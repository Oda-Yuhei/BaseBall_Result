<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogonForm
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
        Me.UserComboBox = New System.Windows.Forms.ComboBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogonButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserComboBox
        '
        Me.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserComboBox.FormattingEnabled = True
        Me.UserComboBox.Items.AddRange(New Object() {"閲覧者", "管理者"})
        Me.UserComboBox.Location = New System.Drawing.Point(124, 67)
        Me.UserComboBox.Name = "UserComboBox"
        Me.UserComboBox.Size = New System.Drawing.Size(185, 23)
        Me.UserComboBox.TabIndex = 0
        '
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(124, 128)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PassTextBox.Size = New System.Drawing.Size(185, 22)
        Me.PassTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "権　　限"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "パスワード"
        '
        'LogonButton
        '
        Me.LogonButton.BackColor = System.Drawing.SystemColors.Control
        Me.LogonButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LogonButton.Location = New System.Drawing.Point(330, 60)
        Me.LogonButton.Name = "LogonButton"
        Me.LogonButton.Size = New System.Drawing.Size(101, 32)
        Me.LogonButton.TabIndex = 4
        Me.LogonButton.Text = "ログオン"
        Me.LogonButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Location = New System.Drawing.Point(330, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 32)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "キャンセル"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "選手成績管理システム"
        '
        'LogonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(465, 204)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LogonButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.UserComboBox)
        Me.Name = "LogonForm"
        Me.Text = "Logon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserComboBox As ComboBox
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LogonButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
