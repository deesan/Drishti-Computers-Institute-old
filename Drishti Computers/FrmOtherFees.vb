Imports System.Data.SqlClient

Public Class FrmOtherFees

    Private Sub FrmLateFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Text = Today
        txtStudentNameSearch.Focus()
    End Sub

    '-------------------- Function Section Start ------------------

    Sub Reset()
        txtStudentID.Text = ""
        txtStudentname.Text = ""
        txtCourse.Text = ""
        txtSession.Text = ""
        txtFees.Text = ""
        txtDetails.Text = ""
        dtpDate.Text = Today
        SaveBtn.Enabled = False
        txtStudentNameSearch.Text = ""
        txtStudentIDSearch.Text = ""
        Getdata()
        FillSession()
        Getdata()
    End Sub

    Sub FillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            'adp.SelectCommand = New SqlCommand("Select Session From Session_Master where id > (select count(*) from Session_master) - 5 order by ID", con)
            adp.SelectCommand = New SqlCommand("Select Session from Session_Master order by ID", con)
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
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Fees) As [Fees], RTRIM(Details) As [Details], RTRIM(Date1) As [Date] from OtherFees"  ' where Session = '" & lblSession.Text & "'
            Dim B As String = "OtherFees"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub otherFeesIDAuto()
        con = New SqlConnection(cs)
        con.Open()
        Dim st As String = "select Count(ID) As ID from OtherFees"
        cmd = New SqlCommand(st)
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("ID").ToString() <> "" Then
            lblotherfeesID.Text = Integer.Parse(rdr("ID").ToString()) + 1
        Else
            lblotherfeesID.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    '------------------------ Function Section End ----------------

    '-------------------- Textbox & Label - Text Change Section Start ----------

    Private Sub txtStudentNameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNameSearch.TextChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Fees) As [Fees], RTRIM(Details) As [Details], RTRIM(Date1) As [Date] from OtherFees where StuName like'" & txtStudentNameSearch.Text & "%' order by StudentID"   ' and Session = '" & lblSession.Text & "'
            Dim B As String = "OtherFees"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStudentIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentIDSearch.TextChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Fees) As [Fees], RTRIM(Details) As [Details], RTRIM(Date1) As [Date] from OtherFees where StudentID like'" & txtStudentIDSearch.Text & "%' order by StudentID"  'and Session = '" & lblSession.Text & "'
            Dim B As String = "OtherFees"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSessionSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSessionSearch.SelectedIndexChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Fees) As [Fees], RTRIM(Details) As [Details], RTRIM(Date1) As [Date] from OtherFees where Session ='" & cmbSessionSearch.Text & "%' order by StudentID"  'and Session = '" & lblSession.Text & "'
            Dim B As String = "OtherFees"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCourseSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCourseSearch.TextChanged
        If txtCourseSearch.Text <> "" Then
            If Len(Trim(cmbSessionSearch.Text)) = 0 Then
                MessageBox.Show("Please select session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbSessionSearch.Focus()
                Exit Sub
            End If
        End If
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Fees) As [Fees], RTRIM(Details) As [Details], RTRIM(Date1) As [Date] from OtherFees where Course like'" & txtCourseSearch.Text & "%' and Session = '" & cmbSessionSearch.Text & "' order by StudentID"  'and Session = '" & lblSession.Text & "'
            Dim B As String = "OtherFees"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFeesDetailsSearch_TextChanged(sender As Object, e As EventArgs) Handles txtFeesDetailsSearch.TextChanged
        If txtFeesDetailsSearch.Text <> "" Then
            If Len(Trim(cmbSessionSearch.Text)) = 0 Then
                MessageBox.Show("Please select session  ? ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbSessionSearch.Focus()
                Exit Sub
            End If
            If txtCourseSearch.Text = "" Then
                MessageBox.Show("Please enter course name  ? ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCourseSearch.Focus()
                Exit Sub
            End If
        End If
        
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Fees) As [Fees], RTRIM(Details) As [Details], RTRIM(Date1) As [Date] from OtherFees where Session = '" & cmbSessionSearch.Text & "' and Course like'" & txtCourseSearch.Text & "%' and Details = '" & txtFeesDetailsSearch.Text & "' order by StudentID"  'and Session = '" & lblSession.Text & "'
            Dim B As String = "OtherFees"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------------ Textbox & Label - Text Change Section End -----------------

    '----------------- Button Section Start ------------------ 

    Private Sub GetDataBtn_Click(sender As Object, e As EventArgs) Handles GetDataBtn.Click
        FrmStudentRecord1.lblSet.Text = Me.Text
        FrmStudentRecord1.Reset()
        FrmStudentRecord1.ShowDialog()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Reset()
        otherFeesIDAuto()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If Len(Trim(txtStudentID.Text)) = 0 Then
                MessageBox.Show("Unable to Save. Please select Student ID ?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "insert into OtherFees(ID, StudentID, StuName, Course, Session, Fees, Details, Date1) Values(@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8)"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", lblotherfeesID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d3", txtStudentname.Text)
                cmd.Parameters.AddWithValue("@d4", txtCourse.Text)
                cmd.Parameters.AddWithValue("@d5", txtSession.Text)
                cmd.Parameters.AddWithValue("@d6", txtFees.Text)
                cmd.Parameters.AddWithValue("@d7", txtDetails.Text)
                cmd.Parameters.AddWithValue("@d8", dtpDate.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                ' Condition

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Added the Late Fees Details '" & txtStudentname.Text & "' has ID '" & txtStudentID.Text & "'")
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Reset()
                Getdata()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-------------------- Button Section End --------------------

    '------------------- DataGridView Section Start -------------

    Private Sub dgw_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    '--------------- DataGridView Section End ----------------
    
End Class