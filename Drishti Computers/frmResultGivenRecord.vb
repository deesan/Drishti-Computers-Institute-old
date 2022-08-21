Imports System.Data.SqlClient

Public Class frmResultGivenRecord

    Private Sub frmResultGivenRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
        FillCenterCode()
        FillSession()
    End Sub

    '------------------ Function Section Start -----------------

    Sub Reset()
        txtStuNameIDCourseSearch.Text = ""
        cmbSessionSearch1.SelectedIndex = -1
        cmbCenterCodeSearch.SelectedIndex = -1
        cmbGiven.SelectedIndex = -1
        Getdata()
        FillCenterCode()
        FillSession()
        txtStuNameIDCourseSearch.Focus()
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
            cmbSessionSearch1.Items.Clear()
            'cmbSessionSearch2.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSessionSearch1.Items.Add(drow(0).ToString())
                'cmbSessionSearch2.Items.Add(drow(0).ToString())
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

    Sub Getdata()
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Given) As [Given] ,RTRIM(Date) As [Date] from Result_Given"   'where Session = '" & lblSession.Text & "'
            Dim B As String = "Result_Given"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--------------- Function Section End ---------------

    '----------------- Textbox, Label & Combobox - Text & Index Change section Start ------------------

    Private Sub txtStudentNameIDCourseSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStuNameIDCourseSearch.TextChanged
        If txtStuNameIDCourseSearch.Text <> "" Then
            Try
                Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Given) As [Given] ,RTRIM(Date) As [Date] from Result_Given where Name like'" & txtStuNameIDCourseSearch.Text & "%' or StudentID like '" & txtStuNameIDCourseSearch.Text & "' or Course like '" & txtStuNameIDCourseSearch.Text & "' order by StudentID"    '  and session = '" & lblSession.Text & "'
                Dim B As String = "Result_Given"
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

    Private Sub cmbSessionSearch1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSessionSearch1.SelectedIndexChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Given) As [Given] ,RTRIM(Date) As [Date] from Result_Given where Session = '" & cmbSessionSearch1.Text & "' order by StudentID"
            Dim B As String = "Result_Given"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbGiven_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGiven.SelectedIndexChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Given) As [Given] ,RTRIM(Date) As [Date] from Result_Given where Given = '" & cmbGiven.Text & "' and Session = '" & lblSession.Text & "' order by StudentID"
            Dim B As String = "Result_Given"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblSession_TextChanged(sender As Object, e As EventArgs) Handles lblSession.TextChanged
        Reset()
    End Sub

    '-------------- Textbox, Label & Combobox - Text & Index Change section End -----------

    '------------- Button Section Start ----------------

    'Search Buttons

    Private Sub SearchBtn1_Click(sender As Object, e As EventArgs) Handles SearchBtn1.Click
        If Len(Trim(txtStuNameIDCourseSearch.Text)) = 0 Then
            MessageBox.Show("Please Enter Course ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStuNameIDCourseSearch.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSessionSearch1.Text)) = 0 Then
            MessageBox.Show("Please Select Session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSessionSearch1.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Given) As [Given] ,RTRIM(Date) As [Date] from Result_Given where Course like'" & txtStuNameIDCourseSearch.Text & "%' and Session = @d1 order by StudentID", con)   'and session = '" & lblSession.Text & "'
            cmd.Parameters.AddWithValue("@d1", cmbSessionSearch1.Text)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Result_Given")
            dgw.DataSource = ds.Tables("Result_Given").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Search2Btn_Click(sender As Object, e As EventArgs) Handles Search2Btn.Click
        If Len(Trim(cmbSessionSearch1.Text)) = 0 Then
            MessageBox.Show("Please Select Session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSessionSearch1.Focus()
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
            cmd = New SqlCommand("Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Given) As [Given] ,RTRIM(Date) As [Date] from Result_Given where Session = @d1 and CenterCode = @d2 order by StudentID", con)
            cmd.Parameters.AddWithValue("@d1", cmbSessionSearch1.Text)
            cmd.Parameters.AddWithValue("@d2", cmbCenterCodeSearch.Text)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Result_Given")
            dgw.DataSource = ds.Tables("Result_Given").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Reset Button

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    '-------------- Button Section End ------------

    '--------------- DataGridView Section Start -------------

    Private Sub dgw_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

End Class