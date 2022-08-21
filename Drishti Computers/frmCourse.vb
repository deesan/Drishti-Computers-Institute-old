Imports System.Data.SqlClient
Imports System.IO

Public Class frmCourse

    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        Category()
        txtCourseSearch.Focus()
    End Sub

    '-------------------- function Section Start ------------------

    Sub Reset()
        txtCourseName.Text = ""
        cmbCategory.SelectedIndex = -1
        cmbMode.SelectedIndex = -1
        txtDuration.Text = ""
        txtQualification.Text = ""
        txtFPY.Text = ""
        txtFtime.Text = ""
        txtSTime.Text = ""
        txtExamFees.Text = ""
        NewBtn.Enabled = True
        SaveBtn.Enabled = True
        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False
        txtCourseName.Focus()
        GetData()
        Category()
    End Sub

    Sub Category()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select distinct (Category) From Course_Category", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCategory.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCategory.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub GetData()
        Try
            Dim B As String = "Select RTRIM(CourseName) As [Course Name], RTRIM(Category) As [Course Category], RTRIM(Mode) As [Mode], RTRIM(Duration) As [Duration] , RTRIM(Qualification) As [Qualification], RTRIM(FPYear) As [Total Fees per Year], RTRIM(FTime) As [First Time] , RTRIM(STime) As [Second Time], RTRIM(EFees) As [Exam Fees] from Course_Master order by CourseName"
            Dim C As String = "Course_Master"
            Dim E As New DataGridView
            E = dgw
            Data(B, C, E)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "delete from Course_Master where Coursename = @d1"
            cmd = New SqlCommand(cb1)
            cmd.Parameters.AddWithValue("@d1", txtCourseName.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "delete the Course '" & txtCourseName.Text & "'"
                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, st)
                    MessageBox.Show("Successfully Deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                
                GetData()
                Reset()
            Else
                MessageBox.Show("No Record Found !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '---------------------- Function Section End -----------------

    '---------------------- Textbox - Text Change Section Start ------------------

    Private Sub txtCourseSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCourseSearch.TextChanged
        Try
            Dim A As String = "Select RTRIM(CourseName) As [Course Name], RTRIM(Mode) As [Mode], RTRIM(Duration) As [Duration] , RTRIM(Qualification) As [Qualification], RTRIM(FPYear) As [Total Fees per Year], RTRIM(FTime) As [First Time] , RTRIM(STime) As [Second Time], RTRIM(EFees) As [Exam Fees] from Course_Master where CourseName like '" & txtCourseSearch.Text & "%' order by CourseName"
            Dim D As String = "Course_Master"
            Dim F As New DataGridView
            F = dgw
            Data(A, D, F)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----------------------- Textbox - Text Change Section End ------------------

    '----------------------- Button Section Start ----------------------

    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If Len(Trim(txtCourseName.Text)) = 0 Then
            MessageBox.Show("Please Enter Course Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCourseName.Focus()
            Exit Sub
        End If

        If Len(Trim(cmbCategory.Text)) = 0 Then
            MessageBox.Show("Please Select Course Category ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCourseName.Focus()
            Exit Sub
        End If

        If Len(Trim(cmbMode.Text)) = 0 Then
            MessageBox.Show("Please Select Mode ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMode.Focus()
            Exit Sub
        End If

        If Len(Trim(txtDuration.Text)) = 0 Then
            MessageBox.Show("Please Enter Duration ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDuration.Focus()
            Exit Sub
        End If

        If Len(Trim(txtQualification.Text)) = 0 Then
            MessageBox.Show("Please Enter Qualification ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQualification.Focus()
            Exit Sub
        End If

        If Len(Trim(txtFPY.Text)) = 0 Then
            MessageBox.Show("Please Enter Fees per year ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFPY.Focus()
            Exit Sub
        End If

        If Len(Trim(txtFtime.Text)) = 0 Then
            MessageBox.Show("Please Enter First Time ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFtime.Focus()
            Exit Sub
        End If

        If Len(Trim(txtSTime.Text)) = 0 Then
            MessageBox.Show("Please Enter Second Time ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSTime.Focus()
            Exit Sub
        End If

        If Len(Trim(txtExamFees.Text)) = 0 Then
            MessageBox.Show("Please Enter Exam Fees ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtExamFees.Focus()
            Exit Sub
        End If

        '---------------------------------------------------------------------------------------------------------------------------

        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select CourseName from Course_Master where CourseName = @d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtCourseName.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("Course is Already Exists !", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            con.Close()

            '------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into Course_Master(CourseName, Category, Mode, Duration, Qualification, FPYear, FTime, STime, EFees) values(@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8, @d9)"
            cmd = New SqlCommand(cb1)
            cmd.Parameters.AddWithValue("@d1", txtCourseName.Text)
            cmd.Parameters.AddWithValue("@d2", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@d3", cmbMode.Text)
            cmd.Parameters.AddWithValue("@d4", txtDuration.Text)
            cmd.Parameters.AddWithValue("@d5", txtQualification.Text)
            cmd.Parameters.AddWithValue("@d6", txtFPY.Text)
            cmd.Parameters.AddWithValue("@d7", txtFtime.Text)
            cmd.Parameters.AddWithValue("@d8", txtSTime.Text)
            cmd.Parameters.AddWithValue("@d9", txtExamFees.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            '------------------------------------------------------------------------------------------------------------------------

            Dim st As String = "Added the New Course '" & txtCourseName.Text & "'"

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, st)
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            SaveBtn.Enabled = True
            GetData()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            If Len(Trim(txtCourseName.Text)) = 0 Then
                MessageBox.Show("Unable to Update. Please select Course ?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Len(Trim(txtCourseName.Text)) = 0 Then
                    MessageBox.Show("Please Enter Course Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCourseName.Focus()
                    Exit Sub
                End If

                If Len(Trim(cmbCategory.Text)) = 0 Then
                    MessageBox.Show("Please Select Course Category ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCourseName.Focus()
                    Exit Sub
                End If

                If Len(Trim(cmbMode.Text)) = 0 Then
                    MessageBox.Show("Please Select Mode ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cmbMode.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtDuration.Text)) = 0 Then
                    MessageBox.Show("Please Enter Duration ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtDuration.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtQualification.Text)) = 0 Then
                    MessageBox.Show("Please Enter Qualification ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtQualification.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtFPY.Text)) = 0 Then
                    MessageBox.Show("Please Enter Fees per year ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtFPY.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtFtime.Text)) = 0 Then
                    MessageBox.Show("Please Enter First Time ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtFtime.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtSTime.Text)) = 0 Then
                    MessageBox.Show("Please Enter Second Time ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtSTime.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtExamFees.Text)) = 0 Then
                    MessageBox.Show("Please Enter Exam Fees ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtExamFees.Focus()
                    Exit Sub
                End If

                '--------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb2 As String = "Update Course_Master set CourseName = @d1, Category = @d2, mode = @d3, Duration = @d4, Qualification = @d5, FPYear = @d6, FTime = @d7, STime = @d8, EFees = @d9 where CourseName = @d10"
                cmd = New SqlCommand(cb2)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtCourseName.Text)
                cmd.Parameters.AddWithValue("@d2", cmbCategory.Text)
                cmd.Parameters.AddWithValue("@d3", cmbMode.Text)
                cmd.Parameters.AddWithValue("@d4", txtDuration.Text)
                cmd.Parameters.AddWithValue("@d5", txtQualification.Text)
                cmd.Parameters.AddWithValue("@d6", txtFPY.Text)
                cmd.Parameters.AddWithValue("@d7", txtFtime.Text)
                cmd.Parameters.AddWithValue("@d8", txtSTime.Text)
                cmd.Parameters.AddWithValue("@d9", txtExamFees.Text)
                cmd.Parameters.AddWithValue("@d10", txtCourseNameChange.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                '--------------------------------------------------------------------------------------------------------------------

                Dim st1 As String = "Update the Course Details '" & txtCourseName.Text & "'"

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, st1)
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                SaveBtn.Enabled = False
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
                GetData()
                Reset()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If Len(Trim(txtCourseName.Text)) = 0 Then
                MessageBox.Show("Unable to delete !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MessageBox.Show("Do You really want to delete this Course ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    DeleteRecord()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ManageCCBtn_Click(sender As Object, e As EventArgs) Handles ManageCCBtn.Click
        FrmManageCourseCategory.Reset()
        FrmManageCourseCategory.lblUserID.Text = lblUserID.Text
        FrmManageCourseCategory.lblUserName.Text = lblUserName.Text
        FrmManageCourseCategory.ShowDialog()
    End Sub

    '---------------------- Button Section End ----------------------

    '---------------------- DataGridView Section Start ------------

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim row As DataGridViewRow = dgw.SelectedRows(0)

            txtCourseName.Text = row.Cells(0).Value.ToString
            cmbCategory.Text = row.Cells(1).Value.ToString
            cmbMode.Text = row.Cells(2).Value.ToString
            txtDuration.Text = row.Cells(3).Value.ToString
            txtQualification.Text = row.Cells(4).Value.ToString
            txtFPY.Text = row.Cells(5).Value.ToString
            txtFtime.Text = row.Cells(6).Value.ToString
            txtSTime.Text = row.Cells(7).Value.ToString
            txtExamFees.Text = row.Cells(8).Value.ToString
            txtCourseNameChange.Text = row.Cells(0).Value.ToString
            UpdateBtn.Enabled = True
            DeleteBtn.Enabled = True
            SaveBtn.Enabled = False
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

    '--------------------- DatGridview section End -----------------

End Class