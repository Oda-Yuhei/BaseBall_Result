Public Class PersonalEditing
    Private Sub PersonalEditing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PlayerManagementDataSet.vw_PitcherResult' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_PitcherResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_PitcherResult)

    End Sub
End Class