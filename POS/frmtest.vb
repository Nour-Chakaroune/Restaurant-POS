Public Class frmtest

    Private Sub frmtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim uc As New UCTest
        uc.myX = 5
        uc.TextBox1.Text = 0
        AddHandler uc.clicked, AddressOf myclicked
        FlowLayoutPanel1.Controls.Add(uc)


  
    End Sub

    Sub myclicked(ByVal oldUC As UCTest)     'bas badde eb3atla shi metel id w te3male sha8le 3a ases hel id bektob sender w ho, bas hal2 ma fi shi eb3atla yeh w badde te3male calcule fa ma fi de3e la sender de8re bektob hek.
        Dim n As Integer = oldUC.TextBox1.Text
        Dim x As String = oldUC.myX
        oldUC.Button1.Visible = False

        Dim newUc As New UCTest
        newUc.TextBox1.Text = n + 1
        newUc.Label1.Text = x + 5
        AddHandler newUc.clicked, AddressOf myclicked
        FlowLayoutPanel1.Controls.Add(newUc)
    End Sub

End Class