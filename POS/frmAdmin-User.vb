Public Class frmAdmin_user

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        Using aMainor As New lqPOSDataContext
            Dim res = (From ax In aMainor.tblAdmins Where ax.AdminName = txtName.Text And ax.AdminPassword = txtPass.Text).ToList
            If res.Count = 0 Then
                MessageBox.Show("error")
                txtName.Clear()
                txtPass.Clear()

            Else
                Dim x As New frmInitial
                x.ShowDialog()
                txtName.Clear()
                txtPass.Clear()

            End If
        End Using
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        Using aMainor As New lqPOSDataContext
            Dim res = (From ax In aMainor.tblUsers Where ax.Name = txtName.Text And ax.Password = txtPass.Text).ToList
            If res.Count = 0 Then
                MessageBox.Show("error")
                txtName.Clear()
                txtPass.Clear()

            Else
                userId = res.ToList(0).id
                Dim x As New FrmUserInitial
                x.ShowDialog()
                txtName.Clear()
                txtPass.Clear()

            End If
        End Using

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()

    End Sub

    Private Sub frmAdmin_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class