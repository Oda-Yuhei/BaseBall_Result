Imports System.Data.SqlClient
Public Class RegisterPlayerForm
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Dim result As DialogResult = MessageBox.Show("データを登録します", "登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If result = DialogResult.OK Then
            Try
                Using conn As New SqlConnection
                    conn.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
                    conn.Open()

                    Dim Sql As String = "INSERT INTO Pitcher VALUES(@app, @ip, @r, @er, @k, @b, @w, @sv)"
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(Sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@app", Me.APPTextBox.Text)
                                cmd.Parameters.AddWithValue("@ip", Me.IPTextBox.Text)
                                cmd.Parameters.AddWithValue("@r", Me.RTextBox.Text)
                                cmd.Parameters.AddWithValue("@er", Me.ERTextBox.Text)
                                cmd.Parameters.AddWithValue("@k", Me.KTextBox.Text)
                                cmd.Parameters.AddWithValue("@b", Me.BTextBox.Text)
                                cmd.Parameters.AddWithValue("@w", Me.WTextBox.Text)
                                cmd.Parameters.AddWithValue("@sv", Me.SVTextBox.Text)
                                cmd.ExecuteNonQuery()
                                transaction.Commit()

                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)

                        End Try
                    End Using


                    Sql = "INSERT INTO Batter VALUES(@ar, @h, @lh, @hr, @hbp, @sh, @ibb_hbp, @so, @sb)"
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(Sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@ar", Me.ARTextBox.Text)
                                cmd.Parameters.AddWithValue("@h", Me.HTextBox.Text)
                                cmd.Parameters.AddWithValue("@lh", Me.LHTextBox.Text)
                                cmd.Parameters.AddWithValue("@hr", Me.HRTextBox.Text)
                                cmd.Parameters.AddWithValue("@hbp", Me.HBPTextBox.Text)
                                cmd.Parameters.AddWithValue("@sh", Me.SHTextBox.Text)
                                cmd.Parameters.AddWithValue("@ibb_hbp", Me.IBBandHBPTextBox.Text)
                                cmd.Parameters.AddWithValue("@so", Me.SOTextBox.Text)
                                cmd.Parameters.AddWithValue("@sb", Me.SBTextBox.Text)
                                cmd.ExecuteNonQuery()
                                transaction.Commit()

                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)

                        End Try
                        End Using

                    Sql = "INSERT INTO Player VALUES(@name, @rub, @origin_school, @position, @TandB, @comment )"
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(Sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@name", Me.NameTextBox.Text)
                                cmd.Parameters.AddWithValue("@rub", Me.RubTextBox.Text)
                                cmd.Parameters.AddWithValue("@origin_school", Me.Origin_schoolTextBox.Text)
                                cmd.Parameters.AddWithValue("@position", Me.PositionLabel.Text)
                                cmd.Parameters.AddWithValue("@TandB", Me.TandBComboBox.Text)
                                cmd.Parameters.AddWithValue("@comment", Me.CommentTextBox.Text)
                                cmd.ExecuteNonQuery()
                                transaction.Commit()

                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)

                        End Try
                    End Using
                    Sql = "INSERT INTO  Player_Result VALUES((SELECT Max(Player_id) FROM Player),(SELECT Max(Batter_id) FROM Batter),(SELECT Max(Pitcher_id) FROM Pitcher))"
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(Sql, conn, transaction)
                                cmd.ExecuteNonQuery()
                                transaction.Commit()

                            End Using
                            MsgBox("無事に登録が完了しました")
                            Me.Close()
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.StackTrace)

                        End Try

                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf result = DialogResult.Cancel Then
            Return
        End If
    End Sub
    Public select_position As New List(Of String)
    Private Sub PositionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PositionComboBox.SelectedIndexChanged
        Dim str As String
        str = PositionComboBox.Text
        If PositionLabel.Text.Contains(PositionComboBox.SelectedItem) Then '同じものがあれば削除
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
        PositionLabel.Text = Tstr
    End Sub
End Class