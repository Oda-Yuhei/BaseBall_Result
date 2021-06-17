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
        Dim registerform As New RegisterMenuForm
        registerform.Show()
    End Sub
End Class