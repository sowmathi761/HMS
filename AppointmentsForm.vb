Imports Oracle.ManagedDataAccess.Client

Public Class AppointmentsForm
    Private currentPosition As Integer = 0
    Private recordCount As Integer = 0

    Private Sub AppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppointmentData()
    End Sub

    Private Sub LoadAppointmentData()
        Try
            OpenConnection()
            da = New OracleDataAdapter("SELECT * FROM AppointmentTable3 ORDER BY Appointment_Id", conn)
            dt = New DataTable()
            da.Fill(dt)
            recordCount = dt.Rows.Count
            If recordCount > 0 Then
                DisplayRecord(0)
            End If
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayRecord(position As Integer)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso position >= 0 AndAlso position < dt.Rows.Count Then
            currentPosition = position
            txtAppointmentId.Text = dt.Rows(position)("Appointment_Id").ToString()
            txtPatientId.Text = dt.Rows(position)("Patient_Id").ToString()
            txtDoctorId.Text = dt.Rows(position)("Doctor_Id").ToString()
            txtAppointmentDate.Text = Convert.ToDateTime(dt.Rows(position)("Appointment_Date")).ToString("dd-MMM-yyyy")
            txtRemarks.Text = dt.Rows(position)("Remarks").ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtAppointmentId.Clear()
        txtPatientId.Clear()
        txtDoctorId.Clear()
        txtAppointmentDate.Clear()
        txtRemarks.Clear()
        txtSearch.Clear()
        txtAppointmentId.Focus()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If String.IsNullOrWhiteSpace(txtAppointmentId.Text) OrElse String.IsNullOrWhiteSpace(txtPatientId.Text) OrElse String.IsNullOrWhiteSpace(txtDoctorId.Text) Then
                MessageBox.Show("Please enter Appointment ID, Patient ID and Doctor ID", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "INSERT INTO AppointmentTable3 (Appointment_Id, Patient_Id, Doctor_Id, Appointment_Date, Remarks) VALUES (:appid, :patid, :docid, :appdate, :remarks)"
            cmd = New OracleCommand(query, conn)
            cmd.Parameters.Add(":appid", OracleDbType.Int32).Value = Integer.Parse(txtAppointmentId.Text)
            cmd.Parameters.Add(":patid", OracleDbType.Int32).Value = Integer.Parse(txtPatientId.Text)
            cmd.Parameters.Add(":docid", OracleDbType.Int32).Value = Integer.Parse(txtDoctorId.Text)

            If String.IsNullOrWhiteSpace(txtAppointmentDate.Text) Then
                cmd.Parameters.Add(":appdate", OracleDbType.Date).Value = DateTime.Now
            Else
                cmd.Parameters.Add(":appdate", OracleDbType.Date).Value = DateTime.Parse(txtAppointmentDate.Text)
            End If

            cmd.Parameters.Add(":remarks", OracleDbType.Varchar2).Value = txtRemarks.Text

            cmd.ExecuteNonQuery()
            MessageBox.Show("Appointment record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CloseConnection()
            LoadAppointmentData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error inserting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseConnection()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtAppointmentId.Text) Then
                MessageBox.Show("Please enter Appointment ID to update", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "UPDATE AppointmentTable3 SET Patient_Id=:patid, Doctor_Id=:docid, Appointment_Date=:appdate, Remarks=:remarks WHERE Appointment_Id=:appid"
            cmd = New OracleCommand(query, conn)
            cmd.Parameters.Add(":patid", OracleDbType.Int32).Value = Integer.Parse(txtPatientId.Text)
            cmd.Parameters.Add(":docid", OracleDbType.Int32).Value = Integer.Parse(txtDoctorId.Text)
            cmd.Parameters.Add(":appdate", OracleDbType.Date).Value = DateTime.Parse(txtAppointmentDate.Text)
            cmd.Parameters.Add(":remarks", OracleDbType.Varchar2).Value = txtRemarks.Text
            cmd.Parameters.Add(":appid", OracleDbType.Int32).Value = Integer.Parse(txtAppointmentId.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Appointment record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with this Appointment ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CloseConnection()
            LoadAppointmentData()
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseConnection()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtAppointmentId.Text) Then
                MessageBox.Show("Please enter Appointment ID to delete", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                OpenConnection()
                Dim query As String = "DELETE FROM AppointmentTable3 WHERE Appointment_Id=:appid"
                cmd = New OracleCommand(query, conn)
                cmd.Parameters.Add(":appid", OracleDbType.Int32).Value = Integer.Parse(txtAppointmentId.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Appointment record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                Else
                    MessageBox.Show("No record found with this Appointment ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                CloseConnection()
                LoadAppointmentData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseConnection()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("Please enter Appointment ID to search", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "SELECT * FROM AppointmentTable3 WHERE Appointment_Id = :search"
            cmd = New OracleCommand(query, conn)
            cmd.Parameters.Add(":search", OracleDbType.Int32).Value = Integer.Parse(txtSearch.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtAppointmentId.Text = dr("Appointment_Id").ToString()
                txtPatientId.Text = dr("Patient_Id").ToString()
                txtDoctorId.Text = dr("Doctor_Id").ToString()
                txtAppointmentDate.Text = Convert.ToDateTime(dr("Appointment_Date")).ToString("dd-MMM-yyyy")
                txtRemarks.Text = dr("Remarks").ToString()
            Else
                MessageBox.Show("No record found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            dr.Close()
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Error searching record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseConnection()
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPosition < recordCount - 1 Then
            DisplayRecord(currentPosition + 1)
        Else
            MessageBox.Show("This is the last record", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentPosition > 0 Then
            DisplayRecord(currentPosition - 1)
        Else
            MessageBox.Show("This is the first record", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtPatientId_TextChanged(sender As Object, e As EventArgs) Handles txtPatientId.TextChanged

    End Sub
End Class