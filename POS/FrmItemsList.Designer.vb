<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemsList
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
        Me.TblItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.Category = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoryIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblCategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        CType(Me.TblItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblItemDataGridView
        '
        Me.TblItemDataGridView.AllowUserToAddRows = False
        Me.TblItemDataGridView.AllowUserToDeleteRows = False
        Me.TblItemDataGridView.AutoGenerateColumns = False
        Me.TblItemDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TblItemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Category, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.Edit, Me.Delete})
        Me.TblItemDataGridView.DataSource = Me.TblItemBindingSource
        Me.TblItemDataGridView.Location = New System.Drawing.Point(0, 140)
        Me.TblItemDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TblItemDataGridView.Name = "TblItemDataGridView"
        Me.TblItemDataGridView.ReadOnly = True
        Me.TblItemDataGridView.RowTemplate.Height = 24
        Me.TblItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblItemDataGridView.Size = New System.Drawing.Size(925, 430)
        Me.TblItemDataGridView.TabIndex = 2
        '
        'Category
        '
        Me.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Category.DataPropertyName = "CategoryId"
        Me.Category.DataSource = Me.TblCategoryBindingSource
        Me.Category.DisplayMember = "CategoryName"
        Me.Category.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.ValueMember = "id"
        '
        'TblCategoryBindingSource
        '
        Me.TblCategoryBindingSource.DataSource = GetType(POS.tblCategory)
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ItemName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ItemName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Image = Global.POS.My.Resources.Resources.images
        Me.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Image = Global.POS.My.Resources.Resources.red_cross_symbol_icon_as_delete_remove_vector_22586546
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'TblItemBindingSource
        '
        Me.TblItemBindingSource.DataSource = GetType(POS.tblItem)
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.Location = New System.Drawing.Point(796, 587)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 42)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(925, 58)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ITEMS LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(871, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CategoryIdComboBox
        '
        Me.CategoryIdComboBox.DataSource = Me.TblCategoryBindingSource1
        Me.CategoryIdComboBox.DisplayMember = "CategoryName"
        Me.CategoryIdComboBox.FormattingEnabled = True
        Me.CategoryIdComboBox.Location = New System.Drawing.Point(41, 105)
        Me.CategoryIdComboBox.Name = "CategoryIdComboBox"
        Me.CategoryIdComboBox.Size = New System.Drawing.Size(214, 29)
        Me.CategoryIdComboBox.TabIndex = 0
        Me.CategoryIdComboBox.ValueMember = "id"
        '
        'TblCategoryBindingSource1
        '
        Me.TblCategoryBindingSource1.DataSource = GetType(POS.tblCategory)
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(269, 105)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(221, 28)
        Me.NameTextBox.TabIndex = 1
        '
        'FrmItemsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(925, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.CategoryIdComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TblItemDataGridView)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmItemsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblItemDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Category As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CategoryIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblCategoryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
End Class
