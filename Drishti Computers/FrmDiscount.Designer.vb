<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiscount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDiscount))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBalanceFees = New Guna.UI.WinForms.GunaLabel()
        Me.lblDisBal = New Guna.UI.WinForms.GunaLabel()
        Me.RefrashBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtStudentIDSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtDicount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSession = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudentName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GetDatabtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUserID)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblSession)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUserName)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label7)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblBalanceFees)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblDisBal)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.RefrashBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtStudentIDSearch)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.SaveBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.dgw)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.GetDatabtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2Panel1)
        Me.Guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Azure
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.PaleTurquoise
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel3
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(1043, 554)
        Me.Guna2CustomGradientPanel3.TabIndex = 69
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(38, 443)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(40, 13)
        Me.lblUserID.TabIndex = 94
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.Visible = False
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Location = New System.Drawing.Point(36, 469)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(44, 13)
        Me.lblSession.TabIndex = 95
        Me.lblSession.Text = "Session"
        Me.lblSession.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(29, 456)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(57, 13)
        Me.lblUserName.TabIndex = 96
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label7.Location = New System.Drawing.Point(307, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 22)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Student ID"
        '
        'lblBalanceFees
        '
        Me.lblBalanceFees.AutoSize = True
        Me.lblBalanceFees.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBalanceFees.Location = New System.Drawing.Point(92, 469)
        Me.lblBalanceFees.Name = "lblBalanceFees"
        Me.lblBalanceFees.Size = New System.Drawing.Size(48, 15)
        Me.lblBalanceFees.TabIndex = 98
        Me.lblBalanceFees.Text = "balance"
        Me.lblBalanceFees.Visible = False
        '
        'lblDisBal
        '
        Me.lblDisBal.AutoSize = True
        Me.lblDisBal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDisBal.Location = New System.Drawing.Point(84, 443)
        Me.lblDisBal.Name = "lblDisBal"
        Me.lblDisBal.Size = New System.Drawing.Size(39, 15)
        Me.lblDisBal.TabIndex = 99
        Me.lblDisBal.Text = "DisBal"
        Me.lblDisBal.Visible = False
        '
        'RefrashBtn
        '
        Me.RefrashBtn.Animated = True
        Me.RefrashBtn.BackColor = System.Drawing.Color.Transparent
        Me.RefrashBtn.BorderColor = System.Drawing.Color.White
        Me.RefrashBtn.BorderRadius = 5
        Me.RefrashBtn.BorderThickness = 1
        Me.RefrashBtn.CheckedState.Parent = Me.RefrashBtn
        Me.RefrashBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefrashBtn.CustomImages.Parent = Me.RefrashBtn
        Me.RefrashBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.RefrashBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.RefrashBtn.ForeColor = System.Drawing.Color.Black
        Me.RefrashBtn.HoverState.BorderColor = System.Drawing.Color.Black
        Me.RefrashBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.RefrashBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefrashBtn.HoverState.Image = CType(resources.GetObject("RefrashBtn.HoverState.Image"), System.Drawing.Image)
        Me.RefrashBtn.HoverState.Parent = Me.RefrashBtn
        Me.RefrashBtn.Location = New System.Drawing.Point(607, 21)
        Me.RefrashBtn.Name = "RefrashBtn"
        Me.RefrashBtn.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue
        Me.RefrashBtn.ShadowDecoration.Enabled = True
        Me.RefrashBtn.ShadowDecoration.Parent = Me.RefrashBtn
        Me.RefrashBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.RefrashBtn.Size = New System.Drawing.Size(120, 30)
        Me.RefrashBtn.TabIndex = 87
        Me.RefrashBtn.Text = "Refrash"
        '
        'txtStudentIDSearch
        '
        Me.txtStudentIDSearch.Animated = True
        Me.txtStudentIDSearch.BorderColor = System.Drawing.Color.Black
        Me.txtStudentIDSearch.BorderRadius = 5
        Me.txtStudentIDSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentIDSearch.DefaultText = ""
        Me.txtStudentIDSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentIDSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentIDSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentIDSearch.DisabledState.Parent = Me.txtStudentIDSearch
        Me.txtStudentIDSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentIDSearch.FillColor = System.Drawing.Color.LightCyan
        Me.txtStudentIDSearch.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtStudentIDSearch.FocusedState.Parent = Me.txtStudentIDSearch
        Me.txtStudentIDSearch.ForeColor = System.Drawing.Color.Black
        Me.txtStudentIDSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentIDSearch.HoverState.Parent = Me.txtStudentIDSearch
        Me.txtStudentIDSearch.Location = New System.Drawing.Point(413, 26)
        Me.txtStudentIDSearch.Name = "txtStudentIDSearch"
        Me.txtStudentIDSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentIDSearch.PlaceholderText = ""
        Me.txtStudentIDSearch.SelectedText = ""
        Me.txtStudentIDSearch.ShadowDecoration.Parent = Me.txtStudentIDSearch
        Me.txtStudentIDSearch.Size = New System.Drawing.Size(173, 21)
        Me.txtStudentIDSearch.TabIndex = 85
        '
        'SaveBtn
        '
        Me.SaveBtn.Animated = True
        Me.SaveBtn.BackColor = System.Drawing.Color.Transparent
        Me.SaveBtn.BorderColor = System.Drawing.Color.White
        Me.SaveBtn.BorderRadius = 5
        Me.SaveBtn.BorderThickness = 1
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.SaveBtn.FillColor = System.Drawing.Color.Lime
        Me.SaveBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.0!)
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.HoverState.BorderColor = System.Drawing.Color.Black
        Me.SaveBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SaveBtn.HoverState.Image = CType(resources.GetObject("SaveBtn.HoverState.Image"), System.Drawing.Image)
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(121, 314)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.SaveBtn.ShadowDecoration.Enabled = True
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.SaveBtn.Size = New System.Drawing.Size(90, 26)
        Me.SaveBtn.TabIndex = 90
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.TextOffset = New System.Drawing.Point(0, -1)
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.dgw.Location = New System.Drawing.Point(329, 69)
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
        Me.dgw.Size = New System.Drawing.Size(702, 470)
        Me.dgw.TabIndex = 89
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.dtpDate)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDicount)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSession)
        Me.Guna2GroupBox1.Controls.Add(Me.txtCourse)
        Me.Guna2GroupBox1.Controls.Add(Me.txtStudentName)
        Me.Guna2GroupBox1.Controls.Add(Me.txtStudentID)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.LightCyan
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(15, 69)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(300, 229)
        Me.Guna2GroupBox1.TabIndex = 88
        Me.Guna2GroupBox1.Text = "Discount"
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(0, -5)
        '
        'dtpDate
        '
        Me.dtpDate.Animated = True
        Me.dtpDate.BorderRadius = 5
        Me.dtpDate.BorderThickness = 1
        Me.dtpDate.CheckedState.Parent = Me.dtpDate
        Me.dtpDate.FillColor = System.Drawing.Color.LightCyan
        Me.dtpDate.FocusedColor = System.Drawing.Color.Lime
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.Black
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDate.HoverState.Parent = Me.dtpDate
        Me.dtpDate.Location = New System.Drawing.Point(96, 196)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShadowDecoration.Parent = Me.dtpDate
        Me.dtpDate.Size = New System.Drawing.Size(180, 21)
        Me.dtpDate.TabIndex = 6
        Me.dtpDate.Value = New Date(2022, 5, 7, 20, 33, 48, 327)
        '
        'txtDicount
        '
        Me.txtDicount.Animated = True
        Me.txtDicount.BorderColor = System.Drawing.Color.Black
        Me.txtDicount.BorderRadius = 5
        Me.txtDicount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDicount.DefaultText = ""
        Me.txtDicount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDicount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDicount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDicount.DisabledState.Parent = Me.txtDicount
        Me.txtDicount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDicount.FillColor = System.Drawing.Color.LightCyan
        Me.txtDicount.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtDicount.FocusedState.Parent = Me.txtDicount
        Me.txtDicount.ForeColor = System.Drawing.Color.Black
        Me.txtDicount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDicount.HoverState.Parent = Me.txtDicount
        Me.txtDicount.Location = New System.Drawing.Point(96, 164)
        Me.txtDicount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDicount.Name = "txtDicount"
        Me.txtDicount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDicount.PlaceholderText = ""
        Me.txtDicount.SelectedText = ""
        Me.txtDicount.ShadowDecoration.Parent = Me.txtDicount
        Me.txtDicount.Size = New System.Drawing.Size(180, 21)
        Me.txtDicount.TabIndex = 5
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
        Me.txtSession.Location = New System.Drawing.Point(96, 132)
        Me.txtSession.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSession.PlaceholderText = ""
        Me.txtSession.ReadOnly = True
        Me.txtSession.SelectedText = ""
        Me.txtSession.ShadowDecoration.Parent = Me.txtSession
        Me.txtSession.Size = New System.Drawing.Size(180, 21)
        Me.txtSession.TabIndex = 4
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
        Me.txtCourse.Location = New System.Drawing.Point(96, 100)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourse.PlaceholderText = ""
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.SelectedText = ""
        Me.txtCourse.ShadowDecoration.Parent = Me.txtCourse
        Me.txtCourse.Size = New System.Drawing.Size(180, 21)
        Me.txtCourse.TabIndex = 3
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
        Me.txtStudentName.Location = New System.Drawing.Point(96, 68)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentName.PlaceholderText = ""
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.SelectedText = ""
        Me.txtStudentName.ShadowDecoration.Parent = Me.txtStudentName
        Me.txtStudentName.Size = New System.Drawing.Size(180, 21)
        Me.txtStudentName.TabIndex = 2
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
        Me.txtStudentID.Location = New System.Drawing.Point(96, 36)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.PlaceholderText = ""
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.ShadowDecoration.Parent = Me.txtStudentID
        Me.txtStudentID.Size = New System.Drawing.Size(180, 21)
        Me.txtStudentID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Discount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Session"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student ID"
        '
        'GetDatabtn
        '
        Me.GetDatabtn.Animated = True
        Me.GetDatabtn.BackColor = System.Drawing.Color.Transparent
        Me.GetDatabtn.BorderColor = System.Drawing.Color.White
        Me.GetDatabtn.BorderRadius = 5
        Me.GetDatabtn.BorderThickness = 1
        Me.GetDatabtn.CheckedState.Parent = Me.GetDatabtn
        Me.GetDatabtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetDatabtn.CustomImages.Parent = Me.GetDatabtn
        Me.GetDatabtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.GetDatabtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.GetDatabtn.ForeColor = System.Drawing.Color.Black
        Me.GetDatabtn.HoverState.BorderColor = System.Drawing.Color.Black
        Me.GetDatabtn.HoverState.FillColor = System.Drawing.Color.White
        Me.GetDatabtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetDatabtn.HoverState.Image = CType(resources.GetObject("GetDatabtn.HoverState.Image"), System.Drawing.Image)
        Me.GetDatabtn.HoverState.Parent = Me.GetDatabtn
        Me.GetDatabtn.Location = New System.Drawing.Point(746, 21)
        Me.GetDatabtn.Name = "GetDatabtn"
        Me.GetDatabtn.ShadowDecoration.Color = System.Drawing.Color.DodgerBlue
        Me.GetDatabtn.ShadowDecoration.Enabled = True
        Me.GetDatabtn.ShadowDecoration.Parent = Me.GetDatabtn
        Me.GetDatabtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.GetDatabtn.Size = New System.Drawing.Size(120, 30)
        Me.GetDatabtn.TabIndex = 86
        Me.GetDatabtn.Text = "GetData"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Location = New System.Drawing.Point(329, 69)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(702, 470)
        Me.Guna2Panel1.TabIndex = 97
        '
        'FrmDiscount
        '
        Me.AcceptButton = Me.SaveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1043, 554)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDiscount"
        Me.Text = "Discount"
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblBalanceFees As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblDisBal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents RefrashBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtStudentIDSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtDicount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSession As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudentName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GetDatabtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
