Imports MySql.Data.MySqlClient

Public Class DBConnection
    Dim con As New MySqlConnection("Server=127.0.0.1; user=root; password=; database=schoolmgtdb")
    Public Function Open() As MySqlConnection
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function
    Public Function Close() As MySqlConnection
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function
End Class