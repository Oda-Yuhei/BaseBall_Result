<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalEditing
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PlayerManagementDataSet = New Score_management.PlayerManagementDataSet()
        Me.VwPitcherResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_PitcherResultTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_PitcherResultTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RubDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPitcherResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 154)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "名前"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "フリガナ"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(286, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 22)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(286, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 22)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(286, 69)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(188, 22)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(286, 97)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(188, 22)
        Me.TextBox4.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "出身校"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ポジション"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "利腕"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(286, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 23)
        Me.ComboBox1.TabIndex = 11
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 188)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(99, 26)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "投手成績"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(121, 188)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(99, 26)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "投手成績"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(501, 363)
        Me.DataGridView1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(192, 589)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 56)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "確定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.RubDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.APPDataGridViewTextBoxColumn, Me.IPDataGridViewTextBoxColumn, Me.RDataGridViewTextBoxColumn, Me.ERDataGridViewTextBoxColumn, Me.KDataGridViewTextBoxColumn, Me.BDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.VwPitcherResultBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(13, 220)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(501, 363)
        Me.DataGridView2.TabIndex = 16
        '
        'PlayerManagementDataSet
        '
        Me.PlayerManagementDataSet.DataSetName = "PlayerManagementDataSet"
        Me.PlayerManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwPitcherResultBindingSource
        '
        Me.VwPitcherResultBindingSource.DataMember = "vw_PitcherResult"
        Me.VwPitcherResultBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'Vw_PitcherResultTableAdapter
        '
        Me.Vw_PitcherResultTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 6
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "名前"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 6
        '
        'RubDataGridViewTextBoxColumn
        '
        Me.RubDataGridViewTextBoxColumn.DataPropertyName = "rub"
        Me.RubDataGridViewTextBoxColumn.HeaderText = "ふりがな"
        Me.RubDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RubDataGridViewTextBoxColumn.Name = "RubDataGridViewTextBoxColumn"
        Me.RubDataGridViewTextBoxColumn.ReadOnly = True
        Me.RubDataGridViewTextBoxColumn.Width = 6
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "ポジション"
        Me.PositionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PositionDataGridViewTextBoxColumn.Width = 6
        '
        'APPDataGridViewTextBoxColumn
        '
        Me.APPDataGridViewTextBoxColumn.DataPropertyName = "APP"
        Me.APPDataGridViewTextBoxColumn.HeaderText = "登板数"
        Me.APPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.APPDataGridViewTextBoxColumn.Name = "APPDataGridViewTextBoxColumn"
        Me.APPDataGridViewTextBoxColumn.ReadOnly = True
        Me.APPDataGridViewTextBoxColumn.Width = 6
        '
        'IPDataGridViewTextBoxColumn
        '
        Me.IPDataGridViewTextBoxColumn.DataPropertyName = "IP"
        Me.IPDataGridViewTextBoxColumn.HeaderText = "投球回数"
        Me.IPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IPDataGridViewTextBoxColumn.Name = "IPDataGridViewTextBoxColumn"
        Me.IPDataGridViewTextBoxColumn.ReadOnly = True
        Me.IPDataGridViewTextBoxColumn.Width = 6
        '
        'RDataGridViewTextBoxColumn
        '
        Me.RDataGridViewTextBoxColumn.DataPropertyName = "R"
        Me.RDataGridViewTextBoxColumn.HeaderText = "失点"
        Me.RDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RDataGridViewTextBoxColumn.Name = "RDataGridViewTextBoxColumn"
        Me.RDataGridViewTextBoxColumn.ReadOnly = True
        Me.RDataGridViewTextBoxColumn.Width = 6
        '
        'ERDataGridViewTextBoxColumn
        '
        Me.ERDataGridViewTextBoxColumn.DataPropertyName = "ER"
        Me.ERDataGridViewTextBoxColumn.HeaderText = "自責点"
        Me.ERDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ERDataGridViewTextBoxColumn.Name = "ERDataGridViewTextBoxColumn"
        Me.ERDataGridViewTextBoxColumn.ReadOnly = True
        Me.ERDataGridViewTextBoxColumn.Width = 6
        '
        'KDataGridViewTextBoxColumn
        '
        Me.KDataGridViewTextBoxColumn.DataPropertyName = "K"
        Me.KDataGridViewTextBoxColumn.HeaderText = "奪三振"
        Me.KDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KDataGridViewTextBoxColumn.Name = "KDataGridViewTextBoxColumn"
        Me.KDataGridViewTextBoxColumn.ReadOnly = True
        Me.KDataGridViewTextBoxColumn.Width = 6
        '
        'BDataGridViewTextBoxColumn
        '
        Me.BDataGridViewTextBoxColumn.DataPropertyName = "B"
        Me.BDataGridViewTextBoxColumn.HeaderText = "四死球"
        Me.BDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BDataGridViewTextBoxColumn.Name = "BDataGridViewTextBoxColumn"
        Me.BDataGridViewTextBoxColumn.ReadOnly = True
        Me.BDataGridViewTextBoxColumn.Width = 6
        '
        'PersonalEditing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 657)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(544, 704)
        Me.Name = "PersonalEditing"
        Me.Text = "PersonalEditing"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPitcherResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PlayerManagementDataSet As PlayerManagementDataSet
    Friend WithEvents VwPitcherResultBindingSource As BindingSource
    Friend WithEvents Vw_PitcherResultTableAdapter As PlayerManagementDataSetTableAdapters.vw_PitcherResultTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RubDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
