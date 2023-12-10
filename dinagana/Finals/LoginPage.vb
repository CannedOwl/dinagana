Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class LoginPage

    Private Sub txtbxpassword_TextChanged(sender As Object, e As EventArgs) Handles txtbxpassword.TextChanged
        txtbxpassword.PasswordChar = "●"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' If the checkbox is checked, show the password
            txtbxpassword.PasswordChar = ControlChars.NullChar ' Set to null to show actual characters
        Else
            ' If the checkbox is unchecked, hide the password
            txtbxpassword.PasswordChar = "●"
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        login()
    End Sub



    'Login Function'
    Sub login()
        ' Set the Username property with the value from the TextBox in Form1

        Dim myConnectionx As MySqlConnection
        Dim myCommandx As MySqlCommand
        Dim username As String = userTxtbx.Text
        Dim password As String = txtbxpassword.Text


        SelectionOfUser.Username = userTxtbx.Text
        watchlist_form.Username = userTxtbx.Text




        myConnectionx = Common.getDBConnectionX()

        myConnectionx.Open()
        myCommandx = New MySqlCommand($"SELECT userName, userPass FROM tblusers WHERE userName = @username AND userPass = @password", myConnectionx)
        myCommandx.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
        myCommandx.Parameters.Add("@password", MySqlDbType.VarChar).Value = password

        Dim adapter As New MySqlDataAdapter(myCommandx)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count = 1 Then

            Me.Hide()
            SelectionOfUser.Show()
            SelectionOfUser.Focus()

        Else
            MessageBox.Show("INVALID USERNAME OR PASSWORD")

        End If

    End Sub
    Public ReadOnly Property TextBoxData As String
        Get
            Return userTxtbx.Text ' Assuming TextBox1 is the name of your TextBox
        End Get
    End Property
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Create an instance of Form2
        Dim register As New CreateAccount()

        ' Show Form2
        register.Show()
    End Sub


End Class
'=======================================================================================================================






