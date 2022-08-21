Imports System.Data.SqlClient
Imports System.IO

Public Class frmStudentRecord

    Private Sub frmStudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSession()
        FillCenterCode()
        GetData()
        dtpFrom.Text = Today
        dtpTo.Text = Today
    End Sub

    '----------------- Function Section Start --------------

    Sub Reset()
        txtStuNameIDCourseSearch.Text = ""
        cmbSessionSearch.SelectedIndex = -1
        dtpFrom.Text = Today
        dtpTo.Text = Today
        cmbCenterCodeSearch.SelectedIndex = -1
        FillCenterCode()
        FillSession()
        GetData()
        ResetBtn.Focus()
    End Sub

    Sub GetData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select Photo, RTRIM(RegisterNO), RTRIM(StudentID), RTRIM(StuName), RTRIM(FName), RTRIM(MName), RTRIM(Gender), RTRIM(DoB), RTRIM(Category), RTRIM(FContactNo), RTRIM(ContactNo), RTRIM(EmailID), RTRIM(AdmissionDate), RTRIM(Address), RTRIM(Session), RTRIM(CenterCode), RTRIM(CourseCategory), RTRIM(CourseName), RTRIM(CourseFees), RTRIM(ExamFees), RTRIM(Duration), RTRIM(Remark) from Student order by StudentID", con)   'where Session = '" & lblSession.Text & "'
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21))
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
            adp.SelectCommand = New SqlCommand("Select Session From Session_Master order by ID", con)
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

    Sub FillCenterCode()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select distinct (CenterCode) From CenterCode", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCenterCodeSearch.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCenterCodeSearch.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-------------------- Function Section End -------------------

    '-------------------- Textbox, Label & Combobox - Text & Index Change section Start --------------------

    Private Sub txtStuNameIDCourseSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStuNameIDCourseSearch.TextChanged
        If txtStuNameIDCourseSearch.Text <> "" Then
            Try
                con = New SqlConnection(cs)
                con.Open()
                cmd = New SqlCommand("Select Photo, RTRIM(RegisterNO), RTRIM(StudentID), RTRIM(StuName), RTRIM(FName), RTRIM(MName), RTRIM(Gender), RTRIM(DoB), RTRIM(Category), RTRIM(FContactNo), RTRIM(ContactNo), RTRIM(EmailID), RTRIM(AdmissionDate), RTRIM(Address), RTRIM(Session), RTRIM(CenterCode), RTRIM(CourseCategory), RTRIM(CourseName), RTRIM(CourseFees), RTRIM(ExamFees), RTRIM(Duration), RTRIM(Remark) from Student where StuName like'" & txtStuNameIDCourseSearch.Text & "%' or StudentID like '" & txtStuNameIDCourseSearch.Text & "' or CourseName like '" & txtStuNameIDCourseSearch.Text & "' or RegisterNO like '" & txtStuNameIDCourseSearch.Text & "' order by StudentID", con)   'and Session = '" & lblSession.Text & "'     '' or COurseName like '" & txtStuNameIDCourseSearch.Text & "'
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                dgw.Rows.Clear()
                While (rdr.Read() = True)
                    dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21))
                End While
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cmbSessionSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSessionSearch.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select Photo, RTRIM(RegisterNO), RTRIM(StudentID), RTRIM(StuName), RTRIM(FName), RTRIM(MName), RTRIM(Gender), RTRIM(DoB), RTRIM(Category), RTRIM(FContactNo), RTRIM(ContactNo), RTRIM(EmailID), RTRIM(AdmissionDate), RTRIM(Address), RTRIM(Session), RTRIM(CenterCode), RTRIM(CourseCategory), RTRIM(CourseName), RTRIM(CourseFees), RTRIM(ExamFees), RTRIM(Duration), RTRIM(Remark) from Student where Session = '" & cmbSessionSearch.Text & "' order by StudentID", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----------- Textbox, Label & Combobox - Text & Index Change section End --------------

    '-------------- Button section Start ----------------

    'Reset Button

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    'Search Button

    Private Sub SearchBtn1_Click(sender As Object, e As EventArgs) Handles SearchBtn1.Click
        If Len(Trim(txtStuNameIDCourseSearch.Text)) = 0 Then
            MessageBox.Show("Please Enter Course ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStuNameIDCourseSearch.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSessionSearch.Text)) = 0 Then
            MessageBox.Show("Please Select Session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSessionSearch.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select Photo, RTRIM(RegisterNO), RTRIM(StudentID), RTRIM(StuName), RTRIM(FName), RTRIM(MName), RTRIM(Gender), RTRIM(DoB), RTRIM(Category), RTRIM(FContactNo), RTRIM(ContactNo), RTRIM(EmailID), RTRIM(AdmissionDate), RTRIM(Address), RTRIM(Session), RTRIM(CenterCode), RTRIM(CourseCategory), RTRIM(CourseName), RTRIM(CourseFees), RTRIM(ExamFees), RTRIM(Duration), RTRIM(Remark) from Student where  CourseName like '" & txtStuNameIDCourseSearch.Text & "' and session=@d1 order by StudentID", con)
            cmd.Parameters.AddWithValue("@d1", cmbSessionSearch.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchBtn2_Click(sender As Object, e As EventArgs) Handles SearchBtn2.Click
        If Len(Trim(cmbSessionSearch.Text)) = 0 Then
            MessageBox.Show("Please Select Session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStuNameIDCourseSearch.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbCenterCodeSearch.Text)) = 0 Then
            MessageBox.Show("Please Select Center Code ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCenterCodeSearch.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select Photo, RTRIM(RegisterNO), RTRIM(StudentID), RTRIM(StuName), RTRIM(FName), RTRIM(MName), RTRIM(Gender), RTRIM(DoB), RTRIM(Category), RTRIM(FContactNo), RTRIM(ContactNo), RTRIM(EmailID), RTRIM(AdmissionDate), RTRIM(Address), RTRIM(Session), RTRIM(CenterCode), RTRIM(CourseCategory), RTRIM(CourseName), RTRIM(CourseFees), RTRIM(ExamFees), RTRIM(Duration), RTRIM(Remark) from Student where session=@d1 and centercode=@d2 order by StudentID", con)
            cmd.Parameters.AddWithValue("@d1", cmbSessionSearch.Text)
            cmd.Parameters.AddWithValue("@d2", cmbCenterCodeSearch.Text)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchBtn3_Click(sender As Object, e As EventArgs) Handles SearchBtn3.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select Photo, RTRIM(RegisterNO), RTRIM(StudentID), RTRIM(StuName), RTRIM(FName), RTRIM(MName), RTRIM(Gender), RTRIM(DoB), RTRIM(Category), RTRIM(FContactNo), RTRIM(ContactNo), RTRIM(EmailID), RTRIM(AdmissionDate), RTRIM(Address), RTRIM(Session), RTRIM(CenterCode), RTRIM(CourseCategory), RTRIM(CourseName), RTRIM(CourseFees), RTRIM(ExamFees), RTRIM(Duration), RTRIM(Remark) from Student where AdmissionDate between @d1 and @d2 order by StudentID", con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpTo.Value.Date
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------ Button section End --------------------

    '------------- DataGridView section Start ---------------

    Private Sub dgw_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)

            Dim data As Byte() = DirectCast(dr.Cells(0).Value, Byte())
            Dim ms As New MemoryStream(data)
            FrmStuDetailasPopup.StuPic.Image = Image.FromStream(ms)

            FrmStuDetailasPopup.lblRegistrationNo.Text = dr.Cells(1).Value.ToString()
            FrmStuDetailasPopup.lblStuID.Text = dr.Cells(2).Value.ToString()
            FrmStuDetailasPopup.lblStudentName.Text = dr.Cells(3).Value.ToString()
            FrmStuDetailasPopup.lblFHName.Text = dr.Cells(4).Value.ToString()
            FrmStuDetailasPopup.lblMotherName.Text = dr.Cells(5).Value.ToString()
            FrmStuDetailasPopup.lblGender.Text = dr.Cells(6).Value.ToString()
            FrmStuDetailasPopup.lblDoB.Text = dr.Cells(7).Value.ToString()
            FrmStuDetailasPopup.lblCategory.Text = dr.Cells(8).Value.ToString()
            FrmStuDetailasPopup.lblFatherContactNo.Text = dr.Cells(9).Value.ToString()
            FrmStuDetailasPopup.lblContactNo.Text = dr.Cells(10).Value.ToString()
            FrmStuDetailasPopup.lblEmailID.Text = dr.Cells(11).Value.ToString()
            FrmStuDetailasPopup.lblAdmissionDate.Text = dr.Cells(12).Value.ToString()
            FrmStuDetailasPopup.lblAddress.Text = dr.Cells(13).Value.ToString()
            FrmStuDetailasPopup.lblSession.Text = dr.Cells(14).Value.ToString()
            FrmStuDetailasPopup.lblCenterCode.Text = dr.Cells(15).Value.ToString()
            FrmStuDetailasPopup.lblCourseCategory.Text = dr.Cells(16).Value.ToString()
            FrmStuDetailasPopup.lblCourseName.Text = dr.Cells(17).Value.ToString()
            FrmStuDetailasPopup.lblCourse.Text = dr.Cells(18).Value.ToString()
            FrmStuDetailasPopup.lblExam.Text = dr.Cells(19).Value.ToString()
            FrmStuDetailasPopup.lblDuration.Text = dr.Cells(20).Value.ToString()
            FrmStuDetailasPopup.lblRemark.Text = dr.Cells(21).Value.ToString()


            FrmStuDetailasPopup.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------- DataGridView section End -----------

End Class