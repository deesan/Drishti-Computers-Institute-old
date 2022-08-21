Imports System.Data.SqlClient

Public Class FrmResultReceiveRecord

    Private Sub FrmResultReceiveRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
        FillSession()
        FillCenterCode()
    End Sub

    '----------------- Function Section Start -----------------

    Sub Reset()
        txtStuNameIDCourseSearch.Text = ""
        cmbSessionSearch1.SelectedIndex = -1
        cmbCenterCodeSearch.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
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
            For Each drow As DataRow In dtable.Rows
                cmbSessionSearch1.Items.Add(drow(0).ToString())
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
            Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Status) As [Status], RTRIM(Subject) As [BackLog], RTRIM(Receive) As [Receive], RTRIM(NOFM) As [No. of Marksheet], RTRIM(Date) As [Date] from Result_Receive"    ' where Session = '" & lblSession.Text & "'
            Dim B As String = "Result_Receive"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----------------- Function Section End ----------------

    '------------------ Textbox, Label & Combobox - Text & Index Change section Start --------------

    Private Sub txtStuNameIDCourseSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStuNameIDCourseSearch.TextChanged
        If txtStuNameIDCourseSearch.Text <> "" Then
            Try
                Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Status) As [Status], RTRIM(Subject) As [BackLog], RTRIM(Receive) As [Receive], RTRIM(NOFM) As [No. of Marksheet], RTRIM(Date) As [Date] from Result_Receive where Name like'" & txtStuNameIDCourseSearch.Text & "%' or StudentID like '" & txtStuNameIDCourseSearch.Text & "' or Course like '" & txtStuNameIDCourseSearch.Text & "' order by StudentID"  'and Session = '" & lblSession.Text & "'
                Dim B As String = "Result_Receive"
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
            Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Status) As [Status], RTRIM(Subject) As [BackLog], RTRIM(Receive) As [Receive], RTRIM(NOFM) As [No. of Marksheet], RTRIM(Date) As [Date] from Result_Receive where Session = '" & cmbSessionSearch1.Text & "' order by StudentID"
            Dim B As String = "Result_Receive"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Status) As [Status], RTRIM(Subject) As [BackLog], RTRIM(Receive) As [Receive], RTRIM(NOFM) As [No. of Marksheet], RTRIM(Date) As [Date] from Result_Receive where Status = '" & cmbStatus.Text & "' and Session = '" & lblSession.Text & "' order by StudentID"
            Dim B As String = "ResultReceive"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbReceive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReceive.SelectedIndexChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Status) As [Status], RTRIM(Subject) As [BackLog], RTRIM(Receive) As [Receive], RTRIM(NOFM) As [No. of Marksheet], RTRIM(Date) As [Date] from Result_Receive where Receive = '" & cmbReceive.Text & "' and Session = '" & lblSession.Text & "' order by StudentID"
            Dim B As String = "Result_Receive"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblSession_TextChanged(sender As Object, e As EventArgs) Handles lblSession.TextChanged
        Reset()
        Getdata()
    End Sub

    '------------ Textbox, Label & Combobox - Text & Index Change section End -------------

    '------------- Button Section Start ------------------

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
            cmd = New SqlCommand("Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Status) As [Status], RTRIM(Subject) As [BackLog], RTRIM(Receive) As [Receive], RTRIM(NOFM) As [No. of Marksheet], RTRIM(Date) As [Date] from Result_Receive where Course like '" & txtStuNameIDCourseSearch.Text & "' and Session = @d1 order by StudentID", con)
            cmd.Parameters.AddWithValue("@d1", cmbSessionSearch1.Text)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Result_Receive")
            dgw.DataSource = ds.Tables("Result_Receive").DefaultView
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
            cmd = New SqlCommand("Select RTRIM(StudentID) As [Student ID],RTRIM(Name) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Status) As [Status], RTRIM(Subject) As [BackLog], RTRIM(Receive) As [Receive], RTRIM(NOFM) As [No. of Marksheet], RTRIM(Date) As [Date] from Result_Receive where Session = @d1 and CenterCode = @d2 order by StudentID", con)
            cmd.Parameters.AddWithValue("@d1", cmbSessionSearch1.Text)
            cmd.Parameters.AddWithValue("@d2", cmbCenterCodeSearch.Text)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "Result_Receive")
            dgw.DataSource = ds.Tables("Result_Receive").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    '-------------- Button Section End --------------

    '------------ DataGridView Section End -----------

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