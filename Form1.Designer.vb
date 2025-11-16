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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        PatientsFormToolStripMenuItem = New ToolStripMenuItem()
        DoctorsFormToolStripMenuItem = New ToolStripMenuItem()
        AppointmentsFormToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PatientsFormToolStripMenuItem, DoctorsFormToolStripMenuItem, AppointmentsFormToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1369, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PatientsFormToolStripMenuItem
        ' 
        PatientsFormToolStripMenuItem.Name = "PatientsFormToolStripMenuItem"
        PatientsFormToolStripMenuItem.Size = New Size(108, 24)
        PatientsFormToolStripMenuItem.Text = "PatientsForm"
        ' 
        ' DoctorsFormToolStripMenuItem
        ' 
        DoctorsFormToolStripMenuItem.Name = "DoctorsFormToolStripMenuItem"
        DoctorsFormToolStripMenuItem.Size = New Size(109, 24)
        DoctorsFormToolStripMenuItem.Text = "DoctorsForm"
        ' 
        ' AppointmentsFormToolStripMenuItem
        ' 
        AppointmentsFormToolStripMenuItem.Name = "AppointmentsFormToolStripMenuItem"
        AppointmentsFormToolStripMenuItem.Size = New Size(151, 24)
        AppointmentsFormToolStripMenuItem.Text = "AppointmentsForm"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(47, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1369, 645)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form4"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientsFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctorsFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentsFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
