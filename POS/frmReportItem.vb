Public Class frmReportItem
    Dim loaded As Boolean = False
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub frmReportItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using aMainor As New lqPOSDataContext
            CheckBox1.CheckState = CheckState.Indeterminate 'kermel l check awal shi ma teje la true wala false
            View_OrderInvoiceItemBindingSource.DataSource = aMainor.View_OrderInvoiceItems.ToList
            For i As Integer = 0 To View_OrderInvoiceItemBindingSource.Count - 1
                Dim x As View_OrderInvoiceItem = View_OrderInvoiceItemBindingSource(i)
                '    If x.open___close = False Then
                '        View_OrderInvoiceItemDataGridView.Rows(i).Cells(check.Index).Value = True
                '    Else
                '        View_OrderInvoiceItemDataGridView.Rows(i).Cells(check.Index).Value = False

                ' End If
                Dim total As Decimal = (1 - x.discount / 100) * x.quantity * x.Price
                View_OrderInvoiceItemDataGridView.Rows(i).Cells(TotalCol.Index).Value = total

            Next

            loaded = True
        End Using
    End Sub

    Private Sub txtItemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemName.TextChanged, CheckBox1.CheckStateChanged
        If loaded Then
            Using aMainor As New lqPOSDataContext
                Dim checked As Boolean? = Nothing '? kermel e7timel telet la true wala false
                If CheckBox1.CheckState = 2 Then
                    checked = Nothing
                Else
                    checked = CheckBox1.Checked
                End If

                View_OrderInvoiceItemBindingSource.DataSource = aMainor.Filter_ReprotIemOrder(txtItemName.Text, checked).ToList

                For i As Integer = 0 To View_OrderInvoiceItemBindingSource.Count - 1
                    Dim x As Filter_ReprotIemOrderResult = View_OrderInvoiceItemBindingSource(i)

                    Dim total As Decimal = (1 - x.discount / 100) * x.quantity * x.Price
                    View_OrderInvoiceItemDataGridView.Rows(i).Cells(TotalCol.Index).Value = total

                Next
            End Using
        End If
    End Sub

    Private Sub View_OrderInvoiceItemDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_OrderInvoiceItemDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using aMainor As New lqPOSDataContext


            Dim x As New FrmReportOrder2

            Dim checked As Boolean? = Nothing '? kermel e7timel telet la true wala false
            If CheckBox1.CheckState = 2 Then
                checked = Nothing
            Else
                checked = CheckBox1.Checked
            End If
            x.View_OrderInvoiceItemBindingSource.DataSource = View_OrderInvoiceItemBindingSource.DataSource
            x.ShowDialog()
        End Using
    End Sub
End Class