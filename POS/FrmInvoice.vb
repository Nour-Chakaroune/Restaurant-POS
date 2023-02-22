Public Class FrmInvoice

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim x As New tblInvoice
        x.open___close = True
        x.date_and_time = Date.Now
        x.userId = userId
        Using aMainor As New lqPOSDataContext
            aMainor.tblInvoices.InsertOnSubmit(x)
            aMainor.SubmitChanges()
        End Using
        Dim a As New frmOrder
        a.InvoiceId = x.id
        a.ShowDialog()
        refreshform()

    End Sub

    Private Sub FrmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshform()
    End Sub
    Sub btnClicked(ByVal sender As Object, ByVal e As EventArgs)
        Dim x As New frmOrder
        Dim b As Integer = sender.Tag
        x.InvoiceId = b
        x.ShowDialog()
        refreshform()

    End Sub
    Sub refreshform()
        FlowLayoutPanel1.Controls.Clear()

        Using aMainor As New lqPOSDataContext
            'Dim res = aMainor.tblInvoices.ToList
            Dim res = (From ax In aMainor.tblInvoices Where ax.open___close = True And ax.customerId Is Nothing).ToList
            For i As Integer = 0 To res.Count - 1
                Dim btn As New Button
                btn.Width = 100
                btn.Height = 50
                btn.Text = res.ToList(i).id
                btn.Tag = res.ToList(i).id
                AddHandler btn.Click, AddressOf btnClicked
                FlowLayoutPanel1.Controls.Add(btn)

            Next
        End Using
    End Sub
End Class