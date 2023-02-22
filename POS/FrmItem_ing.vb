Public Class FrmItem_ing

    Private Sub FrmItem_ing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New lqPOSDataContext
            TblItem_IngBindingSource.DataSource = aMainor.tblItem_Ings.ToList
            TblIngredientBindingSource.DataSource = aMainor.tblIngredients.ToList
            TblItemBindingSource.DataSource = aMainor.tblItems.ToList
            TblIngredientBindingSource1.DataSource = aMainor.tblIngredients.ToList
            TblItemBindingSource1.DataSource = aMainor.tblItems.ToList
            TblIngredientBindingSource1.Insert(0, New tblIngredient) 'zid row awal shi fadye
            TblItemBindingSource1.Insert(0, New tblItem) 'zid row awal shi fadye
            ItemComboBox.SelectedIndex = 0 'la7ata bas e3mal run tkun awal we7de fadye
            IngComboBox.SelectedIndex = 0




        End Using
    End Sub

   
    Private Sub ItemComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemComboBox.SelectedIndexChanged, IngComboBox.SelectedIndexChanged
        Using aMainor As New lqPOSDataContext
            Dim ItemID = 0
            Dim IngID = 0
            If ItemComboBox.SelectedValue = 0 And IngComboBox.SelectedValue = 0 Or ItemComboBox.SelectedValue = -1 And IngComboBox.SelectedValue = -1 Then
                ItemID = 0
                IngID = 0
            Else
                ItemID = ItemComboBox.SelectedValue
                IngID = IngComboBox.SelectedValue

            End If
            TblItem_IngBindingSource.DataSource = aMainor.Filter_itemIng(ItemID, IngID).ToList

        End Using
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()

    End Sub
End Class