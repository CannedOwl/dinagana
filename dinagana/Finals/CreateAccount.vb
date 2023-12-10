Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class CreateAccount


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim dbConnection As MySqlConnection
        Dim query As MySqlCommand
        dbConnection = Common.getDBConnectionX()


        If Not String.IsNullOrWhiteSpace(newUser.Text) AndAlso
           Not String.IsNullOrWhiteSpace(newPass.Text) Then
            ' All three textboxes have input
            dbConnection.Open()
            query = New MySqlCommand("INSERT INTO tblusers (userName, userPass, userType) VALUES (@username, @password, 'Consumer');")
            query.Parameters.Add("@username", MySqlDbType.VarChar).Value = newUser
            query.Parameters.Add("@password", MySqlDbType.VarChar).Value = newPass

        Else
            ' One or more textboxes are empty
            MessageBox.Show("Please fill in all the requirements.")
        End If

    End Sub
End Class