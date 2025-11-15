<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentsForm
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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtAppointmentId = New TextBox()
        txtRemarks = New TextBox()
        txtAppointmentDate = New TextBox()
        txtDoctorId = New TextBox()
        txtPatientId = New TextBox()
        btnPrevious = New Button()
        btnDelete = New Button()
        btnNext = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        btnInsert = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label1.Location = New Point(474, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(481, 100)
        Label1.TabIndex = 0
        Label1.Text = vbCrLf & vbCrLf & "                                       APPOINTMENT FORM                                           " & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(142, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 1
        Label2.Text = "Appointment_Id"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(143, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 2
        Label3.Text = "Patient_Id"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(143, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 3
        Label4.Text = "Doctor_Id"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(142, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 20)
        Label5.TabIndex = 4
        Label5.Text = "Appointment_Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(142, 426)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 5
        Label6.Text = "Remarks"
        ' 
        ' txtAppointmentId
        ' 
        txtAppointmentId.Location = New Point(322, 125)
        txtAppointmentId.Name = "txtAppointmentId"
        txtAppointmentId.Size = New Size(125, 27)
        txtAppointmentId.TabIndex = 7
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(322, 419)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(125, 27)
        txtRemarks.TabIndex = 8
        ' 
        ' txtAppointmentDate
        ' 
        txtAppointmentDate.Location = New Point(322, 347)
        txtAppointmentDate.Name = "txtAppointmentDate"
        txtAppointmentDate.Size = New Size(125, 27)
        txtAppointmentDate.TabIndex = 9
        ' 
        ' txtDoctorId
        ' 
        txtDoctorId.Location = New Point(322, 268)
        txtDoctorId.Name = "txtDoctorId"
        txtDoctorId.Size = New Size(125, 27)
        txtDoctorId.TabIndex = 10
        ' 
        ' txtPatientId
        ' 
        txtPatientId.Location = New Point(322, 193)
        txtPatientId.Name = "txtPatientId"
        txtPatientId.Size = New Size(125, 27)
        txtPatientId.TabIndex = 11
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(1143, 250)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(94, 29)
        btnPrevious.TabIndex = 12
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(1143, 193)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(967, 250)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(94, 29)
        btnNext.TabIndex = 14
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(967, 191)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(787, 250)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(787, 189)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(94, 29)
        btnInsert.TabIndex = 17
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(881, 309)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 18
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(981, 309)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 20
        ' 
        ' AppointmentsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(1396, 626)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(btnInsert)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnNext)
        Controls.Add(btnDelete)
        Controls.Add(btnPrevious)
        Controls.Add(txtPatientId)
        Controls.Add(txtDoctorId)
        Controls.Add(txtAppointmentDate)
        Controls.Add(txtRemarks)
        Controls.Add(txtAppointmentId)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AppointmentsForm"
        Text = "Appointment_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAppointmentId As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtAppointmentDate As TextBox
    Friend WithEvents txtDoctorId As TextBox
    Friend WithEvents txtPatientId As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
