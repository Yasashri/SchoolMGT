Imports System.Data.Common
Imports MySql.Data.MySqlClient
Public Class Addvb

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click

        Dim conn As MySqlConnection
        Dim cmd As MySqlCommand

        conn = New MySqlConnection With {
            .ConnectionString = "server=localhost;user=root; password=''; database=schoolmgtdb"
        }
        Dim READER As MySqlDataReader
        Dim fnamez, lnamez, addressz, phonez, gradez As String

        fnamez = Txt_Fname.Text
        lnamez = Txt_Lname.Text
        addressz = Txt_Address.Text
        phonez = Txt_Phone.Text
        gradez = Txt_Grade.Text

        If (fnamez = "" Or lnamez = "" Or addressz = "" Or phonez = "" Or gradez = "") Then
            MsgBox("Please Fill All Fields", MsgBoxStyle.Information)
            Return

        End If

        Try
            Dim sql As String = "INSERT INTO students(fname, lname, address, phone, grade) VALUES
            ('" & fnamez & "','" & lnamez & "','" & addressz & "','" & phonez & "','" & gradez & "' )"
            conn.Open()
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            MsgBox("Data Added", MsgBoxStyle.Information)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try


    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Close()
        Mainmenu.Show()
    End Sub

    Private Sub Addvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class