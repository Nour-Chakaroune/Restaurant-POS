<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.txtPriceTotal = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnWIth = New System.Windows.Forms.Button()
        Me.btnWithout = New System.Windows.Forms.Button()
        Me.ItemCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QtyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Totalcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Without = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.itemcolumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.qtycolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.discolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalcolumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriptioncol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.withcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.withoutcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.TblItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(44, 565)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(581, 225)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(631, 565)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(543, 225)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1920, 74)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ORDER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(1866, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 46)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "X"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Firebrick
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(1274, 734)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(170, 56)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.LightGray
        Me.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlus.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPlus.Location = New System.Drawing.Point(27, 52)
        Me.btnPlus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 38)
        Me.btnPlus.TabIndex = 0
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMin.Location = New System.Drawing.Point(26, 110)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(73, 38)
        Me.btnMin.TabIndex = 1
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'txtPriceTotal
        '
        Me.txtPriceTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriceTotal.Location = New System.Drawing.Point(23, 50)
        Me.txtPriceTotal.Name = "txtPriceTotal"
        Me.txtPriceTotal.Size = New System.Drawing.Size(140, 32)
        Me.txtPriceTotal.TabIndex = 17
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(1274, 639)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 56)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnWIth
        '
        Me.btnWIth.BackColor = System.Drawing.Color.Firebrick
        Me.btnWIth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWIth.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWIth.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWIth.Location = New System.Drawing.Point(1274, 549)
        Me.btnWIth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnWIth.Name = "btnWIth"
        Me.btnWIth.Size = New System.Drawing.Size(170, 56)
        Me.btnWIth.TabIndex = 6
        Me.btnWIth.Text = "WITH"
        Me.btnWIth.UseVisualStyleBackColor = False
        '
        'btnWithout
        '
        Me.btnWithout.BackColor = System.Drawing.Color.Firebrick
        Me.btnWithout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithout.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWithout.Location = New System.Drawing.Point(1274, 460)
        Me.btnWithout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnWithout.Name = "btnWithout"
        Me.btnWithout.Size = New System.Drawing.Size(170, 56)
        Me.btnWithout.TabIndex = 7
        Me.btnWithout.Text = "WITHOUT"
        Me.btnWithout.UseVisualStyleBackColor = False
        '
        'ItemCol
        '
        Me.ItemCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemCol.DataPropertyName = "itemId"
        Me.ItemCol.DataSource = Me.TblItemBindingSource
        Me.ItemCol.DisplayMember = "ItemName"
        Me.ItemCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ItemCol.HeaderText = "Item Name"
        Me.ItemCol.Name = "ItemCol"
        Me.ItemCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ItemCol.ValueMember = "id"
        '
        'TblItemBindingSource
        '
        Me.TblItemBindingSource.DataSource = GetType(POS.tblItem)
        '
        'QtyCol
        '
        Me.QtyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QtyCol.DataPropertyName = "quantity"
        Me.QtyCol.HeaderText = "quantity"
        Me.QtyCol.Name = "QtyCol"
        '
        'itemId
        '
        Me.itemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemId.DataPropertyName = "itemId"
        Me.itemId.DataSource = Me.TblItemBindingSource
        Me.itemId.DisplayMember = "Price"
        Me.itemId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.itemId.HeaderText = "price"
        Me.itemId.Name = "itemId"
        Me.itemId.ValueMember = "id"
        '
        'discount
        '
        Me.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.discount.HeaderText = "discount"
        Me.discount.Name = "discount"
        Me.discount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Totalcol
        '
        Me.Totalcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Totalcol.HeaderText = "Total"
        Me.Totalcol.Name = "Totalcol"
        '
        'descCol
        '
        Me.descCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descCol.DataPropertyName = "description"
        Me.descCol.HeaderText = "description"
        Me.descCol.Name = "descCol"
        '
        'check
        '
        Me.check.HeaderText = "check"
        Me.check.Name = "check"
        '
        'Without
        '
        Me.Without.DataPropertyName = "Without"
        Me.Without.HeaderText = "Without"
        Me.Without.Name = "Without"
        '
        'TblOrderDataGridView
        '
        Me.TblOrderDataGridView.AllowUserToAddRows = False
        Me.TblOrderDataGridView.AllowUserToDeleteRows = False
        Me.TblOrderDataGridView.AutoGenerateColumns = False
        Me.TblOrderDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TblOrderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblOrderDataGridView.ColumnHeadersHeight = 40
        Me.TblOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemcolumn, Me.qtycolumn, Me.Price, Me.discolumn, Me.totalcolumn, Me.descriptioncol, Me.withcol, Me.withoutcol, Me.checked})
        Me.TblOrderDataGridView.DataSource = Me.TblOrderBindingSource
        Me.TblOrderDataGridView.Location = New System.Drawing.Point(44, 110)
        Me.TblOrderDataGridView.Name = "TblOrderDataGridView"
        Me.TblOrderDataGridView.ReadOnly = True
        Me.TblOrderDataGridView.RowTemplate.Height = 24
        Me.TblOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblOrderDataGridView.Size = New System.Drawing.Size(1130, 433)
        Me.TblOrderDataGridView.TabIndex = 0
        '
        'itemcolumn
        '
        Me.itemcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemcolumn.DataPropertyName = "itemId"
        Me.itemcolumn.DataSource = Me.TblItemBindingSource
        Me.itemcolumn.DisplayMember = "ItemName"
        Me.itemcolumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.itemcolumn.HeaderText = "Item"
        Me.itemcolumn.Name = "itemcolumn"
        Me.itemcolumn.ReadOnly = True
        Me.itemcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itemcolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.itemcolumn.ValueMember = "id"
        '
        'qtycolumn
        '
        Me.qtycolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.qtycolumn.DataPropertyName = "quantity"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.qtycolumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.qtycolumn.HeaderText = "Quantity"
        Me.qtycolumn.Name = "qtycolumn"
        Me.qtycolumn.ReadOnly = True
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Price.DataPropertyName = "itemId"
        Me.Price.DataSource = Me.TblItemBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle6
        Me.Price.DisplayMember = "Price"
        Me.Price.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.ValueMember = "id"
        '
        'discolumn
        '
        Me.discolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.discolumn.DataPropertyName = "discount"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.discolumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.discolumn.HeaderText = "Discount"
        Me.discolumn.Name = "discolumn"
        Me.discolumn.ReadOnly = True
        '
        'totalcolumn
        '
        Me.totalcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.totalcolumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.totalcolumn.HeaderText = "Total"
        Me.totalcolumn.Name = "totalcolumn"
        Me.totalcolumn.ReadOnly = True
        '
        'descriptioncol
        '
        Me.descriptioncol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descriptioncol.DataPropertyName = "description"
        Me.descriptioncol.HeaderText = "Description"
        Me.descriptioncol.Name = "descriptioncol"
        Me.descriptioncol.ReadOnly = True
        '
        'withcol
        '
        Me.withcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.withcol.DataPropertyName = "With"
        Me.withcol.HeaderText = "With"
        Me.withcol.Name = "withcol"
        Me.withcol.ReadOnly = True
        '
        'withoutcol
        '
        Me.withoutcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.withoutcol.DataPropertyName = "Without"
        Me.withoutcol.HeaderText = "Without"
        Me.withoutcol.Name = "withoutcol"
        Me.withoutcol.ReadOnly = True
        '
        'checked
        '
        Me.checked.HeaderText = "Checked"
        Me.checked.Name = "checked"
        Me.checked.ReadOnly = True
        '
        'TblOrderBindingSource
        '
        Me.TblOrderBindingSource.DataSource = GetType(POS.tblOrder)
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDown.BackgroundImage = Global.POS.My.Resources.Resources.up_arrow_png_52961__2_
        Me.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDown.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDown.Location = New System.Drawing.Point(1226, 352)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(57, 36)
        Me.btnDown.TabIndex = 4
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUp.BackgroundImage = Global.POS.My.Resources.Resources.up_arrow_png_529611
        Me.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUp.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUp.Location = New System.Drawing.Point(1226, 300)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(57, 38)
        Me.btnUp.TabIndex = 3
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Controls.Add(Me.btnPlus)
        Me.GroupBox1.Controls.Add(Me.btnMin)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(1313, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 176)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quantity"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Firebrick
        Me.GroupBox2.Controls.Add(Me.txtPriceTotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(1267, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(196, 103)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price Total"
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TblOrderDataGridView)
        Me.Controls.Add(Me.btnWithout)
        Me.Controls.Add(Me.btnWIth)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmOrder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TblItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TblOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents txtPriceTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnWIth As System.Windows.Forms.Button
    Friend WithEvents btnWithout As System.Windows.Forms.Button
    Friend WithEvents ItemCol As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QtyCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Totalcol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Without As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblOrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents itemcolumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents qtycolumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents discolumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalcolumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descriptioncol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents withcol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents withoutcol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checked As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
