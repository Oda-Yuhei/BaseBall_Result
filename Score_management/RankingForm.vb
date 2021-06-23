Public Class RankingForm
    Private Sub RankingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '打者欄
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
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        '打者欄
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
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopAverageDataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopAverageDataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub

    Private Sub TopOBPDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopOBPDataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopOBPDataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub

    Private Sub TopHitterViewDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopHitterViewDataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopHitterViewDataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub

    Private Sub TopHRDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopHRDataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopHRDataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub

    Private Sub TopSODataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopSODataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopSODataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub

    Private Sub TopSBViewDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopSBViewDataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopSBViewDataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub

    Private Sub TopERADataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopERADataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopERADataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub

    Private Sub TopKDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopKDataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopKDataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub

    Private Sub TopKBBViewDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TopKBBViewDataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = TopKBBViewDataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub
End Class