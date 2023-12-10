<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuideLines
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GuideLines))
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Label1 = New Label()
        Guna2CircleButton8 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ShadowPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.BackgroundImage = CType(resources.GetObject("Guna2ShadowPanel1.BackgroundImage"), Image)
        Guna2ShadowPanel1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2ShadowPanel1.Controls.Add(Guna2ControlBox2)
        Guna2ShadowPanel1.Controls.Add(Guna2ControlBox1)
        Guna2ShadowPanel1.Controls.Add(Guna2CircleButton8)
        Guna2ShadowPanel1.FillColor = Color.Transparent
        Guna2ShadowPanel1.Location = New Point(0, 0)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2ShadowPanel1.Size = New Size(348, 32)
        Guna2ShadowPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(9, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 494)
        Label1.TabIndex = 1
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Guna2CircleButton8
        ' 
        Guna2CircleButton8.BackColor = Color.Transparent
        Guna2CircleButton8.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton8.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton8.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton8.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton8.FillColor = Color.Transparent
        Guna2CircleButton8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2CircleButton8.ForeColor = Color.White
        Guna2CircleButton8.Image = CType(resources.GetObject("Guna2CircleButton8.Image"), Image)
        Guna2CircleButton8.Location = New Point(0, 3)
        Guna2CircleButton8.Name = "Guna2CircleButton8"
        Guna2CircleButton8.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2CircleButton8.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton8.Size = New Size(43, 24)
        Guna2CircleButton8.TabIndex = 8
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox2.FillColor = Color.Transparent
        Guna2ControlBox2.IconColor = Color.DimGray
        Guna2ControlBox2.Location = New Point(294, 3)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox2.Size = New Size(24, 24)
        Guna2ControlBox2.TabIndex = 12
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = Color.Transparent
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(324, 3)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(24, 24)
        Guna2ControlBox1.TabIndex = 11
        ' 
        ' GuideLines
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(348, 533)
        Controls.Add(Label1)
        Controls.Add(Guna2ShadowPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "GuideLines"
        Text = "GuideLines"
        Guna2ShadowPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CircleButton8 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
