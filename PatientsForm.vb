Imports Oracle.ManagedDataAccess.Client

Public Class PatientsForm
    Private currentPosition As Integer = 0
    Private recordCount As Integer = 0

    Private Sub PatientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientData()
    End Sub

    Private Sub LoadPatientData()
        Try
            OpenConnection()
            da = New OracleDataAdapter("SELECT * FROM PatientTable3 ORDER BY Patient_Id", conn)
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
            txtPatientId.Text = dt.Rows(position)("Patient_Id").ToString()
            txtName.Text = dt.Rows(position)("Name").ToString()
            txtAge.Text = dt.Rows(position)("Age").ToString()
            txtGender.Text = dt.Rows(position)("Gender").ToString()
            txtContactNo.Text = dt.Rows(position)("Contact_No").ToString()
            txtAddress.Text = dt.Rows(position)("Address").ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtPatientId.Clear()
        txtName.Clear()
        txtAge.Clear()
        txtGender.Clear()
        txtContactNo.Clear()
        txtAddress.Clear()
        txtSearch.Clear()
        txtPatientId.Focus()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If String.IsNullOrWhiteSpace(txtPatientId.Text) OrElse String.IsNullOrWhiteSpace(txtName.Text) Then
                MessageBox.Show("Please enter Patient ID and Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "INSERT INTO PatientTable3 (Patient_Id, Name, Age, Gender, Contact_No, Address) VALUES (:id, :name, :age, :gender, :contact, :address)"
            cmd = New OracleCommand(query, conn)
            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Integer.Parse(txtPatientId.Text)
            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = txtName.Text
            cmd.Parameters.Add(":age", OracleDbType.Int32).Value = If(String.IsNullOrWhiteSpace(txtAge.Text), DBNull.Value, Integer.Parse(txtAge.Text))
            cmd.Parameters.Add(":gender", OracleDbType.Varchar2).Value = txtGender.Text
            cmd.Parameters.Add(":contact", OracleDbType.Varchar2).Value = txtContactNo.Text
            cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = txtAddress.Text

            cmd.ExecuteNonQuery()
            MessageBox.Show("Patient record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CloseConnection()
            LoadPatientData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error inserting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseConnection()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtPatientId.Text) Then
                MessageBox.Show("Please enter Patient ID to update", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "UPDATE PatientTable3 SET Name=:name, Age=:age, Gender=:gender, Contact_No=:contact, Address=:address WHERE Patient_Id=:id"
            cmd = New OracleCommand(query, conn)
            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = txtName.Text
            cmd.Parameters.Add(":age", OracleDbType.Int32).Value = If(String.IsNullOrWhiteSpace(txtAge.Text), DBNull.Value, Integer.Parse(txtAge.Text))
            cmd.Parameters.Add(":gender", OracleDbType.Varchar2).Value = txtGender.Text
            cmd.Parameters.Add(":contact", OracleDbType.Varchar2).Value = txtContactNo.Text
            cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = txtAddress.Text
            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Integer.Parse(txtPatientId.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Patient record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with this Patient ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CloseConnection()
            LoadPatientData()
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseConnection()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtPatientId.Text) Then
                MessageBox.Show("Please enter Patient ID to delete", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                OpenConnection()
                Dim query As String = "DELETE FROM AppointmentTable3 WHERE Patient_Id=:id"
                cmd = New OracleCommand(query, conn)
                Dim query1 As String = "DELETE FROM PatientTable3 WHERE Patient_Id=:id"
                cmd = New OracleCommand(query1, conn)
                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Integer.Parse(txtPatientId.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Patient record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                Else
                    MessageBox.Show("No record found with this Patient ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                CloseConnection()
                LoadPatientData()
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
                MessageBox.Show("Please enter Patient ID or Name to search", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "SELECT * FROM PatientTable3 WHERE Patient_Id = :search OR UPPER(Name) LIKE UPPER(:searchName)"
            cmd = New OracleCommand(query, conn)

            Dim searchValue As String = txtSearch.Text
            If IsNumeric(searchValue) Then
                cmd.Parameters.Add(":search", OracleDbType.Int32).Value = Integer.Parse(searchValue)
            Else
                cmd.Parameters.Add(":search", OracleDbType.Int32).Value = DBNull.Value
            End If
            cmd.Parameters.Add(":searchName", OracleDbType.Varchar2).Value = "%" & searchValue & "%"

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtPatientId.Text = dr("Patient_Id").ToString()
                txtName.Text = dr("Name").ToString()
                txtAge.Text = dr("Age").ToString()
                txtGender.Text = dr("Gender").ToString()
                txtContactNo.Text = dr("Contact_No").ToString()
                txtAddress.Text = dr("Address").ToString()
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
End Class