<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtSearch = New TextBox()
        txtAddress = New TextBox()
        txtContactNo = New TextBox()
        txtGender = New TextBox()
        txtAge = New TextBox()
        txtName = New TextBox()
        txtPatientId = New TextBox()
        btnInsert = New Button()
        btnNext = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSearch = New Button()
        btnPrevious = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(769, 356)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 0
        Label1.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(750, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "Contact_No"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(779, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 2
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(285, 349)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 3
        Label4.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(285, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 4
        Label5.Text = "Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(285, 169)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 20)
        Label6.TabIndex = 5
        Label6.Text = "Patient_Id"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label7.Location = New Point(425, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(411, 100)
        Label7.TabIndex = 6
        Label7.Text = "                              " & vbCrLf & vbCrLf & "                         PATIENT REGISTRATION FORM                         " & vbCrLf & "               " & vbCrLf & "   " & vbCrLf
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(729, 438)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 7
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(969, 356)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(125, 27)
        txtAddress.TabIndex = 8
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(969, 262)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(125, 27)
        txtContactNo.TabIndex = 9
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(969, 169)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(125, 27)
        txtGender.TabIndex = 10
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(425, 349)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 27)
        txtAge.TabIndex = 11
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(425, 255)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 12
        ' 
        ' txtPatientId
        ' 
        txtPatientId.Location = New Point(425, 163)
        txtPatientId.Name = "txtPatientId"
        txtPatientId.Size = New Size(125, 27)
        txtPatientId.TabIndex = 13
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(285, 502)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(94, 29)
        btnInsert.TabIndex = 14
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(859, 502)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(94, 29)
        btnNext.TabIndex = 15
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(714, 502)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(569, 502)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 17
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(425, 502)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 18
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(569, 437)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 19
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(1000, 502)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(94, 29)
        btnPrevious.TabIndex = 20
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' PatientsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(1343, 633)
        Controls.Add(btnPrevious)
        Controls.Add(btnSearch)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnNext)
        Controls.Add(btnInsert)
        Controls.Add(txtPatientId)
        Controls.Add(txtName)
        Controls.Add(txtAge)
        Controls.Add(txtGender)
        Controls.Add(txtContactNo)
        Controls.Add(txtAddress)
        Controls.Add(txtSearch)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "PatientsForm"
        Text = "Patient_Registration_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPatientId As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnPrevious As Button

End Class
