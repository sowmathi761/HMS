<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorsForm
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
        txtDoctorId = New TextBox()
        txtName = New TextBox()
        txtSpecialisation = New TextBox()
        txtContactNo = New TextBox()
        txtSearch = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnInsert = New Button()
        btnSearch = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(169, 410)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 0
        Label1.Text = "Specialisation"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(169, 486)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "Contact_No"
        ' 
        ' txtDoctorId
        ' 
        txtDoctorId.Location = New Point(315, 233)
        txtDoctorId.Name = "txtDoctorId"
        txtDoctorId.Size = New Size(125, 27)
        txtDoctorId.TabIndex = 3
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(315, 315)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 4
        ' 
        ' txtSpecialisation
        ' 
        txtSpecialisation.Location = New Point(315, 407)
        txtSpecialisation.Name = "txtSpecialisation"
        txtSpecialisation.Size = New Size(125, 27)
        txtSpecialisation.TabIndex = 5
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(315, 483)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(125, 27)
        txtContactNo.TabIndex = 6
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(974, 423)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 7
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(946, 351)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(94, 29)
        btnPrevious.TabIndex = 8
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(1117, 351)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(94, 29)
        btnNext.TabIndex = 9
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(768, 351)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(1117, 282)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(946, 282)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(768, 282)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(94, 29)
        btnInsert.TabIndex = 13
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(856, 421)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 14
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label3.Location = New Point(497, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 100)
        Label3.TabIndex = 15
        Label3.Text = vbCrLf & vbCrLf & "                                 DOCTOR FORM                               " & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(193, 322)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 20)
        Label4.TabIndex = 16
        Label4.Text = "Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(181, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 17
        Label5.Text = "Doctor_Id"
        ' 
        ' DoctorsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(1351, 613)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSearch)
        Controls.Add(btnInsert)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtSearch)
        Controls.Add(txtContactNo)
        Controls.Add(txtSpecialisation)
        Controls.Add(txtName)
        Controls.Add(txtDoctorId)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DoctorsForm"
        Text = "Doctor_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDoctorId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSpecialisation As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
