<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayerCardForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Player_idLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Vw_PitcherResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.AdvancedBatterResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.RubTextBox = New System.Windows.Forms.TextBox()
        Me.Origin_schoolTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.TandBTextBox = New System.Windows.Forms.TextBox()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.Player_idTextBox = New System.Windows.Forms.TextBox()
        Me.Label_FileName = New System.Windows.Forms.Label()
        Me.Vw_PlayerlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerManagementDataSet = New Score_management.PlayerManagementDataSet()
        Me.Vw_PitcherResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vw_BatterResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_BatterResultTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_BatterResultTableAdapter()
        Me.TableAdapterManager = New Score_management.PlayerManagementDataSetTableAdapters.TableAdapterManager()
        Me.Vw_PitcherResultTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_PitcherResultTableAdapter()
        Me.Vw_PlayerlistTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_PlayerlistTableAdapter()
        Me.Player_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Player_ResultTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.Player_ResultTableAdapter()
        Me.PlayerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.PlayerTableAdapter()
        Me.UploadFileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KBB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.W = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Player_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pitcher_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Player_idLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_PitcherResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvancedBatterResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_PlayerlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_PitcherResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_BatterResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UploadFileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player_idLabel
        '
        Player_idLabel.AutoSize = True
        Player_idLabel.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Player_idLabel.Location = New System.Drawing.Point(14, 260)
        Player_idLabel.Name = "Player_idLabel"
        Player_idLabel.Size = New System.Drawing.Size(26, 19)
        Player_idLabel.TabIndex = 36
        Player_idLabel.Text = "ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 191)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "名前"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ふりがな"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "出身校"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ポジション"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "利腕"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(507, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "コメント"
        '
        'Button
        '
        Me.Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button.Location = New System.Drawing.Point(583, 202)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(100, 49)
        Me.Button.TabIndex = 9
        Me.Button.Text = "編集"
        Me.Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(702, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 49)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "削除"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Vw_PitcherResultDataGridView
        '
        Me.Vw_PitcherResultDataGridView.AllowUserToAddRows = False
        Me.Vw_PitcherResultDataGridView.AllowUserToDeleteRows = False
        Me.Vw_PitcherResultDataGridView.AllowUserToOrderColumns = True
        Me.Vw_PitcherResultDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Vw_PitcherResultDataGridView.AutoGenerateColumns = False
        Me.Vw_PitcherResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Vw_PitcherResultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Vw_PitcherResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_PitcherResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn32, Me.ERA, Me.KBB, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.W, Me.SV, Me.Player_id, Me.Pitcher_id, Me.Expr2, Me.Expr1})
        Me.Vw_PitcherResultDataGridView.DataSource = Me.Vw_PitcherResultBindingSource
        Me.Vw_PitcherResultDataGridView.Location = New System.Drawing.Point(12, 401)
        Me.Vw_PitcherResultDataGridView.Name = "Vw_PitcherResultDataGridView"
        Me.Vw_PitcherResultDataGridView.RowHeadersVisible = False
        Me.Vw_PitcherResultDataGridView.RowHeadersWidth = 51
        Me.Vw_PitcherResultDataGridView.RowTemplate.Height = 24
        Me.Vw_PitcherResultDataGridView.Size = New System.Drawing.Size(846, 74)
        Me.Vw_PitcherResultDataGridView.TabIndex = 7
        '
        'AdvancedBatterResultDataGridView
        '
        Me.AdvancedBatterResultDataGridView.AllowUserToAddRows = False
        Me.AdvancedBatterResultDataGridView.AllowUserToDeleteRows = False
        Me.AdvancedBatterResultDataGridView.AllowUserToOrderColumns = True
        Me.AdvancedBatterResultDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvancedBatterResultDataGridView.AutoGenerateColumns = False
        Me.AdvancedBatterResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AdvancedBatterResultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AdvancedBatterResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdvancedBatterResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.average, Me.OBP, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn14})
        Me.AdvancedBatterResultDataGridView.DataSource = Me.Vw_BatterResultBindingSource
        Me.AdvancedBatterResultDataGridView.Location = New System.Drawing.Point(12, 312)
        Me.AdvancedBatterResultDataGridView.Name = "AdvancedBatterResultDataGridView"
        Me.AdvancedBatterResultDataGridView.RowHeadersVisible = False
        Me.AdvancedBatterResultDataGridView.RowHeadersWidth = 51
        Me.AdvancedBatterResultDataGridView.RowTemplate.Height = 24
        Me.AdvancedBatterResultDataGridView.Size = New System.Drawing.Size(846, 74)
        Me.AdvancedBatterResultDataGridView.TabIndex = 8
        '
        'average
        '
        Me.average.DataPropertyName = "average"
        Me.average.HeaderText = "打率"
        Me.average.MinimumWidth = 6
        Me.average.Name = "average"
        Me.average.ReadOnly = True
        Me.average.Width = 66
        '
        'OBP
        '
        Me.OBP.DataPropertyName = "OBP"
        Me.OBP.HeaderText = "出塁率"
        Me.OBP.MinimumWidth = 6
        Me.OBP.Name = "OBP"
        Me.OBP.ReadOnly = True
        Me.OBP.Width = 81
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_PlayerlistBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(268, 47)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(170, 22)
        Me.NameTextBox.TabIndex = 1
        '
        'RubTextBox
        '
        Me.RubTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_PlayerlistBindingSource, "rub", True))
        Me.RubTextBox.Location = New System.Drawing.Point(268, 80)
        Me.RubTextBox.Name = "RubTextBox"
        Me.RubTextBox.Size = New System.Drawing.Size(170, 22)
        Me.RubTextBox.TabIndex = 2
        '
        'Origin_schoolTextBox
        '
        Me.Origin_schoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_PlayerlistBindingSource, "origin_school", True))
        Me.Origin_schoolTextBox.Location = New System.Drawing.Point(268, 110)
        Me.Origin_schoolTextBox.Name = "Origin_schoolTextBox"
        Me.Origin_schoolTextBox.Size = New System.Drawing.Size(170, 22)
        Me.Origin_schoolTextBox.TabIndex = 3
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_PlayerlistBindingSource, "position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(268, 171)
        Me.PositionTextBox.Multiline = True
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.ReadOnly = True
        Me.PositionTextBox.Size = New System.Drawing.Size(170, 51)
        Me.PositionTextBox.TabIndex = 500
        Me.PositionTextBox.TabStop = False
        '
        'TandBTextBox
        '
        Me.TandBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_PlayerlistBindingSource, "TandB", True))
        Me.TandBTextBox.Location = New System.Drawing.Point(268, 257)
        Me.TandBTextBox.Name = "TandBTextBox"
        Me.TandBTextBox.ReadOnly = True
        Me.TandBTextBox.Size = New System.Drawing.Size(170, 22)
        Me.TandBTextBox.TabIndex = 501
        Me.TandBTextBox.TabStop = False
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_PlayerlistBindingSource, "comment", True))
        Me.CommentTextBox.Location = New System.Drawing.Point(583, 49)
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(219, 106)
        Me.CommentTextBox.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"右投右打", "右投左打", "右投両打", "左投右打", "左投左打", "左投両打", "両投右打", "両投左打", "両投両打"})
        Me.ComboBox1.Location = New System.Drawing.Point(268, 228)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(170, 23)
        Me.ComboBox1.TabIndex = 5
        '
        'PositionComboBox
        '
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Items.AddRange(New Object() {"投手", "キャッチャー", "ファースト", "セカンド", "ショート", "サード", "外野手"})
        Me.PositionComboBox.Location = New System.Drawing.Point(268, 142)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(170, 23)
        Me.PositionComboBox.TabIndex = 4
        '
        'Player_idTextBox
        '
        Me.Player_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_PlayerlistBindingSource, "Player_id", True))
        Me.Player_idTextBox.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Player_idTextBox.Location = New System.Drawing.Point(46, 257)
        Me.Player_idTextBox.Name = "Player_idTextBox"
        Me.Player_idTextBox.ReadOnly = True
        Me.Player_idTextBox.Size = New System.Drawing.Size(80, 27)
        Me.Player_idTextBox.TabIndex = 37
        '
        'Label_FileName
        '
        Me.Label_FileName.AutoSize = True
        Me.Label_FileName.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_FileName.Location = New System.Drawing.Point(5, 7)
        Me.Label_FileName.Name = "Label_FileName"
        Me.Label_FileName.Size = New System.Drawing.Size(24, 19)
        Me.Label_FileName.TabIndex = 502
        Me.Label_FileName.Text = "："
        '
        'Vw_PlayerlistBindingSource
        '
        Me.Vw_PlayerlistBindingSource.DataMember = "vw_Playerlist"
        Me.Vw_PlayerlistBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'PlayerManagementDataSet
        '
        Me.PlayerManagementDataSet.DataSetName = "PlayerManagementDataSet"
        Me.PlayerManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_PitcherResultBindingSource
        '
        Me.Vw_PitcherResultBindingSource.DataMember = "vw_PitcherResult"
        Me.Vw_PitcherResultBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "名前"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 66
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "rub"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ふりがな"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 82
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AR"
        Me.DataGridViewTextBoxColumn5.HeaderText = "打席"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 66
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "H"
        Me.DataGridViewTextBoxColumn6.HeaderText = "安打"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 66
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LH"
        Me.DataGridViewTextBoxColumn7.HeaderText = "長打"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 66
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "HR"
        Me.DataGridViewTextBoxColumn8.HeaderText = "本塁打"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 81
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "HBP"
        Me.DataGridViewTextBoxColumn9.HeaderText = "犠打"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 66
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SH"
        Me.DataGridViewTextBoxColumn10.HeaderText = "犠飛"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 66
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "三振"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 66
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IBBandHBP"
        Me.DataGridViewTextBoxColumn11.HeaderText = "四死球"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 81
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SB"
        Me.DataGridViewTextBoxColumn13.HeaderText = "盗塁"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 66
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 71
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Expr2"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Expr2"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 71
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Batter_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Batter_id"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 91
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 50
        '
        'Vw_BatterResultBindingSource
        '
        Me.Vw_BatterResultBindingSource.DataMember = "vw_BatterResult"
        Me.Vw_BatterResultBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'Vw_BatterResultTableAdapter
        '
        Me.Vw_BatterResultTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatterTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PitcherTableAdapter = Nothing
        Me.TableAdapterManager.Player_ResultTableAdapter = Nothing
        Me.TableAdapterManager.PlayerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Score_management.PlayerManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UploadFileTableAdapter = Nothing
        '
        'Vw_PitcherResultTableAdapter
        '
        Me.Vw_PitcherResultTableAdapter.ClearBeforeFill = True
        '
        'Vw_PlayerlistTableAdapter
        '
        Me.Vw_PlayerlistTableAdapter.ClearBeforeFill = True
        '
        'Player_ResultBindingSource
        '
        Me.Player_ResultBindingSource.DataMember = "Player_Result"
        Me.Player_ResultBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'Player_ResultTableAdapter
        '
        Me.Player_ResultTableAdapter.ClearBeforeFill = True
        '
        'PlayerBindingSource
        '
        Me.PlayerBindingSource.DataMember = "Player"
        Me.PlayerBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'PlayerTableAdapter
        '
        Me.PlayerTableAdapter.ClearBeforeFill = True
        '
        'UploadFileBindingSource
        '
        Me.UploadFileBindingSource.DataSource = Me.PlayerManagementDataSet
        Me.UploadFileBindingSource.Position = 0
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn32.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 50
        '
        'ERA
        '
        Me.ERA.DataPropertyName = "ERA"
        Me.ERA.HeaderText = "防御率"
        Me.ERA.MinimumWidth = 6
        Me.ERA.Name = "ERA"
        Me.ERA.ReadOnly = True
        Me.ERA.Width = 81
        '
        'KBB
        '
        Me.KBB.DataPropertyName = "KBB"
        Me.KBB.HeaderText = "K/BB"
        Me.KBB.MinimumWidth = 6
        Me.KBB.Name = "KBB"
        Me.KBB.ReadOnly = True
        Me.KBB.Width = 73
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "APP"
        Me.DataGridViewTextBoxColumn26.HeaderText = "登板回数"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 96
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "IP"
        Me.DataGridViewTextBoxColumn27.HeaderText = "投球回数"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 96
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "R"
        Me.DataGridViewTextBoxColumn28.HeaderText = "失点"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 66
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "ER"
        Me.DataGridViewTextBoxColumn29.HeaderText = "自責点"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 81
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "K"
        Me.DataGridViewTextBoxColumn30.HeaderText = "奪三振"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 81
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "B"
        Me.DataGridViewTextBoxColumn31.HeaderText = "四球"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 66
        '
        'W
        '
        Me.W.DataPropertyName = "W"
        Me.W.HeaderText = "勝利"
        Me.W.MinimumWidth = 6
        Me.W.Name = "W"
        Me.W.Width = 66
        '
        'SV
        '
        Me.SV.DataPropertyName = "SV"
        Me.SV.HeaderText = "セーブ"
        Me.SV.MinimumWidth = 6
        Me.SV.Name = "SV"
        Me.SV.Width = 71
        '
        'Player_id
        '
        Me.Player_id.DataPropertyName = "Player_id"
        Me.Player_id.HeaderText = "Player_id"
        Me.Player_id.MinimumWidth = 6
        Me.Player_id.Name = "Player_id"
        Me.Player_id.Visible = False
        Me.Player_id.Width = 90
        '
        'Pitcher_id
        '
        Me.Pitcher_id.DataPropertyName = "Pitcher_id"
        Me.Pitcher_id.HeaderText = "Pitcher_id"
        Me.Pitcher_id.MinimumWidth = 6
        Me.Pitcher_id.Name = "Pitcher_id"
        Me.Pitcher_id.Visible = False
        Me.Pitcher_id.Width = 97
        '
        'Expr2
        '
        Me.Expr2.DataPropertyName = "Expr2"
        Me.Expr2.HeaderText = "Expr2"
        Me.Expr2.MinimumWidth = 6
        Me.Expr2.Name = "Expr2"
        Me.Expr2.Visible = False
        Me.Expr2.Width = 71
        '
        'Expr1
        '
        Me.Expr1.DataPropertyName = "Expr1"
        Me.Expr1.HeaderText = "Expr1"
        Me.Expr1.MinimumWidth = 6
        Me.Expr1.Name = "Expr1"
        Me.Expr1.Visible = False
        Me.Expr1.Width = 71
        '
        'PlayerCardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(870, 487)
        Me.Controls.Add(Me.Label_FileName)
        Me.Controls.Add(Player_idLabel)
        Me.Controls.Add(Me.Player_idTextBox)
        Me.Controls.Add(Me.PositionComboBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.RubTextBox)
        Me.Controls.Add(Me.Origin_schoolTextBox)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(Me.TandBTextBox)
        Me.Controls.Add(Me.CommentTextBox)
        Me.Controls.Add(Me.Vw_PitcherResultDataGridView)
        Me.Controls.Add(Me.AdvancedBatterResultDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(888, 534)
        Me.Name = "PlayerCardForm"
        Me.Text = "個人カード"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_PitcherResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvancedBatterResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_PlayerlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_PitcherResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_BatterResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UploadFileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PlayerManagementDataSet As PlayerManagementDataSet
    Friend WithEvents Vw_BatterResultBindingSource As BindingSource
    Friend WithEvents Vw_BatterResultTableAdapter As PlayerManagementDataSetTableAdapters.vw_BatterResultTableAdapter
    Friend WithEvents TableAdapterManager As PlayerManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Vw_PitcherResultBindingSource As BindingSource
    Friend WithEvents Vw_PitcherResultTableAdapter As PlayerManagementDataSetTableAdapters.vw_PitcherResultTableAdapter
    Friend WithEvents Vw_PitcherResultDataGridView As DataGridView
    Friend WithEvents Vw_PlayerlistBindingSource As BindingSource
    Friend WithEvents Vw_PlayerlistTableAdapter As PlayerManagementDataSetTableAdapters.vw_PlayerlistTableAdapter
    Friend WithEvents AdvancedBatterResultDataGridView As DataGridView
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents RubTextBox As TextBox
    Friend WithEvents Origin_schoolTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents TandBTextBox As TextBox
    Friend WithEvents CommentTextBox As TextBox
    Friend WithEvents Player_ResultBindingSource As BindingSource
    Friend WithEvents Player_ResultTableAdapter As PlayerManagementDataSetTableAdapters.Player_ResultTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PositionComboBox As ComboBox
    Friend WithEvents PlayerBindingSource As BindingSource
    Friend WithEvents PlayerTableAdapter As PlayerManagementDataSetTableAdapters.PlayerTableAdapter
    Friend WithEvents Player_idTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents average As DataGridViewTextBoxColumn
    Friend WithEvents OBP As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Label_FileName As Label
    Friend WithEvents UploadFileBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents ERA As DataGridViewTextBoxColumn
    Friend WithEvents KBB As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents W As DataGridViewTextBoxColumn
    Friend WithEvents SV As DataGridViewTextBoxColumn
    Friend WithEvents Player_id As DataGridViewTextBoxColumn
    Friend WithEvents Pitcher_id As DataGridViewTextBoxColumn
    Friend WithEvents Expr2 As DataGridViewTextBoxColumn
    Friend WithEvents Expr1 As DataGridViewTextBoxColumn
End Class
