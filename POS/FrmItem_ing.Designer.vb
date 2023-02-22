<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItem_ing
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
        Me.TblItem_IngDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblIngredientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblItem_IngBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemComboBox = New System.Windows.Forms.ComboBox()
        Me.TblItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngComboBox = New System.Windows.Forms.ComboBox()
        Me.TblIngredientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblItemIngBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TblItem_IngDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIngredientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblItem_IngBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIngredientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblItemIngBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblItem_IngDataGridView
        '
        Me.TblItem_IngDataGridView.AllowUserToAddRows = False
        Me.TblItem_IngDataGridView.AllowUserToDeleteRows = False
        Me.TblItem_IngDataGridView.AutoGenerateColumns = False
        Me.TblItem_IngDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TblItem_IngDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TblItem_IngDataGridView.ColumnHeadersHeight = 40
        Me.TblItem_IngDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TblItem_IngDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblItem_IngDataGridView.DataSource = Me.TblItem_IngBindingSource
        Me.TblItem_IngDataGridView.Location = New System.Drawing.Point(86, 141)
        Me.TblItem_IngDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TblItem_IngDataGridView.Name = "TblItem_IngDataGridView"
        Me.TblItem_IngDataGridView.ReadOnly = True
        Me.TblItem_IngDataGridView.RowTemplate.Height = 24
        Me.TblItem_IngDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblItem_IngDataGridView.Size = New System.Drawing.Size(710, 360)
        Me.TblItem_IngDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ItemId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.TblItemBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ItemName"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "ItemId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "id"
        '
        'TblItemBindingSource
        '
        Me.TblItemBindingSource.DataSource = GetType(POS.tblItem)
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IngId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.TblIngredientBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "IngredientName"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "IngId"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "id"
        '
        'TblIngredientBindingSource
        '
        Me.TblIngredientBindingSource.DataSource = GetType(POS.tblIngredient)
        '
        'TblItem_IngBindingSource
        '
        Me.TblItem_IngBindingSource.DataSource = GetType(POS.tblItem_Ing)
        '
        'ItemComboBox
        '
        Me.ItemComboBox.DataSource = Me.TblItemBindingSource1
        Me.ItemComboBox.DisplayMember = "ItemName"
        Me.ItemComboBox.FormattingEnabled = True
        Me.ItemComboBox.Location = New System.Drawing.Point(129, 93)
        Me.ItemComboBox.Name = "ItemComboBox"
        Me.ItemComboBox.Size = New System.Drawing.Size(275, 29)
        Me.ItemComboBox.TabIndex = 0
        Me.ItemComboBox.ValueMember = "id"
        '
        'TblItemBindingSource1
        '
        Me.TblItemBindingSource1.DataSource = GetType(POS.tblItem)
        '
        'IngComboBox
        '
        Me.IngComboBox.DataSource = Me.TblIngredientBindingSource1
        Me.IngComboBox.DisplayMember = "IngredientName"
        Me.IngComboBox.FormattingEnabled = True
        Me.IngComboBox.Location = New System.Drawing.Point(480, 93)
        Me.IngComboBox.Name = "IngComboBox"
        Me.IngComboBox.Size = New System.Drawing.Size(284, 29)
        Me.IngComboBox.TabIndex = 1
        Me.IngComboBox.ValueMember = "id"
        '
        'TblIngredientBindingSource1
        '
        Me.TblIngredientBindingSource1.DataSource = GetType(POS.tblIngredient)
        '
        'TblItemIngBindingSource
        '
        Me.TblItemIngBindingSource.DataSource = GetType(POS.tblItem_Ing)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(896, 58)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ITEMS - Ingredients "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(843, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 39)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "X"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmItem_ing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(896, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IngComboBox)
        Me.Controls.Add(Me.ItemComboBox)
        Me.Controls.Add(Me.TblItem_IngDataGridView)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmItem_ing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TblItem_IngDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIngredientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblItem_IngBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIngredientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblItemIngBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TblItem_IngBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblItem_IngDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TblIngredientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IngComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblItemIngBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblItemBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblIngredientBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
