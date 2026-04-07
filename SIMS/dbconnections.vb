Imports MySql.Data.MySqlClient

Module dbconnections

    ' === CONNECTION STRING ===
    Public conn As New MySqlConnection("server=localhost;user id=root;password=;database=simsdb;")
    Public dr As MySqlDataReader
    ' === OPEN CONNECTION ===
    Public Sub openConn()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Database connection failed: " & ex.Message)
        End Try
    End Sub

    ' === CLOSE CONNECTION ===
    Public Sub closeConn()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Failed to close connection: " & ex.Message)
        End Try
    End Sub

    ' === GET COMMAND (REUSABLE) ===
    Public Function cmd(query As String) As MySqlCommand
        Return New MySqlCommand(query, conn)
    End Function

End Module