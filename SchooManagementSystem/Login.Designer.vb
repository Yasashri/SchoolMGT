<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label1 = New Label()
        Label2 = New Label()
        Btn_Login = New Button()
        Txt_Username = New TextBox()
        Txt_Pass = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 0
        Label1.Text = "User name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Btn_Login
        ' 
        Btn_Login.Location = New Point(17, 190)
        Btn_Login.Name = "Btn_Login"
        Btn_Login.Size = New Size(249, 23)
        Btn_Login.TabIndex = 2
        Btn_Login.Text = "Log in"
        Btn_Login.UseVisualStyleBackColor = True
        ' 
        ' Txt_Username
        ' 
        Txt_Username.Location = New Point(18, 102)
        Txt_Username.Name = "Txt_Username"
        Txt_Username.Size = New Size(248, 23)
        Txt_Username.TabIndex = 3
        ' 
        ' Txt_Pass
        ' 
        Txt_Pass.Location = New Point(18, 147)
        Txt_Pass.Name = "Txt_Pass"
        Txt_Pass.Size = New Size(248, 23)
        Txt_Pass.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(17, 219)
        Button1.Name = "Button1"
        Button1.Size = New Size(249, 23)
        Button1.TabIndex = 5
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Reem Kufi", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(17, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(249, 32)
        Label3.TabIndex = 6
        Label3.Text = "Student Management System"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(292, 275)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Txt_Pass)
        Controls.Add(Txt_Username)
        Controls.Add(Btn_Login)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Txt_Username As TextBox
    Friend WithEvents Txt_Pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
