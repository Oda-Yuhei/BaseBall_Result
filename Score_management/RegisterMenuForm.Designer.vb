<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterMenuForm
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
        Me.metaButton = New System.Windows.Forms.Button()
        Me.ResultButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'metaButton
        '
        Me.metaButton.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.metaButton.Location = New System.Drawing.Point(13, 13)
        Me.metaButton.Name = "metaButton"
        Me.metaButton.Size = New System.Drawing.Size(122, 114)
        Me.metaButton.TabIndex = 0
        Me.metaButton.Text = "情報登録"
        Me.metaButton.UseVisualStyleBackColor = True
        '
        'ResultButton
        '
        Me.ResultButton.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ResultButton.Location = New System.Drawing.Point(141, 13)
        Me.ResultButton.Name = "ResultButton"
        Me.ResultButton.Size = New System.Drawing.Size(122, 114)
        Me.ResultButton.TabIndex = 1
        Me.ResultButton.Text = "成績登録"
        Me.ResultButton.UseVisualStyleBackColor = True
        '
        'RegisterMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 153)
        Me.Controls.Add(Me.ResultButton)
        Me.Controls.Add(Me.metaButton)
        Me.Name = "RegisterMenuForm"
        Me.Text = "RegisterMenuForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents metaButton As Button
    Friend WithEvents ResultButton As Button
End Class
