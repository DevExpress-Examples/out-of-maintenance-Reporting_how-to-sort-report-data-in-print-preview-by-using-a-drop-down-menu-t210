Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports System.Linq
Imports DevExpress.Utils.Win

Namespace ReportSortHelpers
    Public Class ReportColumnSortHelper
        Private Menu As PopupMenu
        Private _sortPrefix As String = "Sort_"
        Private ClickedItem As HelpSortItem
        Private sortItems As List(Of HelpSortItem)
        Friend Property Report() As XtraReport

        Public Sub New(ByVal report As XtraReport)
            Me.Report = report
            Menu = Menu_InitSortMenu()
            AddHandler Menu.Popup, AddressOf Menu_Popup

            Dim sortCells As New List(Of XRLabel)()
            sortItems = New List(Of HelpSortItem)()
            InitHeaderCells(sortCells)
        End Sub

        Private Sub Menu_Popup(ByVal sender As Object, ByVal e As EventArgs)
            Dim popupcontrol As IPopupControl = TryCast(sender, IPopupControl)
        End Sub
        Private Function Menu_InitSortMenu() As PopupMenu
            Dim manager As New BarManager()
            Dim sortMenu As New PopupMenu()
            AddHandler manager.ItemClick, AddressOf manager_ItemClick
            sortMenu.Manager = manager
            Dim item1 As BarCheckItem = Menu_InitSortItem(SortOrder.None)
            Dim item2 As BarCheckItem = Menu_InitSortItem(SortOrder.Ascending)
            Dim item3 As BarCheckItem = Menu_InitSortItem(SortOrder.Descending)
            item3.GroupIndex = 1
            item2.GroupIndex = item3.GroupIndex
            item1.GroupIndex = item2.GroupIndex
            sortMenu.AddItems(New BarItem() { item1, item2, item3 })
            Return sortMenu
        End Function
        Private Shared Function Menu_InitSortItem(ByVal sortMode As SortOrder) As BarCheckItem
            Dim itemNone As New BarCheckItem()
            itemNone.Width = 100
            itemNone.Tag = sortMode
            itemNone.Caption = itemNone.Tag.ToString()
            itemNone.CheckBoxVisibility = CheckBoxVisibility.BeforeText
            Return itemNone
        End Function

        Private Sub InitHeaderCells(ByVal sortCells As List(Of XRLabel))
            PopulateHeaderCells(sortCells)
            For Each lbl As XRLabel In sortCells
                Dim fieldName As String = lbl.Tag.ToString().Substring(lbl.Tag.ToString().IndexOf("_"c) + 1)
                Dim caption As String = lbl.Text
                Dim item As New HelpSortItem(Me, lbl, Menu, fieldName, caption)
                sortItems.Add(item)
                AddHandler lbl.PreviewMouseDown, AddressOf lbl_PreviewMouseDown
            Next lbl
        End Sub
        Private Sub lbl_PreviewMouseDown(ByVal sender As Object, ByVal e As PreviewMouseEventArgs)
            Dim clickedCell As XRLabel = TryCast(sender, XRLabel)
            ClickedItem = CType(sortItems.FirstOrDefault(Function(x) x.HeaderCell Is clickedCell), HelpSortItem)
        End Sub
        Private Sub PopulateHeaderCells(ByVal sortCells As List(Of XRLabel))
            Dim allControls As IEnumerable(Of XRLabel) = GetAllReportControls()
            Dim cells = From c In allControls _
                        Where c.Tag IsNot Nothing AndAlso c.Tag.ToString().StartsWith(_sortPrefix) _
                        Select c
            sortCells.AddRange(cells.ToList())
        End Sub
        Private Function GetAllReportControls() As IEnumerable(Of XRLabel)
            Return Report.AllControls(Of XRLabel)()
        End Function

        Private Sub manager_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim clickedMenuItem As BarItem = e.Item
            Dim item As HelpSortItem = Nothing
            If clickedMenuItem IsNot Nothing AndAlso clickedMenuItem.Tag IsNot Nothing AndAlso TypeOf clickedMenuItem.Tag Is SortOrder Then
                item = ClickedItem
                Dim newSortOrder As SortOrder = CType(clickedMenuItem.Tag, SortOrder)
                item.ColumnSortOrder = newSortOrder
            End If
            If item IsNot Nothing AndAlso item.Modified Then
                RecreateDocument()
            End If
        End Sub
        Friend Sub RecreateDocument()
            Report.CreateDocument()
        End Sub
        Public Function IsMouseButtonPressed(ByVal button As MouseButtons) As Boolean
            Return (Control.MouseButtons And button) = button
        End Function
        Friend Sub ResetItemsCaption(ByVal actualItem As HelpSortItem)
            Dim order As SortOrder = SortOrder.None
            For Each item As HelpSortItem In sortItems
                If actualItem IsNot Nothing AndAlso item Is actualItem Then
                    Continue For
                Else
                    item.ColumnSortOrder = order
                End If
            Next item
        End Sub
        Private Sub ClearSorting()
            Dim dataBand As DetailBand = GetDataBand()
            dataBand.SortFields.Clear()
        End Sub
        Private Function GetDataBand() As DetailBand
            Return CType(Report.Bands.FirstOrDefault(Function(x) TypeOf x Is DetailBand), DetailBand)
        End Function
        Public Sub ClearAll(ByVal actualItem As HelpSortItem)
            ClearAll(actualItem, True)
        End Sub
        Public Sub ClearAll(ByVal actualItem As HelpSortItem, ByVal refreshDocument As Boolean)
            ClearSorting()
            ResetItemsCaption(actualItem)
            If refreshDocument Then
                RecreateDocument()
            End If
        End Sub
        Public Sub HidePopup()
            If Menu.Opened Then
                Menu.HidePopup()
            End If

        End Sub
    End Class
End Namespace
