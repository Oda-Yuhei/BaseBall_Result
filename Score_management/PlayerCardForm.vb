Imports System.Data.SqlClient
Public Class PlayerCardForm
    Private Sub PlayerCardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PlayerManagementDataSet.Player_Result' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Player_ResultTableAdapter.Fill(Me.PlayerManagementDataSet.Player_Result)

        'TODO: このコード行はデータを 'PlayerManagementDataSet.vw_Playerlist' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_PlayerlistTableAdapter.Fill(Me.PlayerManagementDataSet.vw_Playerlist)
        'TODO: このコード行はデータを 'PlayerManagementDataSet.vw_PitcherResult' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_PitcherResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_PitcherResult)
        'TODO: このコード行はデータを 'PlayerManagementDataSet.vw_BatterResult' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Vw_BatterResultTableAdapter.Fill(Me.PlayerManagementDataSet.vw_BatterResult)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show($"本当に{NameTextBox.Text}のデータを削除してもよろしいですか？", "データ削除", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim sql As String = "INSERT INTO Player (name, rub, origin_school,position, TandB, comment) VALUES(@name,@rub,@origin_school,@position,@TandB,@comment)"
            Try
                Using conn As New SqlConnection
                    conn.ConnectionString = "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True"
                    conn.Open()
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand(sql, conn, transaction)
                                cmd.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar).Value = Me.NameTextBox.Text)
                                cmd.Parameters.Add(New SqlParameter("@rub", SqlDbType.NVarChar).Value = Me.RubTextBox.Text)
                                cmd.Parameters.Add(New SqlParameter("@origin_shool", SqlDbType.NVarChar).Value = Me.Origin_schoolTextBox.Text)
                                cmd.Parameters.Add(New SqlParameter("@position", SqlDbType.NVarChar).Value = Me.PositionTextBox.Text)
                                cmd.Parameters.Add(New SqlParameter("@TandB", SqlDbType.NVarChar).Value = Me.TandBTextBox.Text)
                                cmd.Parameters.Add(New SqlParameter("@comment", SqlDbType.NVarChar).Value = Me.CommentTextBox.Text)

                                cmd.ExecuteNonQuery()

                                transaction.Commit()
                            End Using
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox(ex.Message)

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

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        Dim result As DialogResult = MessageBox.Show("データを上書きしてもよろしいですか？", "データ編集", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then

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
        ElseIf PositionComboBox.SelectedItem = "野手" Then '野手が選択されれば、個別に選択されていた野手を削除
            Select_Fielder()
            Select_Tostring()

        ElseIf Fielder_sarch() And Not PositionComboBox.SelectedItem = "投手" Then '野手が選択されている状態で投手以外が選択されたとき無効
            Return
        ElseIf PositionComboBox.SelectedItem = "内野手" Then '内野手が選択されれば、個別に選択されていた内野手を削除
            Select_InnerFielder()
            Select_Tostring()
        ElseIf InnerFielder_sarch() And Select_InnerFielder_sarch() Then '内野手が選択されている状態で個別内野手が選択されたとき無効
            Return
        Else
            select_position.Add(str)
            Select_Tostring()
        End If

        ChartForm.Origin_RadioButton.Visible = True
        ChartForm.Origin_RadioButton.Checked = True


    End Sub
    Public Function Select_InnerFielder_sarch() As Boolean
        Dim pos As New List(Of String)(New String() {"キャッチャー", "ファースト", "セカンド", "ショート", "サード"})
        If pos.IndexOf(PositionComboBox.SelectedItem) = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function InnerFielder_sarch() As Boolean
        If select_position.IndexOf("内野手") = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function Fielder_sarch() As Boolean
        If select_position.IndexOf("野手") = -1 Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Sub Select_InnerFielder()
        Dim remove_collection As New List(Of String)
        For Each i In select_position
            If i = "キャッチャー" Or i = "ファースト" Or i = "セカンド" Or i = "ショート" Or i = "サード" Then
                remove_collection.Add(i)
            End If
        Next
        For Each i In remove_collection
            select_position.Remove(i)
        Next
        select_position.Add("内野手")
    End Sub
    Public Sub Select_Fielder()
        Dim remove_collection As New List(Of String)
        For Each i In select_position

            If Not i = "投手" Then
                remove_collection.Add(i)
            End If
        Next
        For Each i In remove_collection
            select_position.Remove(i)
        Next
        select_position.Add("野手")

    End Sub
    Public Sub Select_Tostring()
        Dim str As String = ""
        For Each i In select_position
            str &= i + ","
        Next
        PositionTextBox.Text = str
    End Sub

End Class