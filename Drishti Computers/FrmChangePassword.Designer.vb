<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePassword))
        Me.TitelCusGraPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.LogoPic1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ClosePic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LabelAbout = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.ChangePassowrdBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TitelCusGraPanel.SuspendLayout()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelCusGraPanel
        '
        Me.TitelCusGraPanel.BackColor = System.Drawing.Color.Transparent
        Me.TitelCusGraPanel.BorderRadius = 5
        Me.TitelCusGraPanel.Controls.Add(Me.LogoPic1)
        Me.TitelCusGraPanel.Controls.Add(Me.ClosePic)
        Me.TitelCusGraPanel.Controls.Add(Me.LabelAbout)
        Me.TitelCusGraPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitelCusGraPanel.FillColor = System.Drawing.Color.Azure
        Me.TitelCusGraPanel.FillColor2 = System.Drawing.Color.LightCyan
        Me.TitelCusGraPanel.FillColor3 = System.Drawing.Color.LightCyan
        Me.TitelCusGraPanel.FillColor4 = System.Drawing.Color.Honeydew
        Me.TitelCusGraPanel.Location = New System.Drawing.Point(0, 0)
        Me.TitelCusGraPanel.Name = "TitelCusGraPanel"
        Me.TitelCusGraPanel.ShadowDecoration.Enabled = True
        Me.TitelCusGraPanel.ShadowDecoration.Parent = Me.TitelCusGraPanel
        Me.TitelCusGraPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TitelCusGraPanel.Size = New System.Drawing.Size(318, 30)
        Me.TitelCusGraPanel.TabIndex = 3
        '
        'LogoPic1
        '
        Me.LogoPic1.Image = CType(resources.GetObject("LogoPic1.Image"), System.Drawing.Image)
        Me.LogoPic1.Location = New System.Drawing.Point(10, 4)
        Me.LogoPic1.Name = "LogoPic1"
        Me.LogoPic1.ShadowDecoration.BorderRadius = 2
        Me.LogoPic1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LogoPic1.ShadowDecoration.Enabled = True
        Me.LogoPic1.ShadowDecoration.Parent = Me.LogoPic1
        Me.LogoPic1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.LogoPic1.Size = New System.Drawing.Size(20, 20)
        Me.LogoPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPic1.TabIndex = 71
        Me.LogoPic1.TabStop = False
        '
        'ClosePic
        '
        Me.ClosePic.AutoRoundedCorners = True
        Me.ClosePic.BackColor = System.Drawing.Color.Transparent
        Me.ClosePic.BorderRadius = 11
        Me.ClosePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClosePic.Image = CType(resources.GetObject("ClosePic.Image"), System.Drawing.Image)
        Me.ClosePic.Location = New System.Drawing.Point(288, 3)
        Me.ClosePic.Name = "ClosePic"
        Me.ClosePic.ShadowDecoration.BorderRadius = 16
        Me.ClosePic.ShadowDecoration.Color = System.Drawing.Color.Red
        Me.ClosePic.ShadowDecoration.Enabled = True
        Me.ClosePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ClosePic.ShadowDecoration.Parent = Me.ClosePic
        Me.ClosePic.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.ClosePic.Size = New System.Drawing.Size(24, 24)
        Me.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClosePic.TabIndex = 70
        Me.ClosePic.TabStop = False
        '
        'LabelAbout
        '
        Me.LabelAbout.AutoSize = True
        Me.LabelAbout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelAbout.Location = New System.Drawing.Point(37, 5)
        Me.LabelAbout.Name = "LabelAbout"
        Me.LabelAbout.Size = New System.Drawing.Size(126, 19)
        Me.LabelAbout.TabIndex = 72
        Me.LabelAbout.Text = "Center Information"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.ChangePassowrdBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtConfirmPassword)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtNewPassword)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtUserID)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Azure
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.PaleTurquoise
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 35)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(317, 158)
        Me.Guna2CustomGradientPanel1.TabIndex = 4
        '
        'ChangePassowrdBtn
        '
        Me.ChangePassowrdBtn.Animated = True
        Me.ChangePassowrdBtn.BackColor = System.Drawing.Color.Transparent
        Me.ChangePassowrdBtn.BorderColor = System.Drawing.Color.White
        Me.ChangePassowrdBtn.BorderRadius = 5
        Me.ChangePassowrdBtn.BorderThickness = 1
        Me.ChangePassowrdBtn.CheckedState.Parent = Me.ChangePassowrdBtn
        Me.ChangePassowrdBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangePassowrdBtn.CustomImages.Parent = Me.ChangePassowrdBtn
        Me.ChangePassowrdBtn.FillColor = System.Drawing.Color.Lime
        Me.ChangePassowrdBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.0!)
        Me.ChangePassowrdBtn.ForeColor = System.Drawing.Color.Black
        Me.ChangePassowrdBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.ChangePassowrdBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ChangePassowrdBtn.HoverState.Image = CType(resources.GetObject("ChangePassowrdBtn.HoverState.Image"), System.Drawing.Image)
        Me.ChangePassowrdBtn.HoverState.Parent = Me.ChangePassowrdBtn
        Me.ChangePassowrdBtn.Location = New System.Drawing.Point(98, 117)
        Me.ChangePassowrdBtn.Name = "ChangePassowrdBtn"
        Me.ChangePassowrdBtn.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.ChangePassowrdBtn.ShadowDecoration.Enabled = True
        Me.ChangePassowrdBtn.ShadowDecoration.Parent = Me.ChangePassowrdBtn
        Me.ChangePassowrdBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.ChangePassowrdBtn.Size = New System.Drawing.Size(155, 30)
        Me.ChangePassowrdBtn.TabIndex = 18
        Me.ChangePassowrdBtn.Text = "Change Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Animated = True
        Me.txtConfirmPassword.BorderColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.BorderRadius = 5
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.Parent = Me.txtConfirmPassword
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FillColor = System.Drawing.Color.LightCyan
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtConfirmPassword.FocusedState.Parent = Me.txtConfirmPassword
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.HoverState.Parent = Me.txtConfirmPassword
        Me.txtConfirmPassword.Location = New System.Drawing.Point(140, 82)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPassword.PlaceholderText = ""
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.ShadowDecoration.Parent = Me.txtConfirmPassword
        Me.txtConfirmPassword.Size = New System.Drawing.Size(150, 22)
        Me.txtConfirmPassword.TabIndex = 17
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Animated = True
        Me.txtNewPassword.BorderColor = System.Drawing.Color.Black
        Me.txtNewPassword.BorderRadius = 5
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.Parent = Me.txtNewPassword
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FillColor = System.Drawing.Color.LightCyan
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtNewPassword.FocusedState.Parent = Me.txtNewPassword
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.HoverState.Parent = Me.txtNewPassword
        Me.txtNewPassword.Location = New System.Drawing.Point(140, 43)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPassword.PlaceholderText = ""
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.ShadowDecoration.Parent = Me.txtNewPassword
        Me.txtNewPassword.Size = New System.Drawing.Size(150, 22)
        Me.txtNewPassword.TabIndex = 16
        '
        'txtUserID
        '
        Me.txtUserID.Animated = True
        Me.txtUserID.BorderColor = System.Drawing.Color.Black
        Me.txtUserID.BorderRadius = 5
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.DefaultText = ""
        Me.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.DisabledState.Parent = Me.txtUserID
        Me.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.FillColor = System.Drawing.Color.LightCyan
        Me.txtUserID.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtUserID.FocusedState.Parent = Me.txtUserID
        Me.txtUserID.ForeColor = System.Drawing.Color.Black
        Me.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.HoverState.Parent = Me.txtUserID
        Me.txtUserID.Location = New System.Drawing.Point(140, 10)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserID.PlaceholderText = ""
        Me.txtUserID.SelectedText = ""
        Me.txtUserID.ShadowDecoration.Parent = Me.txtUserID
        Me.txtUserID.Size = New System.Drawing.Size(150, 22)
        Me.txtUserID.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "User ID"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmChangePassword
        '
        Me.AcceptButton = Me.ChangePassowrdBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(318, 194)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.TitelCusGraPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drishti Computers - Change Password"
        Me.TitelCusGraPanel.ResumeLayout(False)
        Me.TitelCusGraPanel.PerformLayout()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitelCusGraPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents LogoPic1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ClosePic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LabelAbout As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ChangePassowrdBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
