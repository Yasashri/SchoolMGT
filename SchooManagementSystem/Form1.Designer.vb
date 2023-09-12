<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_username = New TextBox()
        txt_password = New TextBox()
        btn_login = New Button()
        btn_exit = New Button()
        SuspendLayout()
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(218, 135)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(100, 23)
        txt_username.TabIndex = 0
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(218, 178)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(100, 23)
        txt_password.TabIndex = 1
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(313, 299)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(75, 23)
        btn_login.TabIndex = 2
        btn_login.Text = "login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_exit
        ' 
        btn_exit.Location = New Point(426, 306)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(75, 23)
        btn_exit.TabIndex = 3
        btn_exit.Text = "Exit"
        btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_exit)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
End Class
