Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices


Public Class SelectionOfUser

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

    Dim usernameValue As String = Me.Username

    Function GetUserId(userName As String) As Integer
        Dim myConnection As MySqlConnection
        Dim usernameValue As String = Me.Username
        myConnection = Common.getDBConnectionX()

        Dim query As String = "SELECT users_no FROM tblusers WHERE userName = @userName"
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
    Public Sub Display_playlists()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet
        Dim userId As Integer = GetUserId(usernameValue)
        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT tb1.playlist_name 
                                            FROM playlists tb1
                                            JOIN tblusers tb2 on tb1.users_no = tb2.users_no
                                            WHERE tb2.users_no = " & (userId), myConnection1)



            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            'eto magpapashow ng data
            DataGridPlaylist.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try

    End Sub


    Public Sub SelectionOfUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TabWatchlist.Appearance = TabAppearance.FlatButtons
            TabWatchlist.ItemSize = New Size(0, 1)
            TabWatchlist.SizeMode = TabSizeMode.Fixed

        Catch ex As Exception

        End Try
        Display_playlists()
    End Sub

    'Side Menu Buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, BtnProfile.Click, BtnWtchlst.Click
        Try
            Dim MyButton = DirectCast(sender, Button)

            Select Case MyButton.Name
                Case "Button1"
                    TabWatchlist.SelectedTab = homeTab
                Case "Button2"
                    TabWatchlist.SelectedTab = exploreTab
                Case "BtnProfile"
                    TabWatchlist.SelectedTab = TabProfile
                Case "BtnWtchlst"
                    TabWatchlist.SelectedTab = Watchlist
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        LoginPage.Show()
        LoginPage.Focus()

    End Sub

    Private Sub BtnSrch_Click(sender As Object, e As EventArgs)
        SearchData()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BtnSrch.Click
        SearchData()
    End Sub
    'manual data search
    Sub SearchData()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet
        Dim mtitle As String = Guna2TextBox1.Text

        myConnection1 = Common.getDBConnectionX()

        Try

            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT title, year, genre FROM tblmovie WHERE title LIKE '" & (mtitle) & "%'", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")
            'eto magpapashow ng data
            dataGridViewPlaylist.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try

    End Sub
    'Function to display playlist



    'Filter Search
    Private Sub GbtnFS_Click(sender As Object, e As EventArgs) Handles GbtnFS.Click
        Dim selectedGenre As String = ListBox1.GetItemText(ListBox1.SelectedItem)
        Dim selectedYear As String = ListBox2.GetItemText(ListBox2.SelectedItem)

        If Not String.IsNullOrEmpty(selectedGenre) And Not String.IsNullOrEmpty(selectedYear) Then
            ' Both genre and release date are selected
            DisplayMoviesByGenreAndSelectedYear(selectedGenre, selectedYear)
        ElseIf Not String.IsNullOrEmpty(selectedGenre) Then
            ' Only genre is selected
            DisplayMoviesByGenre(selectedGenre)
        ElseIf Not String.IsNullOrEmpty(selectedYear) Then
            ' Only release date is selected
            DisplayMoviesByReleaseDate(selectedYear)
        End If
    End Sub

    Private Sub DisplayMoviesByGenreAndSelectedYear(selectedGenre As String, selectedYear As String)

        Dim query As String = "SELECT movie_id, original_title, genre, released_year FROM tblmovies WHERE genre LIKE @selectedGenre AND released_year LIKE @selectedYear"
        DisplayMovies(query, "%" & selectedGenre & "%", selectedYear)
    End Sub

    Private Sub DisplayMoviesByGenre(selectedGenre As String)
        Dim query As String = "SELECT movie_id, original_title, genre, released_year FROM tblmovies WHERE genre LIKE @selectedGenre"
        DisplayMovies(query, "%" & selectedGenre & "%")
    End Sub

    Private Sub DisplayMoviesByReleaseDate(selectedYear As String)
        Dim query As String = "SELECT movie_id,original_title, genre, released_year FROM tblmovies WHERE released_year LIKE " & selectedYear
        DisplayMovies(query, "%" & selectedYear & "%")
    End Sub

    Private Sub DisplayMovies(query As String, ParamArray parameters() As String)
        Dim myConnection1 As MySqlConnection
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet
        Dim mtitle As String = Guna2TextBox1.Text

        myConnection1 = Common.getDBConnectionX()


        Using command As New MySqlCommand(query, myConnection1)
            For i As Integer = 0 To parameters.Length - 1
                command.Parameters.AddWithValue("@" & If(i = 0, "selectedGenre", "selectedYear"), parameters(i))
            Next

            Using adapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                dataGridViewPlaylist.DataSource = dataTable
                dataGridViewPlaylist.Columns("movie_id").Visible = False
            End Using
        End Using
    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ' Clear selected items in the first ListBox
        ListBox1.ClearSelected()

        ' Clear selected items in the second ListBox
        ListBox2.ClearSelected()
    End Sub

    '===================================== WORK IN PROGRESS =============================================='



    Dim myConnection As MySqlConnection

    'LABEL TESTING TO BE WORKED ON *GUMAGANA SIYA
    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Access the username value
        Dim usernameValue As String = Me.Username


        Label6.Text = usernameValue


    End Sub
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim userId As Integer = GetUserId(usernameValue)


        Label10.Text = userId
    End Sub
    ' Property to store the selected data
    '===============================================================
    Public Property SelectedData As List(Of String) = New List(Of String)()
    Public selectedMovieIDs As New List(Of Integer)
    Private Sub BtnAddtoW_Click(sender As Object, e As EventArgs) Handles BtnAddtoW.Click


        If dataGridViewPlaylist.SelectedRows.Count > 0 Then
            Dim selectedMovieIds As New List(Of Integer)

            For Each row As DataGridViewRow In dataGridViewPlaylist.SelectedRows
                selectedMovieIds.Add(CInt(row.Cells("movie_id").Value))
            Next

            Dim playlistForm As New AddmovietoPlaylist(selectedMovieIds)
            playlistForm.ShowDialog()
        Else
            MessageBox.Show("Please select at least one movie.")
        End If
    End Sub



    Dim selectedMovieId As Integer
    Private Function GetSelectedDataFromDataGridView() As List(Of String)
        ' Implement your logic to get the selected data from DataGridView in Form1
        ' For example, if your DataGridView is named DataGridView1:
        Dim selectedData As New List(Of String)()

        For Each row As DataGridViewRow In dataGridViewPlaylist.SelectedRows
            ' Assuming the data you want is in the first column (index 0)
            selectedData.Add(row.Cells(0).Value.ToString())
        Next

        Return selectedData
    End Function

End Class