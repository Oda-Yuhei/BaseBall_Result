Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class PlayerCardForm
    Private IsImage As Boolean
    Public ByteArray As Byte()
    Public ID As String
    Private Sub PlayerCardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.AllowDrop = True
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Me.Label_FileName.Text = "ファイルをドラッグ＆ドロップしてください"

        Me.Vw_PitcherResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_PitcherResult)
        Me.Player_ResultTableAdapter.Fill(Me.PlayerManagementDataSet.Player_Result)
        Me.Vw_PlayerlistTableAdapter.Fill(Me.PlayerManagementDataSet.vw_Playerlist)
        Me.Vw_BatterResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_BatterResult)

        PictureBox1.AllowDrop = True

        If Not LogonForm.Auth = True Then
            Button.Visible = False
            Button1.Visible = False
        Else
            Button.Visible = True
            Button1.Visible = True

        End If

        '画像インポート

        Dim cn As New SqlClient.SqlConnection
        Dim cd As New SqlClient.SqlCommand
        Dim dr As SqlClient.SqlDataReader
        Dim sql As String

        Try

            cn.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
            cn.Open()
            sql = "SELECT FileData FROM UploadFile WHERE Player_id = " & Me.ID
            cd.CommandText = sql
            cd.Connection = cn
            dr = cd.ExecuteReader
            While dr.Read
                If Not IsDBNull(dr("FileData")) Then
                    ByteArray = dr("FileData")
                    PictureBox1.Image = ByteArrayToImage(ByteArray)
                End If
            End While
            dr.Close()
            cd.Dispose()
            cn.Close()
            cn.Dispose()
        Catch ex As Exception
            MsgBox("errer 01")
        End Try



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
        If strjadge() Then '個人情報textboxの入力が正しいのか判断
            Return
        End If
        If Not Chk_Hiragana(RubTextBox.Text) Then
            Return
        End If
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
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            sql = "UPDATE UploadFile SET FileData = @FileData, UploadFileName = @UploadFileName WHERE Player_id = @Player_id"
            'sql = "INSERT INTO UploadFile(FileID,FileData,UploadFileName,Player_id) VALUES( NEWID(), @FileData,@UploadFileName,@Player_id)"
            Dim Filename As String = Me.Player_idTextBox.Text & Me.NameTextBox.Text & ".jpg"
            Dim datastr As Byte() = ImageToByteArray(PictureBox1.Image)
            Try
                Using conn As New SqlConnection
                    conn.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
                    conn.Open()
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(sql, conn, transaction)
                                cmd.Parameters.AddWithValue("@FileData", datastr)
                                cmd.Parameters.AddWithValue("@UploadFileName", Filename)
                                cmd.Parameters.AddWithValue("@Player_id", Player_idTextBox.Text)
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
    Public Shared Function ByteArrayToImage(ByVal b As Byte()) As Image
        Dim imgconv As New ImageConverter()
        Dim img As Image = CType(imgconv.ConvertFrom(b), Image)
        Return img
    End Function
    Public Shared Function ImageToByteArray(ByVal img As Image) As Byte()
        Dim imgconv As New ImageConverter()
        Dim b As Byte() = CType(imgconv.ConvertTo(img, GetType(Byte())), Byte())
        Return b
    End Function
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





    ' ---[関数]ドラッグされたものがフォルダーかファイルかを判別
    Private Function fnc_FileSystemType(ByVal drags() As String) As String
        Try
            If (System.IO.File.Exists(drags(0)) = True) Then
                Return "File"
            ElseIf (System.IO.Directory.Exists(drags(0)) = True) Then
                Return "Folder"
            Else
                Return "None"
            End If
        Catch ex As Exception

        End Try
    End Function


    ' ---[関数]画像とみなすか？
    Private Function fnc_IsImage(ByVal fileName As String) As Boolean
        ' ---[配列]画像とみなす拡張子
        Dim AryExt() As String = {".jpg", ".jpeg", ".png", ".gif", ".bmp"}
        ' ---
        Dim ext As String = System.IO.Path.GetExtension(fileName)
        For idx As Integer = 0 To AryExt.Length - 1
            If (ext.ToLower = AryExt(idx)) Then
                Return True
            End If
        Next
        ' ---
        Return False
    End Function

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        If (Me.IsImage) Then
            Me.PictureBox1.Image = Image.FromFile(Me.Label_FileName.Text)
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        ' --- コントロール初期化
        Me.PictureBox1.Image = Nothing
        ' --- 変数初期化
        Me.IsImage = False
        ' --- ドラッグ中のファイルやディレクトリを文字型配列に格納
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        ' --- フォルダーかファイルかを判別（FileSystemType)
        Select Case Me.fnc_FileSystemType(Drags)
            Case = "File"
                ' ---▼ ファイルの場合
                e.Effect = DragDropEffects.Copy  ' -- コピーを可能にする
                Me.Label_FileName.Text = Drags(0) ' -- ファイル名（フルパス）

                '--- ドラッグされているファイルを画像とみなすか？
                If (Me.fnc_IsImage(Me.Label_FileName.Text)) Then
                    Me.IsImage = True
                    Exit Sub
                End If
            Case = "Folder"
                ' ---▼ フォルダーの場合
                e.Effect = DragDropEffects.None ' -- コピー不可
                Me.Label_FileName.Text = "フォルダーはドラッグ＆ドロップできません"
            Case Else
                e.Effect = DragDropEffects.None ' -- コピー不可
                Me.Label_FileName.Text = "ドラッグ対象が不明です"
        End Select
    End Sub

    '入力規制
    Public Function strjadge() As Boolean
        If NameTextBox.Text.Length = 0 Then
            MsgBox("名前を入力してください")
            Return True
        End If
        If RubTextBox.Text.Length = 0 Then
            MsgBox("ふりがなを入力してください")
            Return True
        End If

    End Function
    Public Function Chk_Hiragana(ByVal PistrStr As String) As Boolean
        Chk_Hiragana = Regex.IsMatch(PistrStr, "^\p{IsHiragana}*$")

    End Function


End Class