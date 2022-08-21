Imports System.Data.SqlClient

Public Class FrmChangePassword


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

    '----------------------- Button Section Start ----------------------

    Private Sub ChangePassowrdBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePassowrdBtn.Click
        Try
            Dim RowsAffected As Integer = 0
            If Len(Trim(txtUserID.Text)) = 0 Then
                MessageBox.Show("Please enter User ID ?", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserID.Focus()
                Exit Sub
            End If
            If Len(Trim(txtNewPassword.Text)) = 0 Then
                MessageBox.Show("Please enter new Password ?", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPassword.Focus()
                Exit Sub
            End If
            If Len(Trim(txtConfirmPassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new Password ?", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtConfirmPassword.Focus()
                Exit Sub
            End If
            '------------------------------------------------------------------------------------------------------------------------
            If txtNewPassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters !", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPassword.Text = ""
                txtConfirmPassword.Text = ""
                txtNewPassword.Focus()
                Exit Sub
            ElseIf txtNewPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Password do not match !", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPassword.Text = ""
                txtConfirmPassword.Text = ""
                txtNewPassword.Focus()
                Exit Sub
            End If

            '-----------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim co As String = "update UserDetails set Password = '" & (txtNewPassword.Text) & "'where userid='" & txtUserID.Text & "'"
            cmd = New SqlCommand(co)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully changed.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmLogin.Show()
                frmLogin.UserID.Text = ""
                frmLogin.Password.Text = ""
                frmLogin.UserID.Focus()
            Else
                MessageBox.Show("invalid user name or password ?", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserID.Text = ""
                txtNewPassword.Text = ""
                txtConfirmPassword.Text = ""
                txtUserID.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----------------------- Button Section End -----------------------

    'Close Picture


    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Hide()
        frmLogin.Show()
        frmLogin.UserID.Text = ""
        frmLogin.Password.Text = ""
        frmLogin.UserID.Focus()
    End Sub

    Private Sub FrmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class