<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResultReceiveRecord
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResultReceiveRecord))
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.ResetBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SearchBtn1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Search2Btn = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbCenterCodeSearch = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbReceive = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtStuNameIDCourseSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSessionSearch1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.dgw)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblSession)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.ResetBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2Panel7)
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
        Me.dgw.Location = New System.Drawing.Point(15, 117)
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
        Me.dgw.Size = New System.Drawing.Size(1015, 425)
        Me.dgw.TabIndex = 89
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.BackColor = System.Drawing.Color.Transparent
        Me.lblSession.Location = New System.Drawing.Point(947, 12)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(44, 13)
        Me.lblSession.TabIndex = 88
        Me.lblSession.Text = "Session"
        Me.lblSession.Visible = False
        '
        'ResetBtn
        '
        Me.ResetBtn.Animated = True
        Me.ResetBtn.BackColor = System.Drawing.Color.Transparent
        Me.ResetBtn.BorderColor = System.Drawing.Color.White
        Me.ResetBtn.BorderRadius = 5
        Me.ResetBtn.BorderThickness = 1
        Me.ResetBtn.CheckedState.Parent = Me.ResetBtn
        Me.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetBtn.CustomImages.Parent = Me.ResetBtn
        Me.ResetBtn.FillColor = System.Drawing.Color.DarkOrange
        Me.ResetBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.ResetBtn.ForeColor = System.Drawing.Color.Black
        Me.ResetBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.ResetBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ResetBtn.HoverState.Image = CType(resources.GetObject("ResetBtn.HoverState.Image"), System.Drawing.Image)
        Me.ResetBtn.HoverState.Parent = Me.ResetBtn
        Me.ResetBtn.Location = New System.Drawing.Point(913, 47)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.ShadowDecoration.Color = System.Drawing.Color.DarkOrange
        Me.ResetBtn.ShadowDecoration.Enabled = True
        Me.ResetBtn.ShadowDecoration.Parent = Me.ResetBtn
        Me.ResetBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.ResetBtn.Size = New System.Drawing.Size(120, 30)
        Me.ResetBtn.TabIndex = 87
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbStatus)
        Me.Guna2GroupBox1.Controls.Add(Me.SearchBtn1)
        Me.Guna2GroupBox1.Controls.Add(Me.Search2Btn)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbCenterCodeSearch)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbReceive)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Panel6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtStuNameIDCourseSearch)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbSessionSearch1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.LightCyan
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(888, 96)
        Me.Guna2GroupBox1.TabIndex = 91
        Me.Guna2GroupBox1.Text = "Search"
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(0, -7)
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Lime
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Location = New System.Drawing.Point(779, 25)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Guna2Panel2.Size = New System.Drawing.Size(3, 70)
        Me.Guna2Panel2.TabIndex = 8
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel1.Location = New System.Drawing.Point(102, 25)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(24, 15)
        Me.GunaLabel1.TabIndex = 83
        Me.GunaLabel1.Text = "OR"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel3.Location = New System.Drawing.Point(35, 44)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(24, 15)
        Me.GunaLabel3.TabIndex = 85
        Me.GunaLabel3.Text = "OR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Student Name"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(121, 23)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(23, 19)
        Me.GunaLabel2.TabIndex = 84
        Me.GunaLabel2.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(58, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 19)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Course"
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
        Me.cmbStatus.Items.AddRange(New Object() {"Pass", "Fail", "Back"})
        Me.cmbStatus.ItemsAppearance.Parent = Me.cmbStatus
        Me.cmbStatus.Location = New System.Drawing.Point(793, 65)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShadowDecoration.Parent = Me.cmbStatus
        Me.cmbStatus.Size = New System.Drawing.Size(82, 21)
        Me.cmbStatus.TabIndex = 80
        '
        'SearchBtn1
        '
        Me.SearchBtn1.Animated = True
        Me.SearchBtn1.BackColor = System.Drawing.Color.Transparent
        Me.SearchBtn1.BorderColor = System.Drawing.Color.White
        Me.SearchBtn1.BorderRadius = 5
        Me.SearchBtn1.BorderThickness = 1
        Me.SearchBtn1.CheckedState.Parent = Me.SearchBtn1
        Me.SearchBtn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBtn1.CustomImages.Parent = Me.SearchBtn1
        Me.SearchBtn1.FillColor = System.Drawing.Color.Lime
        Me.SearchBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.SearchBtn1.ForeColor = System.Drawing.Color.Black
        Me.SearchBtn1.HoverState.FillColor = System.Drawing.Color.White
        Me.SearchBtn1.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn1.HoverState.Image = CType(resources.GetObject("SearchBtn1.HoverState.Image"), System.Drawing.Image)
        Me.SearchBtn1.HoverState.Parent = Me.SearchBtn1
        Me.SearchBtn1.Location = New System.Drawing.Point(350, 44)
        Me.SearchBtn1.Name = "SearchBtn1"
        Me.SearchBtn1.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.SearchBtn1.ShadowDecoration.Enabled = True
        Me.SearchBtn1.ShadowDecoration.Parent = Me.SearchBtn1
        Me.SearchBtn1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.SearchBtn1.Size = New System.Drawing.Size(80, 26)
        Me.SearchBtn1.TabIndex = 44
        Me.SearchBtn1.Text = "Search"
        Me.SearchBtn1.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Search2Btn
        '
        Me.Search2Btn.Animated = True
        Me.Search2Btn.BackColor = System.Drawing.Color.Transparent
        Me.Search2Btn.BorderColor = System.Drawing.Color.White
        Me.Search2Btn.BorderRadius = 5
        Me.Search2Btn.BorderThickness = 1
        Me.Search2Btn.CheckedState.Parent = Me.Search2Btn
        Me.Search2Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Search2Btn.CustomImages.Parent = Me.Search2Btn
        Me.Search2Btn.FillColor = System.Drawing.Color.Lime
        Me.Search2Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Search2Btn.ForeColor = System.Drawing.Color.Black
        Me.Search2Btn.HoverState.FillColor = System.Drawing.Color.White
        Me.Search2Btn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search2Btn.HoverState.Image = CType(resources.GetObject("Search2Btn.HoverState.Image"), System.Drawing.Image)
        Me.Search2Btn.HoverState.Parent = Me.Search2Btn
        Me.Search2Btn.Location = New System.Drawing.Point(580, 44)
        Me.Search2Btn.Name = "Search2Btn"
        Me.Search2Btn.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.Search2Btn.ShadowDecoration.Enabled = True
        Me.Search2Btn.ShadowDecoration.Parent = Me.Search2Btn
        Me.Search2Btn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Search2Btn.Size = New System.Drawing.Size(80, 26)
        Me.Search2Btn.TabIndex = 44
        Me.Search2Btn.Text = "Search"
        Me.Search2Btn.TextOffset = New System.Drawing.Point(0, -1)
        '
        'cmbCenterCodeSearch
        '
        Me.cmbCenterCodeSearch.Animated = True
        Me.cmbCenterCodeSearch.BackColor = System.Drawing.Color.Transparent
        Me.cmbCenterCodeSearch.BorderColor = System.Drawing.Color.Black
        Me.cmbCenterCodeSearch.BorderRadius = 5
        Me.cmbCenterCodeSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCenterCodeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCenterCodeSearch.FillColor = System.Drawing.Color.LightCyan
        Me.cmbCenterCodeSearch.FocusedColor = System.Drawing.Color.Lime
        Me.cmbCenterCodeSearch.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.cmbCenterCodeSearch.FocusedState.Parent = Me.cmbCenterCodeSearch
        Me.cmbCenterCodeSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbCenterCodeSearch.ForeColor = System.Drawing.Color.Black
        Me.cmbCenterCodeSearch.FormattingEnabled = True
        Me.cmbCenterCodeSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCenterCodeSearch.HoverState.Parent = Me.cmbCenterCodeSearch
        Me.cmbCenterCodeSearch.IntegralHeight = False
        Me.cmbCenterCodeSearch.ItemHeight = 15
        Me.cmbCenterCodeSearch.ItemsAppearance.Parent = Me.cmbCenterCodeSearch
        Me.cmbCenterCodeSearch.Location = New System.Drawing.Point(454, 65)
        Me.cmbCenterCodeSearch.Name = "cmbCenterCodeSearch"
        Me.cmbCenterCodeSearch.ShadowDecoration.Parent = Me.cmbCenterCodeSearch
        Me.cmbCenterCodeSearch.Size = New System.Drawing.Size(115, 21)
        Me.cmbCenterCodeSearch.TabIndex = 42
        '
        'cmbReceive
        '
        Me.cmbReceive.Animated = True
        Me.cmbReceive.BackColor = System.Drawing.Color.Transparent
        Me.cmbReceive.BorderColor = System.Drawing.Color.Black
        Me.cmbReceive.BorderRadius = 5
        Me.cmbReceive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReceive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReceive.FillColor = System.Drawing.Color.LightCyan
        Me.cmbReceive.FocusedColor = System.Drawing.Color.Lime
        Me.cmbReceive.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.cmbReceive.FocusedState.Parent = Me.cmbReceive
        Me.cmbReceive.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbReceive.ForeColor = System.Drawing.Color.Black
        Me.cmbReceive.FormattingEnabled = True
        Me.cmbReceive.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbReceive.HoverState.Parent = Me.cmbReceive
        Me.cmbReceive.IntegralHeight = False
        Me.cmbReceive.ItemHeight = 15
        Me.cmbReceive.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbReceive.ItemsAppearance.Parent = Me.cmbReceive
        Me.cmbReceive.Location = New System.Drawing.Point(684, 65)
        Me.cmbReceive.Name = "cmbReceive"
        Me.cmbReceive.ShadowDecoration.Parent = Me.cmbReceive
        Me.cmbReceive.Size = New System.Drawing.Size(82, 21)
        Me.cmbReceive.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(808, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(468, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Center Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(696, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Receive"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel6.BorderColor = System.Drawing.Color.Lime
        Me.Guna2Panel6.BorderThickness = 1
        Me.Guna2Panel6.Location = New System.Drawing.Point(158, 25)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Enabled = True
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Guna2Panel6.Size = New System.Drawing.Size(3, 70)
        Me.Guna2Panel6.TabIndex = 8
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.Lime
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Location = New System.Drawing.Point(441, 25)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Enabled = True
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Guna2Panel5.Size = New System.Drawing.Size(3, 70)
        Me.Guna2Panel5.TabIndex = 8
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Teal
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Lime
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Location = New System.Drawing.Point(669, 25)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Guna2Panel1.Size = New System.Drawing.Size(3, 70)
        Me.Guna2Panel1.TabIndex = 7
        '
        'txtStuNameIDCourseSearch
        '
        Me.txtStuNameIDCourseSearch.Animated = True
        Me.txtStuNameIDCourseSearch.BorderColor = System.Drawing.Color.Black
        Me.txtStuNameIDCourseSearch.BorderRadius = 5
        Me.txtStuNameIDCourseSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStuNameIDCourseSearch.DefaultText = ""
        Me.txtStuNameIDCourseSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStuNameIDCourseSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStuNameIDCourseSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStuNameIDCourseSearch.DisabledState.Parent = Me.txtStuNameIDCourseSearch
        Me.txtStuNameIDCourseSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStuNameIDCourseSearch.FillColor = System.Drawing.Color.LightCyan
        Me.txtStuNameIDCourseSearch.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtStuNameIDCourseSearch.FocusedState.Parent = Me.txtStuNameIDCourseSearch
        Me.txtStuNameIDCourseSearch.ForeColor = System.Drawing.Color.Black
        Me.txtStuNameIDCourseSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStuNameIDCourseSearch.HoverState.Parent = Me.txtStuNameIDCourseSearch
        Me.txtStuNameIDCourseSearch.Location = New System.Drawing.Point(12, 65)
        Me.txtStuNameIDCourseSearch.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.txtStuNameIDCourseSearch.Name = "txtStuNameIDCourseSearch"
        Me.txtStuNameIDCourseSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStuNameIDCourseSearch.PlaceholderText = ""
        Me.txtStuNameIDCourseSearch.SelectedText = ""
        Me.txtStuNameIDCourseSearch.ShadowDecoration.Parent = Me.txtStuNameIDCourseSearch
        Me.txtStuNameIDCourseSearch.Size = New System.Drawing.Size(132, 21)
        Me.txtStuNameIDCourseSearch.TabIndex = 1
        '
        'cmbSessionSearch1
        '
        Me.cmbSessionSearch1.BackColor = System.Drawing.Color.Transparent
        Me.cmbSessionSearch1.BorderColor = System.Drawing.Color.Black
        Me.cmbSessionSearch1.BorderRadius = 5
        Me.cmbSessionSearch1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSessionSearch1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSessionSearch1.FillColor = System.Drawing.Color.LightCyan
        Me.cmbSessionSearch1.FocusedColor = System.Drawing.Color.Lime
        Me.cmbSessionSearch1.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.cmbSessionSearch1.FocusedState.Parent = Me.cmbSessionSearch1
        Me.cmbSessionSearch1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbSessionSearch1.ForeColor = System.Drawing.Color.Black
        Me.cmbSessionSearch1.FormattingEnabled = True
        Me.cmbSessionSearch1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSessionSearch1.HoverState.Parent = Me.cmbSessionSearch1
        Me.cmbSessionSearch1.IntegralHeight = False
        Me.cmbSessionSearch1.ItemHeight = 15
        Me.cmbSessionSearch1.ItemsAppearance.Parent = Me.cmbSessionSearch1
        Me.cmbSessionSearch1.Location = New System.Drawing.Point(171, 65)
        Me.cmbSessionSearch1.Name = "cmbSessionSearch1"
        Me.cmbSessionSearch1.ShadowDecoration.Parent = Me.cmbSessionSearch1
        Me.cmbSessionSearch1.Size = New System.Drawing.Size(170, 21)
        Me.cmbSessionSearch1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(231, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Session"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Location = New System.Drawing.Point(15, 117)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2Panel7.ShadowDecoration.Enabled = True
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel7.Size = New System.Drawing.Size(1015, 425)
        Me.Guna2Panel7.TabIndex = 90
        '
        'FrmResultReceiveRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1043, 554)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmResultReceiveRecord"
        Me.Text = "Result Receive Record"
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents ResetBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SearchBtn1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Search2Btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbCenterCodeSearch As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbReceive As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtStuNameIDCourseSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbSessionSearch1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
End Class
