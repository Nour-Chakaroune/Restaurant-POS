Public Class frmOrder
    Public LastClicked As Integer = 0
    Public InvoiceId As Integer = 0
   


    Private Sub frmOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TblOrderDataGridView.ReadOnly = True
        Using aMainor As New lqPOSDataContext
            TblItemBindingSource.DataSource = aMainor.tblItems.ToList
            If Not InvoiceId = 0 Then
                TblOrderBindingSource.DataSource = (From ax In aMainor.tblOrders Where ax.invoiceId = InvoiceId).ToList()
                For i = 0 To TblOrderBindingSource.Count - 1
                    Dim x As tblOrder = TblOrderBindingSource(i)
                    Dim r As tblItem = (From ax In aMainor.tblItems Where ax.id = x.itemId).ToList(0)
                    Dim total As Decimal = (1 - x.discount / 100) * r.Price * x.quantity
                    TblOrderDataGridView.Rows(i).Cells(totalcolumn.Index).Value = total
                Next
            End If
            Dim res = aMainor.tblCategories.ToList
            For i As Integer = 0 To res.Count - 1
                Dim btn As New Button
                btn.Height = 50
                btn.Width = 100
                btn.Text = res.ToList(i).CategoryName
                btn.Tag = res.ToList(i).id
                AddHandler btn.Click, AddressOf btnClicked
                FlowLayoutPanel1.Controls.Add(btn)
            Next
        End Using

        Using aMainor As New lqPOSDataContext
            Dim total As Decimal = 0
            For i = 0 To TblOrderDataGridView.RowCount - 1
                total += TblOrderDataGridView.Rows(i).Cells(totalcolumn.Index).Value
            Next
            txtPriceTotal.Text = total
        End Using




    End Sub
    Sub btnClicked(ByVal sender As Object, ByVal e As EventArgs)
        FlowLayoutPanel2.Controls.Clear()

        For Each a As Button In FlowLayoutPanel1.Controls
            If a.Tag = LastClicked Then
                a.BackColor = Color.Silver

            End If
        Next

        Dim b As Button = sender
        Dim catId As Integer = b.Tag
        b.BackColor = Color.Aqua
        Using aMainor As New lqPOSDataContext
            Dim res = (From ax In aMainor.tblItems Where ax.CategoryId = catId).ToList
            For i As Integer = 0 To res.Count - 1
                Dim btn As New Button
                btn.Height = 50
                btn.Width = 100
                btn.Text = res.ToList(i).ItemName
                btn.Tag = res.ToList(i).id
                AddHandler btn.Click, AddressOf btnitemClicked
                FlowLayoutPanel2.Controls.Add(btn)
            Next
            LastClicked = catId
        End Using


    End Sub

    Sub btnitemClicked(ByVal sender As Object, ByVal e As EventArgs)
        Using aMainor As New lqPOSDataContext
            Dim ItemId As Integer = sender.Tag
            Dim x As New tblOrder
            x.itemId = ItemId
            x.quantity = 1
            x.discount = 0
            x.invoiceId = InvoiceId
            'TblOrderBindingSource.Add(x)

            aMainor.tblOrders.InsertOnSubmit(x)
            aMainor.SubmitChanges()

            TblOrderBindingSource.DataSource = (From ax In aMainor.tblOrders Where ax.invoiceId = InvoiceId).ToList
            refreshform()

            Dim r As tblItem = (From ax In aMainor.tblItems Where ax.id = ItemId).ToList(0)
            Dim total As Decimal = (1 - x.discount / 100) * r.Price * x.quantity
            TblOrderDataGridView.Rows(TblOrderDataGridView.Rows.Count - 1).Cells(totalcolumn.Index).Value = total


        End Using



    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim answer = MessageBox.Show("are you sure you want to close this", "cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If answer = DialogResult.Yes Then
            Using aMainor As New lqPOSDataContext
                Dim res = (From ax In aMainor.tblInvoices Where ax.id = InvoiceId).ToList(0)
                res.open___close = False
                aMainor.SubmitChanges()
                Dim x As New frmReport
                x.invId = InvoiceId
                x.ShowDialog()
                Me.Close()
            End Using


        End If


    End Sub


    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        Using aMainor As New lqPOSDataContext

            Dim x As tblOrder = TblOrderBindingSource.Current
            Dim res = (From ax In aMainor.tblOrders Where ax.Id = x.Id).ToList(0)
            res.quantity = res.quantity + 1
            aMainor.SubmitChanges()
            refreshform()

        End Using
    End Sub
    Sub refreshform()
        Using aMainor As New lqPOSDataContext
            Dim total As Decimal = 0
            TblOrderBindingSource.DataSource = (From ax In aMainor.tblOrders Where ax.invoiceId = InvoiceId).ToList
            For i = 0 To TblOrderBindingSource.Count - 1
                Dim x As tblOrder = TblOrderBindingSource(i)
                Dim itemId As Integer = x.itemId
                Dim res = (From ax In aMainor.tblItems Where ax.id = itemId Select ax.Price).ToList(0)
                TblOrderDataGridView.Rows(i).Cells(totalcolumn.Index).Value = (1 - x.discount / 100) * res * x.quantity
                TblOrderDataGridView.ReadOnly = True
                total += TblOrderDataGridView.Rows(i).Cells(totalcolumn.Index).Value
            Next
            txtPriceTotal.Text = total
        End Using
    End Sub

    Private Sub btnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMin.Click
        Using aMainor As New lqPOSDataContext
            Dim x As tblOrder = TblOrderBindingSource.Current
            Dim res = (From ax In aMainor.tblOrders Where ax.Id = x.Id).ToList(0)
            If res.quantity > 1 Then
                res.quantity = res.quantity - 1
                aMainor.SubmitChanges()
                refreshform()
            Else
                MessageBox.Show("Cannot")
            End If
        End Using

    End Sub



   

    Private Sub TblOrderDataGridView_ReadOnlyChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblOrderDataGridView.ReadOnlyChanged
        itemcolumn.ReadOnly = True
        itemId.ReadOnly = True
        qtycolumn.ReadOnly = True
        totalcolumn.ReadOnly = True
        withcol.ReadOnly = True
        withoutcol.ReadOnly = True
    End Sub


    Private Sub TblOrderDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblOrderDataGridView.CellEndEdit
        If e.ColumnIndex = discolumn.Index Or e.ColumnIndex = descriptioncol.Index Then
            Using aMainor As New lqPOSDataContext
                Dim id As Integer = TblOrderBindingSource.Current.id
                Dim oldRow = (From ax In aMainor.tblOrders Where ax.Id = id).ToList(0)
                Dim newRow As tblOrder = TblOrderBindingSource.Current
                If newRow.discount <= 100 Then
                    oldRow.discount = newRow.discount
                    oldRow.description = newRow.description
                    aMainor.SubmitChanges()
                Else
                    MessageBox.Show("error")
                End If
            End Using
            refreshform()
        End If
    End Sub

    Private Sub TblOrderDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblOrderDataGridView.CellClick
        TblOrderDataGridView.ReadOnly = False

    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim index As Integer = TblOrderDataGridView.CurrentRow.Index
        If index > 0 Then
            TblOrderDataGridView.Rows(index).Selected = False
            TblOrderDataGridView.Rows(index - 1).Selected = True
            TblOrderDataGridView.CurrentCell = TblOrderDataGridView.Rows(index - 1).Cells(0) 'bala hal ligne m3ash byotla3 ela mara we7de
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim index As Integer = TblOrderDataGridView.CurrentRow.Index
        Dim rowcount As Integer = TblOrderDataGridView.RowCount - 1 'kermel n7aded e5er we7de
        If index < rowcount Then
            TblOrderDataGridView.Rows(index).Selected = False
            TblOrderDataGridView.Rows(index + 1).Selected = True
            TblOrderDataGridView.CurrentCell = TblOrderDataGridView.Rows(index + 1).Cells(0)

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Using aMainor As New lqPOSDataContext

            For i As Integer = 0 To TblOrderBindingSource.Count - 1
                Dim x As tblOrder = TblOrderBindingSource(i)
                If TblOrderDataGridView.Rows(i).Cells(checked.Index).Value = True Then
                    Dim id As Integer = TblOrderBindingSource(i).id
                    Dim res = (From ax In aMainor.tblOrders Where ax.Id = id).ToList(0)
                    Dim a = (From ax In aMainor.tblOrder_Ings Where ax.orderId = res.Id)
                    If a.Count > 0 Then
                        aMainor.tblOrder_Ings.DeleteAllOnSubmit(a)
                        aMainor.SubmitChanges()
                        aMainor.tblOrders.DeleteOnSubmit(res)
                        aMainor.SubmitChanges()
                    Else
                        aMainor.tblOrders.DeleteOnSubmit(res)
                        aMainor.SubmitChanges()
                    End If


                End If
            Next
        End Using
        refreshform()

    End Sub

    Private Sub btnWIth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWIth.Click
        Using aMainor As New lqPOSDataContext
            Dim id As Integer = TblOrderBindingSource.Current.id
            Dim t As Integer = TblOrderBindingSource.Current.itemid
            Dim x As New frmWithWithout
            x.orderID = id
            x.itemID = t
            x.w = True
            x.ShowDialog()
            refreshform()


        End Using
    End Sub

    Private Sub btnWithout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithout.Click
        Using aMainor As New lqPOSDataContext
            Dim id As Integer = TblOrderBindingSource.Current.id
            Dim t As Integer = TblOrderBindingSource.Current.itemid
            Dim x As New frmWithWithout
            x.orderID = id
            x.itemID = t
            x.w = False
            x.ShowDialog()
            refreshform()

        End Using

    End Sub
End Class