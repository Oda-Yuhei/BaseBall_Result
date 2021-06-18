<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChartForm
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
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.Basic_information = New System.Windows.Forms.RadioButton()
        Me.Pitcher_Result = New System.Windows.Forms.RadioButton()
        Me.Batter_Result = New System.Windows.Forms.RadioButton()
        Me.name_ComboBox = New System.Windows.Forms.ComboBox()
        Me.defaultDataGridView = New System.Windows.Forms.DataGridView()
        Me.Vw_PlayerlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerManagementDataSet = New Score_management.PlayerManagementDataSet()
        Me.BatterResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.PlayeridDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatteridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RubDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TandBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HBPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IBBandHBPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vw_BatterResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PitcherResultDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwPitcherResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPlayerlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllresultViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_PlayerlistTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_PlayerlistTableAdapter()
        Me.TableAdapterManager = New Score_management.PlayerManagementDataSetTableAdapters.TableAdapterManager()
        Me.Vw_PitcherResultTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_PitcherResultTableAdapter()
        Me.Vw_BatterResultTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_BatterResultTableAdapter()
        Me.AllresultViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.AllresultViewTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RubDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TandB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.origin_school = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.defaultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_PlayerlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatterResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_BatterResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PitcherResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPitcherResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPlayerlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllresultViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PositionComboBox
        '
        Me.PositionComboBox.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Items.AddRange(New Object() {"投手", "キャッチャー", "ファースト", "セカンド", "ショート", "サード", "野手", "内野手", "外野手"})
        Me.PositionComboBox.Location = New System.Drawing.Point(139, 12)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(121, 27)
        Me.PositionComboBox.TabIndex = 2
        Me.PositionComboBox.Text = "(ポジション)"
        '
        'EnterButton
        '
        Me.EnterButton.Location = New System.Drawing.Point(281, 13)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(97, 26)
        Me.EnterButton.TabIndex = 3
        Me.EnterButton.Text = "決定"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'Basic_information
        '
        Me.Basic_information.AutoSize = True
        Me.Basic_information.Checked = True
        Me.Basic_information.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Basic_information.Location = New System.Drawing.Point(12, 59)
        Me.Basic_information.Name = "Basic_information"
        Me.Basic_information.Size = New System.Drawing.Size(90, 23)
        Me.Basic_information.TabIndex = 6
        Me.Basic_information.TabStop = True
        Me.Basic_information.Text = "個人情報"
        Me.Basic_information.UseVisualStyleBackColor = True
        '
        'Pitcher_Result
        '
        Me.Pitcher_Result.AutoSize = True
        Me.Pitcher_Result.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Pitcher_Result.Location = New System.Drawing.Point(108, 59)
        Me.Pitcher_Result.Name = "Pitcher_Result"
        Me.Pitcher_Result.Size = New System.Drawing.Size(90, 23)
        Me.Pitcher_Result.TabIndex = 7
        Me.Pitcher_Result.Text = "投手成績"
        Me.Pitcher_Result.UseVisualStyleBackColor = True
        '
        'Batter_Result
        '
        Me.Batter_Result.AutoSize = True
        Me.Batter_Result.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Batter_Result.Location = New System.Drawing.Point(204, 59)
        Me.Batter_Result.Name = "Batter_Result"
        Me.Batter_Result.Size = New System.Drawing.Size(90, 23)
        Me.Batter_Result.TabIndex = 8
        Me.Batter_Result.Text = "打撃成績"
        Me.Batter_Result.UseVisualStyleBackColor = True
        '
        'name_ComboBox
        '
        Me.name_ComboBox.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.name_ComboBox.FormattingEnabled = True
        Me.name_ComboBox.Items.AddRange(New Object() {"あ行", "か行", "さ行", "た行", "な行", "は行", "ま行", "や行", "ら行", "わ行"})
        Me.name_ComboBox.Location = New System.Drawing.Point(12, 12)
        Me.name_ComboBox.Name = "name_ComboBox"
        Me.name_ComboBox.Size = New System.Drawing.Size(121, 27)
        Me.name_ComboBox.TabIndex = 1
        Me.name_ComboBox.Text = "(五十音)"
        '
        'defaultDataGridView
        '
        Me.defaultDataGridView.AllowUserToAddRows = False
        Me.defaultDataGridView.AllowUserToDeleteRows = False
        Me.defaultDataGridView.AllowUserToOrderColumns = True
        Me.defaultDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.defaultDataGridView.AutoGenerateColumns = False
        Me.defaultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.defaultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.defaultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.defaultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ID, Me.NameDataGridViewTextBoxColumn, Me.RubDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.TandB, Me.origin_school, Me.comment})
        Me.defaultDataGridView.DataSource = Me.Vw_PlayerlistBindingSource
        Me.defaultDataGridView.Location = New System.Drawing.Point(12, 102)
        Me.defaultDataGridView.Name = "defaultDataGridView"
        Me.defaultDataGridView.ReadOnly = True
        Me.defaultDataGridView.RowHeadersVisible = False
        Me.defaultDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.defaultDataGridView.RowTemplate.Height = 24
        Me.defaultDataGridView.Size = New System.Drawing.Size(1061, 392)
        Me.defaultDataGridView.TabIndex = 0
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
        'BatterResultDataGridView
        '
        Me.BatterResultDataGridView.AllowUserToAddRows = False
        Me.BatterResultDataGridView.AllowUserToDeleteRows = False
        Me.BatterResultDataGridView.AllowUserToOrderColumns = True
        Me.BatterResultDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BatterResultDataGridView.AutoGenerateColumns = False
        Me.BatterResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BatterResultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.BatterResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BatterResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlayeridDataGridViewTextBoxColumn1, Me.BatteridDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn2, Me.RubDataGridViewTextBoxColumn2, Me.TandBDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn2, Me.ARDataGridViewTextBoxColumn, Me.average, Me.OBP, Me.HDataGridViewTextBoxColumn, Me.LHDataGridViewTextBoxColumn, Me.HRDataGridViewTextBoxColumn, Me.HBPDataGridViewTextBoxColumn, Me.SHDataGridViewTextBoxColumn, Me.IBBandHBPDataGridViewTextBoxColumn, Me.SODataGridViewTextBoxColumn, Me.SBDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn, Me.Expr1DataGridViewTextBoxColumn1, Me.Expr2DataGridViewTextBoxColumn1, Me.IDDataGridViewTextBoxColumn2})
        Me.BatterResultDataGridView.DataSource = Me.Vw_BatterResultBindingSource
        Me.BatterResultDataGridView.Location = New System.Drawing.Point(12, 102)
        Me.BatterResultDataGridView.Name = "BatterResultDataGridView"
        Me.BatterResultDataGridView.ReadOnly = True
        Me.BatterResultDataGridView.RowHeadersVisible = False
        Me.BatterResultDataGridView.RowHeadersWidth = 51
        Me.BatterResultDataGridView.RowTemplate.Height = 24
        Me.BatterResultDataGridView.Size = New System.Drawing.Size(1061, 392)
        Me.BatterResultDataGridView.TabIndex = 10
        '
        'PlayeridDataGridViewTextBoxColumn1
        '
        Me.PlayeridDataGridViewTextBoxColumn1.DataPropertyName = "Player_id"
        Me.PlayeridDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.PlayeridDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.PlayeridDataGridViewTextBoxColumn1.Name = "PlayeridDataGridViewTextBoxColumn1"
        Me.PlayeridDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PlayeridDataGridViewTextBoxColumn1.Width = 50
        '
        'BatteridDataGridViewTextBoxColumn
        '
        Me.BatteridDataGridViewTextBoxColumn.DataPropertyName = "Batter_id"
        Me.BatteridDataGridViewTextBoxColumn.HeaderText = "Batter_id"
        Me.BatteridDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BatteridDataGridViewTextBoxColumn.Name = "BatteridDataGridViewTextBoxColumn"
        Me.BatteridDataGridViewTextBoxColumn.ReadOnly = True
        Me.BatteridDataGridViewTextBoxColumn.Visible = False
        Me.BatteridDataGridViewTextBoxColumn.Width = 91
        '
        'NameDataGridViewTextBoxColumn2
        '
        Me.NameDataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn2.HeaderText = "名前"
        Me.NameDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn2.Name = "NameDataGridViewTextBoxColumn2"
        Me.NameDataGridViewTextBoxColumn2.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn2.Width = 66
        '
        'RubDataGridViewTextBoxColumn2
        '
        Me.RubDataGridViewTextBoxColumn2.DataPropertyName = "rub"
        Me.RubDataGridViewTextBoxColumn2.HeaderText = "ふりがな"
        Me.RubDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.RubDataGridViewTextBoxColumn2.Name = "RubDataGridViewTextBoxColumn2"
        Me.RubDataGridViewTextBoxColumn2.ReadOnly = True
        Me.RubDataGridViewTextBoxColumn2.Visible = False
        Me.RubDataGridViewTextBoxColumn2.Width = 82
        '
        'TandBDataGridViewTextBoxColumn
        '
        Me.TandBDataGridViewTextBoxColumn.DataPropertyName = "TandB"
        Me.TandBDataGridViewTextBoxColumn.HeaderText = "利腕"
        Me.TandBDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TandBDataGridViewTextBoxColumn.Name = "TandBDataGridViewTextBoxColumn"
        Me.TandBDataGridViewTextBoxColumn.ReadOnly = True
        Me.TandBDataGridViewTextBoxColumn.Width = 66
        '
        'PositionDataGridViewTextBoxColumn2
        '
        Me.PositionDataGridViewTextBoxColumn2.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn2.HeaderText = "ポジション"
        Me.PositionDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.PositionDataGridViewTextBoxColumn2.Name = "PositionDataGridViewTextBoxColumn2"
        Me.PositionDataGridViewTextBoxColumn2.ReadOnly = True
        Me.PositionDataGridViewTextBoxColumn2.Width = 91
        '
        'ARDataGridViewTextBoxColumn
        '
        Me.ARDataGridViewTextBoxColumn.DataPropertyName = "AR"
        Me.ARDataGridViewTextBoxColumn.HeaderText = "打席数"
        Me.ARDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ARDataGridViewTextBoxColumn.Name = "ARDataGridViewTextBoxColumn"
        Me.ARDataGridViewTextBoxColumn.ReadOnly = True
        Me.ARDataGridViewTextBoxColumn.Width = 81
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
        'HDataGridViewTextBoxColumn
        '
        Me.HDataGridViewTextBoxColumn.DataPropertyName = "H"
        Me.HDataGridViewTextBoxColumn.HeaderText = "単打"
        Me.HDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HDataGridViewTextBoxColumn.Name = "HDataGridViewTextBoxColumn"
        Me.HDataGridViewTextBoxColumn.ReadOnly = True
        Me.HDataGridViewTextBoxColumn.Width = 66
        '
        'LHDataGridViewTextBoxColumn
        '
        Me.LHDataGridViewTextBoxColumn.DataPropertyName = "LH"
        Me.LHDataGridViewTextBoxColumn.HeaderText = "長打"
        Me.LHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LHDataGridViewTextBoxColumn.Name = "LHDataGridViewTextBoxColumn"
        Me.LHDataGridViewTextBoxColumn.ReadOnly = True
        Me.LHDataGridViewTextBoxColumn.Width = 66
        '
        'HRDataGridViewTextBoxColumn
        '
        Me.HRDataGridViewTextBoxColumn.DataPropertyName = "HR"
        Me.HRDataGridViewTextBoxColumn.HeaderText = "本塁打"
        Me.HRDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HRDataGridViewTextBoxColumn.Name = "HRDataGridViewTextBoxColumn"
        Me.HRDataGridViewTextBoxColumn.ReadOnly = True
        Me.HRDataGridViewTextBoxColumn.Width = 81
        '
        'HBPDataGridViewTextBoxColumn
        '
        Me.HBPDataGridViewTextBoxColumn.DataPropertyName = "HBP"
        Me.HBPDataGridViewTextBoxColumn.HeaderText = "犠打"
        Me.HBPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HBPDataGridViewTextBoxColumn.Name = "HBPDataGridViewTextBoxColumn"
        Me.HBPDataGridViewTextBoxColumn.ReadOnly = True
        Me.HBPDataGridViewTextBoxColumn.Width = 66
        '
        'SHDataGridViewTextBoxColumn
        '
        Me.SHDataGridViewTextBoxColumn.DataPropertyName = "SH"
        Me.SHDataGridViewTextBoxColumn.HeaderText = "犠飛"
        Me.SHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SHDataGridViewTextBoxColumn.Name = "SHDataGridViewTextBoxColumn"
        Me.SHDataGridViewTextBoxColumn.ReadOnly = True
        Me.SHDataGridViewTextBoxColumn.Width = 66
        '
        'IBBandHBPDataGridViewTextBoxColumn
        '
        Me.IBBandHBPDataGridViewTextBoxColumn.DataPropertyName = "IBBandHBP"
        Me.IBBandHBPDataGridViewTextBoxColumn.HeaderText = "四死球"
        Me.IBBandHBPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IBBandHBPDataGridViewTextBoxColumn.Name = "IBBandHBPDataGridViewTextBoxColumn"
        Me.IBBandHBPDataGridViewTextBoxColumn.ReadOnly = True
        Me.IBBandHBPDataGridViewTextBoxColumn.Width = 81
        '
        'SODataGridViewTextBoxColumn
        '
        Me.SODataGridViewTextBoxColumn.DataPropertyName = "SO"
        Me.SODataGridViewTextBoxColumn.HeaderText = "三振"
        Me.SODataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SODataGridViewTextBoxColumn.Name = "SODataGridViewTextBoxColumn"
        Me.SODataGridViewTextBoxColumn.ReadOnly = True
        Me.SODataGridViewTextBoxColumn.Width = 66
        '
        'SBDataGridViewTextBoxColumn
        '
        Me.SBDataGridViewTextBoxColumn.DataPropertyName = "SB"
        Me.SBDataGridViewTextBoxColumn.HeaderText = "盗塁"
        Me.SBDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SBDataGridViewTextBoxColumn.Name = "SBDataGridViewTextBoxColumn"
        Me.SBDataGridViewTextBoxColumn.ReadOnly = True
        Me.SBDataGridViewTextBoxColumn.Width = 66
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "コメント"
        Me.CommentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommentDataGridViewTextBoxColumn.Width = 78
        '
        'Expr1DataGridViewTextBoxColumn1
        '
        Me.Expr1DataGridViewTextBoxColumn1.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn1.HeaderText = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.Expr1DataGridViewTextBoxColumn1.Name = "Expr1DataGridViewTextBoxColumn1"
        Me.Expr1DataGridViewTextBoxColumn1.ReadOnly = True
        Me.Expr1DataGridViewTextBoxColumn1.Visible = False
        Me.Expr1DataGridViewTextBoxColumn1.Width = 71
        '
        'Expr2DataGridViewTextBoxColumn1
        '
        Me.Expr2DataGridViewTextBoxColumn1.DataPropertyName = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn1.HeaderText = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.Expr2DataGridViewTextBoxColumn1.Name = "Expr2DataGridViewTextBoxColumn1"
        Me.Expr2DataGridViewTextBoxColumn1.ReadOnly = True
        Me.Expr2DataGridViewTextBoxColumn1.Visible = False
        Me.Expr2DataGridViewTextBoxColumn1.Width = 71
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        Me.IDDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn2.Visible = False
        Me.IDDataGridViewTextBoxColumn2.Width = 50
        '
        'Vw_BatterResultBindingSource
        '
        Me.Vw_BatterResultBindingSource.DataMember = "vw_BatterResult"
        Me.Vw_BatterResultBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'PitcherResultDataGridView
        '
        Me.PitcherResultDataGridView.AllowUserToAddRows = False
        Me.PitcherResultDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PitcherResultDataGridView.AutoGenerateColumns = False
        Me.PitcherResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PitcherResultDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PitcherResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PitcherResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn1})
        Me.PitcherResultDataGridView.DataSource = Me.VwPitcherResultBindingSource
        Me.PitcherResultDataGridView.Location = New System.Drawing.Point(13, 102)
        Me.PitcherResultDataGridView.Name = "PitcherResultDataGridView"
        Me.PitcherResultDataGridView.ReadOnly = True
        Me.PitcherResultDataGridView.RowHeadersVisible = False
        Me.PitcherResultDataGridView.RowHeadersWidth = 51
        Me.PitcherResultDataGridView.RowTemplate.Height = 24
        Me.PitcherResultDataGridView.Size = New System.Drawing.Size(1060, 392)
        Me.PitcherResultDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "名前"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 66
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "rub"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ふりがな"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 82
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "position"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ポジション"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 91
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "APP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "登板回数"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 96
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "投球回数"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 96
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ERA"
        Me.DataGridViewTextBoxColumn15.HeaderText = "防御率"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 81
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "KBB"
        Me.DataGridViewTextBoxColumn16.HeaderText = "K/BB"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 73
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "R"
        Me.DataGridViewTextBoxColumn7.HeaderText = "失点"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 66
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ER"
        Me.DataGridViewTextBoxColumn8.HeaderText = "自責点"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 81
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "K"
        Me.DataGridViewTextBoxColumn9.HeaderText = "奪三振"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 81
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "B"
        Me.DataGridViewTextBoxColumn10.HeaderText = "四球"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 66
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Pitcher_id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Pitcher_id"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 97
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 71
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Expr2"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Expr2"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 71
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'VwPitcherResultBindingSource
        '
        Me.VwPitcherResultBindingSource.DataMember = "vw_PitcherResult"
        Me.VwPitcherResultBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'AllresultViewBindingSource
        '
        Me.AllresultViewBindingSource.DataMember = "AllresultView"
        Me.AllresultViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'Vw_PlayerlistTableAdapter
        '
        Me.Vw_PlayerlistTableAdapter.ClearBeforeFill = True
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
        '
        'Vw_PitcherResultTableAdapter
        '
        Me.Vw_PitcherResultTableAdapter.ClearBeforeFill = True
        '
        'Vw_BatterResultTableAdapter
        '
        Me.Vw_BatterResultTableAdapter.ClearBeforeFill = True
        '
        'AllresultViewTableAdapter
        '
        Me.AllresultViewTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 27
        '
        'ID
        '
        Me.ID.DataPropertyName = "Player_id"
        Me.ID.HeaderText = "playerID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 87
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "名前"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 66
        '
        'RubDataGridViewTextBoxColumn
        '
        Me.RubDataGridViewTextBoxColumn.DataPropertyName = "rub"
        Me.RubDataGridViewTextBoxColumn.HeaderText = "ふりがな"
        Me.RubDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RubDataGridViewTextBoxColumn.Name = "RubDataGridViewTextBoxColumn"
        Me.RubDataGridViewTextBoxColumn.ReadOnly = True
        Me.RubDataGridViewTextBoxColumn.Width = 82
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "ポジション"
        Me.PositionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PositionDataGridViewTextBoxColumn.Width = 91
        '
        'TandB
        '
        Me.TandB.DataPropertyName = "TandB"
        Me.TandB.HeaderText = "利腕"
        Me.TandB.MinimumWidth = 6
        Me.TandB.Name = "TandB"
        Me.TandB.ReadOnly = True
        Me.TandB.Width = 66
        '
        'origin_school
        '
        Me.origin_school.DataPropertyName = "origin_school"
        Me.origin_school.HeaderText = "出身校"
        Me.origin_school.MinimumWidth = 6
        Me.origin_school.Name = "origin_school"
        Me.origin_school.ReadOnly = True
        Me.origin_school.Width = 81
        '
        'comment
        '
        Me.comment.DataPropertyName = "comment"
        Me.comment.HeaderText = "コメント"
        Me.comment.MinimumWidth = 6
        Me.comment.Name = "comment"
        Me.comment.ReadOnly = True
        Me.comment.Width = 78
        '
        'ChartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 506)
        Me.Controls.Add(Me.Batter_Result)
        Me.Controls.Add(Me.Pitcher_Result)
        Me.Controls.Add(Me.Basic_information)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.PositionComboBox)
        Me.Controls.Add(Me.name_ComboBox)
        Me.Controls.Add(Me.defaultDataGridView)
        Me.Controls.Add(Me.BatterResultDataGridView)
        Me.Controls.Add(Me.PitcherResultDataGridView)
        Me.MinimumSize = New System.Drawing.Size(530, 500)
        Me.Name = "ChartForm"
        Me.Text = "選手一覧"
        CType(Me.defaultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_PlayerlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatterResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_BatterResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PitcherResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPitcherResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPlayerlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllresultViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PositionComboBox As ComboBox
    Friend WithEvents EnterButton As Button
    Friend WithEvents Basic_information As RadioButton
    Friend WithEvents Pitcher_Result As RadioButton
    Friend WithEvents Batter_Result As RadioButton
    Friend WithEvents name_ComboBox As ComboBox
    Friend WithEvents defaultDataGridView As DataGridView
    Friend WithEvents PlayerManagementDataSet As PlayerManagementDataSet
    Friend WithEvents Vw_PlayerlistBindingSource As BindingSource
    Friend WithEvents Vw_PlayerlistTableAdapter As PlayerManagementDataSetTableAdapters.vw_PlayerlistTableAdapter
    Friend WithEvents TableAdapterManager As PlayerManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VwPitcherResultBindingSource As BindingSource
    Friend WithEvents Vw_PitcherResultTableAdapter As PlayerManagementDataSetTableAdapters.vw_PitcherResultTableAdapter
    Friend WithEvents BatterResultDataGridView As DataGridView
    Friend WithEvents Vw_BatterResultBindingSource As BindingSource
    Friend WithEvents Vw_BatterResultTableAdapter As PlayerManagementDataSetTableAdapters.vw_BatterResultTableAdapter
    Friend WithEvents PitcherResultDataGridView As DataGridView
    Friend WithEvents VwPlayerlistBindingSource As BindingSource
    Friend WithEvents AllresultViewBindingSource As BindingSource
    Friend WithEvents AllresultViewTableAdapter As PlayerManagementDataSetTableAdapters.AllresultViewTableAdapter
    Friend WithEvents PlayeridDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BatteridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents RubDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TandBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents average As DataGridViewTextBoxColumn
    Friend WithEvents OBP As DataGridViewTextBoxColumn
    Friend WithEvents HDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HBPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IBBandHBPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RubDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TandB As DataGridViewTextBoxColumn
    Friend WithEvents origin_school As DataGridViewTextBoxColumn
    Friend WithEvents comment As DataGridViewTextBoxColumn
End Class
