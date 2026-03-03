Imports MySql.Data.MySqlClient

Module DBConnection

    'Public connection object (usable in all forms)
    Public con As New MySqlConnection(
            "server=localhost;user id=root;password=;database=file_tracking")

    'Open database connection
    Public Sub OpenCon()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    'Close database connection
    Public Sub CloseCon()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

End Module


