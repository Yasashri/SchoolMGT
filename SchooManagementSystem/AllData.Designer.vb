<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllData
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
        DataGridView1 = New DataGridView()
        Btn_Update = New Button()
        Btn_Delete = New Button()
        Label1 = New Label()
        Btn_Search = New Button()
        Txt_Search = New TextBox()
        Btn_Refresh = New Button()
        Btn_Back = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 49)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(780, 291)
        DataGridView1.TabIndex = 0
        ' 
        ' Btn_Update
        ' 
        Btn_Update.Location = New Point(555, 357)
        Btn_Update.Name = "Btn_Update"
        Btn_Update.Size = New Size(75, 23)
        Btn_Update.TabIndex = 1
        Btn_Update.Text = "Update"
        Btn_Update.UseVisualStyleBackColor = True
        ' 
        ' Btn_Delete
        ' 
        Btn_Delete.Location = New Point(636, 357)
        Btn_Delete.Name = "Btn_Delete"
        Btn_Delete.Size = New Size(75, 23)
        Btn_Delete.TabIndex = 2
        Btn_Delete.Text = "Delete"
        Btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 15)
        Label1.TabIndex = 3
        Label1.Text = "Student information"
        ' 
        ' Btn_Search
        ' 
        Btn_Search.Location = New Point(636, 16)
        Btn_Search.Name = "Btn_Search"
        Btn_Search.Size = New Size(75, 23)
        Btn_Search.TabIndex = 4
        Btn_Search.Text = "Search"
        Btn_Search.UseVisualStyleBackColor = True
        ' 
        ' Txt_Search
        ' 
        Txt_Search.Location = New Point(454, 16)
        Txt_Search.Name = "Txt_Search"
        Txt_Search.Size = New Size(176, 23)
        Txt_Search.TabIndex = 5
        ' 
        ' Btn_Refresh
        ' 
        Btn_Refresh.Location = New Point(717, 16)
        Btn_Refresh.Name = "Btn_Refresh"
        Btn_Refresh.Size = New Size(75, 23)
        Btn_Refresh.TabIndex = 6
        Btn_Refresh.Text = "Refresh"
        Btn_Refresh.UseVisualStyleBackColor = True
        ' 
        ' Btn_Back
        ' 
        Btn_Back.Location = New Point(717, 357)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(75, 23)
        Btn_Back.TabIndex = 7
        Btn_Back.Text = "Back"
        Btn_Back.UseVisualStyleBackColor = True
        ' 
        ' AllData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(810, 410)
        Controls.Add(Btn_Back)
        Controls.Add(Btn_Refresh)
        Controls.Add(Txt_Search)
        Controls.Add(Btn_Search)
        Controls.Add(Label1)
        Controls.Add(Btn_Delete)
        Controls.Add(Btn_Update)
        Controls.Add(DataGridView1)
        Name = "AllData"
        Text = "AllData"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Btn_Refresh As Button
    Friend WithEvents Btn_Back As Button
End Class
