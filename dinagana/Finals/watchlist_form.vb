Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Data
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class watchlist_form

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

    Dim myConnection As MySqlConnection
    'Dim usernameValue As String = Me.Username

    Dim usernameValue As String = LoginPage.TextBoxData
    'Getting the User ID Value using the Username
    Dim userId As Integer = GetUserId(usernameValue)
    Private Function GetUserId(usernameValue As String) As Integer
        myConnection = Common.getDBConnectionX()
        Dim query As String = "SELECT users_no FROM tblusers WHERE userName = @userName"
        Dim userId As Integer

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
    Private Sub InsertPlaylist(userId As Integer, playlistName As String)
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
    Private Sub BtnCreatePlaylist_Click(sender As Object, e As EventArgs) Handles BtnCreatePlaylist.Click

        Dim playlistName As String = txtPlaylistName.Text

        ' Get user_id based on the provided userName
        Dim userId As Integer = GetUserId(usernameValue)

        If userId <> -1 Then
            ' Insert new playlist into the playlists table
            InsertPlaylist(userId, playlistName)
            MessageBox.Show("Playlist added successfully.")
        Else
            MessageBox.Show("User not found. Please enter a valid username.")
        End If
    End Sub




End Class


