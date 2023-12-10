Imports Guna.UI2.WinForms

Public Class Form1
    Public Property Guna2Transition1 As Object

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles kierron1.Click


        Guna2ShadowPanel1.Visible = True
        Guna2ShadowPanel2.Visible = False


    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Guna2ShadowPanel1.Visible = False
        Guna2ShadowPanel2.Visible = True

    End Sub

    Private Sub Guna2ShadowPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel2.Paint

    End Sub


End Class