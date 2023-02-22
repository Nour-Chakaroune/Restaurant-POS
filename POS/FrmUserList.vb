Public Class FrmUserList

    Private Sub FrmUserList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Using aMainor As New lqPOSDataContext
        ' TblUserBindingSource.DataSource = aMainor.tblUsers.ToList
        TblUserDataGridView.ReadOnly = True
        'End Using
        refreshform()

    End Sub

    Sub refreshform()
        Using aMainor As New lqPOSDataContext
            TblUserBindingSource.DataSource = aMainor.tblUsers.ToList
        End Using
    End Sub

    Private Sub TblUserDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblUserDataGridView.CellContentClick
        Using aMainor As New lqPOSDataContext
            If e.ColumnIndex = Delete.Index Then
                Dim id As Integer = TblUserBindingSource.Current.id
                If id = 0 Then
                    TblUserBindingSource.RemoveCurrent()
                Else
                    Dim res = (From ax In aMainor.tblUsers Where ax.id = id).ToList(0)
                    aMainor.tblUsers.DeleteOnSubmit(res)
                    aMainor.SubmitChanges()
                End If
            End If
            refreshform()

        End Using
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TblUserDataGridView.ReadOnly = False
        TblUserBindingSource.AddNew()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        TblUserDataGridView.ReadOnly = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Using aMainor As New lqPOSDataContext
            For i As Integer = 0 To TblUserBindingSource.Count - 1
                Dim x As tblUser = TblUserBindingSource(i)
                If x.id = 0 Then
                    aMainor.tblUsers.InsertOnSubmit(x)
                    aMainor.SubmitChanges()
                Else
                    Dim id As Integer = x.id
                    Dim oldRow = (From ax In aMainor.tblUsers Where ax.id = id).ToList(0)
                    Dim newRow As tblUser = TblUserBindingSource(i)
                    oldRow.Name = newRow.Name
                    oldRow.Password = newRow.Password
                    aMainor.SubmitChanges()


                End If
            Next
            refreshform()
            TblUserDataGridView.ReadOnly = True

        End Using
    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged, PasswTextBox.TextChanged
        Using aMainor As New lqPOSDataContext
            TblUserBindingSource.DataSource = aMainor.Filter_User(NameTextBox.Text, PasswTextBox.Text).ToList
        End Using
    End Sub
End Class