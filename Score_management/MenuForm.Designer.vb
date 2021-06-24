<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        Me.ChartButton = New System.Windows.Forms.Button()
        Me.RankingButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ChartButton
        '
        Me.ChartButton.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ChartButton.Location = New System.Drawing.Point(12, 56)
        Me.ChartButton.Name = "ChartButton"
        Me.ChartButton.Size = New System.Drawing.Size(204, 114)
        Me.ChartButton.TabIndex = 1
        Me.ChartButton.Text = "選手一覧・検索"
        Me.ChartButton.UseVisualStyleBackColor = True
        '
        'RankingButton
        '
        Me.RankingButton.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RankingButton.Location = New System.Drawing.Point(242, 56)
        Me.RankingButton.Name = "RankingButton"
        Me.RankingButton.Size = New System.Drawing.Size(113, 114)
        Me.RankingButton.TabIndex = 2
        Me.RankingButton.Text = "ランキング"
        Me.RankingButton.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(103, 203)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(113, 44)
        Me.RegisterButton.TabIndex = 3
        Me.RegisterButton.Text = "選手登録"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'SettingButton
        '
        Me.SettingButton.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SettingButton.Location = New System.Drawing.Point(242, 203)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(113, 44)
        Me.SettingButton.TabIndex = 4
        Me.SettingButton.Text = "設定"
        Me.SettingButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 289)
        Me.Controls.Add(Me.SettingButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.RankingButton)
        Me.Controls.Add(Me.ChartButton)
        Me.Name = "MenuForm"
        Me.Text = "menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChartButton As Button
    Friend WithEvents RankingButton As Button
    Friend WithEvents RegisterButton As Button
    Friend WithEvents SettingButton As Button
End Class
