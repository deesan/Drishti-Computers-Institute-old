<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PicBoxClose = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ChangePassword = New Guna.UI.WinForms.GunaLinkLabel()
        Me.CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.UserType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.PassHidePic = New System.Windows.Forms.PictureBox()
        Me.PassSeePic = New System.Windows.Forms.PictureBox()
        Me.LogoPic1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LabelAbout = New Guna.UI.WinForms.GunaLabel()
        Me.TitelCusGraPanel = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.PicBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassHidePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassSeePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitelCusGraPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicBoxClose
        '
        Me.PicBoxClose.AutoRoundedCorners = True
        Me.PicBoxClose.BorderRadius = 11
        Me.PicBoxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBoxClose.Image = CType(resources.GetObject("PicBoxClose.Image"), System.Drawing.Image)
        Me.PicBoxClose.Location = New System.Drawing.Point(436, 1)
        Me.PicBoxClose.Name = "PicBoxClose"
        Me.PicBoxClose.ShadowDecoration.Parent = Me.PicBoxClose
        Me.PicBoxClose.Size = New System.Drawing.Size(25, 25)
        Me.PicBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxClose.TabIndex = 8
        Me.PicBoxClose.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'ChangePassword
        '
        Me.ChangePassword.ActiveLinkColor = System.Drawing.Color.Lime
        Me.ChangePassword.AutoSize = True
        Me.ChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.ChangePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChangePassword.Location = New System.Drawing.Point(166, 306)
        Me.ChangePassword.Name = "ChangePassword"
        Me.ChangePassword.Size = New System.Drawing.Size(133, 21)
        Me.ChangePassword.TabIndex = 18
        Me.ChangePassword.TabStop = True
        Me.ChangePassword.Text = "Change Password"
        '
        'CancelBtn
        '
        Me.CancelBtn.Animated = True
        Me.CancelBtn.BackColor = System.Drawing.Color.Transparent
        Me.CancelBtn.BorderColor = System.Drawing.Color.White
        Me.CancelBtn.BorderRadius = 8
        Me.CancelBtn.BorderThickness = 1
        Me.CancelBtn.CheckedState.Parent = Me.CancelBtn
        Me.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelBtn.CustomImages.Parent = Me.CancelBtn
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.FillColor = System.Drawing.Color.Maroon
        Me.CancelBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.HoverState.FillColor = System.Drawing.Color.Red
        Me.CancelBtn.HoverState.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.HoverState.Image = CType(resources.GetObject("CancelBtn.HoverState.Image"), System.Drawing.Image)
        Me.CancelBtn.HoverState.Parent = Me.CancelBtn
        Me.CancelBtn.Location = New System.Drawing.Point(241, 264)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.ShadowDecoration.BorderRadius = 8
        Me.CancelBtn.ShadowDecoration.Enabled = True
        Me.CancelBtn.ShadowDecoration.Parent = Me.CancelBtn
        Me.CancelBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 4, 4)
        Me.CancelBtn.Size = New System.Drawing.Size(100, 26)
        Me.CancelBtn.TabIndex = 16
        Me.CancelBtn.Text = "Cancel"
        '
        'LoginBtn
        '
        Me.LoginBtn.Animated = True
        Me.LoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.LoginBtn.BorderColor = System.Drawing.Color.White
        Me.LoginBtn.BorderRadius = 8
        Me.LoginBtn.BorderThickness = 1
        Me.LoginBtn.CheckedState.Parent = Me.LoginBtn
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.CustomImages.Parent = Me.LoginBtn
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.HoverState.FillColor = System.Drawing.Color.Lime
        Me.LoginBtn.HoverState.ForeColor = System.Drawing.Color.Black
        Me.LoginBtn.HoverState.Image = CType(resources.GetObject("LoginBtn.HoverState.Image"), System.Drawing.Image)
        Me.LoginBtn.HoverState.Parent = Me.LoginBtn
        Me.LoginBtn.Location = New System.Drawing.Point(117, 264)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.ShadowDecoration.BorderRadius = 8
        Me.LoginBtn.ShadowDecoration.Enabled = True
        Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
        Me.LoginBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 4, 4)
        Me.LoginBtn.Size = New System.Drawing.Size(100, 26)
        Me.LoginBtn.TabIndex = 15
        Me.LoginBtn.Text = "Login"
        '
        'Password
        '
        Me.Password.Animated = True
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.BorderColor = System.Drawing.Color.Black
        Me.Password.BorderRadius = 10
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.Parent = Me.Password
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.Password.FocusedState.Parent = Me.Password
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Password.ForeColor = System.Drawing.Color.Black
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.HoverState.Parent = Me.Password
        Me.Password.Location = New System.Drawing.Point(130, 221)
        Me.Password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.PlaceholderText = ""
        Me.Password.SelectedText = ""
        Me.Password.ShadowDecoration.Parent = Me.Password
        Me.Password.Size = New System.Drawing.Size(200, 26)
        Me.Password.TabIndex = 2
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.Location = New System.Drawing.Point(182, 184)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(101, 28)
        Me.GunaLabel2.TabIndex = 11
        Me.GunaLabel2.Text = "Password"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.Location = New System.Drawing.Point(179, 112)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(106, 28)
        Me.GunaLabel1.TabIndex = 12
        Me.GunaLabel1.Text = "Username"
        '
        'UserType
        '
        Me.UserType.BorderColor = System.Drawing.Color.Black
        Me.UserType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserType.DefaultText = ""
        Me.UserType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserType.DisabledState.Parent = Me.UserType
        Me.UserType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserType.FocusedState.Parent = Me.UserType
        Me.UserType.Font = New System.Drawing.Font("Segoe UI", 5.0!)
        Me.UserType.ForeColor = System.Drawing.Color.Black
        Me.UserType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserType.HoverState.Parent = Me.UserType
        Me.UserType.Location = New System.Drawing.Point(315, 41)
        Me.UserType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserType.Name = "UserType"
        Me.UserType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserType.PlaceholderText = ""
        Me.UserType.SelectedText = ""
        Me.UserType.ShadowDecoration.Parent = Me.UserType
        Me.UserType.Size = New System.Drawing.Size(104, 11)
        Me.UserType.TabIndex = 19
        Me.UserType.Visible = False
        '
        'UserID
        '
        Me.UserID.Animated = True
        Me.UserID.BorderColor = System.Drawing.Color.Black
        Me.UserID.BorderRadius = 10
        Me.UserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserID.DefaultText = ""
        Me.UserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserID.DisabledState.Parent = Me.UserID
        Me.UserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserID.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.UserID.FocusedState.Parent = Me.UserID
        Me.UserID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.UserID.ForeColor = System.Drawing.Color.Black
        Me.UserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserID.HoverState.Parent = Me.UserID
        Me.UserID.Location = New System.Drawing.Point(130, 145)
        Me.UserID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UserID.Name = "UserID"
        Me.UserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserID.PlaceholderText = ""
        Me.UserID.SelectedText = ""
        Me.UserID.ShadowDecoration.Parent = Me.UserID
        Me.UserID.Size = New System.Drawing.Size(200, 26)
        Me.UserID.TabIndex = 1
        Me.UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserName
        '
        Me.UserName.BorderColor = System.Drawing.Color.Black
        Me.UserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserName.DefaultText = ""
        Me.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserName.DisabledState.Parent = Me.UserName
        Me.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserName.FocusedState.Parent = Me.UserName
        Me.UserName.Font = New System.Drawing.Font("Segoe UI", 5.0!)
        Me.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserName.HoverState.Parent = Me.UserName
        Me.UserName.Location = New System.Drawing.Point(315, 58)
        Me.UserName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserName.Name = "UserName"
        Me.UserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserName.PlaceholderText = ""
        Me.UserName.SelectedText = ""
        Me.UserName.ShadowDecoration.Parent = Me.UserName
        Me.UserName.Size = New System.Drawing.Size(104, 11)
        Me.UserName.TabIndex = 20
        Me.UserName.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.BorderRadius = 5
        Me.ProgressBar1.FillColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar1.Location = New System.Drawing.Point(31, 340)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ProgressBar1.ShadowDecoration.Parent = Me.ProgressBar1
        Me.ProgressBar1.Size = New System.Drawing.Size(400, 25)
        Me.ProgressBar1.TabIndex = 21
        Me.ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'PassHidePic
        '
        Me.PassHidePic.BackColor = System.Drawing.Color.Transparent
        Me.PassHidePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PassHidePic.Image = CType(resources.GetObject("PassHidePic.Image"), System.Drawing.Image)
        Me.PassHidePic.Location = New System.Drawing.Point(307, 224)
        Me.PassHidePic.Name = "PassHidePic"
        Me.PassHidePic.Size = New System.Drawing.Size(20, 20)
        Me.PassHidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassHidePic.TabIndex = 22
        Me.PassHidePic.TabStop = False
        Me.PassHidePic.Visible = False
        '
        'PassSeePic
        '
        Me.PassSeePic.BackColor = System.Drawing.Color.Transparent
        Me.PassSeePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PassSeePic.Image = CType(resources.GetObject("PassSeePic.Image"), System.Drawing.Image)
        Me.PassSeePic.Location = New System.Drawing.Point(307, 224)
        Me.PassSeePic.Name = "PassSeePic"
        Me.PassSeePic.Size = New System.Drawing.Size(20, 20)
        Me.PassSeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassSeePic.TabIndex = 23
        Me.PassSeePic.TabStop = False
        '
        'LogoPic1
        '
        Me.LogoPic1.Image = CType(resources.GetObject("LogoPic1.Image"), System.Drawing.Image)
        Me.LogoPic1.Location = New System.Drawing.Point(8, 4)
        Me.LogoPic1.Name = "LogoPic1"
        Me.LogoPic1.ShadowDecoration.BorderRadius = 2
        Me.LogoPic1.ShadowDecoration.Parent = Me.LogoPic1
        Me.LogoPic1.Size = New System.Drawing.Size(20, 20)
        Me.LogoPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPic1.TabIndex = 71
        Me.LogoPic1.TabStop = False
        '
        'LabelAbout
        '
        Me.LabelAbout.AutoSize = True
        Me.LabelAbout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelAbout.Location = New System.Drawing.Point(34, 4)
        Me.LabelAbout.Name = "LabelAbout"
        Me.LabelAbout.Size = New System.Drawing.Size(210, 19)
        Me.LabelAbout.TabIndex = 72
        Me.LabelAbout.Text = "Login - Drishti Compter Institute"
        '
        'TitelCusGraPanel
        '
        Me.TitelCusGraPanel.BackColor = System.Drawing.Color.Transparent
        Me.TitelCusGraPanel.Controls.Add(Me.LogoPic1)
        Me.TitelCusGraPanel.Controls.Add(Me.LabelAbout)
        Me.TitelCusGraPanel.Controls.Add(Me.PicBoxClose)
        Me.TitelCusGraPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitelCusGraPanel.Location = New System.Drawing.Point(0, 0)
        Me.TitelCusGraPanel.Name = "TitelCusGraPanel"
        Me.TitelCusGraPanel.ShadowDecoration.Parent = Me.TitelCusGraPanel
        Me.TitelCusGraPanel.Size = New System.Drawing.Size(465, 27)
        Me.TitelCusGraPanel.TabIndex = 73
        '
        'frmLogin
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(465, 398)
        Me.Controls.Add(Me.TitelCusGraPanel)
        Me.Controls.Add(Me.PassSeePic)
        Me.Controls.Add(Me.PassHidePic)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.UserID)
        Me.Controls.Add(Me.UserType)
        Me.Controls.Add(Me.ChangePassword)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PicBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassHidePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassSeePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitelCusGraPanel.ResumeLayout(False)
        Me.TitelCusGraPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicBoxClose As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ChangePassword As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents UserType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents PassHidePic As System.Windows.Forms.PictureBox
    Friend WithEvents PassSeePic As System.Windows.Forms.PictureBox
    Friend WithEvents TitelCusGraPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LogoPic1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LabelAbout As Guna.UI.WinForms.GunaLabel
End Class
