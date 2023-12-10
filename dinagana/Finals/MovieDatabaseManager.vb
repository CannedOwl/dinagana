Imports System.Data
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class MovieDatabaseManager
    'Getting the Values from the LoginPage
    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property
    Private inputData As Integer
    Dim myConnection As MySqlConnection
    Dim usernameValue As String = Me.Username


    Private Function GetUserId(userName As String) As Integer
        myConnection = Common.getDBConnectionX()

        Dim query As String = "SELECT user_id FROM users WHERE userName = @userName"
        Dim userId As Integer = -1

        Using cmd As New MySqlCommand(query, myConnection)
            cmd.Parameters.AddWithValue("@userName", usernameValue)
            Try
                myConnection.Open()
                userId = Convert.ToInt32(cmd.ExecuteScalar())
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                myConnection.Close()
            End Try
        End Using

        Return userId
    End Function

    Public Sub CreatePlaylist(userId As Integer, playlistName As String)
        myConnection = Common.getDBConnectionX()

        Dim query As String = "INSERT INTO playlists (users_no, playlist_name) VALUES (@userId, @playlistName)"
        Using cmd As New MySqlCommand(query, myConnection)
            cmd.Parameters.AddWithValue("@userId", userId)
            cmd.Parameters.AddWithValue("@playlistName", playlistName)

            Try
                myConnection.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                myConnection.Close()
            End Try
        End Using

    End Sub

End Class