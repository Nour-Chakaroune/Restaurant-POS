Public Class FrmUC

    Private Sub FrmUC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As New UC
        ' x.s = 0
        x.TextBox1.Text = 1
        AddHandler x.clicked, AddressOf myclicked
        FlowLayoutPanel1.Controls.Add(x)


    End Sub
    Sub myclicked(ByVal old As UC)
        Dim n As Integer = old.TextBox1.Text
        Dim m As Integer = old.s
        old.Button1.Visible = False
        Dim newUC As New UC
        newUC.TextBox1.Text = n + 1
        newUC.s = m + 5
        AddHandler newUC.clicked, AddressOf myclicked
        FlowLayoutPanel1.Controls.Add(newUC)


    End Sub
End Class