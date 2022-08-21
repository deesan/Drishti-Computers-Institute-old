<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSession
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSession))
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TitelCusGraPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.LogoPic1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ClosePic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LabelAbout = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtSessionName = New System.Windows.Forms.TextBox()
        Me.txtSession = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnNew = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.UpdateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSessionID = New System.Windows.Forms.TextBox()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblUserType = New Guna.UI.WinForms.GunaLabel()
        Me.TitelCusGraPanel.SuspendLayout()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me
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
        Me.TitelCusGraPanel.Size = New System.Drawing.Size(384, 30)
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
        Me.ClosePic.Location = New System.Drawing.Point(351, 3)
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
        Me.LabelAbout.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelAbout.Location = New System.Drawing.Point(37, 4)
        Me.LabelAbout.Name = "LabelAbout"
        Me.LabelAbout.Size = New System.Drawing.Size(123, 21)
        Me.LabelAbout.TabIndex = 72
        Me.LabelAbout.Text = "Manage Session"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Location = New System.Drawing.Point(13, 42)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Teal
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(228, 222)
        Me.Guna2Panel1.TabIndex = 589
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
        Me.dgw.Location = New System.Drawing.Point(13, 42)
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
        Me.dgw.Size = New System.Drawing.Size(228, 222)
        Me.dgw.TabIndex = 585
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 591
        Me.Label2.Text = "Session :"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(268, 267)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(40, 13)
        Me.lblUserID.TabIndex = 592
        Me.lblUserID.Text = "UserID"
        Me.lblUserID.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(268, 277)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(57, 13)
        Me.lblUserName.TabIndex = 587
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.Visible = False
        '
        'txtSessionName
        '
        Me.txtSessionName.Location = New System.Drawing.Point(286, 36)
        Me.txtSessionName.Name = "txtSessionName"
        Me.txtSessionName.Size = New System.Drawing.Size(55, 20)
        Me.txtSessionName.TabIndex = 588
        Me.txtSessionName.Visible = False
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
        Me.txtSession.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSession.ForeColor = System.Drawing.Color.Black
        Me.txtSession.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSession.HoverState.Parent = Me.txtSession
        Me.txtSession.Location = New System.Drawing.Point(122, 282)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSession.PlaceholderText = "___  ____-__"
        Me.txtSession.SelectedText = ""
        Me.txtSession.ShadowDecoration.Parent = Me.txtSession
        Me.txtSession.Size = New System.Drawing.Size(103, 21)
        Me.txtSession.TabIndex = 581
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
        Me.btnNew.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.HoverState.FillColor = System.Drawing.Color.White
        Me.btnNew.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.HoverState.Image = CType(resources.GetObject("btnNew.HoverState.Image"), System.Drawing.Image)
        Me.btnNew.HoverState.Parent = Me.btnNew
        Me.btnNew.Location = New System.Drawing.Point(257, 63)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.btnNew.ShadowDecoration.Enabled = True
        Me.btnNew.ShadowDecoration.Parent = Me.btnNew
        Me.btnNew.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btnNew.Size = New System.Drawing.Size(110, 28)
        Me.btnNew.TabIndex = 582
        Me.btnNew.Text = "New"
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
        Me.SaveBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.SaveBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SaveBtn.HoverState.Image = CType(resources.GetObject("SaveBtn.HoverState.Image"), System.Drawing.Image)
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(257, 109)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Color = System.Drawing.Color.Lime
        Me.SaveBtn.ShadowDecoration.Enabled = True
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.SaveBtn.Size = New System.Drawing.Size(110, 28)
        Me.SaveBtn.TabIndex = 583
        Me.SaveBtn.Text = "Save"
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
        Me.UpdateBtn.FillColor = System.Drawing.Color.DarkOrange
        Me.UpdateBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.UpdateBtn.ForeColor = System.Drawing.Color.Black
        Me.UpdateBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.UpdateBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UpdateBtn.HoverState.Image = CType(resources.GetObject("UpdateBtn.HoverState.Image"), System.Drawing.Image)
        Me.UpdateBtn.HoverState.Parent = Me.UpdateBtn
        Me.UpdateBtn.Location = New System.Drawing.Point(257, 153)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.ShadowDecoration.Color = System.Drawing.Color.DarkOrange
        Me.UpdateBtn.ShadowDecoration.Enabled = True
        Me.UpdateBtn.ShadowDecoration.Parent = Me.UpdateBtn
        Me.UpdateBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.UpdateBtn.Size = New System.Drawing.Size(110, 28)
        Me.UpdateBtn.TabIndex = 584
        Me.UpdateBtn.Text = "Update"
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
        Me.DeleteBtn.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.DeleteBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteBtn.HoverState.Image = CType(resources.GetObject("DeleteBtn.HoverState.Image"), System.Drawing.Image)
        Me.DeleteBtn.HoverState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Location = New System.Drawing.Point(257, 198)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ShadowDecoration.Color = System.Drawing.Color.Red
        Me.DeleteBtn.ShadowDecoration.Enabled = True
        Me.DeleteBtn.ShadowDecoration.Parent = Me.DeleteBtn
        Me.DeleteBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.DeleteBtn.Size = New System.Drawing.Size(110, 28)
        Me.DeleteBtn.TabIndex = 586
        Me.DeleteBtn.Text = "Delete"
        '
        'txtSessionID
        '
        Me.txtSessionID.Location = New System.Drawing.Point(257, 244)
        Me.txtSessionID.Name = "txtSessionID"
        Me.txtSessionID.Size = New System.Drawing.Size(55, 20)
        Me.txtSessionID.TabIndex = 590
        Me.txtSessionID.Visible = False
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUserType)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtSessionID)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.DeleteBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.UpdateBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.SaveBtn)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.btnNew)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtSession)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtSessionName)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUserName)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblUserID)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.dgw)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2Panel1)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.TitelCusGraPanel)
        Me.Guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Azure
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.PaleTurquoise
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel3
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(384, 316)
        Me.Guna2CustomGradientPanel3.TabIndex = 69
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUserType.Location = New System.Drawing.Point(268, 292)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(52, 15)
        Me.lblUserType.TabIndex = 593
        Me.lblUserType.Text = "usertype"
        Me.lblUserType.Visible = False
        '
        'frmSession
        '
        Me.AcceptButton = Me.SaveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(384, 316)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Session"
        Me.TitelCusGraPanel.ResumeLayout(False)
        Me.TitelCusGraPanel.PerformLayout()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtSessionID As System.Windows.Forms.TextBox
    Friend WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UpdateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSession As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSessionName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TitelCusGraPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents LogoPic1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ClosePic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LabelAbout As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblUserType As Guna.UI.WinForms.GunaLabel
End Class
