<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedSearchForm
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
        Me.PositionComboBox = New System.Windows.Forms.ComboBox()
        Me.FieldPlayerComboBox = New System.Windows.Forms.ComboBox()
        Me.PitcherComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Count = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'PositionComboBox
        '
        Me.PositionComboBox.FormattingEnabled = True
        Me.PositionComboBox.Items.AddRange(New Object() {"投手", "キャッチャー", "ファースト", "セカンド", "ショート", "サード", "野手", "内野手", "外野手"})
        Me.PositionComboBox.Location = New System.Drawing.Point(189, 44)
        Me.PositionComboBox.Name = "PositionComboBox"
        Me.PositionComboBox.Size = New System.Drawing.Size(229, 23)
        Me.PositionComboBox.TabIndex = 0
        '
        'FieldPlayerComboBox
        '
        Me.FieldPlayerComboBox.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FieldPlayerComboBox.FormattingEnabled = True
        Me.FieldPlayerComboBox.Items.AddRange(New Object() {"打率", "出塁率", "長打率", "犠飛・犠打"})
        Me.FieldPlayerComboBox.Location = New System.Drawing.Point(189, 149)
        Me.FieldPlayerComboBox.Name = "FieldPlayerComboBox"
        Me.FieldPlayerComboBox.Size = New System.Drawing.Size(229, 27)
        Me.FieldPlayerComboBox.TabIndex = 2
        Me.FieldPlayerComboBox.Text = "(野手用)"
        '
        'PitcherComboBox
        '
        Me.PitcherComboBox.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PitcherComboBox.FormattingEnabled = True
        Me.PitcherComboBox.Items.AddRange(New Object() {"防御率", "K/BB", "奪三振", "投球回数"})
        Me.PitcherComboBox.Location = New System.Drawing.Point(189, 120)
        Me.PitcherComboBox.Name = "PitcherComboBox"
        Me.PitcherComboBox.Size = New System.Drawing.Size(229, 27)
        Me.PitcherComboBox.TabIndex = 3
        Me.PitcherComboBox.Text = "(投手用)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(157, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "検索"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Count
        '
        Me.Count.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Count.Location = New System.Drawing.Point(189, 260)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(229, 27)
        Me.Count.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ポジション"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "評価項目"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "表示数"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 47)
        Me.Label2.TabIndex = 13
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(210, 309)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 26)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Top"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(310, 309)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 26)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.Text = "Worst"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(189, 182)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 27)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "(野手選択時規定打席)"
        Me.TextBox1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(189, 213)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 23)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "投手データを含む"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'AdvancedSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 421)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PitcherComboBox)
        Me.Controls.Add(Me.FieldPlayerComboBox)
        Me.Controls.Add(Me.PositionComboBox)
        Me.Name = "AdvancedSearchForm"
        Me.Text = "詳細検索"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PositionComboBox As ComboBox
    Friend WithEvents FieldPlayerComboBox As ComboBox
    Friend WithEvents PitcherComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Count As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
