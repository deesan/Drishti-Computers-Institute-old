Imports System.Data.SqlClient
Imports System.IO
Public Class FrmAssignement


    Private Sub FrmAssignement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSession()
        Getdata()
    End Sub

    '----------------------- Function section Start ----------------

    Sub Reset()
        txtStudentID.Text = ""
        txtStudentName.Text = ""
        txtCourse.Text = ""
        txtSession.Text = ""
        cmbAssignement.SelectedIndex = -1
        dtpdate.Text = Today
        txtStudentNameSearch.Text = ""
        txtStudentIDSearch.Text = ""
        txtCourseSearch.Text = ""
        cmbSessionSearch.SelectedIndex = -1
        txtStudentNameSearch.Focus()
        DeleteBtn.Enabled = False
        SaveBtn.Enabled = False
        Getdata()
        FillSession()
    End Sub

    Sub Getdata()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(StudentID) ,RTRIM(Name), RTRIM(Course), RTRIM(Session), RTRIM(Assignement), RTRIM(Date) from Assignement", con)  'where Session = '" & lblSession.Text & "'
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub FillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select distinct (Session) From Session_Master where id > (select count(*) from Session_master) - 5", con)
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

    Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            Dim Drop As String = ""

            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "Update Assignement set Assignement = @d1 where StudentID = @d2"
            cmd = New SqlCommand(cq)
            cmd.Parameters.AddWithValue("@d1", Drop)
            cmd.Parameters.AddWithValue("@d2", txtStudentIDChange.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Deleted the Assignement details '" & txtStudentName.Text & "' has id '" & txtStudentID.Text & "'")
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----------------------- Function section End --------------------

    '----------------------- Textbox, Label & Combobox -  Text & Index Change section Start ------------------

    Private Sub txtStudentNameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNameSearch.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(StudentID) ,RTRIM(Name), RTRIM(Course), RTRIM(Session), RTRIM(Assignement), RTRIM(Date) from Assignement where Name like'" & txtStudentNameSearch.Text & "%' order by StudentID", con)   ' and Session = '" & lblSession.Text & "'
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStudentIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentIDSearch.TextChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(StudentID) ,RTRIM(Name), RTRIM(Course), RTRIM(Session), RTRIM(Assignement), RTRIM(Date) from Assignement where StudentID like'" & txtStudentIDSearch.Text & "%' order by StudentID", con)  'and Session = '" & lblSession.Text & "'
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub txtCourseSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCourseSearch.TextChanged
    '    Try
    '        con = New SqlConnection(cs)
    '        con.Open()
    '        cmd = New SqlCommand("Select RTRIM(StudentID) ,RTRIM(Name), RTRIM(Course), RTRIM(Session), RTRIM(Assignement), RTRIM(Date) from Assignement where Course like'" & txtCourseSearch.Text & "%' and Session = '" & lblSession.Text & "' order by StudentID", con)
    '        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    '        dgw.Rows.Clear()
    '        While (rdr.Read() = True)
    '            dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
    '        End While
    '        con.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub cmbSessionSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSessionSearch.SelectedIndexChanged
    '    Try
    '        con = New SqlConnection(cs)
    '        con.Open()
    '        cmd = New SqlCommand("Select RTRIM(StudentID) ,RTRIM(Name), RTRIM(Course), RTRIM(Session), RTRIM(Assignement), RTRIM(Date) from Assignement where Session = '" & cmbSessionSearch.Text & "' order by StudentID", con)
    '        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    '        dgw.Rows.Clear()
    '        While (rdr.Read() = True)
    '            dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
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

    '--------------------- Textbox, Label & Combobox - Text & Index Change section End -------------------------

    '--------------------- Button section Start ---------------------------------------------------------------

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If Len(Trim(txtStudentID.Text)) = 0 Then
                MessageBox.Show("Please Select Student ID ?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "Update Assignement set Assignement = @d1, Date = @d2  where StudentID = @d3"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", cmbAssignement.Text)
                cmd.Parameters.AddWithValue("@d2", dtpdate.Text)
                cmd.Parameters.AddWithValue("@D3", txtStudentIDChange.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                '------------------------------------------------------------------------------------------------------------

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Update the student assignement Details '" & txtStudentName.Text & "' has  ID '" & txtStudentID.Text & "'")
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Reset()
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

        If txtStudentIDSearch.Text <> "" Then
            Try
                con = New SqlConnection(cs)
                con.Open()
                cmd = New SqlCommand("Select RTRIM(StudentID) ,RTRIM(Name), RTRIM(Course), RTRIM(Session), RTRIM(Assignement), RTRIM(Date) from Assignement where Course like'" & txtCourseSearch.Text & "%' and Session = '" & cmbSessionSearch.Text & "' order by StudentID", con) 'and Session = '" & lblSession.Text & "'
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw.Rows.Clear()
                While (rdr.Read() = True)
                    dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5))
                End While
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Getdata()
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If Len(Trim(txtStudentID.Text)) = 0 Then
                MessageBox.Show("Unable to delete", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                    DeleteRecord()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '---------------------- Button section End --------------------------------

    '--------------------- DataGridView section Start -----------------------

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim row As DataGridViewRow = dgw.SelectedRows(0)

            txtStudentID.Text = row.Cells(0).Value.ToString
            txtStudentName.Text = row.Cells(1).Value.ToString
            txtCourse.Text = row.Cells(2).Value.ToString
            txtSession.Text = row.Cells(3).Value.ToString
            cmbAssignement.Text = row.Cells(4).Value.ToString
            dtpdate.Text = row.Cells(5).Value.ToString
            txtStudentIDChange.Text = row.Cells(0).Value.ToString
            SaveBtn.Enabled = True
            DeleteBtn.Enabled = True
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

    '--------------------- DataGridView section End ------------------------

    Shared Function lblSession() As Object
        Throw New NotImplementedException
    End Function


End Class