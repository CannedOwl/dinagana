Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Common

    Public Shared myDBConnection As MySqlConnection
    Public Shared Function getDBConnectionX() As MySqlConnection
        myDBConnection = New MySqlConnection(
               "Database=moviedatabase;" &
                     "Data Source=localhost;" &
                    "User id= root;" &
                    "Password= #Monster1472;" &
                    "Port=3306;Command TimeOut=600;")
        Return myDBConnection
    End Function

End Class