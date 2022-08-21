Imports System.Data.SqlClient

Public Class FrmDiscount

    Dim Sum0 As Integer = 0
    Dim Sum1 As Integer = 0
    Dim Zero As Integer = 0

    Private Sub FrmDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
        dtpDate.Text = Today
        txtStudentIDSearch.Focus()
    End Sub

    '---------------- Function section Start ------------------

    Sub Reset()
        txtStudentID.Text = ""
        txtStudentName.Text = ""
        txtCourse.Text = ""
        txtSession.Text = ""
        txtDicount.Text = ""
        dtpDate.Text = System.DateTime.Now
        SaveBtn.Enabled = False
        RefrashBtn.Enabled = True
        GetDatabtn.Enabled = True
        txtStudentIDSearch.Text = ""
        lblBalanceFees.Text = "0"
        lblDisBal.Text = "0"
        Getdata()
    End Sub

    Sub Getdata()
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Discount) As [Discount], RTRIM(Date) As [Date] from Discount"    ' where Session = '" & lblSession.Text & "'
            Dim B As String = "Discount"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--------------- Function section End ------------------

    '----------------- Textbox & Label - Text Change section Start ------------

    Private Sub txtStudentIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStudentIDSearch.TextChanged
        Try
            Dim A As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(Discount) As [Discount], RTRIM(Date) As [Date] from Discount where StudentID like'" & txtStudentIDSearch.Text & "%' order by StudentID"  'and Session = '" & lblSession.Text & "'
            Dim B As String = "Discount"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDicount_TextChanged(sender As Object, e As EventArgs) Handles txtDicount.TextChanged
        If txtDicount.Text <> "" Then
            Dim num1 As Double
            num1 = CDec(Val(lblBalanceFees.Text) - Val(txtDicount.Text))
            num1 = Math.Round(num1, 2)
            lblDisBal.Text = num1
        End If
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        If txtStudentID.Text <> "" Then
            con = New SqlConnection(cs)
            con.Open()
            Dim sum As String = "SELECT Balance As Sum1 from FullReport where StudentID = '" & txtStudentID.Text & "'"
            cmd = New SqlCommand(sum)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Sum1 = 0
                lblBalanceFees.Text = Sum1.ToString
            Else
                Sum1 = cmd.ExecuteScalar
                lblBalanceFees.Text = Sum1.ToString
            End If
            cmd.Dispose()
            con.Close()
        End If
    End Sub

    '--------------- Textbox & Label - Text Change section End -----------------

    '------------- Button section Start ------------------

    Private Sub GetDataBtn_Click(sender As Object, e As EventArgs) Handles GetDatabtn.Click
        FrmStudentRecord1.lblSet.Text = Me.Text
        FrmStudentRecord1.Reset()
        FrmStudentRecord1.ShowDialog()
    End Sub

    Private Sub RefrashBtn_Click(sender As Object, e As EventArgs) Handles RefrashBtn.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If Len(Trim(txtStudentID.Text)) = 0 Then
                MessageBox.Show("Please select Student ID ?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "insert into Discount(StudentID, StuName, Course, Session, Discount, Date) Values(@d1, @d2, @d3, @d4, @d5, @d6)"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d3", txtCourse.Text)
                cmd.Parameters.AddWithValue("@d4", txtSession.Text)
                cmd.Parameters.AddWithValue("@d5", txtDicount.Text)
                cmd.Parameters.AddWithValue("@d6", dtpDate.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                '-------------------------------------------------------------------------------------------------------------------------------------------------------
                If txtDicount.Text <> "" Then
                    con = New SqlConnection(cs)
                    con.Open()
                    Dim cb2 As String = "Update FullReport set Balance = @d1, Discount = @d2 where StudentID = @d3"
                    cmd = New SqlCommand(cb2)
                    cmd.Parameters.AddWithValue("@d1", lblDisBal.Text)
                    cmd.Parameters.AddWithValue("@d2", txtDicount.Text)
                    cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
                    cmd.Connection = con
                    cmd.ExecuteReader()
                    con.Close()
                End If

                '---------------------------------------------------------------------------------------------------------------------------------------------------------

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Discount the student to Student Name '" & txtStudentName.Text & "' has Discount Rs. '" & txtDicount.Text & "'")
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Reset()
                Getdata()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------- Button section End -------------------

    '------------------- DataGridView section Start ----------

    Private Sub dgw_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    '----------------- DataGridView section End -----------------

End Class