<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.DeleteAlllogsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbName = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbUserID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GetDataBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUsername)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUserID)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.DeleteAlllogsBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.btnReset)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.dgw)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2Panel3)
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
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(960, 513)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(57, 13)
        Me.lblUsername.TabIndex = 81
        Me.lblUsername.Text = "UserName"
        Me.lblUsername.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(968, 501)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(40, 13)
        Me.lblUserID.TabIndex = 80
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.Visible = False
        '
        'DeleteAlllogsBtn
        '
        Me.DeleteAlllogsBtn.Animated = True
        Me.DeleteAlllogsBtn.BackColor = System.Drawing.Color.Transparent
        Me.DeleteAlllogsBtn.BorderColor = System.Drawing.Color.White
        Me.DeleteAlllogsBtn.BorderRadius = 5
        Me.DeleteAlllogsBtn.BorderThickness = 1
        Me.DeleteAlllogsBtn.CheckedState.Parent = Me.DeleteAlllogsBtn
        Me.DeleteAlllogsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteAlllogsBtn.CustomImages.Parent = Me.DeleteAlllogsBtn
        Me.DeleteAlllogsBtn.FillColor = System.Drawing.Color.Red
        Me.DeleteAlllogsBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!)
        Me.DeleteAlllogsBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteAlllogsBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.DeleteAlllogsBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteAlllogsBtn.HoverState.Image = CType(resources.GetObject("DeleteAlllogsBtn.HoverState.Image"), System.Drawing.Image)
        Me.DeleteAlllogsBtn.HoverState.Parent = Me.DeleteAlllogsBtn
        Me.DeleteAlllogsBtn.Location = New System.Drawing.Point(914, 238)
        Me.DeleteAlllogsBtn.Name = "DeleteAlllogsBtn"
        Me.DeleteAlllogsBtn.ShadowDecoration.Color = System.Drawing.Color.Red
        Me.DeleteAlllogsBtn.ShadowDecoration.Enabled = True
        Me.DeleteAlllogsBtn.ShadowDecoration.Parent = Me.DeleteAlllogsBtn
        Me.DeleteAlllogsBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.DeleteAlllogsBtn.Size = New System.Drawing.Size(120, 30)
        Me.DeleteAlllogsBtn.TabIndex = 77
        Me.DeleteAlllogsBtn.Text = "Delete all logs"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbName)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbUserID)
        Me.Guna2GroupBox1.Controls.Add(Me.GetDataBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.LightCyan
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(36, 13)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(828, 76)
        Me.Guna2GroupBox1.TabIndex = 79
        Me.Guna2GroupBox1.Text = "Search"
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(0, -7)
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Lime
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Location = New System.Drawing.Point(621, 25)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Guna2Panel2.Size = New System.Drawing.Size(3, 53)
        Me.Guna2Panel2.TabIndex = 8
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Lime
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Location = New System.Drawing.Point(418, 25)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Guna2Panel1.Size = New System.Drawing.Size(3, 53)
        Me.Guna2Panel1.TabIndex = 8
        '
        'cmbName
        '
        Me.cmbName.Animated = True
        Me.cmbName.BackColor = System.Drawing.Color.Transparent
        Me.cmbName.BorderColor = System.Drawing.Color.Black
        Me.cmbName.BorderRadius = 5
        Me.cmbName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.FillColor = System.Drawing.Color.LightCyan
        Me.cmbName.FocusedColor = System.Drawing.Color.Lime
        Me.cmbName.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.cmbName.FocusedState.Parent = Me.cmbName
        Me.cmbName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbName.ForeColor = System.Drawing.Color.Black
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbName.HoverState.Parent = Me.cmbName
        Me.cmbName.IntegralHeight = False
        Me.cmbName.ItemHeight = 17
        Me.cmbName.ItemsAppearance.Parent = Me.cmbName
        Me.cmbName.Location = New System.Drawing.Point(638, 47)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.ShadowDecoration.Parent = Me.cmbName
        Me.cmbName.Size = New System.Drawing.Size(171, 23)
        Me.cmbName.TabIndex = 7
        '
        'cmbUserID
        '
        Me.cmbUserID.Animated = True
        Me.cmbUserID.BackColor = System.Drawing.Color.Transparent
        Me.cmbUserID.BorderColor = System.Drawing.Color.Black
        Me.cmbUserID.BorderRadius = 5
        Me.cmbUserID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserID.FillColor = System.Drawing.Color.LightCyan
        Me.cmbUserID.FocusedColor = System.Drawing.Color.Lime
        Me.cmbUserID.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.cmbUserID.FocusedState.Parent = Me.cmbUserID
        Me.cmbUserID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbUserID.ForeColor = System.Drawing.Color.Black
        Me.cmbUserID.FormattingEnabled = True
        Me.cmbUserID.HoverState.BorderColor = System.Drawing.Color.White
        Me.cmbUserID.HoverState.Parent = Me.cmbUserID
        Me.cmbUserID.IntegralHeight = False
        Me.cmbUserID.ItemHeight = 17
        Me.cmbUserID.ItemsAppearance.Parent = Me.cmbUserID
        Me.cmbUserID.Location = New System.Drawing.Point(436, 47)
        Me.cmbUserID.Name = "cmbUserID"
        Me.cmbUserID.ShadowDecoration.Parent = Me.cmbUserID
        Me.cmbUserID.Size = New System.Drawing.Size(171, 23)
        Me.cmbUserID.TabIndex = 6
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
        Me.GetDataBtn.FillColor = System.Drawing.Color.Lime
        Me.GetDataBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.0!)
        Me.GetDataBtn.ForeColor = System.Drawing.Color.Black
        Me.GetDataBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.GetDataBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GetDataBtn.HoverState.Image = CType(resources.GetObject("GetDataBtn.HoverState.Image"), System.Drawing.Image)
        Me.GetDataBtn.HoverState.Parent = Me.GetDataBtn
        Me.GetDataBtn.Location = New System.Drawing.Point(303, 42)
        Me.GetDataBtn.Name = "GetDataBtn"
        Me.GetDataBtn.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.GetDataBtn.ShadowDecoration.Enabled = True
        Me.GetDataBtn.ShadowDecoration.Parent = Me.GetDataBtn
        Me.GetDataBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.GetDataBtn.Size = New System.Drawing.Size(100, 26)
        Me.GetDataBtn.TabIndex = 2
        Me.GetDataBtn.Text = "Get Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(689, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(499, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "User ID"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Animated = True
        Me.dtpDateTo.BorderRadius = 5
        Me.dtpDateTo.BorderThickness = 1
        Me.dtpDateTo.CheckedState.Parent = Me.dtpDateTo
        Me.dtpDateTo.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateTo.FillColor = System.Drawing.Color.LightCyan
        Me.dtpDateTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDateTo.ForeColor = System.Drawing.Color.Black
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.HoverState.Parent = Me.dtpDateTo
        Me.dtpDateTo.Location = New System.Drawing.Point(152, 47)
        Me.dtpDateTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.ShadowDecoration.Parent = Me.dtpDateTo
        Me.dtpDateTo.Size = New System.Drawing.Size(130, 21)
        Me.dtpDateTo.TabIndex = 3
        Me.dtpDateTo.Value = New Date(2022, 3, 22, 21, 40, 49, 500)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(43, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Animated = True
        Me.dtpDateFrom.BorderRadius = 5
        Me.dtpDateFrom.BorderThickness = 1
        Me.dtpDateFrom.CheckedState.Parent = Me.dtpDateFrom
        Me.dtpDateFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDateFrom.FillColor = System.Drawing.Color.LightCyan
        Me.dtpDateFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDateFrom.ForeColor = System.Drawing.Color.Black
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.HoverState.Parent = Me.dtpDateFrom
        Me.dtpDateFrom.Location = New System.Drawing.Point(7, 47)
        Me.dtpDateFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.ShadowDecoration.Parent = Me.dtpDateFrom
        Me.dtpDateFrom.Size = New System.Drawing.Size(130, 21)
        Me.dtpDateFrom.TabIndex = 3
        Me.dtpDateFrom.Value = New Date(2022, 3, 22, 21, 40, 49, 500)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(200, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "To "
        '
        'btnReset
        '
        Me.btnReset.Animated = True
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.BorderColor = System.Drawing.Color.White
        Me.btnReset.BorderRadius = 5
        Me.btnReset.BorderThickness = 1
        Me.btnReset.CheckedState.Parent = Me.btnReset
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.CustomImages.Parent = Me.btnReset
        Me.btnReset.FillColor = System.Drawing.Color.DarkOrange
        Me.btnReset.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.HoverState.FillColor = System.Drawing.Color.White
        Me.btnReset.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReset.HoverState.Image = CType(resources.GetObject("btnReset.HoverState.Image"), System.Drawing.Image)
        Me.btnReset.HoverState.Parent = Me.btnReset
        Me.btnReset.Location = New System.Drawing.Point(887, 39)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.ShadowDecoration.Color = System.Drawing.Color.DarkOrange
        Me.btnReset.ShadowDecoration.Enabled = True
        Me.btnReset.ShadowDecoration.Parent = Me.btnReset
        Me.btnReset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnReset.Size = New System.Drawing.Size(130, 30)
        Me.btnReset.TabIndex = 76
        Me.btnReset.Text = "Reset"
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
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(9, 101)
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
        Me.dgw.Size = New System.Drawing.Size(895, 440)
        Me.dgw.TabIndex = 78
        '
        'Column1
        '
        Me.Column1.HeaderText = "User ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Date & Time"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Operation"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Location = New System.Drawing.Point(9, 101)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel3.Size = New System.Drawing.Size(895, 440)
        Me.Guna2Panel3.TabIndex = 82
        '
        'frmLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1043, 554)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogs"
        Me.Text = "Logs"
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents DeleteAlllogsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbName As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbUserID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GetDataBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
