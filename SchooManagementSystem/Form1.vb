Imports System.Data.Common
Imports MySql.Data.MySqlClient
Public Class Form1
#Region "Declares"
    Dim myConnection As New DBConnection
    Dim conAdapter As MySqlDataAdapter
    Dim dataTable As DataTable

#End Region
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String
        Dim password As String

        username = txt_username.Text
        password = txt_password.Text

        conAdapter = New MySqlDataAdapter("Select * From users where username = '" & username & "' and password= '" & password & "'", myConnection.Open)
        dataTable = New DataTable
        dataTable.Clear()
        conAdapter.Fill(dataTable)
        If dataTable.Rows.Count() <= 0 Then
            MessageBox.Show("Invalid")
        Else
            MessageBox.Show("Done")
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub
End Class
