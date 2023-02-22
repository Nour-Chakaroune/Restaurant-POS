Public Class frmCustomer

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshform()
        TblCustomerDataGridView.ReadOnly = True

    End Sub
    Sub refreshform()

        Using aMainor As New lqPOSDataContext
            TblCustomerBindingSource.DataSource = aMainor.tblCustomers.ToList

        End Using


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TblCustomerDataGridView.ReadOnly = False
        TblCustomerBindingSource.AddNew()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        TblCustomerDataGridView.ReadOnly = False
    End Sub

    Private Sub brnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnSave.Click
        For i As Integer = 0 To TblCustomerBindingSource.Count - 1
            Dim x As tblCustomer = TblCustomerBindingSource(i)
            Using aMainor As New lqPOSDataContext
                If x.id = 0 Then
                    aMainor.tblCustomers.InsertOnSubmit(x)
                    aMainor.SubmitChanges()
                Else
                    Dim id As Integer = x.id
                    Dim oldRow = (From ax In aMainor.tblCustomers Where ax.id = id).ToList(0)
                    Dim newRow As tblCustomer = TblCustomerBindingSource(i)
                    oldRow.Customer = newRow.Customer
                    oldRow.Address = newRow.Address
                    oldRow.Phone = newRow.Phone
                    aMainor.SubmitChanges()


                End If
            End Using
        Next
        TblCustomerDataGridView.ReadOnly = True
    End Sub

    Private Sub TblCustomerDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblCustomerDataGridView.CellContentClick
        Using aMainor As New lqPOSDataContext
            If e.ColumnIndex = Delete.Index Then
                Dim id As Integer = TblCustomerBindingSource.Current.id
                If id = 0 Then
                    TblCustomerBindingSource.RemoveCurrent()
                Else
                    Dim n = (From ax In aMainor.tblInvoices Where ax.customerId = id).ToList
                    If n.Count > 0 Then
                        MessageBox.Show("Cannot delete")
                    Else
                        Dim result = (From ax In aMainor.tblCustomers Where ax.id = id).ToList(0)
                        aMainor.tblCustomers.DeleteOnSubmit(result)
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

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Using aMainor As New lqPOSDataContext
    '        Dim id As Integer = TblCustomerBindingSource.Current.id
    '        Dim x As New tblInvoice
    '        x.open___close = True
    '        x.date_and_time = Date.Now
    '        x.userId = userId
    '        x.customerId = id
    '        aMainor.tblInvoices.InsertOnSubmit(x)
    '        aMainor.SubmitChanges()
    '        Dim a As New frmOrder
    '        a.InvoiceId = x.id
    '        a.ShowDialog()


    '    End Using
    'End Sub

    Private Sub TblCustomerDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblCustomerDataGridView.DoubleClick
        Using aMainor As New lqPOSDataContext
            Dim id As Integer = TblCustomerBindingSource.Current.id
            Dim res = (From ax In aMainor.tblInvoices Where ax.customerId = id And ax.open___close = True).ToList
            Dim invoiceID = 0

            If res.Count > 0 Then
                invoiceID = res.ToList(0).id

            Else
                Dim x As New tblInvoice
                x.open___close = True
                x.date_and_time = Date.Now
                x.userId = userId
                x.customerId = id
                aMainor.tblInvoices.InsertOnSubmit(x)
                aMainor.SubmitChanges()
                invoiceID = x.id
            End If
           
            Dim a As New frmOrder
            a.InvoiceId = invoiceID
            a.ShowDialog()


        End Using
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerTextBox.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged
        Using aMainor As New lqPOSDataContext
            TblCustomerBindingSource.DataSource = aMainor.Filter_Customer(CustomerTextBox.Text, TextBox2.Text, TextBox3.Text).ToList
        End Using


    End Sub
End Class