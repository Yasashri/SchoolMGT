Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Public Class Login
    Dim connectionString As String = "server=localhost;user=root; password=''; database=schoolmgtdb;"
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim username As String = Txt_Username.Text
        Dim password As String = Txt_Pass.Text

        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login successful")
            Me.Hide()
            Mainmenu.Show()
        Else
            MessageBox.Show("Login error")
        End If
    End Sub
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class