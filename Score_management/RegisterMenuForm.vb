Public Class RegisterMenuForm
    Private Sub metaButton_Click(sender As Object, e As EventArgs) Handles metaButton.Click
        Dim playerfrom As New RegisterPlayerForm
        playerfrom.Show()
    End Sub

    Private Sub ResultButton_Click(sender As Object, e As EventArgs) Handles ResultButton.Click
        Dim resultfrom As New RegisterResultForm
        resultfrom.Show()
    End Sub
End Class