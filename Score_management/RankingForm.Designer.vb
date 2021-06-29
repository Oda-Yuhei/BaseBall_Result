<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RankingForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TopAverageDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopAverageViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerManagementDataSet = New Score_management.PlayerManagementDataSet()
        Me.TopOBPDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopOBPViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopSODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopSOViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopERADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ERADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopERAViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopKDataGridView = New System.Windows.Forms.DataGridView()
        Me.Player_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopKViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopCountTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DataGridView10 = New System.Windows.Forms.DataGridView()
        Me.AverageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamAVGAverageViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ARTextBox = New System.Windows.Forms.TextBox()
        Me.InningTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TopHitterViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopHitterViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopHRDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopHRViewBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopSBViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopSBViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopKBBViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopKBBViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.ERADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamAVGERAViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.KBBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamAVGKBBViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamAVGOBPViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamAVGOBPViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_BatterResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwBatterResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerManagementDataSet2 = New Score_management.PlayerManagementDataSet()
        Me.Vw_BatterResultTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_BatterResultTableAdapter()
        Me.TableAdapterManager = New Score_management.PlayerManagementDataSetTableAdapters.TableAdapterManager()
        Me.PlayerManagementDataSet1 = New Score_management.PlayerManagementDataSet()
        Me.VwPitcherResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_PitcherResultTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.vw_PitcherResultTableAdapter()
        Me.TopHitterViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopHitterViewTableAdapter()
        Me.TopHRViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopHRViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopHRViewTableAdapter()
        Me.TopHRViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopHRViewBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopHRViewBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopSOViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopSOViewTableAdapter()
        Me.TopSBViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopSBViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopSBViewTableAdapter()
        Me.TopOBPViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopOBPViewTableAdapter()
        Me.TopERAViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopERAViewTableAdapter()
        Me.TopKViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopKViewTableAdapter()
        Me.TopKBBViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopKBBViewTableAdapter()
        Me.TeamAVGAverageViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TeamAVGAverageViewTableAdapter()
        Me.BatterTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.BatterTableAdapter()
        Me.TopAverageViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopAverageViewTableAdapter()
        Me.TeamAVGOBPViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TeamAVGOBPViewTableAdapter()
        Me.TeamAVGERAViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TeamAVGERAViewTableAdapter()
        Me.TeamAVGKBBViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TeamAVGKBBViewTableAdapter()
        CType(Me.TopAverageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopAverageViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopOBPDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopOBPViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSOViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopERADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopERAViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopKDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopKViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamAVGAverageViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHitterViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHitterViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHRDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHRViewBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSBViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSBViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopKBBViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopKBBViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamAVGERAViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamAVGKBBViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamAVGOBPViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamAVGOBPViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_BatterResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBatterResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerManagementDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerManagementDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPitcherResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHRViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHRViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHRViewBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHRViewBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSBViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "最高打率"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(498, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "最多安打"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(741, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "最多本塁打"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(1227, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "最多盗塁"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(984, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "最多三振"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(280, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "最多奪三振"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 441)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "最高防御率"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(552, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "最高K/BB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "出塁率"
        '
        'TopAverageDataGridView
        '
        Me.TopAverageDataGridView.AllowUserToAddRows = False
        Me.TopAverageDataGridView.AllowUserToDeleteRows = False
        Me.TopAverageDataGridView.AutoGenerateColumns = False
        Me.TopAverageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopAverageDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopAverageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopAverageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.name, Me.average, Me.ARDataGridViewTextBoxColumn1})
        Me.TopAverageDataGridView.DataSource = Me.TopAverageViewBindingSource
        Me.TopAverageDataGridView.Location = New System.Drawing.Point(16, 59)
        Me.TopAverageDataGridView.Name = "TopAverageDataGridView"
        Me.TopAverageDataGridView.ReadOnly = True
        Me.TopAverageDataGridView.RowHeadersVisible = False
        Me.TopAverageDataGridView.RowHeadersWidth = 51
        Me.TopAverageDataGridView.RowTemplate.Height = 24
        Me.TopAverageDataGridView.Size = New System.Drawing.Size(237, 341)
        Me.TopAverageDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Player_id"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 67
        '
        'name
        '
        Me.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.name.DataPropertyName = "name"
        Me.name.HeaderText = "名前"
        Me.name.MinimumWidth = 6
        Me.name.Name = "name"
        Me.name.ReadOnly = True
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
        'ARDataGridViewTextBoxColumn1
        '
        Me.ARDataGridViewTextBoxColumn1.DataPropertyName = "AR"
        Me.ARDataGridViewTextBoxColumn1.HeaderText = "打席"
        Me.ARDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.ARDataGridViewTextBoxColumn1.Name = "ARDataGridViewTextBoxColumn1"
        Me.ARDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ARDataGridViewTextBoxColumn1.Width = 66
        '
        'TopAverageViewBindingSource
        '
        Me.TopAverageViewBindingSource.DataMember = "TopAverageView"
        Me.TopAverageViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'PlayerManagementDataSet
        '
        Me.PlayerManagementDataSet.DataSetName = "PlayerManagementDataSet"
        Me.PlayerManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopOBPDataGridView
        '
        Me.TopOBPDataGridView.AllowUserToAddRows = False
        Me.TopOBPDataGridView.AllowUserToDeleteRows = False
        Me.TopOBPDataGridView.AutoGenerateColumns = False
        Me.TopOBPDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopOBPDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopOBPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopOBPDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.NameDataGridViewTextBoxColumn2, Me.OBPDataGridViewTextBoxColumn, Me.ARDataGridViewTextBoxColumn2})
        Me.TopOBPDataGridView.DataSource = Me.TopOBPViewBindingSource
        Me.TopOBPDataGridView.Location = New System.Drawing.Point(259, 59)
        Me.TopOBPDataGridView.Name = "TopOBPDataGridView"
        Me.TopOBPDataGridView.ReadOnly = True
        Me.TopOBPDataGridView.RowHeadersVisible = False
        Me.TopOBPDataGridView.RowHeadersWidth = 51
        Me.TopOBPDataGridView.RowTemplate.Height = 24
        Me.TopOBPDataGridView.Size = New System.Drawing.Size(237, 341)
        Me.TopOBPDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Player_id"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 67
        '
        'NameDataGridViewTextBoxColumn2
        '
        Me.NameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn2.HeaderText = "名前"
        Me.NameDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn2.Name = "NameDataGridViewTextBoxColumn2"
        Me.NameDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'OBPDataGridViewTextBoxColumn
        '
        Me.OBPDataGridViewTextBoxColumn.DataPropertyName = "OBP"
        Me.OBPDataGridViewTextBoxColumn.HeaderText = "出塁率"
        Me.OBPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OBPDataGridViewTextBoxColumn.Name = "OBPDataGridViewTextBoxColumn"
        Me.OBPDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBPDataGridViewTextBoxColumn.Width = 81
        '
        'ARDataGridViewTextBoxColumn2
        '
        Me.ARDataGridViewTextBoxColumn2.DataPropertyName = "AR"
        Me.ARDataGridViewTextBoxColumn2.HeaderText = "打席"
        Me.ARDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.ARDataGridViewTextBoxColumn2.Name = "ARDataGridViewTextBoxColumn2"
        Me.ARDataGridViewTextBoxColumn2.ReadOnly = True
        Me.ARDataGridViewTextBoxColumn2.Width = 66
        '
        'TopOBPViewBindingSource
        '
        Me.TopOBPViewBindingSource.DataMember = "TopOBPView"
        Me.TopOBPViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'TopSODataGridView
        '
        Me.TopSODataGridView.AllowUserToAddRows = False
        Me.TopSODataGridView.AllowUserToDeleteRows = False
        Me.TopSODataGridView.AutoGenerateColumns = False
        Me.TopSODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopSODataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopSODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopSODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.NameDataGridViewTextBoxColumn, Me.SODataGridViewTextBoxColumn, Me.ARDataGridViewTextBoxColumn})
        Me.TopSODataGridView.DataSource = Me.TopSOViewBindingSource
        Me.TopSODataGridView.Location = New System.Drawing.Point(988, 59)
        Me.TopSODataGridView.Name = "TopSODataGridView"
        Me.TopSODataGridView.ReadOnly = True
        Me.TopSODataGridView.RowHeadersVisible = False
        Me.TopSODataGridView.RowHeadersWidth = 51
        Me.TopSODataGridView.RowTemplate.Height = 24
        Me.TopSODataGridView.Size = New System.Drawing.Size(237, 341)
        Me.TopSODataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Player_id"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 67
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "名前"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
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
        'ARDataGridViewTextBoxColumn
        '
        Me.ARDataGridViewTextBoxColumn.DataPropertyName = "AR"
        Me.ARDataGridViewTextBoxColumn.HeaderText = "打席"
        Me.ARDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ARDataGridViewTextBoxColumn.Name = "ARDataGridViewTextBoxColumn"
        Me.ARDataGridViewTextBoxColumn.ReadOnly = True
        Me.ARDataGridViewTextBoxColumn.Width = 66
        '
        'TopSOViewBindingSource
        '
        Me.TopSOViewBindingSource.DataMember = "TopSOView"
        Me.TopSOViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'TopERADataGridView
        '
        Me.TopERADataGridView.AllowUserToAddRows = False
        Me.TopERADataGridView.AllowUserToDeleteRows = False
        Me.TopERADataGridView.AutoGenerateColumns = False
        Me.TopERADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopERADataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopERADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopERADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.NameDataGridViewTextBoxColumn3, Me.ERADataGridViewTextBoxColumn, Me.IPDataGridViewTextBoxColumn})
        Me.TopERADataGridView.DataSource = Me.TopERAViewBindingSource
        Me.TopERADataGridView.Location = New System.Drawing.Point(12, 481)
        Me.TopERADataGridView.Name = "TopERADataGridView"
        Me.TopERADataGridView.ReadOnly = True
        Me.TopERADataGridView.RowHeadersVisible = False
        Me.TopERADataGridView.RowHeadersWidth = 51
        Me.TopERADataGridView.RowTemplate.Height = 24
        Me.TopERADataGridView.Size = New System.Drawing.Size(266, 389)
        Me.TopERADataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Player_id"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 67
        '
        'NameDataGridViewTextBoxColumn3
        '
        Me.NameDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn3.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn3.HeaderText = "名前"
        Me.NameDataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn3.Name = "NameDataGridViewTextBoxColumn3"
        Me.NameDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'ERADataGridViewTextBoxColumn
        '
        Me.ERADataGridViewTextBoxColumn.DataPropertyName = "ERA"
        Me.ERADataGridViewTextBoxColumn.HeaderText = "防御率"
        Me.ERADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ERADataGridViewTextBoxColumn.Name = "ERADataGridViewTextBoxColumn"
        Me.ERADataGridViewTextBoxColumn.ReadOnly = True
        Me.ERADataGridViewTextBoxColumn.Width = 81
        '
        'IPDataGridViewTextBoxColumn
        '
        Me.IPDataGridViewTextBoxColumn.DataPropertyName = "IP"
        Me.IPDataGridViewTextBoxColumn.HeaderText = "投球回"
        Me.IPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IPDataGridViewTextBoxColumn.Name = "IPDataGridViewTextBoxColumn"
        Me.IPDataGridViewTextBoxColumn.ReadOnly = True
        Me.IPDataGridViewTextBoxColumn.Width = 81
        '
        'TopERAViewBindingSource
        '
        Me.TopERAViewBindingSource.DataMember = "TopERAView"
        Me.TopERAViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'TopKDataGridView
        '
        Me.TopKDataGridView.AllowUserToAddRows = False
        Me.TopKDataGridView.AllowUserToDeleteRows = False
        Me.TopKDataGridView.AutoGenerateColumns = False
        Me.TopKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopKDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopKDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Player_id, Me.NameDataGridViewTextBoxColumn4, Me.KDataGridViewTextBoxColumn, Me.IPDataGridViewTextBoxColumn1})
        Me.TopKDataGridView.DataSource = Me.TopKViewBindingSource
        Me.TopKDataGridView.Location = New System.Drawing.Point(284, 481)
        Me.TopKDataGridView.Name = "TopKDataGridView"
        Me.TopKDataGridView.ReadOnly = True
        Me.TopKDataGridView.RowHeadersVisible = False
        Me.TopKDataGridView.RowHeadersWidth = 51
        Me.TopKDataGridView.RowTemplate.Height = 24
        Me.TopKDataGridView.Size = New System.Drawing.Size(266, 389)
        Me.TopKDataGridView.TabIndex = 17
        '
        'Player_id
        '
        Me.Player_id.DataPropertyName = "Player_id"
        Me.Player_id.HeaderText = "Player_id"
        Me.Player_id.MinimumWidth = 6
        Me.Player_id.Name = "Player_id"
        Me.Player_id.ReadOnly = True
        Me.Player_id.Visible = False
        Me.Player_id.Width = 67
        '
        'NameDataGridViewTextBoxColumn4
        '
        Me.NameDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn4.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn4.HeaderText = "名前"
        Me.NameDataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn4.Name = "NameDataGridViewTextBoxColumn4"
        Me.NameDataGridViewTextBoxColumn4.ReadOnly = True
        '
        'KDataGridViewTextBoxColumn
        '
        Me.KDataGridViewTextBoxColumn.DataPropertyName = "K"
        Me.KDataGridViewTextBoxColumn.HeaderText = "奪三振"
        Me.KDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KDataGridViewTextBoxColumn.Name = "KDataGridViewTextBoxColumn"
        Me.KDataGridViewTextBoxColumn.ReadOnly = True
        Me.KDataGridViewTextBoxColumn.Width = 81
        '
        'IPDataGridViewTextBoxColumn1
        '
        Me.IPDataGridViewTextBoxColumn1.DataPropertyName = "IP"
        Me.IPDataGridViewTextBoxColumn1.HeaderText = "投球回"
        Me.IPDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IPDataGridViewTextBoxColumn1.Name = "IPDataGridViewTextBoxColumn1"
        Me.IPDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IPDataGridViewTextBoxColumn1.Width = 81
        '
        'TopKViewBindingSource
        '
        Me.TopKViewBindingSource.DataMember = "TopKView"
        Me.TopKViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'TopCountTextBox
        '
        Me.TopCountTextBox.Location = New System.Drawing.Point(1264, 737)
        Me.TopCountTextBox.Name = "TopCountTextBox"
        Me.TopCountTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TopCountTextBox.TabIndex = 19
        Me.TopCountTextBox.Text = "5"
        Me.TopCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(1214, 735)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 22)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "TOP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(1370, 735)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 22)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "まで表示"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1264, 791)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(140, 51)
        Me.ExitButton.TabIndex = 22
        Me.ExitButton.Text = "更　　新"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DataGridView10
        '
        Me.DataGridView10.AllowUserToAddRows = False
        Me.DataGridView10.AllowUserToDeleteRows = False
        Me.DataGridView10.AutoGenerateColumns = False
        Me.DataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView10.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AverageDataGridViewTextBoxColumn})
        Me.DataGridView10.DataSource = Me.TeamAVGAverageViewBindingSource
        Me.DataGridView10.Location = New System.Drawing.Point(828, 481)
        Me.DataGridView10.Name = "DataGridView10"
        Me.DataGridView10.ReadOnly = True
        Me.DataGridView10.RowHeadersVisible = False
        Me.DataGridView10.RowHeadersWidth = 51
        Me.DataGridView10.RowTemplate.Height = 24
        Me.DataGridView10.Size = New System.Drawing.Size(154, 61)
        Me.DataGridView10.TabIndex = 23
        '
        'AverageDataGridViewTextBoxColumn
        '
        Me.AverageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AverageDataGridViewTextBoxColumn.DataPropertyName = "average"
        Me.AverageDataGridViewTextBoxColumn.HeaderText = "平均打率"
        Me.AverageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AverageDataGridViewTextBoxColumn.Name = "AverageDataGridViewTextBoxColumn"
        Me.AverageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeamAVGAverageViewBindingSource
        '
        Me.TeamAVGAverageViewBindingSource.DataMember = "TeamAVGAverageView"
        Me.TeamAVGAverageViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(824, 441)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 24)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "チーム平均"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(1193, 635)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 22)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "規定打席"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(1193, 685)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 22)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "規定イニング"
        '
        'ARTextBox
        '
        Me.ARTextBox.Location = New System.Drawing.Point(1276, 635)
        Me.ARTextBox.Name = "ARTextBox"
        Me.ARTextBox.Size = New System.Drawing.Size(88, 22)
        Me.ARTextBox.TabIndex = 28
        Me.ARTextBox.Text = "5"
        Me.ARTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InningTextBox
        '
        Me.InningTextBox.Location = New System.Drawing.Point(1294, 685)
        Me.InningTextBox.Name = "InningTextBox"
        Me.InningTextBox.Size = New System.Drawing.Size(70, 22)
        Me.InningTextBox.TabIndex = 29
        Me.InningTextBox.Text = "9"
        Me.InningTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(1370, 633)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 22)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "まで表示"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.Location = New System.Drawing.Point(1370, 685)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 22)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "まで表示"
        '
        'TopHitterViewDataGridView
        '
        Me.TopHitterViewDataGridView.AllowUserToAddRows = False
        Me.TopHitterViewDataGridView.AllowUserToDeleteRows = False
        Me.TopHitterViewDataGridView.AutoGenerateColumns = False
        Me.TopHitterViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopHitterViewDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopHitterViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopHitterViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn14})
        Me.TopHitterViewDataGridView.DataSource = Me.TopHitterViewBindingSource
        Me.TopHitterViewDataGridView.Location = New System.Drawing.Point(502, 59)
        Me.TopHitterViewDataGridView.Name = "TopHitterViewDataGridView"
        Me.TopHitterViewDataGridView.ReadOnly = True
        Me.TopHitterViewDataGridView.RowHeadersVisible = False
        Me.TopHitterViewDataGridView.RowHeadersWidth = 51
        Me.TopHitterViewDataGridView.RowTemplate.Height = 24
        Me.TopHitterViewDataGridView.Size = New System.Drawing.Size(237, 341)
        Me.TopHitterViewDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Player_id"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 67
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "名前"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "H"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HIT"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 59
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "AR"
        Me.DataGridViewTextBoxColumn14.HeaderText = "打席"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 66
        '
        'TopHitterViewBindingSource
        '
        Me.TopHitterViewBindingSource.DataMember = "TopHitterView"
        Me.TopHitterViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'TopHRDataGridView
        '
        Me.TopHRDataGridView.AllowUserToAddRows = False
        Me.TopHRDataGridView.AllowUserToDeleteRows = False
        Me.TopHRDataGridView.AutoGenerateColumns = False
        Me.TopHRDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopHRDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopHRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopHRDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn15})
        Me.TopHRDataGridView.DataSource = Me.TopHRViewBindingSource4
        Me.TopHRDataGridView.Location = New System.Drawing.Point(745, 59)
        Me.TopHRDataGridView.Name = "TopHRDataGridView"
        Me.TopHRDataGridView.ReadOnly = True
        Me.TopHRDataGridView.RowHeadersVisible = False
        Me.TopHRDataGridView.RowHeadersWidth = 51
        Me.TopHRDataGridView.RowTemplate.Height = 24
        Me.TopHRDataGridView.Size = New System.Drawing.Size(237, 341)
        Me.TopHRDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Player_id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 67
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "名前"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HR"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HR"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 55
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "AR"
        Me.DataGridViewTextBoxColumn15.HeaderText = "打席"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 66
        '
        'TopHRViewBindingSource4
        '
        Me.TopHRViewBindingSource4.DataMember = "TopHRView"
        Me.TopHRViewBindingSource4.DataSource = Me.PlayerManagementDataSet
        '
        'TopSBViewDataGridView
        '
        Me.TopSBViewDataGridView.AllowUserToAddRows = False
        Me.TopSBViewDataGridView.AllowUserToDeleteRows = False
        Me.TopSBViewDataGridView.AutoGenerateColumns = False
        Me.TopSBViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopSBViewDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopSBViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopSBViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn19})
        Me.TopSBViewDataGridView.DataSource = Me.TopSBViewBindingSource1
        Me.TopSBViewDataGridView.Location = New System.Drawing.Point(1231, 59)
        Me.TopSBViewDataGridView.Name = "TopSBViewDataGridView"
        Me.TopSBViewDataGridView.ReadOnly = True
        Me.TopSBViewDataGridView.RowHeadersVisible = False
        Me.TopSBViewDataGridView.RowHeadersWidth = 51
        Me.TopSBViewDataGridView.RowTemplate.Height = 24
        Me.TopSBViewDataGridView.Size = New System.Drawing.Size(237, 341)
        Me.TopSBViewDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Player_id"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 67
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn12.HeaderText = "名前"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
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
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "AR"
        Me.DataGridViewTextBoxColumn19.HeaderText = "打席"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 66
        '
        'TopSBViewBindingSource1
        '
        Me.TopSBViewBindingSource1.DataMember = "TopSBView"
        Me.TopSBViewBindingSource1.DataSource = Me.PlayerManagementDataSet
        '
        'TopKBBViewDataGridView
        '
        Me.TopKBBViewDataGridView.AllowUserToAddRows = False
        Me.TopKBBViewDataGridView.AllowUserToDeleteRows = False
        Me.TopKBBViewDataGridView.AutoGenerateColumns = False
        Me.TopKBBViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopKBBViewDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopKBBViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopKBBViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn21})
        Me.TopKBBViewDataGridView.DataSource = Me.TopKBBViewBindingSource
        Me.TopKBBViewDataGridView.Location = New System.Drawing.Point(556, 481)
        Me.TopKBBViewDataGridView.Name = "TopKBBViewDataGridView"
        Me.TopKBBViewDataGridView.ReadOnly = True
        Me.TopKBBViewDataGridView.RowHeadersVisible = False
        Me.TopKBBViewDataGridView.RowHeadersWidth = 51
        Me.TopKBBViewDataGridView.RowTemplate.Height = 24
        Me.TopKBBViewDataGridView.Size = New System.Drawing.Size(266, 389)
        Me.TopKBBViewDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Player_id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Player_id"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 67
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn17.HeaderText = "名前"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "KBB"
        Me.DataGridViewTextBoxColumn18.HeaderText = "K/BB"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 73
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "IP"
        Me.DataGridViewTextBoxColumn21.HeaderText = "投球回"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 81
        '
        'TopKBBViewBindingSource
        '
        Me.TopKBBViewBindingSource.DataMember = "TopKBBView"
        Me.TopKBBViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ERADataGridViewTextBoxColumn1})
        Me.DataGridView4.DataSource = Me.TeamAVGERAViewBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(828, 615)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(154, 61)
        Me.DataGridView4.TabIndex = 36
        '
        'ERADataGridViewTextBoxColumn1
        '
        Me.ERADataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ERADataGridViewTextBoxColumn1.DataPropertyName = "ERA"
        Me.ERADataGridViewTextBoxColumn1.HeaderText = "平均防御率"
        Me.ERADataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.ERADataGridViewTextBoxColumn1.Name = "ERADataGridViewTextBoxColumn1"
        Me.ERADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TeamAVGERAViewBindingSource
        '
        Me.TeamAVGERAViewBindingSource.DataMember = "TeamAVGERAView"
        Me.TeamAVGERAViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'DataGridView6
        '
        Me.DataGridView6.AllowUserToAddRows = False
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KBBDataGridViewTextBoxColumn})
        Me.DataGridView6.DataSource = Me.TeamAVGKBBViewBindingSource
        Me.DataGridView6.Location = New System.Drawing.Point(828, 682)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.ReadOnly = True
        Me.DataGridView6.RowHeadersVisible = False
        Me.DataGridView6.RowHeadersWidth = 51
        Me.DataGridView6.RowTemplate.Height = 24
        Me.DataGridView6.Size = New System.Drawing.Size(154, 61)
        Me.DataGridView6.TabIndex = 37
        '
        'KBBDataGridViewTextBoxColumn
        '
        Me.KBBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.KBBDataGridViewTextBoxColumn.DataPropertyName = "KBB"
        Me.KBBDataGridViewTextBoxColumn.HeaderText = "平均K/BB"
        Me.KBBDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KBBDataGridViewTextBoxColumn.Name = "KBBDataGridViewTextBoxColumn"
        Me.KBBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeamAVGKBBViewBindingSource
        '
        Me.TeamAVGKBBViewBindingSource.DataMember = "TeamAVGKBBView"
        Me.TeamAVGKBBViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'TeamAVGOBPViewDataGridView
        '
        Me.TeamAVGOBPViewDataGridView.AllowUserToAddRows = False
        Me.TeamAVGOBPViewDataGridView.AllowUserToDeleteRows = False
        Me.TeamAVGOBPViewDataGridView.AutoGenerateColumns = False
        Me.TeamAVGOBPViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeamAVGOBPViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6})
        Me.TeamAVGOBPViewDataGridView.DataSource = Me.TeamAVGOBPViewBindingSource
        Me.TeamAVGOBPViewDataGridView.Location = New System.Drawing.Point(828, 548)
        Me.TeamAVGOBPViewDataGridView.Name = "TeamAVGOBPViewDataGridView"
        Me.TeamAVGOBPViewDataGridView.ReadOnly = True
        Me.TeamAVGOBPViewDataGridView.RowHeadersVisible = False
        Me.TeamAVGOBPViewDataGridView.RowHeadersWidth = 51
        Me.TeamAVGOBPViewDataGridView.RowTemplate.Height = 24
        Me.TeamAVGOBPViewDataGridView.Size = New System.Drawing.Size(154, 61)
        Me.TeamAVGOBPViewDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OBP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "平均出塁率"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'TeamAVGOBPViewBindingSource
        '
        Me.TeamAVGOBPViewBindingSource.DataMember = "TeamAVGOBPView"
        Me.TeamAVGOBPViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'BatterBindingSource
        '
        Me.BatterBindingSource.DataMember = "Batter"
        Me.BatterBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'Vw_BatterResultBindingSource
        '
        Me.Vw_BatterResultBindingSource.DataMember = "vw_BatterResult"
        Me.Vw_BatterResultBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'VwBatterResultBindingSource
        '
        Me.VwBatterResultBindingSource.DataMember = "vw_BatterResult"
        Me.VwBatterResultBindingSource.DataSource = Me.PlayerManagementDataSet2
        '
        'PlayerManagementDataSet2
        '
        Me.PlayerManagementDataSet2.DataSetName = "PlayerManagementDataSet"
        Me.PlayerManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PlayerManagementDataSet1
        '
        Me.PlayerManagementDataSet1.DataSetName = "PlayerManagementDataSet"
        Me.PlayerManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwPitcherResultBindingSource
        '
        Me.VwPitcherResultBindingSource.DataMember = "vw_PitcherResult"
        Me.VwPitcherResultBindingSource.DataSource = Me.PlayerManagementDataSet1
        '
        'Vw_PitcherResultTableAdapter
        '
        Me.Vw_PitcherResultTableAdapter.ClearBeforeFill = True
        '
        'TopHitterViewTableAdapter
        '
        Me.TopHitterViewTableAdapter.ClearBeforeFill = True
        '
        'TopHRViewBindingSource
        '
        Me.TopHRViewBindingSource.DataSource = Me.PlayerManagementDataSet
        Me.TopHRViewBindingSource.Position = 0
        '
        'TopHRViewTableAdapter
        '
        Me.TopHRViewTableAdapter.ClearBeforeFill = True
        '
        'TopHRViewBindingSource1
        '
        Me.TopHRViewBindingSource1.DataSource = Me.PlayerManagementDataSet
        Me.TopHRViewBindingSource1.Position = 0
        '
        'TopHRViewBindingSource2
        '
        Me.TopHRViewBindingSource2.DataSource = Me.PlayerManagementDataSet
        Me.TopHRViewBindingSource2.Position = 0
        '
        'TopHRViewBindingSource3
        '
        Me.TopHRViewBindingSource3.DataSource = Me.PlayerManagementDataSet
        Me.TopHRViewBindingSource3.Position = 0
        '
        'TopSOViewTableAdapter
        '
        Me.TopSOViewTableAdapter.ClearBeforeFill = True
        '
        'TopSBViewBindingSource
        '
        Me.TopSBViewBindingSource.DataSource = Me.PlayerManagementDataSet
        Me.TopSBViewBindingSource.Position = 0
        '
        'TopSBViewTableAdapter
        '
        Me.TopSBViewTableAdapter.ClearBeforeFill = True
        '
        'TopOBPViewTableAdapter
        '
        Me.TopOBPViewTableAdapter.ClearBeforeFill = True
        '
        'TopERAViewTableAdapter
        '
        Me.TopERAViewTableAdapter.ClearBeforeFill = True
        '
        'TopKViewTableAdapter
        '
        Me.TopKViewTableAdapter.ClearBeforeFill = True
        '
        'TopKBBViewTableAdapter
        '
        Me.TopKBBViewTableAdapter.ClearBeforeFill = True
        '
        'TeamAVGAverageViewTableAdapter
        '
        Me.TeamAVGAverageViewTableAdapter.ClearBeforeFill = True
        '
        'BatterTableAdapter
        '
        Me.BatterTableAdapter.ClearBeforeFill = True
        '
        'TopAverageViewTableAdapter
        '
        Me.TopAverageViewTableAdapter.ClearBeforeFill = True
        '
        'TeamAVGOBPViewTableAdapter
        '
        Me.TeamAVGOBPViewTableAdapter.ClearBeforeFill = True
        '
        'TeamAVGERAViewTableAdapter
        '
        Me.TeamAVGERAViewTableAdapter.ClearBeforeFill = True
        '
        'TeamAVGKBBViewTableAdapter
        '
        Me.TeamAVGKBBViewTableAdapter.ClearBeforeFill = True
        '
        'RankingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1498, 890)
        Me.Controls.Add(Me.TeamAVGOBPViewDataGridView)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.TopKBBViewDataGridView)
        Me.Controls.Add(Me.TopSBViewDataGridView)
        Me.Controls.Add(Me.TopHRDataGridView)
        Me.Controls.Add(Me.TopHitterViewDataGridView)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.InningTextBox)
        Me.Controls.Add(Me.ARTextBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView10)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TopCountTextBox)
        Me.Controls.Add(Me.TopKDataGridView)
        Me.Controls.Add(Me.TopERADataGridView)
        Me.Controls.Add(Me.TopSODataGridView)
        Me.Controls.Add(Me.TopOBPDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TopAverageDataGridView)
        Me.MinimumSize = New System.Drawing.Size(1075, 707)
        Me.Text = "ランキング"
        CType(Me.TopAverageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopAverageViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopOBPDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopOBPViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSOViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopERADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopERAViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopKDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopKViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamAVGAverageViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHitterViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHitterViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHRDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHRViewBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSBViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSBViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopKBBViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopKBBViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamAVGERAViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamAVGKBBViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamAVGOBPViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamAVGOBPViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_BatterResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBatterResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerManagementDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerManagementDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPitcherResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHRViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHRViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHRViewBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHRViewBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSBViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TopAverageDataGridView As DataGridView
    Friend WithEvents TopOBPDataGridView As DataGridView
    Friend WithEvents TopSODataGridView As DataGridView
    Friend WithEvents TopERADataGridView As DataGridView
    Friend WithEvents TopKDataGridView As DataGridView
    Friend WithEvents TopCountTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents DataGridView10 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ARTextBox As TextBox
    Friend WithEvents InningTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PlayerManagementDataSet As PlayerManagementDataSet
    Friend WithEvents Vw_BatterResultBindingSource As BindingSource
    Friend WithEvents Vw_BatterResultTableAdapter As PlayerManagementDataSetTableAdapters.vw_BatterResultTableAdapter
    Friend WithEvents TableAdapterManager As PlayerManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlayerManagementDataSet1 As PlayerManagementDataSet
    Friend WithEvents VwPitcherResultBindingSource As BindingSource
    Friend WithEvents Vw_PitcherResultTableAdapter As PlayerManagementDataSetTableAdapters.vw_PitcherResultTableAdapter
    Friend WithEvents PlayerManagementDataSet2 As PlayerManagementDataSet
    Friend WithEvents VwBatterResultBindingSource As BindingSource
    Friend WithEvents TopHitterViewBindingSource As BindingSource
    Friend WithEvents TopHitterViewTableAdapter As PlayerManagementDataSetTableAdapters.TopHitterViewTableAdapter
    Friend WithEvents TopHitterViewDataGridView As DataGridView
    Friend WithEvents TopHRViewBindingSource As BindingSource
    Friend WithEvents TopHRViewTableAdapter As PlayerManagementDataSetTableAdapters.TopHRViewTableAdapter
    Friend WithEvents TopHRViewBindingSource1 As BindingSource
    Friend WithEvents TopHRViewBindingSource2 As BindingSource
    Friend WithEvents TopHRViewBindingSource3 As BindingSource
    Friend WithEvents TopHRViewBindingSource4 As BindingSource
    Friend WithEvents TopHRDataGridView As DataGridView
    Friend WithEvents TopSOViewBindingSource As BindingSource
    Friend WithEvents TopSOViewTableAdapter As PlayerManagementDataSetTableAdapters.TopSOViewTableAdapter
    Friend WithEvents TopSBViewBindingSource As BindingSource
    Friend WithEvents TopSBViewTableAdapter As PlayerManagementDataSetTableAdapters.TopSBViewTableAdapter
    Friend WithEvents TopSBViewBindingSource1 As BindingSource
    Friend WithEvents TopSBViewDataGridView As DataGridView
    Friend WithEvents TopAverageViewBindingSource As BindingSource
    Friend WithEvents TopOBPViewBindingSource As BindingSource
    Friend WithEvents TopOBPViewTableAdapter As PlayerManagementDataSetTableAdapters.TopOBPViewTableAdapter
    Friend WithEvents TopERAViewBindingSource As BindingSource
    Friend WithEvents TopERAViewTableAdapter As PlayerManagementDataSetTableAdapters.TopERAViewTableAdapter
    Friend WithEvents TopKViewBindingSource As BindingSource
    Friend WithEvents TopKViewTableAdapter As PlayerManagementDataSetTableAdapters.TopKViewTableAdapter
    Friend WithEvents TopKBBViewBindingSource As BindingSource
    Friend WithEvents TopKBBViewTableAdapter As PlayerManagementDataSetTableAdapters.TopKBBViewTableAdapter
    Friend WithEvents TopKBBViewDataGridView As DataGridView
    Friend WithEvents TeamAVGAverageViewBindingSource As BindingSource
    Friend WithEvents TeamAVGAverageViewTableAdapter As PlayerManagementDataSetTableAdapters.TeamAVGAverageViewTableAdapter
    Friend WithEvents AverageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents BatterBindingSource As BindingSource
    Friend WithEvents BatterTableAdapter As PlayerManagementDataSetTableAdapters.BatterTableAdapter
    Friend WithEvents TopAverageViewTableAdapter As PlayerManagementDataSetTableAdapters.TopAverageViewTableAdapter
    Friend WithEvents TeamAVGOBPViewBindingSource As BindingSource
    Friend WithEvents TeamAVGOBPViewTableAdapter As PlayerManagementDataSetTableAdapters.TeamAVGOBPViewTableAdapter
    Friend WithEvents TeamAVGOBPViewDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TeamAVGERAViewBindingSource As BindingSource
    Friend WithEvents TeamAVGERAViewTableAdapter As PlayerManagementDataSetTableAdapters.TeamAVGERAViewTableAdapter
    Friend WithEvents ERADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TeamAVGKBBViewBindingSource As BindingSource
    Friend WithEvents TeamAVGKBBViewTableAdapter As PlayerManagementDataSetTableAdapters.TeamAVGKBBViewTableAdapter
    Friend WithEvents PitcheridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IPDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents RDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KBBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Player_id As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents KDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IPDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents average As DataGridViewTextBoxColumn
    Friend WithEvents ARDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents OBPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ARDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ERADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
End Class
