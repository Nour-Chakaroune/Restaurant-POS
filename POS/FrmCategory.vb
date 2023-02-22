Public Class FrmCategory

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TblCategoryDataGridView.ReadOnly = False
        TblCategoryBindingSource.AddNew()

    End Sub

    Private Sub FrmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshform()
        TblCategoryDataGridView.ReadOnly = True


    End Sub

    Sub refreshform()

        Using aMainor As New lqPOSDataContext
            TblCategoryBindingSource.DataSource = aMainor.tblCategories.ToList

        End Using



    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        TblCategoryDataGridView.ReadOnly = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        For i As Integer = 0 To TblCategoryBindingSource.Count - 1
            Dim x As tblCategory = TblCategoryBindingSource(i)
            Using aMainor As New lqPOSDataContext
                If x.id = 0 Then
                    aMainor.tblCategories.InsertOnSubmit(x)
                    aMainor.SubmitChanges()
                Else
                    Dim id As Integer = x.id
                    Dim oldRow = (From ax In aMainor.tblCategories Where ax.id = id).ToList(0)
                    Dim newRow As tblCategory = TblCategoryBindingSource(i)
                    oldRow.CategoryName = newRow.CategoryName
                    aMainor.SubmitChanges()


                End If
            End Using
        Next
        TblCategoryDataGridView.ReadOnly = True
    End Sub

    Private Sub TblCategoryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblCategoryDataGridView.CellContentClick
        Using aMainor As New lqPOSDataContext
            If e.ColumnIndex = delete.Index Then
                Dim id As Integer = TblCategoryBindingSource.Current.id
                If id = 0 Then
                    TblCategoryBindingSource.RemoveCurrent()
                Else
                    Dim n = (From ax In aMainor.tblItems Where ax.CategoryId = id).ToList
                    If n.Count > 0 Then
                        MessageBox.Show("Cannot delete")
                    Else
                        Dim result = (From ax In aMainor.tblCategories Where ax.id = id).ToList(0)
                        aMainor.tblCategories.DeleteOnSubmit(result)
                        aMainor.SubmitChanges()
                        refreshform()

                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class