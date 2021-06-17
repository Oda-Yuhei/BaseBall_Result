<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ログイン設定"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "管理者権限"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "パスワード再登録"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "確認用"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "閲覧者権限"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(108, 261)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 19)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "する"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(166, 261)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 19)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "しない"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(99, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "パスワード請求"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(257, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 22)
        Me.TextBox1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(99, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 22)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "パスワード再登録"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(99, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "確認用"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(257, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 22)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(257, 294)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 22)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(257, 334)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(144, 22)
        Me.TextBox4.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(445, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "サーバー設定"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(584, 19)
        Me.CheckBox1.MinimumSize = New System.Drawing.Size(112, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 23)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Read Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'EnterButton
        '
        Me.EnterButton.Location = New System.Drawing.Point(394, 398)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(76, 40)
        Me.EnterButton.TabIndex = 16
        Me.EnterButton.Text = "登録"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SettingForm"
        Me.Text = "設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents EnterButton As Button
End Class
