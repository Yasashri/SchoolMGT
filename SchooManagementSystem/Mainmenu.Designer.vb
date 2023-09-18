<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Btn_All = New Button()
        Btn_New_Stu = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Btn_All
        ' 
        Btn_All.Location = New Point(12, 94)
        Btn_All.Name = "Btn_All"
        Btn_All.Size = New Size(257, 23)
        Btn_All.TabIndex = 1
        Btn_All.Text = "View all students"
        Btn_All.UseVisualStyleBackColor = True
        ' 
        ' Btn_New_Stu
        ' 
        Btn_New_Stu.Location = New Point(12, 54)
        Btn_New_Stu.Name = "Btn_New_Stu"
        Btn_New_Stu.Size = New Size(257, 23)
        Btn_New_Stu.TabIndex = 2
        Btn_New_Stu.Text = "Add new student"
        Btn_New_Stu.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 3
        Label1.Text = "Main menu"
        ' 
        ' Mainmenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(301, 152)
        Controls.Add(Label1)
        Controls.Add(Btn_New_Stu)
        Controls.Add(Btn_All)
        Name = "Mainmenu"
        Text = "Main"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Btn_All As Button
    Friend WithEvents Btn_New_Stu As Button
    Friend WithEvents Label1 As Label
End Class
