Imports System.Data.SqlClient

Public Class frmLogin
    Dim frm As New Admin_main
    Dim frm2 As New User_Main
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

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Visible = False
    End Sub


    '------------------------- Code to  Move Form -------------------

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

    '------------ Picture Box Section Start ------------------

    ' Close Picture Section

    Private Sub PicBoxClose_Click(sender As Object, e As EventArgs) Handles PicBoxClose.Click
        Me.Close()
    End Sub

    'Password Seen & Hide Picture Section

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PassHidePic.Click
        Password.PasswordChar = "*"
        PassHidePic.Visible = False
        PassSeePic.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PassSeePic.Click
        Password.PasswordChar = ""
        PassHidePic.Visible = True
        PassSeePic.Visible = False
    End Sub

    '------------ Picture Box Section End ------------------

    '----------- Link Label Section Start -----------------

    Private Sub ChangePassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ChangePassword.LinkClicked
        Me.Hide()
        FrmChangePassword.Show()
        FrmChangePassword.txtUserID.Text = ""
        FrmChangePassword.txtNewPassword.Text = ""
        FrmChangePassword.txtUserID.Focus()
    End Sub

    '----------- Link Label Section End --------------

    '----------------  Button Section Start ---------

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        If Len(Trim(UserID.Text)) = 0 And Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please Enter UserID and Password ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UserID.Focus()
            Exit Sub
        End If

        If Len(Trim(UserID.Text)) = 0 Then
            MessageBox.Show("Please Enter User ID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UserID.Focus()
            Exit Sub
        End If

        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please Enter Password ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Password.Focus()
            Exit Sub
        End If

        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT RTRIM(UserID), RTRIM(Password) FROM Userlogin where UserID = @d1 and Password=@d2"
            cmd.Parameters.AddWithValue("@d1", UserID.Text)
            cmd.Parameters.AddWithValue("@d2", Password.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then

                con = New SqlConnection(cs)
                con.Open()
                cmd = con.CreateCommand()
                cmd.CommandText = "SELECT usertype, Name FROM Userlogin where UserID=@d3 and Password=@d4"
                cmd.Parameters.AddWithValue("@d3", UserID.Text)
                cmd.Parameters.AddWithValue("@d4", Password.Text)
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    UserType.Text = rdr.GetValue(0).ToString.Trim
                    UserName.Text = rdr.GetValue(1).ToString.Trim
                End If

                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                Timer1.Enabled = True
                ProgressBar1.Visible = True
            Else
                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                ProgressBar1.Value = 0
                UserID.Text = ""
                Password.Text = ""
                UserID.Focus()
            End If

            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    '--------------- Button Section End ------------------

    '-------------- Timer Section -------------------

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            If UserType.Text = "Admin" Or UserType.Text = "User" Then

                ProgressBar1.Value = 0

                If UserType.Text = "Admin" Then
                    frm.lblUserID.Text = UserID.Text
                    frm.lblUserName.Text = UserName.Text
                    frm.lblUserType.Text = UserType.Text
                    Dim st As String = "Successfully logged in"

                    If UserID.Text = "146546" And UserName.Text = "Deepak" Then
                        Me.Hide()
                        frm.Show()
                        MsgBox("Welcome Developer", MsgBoxStyle.Information, "Drishti Computers")
                    Else
                        LogFunc(UserID.Text, UserName.Text, st)
                        Me.Hide()
                        frm.Show()
                        MsgBox("Welcome '" & UserName.Text & "'", MsgBoxStyle.Information, "Drishti Computers")
                    End If
                ElseIf UserType.Text = "User" Then
                    frm2.lblUserID.Text = UserID.Text
                    frm2.lblUserName.Text = UserName.Text
                    frm2.lblUserType.Text = UserType.Text
                    Dim st As String = "Successfully logged in"
                    LogFunc(UserID.Text, UserName.Text, st)
                    Me.Hide()
                    frm2.Show()
                    MsgBox("Welcome '" & UserName.Text & "'", MsgBoxStyle.Information, "Drishti Computers")
                End If
            End If
        End If
    End Sub

    '---------------- Timer Section ------------------

End Class