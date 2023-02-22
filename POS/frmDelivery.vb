Public Class frmDelivery

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub frmDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshform()

    End Sub
    Sub refreshform()
        FlowLayoutPanel1.Controls.Clear()
        Using aMainor As New lqPOSDataContext
            Dim res = (From ax In aMainor.tblInvoices Where ax.open___close = True And ax.customerId <> 0).ToList
            For i As Integer = 0 To res.Count - 1
                Dim btn As New Button
                btn.Height = 50
                btn.Width = 100
                Dim n As Integer = res.ToList(i).customerId
                Dim m = (From ax In aMainor.tblCustomers Where ax.id = n).ToList(0)
                btn.Text = m.Customer
                'btn.Text = res.ToList(i).id
                btn.Tag = res.ToList(i).id
                AddHandler btn.Click, AddressOf btnClicked
                FlowLayoutPanel1.Controls.Add(btn)

            Next
        End Using
    End Sub

    Private Sub btnNewDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDelivery.Click
        Dim x As New frmCustomer
        x.ShowDialog()
        refreshform()


    End Sub
    Sub btnClicked(ByVal sender As Object, ByVal e As EventArgs)
        Dim x As New frmOrder
        Dim b As Integer = sender.Tag
        x.InvoiceId = b
        x.ShowDialog()
        refreshform()

    End Sub
End Class