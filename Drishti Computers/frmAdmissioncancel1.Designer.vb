<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmissioncancel1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmissioncancel1))
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblUserName = New Guna.UI.WinForms.GunaLabel()
        Me.lblUserID = New Guna.UI.WinForms.GunaLabel()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AdmissincancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtStudentName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSession = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtFeesRefound = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtReason = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TitelCusGraPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.LabelAbout = New Guna.UI.WinForms.GunaLabel()
        Me.ClosePic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LogoPic1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.UcAdmissionCancel11 = New Drishti_Computers.ucAdmissionCancel1()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.TitelCusGraPanel.SuspendLayout()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblUserName)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblUserID)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.CloseBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.AdmissincancelBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtStudentName)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtSession)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cmbStatus)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.dtpdate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtFeesRefound)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtReason)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtCourse)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtStudentID)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.TitelCusGraPanel)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.UcAdmissionCancel11)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.LightCoral
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Red
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.MintCream
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LightCoral
        Me.Guna2CustomGradientPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(350, 450)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUserName.Location = New System.Drawing.Point(9, 410)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(59, 15)
        Me.lblUserName.TabIndex = 65
        Me.lblUserName.Text = "username"
        Me.lblUserName.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUserID.Location = New System.Drawing.Point(247, 410)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(39, 15)
        Me.lblUserID.TabIndex = 65
        Me.lblUserID.Text = "userid"
        Me.lblUserID.Visible = False
        '
        'CloseBtn
        '
        Me.CloseBtn.Animated = True
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.BorderColor = System.Drawing.Color.White
        Me.CloseBtn.BorderRadius = 5
        Me.CloseBtn.BorderThickness = 1
        Me.CloseBtn.CheckedState.Parent = Me.CloseBtn
        Me.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseBtn.CustomImages.Parent = Me.CloseBtn
        Me.CloseBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.CloseBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.CloseBtn.ForeColor = System.Drawing.Color.Black
        Me.CloseBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.CloseBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.HoverState.Image = CType(resources.GetObject("CloseBtn.HoverState.Image"), System.Drawing.Image)
        Me.CloseBtn.HoverState.Parent = Me.CloseBtn
        Me.CloseBtn.Location = New System.Drawing.Point(124, 410)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CloseBtn.ShadowDecoration.Enabled = True
        Me.CloseBtn.ShadowDecoration.Parent = Me.CloseBtn
        Me.CloseBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.CloseBtn.Size = New System.Drawing.Size(96, 30)
        Me.CloseBtn.TabIndex = 63
        Me.CloseBtn.Text = "Close"
        '
        'AdmissincancelBtn
        '
        Me.AdmissincancelBtn.Animated = True
        Me.AdmissincancelBtn.BackColor = System.Drawing.Color.Transparent
        Me.AdmissincancelBtn.BorderColor = System.Drawing.Color.White
        Me.AdmissincancelBtn.BorderRadius = 5
        Me.AdmissincancelBtn.BorderThickness = 1
        Me.AdmissincancelBtn.CheckedState.Parent = Me.AdmissincancelBtn
        Me.AdmissincancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdmissincancelBtn.CustomImages.Parent = Me.AdmissincancelBtn
        Me.AdmissincancelBtn.FillColor = System.Drawing.Color.Red
        Me.AdmissincancelBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.AdmissincancelBtn.ForeColor = System.Drawing.Color.Black
        Me.AdmissincancelBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.AdmissincancelBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmissincancelBtn.HoverState.Image = CType(resources.GetObject("AdmissincancelBtn.HoverState.Image"), System.Drawing.Image)
        Me.AdmissincancelBtn.HoverState.Parent = Me.AdmissincancelBtn
        Me.AdmissincancelBtn.Location = New System.Drawing.Point(86, 372)
        Me.AdmissincancelBtn.Name = "AdmissincancelBtn"
        Me.AdmissincancelBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.AdmissincancelBtn.ShadowDecoration.Enabled = True
        Me.AdmissincancelBtn.ShadowDecoration.Parent = Me.AdmissincancelBtn
        Me.AdmissincancelBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.AdmissincancelBtn.Size = New System.Drawing.Size(170, 30)
        Me.AdmissincancelBtn.TabIndex = 64
        Me.AdmissincancelBtn.Text = "Admission Cancel"
        '
        'txtStudentName
        '
        Me.txtStudentName.Animated = True
        Me.txtStudentName.BackColor = System.Drawing.Color.Transparent
        Me.txtStudentName.BorderColor = System.Drawing.Color.Black
        Me.txtStudentName.BorderRadius = 5
        Me.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentName.DefaultText = ""
        Me.txtStudentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentName.DisabledState.Parent = Me.txtStudentName
        Me.txtStudentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentName.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtStudentName.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtStudentName.FocusedState.Parent = Me.txtStudentName
        Me.txtStudentName.ForeColor = System.Drawing.Color.Black
        Me.txtStudentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentName.HoverState.Parent = Me.txtStudentName
        Me.txtStudentName.Location = New System.Drawing.Point(130, 114)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentName.PlaceholderText = ""
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.SelectedText = ""
        Me.txtStudentName.ShadowDecoration.Parent = Me.txtStudentName
        Me.txtStudentName.Size = New System.Drawing.Size(186, 21)
        Me.txtStudentName.TabIndex = 10
        '
        'txtSession
        '
        Me.txtSession.Animated = True
        Me.txtSession.BackColor = System.Drawing.Color.Transparent
        Me.txtSession.BorderColor = System.Drawing.Color.Black
        Me.txtSession.BorderRadius = 5
        Me.txtSession.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSession.DefaultText = ""
        Me.txtSession.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSession.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSession.DisabledState.Parent = Me.txtSession
        Me.txtSession.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSession.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtSession.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtSession.FocusedState.Parent = Me.txtSession
        Me.txtSession.ForeColor = System.Drawing.Color.Black
        Me.txtSession.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSession.HoverState.Parent = Me.txtSession
        Me.txtSession.Location = New System.Drawing.Point(130, 171)
        Me.txtSession.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSession.PlaceholderText = ""
        Me.txtSession.ReadOnly = True
        Me.txtSession.SelectedText = ""
        Me.txtSession.ShadowDecoration.Parent = Me.txtSession
        Me.txtSession.Size = New System.Drawing.Size(186, 21)
        Me.txtSession.TabIndex = 12
        '
        'cmbStatus
        '
        Me.cmbStatus.Animated = True
        Me.cmbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatus.BorderColor = System.Drawing.Color.Black
        Me.cmbStatus.BorderRadius = 5
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cmbStatus.FocusedColor = System.Drawing.Color.Lime
        Me.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.cmbStatus.FocusedState.Parent = Me.cmbStatus
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbStatus.ForeColor = System.Drawing.Color.Black
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.HoverState.Parent = Me.cmbStatus
        Me.cmbStatus.IntegralHeight = False
        Me.cmbStatus.ItemHeight = 15
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Deactive"})
        Me.cmbStatus.ItemsAppearance.Parent = Me.cmbStatus
        Me.cmbStatus.Location = New System.Drawing.Point(130, 324)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShadowDecoration.Parent = Me.cmbStatus
        Me.cmbStatus.Size = New System.Drawing.Size(186, 21)
        Me.cmbStatus.TabIndex = 16
        '
        'dtpdate
        '
        Me.dtpdate.Animated = True
        Me.dtpdate.BackColor = System.Drawing.Color.Transparent
        Me.dtpdate.BorderRadius = 5
        Me.dtpdate.BorderThickness = 1
        Me.dtpdate.CheckedState.Parent = Me.dtpdate
        Me.dtpdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.dtpdate.FocusedColor = System.Drawing.Color.Lime
        Me.dtpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpdate.ForeColor = System.Drawing.Color.Black
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpdate.HoverState.Parent = Me.dtpdate
        Me.dtpdate.Location = New System.Drawing.Point(130, 295)
        Me.dtpdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.ShadowDecoration.Parent = Me.dtpdate
        Me.dtpdate.Size = New System.Drawing.Size(186, 21)
        Me.dtpdate.TabIndex = 15
        Me.dtpdate.Value = New Date(2022, 3, 30, 21, 11, 28, 0)
        '
        'txtFeesRefound
        '
        Me.txtFeesRefound.Animated = True
        Me.txtFeesRefound.BackColor = System.Drawing.Color.Transparent
        Me.txtFeesRefound.BorderColor = System.Drawing.Color.Black
        Me.txtFeesRefound.BorderRadius = 5
        Me.txtFeesRefound.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFeesRefound.DefaultText = ""
        Me.txtFeesRefound.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFeesRefound.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFeesRefound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFeesRefound.DisabledState.Parent = Me.txtFeesRefound
        Me.txtFeesRefound.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFeesRefound.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtFeesRefound.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtFeesRefound.FocusedState.Parent = Me.txtFeesRefound
        Me.txtFeesRefound.ForeColor = System.Drawing.Color.Black
        Me.txtFeesRefound.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFeesRefound.HoverState.Parent = Me.txtFeesRefound
        Me.txtFeesRefound.Location = New System.Drawing.Point(130, 200)
        Me.txtFeesRefound.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFeesRefound.Name = "txtFeesRefound"
        Me.txtFeesRefound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFeesRefound.PlaceholderText = ""
        Me.txtFeesRefound.SelectedText = ""
        Me.txtFeesRefound.ShadowDecoration.Parent = Me.txtFeesRefound
        Me.txtFeesRefound.Size = New System.Drawing.Size(186, 21)
        Me.txtFeesRefound.TabIndex = 13
        '
        'txtReason
        '
        Me.txtReason.Animated = True
        Me.txtReason.BackColor = System.Drawing.Color.Transparent
        Me.txtReason.BorderColor = System.Drawing.Color.Black
        Me.txtReason.BorderRadius = 5
        Me.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReason.DefaultText = ""
        Me.txtReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReason.DisabledState.Parent = Me.txtReason
        Me.txtReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReason.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtReason.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtReason.FocusedState.Parent = Me.txtReason
        Me.txtReason.ForeColor = System.Drawing.Color.Black
        Me.txtReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReason.HoverState.Parent = Me.txtReason
        Me.txtReason.Location = New System.Drawing.Point(130, 229)
        Me.txtReason.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReason.PlaceholderText = ""
        Me.txtReason.SelectedText = ""
        Me.txtReason.ShadowDecoration.Parent = Me.txtReason
        Me.txtReason.Size = New System.Drawing.Size(186, 55)
        Me.txtReason.TabIndex = 14
        '
        'txtCourse
        '
        Me.txtCourse.Animated = True
        Me.txtCourse.BackColor = System.Drawing.Color.Transparent
        Me.txtCourse.BorderColor = System.Drawing.Color.Black
        Me.txtCourse.BorderRadius = 5
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.DefaultText = ""
        Me.txtCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourse.DisabledState.Parent = Me.txtCourse
        Me.txtCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtCourse.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtCourse.FocusedState.Parent = Me.txtCourse
        Me.txtCourse.ForeColor = System.Drawing.Color.Black
        Me.txtCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourse.HoverState.Parent = Me.txtCourse
        Me.txtCourse.Location = New System.Drawing.Point(130, 143)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourse.PlaceholderText = ""
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.SelectedText = ""
        Me.txtCourse.ShadowDecoration.Parent = Me.txtCourse
        Me.txtCourse.Size = New System.Drawing.Size(186, 21)
        Me.txtCourse.TabIndex = 11
        '
        'txtStudentID
        '
        Me.txtStudentID.Animated = True
        Me.txtStudentID.BackColor = System.Drawing.Color.Transparent
        Me.txtStudentID.BorderColor = System.Drawing.Color.Black
        Me.txtStudentID.BorderRadius = 5
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.DefaultText = ""
        Me.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.DisabledState.Parent = Me.txtStudentID
        Me.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtStudentID.FocusedState.Parent = Me.txtStudentID
        Me.txtStudentID.ForeColor = System.Drawing.Color.Black
        Me.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.HoverState.Parent = Me.txtStudentID
        Me.txtStudentID.Location = New System.Drawing.Point(130, 86)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.PlaceholderText = ""
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.ShadowDecoration.Parent = Me.txtStudentID
        Me.txtStudentID.Size = New System.Drawing.Size(186, 21)
        Me.txtStudentID.TabIndex = 9
        '
        'TitelCusGraPanel
        '
        Me.TitelCusGraPanel.BackColor = System.Drawing.Color.Transparent
        Me.TitelCusGraPanel.BorderRadius = 5
        Me.TitelCusGraPanel.Controls.Add(Me.LabelAbout)
        Me.TitelCusGraPanel.Controls.Add(Me.ClosePic)
        Me.TitelCusGraPanel.Controls.Add(Me.LogoPic1)
        Me.TitelCusGraPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitelCusGraPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.TitelCusGraPanel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.TitelCusGraPanel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TitelCusGraPanel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.TitelCusGraPanel.Location = New System.Drawing.Point(0, 0)
        Me.TitelCusGraPanel.Name = "TitelCusGraPanel"
        Me.TitelCusGraPanel.ShadowDecoration.Enabled = True
        Me.TitelCusGraPanel.ShadowDecoration.Parent = Me.TitelCusGraPanel
        Me.TitelCusGraPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.TitelCusGraPanel.Size = New System.Drawing.Size(350, 30)
        Me.TitelCusGraPanel.TabIndex = 1
        '
        'LabelAbout
        '
        Me.LabelAbout.AutoSize = True
        Me.LabelAbout.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.LabelAbout.ForeColor = System.Drawing.Color.White
        Me.LabelAbout.Location = New System.Drawing.Point(34, 1)
        Me.LabelAbout.Name = "LabelAbout"
        Me.LabelAbout.Size = New System.Drawing.Size(161, 25)
        Me.LabelAbout.TabIndex = 74
        Me.LabelAbout.Text = "Admission Cancel"
        '
        'ClosePic
        '
        Me.ClosePic.AutoRoundedCorners = True
        Me.ClosePic.BackColor = System.Drawing.Color.Transparent
        Me.ClosePic.BorderRadius = 11
        Me.ClosePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClosePic.Image = CType(resources.GetObject("ClosePic.Image"), System.Drawing.Image)
        Me.ClosePic.Location = New System.Drawing.Point(319, 3)
        Me.ClosePic.Name = "ClosePic"
        Me.ClosePic.ShadowDecoration.BorderRadius = 16
        Me.ClosePic.ShadowDecoration.Color = System.Drawing.Color.Red
        Me.ClosePic.ShadowDecoration.Enabled = True
        Me.ClosePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ClosePic.ShadowDecoration.Parent = Me.ClosePic
        Me.ClosePic.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.ClosePic.Size = New System.Drawing.Size(24, 24)
        Me.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClosePic.TabIndex = 73
        Me.ClosePic.TabStop = False
        '
        'LogoPic1
        '
        Me.LogoPic1.Image = CType(resources.GetObject("LogoPic1.Image"), System.Drawing.Image)
        Me.LogoPic1.Location = New System.Drawing.Point(12, 5)
        Me.LogoPic1.Name = "LogoPic1"
        Me.LogoPic1.ShadowDecoration.BorderRadius = 2
        Me.LogoPic1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LogoPic1.ShadowDecoration.Enabled = True
        Me.LogoPic1.ShadowDecoration.Parent = Me.LogoPic1
        Me.LogoPic1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.LogoPic1.Size = New System.Drawing.Size(20, 20)
        Me.LogoPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPic1.TabIndex = 72
        Me.LogoPic1.TabStop = False
        '
        'UcAdmissionCancel11
        '
        Me.UcAdmissionCancel11.Location = New System.Drawing.Point(0, 0)
        Me.UcAdmissionCancel11.Name = "UcAdmissionCancel11"
        Me.UcAdmissionCancel11.Size = New System.Drawing.Size(350, 450)
        Me.UcAdmissionCancel11.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'frmAdmissioncancel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 450)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdmissioncancel1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission Cancel"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.TitelCusGraPanel.ResumeLayout(False)
        Me.TitelCusGraPanel.PerformLayout()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TitelCusGraPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents UcAdmissionCancel11 As Drishti_Computers.ucAdmissionCancel1
    Friend WithEvents LogoPic1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ClosePic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LabelAbout As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtStudentName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSession As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtFeesRefound As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtReason As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AdmissincancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblUserName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblUserID As Guna.UI.WinForms.GunaLabel
End Class
