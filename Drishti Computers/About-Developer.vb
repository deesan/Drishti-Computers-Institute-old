Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D


Public Class About_Developer

    Dim gp As GraphicsPath
    Dim wh As Integer = 20


    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    '------------------------- code to  Move Form -------------------

    Private Sub TitelCusGraPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitelCusGraPanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub TitelCusGraPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles TitelCusGraPanel.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub TitelCusGraPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitelCusGraPanel.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    '------------------ close section -------------------------------

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Close()
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Me.Close()
    End Sub

    '------------------- Panel Change button Section ------------------

    ' About Panel

    Private Sub DAboutBtn_Click(sender As Object, e As EventArgs) Handles DAboutBtn.Click
        DContactPanel.Visible = False
        DExperiencePanel.Visible = False
        DAboutPanel.Visible = True
    End Sub

    Private Sub MeAboutBtn_Click(sender As Object, e As EventArgs) Handles MeAboutBtn.Click
        MeContactPanel.Visible = False
        MeExperiencePanel.Visible = False
        MeAboutPanel.Visible = True
    End Sub

    ' Experince Panel

    Private Sub DExperinceBtn_Click(sender As Object, e As EventArgs) Handles DExperinceBtn.Click
        DAboutPanel.Visible = False
        DContactPanel.Visible = False
        DExperiencePanel.Visible = True
    End Sub

    Private Sub MeExperienceBtn_Click(sender As Object, e As EventArgs) Handles MeExperienceBtn.Click
        MeAboutPanel.Visible = False
        MeContactPanel.Visible = False
        MeExperiencePanel.Visible = True
    End Sub

    ' Contact Panel

    Private Sub DContantBtn_Click(sender As Object, e As EventArgs) Handles DContantBtn.Click
        DAboutPanel.Visible = False
        DExperiencePanel.Visible = False
        DContactPanel.Visible = True
    End Sub

    Private Sub MeContactBtn_Click(sender As Object, e As EventArgs) Handles MeContactBtn.Click
        MeAboutPanel.Visible = False
        MeExperiencePanel.Visible = False
        MeContactPanel.Visible = True
    End Sub

    '------------------ Profile logo button hover then tooltip section ----------------------

    Private Sub Guna2CircleButton1_MouseHover(sender As Object, e As EventArgs) Handles Guna2CircleButton1.MouseHover
        ToolTip1.Show("Durgesh Dhuri", Guna2CircleButton1)
    End Sub

    Private Sub Guna2CircleButton2_MouseHover(sender As Object, e As EventArgs) Handles Guna2CircleButton2.MouseHover
        ToolTip1.Show("durgesh__dhuri", Guna2CircleButton2)
    End Sub

    Private Sub Guna2CircleButton3_MouseHover(sender As Object, e As EventArgs) Handles Guna2CircleButton3.MouseHover
        ToolTip1.Show("+91 8085804214", Guna2CircleButton3)
    End Sub

    Private Sub Guna2CircleButton6_MouseHover(sender As Object, e As EventArgs) Handles Guna2CircleButton6.MouseHover
        ToolTip1.Show("deesan", Guna2CircleButton6)
    End Sub

    Private Sub Guna2CircleButton5_MouseHover(sender As Object, e As EventArgs) Handles Guna2CircleButton5.MouseHover
        ToolTip1.Show("_d.e.e.p.a.k__99", Guna2CircleButton5)
    End Sub

    Private Sub Guna2CircleButton4_MouseHover(sender As Object, e As EventArgs) Handles Guna2CircleButton4.MouseHover
        ToolTip1.Show("+91 9098893789", Guna2CircleButton4)
    End Sub

End Class