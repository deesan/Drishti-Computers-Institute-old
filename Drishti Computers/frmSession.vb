Imports System.Data.SqlClient
Imports System.IO
Public Class frmSession

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

    Private Sub frmSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        SessionIDAuto()
    End Sub

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

    '---------- Function Section Start --------------

    Sub Reset()
        txtSession.Text = ""
        SaveBtn.Enabled = True
        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False
        SessionIDAuto()
        txtSession.Focus()
    End Sub

    Sub GetData()
        Try
            Dim A As String = "SELECT RTRIM(Session) As [Session] from Session_Master"
            Dim B As String = "Session_Master"
            Dim C As New DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub DeleteRecord()

        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cl As String = "select Session_Master.Session from Session_master,Student where Session_Master.Session=Student.Session and Session_master.Session=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtSession.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Student Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If

            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Session_master where Session=@d1"
            cmd = New SqlCommand(cq)
            cmd.Parameters.AddWithValue("@d1", txtSession.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the Session '" & txtSession.Text & "'"

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, st)
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                GetData()
                Reset()
            Else
                MessageBox.Show("No Record found !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Sub SessionIDAuto()
        con = New SqlConnection(cs)
        con.Open()

        Dim st As String = "select Count(ID) As ID from Session_Master"
        cmd = New SqlCommand(st)
        cmd.Connection = con

        rdr = cmd.ExecuteReader()
        rdr.Read()

        If rdr("ID").ToString() <> "" Then
            txtSessionID.Text = Integer.Parse(rdr("ID").ToString()) + 1
        Else
            txtSessionID.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    '---------- Function Section End --------------

    '------------- Button Section Start ---------------

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If txtSession.Text = "" Then
            MessageBox.Show("Please enter Session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSession.Focus()
            Return
        End If

        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select Session from Session_Master where Session=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtSession.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("Session Already Exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtSession.Text = ""
                txtSession.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If

            con = New SqlConnection(cs)
            con.Open()

            Dim cb As String = "insert into Session_Master(ID, Session) VALUES (@d1, @d2)"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", txtSessionID.Text)
            cmd.Parameters.AddWithValue("@d2", txtSession.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            Dim st As String = "added the new Session '" & txtSession.Text & "'"

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, st)
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            GetData()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If txtSession.Text = "" Then
            MessageBox.Show("Please enter Session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSession.Focus()
            Return
        End If

        Try
            con = New SqlConnection(cs)
            con.Open()

            Dim cb As String = "Update Session_master set Session=@d1 where Session=@d2"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtSession.Text)
            cmd.Parameters.AddWithValue("@d2", txtSessionName.Text)
            cmd.ExecuteReader()
            con.Close()
            Dim st As String = "updated the Session '" & txtSession.Text & "'"

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, st)
                MessageBox.Show("Successfully updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            GetData()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If Len(Trim(txtSession.Text)) = 0 Then
                MessageBox.Show("Please Enter Session ?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                    DeleteRecord()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--------- Button Section End --------------

    '------------ DatGridview section Start -----------

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)

            txtSession.Text = dr.Cells(0).Value.ToString()
            txtSessionName.Text = dr.Cells(0).Value.ToString()
            UpdateBtn.Enabled = True
            DeleteBtn.Enabled = True
            SaveBtn.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgw_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    '----------------------------------------------------- DatGridview section End ------------------------------------------------------------------------------------------------------------------------------

    'Close Picture Section

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Close()
    End Sub

End Class