Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports System.Linq

Namespace ReportSortHelpers
    Public Class HelpSortItem
        Friend Property Report() As XtraReport
        Friend Property FieldName() As String
        Friend Property Caption() As String
        Friend Property HeaderCell() As XRLabel
        Friend Property Menu() As PopupMenu
        Private _ColumnSortOrder As SortOrder = SortOrder.None
        Private ascendingSortCaptionPrefix As String = "*"
        Private descendingSortCaptionPrefix As String = "**"
        Private ReadOnly Property DataBand() As DetailBand
            Get
                Return CType(Report.Bands.FirstOrDefault(Function(x) TypeOf x Is DetailBand), DetailBand)
            End Get
        End Property
        Public Property Modified() As Boolean
        Friend Property Helper() As ReportColumnSortHelper
        Friend Property ColumnSortOrder() As SortOrder
            Get
                Return _ColumnSortOrder
            End Get
            Set(ByVal value As SortOrder)
                If _ColumnSortOrder = value Then
                    Modified = False
                    Return
                End If
                Modified = True
                _ColumnSortOrder = value
                If value = SortOrder.None Then
                    ClearPrevSorting()
                Else
                    ApplySorting()
                End If
                ResetCaption()
            End Set
        End Property
        Public Sub New(ByVal helper As ReportColumnSortHelper, ByVal cell As XRLabel, ByVal menu As PopupMenu, ByVal fieldName As String, ByVal caption As String, ByVal sortOrder As SortOrder)
            DoInit(helper, helper.Report, cell, menu, fieldName, caption, sortOrder)
        End Sub
        Public Sub New(ByVal helper As ReportColumnSortHelper, ByVal cell As XRLabel, ByVal menu As PopupMenu, ByVal fieldName As String, ByVal caption As String)
            DoInit(helper, helper.Report, cell, menu, fieldName, caption, SortOrder.None)
        End Sub
        Private Sub DoInit(ByVal helper As ReportColumnSortHelper, ByVal report As XtraReport, ByVal cell As XRLabel, ByVal menu As PopupMenu, ByVal fieldName As String, ByVal caption As String, ByVal sortOrder As SortOrder)
            Me.Helper = helper
            Me.Report = report
            HeaderCell = cell
            AddHandler cell.PreviewMouseMove, AddressOf cell_PreviewMouseMove
            AddHandler cell.PreviewMouseDown, AddressOf cell_PreviewMouseDown
            Me.Menu = menu
            Me.FieldName = fieldName
            Me.Caption = caption
            ColumnSortOrder = sortOrder
        End Sub
        Private Sub cell_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs)
            SetHandCursor(e)
        End Sub
        Private Shared Sub SetHandCursor(ByVal e As PreviewMouseEventArgs)
            e.PreviewControl.Cursor = Cursors.Hand
        End Sub
        Private Sub cell_PreviewMouseDown(ByVal sender As Object, ByVal e As PreviewMouseEventArgs)
            If IsMouseButtonPressed(MouseButtons.Right) Then
                InitSortMenu(Control.MousePosition)
            End If
            If IsMouseButtonPressed(MouseButtons.Left) Then
                Helper.HidePopup()
                If Not ShiftKeyHeld() Then
                    Helper.ClearAll(Me, False)
                End If
                Dim newSortOrder As SortOrder = GetSortOrderByLeftClick(ColumnSortOrder)
                ColumnSortOrder = newSortOrder
                RecreateDocument()
            End If
        End Sub

        Private Function ShiftKeyHeld() As Boolean
            Return Control.ModifierKeys = Keys.Shift
        End Function
        Private Function GetSortOrderByLeftClick(ByVal prevSortOrder As SortOrder) As SortOrder
            Return If(prevSortOrder = SortOrder.Descending OrElse prevSortOrder = SortOrder.None, SortOrder.Ascending, SortOrder.Descending)
        End Function
        Private Sub ApplySorting()
            Dim realOrder As XRColumnSortOrder = GetRealSortOrder()
            DoSort(realOrder)
        End Sub
        Private Sub InitSortMenu(ByVal location As System.Drawing.Point)
            CheckMenuItemBySortOrder()
            ShowMenu(location)
        End Sub
        Private Sub CheckMenuItemBySortOrder()
            Dim sortOrder As SortOrder = ColumnSortOrder
            Dim menuItem As BarCheckItemLink = Menu.ItemLinks.OfType(Of BarCheckItemLink)().FirstOrDefault(Function(x) (x.Item.Tag IsNot Nothing AndAlso TypeOf x.Item.Tag Is SortOrder AndAlso CType(x.Item.Tag, SortOrder) = sortOrder))
            TryCast(menuItem.Item, BarCheckItem).Checked = True
        End Sub
        Private Sub ShowMenu(ByVal location As System.Drawing.Point)
            Menu.ShowPopup(location)
        End Sub
        Private Sub ClearPrevSorting()
            If DataBand.SortFields.Count = 0 Then
                Return
            End If
            Dim fToRemove As New List(Of GroupField)()
            For Each field As GroupField In DataBand.SortFields
                If field.FieldName = FieldName Then
                    fToRemove.Add(field)
                End If
            Next field
            If fToRemove.Count = 0 Then
                Return
            End If
            For Each item As GroupField In fToRemove
                DataBand.SortFields.Remove(item)
            Next item
        End Sub
        Private Sub ResetCaption()
            HeaderCell.Text = GetCaptionText()
        End Sub
        Private Sub RecreateDocument()
            Helper.RecreateDocument()
        End Sub
        Private Function GetCaptionText() As String
            Dim result As String = Caption
            Select Case ColumnSortOrder
                Case SortOrder.None
                Case SortOrder.Ascending, SortOrder.Descending
                    result = Caption & " " & GetSortPrefix(ColumnSortOrder)
            End Select
            Return result
        End Function

        Private Function GetRealSortOrder() As XRColumnSortOrder
            Dim result As XRColumnSortOrder = XRColumnSortOrder.Ascending
            Select Case ColumnSortOrder
                Case SortOrder.None, SortOrder.Descending
                    result = XRColumnSortOrder.Descending
                Case SortOrder.Ascending
                    result = XRColumnSortOrder.Ascending
            End Select
            Return result
        End Function

        Private Sub DoSort(ByVal realOrder As XRColumnSortOrder)
            Dim cellSortInfo As HelpSortItem = Me

            Dim fieldName_Renamed As String = cellSortInfo.FieldName
            Dim item As New GroupField(fieldName_Renamed, realOrder)
            Dim groupFieldToRemove As GroupField = DataBand.SortFields.OfType(Of GroupField)().FirstOrDefault(Function(x) x.FieldName = fieldName_Renamed)
            If groupFieldToRemove IsNot Nothing Then
                DataBand.SortFields.Remove(groupFieldToRemove)
            End If
            DataBand.SortFields.Add(item)
        End Sub
        Private Function GetSortPrefix(ByVal newSortOrder As SortOrder) As String
            Return If(newSortOrder = SortOrder.Ascending, ascendingSortCaptionPrefix, descendingSortCaptionPrefix)
        End Function
        Public Function IsMouseButtonPressed(ByVal button As MouseButtons) As Boolean
            Return (Control.MouseButtons And button) = button
        End Function
    End Class
End Namespace
