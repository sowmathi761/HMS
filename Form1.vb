Imports Oracle.ManagedDataAccess.Client
Imports System.Data
Public Class Form1
    ' For MenuStrip items, use ToolStripMenuItem
    Private Sub PatientsFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientsFormToolStripMenuItem.Click
        PatientsForm.Show()
    End Sub

    Private Sub DoctorsFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorsFormToolStripMenuItem.Click
        DoctorsForm.Show()
    End Sub

    Private Sub AppointmentsFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentsFormToolStripMenuItem.Click
        AppointmentsForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class