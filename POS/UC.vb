Public Class UC
    Public s As Integer = 0
    Event clicked(ByVal sender As UC)

    Private Sub UC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = s

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RaiseEvent clicked(Me)

    End Sub
End Class
