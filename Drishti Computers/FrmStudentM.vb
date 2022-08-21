Imports System.Data.SqlClient
Imports System.IO

Public Class FrmStudentM

    Dim s1 As String

    Private Sub FrmStudentM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSession()
        FillCenterCode()
        FillCourseCategory()
    End Sub

    '-------------------- Function Section Start -------------------

    Sub Reset()
        cmbCenterCode.SelectedIndex = -1
        txtregistrationNo.Text = ""
        txtStudentID.Text = ""
        dtpAdmissionDate.Text = Today
        cmbSession.SelectedIndex = -1
        txtStudentName.Text = ""
        rdoMale.Checked = False
        rdoFemale.Checked = False
        dtpDoB.Text = Today
        cmbCategory.SelectedIndex = -1
        txtFatherName.Text = ""
        txtMotherName.Text = ""
        cmbCourseCategory.SelectedIndex = -1
        cmbCourseName.SelectedIndex = -1
        txtTotalFees.Text = ""
        txtDuration.Text = ""
        txtFcontactNo.Text = ""
        txtContactNo.Text = ""
        txtEmailID.Text = ""
        txtRemark.Text = ""
        txtAddress.Text = ""
        PIC1.Image = My.Resources.photo
        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False
        GetdataBtn.Enabled = True
        FillCenterCode()
        FillCourseCategory()
        FillSession()
    End Sub

    Sub FillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            'adp.SelectCommand = New SqlCommand("Select distinct (Session) From Session_Master", con)
            adp.SelectCommand = New SqlCommand("Select Session From Session_Master where id > (select count(*) from Session_master) - 5 order by ID", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSession.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSession.Items.Add(drow(0).ToString())
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
            cmbCenterCode.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCenterCode.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub FillCourseCategory()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select distinct (Category) From Course_Category", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCourseCategory.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCourseCategory.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------------------- Function Section End -----------------

    '------------------------ Combobox Index Change Section Start ----------------

    Private Sub cmbCourseCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourseCategory.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "Select CourseName from Course_Master where Category = @d1"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", cmbCourseCategory.Text)
            rdr = cmd.ExecuteReader()
            cmbCourseName.Items.Clear()
            While rdr.Read
                cmbCourseName.Items.Add(rdr(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCourseName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourseName.SelectedIndexChanged
        Try

            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select Duration, FPYear,EFees From Course_Master where CourseName = '" & cmbCourseName.Text & "'", con)
            ds = New DataSet("ds")
            adp.Fill(ds)

            lblCourse.Text = ds.Tables(0).Rows(0)("FPYear").ToString
            txtDuration.Text = ds.Tables(0).Rows(0)("Duration").ToString()
            lblExam.Text = ds.Tables(0).Rows(0)("EFees").ToString()

            Dim num1 As Double
            num1 = CDec(Val(lblCourse.Text) + Val(lblExam.Text))
            num1 = Math.Round(num1, 2)
            txtTotalFees.Text = num1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '---------------- Combobox Index Change Section End -------------------

    '------------------- Button Section Start ----------------

    'Image Button Section Start

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PIC1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        PIC1.Image = My.Resources.photo
    End Sub

    'Image Button Section End

    'Form Button Section Start

    Private Sub GetdataBtn_Click(sender As Object, e As EventArgs) Handles GetdataBtn.Click
        FrmStudentRecord1.lblSet.Text = Me.Text
        FrmStudentRecord1.Reset()
        FrmStudentRecord1.ShowDialog()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If Len(Trim(cmbCenterCode.Text)) = 0 Then
            MessageBox.Show("Please select center code ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCenterCode.Focus()
            Exit Sub
        End If
        If Len(Trim(txtStudentID.Text)) = 0 Then
            MessageBox.Show("Do not blank student id ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentID.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSession.Text)) = 0 Then
            MessageBox.Show("Please select session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSession.Focus()
            Exit Sub
        End If
        If Len(Trim(txtStudentName.Text)) = 0 Then
            MessageBox.Show("Please enter student's name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtFatherName.Text)) = 0 Then
            MessageBox.Show("Please enter father's or husband's name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFatherName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtFatherName.Text)) = 0 Then
            MessageBox.Show("Please enter mother's name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFatherName.Focus()
            Exit Sub
        End If
        If rdoMale.Checked = False And rdoFemale.Checked = False Then
            MessageBox.Show("Please check in gender ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Len(Trim(cmbCategory.Text)) = 0 Then
            MessageBox.Show("Please select category ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCategory.Focus()
            Exit Sub
        End If

        If Len(Trim(cmbCourseName.Text)) = 0 Then
            MessageBox.Show("Please select course ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCourseName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtTotalFees.Text)) = 0 Then
            MessageBox.Show("Please enter fees ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalFees.Focus()
            Exit Sub
        End If
        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("Please enter contact no. ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Exit Sub
        End If
        If txtContactNo.Text.Length < 8 Then
            MessageBox.Show("Contact no. is not vaild !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Exit Sub
        End If
        If Len(Trim(txtAddress.Text)) = 0 Then
            MessageBox.Show("Please enter address ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Exit Sub
        End If

        Try
            If rdoMale.Checked = True Then
                s1 = rdoMale.Text
            End If
            If rdoFemale.Checked = True Then
                s1 = rdoFemale.Text
            End If

            ' sql connection for update record to student table

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update Student Set Photo = @d1, RegisterNo = @d2, StuName = @d3, FName = @d4, MName = @d5, Gender = @d6, DoB = @d7, Category = @d8, Session = @d9, CourseCategory = @d10, CourseName = @d11, CourseFees = @d12, ExamFees = @d13, Duration = @d14, FContactNo = @d15, ContactNo = @d16, EmailID = @d17, CenterCode = @d18, AdmissionDate = @d19, Remark = @d20, Address = @d21 where StudentID = @d22"
            cmd = New SqlCommand(cb)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PIC1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d1", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.Parameters.AddWithValue("@d2", txtregistrationNo.Text)
            cmd.Parameters.AddWithValue("@d3", txtStudentName.Text)
            cmd.Parameters.AddWithValue("@d4", txtFatherName.Text)
            cmd.Parameters.AddWithValue("@d5", txtMotherName.Text)
            cmd.Parameters.AddWithValue("@d6", s1)
            cmd.Parameters.AddWithValue("@d7", dtpDoB.Text)
            cmd.Parameters.AddWithValue("@d8", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@d9", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d10", cmbCourseCategory.Text)
            cmd.Parameters.AddWithValue("@d11", cmbCourseName.Text)
            cmd.Parameters.AddWithValue("@d12", lblCourse.Text)
            cmd.Parameters.AddWithValue("@d13", lblExam.Text)
            cmd.Parameters.AddWithValue("@d14", txtDuration.Text)
            cmd.Parameters.AddWithValue("@d15", txtFcontactNo.Text)
            cmd.Parameters.AddWithValue("@d16", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d17", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d18", cmbCenterCode.Text)
            cmd.Parameters.AddWithValue("@d19", dtpAdmissionDate.Text)
            cmd.Parameters.AddWithValue("@d20", txtRemark.Text)
            cmd.Parameters.AddWithValue("@d21", txtAddress.Text)
            cmd.Parameters.AddWithValue("@d22", txtStudentIDChange.Text)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()

            ' sql connection for update record to fullreport table

            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "Update FullReport Set  RegistrationNo = @d1, StuName = @d2, FName = @d3, MName = @d4, DoB = @d5, Mobileno = @d6, Course = @d7, Session = @d8, TotalCouFees = @d9, ExamFees = @d10,  TotalFees = @d11 where StudentID = @d12"
            cmd = New SqlCommand(cb1)
            cmd.Parameters.AddWithValue("@d1", txtregistrationNo.Text)
            cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
            cmd.Parameters.AddWithValue("@d3", txtFatherName.Text)
            cmd.Parameters.AddWithValue("@d4", txtMotherName.Text)
            cmd.Parameters.AddWithValue("@d5", dtpDoB.Text)
            cmd.Parameters.AddWithValue("@d6", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d7", cmbCourseName.Text)
            cmd.Parameters.AddWithValue("@d8", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d9", lblCourse.Text)
            cmd.Parameters.AddWithValue("@d10", lblExam.Text)
            cmd.Parameters.AddWithValue("@d11", txtTotalFees.Text)
            cmd.Parameters.AddWithValue("@d12", txtStudentIDChange.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            ' sql connection for update record to assignement table

            con = New SqlConnection(cs)
            con.Open()
            Dim cb2 As String = "Update Assignement Set Name = @d1, Course = @d2, Session = @d3 where StudentID = @d4"
            cmd = New SqlCommand(cb2)
            cmd.Parameters.AddWithValue("@d1", txtStudentName.Text)
            cmd.Parameters.AddWithValue("@d2", cmbCourseName.Text)
            cmd.Parameters.AddWithValue("@d3", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d4", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            ' sql connection for update record to coursematerial table

            con = New SqlConnection(cs)
            con.Open()
            Dim cb3 As String = "Update CourseMaterial Set Name = @d2, Course = @d3, Session = @d4, CenterCode = @d5 where StudentID = @d1"
            cmd = New SqlCommand(cb3)
            cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
            cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
            cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d5", cmbCenterCode.Text)
            cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            ' sql connection for update record to examfrom table

            con = New SqlConnection(cs)
            con.Open()
            Dim cb4 As String = "Update ExamFrom Set Name = @d2, Course = @d3, Session = @d4 where StudentID = @d1"
            cmd = New SqlCommand(cb4)
            cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
            cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
            cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            ' sql connection for update record to result_given table

            con = New SqlConnection(cs)
            con.Open()
            Dim cb5 As String = "Update Result_Given Set Name = @d2, Course = @d3, Session = @d4, CenterCode = @d5 where StudentID = @d1"
            cmd = New SqlCommand(cb5)
            cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
            cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
            cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d5", cmbCenterCode.Text)
            cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            ' sql connection for update record to result_receive table

            con = New SqlConnection(cs)
            con.Open()
            Dim cb6 As String = "Update Result_Receive Set Name = @d2, Course = @d3, Session = @d4, CenterCode = @d5 where StudentID = @d1"
            cmd = New SqlCommand(cb6)
            cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
            cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
            cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
            cmd.Parameters.AddWithValue("@d5", cmbCenterCode.Text)
            cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            'conditions

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, "Update student Details '" & txtStudentName.Text & "' has Student ID '" & txtStudentID.Text & "'")
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If Len(Trim(txtStudentID.Text)) = 0 Then
                MessageBox.Show("Unable to delete", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                frmAdmissioncancel1.txtStudentID.Text = txtStudentID.Text
                frmAdmissioncancel1.txtStudentName.Text = txtStudentName.Text
                frmAdmissioncancel1.txtCourse.Text = cmbCourseName.Text
                frmAdmissioncancel1.txtSession.Text = cmbSession.Text
                frmAdmissioncancel1.lblUserName.Text = lblUserName.Text
                frmAdmissioncancel1.lblUserID.Text = lblUserID.Text
                frmAdmissioncancel1.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Form Button Section End

    '--------------- Button Section End --------------------
  
    Private Sub CustomFees_CheckedChanged(sender As Object, e As EventArgs) Handles CustomFees.CheckedChanged
        If CustomFees.Checked = True Then
            txtTotalFees.ReadOnly = False
        Else
            txtTotalFees.ReadOnly = True
        End If
    End Sub

End Class