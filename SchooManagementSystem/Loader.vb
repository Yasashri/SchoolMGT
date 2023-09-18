Imports System.Threading

Public Class Loader


    Private Sub Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Close()
        AllData.Show()

    End Sub
End Class