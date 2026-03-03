Imports System.Data.SqlClient

Module DBConnection

    ' Update this to match your SQL Server instance.
    ' Integrated Security example:
    '   "Server=localhost;Database=TrackingFileDB;Integrated Security=True;"
    ' SQL Server auth example:
    '   "Server=SERVERNAME\INSTANCE;Database=TrackingFileDB;User Id=sa;Password=your_password;"
    Private ReadOnly connStr As String = "Server=localhost;Database=TrackingFileDB;Integrated Security=True;"

    ' Public connection object (created on first use)
    Public con As SqlConnection = Nothing

    ' Open database connection (lazy create)
    Public Sub OpenCon()
        If con Is Nothing Then
            con = New SqlConnection(connStr)
        End If

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    ' Close database connection
    Public Sub CloseCon()
        If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

End Module