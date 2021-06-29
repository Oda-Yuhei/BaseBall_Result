Public Class RankingForm
    Private Sub RankingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RankingLoad()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        RankingLoad()
    End Sub
    Public Sub RankingLoad()
        Try
            Me.TopSOViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopSOView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
            Me.TopHRViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopHRView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
            Me.TopHitterViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopHitterView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
            Me.TopAverageViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopAverageView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
            Me.TopSBViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopSBView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
            Me.TopOBPViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopOBPView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
            '投手欄
            Me.TopERAViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopERAView, CInt(TopCountTextBox.Text), CInt(InningTextBox.Text))
            Me.TopKViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopKView, CInt(TopCountTextBox.Text), CInt(InningTextBox.Text))
            Me.TopKBBViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopKBBView, CInt(TopCountTextBox.Text), CInt(InningTextBox.Text))
            'チーム平均
            Me.TeamAVGAverageViewTableAdapter.Fill(Me.PlayerManagementDataSet.TeamAVGAverageView, CInt(ARTextBox.Text))
            Me.TeamAVGOBPViewTableAdapter.Fill(Me.PlayerManagementDataSet.TeamAVGOBPView, CInt(ARTextBox.Text))
            Me.TeamAVGERAViewTableAdapter.Fill(Me.PlayerManagementDataSet.TeamAVGERAView, CInt(InningTextBox.Text))
            Me.TeamAVGKBBViewTableAdapter.Fill(Me.PlayerManagementDataSet.TeamAVGKBBView, CInt(InningTextBox.Text))


        Catch ex As Exception
            MsgBox("Dataの最大範囲外もしくは不正文字入力です")
        End Try
    End Sub

    Private Sub TopKDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopKDataGridView.CellContentClick, TopKBBViewDataGridView.CellContentClick, TopERADataGridView.CellContentClick, TopSBViewDataGridView.CellContentClick, TopSODataGridView.CellContentClick, TopHRDataGridView.CellContentClick, TopHitterViewDataGridView.CellContentClick, TopOBPDataGridView.CellContentClick, TopAverageDataGridView.CellContentClick
        Dim data = CType(sender, DataGridView)
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = data.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub
End Class