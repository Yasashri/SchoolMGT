Imports System.Data
Imports MySql.Data.MySqlClient
Public Class AllData
    Dim connectionString As String = "server=localhost;user=root; password=''; database=schoolmgtdb;"
    Dim connection As New MySqlConnection(connectionString)
    Dim ds As New DataSet()
    Dim dt As DataTable
    Private Sub AllData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadData()
    End Sub

    Private Sub LoadData()
        dt = New DataTable("students")
        Using adapter As New MySqlDataAdapter("SELECT * FROM students", connection)
            adapter.Fill(dt)
        End Using
        ds.Tables.Add(dt)
        DataGridView1.DataSource = ds.Tables("students")
        DataGridView1.ColumnHeadersVisible = False
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(5).Width = 50
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Try
            Using adapter As New MySqlDataAdapter("SELECT * FROM students", connection)
                Dim commandBuilder As New MySqlCommandBuilder(adapter)
                adapter.Update(ds, "students")
                MessageBox.Show("Data updated successfully.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim rowToDelete As DataRow = ds.Tables("students").Rows(selectedRowIndex)
            rowToDelete.Delete()

            Try
                Using adapter As New MySqlDataAdapter("SELECT * FROM students", connection)
                    Dim commandBuilder As New MySqlCommandBuilder(adapter)
                    adapter.Update(ds, "students")
                    MessageBox.Show("Data deleted successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim searchQuery As String = Txt_Search.Text.Trim()

        If Not String.IsNullOrEmpty(searchQuery) Then
            Dim dv As DataView = ds.Tables("students").DefaultView
            dv.RowFilter = $"fname LIKE '%{searchQuery}%' Or lname LIKE '%{searchQuery}%' or grade LIKE '%{searchQuery}%' Or
                            phone LIKE '%{searchQuery}%'"

            DataGridView1.DataSource = dv
        Else
            MsgBox("Please enter search data", MsgBoxStyle.Critical)
            DataGridView1.DataSource = ds.Tables("students")
        End If
    End Sub

    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        Me.Close()
        Loader.Show()
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Close()
        Mainmenu.Show()
    End Sub
End Class