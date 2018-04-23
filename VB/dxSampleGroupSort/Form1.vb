Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraReports.UI

Namespace dxSampleGroupSort
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub ShowReport()

            CType(New XtraReport1(), XtraReport1).ShowPreview()
        End Sub
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            ShowReport()
        End Sub
    End Class
End Namespace
