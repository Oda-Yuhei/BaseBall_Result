Imports System.Data.SqlClient
Imports System.Configuration
Public Class ChartForm

    Public line As New List(Of String)
    Public positioncode As String
    Public farstcode As String
    Private Sub ChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Vw_PitcherResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_PitcherResult)
            Me.Vw_BatterResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_BatterResult)
            Me.Vw_PlayerlistTableAdapter.Fill(Me.PlayerManagementDataSet.vw_Playerlist)

        Catch ex As Exception
            MsgBox("No Data")
        End Try

    End Sub
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Try
            Dim str As String
            str = name_ComboBox.SelectedItem
            Dim fillter_position As String = PositionComboBox.SelectedItem
            'defaultDataGridViewをsearch
            If Not name_ComboBox.Text = "全て" And PositionComboBox.Text = "全て" Then
                Initial_sarch(str)
            ElseIf name_ComboBox.Text = "全て" And Not PositionComboBox.Text = "全て" Then
                Position_sarch(fillter_position, 1)
            ElseIf name_ComboBox.Text = "全て" And PositionComboBox.Text = "全て" Then
                Me.Vw_PlayerlistTableAdapter.Fill(Me.PlayerManagementDataSet.vw_Playerlist)
            ElseIf fillter_position = Nothing And str = Nothing Then
                Return
            Else
                Initial_Position_sarch(str, fillter_position)
            End If


        Catch ex As Exception
            MsgBox("No Data")

        End Try

    End Sub

    Public Sub Position_sarch(pos As String, num As Integer)
        Dim str As String
        str = "%" & pos & "%"
        If num = 1 Then
            Try
                Me.Vw_PlayerlistTableAdapter.FillByPosition(Me.PlayerManagementDataSet.vw_Playerlist, str)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf num = 2 Then

            Try
                Me.Vw_BatterResultTableAdapter.FillByposition(Me.PlayerManagementDataSet.vw_BatterResult, str)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Public Sub Initial_Position_sarch(ini As String, pos As String)
        Dim str As String
        str = "%" & pos & "%"
        ini = ini.Substring(0, 1)
        Gojuon(ini)

        Try
            Me.Vw_PlayerlistTableAdapter.FillByName_Position(Me.PlayerManagementDataSet.vw_Playerlist, str, line(0) & "%", line(1) & "%", line(2) & "%", line(3) & "%", line(4) & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Initial_sarch(Initialname As String)
        Initialname = Initialname.Substring(0, 1)
        Gojuon(Initialname)
        Try
            Me.Vw_PlayerlistTableAdapter.FillByInitial(Me.PlayerManagementDataSet.vw_Playerlist, line(0) & "%", line(1) & "%", line(2) & "%", line(3) & "%", line(4) & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Gojuon(initial As String)
        line.Clear()

        If initial = "あ" Then
            line.Add("あ")
            line.Add("い")
            line.Add("う")
            line.Add("え")
            line.Add("お")

        ElseIf initial = "か" Then
            line.Add("か")
            line.Add("き")
            line.Add("く")
            line.Add("け")
            line.Add("こ")

        ElseIf initial = "さ" Then
            line.Add("さ")
            line.Add("し")
            line.Add("す")
            line.Add("せ")
            line.Add("そ")

        ElseIf initial = "た" Then
            line.Add("た")
            line.Add("ち")
            line.Add("つ")
            line.Add("て")
            line.Add("と")

        ElseIf initial = "な" Then
            line.Add("な")
            line.Add("に")
            line.Add("ぬ")
            line.Add("ね")
            line.Add("の")
        ElseIf initial = "は" Then
            line.Add("は")
            line.Add("ひ")
            line.Add("ふ")
            line.Add("へ")
            line.Add("ほ")
        ElseIf initial = "ま" Then
            line.Add("ま")
            line.Add("み")
            line.Add("む")
            line.Add("め")
            line.Add("も")

        ElseIf initial = "や" Then
            line.Add("や")
            line.Add("ゆ")
            line.Add("よ")
            line.Add("ゆ")
            line.Add("よ")

        ElseIf initial = "ら" Then
            line.Add("ら")
            line.Add("り")
            line.Add("る")
            line.Add("れ")
            line.Add("ろ")

        ElseIf initial = "わ" Then
            line.Add("わ")
            line.Add("わ")
            line.Add("わ")
            line.Add("わ")
            line.Add("わ")
        End If

    End Sub
    Private Sub Pitcher_Result_CheckedChanged(sender As Object, e As EventArgs) Handles Pitcher_Result.CheckedChanged, Basic_information.CheckedChanged, Batter_Result.CheckedChanged
        Dim button = CType(sender, RadioButton)
        Select Case True
            Case Pitcher_Result.Checked
                Me.DefaultDataGridView.Visible = False
                Me.PitcherResultDataGridView.Visible = True
                Me.BatterResultDataGridView.Visible = False

                Me.PositionComboBox.Visible = False
                Me.name_ComboBox.Visible = False
                Me.EnterButton.Visible = False
            Case Basic_information.Checked
                Me.DefaultDataGridView.Visible = True
                Me.PitcherResultDataGridView.Visible = False
                Me.BatterResultDataGridView.Visible = False

                Me.PositionComboBox.Visible = True
                Me.name_ComboBox.Visible = True
                Me.EnterButton.Visible = True
            Case Batter_Result.Checked
                Me.DefaultDataGridView.Visible = False
                Me.PitcherResultDataGridView.Visible = False
                Me.BatterResultDataGridView.Visible = True

                Me.name_ComboBox.Visible = False
                Me.PositionComboBox.Visible = False
                Me.EnterButton.Visible = False

        End Select
    End Sub
    Private Sub DefaultDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DefaultDataGridView.CellContentClick, BatterResultDataGridView.CellContentClick, PitcherResultDataGridView.CellContentClick
        Dim data = CType(sender, DataGridView)
        Dim cardform As New PlayerCardForm

        Dim PlayerID As Integer = data.CurrentRow.Cells(0).Value
        cardform.ID = PlayerID
        cardform.Show()

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID)
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub
End Class