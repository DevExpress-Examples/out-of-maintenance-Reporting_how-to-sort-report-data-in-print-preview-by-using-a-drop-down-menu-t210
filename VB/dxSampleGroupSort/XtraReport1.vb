Imports System
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports ReportSortHelpers

Namespace dxSampleGroupSort
    Partial Public Class XtraReport1
        Inherits XtraReport

        Private sortHelper As ReportColumnSortHelper
        Public Sub New()
            InitializeComponent()
            sortHelper = New ReportColumnSortHelper(Me)
        End Sub
        Private Sub lblClearSorting_PreviewMouseDown(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles lblClearSorting.PreviewMouseDown
            ClearAll()
        End Sub
        Private Sub ClearAll()
            sortHelper.ClearAll(Nothing)
        End Sub
        Private Sub lblClearSorting_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles lblClearSorting.PreviewMouseMove
            SetHandCursor(e)
        End Sub
        Private Shared Sub SetHandCursor(ByVal e As PreviewMouseEventArgs)
            e.PreviewControl.Cursor = Cursors.Hand
        End Sub

        Private Sub xrPanel1_PreviewMouseDown(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrPanel1.PreviewMouseDown, xrPanel2.PreviewMouseDown
            sortHelper.HidePopup()
        End Sub

    End Class
End Namespace
