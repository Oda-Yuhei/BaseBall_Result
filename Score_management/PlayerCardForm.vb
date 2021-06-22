Imports System.Data.SqlClient
Public Class PlayerCardForm
    Private Sub PlayerCardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Vw_PitcherResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_PitcherResult)
        'TODO: このコード行はデータを 'PlayerManagementDataSet.Player_Result' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Player_ResultTableAdapter.Fill(Me.PlayerManagementDataSet.Player_Result)

        'TODO: このコード行はデータを 'PlayerManagementDataSet.vw_Playerlist' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_PlayerlistTableAdapter.Fill(Me.PlayerManagementDataSet.vw_Playerlist)
        'TODO: このコード行はデータを 'PlayerManagementDataSet.vw_BatterResult' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_BatterResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_BatterResult)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show($"本当に{NameTextBox.Text}のデータを削除してもよろしいですか？", "データ削除", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If result = DialogResult.OK Then
            Try
                Using conn As New SqlConnection
                    conn.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
                    conn.Open()
                    Dim sql As String = "DELETE FROM Pitcher WHERE Pitcher_id = (SELECT Pitcher_id FROM Player_Result WHERE Player_id = @player_id)"
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@player_id", Me.Player_idTextBox.Text)

                                cmd.ExecuteNonQuery()
                                transaction.Commit()
                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)
                        End Try
                    End Using

                    sql = "DELETE FROM Batter WHERE Batter_id = (SELECT Batter_id FROM Player_Result WHERE Player_id = @player_id)"
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@player_id", Me.Player_idTextBox.Text)

                                cmd.ExecuteNonQuery()
                                transaction.Commit()
                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)
                        End Try
                    End Using

                    sql = "DELETE FROM Player WHERE Player_id = @player_id"
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@player_id", Me.Player_idTextBox.Text)

                                cmd.ExecuteNonQuery()
                                transaction.Commit()
                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)
                        End Try
                    End Using

                    sql = "DELETE FROM Player_Result WHERE Player_id = @player_id"
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@player_id", Me.Player_idTextBox.Text)

                                cmd.ExecuteNonQuery()
                                transaction.Commit()
                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)
                        End Try
                    End Using

                End Using
            Catch ex As Exception

            End Try

            ChartForm.Vw_PlayerlistTableAdapter.Fill(ChartForm.PlayerManagementDataSet.vw_Playerlist)
            ChartForm.Vw_PitcherResultTableAdapter.Fill(ChartForm.PlayerManagementDataSet.vw_PitcherResult)
            ChartForm.Vw_BatterResultTableAdapter.Fill(ChartForm.PlayerManagementDataSet.vw_BatterResult)
            Me.Close()

        ElseIf result = DialogResult.Cancel Then
            Return
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        Dim result As DialogResult = MessageBox.Show("データを上書きしてもよろしいですか？", "データ編集", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If result = DialogResult.OK Then
            Dim sql As String = "UPDATE Player SET name = @name, rub = @rub, origin_school = @origin_school, position = @position, TandB = @TandB, comment = @comment WHERE Player_id = @player_id"
            Try
                Using conn As New SqlConnection
                    conn.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
                    conn.Open()
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@name", Me.NameTextBox.Text)
                                cmd.Parameters.AddWithValue("@rub", Me.RubTextBox.Text)
                                cmd.Parameters.AddWithValue("@origin_school", Me.Origin_schoolTextBox.Text)
                                cmd.Parameters.AddWithValue("@position", Me.PositionTextBox.Text)
                                cmd.Parameters.AddWithValue("@TandB", Me.TandBTextBox.Text)
                                cmd.Parameters.AddWithValue("@comment", Me.CommentTextBox.Text)
                                cmd.Parameters.AddWithValue("@player_id", Me.Player_idTextBox.Text)
                                cmd.ExecuteNonQuery()

                                transaction.Commit()
                                ChartForm.Vw_PlayerlistTableAdapter.Fill(ChartForm.PlayerManagementDataSet.vw_Playerlist)
                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)

                        End Try
                    End Using
                End Using

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf result = DialogResult.Cancel Then
            Return
        End If
    End Sub
    Public select_position As New List(Of String)
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PositionComboBox.SelectedIndexChanged
        Dim str As String
        str = PositionComboBox.Text
        If PositionTextBox.Text.Contains(PositionComboBox.SelectedItem) Then '同じものがあれば削除
            select_position.Remove(PositionComboBox.SelectedItem)
            Select_Tostring()
        Else
            select_position.Add(str)
            Select_Tostring()
        End If

    End Sub
    Public Function Select_InnerFielder_sarch() As Boolean
        Dim pos As New List(Of String)(New String() {"キャッチャー", "ファースト", "セカンド", "ショート", "サード"})
        If pos.IndexOf(PositionComboBox.SelectedItem) = -1 Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Sub Select_Tostring()
        Dim str As String = ""
        For Each i In select_position
            str &= i + ","
        Next
        Dim Tstr As String = str.TrimEnd(CType(",", Char))
        PositionTextBox.Text = Tstr
    End Sub

End Class