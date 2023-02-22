Public Class frmInitial

    Private Sub btnCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategory.Click
        Dim x As New FrmCategory
        x.ShowDialog()

    End Sub

    Private Sub btnItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem.Click
        Dim x As New FrmItemsList
        x.ShowDialog()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()

    End Sub



    Private Sub btnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvoice.Click
        Dim x As New FrmInvoice
        x.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As New frmDelivery
        x.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As New FrmUserList
        x.ShowDialog()

    End Sub

    Private Sub btnIng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIng.Click
        Dim X As New FrmIngredient
        X.ShowDialog()

    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim x As New frmReportItem
        x.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x As New FrmItem_ing
        x.ShowDialog()

    End Sub
End Class
