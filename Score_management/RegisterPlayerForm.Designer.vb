<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPlayerForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.EnterButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 237)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(219, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "名前"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(219, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ポジション"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(219, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "出身校"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(219, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "利腕"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(219, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "コメント"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(307, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(307, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(173, 22)
        Me.TextBox2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(219, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "フリガナ"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(307, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(173, 22)
        Me.TextBox3.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ピッチャー", "キャッチャー", "ファースト", "セカンド", "ショート", "サード", "レフト", "センター", "ライト", "野手", "内野", "外野"})
        Me.ComboBox1.Location = New System.Drawing.Point(307, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(173, 23)
        Me.ComboBox1.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"右投/右打", "左投/左打", "右投/左打", "左投/右打"})
        Me.ComboBox2.Location = New System.Drawing.Point(307, 125)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(173, 23)
        Me.ComboBox2.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(307, 152)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(173, 164)
        Me.TextBox4.TabIndex = 12
        '
        'EnterButton
        '
        Me.EnterButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EnterButton.Location = New System.Drawing.Point(307, 343)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(114, 50)
        Me.EnterButton.TabIndex = 13
        Me.EnterButton.Text = "登録"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 405)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents EnterButton As Button
End Class
