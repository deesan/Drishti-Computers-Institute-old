Imports System.Data.SqlClient
Imports System.IO
Public Class FrmStudent

    Dim s1 As String
    Dim YNC As String = "No"
    Dim A As Integer = 0

    Private Sub FrmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSession()
        FillCenterCode()
        FillCourseCategory()
        studentIDAuto()
        dtpAdmissionDate.Text = Today
        dtpDoB.Text = Today
    End Sub

    '--------- Function Section Start -------------

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
        SaveBtn.Enabled = True
        StudentIDAuto()
        FillCenterCode()
        FillCourseCategory()
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

    Sub StudentIDAuto()
        con = New SqlConnection(cs)
        con.Open()

        Dim st As String = "select Count(StudentID) As SID from Student"
        cmd = New SqlCommand(st)
        cmd.Connection = con

        rdr = cmd.ExecuteReader()
        rdr.Read()

        If rdr("SID").ToString() <> "" Then
            txtStudentID.Text = "S" & Integer.Parse(rdr("SID").ToString()) + 1
        Else
            txtStudentID.Text = "S" & 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    '------------------ Function Section End --------------

    '------------------ Combobox Intex Chnage Section Start ---------------

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

    '------------- Combobox Intex Chnaged Section End ----------------

    '------------------ Button Section Start ---------------

    'Iamge Control Button Section Start

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

    'Image Control Button Section End

    'Main Button Section Start

    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        Reset()
        StudentIDAuto()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If Len(Trim(cmbCenterCode.Text)) = 0 Then
            MessageBox.Show("Please select center code ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCenterCode.Focus()
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
            MessageBox.Show("Please enter father's name or husband's name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFatherName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtMotherName.Text)) = 0 Then
            MessageBox.Show("Please enter mother's name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMotherName.Focus()
            Exit Sub
        End If
        If rdoMale.Checked = False And rdoFemale.Checked = False Then
            MessageBox.Show("Please check gender ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        If txtContactNo.Text.Length < 10 Then
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

            'sql connecation for check student id is present or not

            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select StudentID from Student where StudentID=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("Student ID Already Exists !", "Information", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtStudentID.Text = ""
                txtStudentID.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
            Else

                'sql connection for insert a new student record in student table

                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "insert into Student(Photo, RegisterNo, StudentID, StuName, FName, MName, Gender, DoB, Category,Session, CourseCategory, CourseName, CourseFees, ExamFees, Duration, FContactNo, ContactNo, EmailID, CenterCode, AdmissionDate, Remark, Address) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12, @d13, @d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21, @d22)"
                cmd = New SqlCommand(cb)

                Dim ms As New MemoryStream()
                Dim bmpImage As New Bitmap(PIC1.Image)
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@d1", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.Parameters.AddWithValue("@d2", txtregistrationNo.Text)
                cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d4", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d5", txtFatherName.Text)
                cmd.Parameters.AddWithValue("@d6", txtMotherName.Text)
                cmd.Parameters.AddWithValue("@d7", s1)
                cmd.Parameters.AddWithValue("@d8", dtpDoB.Text)
                cmd.Parameters.AddWithValue("@d9", cmbCategory.Text)
                cmd.Parameters.AddWithValue("@d10", cmbSession.Text)
                cmd.Parameters.AddWithValue("@d11", cmbCourseCategory.Text)
                cmd.Parameters.AddWithValue("@d12", cmbCourseName.Text)
                cmd.Parameters.AddWithValue("@d13", lblCourse.Text)
                cmd.Parameters.AddWithValue("@d14", lblExam.Text)
                cmd.Parameters.AddWithValue("@d15", txtDuration.Text)
                cmd.Parameters.AddWithValue("@d16", txtFcontactNo.Text)
                cmd.Parameters.AddWithValue("@d17", txtContactNo.Text)
                cmd.Parameters.AddWithValue("@d18", txtEmailID.Text)
                cmd.Parameters.AddWithValue("@d19", cmbCenterCode.Text)
                cmd.Parameters.AddWithValue("@d20", dtpAdmissionDate.Text)
                cmd.Parameters.AddWithValue("@d21", txtRemark.Text)
                cmd.Parameters.AddWithValue("@d22", txtAddress.Text)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()

                'sql connection for insert a new student record in fullreport table

                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "insert into FullReport(StudentID, StuName, FName, MName, DoB, Mobileno, Course, Session, TotalCouFees, ExamFees, TotalFeesPaid, ALF, ELF, ProjectFees, TotalFees, Discount, Balance) VALUES (@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8, @d9, @d10, @d11, @d12, @d13, @d14, @d15, @d16, @d17)"
                cmd = New SqlCommand(cb1)
                cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d3", txtFatherName.Text)
                cmd.Parameters.AddWithValue("@d4", txtMotherName.Text)
                cmd.Parameters.AddWithValue("@d5", dtpDoB.Text)
                cmd.Parameters.AddWithValue("@d6", txtContactNo.Text)
                cmd.Parameters.AddWithValue("@d7", cmbCourseName.Text)
                cmd.Parameters.AddWithValue("@d8", cmbSession.Text)
                cmd.Parameters.AddWithValue("@d9", lblCourse.Text)
                cmd.Parameters.AddWithValue("@d10", lblExam.Text)
                cmd.Parameters.AddWithValue("@d11", A)
                cmd.Parameters.AddWithValue("@d12", A)
                cmd.Parameters.AddWithValue("@d13", A)
                cmd.Parameters.AddWithValue("@d14", A)
                cmd.Parameters.AddWithValue("@d15", txtTotalFees.Text)
                cmd.Parameters.AddWithValue("@d16", A)
                cmd.Parameters.AddWithValue("@d17", txtTotalFees.Text)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()

                'sql connection for insert a new student record in assignement table

                con = New SqlConnection(cs)
                con.Open()
                Dim cb2 As String = "insert into Assignement(StudentID, Name, Course, Session, Assignement) VALUES (@d1, @d2, @d3, @d4, @d5)"
                cmd = New SqlCommand(cb2)
                cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
                cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
                cmd.Parameters.AddWithValue("@d5", YNC)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()

                'sql connection for insert a new student record in coursematerial table

                con = New SqlConnection(cs)
                con.Open()
                Dim cb3 As String = "insert into CourseMaterial(StudentID, Name, Course, Session, BRFH, BGFC, CenterCode) VALUES (@d1, @d2, @d3, @d4, @d5, @d6, @d7)"
                cmd = New SqlCommand(cb3)
                cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
                cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
                cmd.Parameters.AddWithValue("@d5", YNC)
                cmd.Parameters.AddWithValue("@d6", YNC)
                cmd.Parameters.AddWithValue("@d7", cmbCenterCode.Text)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()

                'sql connection for insert a new student record in examfrom table

                con = New SqlConnection(cs)
                con.Open()
                Dim cb4 As String = "insert into ExamFrom(StudentID, Name, Course, Session, SFC, SFHO) VALUES (@d1, @d2, @d3, @d4, @d5, @d6)"
                cmd = New SqlCommand(cb4)
                cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
                cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
                cmd.Parameters.AddWithValue("@d5", YNC)
                cmd.Parameters.AddWithValue("@d6", YNC)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()

                'sql connection for insert a new student record in result_given table

                con = New SqlConnection(cs)
                con.Open()
                Dim cb5 As String = "insert into Result_Given(StudentID, Name, Course, Session, Given, CenterCode) VALUES (@d1, @d2, @d3, @d4, @d5, @d6)"
                cmd = New SqlCommand(cb5)
                cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
                cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
                cmd.Parameters.AddWithValue("@d5", YNC)
                cmd.Parameters.AddWithValue("@d6", cmbCenterCode.Text)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()

                'sql connection for insert a new student record in result_receive table

                con = New SqlConnection(cs)
                con.Open()
                Dim cb6 As String = "insert into Result_Receive(StudentID, Name, Course, Session, Receive, CenterCode) VALUES (@d1, @d2, @d3, @d4, @d5, @d6)"
                cmd = New SqlCommand(cb6)
                cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d3", cmbCourseName.Text)
                cmd.Parameters.AddWithValue("@d4", cmbSession.Text)
                cmd.Parameters.AddWithValue("@d5", YNC)
                cmd.Parameters.AddWithValue("@d6", cmbCenterCode.Text)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()

                'condition

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Added new student '" & txtStudentName.Text & "' has Student ID '" & txtStudentID.Text & "'")
                    MessageBox.Show("Successfully saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Main Button Section End 

    Private Sub CustomFees_CheckedChanged(sender As Object, e As EventArgs) Handles CustomFees.CheckedChanged
        If CustomFees.Checked = True Then
            txtTotalFees.ReadOnly = False
        Else
            txtTotalFees.ReadOnly = True
        End If
    End Sub

End Class

