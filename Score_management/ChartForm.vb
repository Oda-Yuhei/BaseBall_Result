Imports System.Data.SqlClient
Imports System.Configuration


'----------------------------------------------
'6月16日最終作業
'batter_resultデータテーブルのクエリー構成編集
'打率カラムの追加

'６月17日スタート作業
'batter_resultデータテーブルのクエリー構成編集
'出塁率カラムの追加

'pittya_result
'防御率KBB等の追加
'----------------------------------------------
Public Class ChartForm

    Public advancedsarcform As New AdvancedSearchForm
    Public farstcode As String
    Public positioncode As String
    Private Sub ChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PlayerManagementDataSet.AllresultView' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.AllresultViewTableAdapter.Fill(Me.PlayerManagementDataSet.AllresultView)
        'TODO: このコード行はデータを 'PlayerManagementDataSet1.vw_PitcherResult' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_PitcherResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_PitcherResult)
        'TODO: このコード行はデータを 'PlayerManagementDataSet.vw_BatterResult' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_BatterResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_BatterResult)
        'TODO: このコード行はデータを 'PlayerManagementDataSet.vw_Playerlist' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_PlayerlistTableAdapter.Fill(Me.PlayerManagementDataSet.vw_Playerlist)

    End Sub
    Public line As New List(Of String)
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Dim str As String
        str = name_ComboBox.SelectedItem
        Dim fillter_position As String = PositionComboBox.SelectedItem

        If Basic_information.Checked Then
            'defaultDataGridViewをsearch
            If Not name_ComboBox.Text = "(五十音)" And PositionComboBox.Text = "(ポジション)" Then
                Initial_sarch(str)
            ElseIf name_ComboBox.Text = "(五十音)" And Not PositionComboBox.Text = "(ポジション)" Then
                Position_sarch(fillter_position, 1)
            Else
                Initial_Position_sarch(str, fillter_position)
            End If


        ElseIf Pitcher_Result.Checked Then
            'PitcherResultDataGridViewをsearch

        ElseIf Batter_Result.Checked Then
            Position_sarch(fillter_position, 2)
            'BatterResultDataGridViewをsearch
        ElseIf Origin_RadioButton.Checked Then
            'OriginDataGridViewをsearch
        End If


    End Sub

    Public Sub Position_sarch(pos, num)
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
    Public Sub Initial_Position_sarch(ini, pos)
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

    Public Sub Initial_sarch(Initialname)
        Initialname = Initialname.Substring(0, 1)
        Gojuon(Initialname)
        Try
            Me.Vw_PlayerlistTableAdapter.FillByInitial(Me.PlayerManagementDataSet.vw_Playerlist, line(0) & "%", line(1) & "%", line(2) & "%", line(3) & "%", line(4) & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function Gojuon(initial) As List(Of String)
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
        Return line
    End Function
    Private Sub Pitcher_Result_CheckedChanged(sender As Object, e As EventArgs) Handles Pitcher_Result.CheckedChanged
        Me.defaultDataGridView.Visible = False
        Me.PitcherResultDataGridView.Visible = True
        Me.BatterResultDataGridView.Visible = False

        Me.PositionComboBox.Visible = False
        Me.name_ComboBox.Visible = False
        Me.EnterButton.Visible = False
    End Sub

    Private Sub Basic_information_CheckedChanged(sender As Object, e As EventArgs) Handles Basic_information.CheckedChanged
        Me.defaultDataGridView.Visible = True
        Me.PitcherResultDataGridView.Visible = False
        Me.BatterResultDataGridView.Visible = False

        Me.PositionComboBox.Visible = True
        Me.name_ComboBox.Visible = True
        Me.EnterButton.Visible = True

    End Sub

    Private Sub Batter_Result_CheckedChanged(sender As Object, e As EventArgs) Handles Batter_Result.CheckedChanged
        Me.defaultDataGridView.Visible = False
        Me.PitcherResultDataGridView.Visible = False
        Me.BatterResultDataGridView.Visible = True

        Me.PositionComboBox.Visible = True
        Me.name_ComboBox.Visible = False
        Me.EnterButton.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        advancedsarcform.Show()
    End Sub

    Private Sub PitcherResultDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        MsgBox("enter")
    End Sub
    Private Sub defaultDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles defaultDataGridView.CellContentClick
        Dim cardform As New PlayerCardForm
        cardform.Show()

        Dim PlayerID As Integer = defaultDataGridView.CurrentRow.Cells(0).Value

        cardform.Vw_PlayerlistTableAdapter.FillByAdvancedInfo(cardform.PlayerManagementDataSet.vw_Playerlist, PlayerID.ToString("000"))
        cardform.Vw_PitcherResultTableAdapter.FillByAdvancedPitcher(cardform.PlayerManagementDataSet.vw_PitcherResult, New System.Nullable(Of Integer)(PlayerID))
        cardform.Vw_BatterResultTableAdapter.FillByAdvancedBatter(cardform.PlayerManagementDataSet.vw_BatterResult, New System.Nullable(Of Integer)(PlayerID))
    End Sub
End Class