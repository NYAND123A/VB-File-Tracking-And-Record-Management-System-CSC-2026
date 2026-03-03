' Session functionality removed per request.
' This file intentionally left blank to avoid Session usage in the project.
Module Session
    Public Property CurrentUsername As String

    Friend Function CurrentRole() As String
        Throw New NotImplementedException()
    End Function

    Friend Function CurrentDepartment() As String
        Throw New NotImplementedException()
    End Function
End Module