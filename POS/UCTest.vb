Public Class UCTest
    Public myX As Integer = 0
    Event clicked(ByVal sender As UCTest)

    Private Sub UCTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New lqPOSDataContext
            TblCategoryBindingSource.DataSource = aMainor.tblCategories.ToList
        End Using

        ' TextBox1.Text = 0
        Label1.Text = myX
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RaiseEvent clicked(Me)
    End Sub
End Class
