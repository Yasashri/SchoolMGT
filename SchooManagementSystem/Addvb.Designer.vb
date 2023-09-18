<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addvb
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
        Txt_Fname = New TextBox()
        Txt_Lname = New TextBox()
        Btn_Save = New Button()
        Txt_Address = New TextBox()
        Txt_Phone = New TextBox()
        Txt_Grade = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Btn_Back = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Txt_Fname
        ' 
        Txt_Fname.Location = New Point(97, 69)
        Txt_Fname.Name = "Txt_Fname"
        Txt_Fname.Size = New Size(185, 23)
        Txt_Fname.TabIndex = 0
        ' 
        ' Txt_Lname
        ' 
        Txt_Lname.Location = New Point(97, 98)
        Txt_Lname.Name = "Txt_Lname"
        Txt_Lname.Size = New Size(185, 23)
        Txt_Lname.TabIndex = 1
        ' 
        ' Btn_Save
        ' 
        Btn_Save.Location = New Point(126, 228)
        Btn_Save.Name = "Btn_Save"
        Btn_Save.Size = New Size(75, 23)
        Btn_Save.TabIndex = 2
        Btn_Save.Text = "Save"
        Btn_Save.UseVisualStyleBackColor = True
        ' 
        ' Txt_Address
        ' 
        Txt_Address.Location = New Point(97, 127)
        Txt_Address.Name = "Txt_Address"
        Txt_Address.Size = New Size(185, 23)
        Txt_Address.TabIndex = 3
        ' 
        ' Txt_Phone
        ' 
        Txt_Phone.Location = New Point(97, 156)
        Txt_Phone.Name = "Txt_Phone"
        Txt_Phone.Size = New Size(185, 23)
        Txt_Phone.TabIndex = 4
        ' 
        ' Txt_Grade
        ' 
        Txt_Grade.Location = New Point(97, 185)
        Txt_Grade.Name = "Txt_Grade"
        Txt_Grade.Size = New Size(185, 23)
        Txt_Grade.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 6
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 7
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 8
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 9
        Label4.Text = "Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 10
        Label5.Text = "Grade"
        ' 
        ' Btn_Back
        ' 
        Btn_Back.Location = New Point(207, 228)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(75, 23)
        Btn_Back.TabIndex = 11
        Btn_Back.Text = "Back"
        Btn_Back.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(20, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 28)
        Label6.TabIndex = 12
        Label6.Text = "Add new student"
        ' 
        ' Addvb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(337, 303)
        Controls.Add(Label6)
        Controls.Add(Btn_Back)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Txt_Grade)
        Controls.Add(Txt_Phone)
        Controls.Add(Txt_Address)
        Controls.Add(Btn_Save)
        Controls.Add(Txt_Lname)
        Controls.Add(Txt_Fname)
        Name = "Addvb"
        Text = "Addvb"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt_Fname As TextBox
    Friend WithEvents Txt_Lname As TextBox
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Txt_Address As TextBox
    Friend WithEvents Txt_Phone As TextBox
    Friend WithEvents Txt_Grade As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_Back As Button
    Friend WithEvents Label6 As Label
End Class
