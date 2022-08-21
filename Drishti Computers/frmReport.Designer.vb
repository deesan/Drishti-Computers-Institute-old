<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TitelCusGraPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.LogoPic1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ClosePic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LabelAbout = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        Me.TitelCusGraPanel.SuspendLayout()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.TitelCusGraPanel)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2Panel1)
        Me.Guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Azure
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.LightCyan
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.PaleTurquoise
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel3
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(950, 650)
        Me.Guna2CustomGradientPanel3.TabIndex = 69
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
        Me.TitelCusGraPanel.Size = New System.Drawing.Size(950, 30)
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
        Me.ClosePic.BorderRadius = 13
        Me.ClosePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClosePic.Image = CType(resources.GetObject("ClosePic.Image"), System.Drawing.Image)
        Me.ClosePic.Location = New System.Drawing.Point(914, 0)
        Me.ClosePic.Name = "ClosePic"
        Me.ClosePic.ShadowDecoration.BorderRadius = 16
        Me.ClosePic.ShadowDecoration.Color = System.Drawing.Color.Red
        Me.ClosePic.ShadowDecoration.Enabled = True
        Me.ClosePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ClosePic.ShadowDecoration.Parent = Me.ClosePic
        Me.ClosePic.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.ClosePic.Size = New System.Drawing.Size(28, 28)
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
        Me.LabelAbout.Size = New System.Drawing.Size(43, 21)
        Me.LabelAbout.TabIndex = 72
        Me.LabelAbout.Text = "Print"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(10, 40)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(930, 600)
        Me.Guna2Panel1.TabIndex = 71
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(930, 600)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print"
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.TitelCusGraPanel.ResumeLayout(False)
        Me.TitelCusGraPanel.PerformLayout()
        CType(Me.LogoPic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TitelCusGraPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents LogoPic1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ClosePic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LabelAbout As Guna.UI.WinForms.GunaLabel

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
