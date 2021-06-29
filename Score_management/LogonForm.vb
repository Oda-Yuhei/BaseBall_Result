Imports System.Data.SqlClient
Public Class LogonForm
    Private Authority_num As String
    Public Auth As Boolean = False
    Private Sub LogonButton_Click(sender As Object, e As EventArgs) Handles LogonButton.Click
        If UserComboBox.Text = "管理者" Then
            Authority_num = "1"
        ElseIf UserComboBox.Text = "閲覧者" Then
            Authority_num = "0"
        Else
            MsgBox("権限を選択してください")
            Return
        End If

        Dim pas As String = AddProductCategory(Authority_num, "Data Source=PC-S009;Initial Catalog=PlayerManagement;Integrated Security=True")
        If Authority_num = 1 Then
            Auth = True
        ElseIf Authority_num = 0 Then
            Auth = False
        End If

        If pas = PassTextBox.Text Then

            MenuForm.Visible = True
            Me.Visible = False


        Else
            MsgBox("パスワードが間違っていいます。" & vbCrLf & vbCrLf & "もしくは権限が一致していません。")
        End If
    End Sub
    Public Function AddProductCategory(ByVal newNum As String, ByVal connString As String) As String
        Dim newProdID As String = ""
        Dim sql As String =
         "SELECT PW FROM PWTB WHERE Authority = @AutNum"

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.Add("@AutNum", SqlDbType.VarChar)
            cmd.Parameters("@Autnum").Value = newNum
            Try
                conn.Open()
                newProdID = Convert.ToString(cmd.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        Return newProdID
    End Function

    Private Sub LogonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("閲覧者用PASS  : bb   管理者用PASS : aa")
    End Sub
End Class

