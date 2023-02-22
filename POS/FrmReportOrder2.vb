Public Class FrmReportOrder2
    Public id As Integer = 0
    Private Sub FrmReportOrder2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load
        Using aMainor As New lqPOSDataContext

        End Using
    End Sub
End Class