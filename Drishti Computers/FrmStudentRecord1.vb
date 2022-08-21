Imports System.Data.SqlClient
Imports System.IO

Public Class FrmStudentRecord1

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

    Private Sub FrmStudentRecord1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
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

    '----------------- Function Section Start -------------

    Sub Reset()
        txtStudentNameIDSearch.Text = ""
        GetData()
        txtStudentNameIDSearch.Focus()
    End Sub

    Sub GetData()

        con = New SqlConnection(cs)
        con.Open()
        adp = New SqlDataAdapter()
        adp.SelectCommand = New SqlCommand("Select Photo, RTRIM(RegisterNO) As [Registration No],RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(FName) As [F/H's Name], RTRIM(MName) As [Mother's Name], RTRIM(Gender) As [Gender], RTRIM(DoB) As [Date of Birth], RTRIM(Category) As [Category], RTRIM(Session) As [Session], RTRIM(CourseCategory) As [Course Category], RTRIM(CourseName) As [Course], RTRIM(CourseFees) As [Course Fees], RTRIM(ExamFees) As [Exam Fees], RTRIM(Duration) As [Duration], RTRIM(FContactNo) As [Father's Contact No.], RTRIM(ContactNo) As [Contact No.], RTRIM(EmailID) As [Email ID], RTRIM(CenterCode) As [Center Code], RTRIM(AdmissionDate) As [Admission Date], RTRIM(Remark) As [Remark], RTRIM(Address) As [Address] from Student", con)
        dtable = New DataTable
        adp.Fill(dtable)

        Dim imgc As New DataGridViewImageColumn()

        dgw.DataSource = dtable
        imgc = dgw.Columns(0)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        dgw.RowTemplate.Height = 50
        dgw.Columns(0).Width = 50
        con.Close()
        'Try
        '    Dim A As String = "Select Photo, RTRIM(RegisterNO) As [Registration No],RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(FName) As [F/H's Name], RTRIM(MName) As [Mother's Name], RTRIM(Gender) As [Gender], RTRIM(DoB) As [Date of Birth], RTRIM(Category) As [Category], RTRIM(CourseName) As [Course], RTRIM(TotalFees) As [Total Fees], RTRIM(Duration) As [Duration], RTRIM(FContactNo) As [Father's Contact No.], RTRIM(ContactNo) As [Contact No.], RTRIM(EmailID) As [Email ID], RTRIM(CenterCode) As [Center Code], RTRIM(AdmissionDate) As [Admission Date], RTRIM(Session) As [Session], RTRIM(Remark) As [Remark], RTRIM(Address) As [Address] from Student"
        '    Dim B As String = "Student"
        '    Dim C As New DataGridView
        '    C = dgw
        '    Data(A, B, C)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    '---------------- Function Section End ----------------

    '--------------- Textbox Text Change Section Start ------------------

    Private Sub txtStudentNameIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNameIDSearch.TextChanged
        Try
            Dim A As String = "Select Photo, RTRIM(RegisterNO) As [Registration No],RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(FName) As [F/H's Name], RTRIM(MName) As [Mother's Name], RTRIM(Gender) As [Gender], RTRIM(DoB) As [Date of Birth], RTRIM(Category) As [Category], RTRIM(Session) As [Session], RTRIM(CourseCategory) As [Course Category], RTRIM(CourseName) As [Course], RTRIM(CourseFees) As [Course Fees], RTRIM(ExamFees) As [Exam Fees], RTRIM(Duration) As [Duration], RTRIM(FContactNo) As [Father's Contact No.], RTRIM(ContactNo) As [Contact No.], RTRIM(EmailID) As [Email ID], RTRIM(CenterCode) As [Center Code], RTRIM(AdmissionDate) As [Admission Date], RTRIM(Remark) As [Remark], RTRIM(Address) As [Address] from Student where StuName like'" & txtStudentNameIDSearch.Text & "%' or StudentID like'" & txtStudentNameIDSearch.Text & "%' order by StuName"
            Dim B As String = "Student"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------- Textbox Text Change Section End -------------------

    '-------------------- Button Section Start ----------------------

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Reset()
    End Sub

    '--------------- Button Section End ----------------

    '----------------- DataGridView section Start ----------

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim dr As DataGridViewRow = dgw.SelectedRows(0)

            If lblSet.Text = "Admission Cancel" Then
                Me.Hide()
                FrmAdmissioncancel.Show()
                FrmAdmissioncancel.txtStudentID.Text = dr.Cells(2).Value.ToString()
                FrmAdmissioncancel.txtStudentName.Text = dr.Cells(3).Value.ToString()
                FrmAdmissioncancel.txtCourse.Text = dr.Cells(11).Value.ToString()
                FrmAdmissioncancel.txtSession.Text = dr.Cells(9).Value.ToString()
                FrmAdmissioncancel.AdmissincancelBtn.Enabled = True
            End If

            If lblSet.Text = "Other Fees" Then
                Me.Hide()
                FrmOtherFees.Show()
                FrmOtherFees.txtStudentID.Text = dr.Cells(2).Value.ToString()
                FrmOtherFees.txtStudentname.Text = dr.Cells(3).Value.ToString()
                FrmOtherFees.txtCourse.Text = dr.Cells(11).Value.ToString()
                FrmOtherFees.txtSession.Text = dr.Cells(9).Value.ToString()
                FrmOtherFees.otherFeesIDAuto()
                FrmOtherFees.SaveBtn.Enabled = True
            End If

            If lblSet.Text = "Discount" Then
                Me.Hide()
                FrmDiscount.Show()
                FrmDiscount.txtStudentID.Text = dr.Cells(2).Value.ToString()
                FrmDiscount.txtStudentName.Text = dr.Cells(3).Value.ToString()
                FrmDiscount.txtCourse.Text = dr.Cells(11).Value.ToString()
                FrmDiscount.txtSession.Text = dr.Cells(9).Value.ToString()
                FrmDiscount.SaveBtn.Enabled = True
            End If

            If lblSet.Text = "Edit Student Record" Then
                Me.Close()
                FrmStudentM.Show()

                Dim data As Byte() = DirectCast(dr.Cells(0).Value, Byte())
                Dim ms As New MemoryStream(data)
                FrmStudentM.PIC1.Image = Image.FromStream(ms)

                FrmStudentM.txtregistrationNo.Text = dr.Cells(1).Value.ToString()
                FrmStudentM.txtStudentID.Text = dr.Cells(2).Value.ToString()
                FrmStudentM.txtStudentName.Text = dr.Cells(3).Value.ToString()
                FrmStudentM.txtFatherName.Text = dr.Cells(4).Value.ToString()
                FrmStudentM.txtMotherName.Text = dr.Cells(5).Value.ToString()
                If (dr.Cells(6).Value = "Male") Then
                    FrmStudentM.rdoMale.Checked = True
                End If
                If (dr.Cells(6).Value = "female") Then
                    FrmStudentM.rdoFemale.Checked = True
                End If
                FrmStudentM.dtpDoB.Text = dr.Cells(7).Value.ToString()
                FrmStudentM.cmbCategory.Text = dr.Cells(8).Value.ToString()
                FrmStudentM.cmbSession.Text = dr.Cells(9).Value.ToString()
                FrmStudentM.cmbCourseCategory.Text = dr.Cells(10).Value.ToString()
                FrmStudentM.cmbCourseName.Text = dr.Cells(11).Value.ToString()
                FrmStudentM.lblCourse.Text = dr.Cells(12).Value.ToString()
                FrmStudentM.lblExam.Text = dr.Cells(13).Value.ToString()
                FrmStudentM.txtDuration.Text = dr.Cells(14).Value.ToString()
                FrmStudentM.txtFcontactNo.Text = dr.Cells(15).Value.ToString()
                FrmStudentM.txtContactNo.Text = dr.Cells(16).Value.ToString()
                FrmStudentM.txtEmailID.Text = dr.Cells(17).Value.ToString()
                FrmStudentM.cmbCenterCode.Text = dr.Cells(18).Value.ToString()
                FrmStudentM.dtpAdmissionDate.Text = dr.Cells(19).Value.ToString()
                FrmStudentM.txtRemark.Text = dr.Cells(20).Value.ToString()
                FrmStudentM.txtAddress.Text = dr.Cells(21).Value.ToString()
                FrmStudentM.txtStudentIDChange.Text = dr.Cells(2).Value.ToString()
                FrmStudentM.UpdateBtn.Enabled = True
                FrmStudentM.DeleteBtn.Enabled = True
            End If

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

    '------------------- DataGridView section End ----------------------

    ' Close Picturebox Section

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Close()
    End Sub

End Class