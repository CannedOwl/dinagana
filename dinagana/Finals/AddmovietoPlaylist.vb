Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices



Public Class AddmovietoPlaylist
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

    Private Function GetPlaylistId(playlistName As String) As Integer
        Dim myConnection As MySqlConnection

        myConnection = Common.getDBConnectionX()
        Dim playlistId As Integer = -1

        Dim query As String = "SELECT playlist_id FROM playlist WHERE playlist_name = @PlaylistName"
        myConnection.Open()
        Using cmd As New MySqlCommand(query, myConnection)
            cmd.Parameters.AddWithValue("@PlaylistName", playlistName)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    playlistId = Convert.ToInt32(reader("playlist_id"))
                End If
            End Using
        End Using

        Return playlistId
    End Function
    Private Sub AddmovietoPlaylist_Load(sender As Object, e As EventArgs)

        PopulateListBoxes()
    End Sub
    Private Sub PopulateListBoxes()
        Dim Connection As MySqlConnection
        Connection = Common.getDBConnectionX()
        Connection.Open()

        Dim query As String = "SELECT playlist_id, playlist_name FROM playlist"
        Using command As New MySqlCommand(query, Connection)
            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    ListBox1.Items.Add(reader("playlist_name"))
                    ListBox2.Items.Add(reader("playlist_id"))
                End While
            End Using
        End Using

    End Sub
    Private Sub PlaylistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Assuming you have a MySqlConnection named 'connection' established
        Dim Connection As MySqlConnection
        Dim userId As Integer = GetUserId(usernameValue)
        Connection = Common.getDBConnectionX()
        Connection.Open()
        ' Replace 'YourDatabaseName' with your actual database name
        Dim query As String = "SELECT playlist_id, playlist_name FROM playlists WHERE users_no = " & (userId)
        Dim adapter As New MySqlDataAdapter(query, Connection)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        ' Set the DataSource and DisplayMember for the ListBox
        ListBox1.DataSource = dataTable
        ListBox1.DisplayMember = "playlist_name"

        ' Set the ValueMember for the ListBox (hidden)
        ListBox2.ValueMember = "playlist_id"
        ' ...
    End Sub
    Private selectedMovieIds As List(Of Integer)

    Public Sub New(movieIds As List(Of Integer))
        InitializeComponent()
        selectedMovieIds = movieIds
    End Sub
    Private Sub btnAddToPlaylist_Click(sender As Object, e As EventArgs) Handles BtnAddmovie.Click



        Dim Connection As MySqlConnection
        Connection = Common.getDBConnectionX()
        Dim selectedIndex As Integer = ListBox1.SelectedIndex
        ' Check if an item is selected in ListBox1
        If selectedIndex >= 0 AndAlso selectedIndex < ListBox2.Items.Count Then
            ' Get the corresponding playlist ID from ListBox2
            Connection.Open()
            Dim selectedPlaylistId As Integer = CInt(ListBox2.Items(selectedIndex))
            For Each movieId As Integer In selectedMovieIds
                Using command As New MySqlCommand("INSERT INTO playlist_movies (playlist_id, movie_no) VALUES (@playlist_id, @movie_no)", Connection)
                    command.Parameters.AddWithValue("@playlist_id", selectedPlaylistId)
                    command.Parameters.AddWithValue("@movie_no", movieId)
                    command.ExecuteNonQuery()
                End Using
            Next
            ' Now you can use the selectedPlaylistId as needed
            MessageBox.Show($"Selected Playlist ID: {selectedPlaylistId}")
        Else
            MessageBox.Show("Please select a playlist.")
        End If
    End Sub
End Class