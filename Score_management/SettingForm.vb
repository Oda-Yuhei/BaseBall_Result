Imports System.Data.SqlClient
Imports System.Configuration
Public Class SettingForm
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged, CheckBox1.CheckedChanged

        TextBox1.Visible = CheckBox2.Checked
        TextBox2.Visible = CheckBox2.Checked

        TextBox3.Visible = CheckBox1.Checked
        TextBox4.Visible = CheckBox1.Checked

    End Sub
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Dim num As Integer = Pattern()
        If num = 1 Then

            If Nulljudge(num) = 1 Then
                ConnectSQLPass2()
                ConnectSQLPass3()
            Else
                Return
            End If
        ElseIf num = 2 Then '閲覧者権限のみ選択
            If Nulljudge(num) = 1 Then
                ConnectSQLPass2()
            Else
                Return
            End If
        ElseIf num = 3 Then '管理者権限のみ選択
            If Nulljudge(num) = 1 Then
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
    Public Sub ConnectSQLPass2() '閲覧者のみ更新
        Try
            Using conn As New SqlConnection
                Dim settings As ConnectionStringSettings
                settings = ConfigurationManager.ConnectionStrings("Score_management.My.MySettings.PlayerManagementConnectionString")
                If settings Is Nothing Then
                    MsgBox("App.configに未登録、接続文字エラー")

                Else
                    conn.ConnectionString = settings.ConnectionString
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
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub ConnectSQLPass3() '管理者のみ更新

        Try
            Using conn As New SqlConnection
                Dim settings As ConnectionStringSettings
                settings = ConfigurationManager.ConnectionStrings("Score_management.My.MySettings.PlayerManagementConnectionString")
                If settings Is Nothing Then
                    MsgBox("app.configに未登録、接続文字列エラー")
                Else
                    conn.ConnectionString = settings.ConnectionString
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
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Puttern()から数値を受け取る。
    ''' </summary>
    ''' <param name="num"></param>
    ''' <returns></returns>
    Public Function Nulljudge(num As Integer) As Integer
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
    Public Enum Patterns
        Both_change = 1
        ViewPerson_Authority_change
        Manager_Authority_change
        No_change
    End Enum
    Public Function Pattern() As Integer

        If CheckBox1.Checked And CheckBox2.Checked Then
            Return Patterns.Both_change
        ElseIf CheckBox1.Checked And Not CheckBox2.Checked Then
            Return Patterns.ViewPerson_Authority_change
        ElseIf CheckBox2.Checked And Not CheckBox1.Checked Then
            Return Patterns.Manager_Authority_change
        ElseIf Not CheckBox1.Checked And Not CheckBox2.Checked Then
            Return Patterns.No_change
        End If
        Return Patterns.No_change
    End Function
End Class