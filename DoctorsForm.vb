Imports Oracle.ManagedDataAccess.Client

Public Class DoctorsForm
    Private currentPosition As Integer = 0
    Private recordCount As Integer = 0

    Private Sub DoctorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctorData()
    End Sub

    Private Sub LoadDoctorData()
        Try
            OpenConnection()
            da = New OracleDataAdapter("SELECT * FROM DoctorTable3 ORDER BY Doctor_Id", conn)
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
            txtDoctorId.Text = dt.Rows(position)("Doctor_Id").ToString()
            txtName.Text = dt.Rows(position)("Name").ToString()
            txtSpecialisation.Text = dt.Rows(position)("Specialisation").ToString()
            txtContactNo.Text = dt.Rows(position)("Contact_No").ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtDoctorId.Clear()
        txtName.Clear()
        txtSpecialisation.Clear()
        txtContactNo.Clear()
        txtSearch.Clear()
        txtDoctorId.Focus()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If String.IsNullOrWhiteSpace(txtDoctorId.Text) OrElse String.IsNullOrWhiteSpace(txtName.Text) Then
                MessageBox.Show("Please enter Doctor ID and Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "INSERT INTO DoctorTable3 (Doctor_Id, Name, Specialisation, Contact_No) VALUES (:id, :name, :spec, :contact)"
            cmd = New OracleCommand(query, conn)

            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Integer.Parse(txtDoctorId.Text)
            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = txtName.Text
            cmd.Parameters.Add(":spec", OracleDbType.Varchar2).Value = txtSpecialisation.Text
            cmd.Parameters.Add(":contact", OracleDbType.Varchar2).Value = txtContactNo.Text

            cmd.ExecuteNonQuery()
            MessageBox.Show("Doctor record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CloseConnection()
            LoadDoctorData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error inserting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseConnection()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtDoctorId.Text) Then
                MessageBox.Show("Please enter Doctor ID to update", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "UPDATE DoctorTable3 SET Name=:name, Specialisation=:spec, Contact_No=:contact WHERE Doctor_Id=:id"
            cmd = New OracleCommand(query, conn)

            cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = txtName.Text
            cmd.Parameters.Add(":spec", OracleDbType.Varchar2).Value = txtSpecialisation.Text
            cmd.Parameters.Add(":contact", OracleDbType.Varchar2).Value = txtContactNo.Text
            cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Integer.Parse(txtDoctorId.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Doctor record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with this Doctor ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CloseConnection()
            LoadDoctorData()
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CloseConnection()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtDoctorId.Text) Then
                MessageBox.Show("Please enter Doctor ID to delete", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                OpenConnection()
                Dim query As String = "DELETE FROM DoctorTable3 WHERE Doctor_Id=:id"
                cmd = New OracleCommand(query, conn)
                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = Integer.Parse(txtDoctorId.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Doctor record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                Else
                    MessageBox.Show("No record found with this Doctor ID", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                CloseConnection()
                LoadDoctorData()
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
                MessageBox.Show("Please enter Doctor ID or Name to search", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()
            Dim query As String = "SELECT * FROM DoctorTable3 WHERE Doctor_Id = :search OR UPPER(Name) LIKE UPPER(:searchName)"
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
                txtDoctorId.Text = dr("Doctor_Id").ToString()
                txtName.Text = dr("Name").ToString()
                txtSpecialisation.Text = dr("Specialisation").ToString()
                txtContactNo.Text = dr("Contact_No").ToString()
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
