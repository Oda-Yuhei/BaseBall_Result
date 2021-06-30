Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Configuration
Public Class RegisterPlayerForm
    Public ByteArray As Byte()
    Private ID As Integer = 0
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Dim connectionkey As String = "Score_management.My.MySettings.PlayerManagementConnectionString"

        If intjadge() Then '成績textboxの入力が正しいのか判断
            Return
        End If
        If Strjadge() Then '個人情報textboxの入力が正しいのか判断
            Return
        End If
        If Not Chk_Hiragana(RubTextBox.Text) Then 'ふりがな欄のひらがな判定
            Return
        End If
        Dim result As DialogResult = MessageBox.Show("データを登録します", "登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If result = DialogResult.OK Then
            Try
                Using conn As New SqlConnection
                    Dim settings As ConnectionStringSettings
                    settings = ConfigurationManager.ConnectionStrings("Score_management.My.MySettings.PlayerManagementConnectionString")
                    If settings Is Nothing Then
                        MsgBox("App.configに未登録、接続文字列エラー")
                    Else
                        conn.ConnectionString = settings.ConnectionString
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

                                End Using
                            Catch ex As Exception
                                transaction.Rollback()
                                MsgBox(ex.StackTrace)

                            End Try


                            Sql = "INSERT INTO Batter VALUES(@ar, @h, @lh, @hr, @hbp, @sh, @ibb_hbp, @so, @sb)"

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

                                End Using
                            Catch ex As Exception
                                transaction.Rollback()
                                MsgBox(ex.StackTrace)

                            End Try


                            Sql = "INSERT INTO Player VALUES(@name, @rub, @origin_school, @position, @TandB, @comment )"

                            Try
                                Using cmd As New SqlCommand(Sql, conn, transaction)
                                    cmd.Parameters.AddWithValue("@name", Notpadding(Me.NameTextBox.Text))
                                    cmd.Parameters.AddWithValue("@rub", Notpadding(Me.RubTextBox.Text))
                                    cmd.Parameters.AddWithValue("@origin_school", Notpadding(Me.Origin_schoolTextBox.Text))
                                    cmd.Parameters.AddWithValue("@position", Me.PositionLabel.Text)
                                    cmd.Parameters.AddWithValue("@TandB", Me.TandBComboBox.Text)
                                    cmd.Parameters.AddWithValue("@comment", Me.CommentTextBox.Text)
                                    cmd.ExecuteNonQuery()


                                End Using
                            Catch ex As Exception
                                transaction.Rollback()
                                MsgBox(ex.StackTrace)

                            End Try

                            Sql = "INSERT INTO UploadFile(FileID,FileData,UploadFileName) VALUES(NEWID(), @FileData, @UploadFileName)"
                            Dim datastr As Byte() = ImageToByteArray(PictureBox1.Image)
                            Dim Filename As String = ID.ToString & Me.NameTextBox.Text & ".jpg"

                            Try
                                Using cmd As New SqlCommand(Sql, conn, transaction)
                                    cmd.Parameters.AddWithValue("@FileData", datastr)
                                    cmd.Parameters.AddWithValue("@UploadFileName", Filename)
                                    cmd.ExecuteNonQuery()

                                End Using
                            Catch ex As Exception
                                transaction.Rollback()
                                MsgBox(ex.StackTrace)
                            End Try

                            Sql = "INSERT INTO  Player_Result (Player_id, Batter_id,Pitcher_id,Image_ID) VALUES((SELECT Max(Player_id) FROM Player),(SELECT Max(Batter_id) FROM Batter),(SELECT Max(Pitcher_id) FROM Pitcher),(SELECT Max(Image_id) From UploadFile))"

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
                    End If
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf result = DialogResult.Cancel Then
            Return
        End If
    End Sub
    Public Function Strjadge() As Boolean
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


    Public Function intjadge() As Boolean
        Dim nums As New List(Of String)
        nums.Add(ARTextBox.Text)
        nums.Add(HTextBox.Text)
        nums.Add(LHTextBox.Text)
        nums.Add(HRTextBox.Text)
        nums.Add(HBPTextBox.Text)
        nums.Add(SHTextBox.Text)
        nums.Add(IBBandHBPTextBox.Text)
        nums.Add(SOTextBox.Text)
        nums.Add(SBTextBox.Text)

        nums.Add(APPTextBox.Text)
        nums.Add(IPTextBox.Text)
        nums.Add(KTextBox.Text)
        nums.Add(BTextBox.Text)
        nums.Add(RTextBox.Text)
        nums.Add(ERTextBox.Text)
        nums.Add(WTextBox.Text)
        nums.Add(SVTextBox.Text)

        Dim intnums As New List(Of Integer)
        For Each i In nums

            Try
                intnums.Add(CInt(i))
            Catch ex As Exception
                MsgBox("不正入力があります。")
                Return True
            End Try
        Next
        For Each i In intnums
            If i < 0 OrElse 7000 < i Then
                MsgBox("不正入力があります　　" & i)
                Return True
            End If
        Next
        For Each i In nums
            If i.Length = 0 Then
                MsgBox("空白があります")
                Return True
            End If
        Next
        Return False
    End Function
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

    Private Sub RegisterPlayerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Me.Label_FileName.Text = "ファイルをドラッグ＆ドロップしてください"
        PictureBox1.AllowDrop = True
        AddID()
    End Sub


    Private IsImage As Boolean



    ' ---[関数]ドラッグされたものがフォルダーかファイルかを判別
    Private Function Fnc_FileSystemType(ByVal drags() As String) As String
        If (System.IO.File.Exists(drags(0)) = True) Then
            Return "File"
        ElseIf (System.IO.Directory.Exists(drags(0)) = True) Then
            Return "Folder"
        Else
            Return "None"
        End If
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
        If Me.IsImage Then
            Me.PictureBox1.Image = Image.FromFile(Me.Label_FileName.Text)
            Exit Sub
        End If
    End Sub
    Public Shared Function ImageToByteArray(ByVal img As Image) As Byte()
        Try
            Dim imgconv As New ImageConverter()
            Dim b As Byte() = CType(imgconv.ConvertTo(img, GetType(Byte())), Byte())
            Return b

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        ' --- コントロール初期化
        Me.PictureBox1.Image = Nothing
        ' --- 変数初期化
        Me.IsImage = False
        ' --- ドラッグ中のファイルやディレクトリを文字型配列に格納
        Dim Drags() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        ' --- フォルダーかファイルかを判別（FileSystemType)
        Select Case Me.Fnc_FileSystemType(Drags)
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
    Public Sub AddID()
        Try
            Using con As New SqlConnection
                Using cmd As New SqlCommand
                    con.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
                    cmd.Connection = con
                    con.Open()
                    cmd.CommandText = "SELECT MAX(Player_id) AS MAXID FROM Player_Result"

                    Me.ID = cmd.ExecuteScalar()
                    If ID = Nothing Then
                        ID = 0
                    End If
                    ID += 1
                End Using
            End Using
        Catch ex As Exception
            ' 例外が発生した時の処理
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Public Function Notpadding(str As String) As String
        Dim Rstr As String = str.Replace(" ", "")
        Return Rstr
    End Function
End Class