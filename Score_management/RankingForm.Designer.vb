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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopAverageViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerManagementDataSet = New Score_management.PlayerManagementDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TopOBPViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopSOViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.DataGridView9 = New System.Windows.Forms.DataGridView()
        Me.TopCountTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DataGridView10 = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OptionButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ARTextBox = New System.Windows.Forms.TextBox()
        Me.InningTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TopHitterViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopHitterViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopHRViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopHRViewBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopSBViewDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopSBViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TopAverageViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopAverageViewTableAdapter()
        Me.TopOBPViewTableAdapter = New Score_management.PlayerManagementDataSetTableAdapters.TopOBPViewTableAdapter()
        Me.NameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopAverageViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopOBPViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSOViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHitterViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHitterViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHRViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopHRViewBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSBViewDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSBViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label7.Location = New System.Drawing.Point(255, 441)
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
        Me.Label9.Location = New System.Drawing.Point(498, 441)
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn1, Me.ARDataGridViewTextBoxColumn1, Me.average})
        Me.DataGridView1.DataSource = Me.TopAverageViewBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(237, 341)
        Me.DataGridView1.TabIndex = 10
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "名前"
        Me.NameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
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
        'average
        '
        Me.average.DataPropertyName = "average"
        Me.average.HeaderText = "打率"
        Me.average.MinimumWidth = 6
        Me.average.Name = "average"
        Me.average.ReadOnly = True
        Me.average.Width = 66
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
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn2, Me.OBPDataGridViewTextBoxColumn, Me.ARDataGridViewTextBoxColumn2})
        Me.DataGridView2.DataSource = Me.TopOBPViewBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(259, 59)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(237, 341)
        Me.DataGridView2.TabIndex = 11
        '
        'TopOBPViewBindingSource
        '
        Me.TopOBPViewBindingSource.DataMember = "TopOBPView"
        Me.TopOBPViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.SODataGridViewTextBoxColumn, Me.ARDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.TopSOViewBindingSource
        Me.DataGridView5.Location = New System.Drawing.Point(988, 59)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.RowHeadersVisible = False
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(237, 341)
        Me.DataGridView5.TabIndex = 14
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
        'DataGridView7
        '
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Location = New System.Drawing.Point(12, 481)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.RowHeadersWidth = 51
        Me.DataGridView7.RowTemplate.Height = 24
        Me.DataGridView7.Size = New System.Drawing.Size(237, 389)
        Me.DataGridView7.TabIndex = 16
        '
        'DataGridView8
        '
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Location = New System.Drawing.Point(259, 481)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.RowHeadersWidth = 51
        Me.DataGridView8.RowTemplate.Height = 24
        Me.DataGridView8.Size = New System.Drawing.Size(237, 389)
        Me.DataGridView8.TabIndex = 17
        '
        'DataGridView9
        '
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.Location = New System.Drawing.Point(502, 481)
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.RowHeadersWidth = 51
        Me.DataGridView9.RowTemplate.Height = 24
        Me.DataGridView9.Size = New System.Drawing.Size(237, 389)
        Me.DataGridView9.TabIndex = 18
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
        Me.ExitButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1264, 791)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(140, 51)
        Me.ExitButton.TabIndex = 22
        Me.ExitButton.Text = "更新"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DataGridView10
        '
        Me.DataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView10.Location = New System.Drawing.Point(745, 481)
        Me.DataGridView10.Name = "DataGridView10"
        Me.DataGridView10.RowHeadersWidth = 51
        Me.DataGridView10.RowTemplate.Height = 24
        Me.DataGridView10.Size = New System.Drawing.Size(237, 389)
        Me.DataGridView10.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(741, 441)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 24)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "チーム平均"
        '
        'OptionButton
        '
        Me.OptionButton.Location = New System.Drawing.Point(860, 440)
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Size = New System.Drawing.Size(122, 23)
        Me.OptionButton.TabIndex = 25
        Me.OptionButton.Text = "規定値設定"
        Me.OptionButton.UseVisualStyleBackColor = True
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
        Me.TopHitterViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
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
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "名前"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "H"
        Me.DataGridViewTextBoxColumn2.HeaderText = "HIT"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 59
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "打席"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 66
        '
        'TopHitterViewBindingSource
        '
        Me.TopHitterViewBindingSource.DataMember = "TopHitterView"
        Me.TopHitterViewBindingSource.DataSource = Me.PlayerManagementDataSet
        '
        'TopHRViewDataGridView
        '
        Me.TopHRViewDataGridView.AllowUserToAddRows = False
        Me.TopHRViewDataGridView.AllowUserToDeleteRows = False
        Me.TopHRViewDataGridView.AutoGenerateColumns = False
        Me.TopHRViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopHRViewDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopHRViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopHRViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5})
        Me.TopHRViewDataGridView.DataSource = Me.TopHRViewBindingSource4
        Me.TopHRViewDataGridView.Location = New System.Drawing.Point(745, 59)
        Me.TopHRViewDataGridView.Name = "TopHRViewDataGridView"
        Me.TopHRViewDataGridView.ReadOnly = True
        Me.TopHRViewDataGridView.RowHeadersVisible = False
        Me.TopHRViewDataGridView.RowHeadersWidth = 51
        Me.TopHRViewDataGridView.RowTemplate.Height = 24
        Me.TopHRViewDataGridView.Size = New System.Drawing.Size(237, 341)
        Me.TopHRViewDataGridView.TabIndex = 31
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "HR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "HR"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 55
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
        'TopHRViewBindingSource4
        '
        Me.TopHRViewBindingSource4.DataMember = "TopHRView"
        Me.TopHRViewBindingSource4.DataSource = Me.PlayerManagementDataSet
        '
        'TopSBViewDataGridView1
        '
        Me.TopSBViewDataGridView1.AllowUserToAddRows = False
        Me.TopSBViewDataGridView1.AllowUserToDeleteRows = False
        Me.TopSBViewDataGridView1.AutoGenerateColumns = False
        Me.TopSBViewDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TopSBViewDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TopSBViewDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopSBViewDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn11})
        Me.TopSBViewDataGridView1.DataSource = Me.TopSBViewBindingSource1
        Me.TopSBViewDataGridView1.Location = New System.Drawing.Point(1231, 59)
        Me.TopSBViewDataGridView1.Name = "TopSBViewDataGridView1"
        Me.TopSBViewDataGridView1.ReadOnly = True
        Me.TopSBViewDataGridView1.RowHeadersVisible = False
        Me.TopSBViewDataGridView1.RowHeadersWidth = 51
        Me.TopSBViewDataGridView1.RowTemplate.Height = 24
        Me.TopSBViewDataGridView1.Size = New System.Drawing.Size(237, 341)
        Me.TopSBViewDataGridView1.TabIndex = 33
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
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "AR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "打席"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 66
        '
        'TopSBViewBindingSource1
        '
        Me.TopSBViewBindingSource1.DataMember = "TopSBView"
        Me.TopSBViewBindingSource1.DataSource = Me.PlayerManagementDataSet
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
        'TopAverageViewTableAdapter
        '
        Me.TopAverageViewTableAdapter.ClearBeforeFill = True
        '
        'TopOBPViewTableAdapter
        '
        Me.TopOBPViewTableAdapter.ClearBeforeFill = True
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
        'RankingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 890)
        Me.Controls.Add(Me.TopSBViewDataGridView1)
        Me.Controls.Add(Me.TopHRViewDataGridView)
        Me.Controls.Add(Me.TopHitterViewDataGridView)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.InningTextBox)
        Me.Controls.Add(Me.ARTextBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.OptionButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView10)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TopCountTextBox)
        Me.Controls.Add(Me.DataGridView9)
        Me.Controls.Add(Me.DataGridView8)
        Me.Controls.Add(Me.DataGridView7)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MinimumSize = New System.Drawing.Size(1075, 707)
        Me.Name = "RankingForm"
        Me.Text = "ランキング"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopAverageViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopOBPViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSOViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHitterViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHitterViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHRViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopHRViewBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSBViewDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSBViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents DataGridView8 As DataGridView
    Friend WithEvents DataGridView9 As DataGridView
    Friend WithEvents TopCountTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents DataGridView10 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents OptionButton As Button
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
    Friend WithEvents TopHRViewDataGridView As DataGridView
    Friend WithEvents TopSOViewBindingSource As BindingSource
    Friend WithEvents TopSOViewTableAdapter As PlayerManagementDataSetTableAdapters.TopSOViewTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents TopSBViewBindingSource As BindingSource
    Friend WithEvents TopSBViewTableAdapter As PlayerManagementDataSetTableAdapters.TopSBViewTableAdapter
    Friend WithEvents TopSBViewBindingSource1 As BindingSource
    Friend WithEvents TopSBViewDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents TopAverageViewBindingSource As BindingSource
    Friend WithEvents TopAverageViewTableAdapter As PlayerManagementDataSetTableAdapters.TopAverageViewTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ARDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents average As DataGridViewTextBoxColumn
    Friend WithEvents TopOBPViewBindingSource As BindingSource
    Friend WithEvents TopOBPViewTableAdapter As PlayerManagementDataSetTableAdapters.TopOBPViewTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents OBPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ARDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
