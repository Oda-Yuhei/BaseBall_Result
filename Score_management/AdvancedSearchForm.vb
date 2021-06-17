Public Class AdvancedSearchForm
    Public select_position As New List(Of String) 'ポジションリスト
    Public Evaluation As String　'評価対象
    Public select_count As Integer '表示数
    Public Sort_Top As Boolean '表示順
    Public pitcher_data As Boolean = False '投手データを含めるか
    Public Regular_seat As Integer = 0 '規定打席
    Public Pitcher_or_Fielder As Integer '0 pitche 1 fielder
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            select_count = CInt(Count.Text)
        Catch ex As Exception
            MsgBox("表示件数：数値を入力してください")
            Return
        End Try
        If RadioButton1.Checked Then
            Sort_Top = True
        Else
            Sort_Top = False
        End If

        If CheckBox1.Checked Then
            pitcher_data = True
        End If
        If TextBox1.Text = "(野手選択時規定打席)" Then
            Regular_seat = 0
        Else
            Try
                Regular_seat = CInt(TextBox1.Text)
            Catch ex As Exception
                MsgBox("規定打席欄に正しい数値を入力してください")
            End Try
        End If
        ChartForm.Origin_RadioButton.Visible = True
        ChartForm.Origin_RadioButton.Checked = True

        If PitcherComboBox.Text <> "(投手用)" Then '野手が選択されたとき

        ElseIf FieldPlayerComboBox.Text <> "(野手用)" Then '投手が選択されたとき

        End If
    End Sub

    Private Sub PositionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PositionComboBox.SelectedIndexChanged
        Dim str As String
        str = PositionComboBox.Text
        If Label2.Text.Contains(PositionComboBox.SelectedItem) Then '同じものがあれば削除
            select_position.Remove(PositionComboBox.SelectedItem)
            Select_Tostring()
        Else
            select_position.Add(str)
            Select_Tostring()
        End If


    End Sub

    Public Sub Select_Tostring()
        Dim str As String = ""
        For Each i In select_position
            str &= i + ","
        Next
        Label2.Text = str
    End Sub
End Class
