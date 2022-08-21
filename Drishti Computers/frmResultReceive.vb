Imports System.Data.SqlClient
Imports System.IO

Public Class frmResultReceive

    Private Sub frmResultReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
    End Sub

    '------------------- Function section Start -----------------

    Sub Reset()
        txtStudentNameSearch.Text = ""
        txtStudentIDSearch.Text = ""
        txtStudentID.Text = ""
        txtStudentName.Text = ""
        txtCourse.Text = ""
        txtSession.Text = ""
        txtSubject.Enabled = False
        cmbStatus.SelectedIndex = -1
        cmbReceive.SelectedIndex = -1
        dtpReceiveDate.Text = Today
        SaveBtn.Enabled = False
        DeleteBtn.Enabled = False
        Getdata()
    End Sub

    Sub Getdata()
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session],  RTRIM(Receive) As [Receive], RTRIM(Date) As [Date] from Result_Receive"     'RTRIM(Subject) As [Backlog], ''where Session = '" & lblSession.Text & "'
            Dim B As String = "Result_Receive"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
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
            Dim cq As String = "Update Result_Receive set Status = @d1, Subject = @d2, Receive = @d3,  NOFM = @d4  where StudentID = @d5"
            cmd = New SqlCommand(cq)
            cmd.Parameters.AddWithValue("@d1", Drop)
            cmd.Parameters.AddWithValue("@d2", Drop)
            cmd.Parameters.AddWithValue("@d3", Drop)
            cmd.Parameters.AddWithValue("@d4", Drop)
            cmd.Parameters.AddWithValue("@d5", txtStudentID.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Deleted the Result Receive details '" & txtStudentName.Text & "' has id '" & txtStudentID.Text & "'")
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Reset()
            Else
                MessageBox.Show("No record found ?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------- Function section End ------------------

    '--------------- Textbox, Label & Combobox - Text & Index Change section Start --------------

    Private Sub txtStudentNameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNameSearch.TextChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Receive) As [Receive], RTRIM(Date) As [Date] from Result_Receive where Name like'" & txtStudentNameSearch.Text & "%' order by StudentID"    'RTRIM(Subject) As [Backlog],  ''and Session = '" & lblSession.Text & "'
            Dim B As String = "Result_Receive"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStudentIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentIDSearch.TextChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Receive) As [Receive], RTRIM(Date) As [Date] from Result_Receive where StudentID like'" & txtStudentIDSearch.Text & "%' order by StudentID"  'RTRIM(Subject) As [Backlog],  ''and Session = '" & lblSession.Text & "'
            Dim B As String = "Result_Receive"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If cmbStatus.SelectedItem = "Back" Then
            txtSubject.Enabled = True
        Else
            txtSubject.Enabled = False
        End If
    End Sub

    'Private Sub lblSession_TextChanged(sender As Object, e As EventArgs) Handles lblSession.TextChanged
    '    Reset()
    '    Getdata()
    'End Sub

    '----------------- Textbox, Label & Combobox - Text & Index Change section End -------------------

    '------------------ Button section Start -------------------

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If Len(Trim(txtStudentID.Text)) = 0 Then
                MessageBox.Show("Unable to Update. Please select Student ID ?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "Update Result_Receive set Status = @d1, Subject = @d2, Receive = @d3, NOFM = @d4, Date = @d5  where StudentID = @d6"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@d2", txtSubject.Text)
                cmd.Parameters.AddWithValue("@d3", cmbReceive.Text)
                cmd.Parameters.AddWithValue("@d4", cmbNFM.Text)
                cmd.Parameters.AddWithValue("@d5", dtpReceiveDate.Text)
                cmd.Parameters.AddWithValue("@d6", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                '-----------------------------------------------------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb2 As String = "Update FullReport set Result = @d1, MReceive = @d2 where StudentID = @d3"
                cmd = New SqlCommand(cb2)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@d2", cmbReceive.Text)
                cmd.Parameters.AddWithValue("@D3", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                '------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Update the student Result Receive Details '" & txtStudentName.Text & "' has  ID '" & txtStudentID.Text & "'")
                    MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Getdata()
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
                Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Receive) As [Receive], RTRIM(Date) As [Date] from Result_Receive where Course like '" & txtCourseSearch.Text & "%' and session = '" & cmbSessionSearch.Text & "' order by StudentID"   'and Session = '" & lblSession.Text & "'
                Dim B As String = "Result_Receives"
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

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If Len(Trim(txtStudentID.Text)) = 0 Then
                MessageBox.Show("Unable to Delete !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                    DeleteRecord()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------------ Button section End ---------------

    '------------ DataGridView section Start ------------------

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim row As DataGridViewRow = dgw.SelectedRows(0)

            txtStudentID.Text = row.Cells(0).Value.ToString
            txtStudentName.Text = row.Cells(1).Value.ToString
            txtCourse.Text = row.Cells(2).Value.ToString
            txtSession.Text = row.Cells(3).Value.ToString
            cmbReceive.Text = row.Cells(4).Value.ToString
            dtpReceiveDate.Text = row.Cells(5).Value.ToString
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

    '---------------- DataGridView section End -----------------

End Class