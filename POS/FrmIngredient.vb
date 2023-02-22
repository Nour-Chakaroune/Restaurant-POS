Public Class FrmIngredient

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub FrmIngredient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TblIngredientDataGridView.ReadOnly = True
        refreshform()

    End Sub
    Sub refreshform()
        Using aMainor As New lqPOSDataContext
            TblIngredientBindingSource.DataSource = aMainor.tblIngredients.ToList
        End Using
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TblIngredientDataGridView.ReadOnly = False
        TblIngredientBindingSource.AddNew()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        TblIngredientDataGridView.ReadOnly = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Using aMainor As New lqPOSDataContext
            For i As Integer = 0 To TblIngredientBindingSource.Count - 1
                Dim x As tblIngredient = TblIngredientBindingSource(i)
                If x.id = 0 Then
                    aMainor.tblIngredients.InsertOnSubmit(x)
                    aMainor.SubmitChanges()
                Else
                    Dim oldRow = (From ax In aMainor.tblIngredients Where ax.id = x.id).ToList(0)
                    Dim newRow As tblIngredient = TblIngredientBindingSource(i)
                    oldRow.IngredientName = newRow.IngredientName
                    oldRow.IngredientPrice = newRow.IngredientPrice
                    aMainor.SubmitChanges()
                End If
            Next
        End Using
        TblIngredientDataGridView.ReadOnly = True

    End Sub

    Private Sub TblIngredientDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblIngredientDataGridView.CellContentClick
        If e.ColumnIndex = Delete.Index Then
            Using aMainor As New lqPOSDataContext
                Dim id As Integer = TblIngredientBindingSource.Current.id
                If id = 0 Then
                    TblIngredientBindingSource.RemoveCurrent()
                Else
                    Dim n = (From ax In aMainor.tblItem_Ings Where ax.IngId = id).ToList
                    If n.Count > 0 Then
                        MessageBox.Show("Cannot delete")
                    Else
                        Dim res = (From ax In aMainor.tblIngredients Where ax.id = id).ToList(0)
                        aMainor.tblIngredients.DeleteOnSubmit(res)
                        aMainor.SubmitChanges()
                        refreshform()
                    End If
                End If

            End Using

        End If
    End Sub
End Class