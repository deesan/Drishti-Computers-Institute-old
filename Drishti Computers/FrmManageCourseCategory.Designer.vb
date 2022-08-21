<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageCourseCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManageCourseCategory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TitelCusGraPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.LogoPic1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ClosePic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LabelAbout = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txtCategory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.UpdateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNew = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCouCategChange = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TitelCusGraPanel.SuspendLayout()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TitelCusGraPanel.Size = New System.Drawing.Size(333, 30)
        Me.TitelCusGraPanel.TabIndex = 2
        '
        'LogoPic1
        '
        Me.LogoPic1.Image = CType(resources.GetObject("LogoPic1.Image"), System.Drawing.Image)
        Me.LogoPic1.Location = New System.Drawing.Point(10, 5)
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
        Me.ClosePic.Location = New System.Drawing.Point(299, 3)
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
        Me.LabelAbout.Location = New System.Drawing.Point(32, 6)
        Me.LabelAbout.Name = "LabelAbout"
        Me.LabelAbout.Size = New System.Drawing.Size(166, 19)
        Me.LabelAbout.TabIndex = 72
        Me.LabelAbout.Text = "Manage Course Category"
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtCategory)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.DeleteBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.UpdateBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.SaveBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.btnNew)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtCouCategChange)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUserID)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUserName)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.dgw)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2Panel1)
        Me.Guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Azure
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.PaleTurquoise
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel3
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(333, 275)
        Me.Guna2CustomGradientPanel3.TabIndex = 69
        '
        'txtCategory
        '
        Me.txtCategory.Animated = True
        Me.txtCategory.BorderColor = System.Drawing.Color.Black
        Me.txtCategory.BorderRadius = 5
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.DefaultText = ""
        Me.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.DisabledState.Parent = Me.txtCategory
        Me.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.FillColor = System.Drawing.Color.LightCyan
        Me.txtCategory.FocusedState.BorderColor = System.Drawing.Color.Lime
        Me.txtCategory.FocusedState.Parent = Me.txtCategory
        Me.txtCategory.ForeColor = System.Drawing.Color.Black
        Me.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.HoverState.Parent = Me.txtCategory
        Me.txtCategory.Location = New System.Drawing.Point(73, 235)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategory.PlaceholderText = ""
        Me.txtCategory.SelectedText = ""
        Me.txtCategory.ShadowDecoration.Parent = Me.txtCategory
        Me.txtCategory.Size = New System.Drawing.Size(120, 21)
        Me.txtCategory.TabIndex = 83
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Animated = True
        Me.DeleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.DeleteBtn.BorderColor = System.Drawing.Color.White
        Me.DeleteBtn.BorderRadius = 5
        Me.DeleteBtn.BorderThickness = 1
        Me.DeleteBtn.CheckedState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBtn.CustomImages.Parent = Me.DeleteBtn
        Me.DeleteBtn.FillColor = System.Drawing.Color.Red
        Me.DeleteBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.0!)
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.DeleteBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteBtn.HoverState.Image = CType(resources.GetObject("DeleteBtn.HoverState.Image"), System.Drawing.Image)
        Me.DeleteBtn.HoverState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Location = New System.Drawing.Point(216, 181)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ShadowDecoration.Color = System.Drawing.Color.Red
        Me.DeleteBtn.ShadowDecoration.Enabled = True
        Me.DeleteBtn.ShadowDecoration.Parent = Me.DeleteBtn
        Me.DeleteBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.DeleteBtn.Size = New System.Drawing.Size(104, 27)
        Me.DeleteBtn.TabIndex = 88
        Me.DeleteBtn.Text = "Delete"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Animated = True
        Me.UpdateBtn.BackColor = System.Drawing.Color.Transparent
        Me.UpdateBtn.BorderColor = System.Drawing.Color.White
        Me.UpdateBtn.BorderRadius = 5
        Me.UpdateBtn.BorderThickness = 1
        Me.UpdateBtn.CheckedState.Parent = Me.UpdateBtn
        Me.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateBtn.CustomImages.Parent = Me.UpdateBtn
        Me.UpdateBtn.FillColor = System.Drawing.Color.Orange
        Me.UpdateBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.0!)
        Me.UpdateBtn.ForeColor = System.Drawing.Color.Black
        Me.UpdateBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.UpdateBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UpdateBtn.HoverState.Image = CType(resources.GetObject("UpdateBtn.HoverState.Image"), System.Drawing.Image)
        Me.UpdateBtn.HoverState.Parent = Me.UpdateBtn
        Me.UpdateBtn.Location = New System.Drawing.Point(216, 140)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.ShadowDecoration.Color = System.Drawing.Color.Orange
        Me.UpdateBtn.ShadowDecoration.Enabled = True
        Me.UpdateBtn.ShadowDecoration.Parent = Me.UpdateBtn
        Me.UpdateBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.UpdateBtn.Size = New System.Drawing.Size(104, 27)
        Me.UpdateBtn.TabIndex = 86
        Me.UpdateBtn.Text = "Update"
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
        Me.SaveBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SaveBtn.HoverState.Image = CType(resources.GetObject("SaveBtn.HoverState.Image"), System.Drawing.Image)
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(216, 99)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.SaveBtn.ShadowDecoration.Enabled = True
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.SaveBtn.Size = New System.Drawing.Size(104, 27)
        Me.SaveBtn.TabIndex = 85
        Me.SaveBtn.Text = "Save"
        '
        'btnNew
        '
        Me.btnNew.Animated = True
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BorderColor = System.Drawing.Color.White
        Me.btnNew.BorderRadius = 5
        Me.btnNew.BorderThickness = 1
        Me.btnNew.CheckedState.Parent = Me.btnNew
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.CustomImages.Parent = Me.btnNew
        Me.btnNew.FillColor = System.Drawing.Color.Lime
        Me.btnNew.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.0!)
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.HoverState.FillColor = System.Drawing.Color.White
        Me.btnNew.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.HoverState.Image = CType(resources.GetObject("btnNew.HoverState.Image"), System.Drawing.Image)
        Me.btnNew.HoverState.Parent = Me.btnNew
        Me.btnNew.Location = New System.Drawing.Point(216, 59)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.btnNew.ShadowDecoration.Enabled = True
        Me.btnNew.ShadowDecoration.Parent = Me.btnNew
        Me.btnNew.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnNew.Size = New System.Drawing.Size(104, 27)
        Me.btnNew.TabIndex = 84
        Me.btnNew.Text = "New"
        '
        'txtCouCategChange
        '
        Me.txtCouCategChange.Location = New System.Drawing.Point(259, 243)
        Me.txtCouCategChange.Name = "txtCouCategChange"
        Me.txtCouCategChange.Size = New System.Drawing.Size(55, 20)
        Me.txtCouCategChange.TabIndex = 91
        Me.txtCouCategChange.Visible = False
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Location = New System.Drawing.Point(213, 240)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(40, 13)
        Me.lblUserID.TabIndex = 89
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Category"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Location = New System.Drawing.Point(213, 250)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(57, 13)
        Me.lblUserName.TabIndex = 90
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.Visible = False
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
        Me.dgw.Location = New System.Drawing.Point(20, 43)
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
        Me.dgw.Size = New System.Drawing.Size(183, 178)
        Me.dgw.TabIndex = 87
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Location = New System.Drawing.Point(20, 43)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(183, 178)
        Me.Guna2Panel1.TabIndex = 92
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmManageCourseCategory
        '
        Me.AcceptButton = Me.SaveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(333, 275)
        Me.Controls.Add(Me.TitelCusGraPanel)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmManageCourseCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manage Course Category"
        Me.TitelCusGraPanel.ResumeLayout(False)
        Me.TitelCusGraPanel.PerformLayout()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitelCusGraPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents LogoPic1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ClosePic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LabelAbout As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UpdateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCouCategChange As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
