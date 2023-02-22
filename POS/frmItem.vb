Public Class frmItem
    Public id As Integer = 0
    Public saved As Boolean = False



    Sub refreshform()
        Using aMainor As New lqPOSDataContext
            TblItemBindingSource.DataSource = aMainor.tblItems.ToList
        End Using
    End Sub

    Private Sub frmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New lqPOSDataContext
            Dim res = aMainor.tblIngredients.ToList
            For i As Integer = 0 To res.Count - 1
                Dim check As New CheckBox
                check.Text = res.ToList(i).IngredientName
                check.Tag = res.ToList(i).id
                FlowLayoutPanel1.Controls.Add(check)
            Next
            TblCategoryBindingSource.DataSource = aMainor.tblCategories.ToList
            If id = 0 Then

                TblItemBindingSource.DataSource = New tblItem 'add new row
            Else
                TblItemBindingSource.DataSource = (From ax In aMainor.tblItems Where ax.id = id).ToList(0)
                Dim r = (From ax In aMainor.tblItem_Ings Where ax.ItemId = id).ToList
                If r.Count > 0 Then
                    For i As Integer = 0 To r.Count - 1
                        For Each c As CheckBox In FlowLayoutPanel1.Controls
                            If c.Tag = r.ToList(i).IngId Then
                                c.Checked = True
                            End If
                        Next
                    Next
                   

                End If
            End If




        End Using
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Using aMainor As New lqPOSDataContext
            If id = 0 Then
                aMainor.tblItems.InsertOnSubmit(TblItemBindingSource.Current)
                aMainor.SubmitChanges()
                id = TblItemBindingSource.Current.id
            Else
                Dim oldRow As tblItem = (From ax In aMainor.tblItems Where ax.id = id).ToList(0)
                Dim newRow As tblItem = TblItemBindingSource.Current

                oldRow.CategoryId = newRow.CategoryId
                oldRow.ItemName = newRow.ItemName
                oldRow.Price = newRow.Price

                aMainor.SubmitChanges()

            End If

            For Each c As CheckBox In FlowLayoutPanel1.Controls
                If c.Checked = True Then
                    Dim x As New tblItem_Ing
                    x.IngId = c.Tag
                    x.ItemId = id
                    aMainor.tblItem_Ings.InsertOnSubmit(x)
                    aMainor.SubmitChanges()
                End If
            Next
         
            saved = True
            Me.Close()
        End Using
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()

    End Sub


End Class