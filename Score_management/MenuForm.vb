Public Class MenuForm

    Private Sub ChartButton_Click(sender As Object, e As EventArgs) Handles ChartButton.Click
        Dim chartform As New ChartForm
        chartform.Show()
    End Sub

    Private Sub RankingButton_Click(sender As Object, e As EventArgs) Handles RankingButton.Click
        Dim rankingform As New RankingForm
        rankingform.Show()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim registerform As New RegisterPlayerForm
        registerform.Show()
    End Sub

    Private Sub SettingButton_Click(sender As Object, e As EventArgs) Handles SettingButton.Click
        Dim settingform As New SettingForm
        settingform.Show()

    End Sub

    Private Sub MenuForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LogonForm.Close()
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not LogonForm.Auth = True Then
            SettingButton.Visible = False
        Else
            SettingButton.Visible = True
        End If
    End Sub
End Class