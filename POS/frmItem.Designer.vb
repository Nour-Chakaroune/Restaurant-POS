<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItem
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
        Dim CategoryIdLabel As System.Windows.Forms.Label
        Dim ItemNameLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.TblItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CategoryIdLabel = New System.Windows.Forms.Label()
        ItemNameLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.TblItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryIdLabel
        '
        CategoryIdLabel.AutoSize = True
        CategoryIdLabel.Location = New System.Drawing.Point(97, 116)
        CategoryIdLabel.Name = "CategoryIdLabel"
        CategoryIdLabel.Size = New System.Drawing.Size(102, 21)
        CategoryIdLabel.TabIndex = 1
        CategoryIdLabel.Text = "Category Id:"
        '
        'ItemNameLabel
        '
        ItemNameLabel.AutoSize = True
        ItemNameLabel.Location = New System.Drawing.Point(97, 175)
        ItemNameLabel.Name = "ItemNameLabel"
        ItemNameLabel.Size = New System.Drawing.Size(99, 21)
        ItemNameLabel.TabIndex = 3
        ItemNameLabel.Text = "Item Name:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(144, 228)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(52, 21)
        PriceLabel.TabIndex = 5
        PriceLabel.Text = "Price:"
        '
        'TblItemBindingSource
        '
        Me.TblItemBindingSource.DataSource = GetType(POS.tblItem)
        '
        'CategoryIdComboBox
        '
        Me.CategoryIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblItemBindingSource, "CategoryId", True))
        Me.CategoryIdComboBox.DataSource = Me.TblCategoryBindingSource
        Me.CategoryIdComboBox.DisplayMember = "CategoryName"
        Me.CategoryIdComboBox.FormattingEnabled = True
        Me.CategoryIdComboBox.Location = New System.Drawing.Point(205, 113)
        Me.CategoryIdComboBox.Name = "CategoryIdComboBox"
        Me.CategoryIdComboBox.Size = New System.Drawing.Size(162, 29)
        Me.CategoryIdComboBox.TabIndex = 0
        Me.CategoryIdComboBox.ValueMember = "id"
        '
        'TblCategoryBindingSource
        '
        Me.TblCategoryBindingSource.DataSource = GetType(POS.tblCategory)
        '
        'txtItemName
        '
        Me.txtItemName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblItemBindingSource, "ItemName", True))
        Me.txtItemName.Location = New System.Drawing.Point(202, 172)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(165, 28)
        Me.txtItemName.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Firebrick
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(226, 284)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 38)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblItemBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(202, 225)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(165, 28)
        Me.PriceTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(797, 58)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NEW ITEMS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(753, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 41)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(396, 102)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(393, 220)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'frmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(797, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(ItemNameLabel)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(CategoryIdLabel)
        Me.Controls.Add(Me.CategoryIdComboBox)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmItem"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
