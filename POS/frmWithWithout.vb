Public Class frmWithWithout
    Public orderID As Integer = 0
    Public itemID As Integer = 0
    Public w As Boolean = True



    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub frmWithWithout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If w Then
            Label1.Text = "With"
        Else
            Label1.Text = "Without"
        End If
        Using aMainor As New lqPOSDataContext
            Dim t = (From ax In aMainor.tblItem_Ings Where ax.ItemId = itemID).ToList
            If t.Count > 0 Then
                For i As Integer = 0 To t.Count - 1
                    Dim check As New CheckBox
                    Dim n As Integer = t.ToList(i).IngId
                    Dim r = (From ax In aMainor.tblIngredients Where ax.id = n).ToList(0)

                    check.Text = r.IngredientName

                    'check.Text = t.ToList(i).IngId
                    check.Tag = t.ToList(i).IngId
                    FlowLayoutPanel1.Controls.Add(check)

                Next
            End If
            Dim order = (From ax In aMainor.tblOrder_Ings Where ax.orderId = orderID And ax.with_without = w).ToList
            If order.Count > 0 Then
                For i As Integer = 0 To order.Count - 1
                    For Each c As CheckBox In FlowLayoutPanel1.Controls
                        If c.Tag = order.ToList(i).ingId Then
                            c.Checked = True

                        End If
                    Next
                Next

            End If

        End Using
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Using aMainor As New lqPOSDataContext

            Dim r = (From ax In aMainor.tblOrder_Ings Where ax.orderId = orderID And ax.with_without = w).ToList
            aMainor.tblOrder_Ings.DeleteAllOnSubmit(r)

            Dim desc As String = ""
            Dim descrp As String = ""

            For Each c As CheckBox In FlowLayoutPanel1.Controls
                If c.Checked = True Then
                    Dim x As New tblOrder_Ing
                    x.orderId = orderID
                    x.with_without = w
                    x.ingId = c.Tag
                    aMainor.tblOrder_Ings.InsertOnSubmit(x)
                    aMainor.SubmitChanges()

                    If w Then
                        desc = desc + " " + c.Text
                    Else
                        descrp = descrp + " " + c.Text
                    End If


                End If

            Next

            Dim oldRow = (From ax In aMainor.tblOrders Where ax.Id = orderID).ToList(0)
            If w Then

                oldRow.With = desc
                aMainor.SubmitChanges()

            Else
                oldRow.Without = descrp
                aMainor.SubmitChanges()

            End If


        End Using
        Me.Close()
    End Sub
End Class