Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Module DatabaseModule
    Public conn As OracleConnection
    Public cmd As OracleCommand
    Public da As OracleDataAdapter
    Public dt As DataTable
    Public dr As OracleDataReader

    Public Sub OpenConnection()
        Try
            Dim connString As String = "Data Source=localhost:1521/xe;User Id=system;Password=kprcas;"
            conn = New OracleConnection(connString)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Connection Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module