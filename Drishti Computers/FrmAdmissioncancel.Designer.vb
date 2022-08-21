<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmissioncancel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmissioncancel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.GetDataBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lbluserID = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtStudentName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSession = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtFeesRefound = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtReason = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AdmissincancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtStudentNameSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblUserName)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GetDataBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lbluserID)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.dgw)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.AdmissincancelBtn)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Azure
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.PaleTurquoise
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1043, 554)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Location = New System.Drawing.Point(16, 504)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(57, 13)
        Me.lblUserName.TabIndex = 65
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.Visible = False
        '
        'GetDataBtn
        '
        Me.GetDataBtn.Animated = True
        Me.GetDataBtn.BackColor = System.Drawing.Color.Transparent
        Me.GetDataBtn.BorderColor = System.Drawing.Color.White
        Me.GetDataBtn.BorderRadius = 5
        Me.GetDataBtn.BorderThickness = 1
        Me.GetDataBtn.CheckedState.Parent = Me.GetDataBtn
        Me.GetDataBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetDataBtn.CustomImages.Parent = Me.GetDataBtn
        Me.GetDataBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.GetDataBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.GetDataBtn.ForeColor = System.Drawing.Color.Black
        Me.GetDataBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.GetDataBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetDataBtn.HoverState.Image = CType(resources.GetObject("GetDataBtn.HoverState.Image"), System.Drawing.Image)
        Me.GetDataBtn.HoverState.Parent = Me.GetDataBtn
        Me.GetDataBtn.Location = New System.Drawing.Point(796, 43)
        Me.GetDataBtn.Name = "GetDataBtn"
        Me.GetDataBtn.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue
        Me.GetDataBtn.ShadowDecoration.Enabled = True
        Me.GetDataBtn.ShadowDecoration.Parent = Me.GetDataBtn
        Me.GetDataBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.GetDataBtn.Size = New System.Drawing.Size(130, 30)
        Me.GetDataBtn.TabIndex = 59
        Me.GetDataBtn.Text = "Get Data"
        '
        'lbluserID
        '
        Me.lbluserID.AutoSize = True
        Me.lbluserID.BackColor = System.Drawing.Color.Transparent
        Me.lbluserID.Location = New System.Drawing.Point(24, 491)
        Me.lbluserID.Name = "lbluserID"
        Me.lbluserID.Size = New System.Drawing.Size(40, 13)
        Me.lbluserID.TabIndex = 66
        Me.lbluserID.Text = "UserID"
        Me.lbluserID.Visible = False
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.BackgroundColor = System.Drawing.Color.LightCyan
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(348, 110)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(681, 431)
        Me.dgw.TabIndex = 60
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.txtStudentName)
        Me.Guna2GroupBox2.Controls.Add(Me.txtSession)
        Me.Guna2GroupBox2.Controls.Add(Me.cmbStatus)
        Me.Guna2GroupBox2.Controls.Add(Me.dtpdate)
        Me.Guna2GroupBox2.Controls.Add(Me.txtFeesRefound)
        Me.Guna2GroupBox2.Controls.Add(Me.txtReason)
        Me.Guna2GroupBox2.Controls.Add(Me.txtCourse)
        Me.Guna2GroupBox2.Controls.Add(Me.txtStudentID)
        Me.Guna2GroupBox2.Controls.Add(Me.Label11)
        Me.Guna2GroupBox2.Controls.Add(Me.Label10)
        Me.Guna2GroupBox2.Controls.Add(Me.Label9)
        Me.Guna2GroupBox2.Controls.Add(Me.Label12)
        Me.Guna2GroupBox2.Controls.Add(Me.Label8)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.Controls.Add(Me.Label13)
        Me.Guna2GroupBox2.Controls.Add(Me.Label6)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.LightCyan
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(14, 109)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2GroupBox2.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(318, 316)
        Me.Guna2GroupBox2.TabIndex = 64
        Me.Guna2GroupBox2.Text = "Info"
        Me.Guna2GroupBox2.TextOffset = New System.Drawing.Point(0, -5)
        '
        'txtStudentName
        '
        Me.txtStudentName.Animated = True
        Me.txtStudentName.BorderColor = System.Drawing.Color.Black
        Me.txtStudentName.BorderRadius = 5
        Me.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentName.DefaultText = ""
        Me.txtStudentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentName.DisabledState.Parent = Me.txtStudentName
        Me.txtStudentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentName.FillColor = System.Drawing.Color.LightCyan
        Me.txtStudentName.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtStudentName.FocusedState.Parent = Me.txtStudentName
        Me.txtStudentName.ForeColor = System.Drawing.Color.Black
        Me.txtStudentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentName.HoverState.Parent = Me.txtStudentName
        Me.txtStudentName.Location = New System.Drawing.Point(121, 69)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentName.PlaceholderText = ""
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.SelectedText = ""
        Me.txtStudentName.ShadowDecoration.Parent = Me.txtStudentName
        Me.txtStudentName.Size = New System.Drawing.Size(176, 21)
        Me.txtStudentName.TabIndex = 2
        '
        'txtSession
        '
        Me.txtSession.Animated = True
        Me.txtSession.BorderColor = System.Drawing.Color.Black
        Me.txtSession.BorderRadius = 5
        Me.txtSession.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSession.DefaultText = ""
        Me.txtSession.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSession.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSession.DisabledState.Parent = Me.txtSession
        Me.txtSession.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSession.FillColor = System.Drawing.Color.LightCyan
        Me.txtSession.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtSession.FocusedState.Parent = Me.txtSession
        Me.txtSession.ForeColor = System.Drawing.Color.Black
        Me.txtSession.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSession.HoverState.Parent = Me.txtSession
        Me.txtSession.Location = New System.Drawing.Point(121, 126)
        Me.txtSession.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSession.PlaceholderText = ""
        Me.txtSession.ReadOnly = True
        Me.txtSession.SelectedText = ""
        Me.txtSession.ShadowDecoration.Parent = Me.txtSession
        Me.txtSession.Size = New System.Drawing.Size(176, 21)
        Me.txtSession.TabIndex = 4
        '
        'cmbStatus
        '
        Me.cmbStatus.Animated = True
        Me.cmbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatus.BorderColor = System.Drawing.Color.Black
        Me.cmbStatus.BorderRadius = 5
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FillColor = System.Drawing.Color.LightCyan
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
        Me.cmbStatus.Location = New System.Drawing.Point(121, 278)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShadowDecoration.Parent = Me.cmbStatus
        Me.cmbStatus.Size = New System.Drawing.Size(176, 21)
        Me.cmbStatus.TabIndex = 8
        '
        'dtpdate
        '
        Me.dtpdate.Animated = True
        Me.dtpdate.BorderRadius = 5
        Me.dtpdate.BorderThickness = 1
        Me.dtpdate.CheckedState.Parent = Me.dtpdate
        Me.dtpdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpdate.FillColor = System.Drawing.Color.LightCyan
        Me.dtpdate.FocusedColor = System.Drawing.Color.Lime
        Me.dtpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpdate.ForeColor = System.Drawing.Color.Black
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpdate.HoverState.Parent = Me.dtpdate
        Me.dtpdate.Location = New System.Drawing.Point(121, 249)
        Me.dtpdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.ShadowDecoration.Parent = Me.dtpdate
        Me.dtpdate.Size = New System.Drawing.Size(176, 21)
        Me.dtpdate.TabIndex = 7
        Me.dtpdate.Value = New Date(2022, 3, 30, 21, 11, 28, 0)
        '
        'txtFeesRefound
        '
        Me.txtFeesRefound.Animated = True
        Me.txtFeesRefound.BorderColor = System.Drawing.Color.Black
        Me.txtFeesRefound.BorderRadius = 5
        Me.txtFeesRefound.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFeesRefound.DefaultText = ""
        Me.txtFeesRefound.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFeesRefound.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFeesRefound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFeesRefound.DisabledState.Parent = Me.txtFeesRefound
        Me.txtFeesRefound.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFeesRefound.FillColor = System.Drawing.Color.LightCyan
        Me.txtFeesRefound.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtFeesRefound.FocusedState.Parent = Me.txtFeesRefound
        Me.txtFeesRefound.ForeColor = System.Drawing.Color.Black
        Me.txtFeesRefound.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFeesRefound.HoverState.Parent = Me.txtFeesRefound
        Me.txtFeesRefound.Location = New System.Drawing.Point(121, 154)
        Me.txtFeesRefound.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFeesRefound.Name = "txtFeesRefound"
        Me.txtFeesRefound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFeesRefound.PlaceholderText = ""
        Me.txtFeesRefound.SelectedText = ""
        Me.txtFeesRefound.ShadowDecoration.Parent = Me.txtFeesRefound
        Me.txtFeesRefound.Size = New System.Drawing.Size(176, 21)
        Me.txtFeesRefound.TabIndex = 5
        '
        'txtReason
        '
        Me.txtReason.Animated = True
        Me.txtReason.BorderColor = System.Drawing.Color.Black
        Me.txtReason.BorderRadius = 5
        Me.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReason.DefaultText = ""
        Me.txtReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReason.DisabledState.Parent = Me.txtReason
        Me.txtReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReason.FillColor = System.Drawing.Color.LightCyan
        Me.txtReason.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtReason.FocusedState.Parent = Me.txtReason
        Me.txtReason.ForeColor = System.Drawing.Color.Black
        Me.txtReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReason.HoverState.Parent = Me.txtReason
        Me.txtReason.Location = New System.Drawing.Point(121, 183)
        Me.txtReason.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReason.PlaceholderText = ""
        Me.txtReason.SelectedText = ""
        Me.txtReason.ShadowDecoration.Parent = Me.txtReason
        Me.txtReason.Size = New System.Drawing.Size(176, 55)
        Me.txtReason.TabIndex = 6
        '
        'txtCourse
        '
        Me.txtCourse.Animated = True
        Me.txtCourse.BorderColor = System.Drawing.Color.Black
        Me.txtCourse.BorderRadius = 5
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.DefaultText = ""
        Me.txtCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourse.DisabledState.Parent = Me.txtCourse
        Me.txtCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourse.FillColor = System.Drawing.Color.LightCyan
        Me.txtCourse.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtCourse.FocusedState.Parent = Me.txtCourse
        Me.txtCourse.ForeColor = System.Drawing.Color.Black
        Me.txtCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourse.HoverState.Parent = Me.txtCourse
        Me.txtCourse.Location = New System.Drawing.Point(121, 98)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourse.PlaceholderText = ""
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.SelectedText = ""
        Me.txtCourse.ShadowDecoration.Parent = Me.txtCourse
        Me.txtCourse.Size = New System.Drawing.Size(176, 21)
        Me.txtCourse.TabIndex = 3
        '
        'txtStudentID
        '
        Me.txtStudentID.Animated = True
        Me.txtStudentID.BorderColor = System.Drawing.Color.Black
        Me.txtStudentID.BorderRadius = 5
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.DefaultText = ""
        Me.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.DisabledState.Parent = Me.txtStudentID
        Me.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.FillColor = System.Drawing.Color.LightCyan
        Me.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtStudentID.FocusedState.Parent = Me.txtStudentID
        Me.txtStudentID.ForeColor = System.Drawing.Color.Black
        Me.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.HoverState.Parent = Me.txtStudentID
        Me.txtStudentID.Location = New System.Drawing.Point(121, 41)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.PlaceholderText = ""
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.ShadowDecoration.Parent = Me.txtStudentID
        Me.txtStudentID.Size = New System.Drawing.Size(176, 21)
        Me.txtStudentID.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(18, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(18, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(18, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fees Refound"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(18, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Session"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(18, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Reason"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(18, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Course"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(18, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Student Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(18, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Student ID"
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
        Me.AdmissincancelBtn.Location = New System.Drawing.Point(85, 443)
        Me.AdmissincancelBtn.Name = "AdmissincancelBtn"
        Me.AdmissincancelBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.AdmissincancelBtn.ShadowDecoration.Enabled = True
        Me.AdmissincancelBtn.ShadowDecoration.Parent = Me.AdmissincancelBtn
        Me.AdmissincancelBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.AdmissincancelBtn.Size = New System.Drawing.Size(170, 30)
        Me.AdmissincancelBtn.TabIndex = 62
        Me.AdmissincancelBtn.Text = "Admission Cancel"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.txtStudentNameSearch)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.LightCyan
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(143, 14)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(613, 81)
        Me.Guna2GroupBox1.TabIndex = 63
        Me.Guna2GroupBox1.Text = "Search"
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(0, -5)
        '
        'txtStudentNameSearch
        '
        Me.txtStudentNameSearch.Animated = True
        Me.txtStudentNameSearch.BorderColor = System.Drawing.Color.Black
        Me.txtStudentNameSearch.BorderRadius = 5
        Me.txtStudentNameSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentNameSearch.DefaultText = ""
        Me.txtStudentNameSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentNameSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentNameSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentNameSearch.DisabledState.Parent = Me.txtStudentNameSearch
        Me.txtStudentNameSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentNameSearch.FillColor = System.Drawing.Color.LightCyan
        Me.txtStudentNameSearch.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtStudentNameSearch.FocusedState.Parent = Me.txtStudentNameSearch
        Me.txtStudentNameSearch.ForeColor = System.Drawing.Color.Black
        Me.txtStudentNameSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentNameSearch.HoverState.Parent = Me.txtStudentNameSearch
        Me.txtStudentNameSearch.Location = New System.Drawing.Point(189, 51)
        Me.txtStudentNameSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentNameSearch.Name = "txtStudentNameSearch"
        Me.txtStudentNameSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentNameSearch.PlaceholderText = ""
        Me.txtStudentNameSearch.SelectedText = ""
        Me.txtStudentNameSearch.ShadowDecoration.Parent = Me.txtStudentNameSearch
        Me.txtStudentNameSearch.Size = New System.Drawing.Size(200, 21)
        Me.txtStudentNameSearch.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(242, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student Name"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(348, 110)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(681, 431)
        Me.Guna2Panel1.TabIndex = 68
        '
        'FrmAdmissioncancel
        '
        Me.AcceptButton = Me.AdmissincancelBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1043, 554)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmissioncancel"
        Me.Text = "Admission Cancel"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents GetDataBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbluserID As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtStudentName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSession As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtFeesRefound As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtReason As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AdmissincancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtStudentNameSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
