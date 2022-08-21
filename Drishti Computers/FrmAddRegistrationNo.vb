Imports System.Data.SqlClient

Public Class FrmAddRegistrationNo

    Private Sub FrmAddRegistrationNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSession()
        Getdata()
    End Sub

    '-------------------- Function Section Start ------------------

    Sub Reset()
        txtStudentID.Text = ""
        txtStudentName.Text = ""
        txtCourse.Text = ""
        txtSession.Text = ""
        txtRegistrationNo.Text = ""
        txtStudentNameSearch.Text = ""
        txtStudentIDSearch.Text = ""
        txtCourseSearch.Text = ""
        cmbSessionSearch.SelectedIndex = -1
        SaveBtn.Enabled = False
        Getdata()
        FillSession()
    End Sub

    Sub FillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select Session From Session_Master where id > (select count(*) from Session_master) - 5 order by ID", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSessionSearch.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSessionSearch.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Getdata()
        Try
            Dim A As String = "Select RTRIM(RegisterNo) As[Registration No.], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(CourseName) As [Course], RTRIM(Session) As [Session] from Student"
            Dim B As String = "Student"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-------------------- Function Section End -------------------

    '-------------------- Textbox, Label and Combobox - Text & Index Change Section Start ---------------

    Private Sub txtStudentNameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNameSearch.TextChanged
        If txtStudentNameSearch.Text <> "" Then
            Try
                Dim A As String = "Select RTRIM(RegisterNo) As[Registration No.], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(CourseName) As [Course], RTRIM(Session) As [Session] from Student where StuName like'" & txtStudentNameSearch.Text & "%' order by StudentID"
                Dim B As String = "Student"
                Dim C As DataGridView
                C = dgw
                Data(A, B, C)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Getdata()
        End If
    End Sub

    Private Sub txtStudentIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentIDSearch.TextChanged
        If txtStudentIDSearch.Text <> "" Then
            Try
                Dim A As String = "Select RTRIM(RegisterNo) As[Registration No.], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(CourseName) As [Course], RTRIM(Session) As [Session] from Student where StudentID like'" & txtStudentIDSearch.Text & "%' order by StudentID"
                Dim B As String = "Student"
                Dim C As DataGridView
                C = dgw
                Data(A, B, C)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Getdata()
        End If
    End Sub

    'Private Sub txtCourseSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCourseSearch.TextChanged
    '    If txtCourseSearch.Text <> "" Then
    '        Try
    '            con = New SqlConnection(cs)
    '            con.Open()
    '            cmd = New SqlCommand("Select RTRIM(RegisterNo), RTRIM(StudentID), RTRIM(StuName), RTRIM(CourseName), RTRIM(Session) from Student where CourseName like'" & txtCourseSearch.Text & "%' and Session = '" & lblSession.Text & "' order by StudentID", con)
    '            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    '            dgw.Rows.Clear()
    '            While (rdr.Read() = True)
    '                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
    '            End While
    '            con.Close()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    Else
    '        Getdata()
    '    End If
    'End Sub

    'Private Sub cmbSessionSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSessionSearch.SelectedIndexChanged
    '    Try
    '        con = New SqlConnection(cs)
    '        con.Open()
    '        cmd = New SqlCommand("Select RTRIM(RegisterNo), RTRIM(StudentID), RTRIM(StuName), RTRIM(CourseName), RTRIM(Session) from Student where Session = '" & cmbSessionSearch.Text & "'", con)
    '        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    '        dgw.Rows.Clear()
    '        While (rdr.Read() = True)
    '            dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
    '        End While
    '        con.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub lblSession_TextChanged(sender As Object, e As EventArgs) Handles lblSession.TextChanged
    '    Reset()
    '    Getdata()
    'End Sub

    '---------------------- Textbox, Label and Combobox - Text & Index Change Section End -----------------

    '---------------------- Button Section Start ---------------------

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If Len(Trim(txtRegistrationNo.Text)) = 0 Then
                MessageBox.Show("Please enter Registartion No ?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "Update Student set RegisterNo = @d1 where StudentID = @d2"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtRegistrationNo.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                '---------------------------------------------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb2 As String = "Update FullReport set RegistrationNo = @d1 where StudentID = @d2"
                cmd = New SqlCommand(cb2)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtRegistrationNo.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Added.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Added the student  Registration No '" & txtStudentName.Text & "' has  ID '" & txtStudentID.Text & "'")
                    MessageBox.Show("Successfully Added.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub searchbtn1_Click(sender As Object, e As EventArgs) Handles searchbtn1.Click
        If Len(Trim(txtCourseSearch.Text)) = 0 Then
            MessageBox.Show("Please enter course name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCourse.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSessionSearch.Text)) = 0 Then
            MessageBox.Show("Please select session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSessionSearch.Focus()
            Exit Sub
        End If
        Try
            Dim A As String = "Select RTRIM(RegisterNo) As[Registration No.], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(CourseName) As [Course], RTRIM(Session) As [Session] from Student where CourseName like'" & txtCourseSearch.Text & "%' and Session = '" & cmbSessionSearch.Text & "' order by StudentID"
            Dim B As String = "Student"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Reset()
    End Sub

    '---------------------- Button Section End --------------------------

    '---------------------- DataGridView Section Start ---------------------

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim row As DataGridViewRow = dgw.SelectedRows(0)

            txtRegistrationNo.Text = row.Cells(0).Value.ToString()
            txtStudentID.Text = row.Cells(1).Value.ToString()
            txtStudentName.Text = row.Cells(2).Value.ToString()
            txtCourse.Text = row.Cells(3).Value.ToString()
            txtSession.Text = row.Cells(4).Value.ToString()
            SaveBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgw_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    '----------------------- DataGridView Section End -----------------------

End Class