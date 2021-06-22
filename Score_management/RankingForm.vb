Public Class RankingForm
    Private Sub RankingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopSOViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopSOView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopHRViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopHRView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopHitterViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopHitterView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopAverageViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopAverageView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopSBViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopSBView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopOBPViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopOBPView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.TopSOViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopSOView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopHRViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopHRView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopHitterViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopHitterView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopAverageViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopAverageView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopSBViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopSBView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
        Me.TopOBPViewTableAdapter.Fill(Me.PlayerManagementDataSet.TopOBPView, CInt(TopCountTextBox.Text), CInt(ARTextBox.Text))
    End Sub
End Class