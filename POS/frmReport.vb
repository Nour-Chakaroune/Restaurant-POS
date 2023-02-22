Public Class frmReport
    Public invId As Integer = 0

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New lqPOSDataContext
            View_orderItemBindingSource.DataSource = (From ax In aMainor.View_orderItems Where ax.invoiceId = invId).ToList
            Dim res = (From ax In aMainor.tblInvoices Where ax.id = invId).ToList(0)
            ' Date_and_timeLabel1.Text = res.date_and_time
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("date", res.date_and_time))
        End Using
        Me.ReportViewer1.RefreshReport()
    End Sub

   
    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class