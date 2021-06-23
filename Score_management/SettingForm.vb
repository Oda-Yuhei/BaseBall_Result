Imports System.Data.SqlClient
Public Class SettingForm
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Select Case DirectCast(sender, CheckBox).CheckState
            Case CheckState.Checked
                TextBox1.Visible = True
                TextBox2.Visible = True
            Case CheckState.Unchecked
                TextBox1.Visible = False
                TextBox2.Visible = False
        End Select

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Select Case DirectCast(sender, CheckBox).CheckState
            Case CheckState.Checked
                TextBox3.Visible = True
                TextBox4.Visible = True
            Case CheckState.Unchecked
                TextBox3.Visible = False
                TextBox4.Visible = False
        End Select

    End Sub

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Dim num As Integer = pattern()
        If num = 1 Then

            If nulljudge(num) = 1 Then
                ConnectSQLPass2()
                ConnectSQLPass3()
            Else
                Return
            End If
        ElseIf num = 2 Then '閲覧者権限のみ選択
            If nulljudge(num) = 1 Then
                ConnectSQLPass2()
            Else
                Return
            End If
        ElseIf num = 3 Then '管理者権限のみ選択
            If nulljudge(num) = 1 Then
                ConnectSQLPass3()
            Else
                Return
            End If

        ElseIf num = 4 Then
            MsgBox("どちらも選択されていません")
        Else
            MsgBox("error")

        End If
    End Sub
    Public Sub ConnectSQLPass2() '閲覧者のみ
        Try
            Using conn As New SqlConnection
                conn.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
                conn.Open()
                Dim sql As String = "UPDATE PWTB SET PW = @pass WHERE Authority = 0"
                Using transaction As SqlTransaction = conn.BeginTransaction()
                    Try
                        Using cmd As New SqlCommand(sql, conn, transaction)
                            cmd.Parameters.AddWithValue("@pass", Me.TextBox3.Text)
                            cmd.ExecuteNonQuery()

                            transaction.Commit()
                            MsgBox("パスワードを更新しました")

                        End Using
                    Catch ex As Exception
                        transaction.Rollback()
                        MsgBox(ex.StackTrace)

                    End Try
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub ConnectSQLPass3() '管理者のみ

        Try
            Using conn As New SqlConnection
                conn.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
                conn.Open()
                Dim sql As String = "UPDATE PWTB SET PW = @pass WHERE Authority = 1"
                Using transaction As SqlTransaction = conn.BeginTransaction()
                    Try
                        Using cmd As New SqlCommand(sql, conn, transaction)
                            cmd.Parameters.AddWithValue("@pass", Me.TextBox1.Text)
                            cmd.ExecuteNonQuery()

                            transaction.Commit()
                            MsgBox("パスワードを更新しました")

                        End Using
                    Catch ex As Exception
                        transaction.Rollback()
                        MsgBox(ex.StackTrace)

                    End Try
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function nulljudge(num As Integer) As Integer
        Dim count As Integer = 1
        If num = 1 Then
            If TextBox1.Text = "" Then
                MsgBox("管理者権限のパスワードが入力されていません")
                count = 2
            ElseIf Not TextBox2.Text = TextBox1.Text Then
                MsgBox("管理者権限の登録パスワードと確認パスワードが一致しません")
                count = 2
            ElseIf TextBox3.Text = "" Then
                MsgBox("閲覧者権限のパスワードが入力されていません")
                count = 2
            ElseIf Not TextBox4.Text = TextBox3.Text Then
                MsgBox("閲覧者権限の登録パスワードと確認パスワードが一致しません")
                count = 2
            End If
        ElseIf num = 2 Then '閲覧者権限のみ選択
            If TextBox3.Text = "" Then
                MsgBox("閲覧者権限のパスワードが入力されていません")
                count = 2
            ElseIf Not TextBox4.Text = TextBox3.Text Then
                MsgBox("閲覧者権限の登録パスワードと確認パスワードが一致しません")
                count = 2
            End If
        ElseIf num = 3 Then '管理者権限のみ選択
            If TextBox1.Text = "" Then
                MsgBox("管理者権限のパスワードが入力されていません")
                count = 2
            ElseIf Not TextBox1.Text = TextBox2.Text Then
                MsgBox("管理者権限の登録パスワードと確認パスワードが一致しません")
                count = 2
            End If
        End If

        Return count

    End Function
    Public Function pattern() As Integer
        If (CheckBox1.Checked = True) And (CheckBox2.Checked = True) Then
            Return 1
        ElseIf (CheckBox1.Checked = True) And (CheckBox2.Checked = False) Then
            Return 2
        ElseIf (CheckBox1.Checked = False) And (CheckBox2.Checked = True) Then
            Return 3
        ElseIf (CheckBox1.Checked = False) And (CheckBox2.Checked = False) Then
            Return 4
        End If
        Return 5
    End Function
End Class