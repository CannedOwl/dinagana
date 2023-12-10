<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddmovietoPlaylist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        MySqlCommandBuilder1 = New MySqlConnector.MySqlCommandBuilder()
        BtnAddmovie = New Guna.UI2.WinForms.Guna2Button()
        btnAddPlaylist = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        Label2 = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Label3 = New Label()
        dataGridPlaylistmovies = New Guna.UI2.WinForms.Guna2DataGridView()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        Guna2ShadowPanel1.SuspendLayout()
        CType(dataGridPlaylistmovies, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' MySqlCommandBuilder1
        ' 
        MySqlCommandBuilder1.DataAdapter = Nothing
        MySqlCommandBuilder1.QuotePrefix = "`"
        MySqlCommandBuilder1.QuoteSuffix = "`"
        ' 
        ' BtnAddmovie
        ' 
        BtnAddmovie.BorderRadius = 15
        BtnAddmovie.CustomizableEdges = CustomizableEdges13
        BtnAddmovie.DisabledState.BorderColor = Color.DarkGray
        BtnAddmovie.DisabledState.CustomBorderColor = Color.DarkGray
        BtnAddmovie.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnAddmovie.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnAddmovie.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAddmovie.ForeColor = Color.White
        BtnAddmovie.Location = New Point(49, 328)
        BtnAddmovie.Name = "BtnAddmovie"
        BtnAddmovie.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        BtnAddmovie.Size = New Size(120, 29)
        BtnAddmovie.TabIndex = 9
        BtnAddmovie.Text = "Add to Playlist"
        ' 
        ' btnAddPlaylist
        ' 
        btnAddPlaylist.BorderRadius = 15
        btnAddPlaylist.CustomizableEdges = CustomizableEdges11
        btnAddPlaylist.DisabledState.BorderColor = Color.DarkGray
        btnAddPlaylist.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddPlaylist.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddPlaylist.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddPlaylist.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddPlaylist.ForeColor = Color.White
        btnAddPlaylist.Location = New Point(196, 328)
        btnAddPlaylist.Name = "btnAddPlaylist"
        btnAddPlaylist.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnAddPlaylist.Size = New Size(120, 29)
        btnAddPlaylist.TabIndex = 10
        btnAddPlaylist.Text = "Create Watchlist"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(113, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 15)
        Label1.TabIndex = 11
        Label1.Text = "Please Select a Playlist"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(322, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 12
        Label2.Text = "Label2"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 15
        Guna2Button1.CustomizableEdges = CustomizableEdges9
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(333, 265)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button1.Size = New Size(37, 29)
        Guna2Button1.TabIndex = 13
        Guna2Button1.Text = "Add to Playlist"
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(Guna2ControlBox3)
        Guna2ShadowPanel1.Controls.Add(Guna2ControlBox4)
        Guna2ShadowPanel1.Controls.Add(Guna2ControlBox2)
        Guna2ShadowPanel1.Controls.Add(Guna2ControlBox1)
        Guna2ShadowPanel1.Dock = DockStyle.Top
        Guna2ShadowPanel1.FillColor = Color.Transparent
        Guna2ShadowPanel1.Location = New Point(0, 0)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = SystemColors.ActiveCaptionText
        Guna2ShadowPanel1.ShadowDepth = 70
        Guna2ShadowPanel1.ShadowShift = 100
        Guna2ShadowPanel1.Size = New Size(778, 31)
        Guna2ShadowPanel1.TabIndex = 14
        ' 
        ' Guna2ControlBox3
        ' 
        Guna2ControlBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox3.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox3.FillColor = Color.Transparent
        Guna2ControlBox3.IconColor = Color.DimGray
        Guna2ControlBox3.Location = New Point(721, 3)
        Guna2ControlBox3.Name = "Guna2ControlBox3"
        Guna2ControlBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox3.Size = New Size(24, 24)
        Guna2ControlBox3.TabIndex = 12
        ' 
        ' Guna2ControlBox4
        ' 
        Guna2ControlBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox4.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox4.FillColor = Color.Transparent
        Guna2ControlBox4.IconColor = Color.DimGray
        Guna2ControlBox4.Location = New Point(751, 3)
        Guna2ControlBox4.Name = "Guna2ControlBox4"
        Guna2ControlBox4.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox4.Size = New Size(24, 24)
        Guna2ControlBox4.TabIndex = 11
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges5
        Guna2ControlBox2.FillColor = Color.Transparent
        Guna2ControlBox2.IconColor = Color.DimGray
        Guna2ControlBox2.Location = New Point(1552, 3)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2ControlBox2.Size = New Size(24, 24)
        Guna2ControlBox2.TabIndex = 10
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges7
        Guna2ControlBox1.FillColor = Color.Transparent
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(1582, 3)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2ControlBox1.Size = New Size(24, 24)
        Guna2ControlBox1.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(322, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 15
        Label3.Text = "Label3"
        ' 
        ' dataGridPlaylistmovies
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dataGridPlaylistmovies.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dataGridPlaylistmovies.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dataGridPlaylistmovies.ColumnHeadersHeight = 4
        dataGridPlaylistmovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dataGridPlaylistmovies.DefaultCellStyle = DataGridViewCellStyle3
        dataGridPlaylistmovies.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dataGridPlaylistmovies.Location = New Point(466, 77)
        dataGridPlaylistmovies.Name = "dataGridPlaylistmovies"
        dataGridPlaylistmovies.RowHeadersVisible = False
        dataGridPlaylistmovies.RowTemplate.Height = 25
        dataGridPlaylistmovies.Size = New Size(267, 245)
        dataGridPlaylistmovies.TabIndex = 16
        dataGridPlaylistmovies.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dataGridPlaylistmovies.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dataGridPlaylistmovies.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dataGridPlaylistmovies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dataGridPlaylistmovies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dataGridPlaylistmovies.ThemeStyle.BackColor = Color.White
        dataGridPlaylistmovies.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dataGridPlaylistmovies.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dataGridPlaylistmovies.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dataGridPlaylistmovies.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dataGridPlaylistmovies.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dataGridPlaylistmovies.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dataGridPlaylistmovies.ThemeStyle.HeaderStyle.Height = 4
        dataGridPlaylistmovies.ThemeStyle.ReadOnly = False
        dataGridPlaylistmovies.ThemeStyle.RowsStyle.BackColor = Color.White
        dataGridPlaylistmovies.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dataGridPlaylistmovies.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dataGridPlaylistmovies.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dataGridPlaylistmovies.ThemeStyle.RowsStyle.Height = 25
        dataGridPlaylistmovies.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dataGridPlaylistmovies.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(49, 77)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(267, 244)
        ListBox1.TabIndex = 17
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(322, 77)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(120, 94)
        ListBox2.TabIndex = 18
        ListBox2.Visible = False
        ' 
        ' AddmovietoPlaylist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(778, 382)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(dataGridPlaylistmovies)
        Controls.Add(Label3)
        Controls.Add(Guna2ShadowPanel1)
        Controls.Add(Guna2Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAddPlaylist)
        Controls.Add(BtnAddmovie)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddmovietoPlaylist"
        Text = "AddtoPlaylist"
        Guna2ShadowPanel1.ResumeLayout(False)
        CType(dataGridPlaylistmovies, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnAddPlaylist As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAddmovie As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MySqlCommandBuilder1 As MySqlConnector.MySqlCommandBuilder
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dataGridPlaylistmovies As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
End Class
