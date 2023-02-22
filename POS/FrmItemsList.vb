Public Class FrmItemsList

    Private Sub FrmItemsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TblItemDataGridView.ReadOnly = True
        Using aMainor As New lqPOSDataContext
            TblItemBindingSource.DataSource = aMainor.tblItems.ToList
            TblCategoryBindingSource.DataSource = aMainor.tblCategories.ToList
            TblCategoryBindingSource1.DataSource = (From ax In aMainor.tblCategories Order By ax.CategoryName Ascending).ToList 'y7oton bl tertib
            TblCategoryBindingSource1.Insert(0, New tblCategory)
            CategoryIdComboBox.SelectedIndex = 0
        End Using

        refreshform()
    End Sub


    Sub refreshform()
        Using aMainor As New lqPOSDataContext
            TblItemBindingSource.DataSource = aMainor.tblItems.ToList
        End Using
    End Sub

    Private Sub TblItemDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblItemDataGridView.CellContentClick

        Using aMainor As New lqPOSDataContext
            If e.ColumnIndex = Delete.Index Then
                Dim id As Integer = TblItemBindingSource.Current.id
                Dim n = (From ax In aMainor.tblOrders Where ax.itemId = id).ToList
                If n.Count > 0 Then
                    MessageBox.Show("Cannot Delete")
                Else
                    Dim res = (From ax In aMainor.tblItems Where ax.id = id).ToList(0)
                    aMainor.tblItems.DeleteOnSubmit(res)
                    aMainor.SubmitChanges()
                    refreshform()
                End If
               
            End If
            If e.ColumnIndex = Edit.Index Then
                Dim x As New frmItem
                x.id = TblItemBindingSource.Current.id 'li2anno x. fa hayde l id li mawjude bl form frmitem fa lezem zid id bl awal 3l form
                x.ShowDialog()
                If x.saved = True Then
                    refreshform()
                End If

            End If
        End Using
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim x As New frmItem
        x.ShowDialog()
        If x.saved = True Then
            refreshform()
        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()

    End Sub

    
    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged, CategoryIdComboBox.TextChanged
        Using aMainor As New lqPOSDataContext
            Dim CatId As Integer = 0
            If CategoryIdComboBox.SelectedIndex = 0 Or CategoryIdComboBox.SelectedIndex = -1 Then
                CatId = 0
            Else
                CatId = CategoryIdComboBox.SelectedValue
            End If
            TblItemBindingSource.DataSource = aMainor.Filter_item(NameTextBox.Text, CatId).ToList
        End Using
    End Sub
End Class