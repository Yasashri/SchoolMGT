Public Class Mainmenu

    Private Sub Btn_All_Click(sender As Object, e As EventArgs) Handles Btn_All.Click
        Me.Close()
        AllData.Show()
    End Sub

    Private Sub Btn_New_Stu_Click(sender As Object, e As EventArgs) Handles Btn_New_Stu.Click
        Me.Close()
        Addvb.Show()
    End Sub

    Private Sub Mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class