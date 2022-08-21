Imports System.Data.SqlClient

Public Class frmAdmissioncancel1

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Const CS_DROPSHADOW As Integer = 131072

    Private Sub frmAdmissioncancel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpdate.Text = Today
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

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

    ' close section

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Close()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    ' Admission cancel btn

    Private Sub AdmissincancelBtn_Click(sender As Object, e As EventArgs) Handles AdmissincancelBtn.Click
        If Len(Trim(txtStudentID.Text)) = 0 Then
            MessageBox.Show("Please select Student Details to Data Record ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FrmStudentRecord1.ShowDialog()
            Exit Sub
        End If
        If Len(Trim(cmbStatus.Text)) = 0 Then
            MessageBox.Show("Please Select status ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatus.Focus()
            Exit Sub
        End If

        Try
            Dim RowsAffected As Integer = 0
            Dim A As String = "Drop"
            Dim Drop As String = ""

            'New Table Connection for Assignement table to update

            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "Update Assignement set Assignement = @d1 where StudentID = @d2"
            cmd = New SqlCommand(cq)
            cmd.Parameters.AddWithValue("@d1", Drop)
            cmd.Parameters.AddWithValue("@d2", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            'New Table Connection for CourseMaterial table to update

            con = New SqlConnection(cs)
            con.Open()
            Dim cq2 As String = "Update CourseMaterial set BRFH = @d1, BGFC = @d2 where StudentID = @d3"
            cmd = New SqlCommand(cq2)
            cmd.Parameters.AddWithValue("@d1", Drop)
            cmd.Parameters.AddWithValue("@d2", Drop)
            cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            'New Table Connection for ExamFrom table to update

            con = New SqlConnection(cs)
            con.Open()
            Dim cq3 As String = "Update ExamFrom set SFC = @d1, SFHO = @d2 where StudentID = @d3"
            cmd = New SqlCommand(cq3)
            cmd.Parameters.AddWithValue("@d1", Drop)
            cmd.Parameters.AddWithValue("@d2", Drop)
            cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            'New Table Connection for Result_Given table to update

            con = New SqlConnection(cs)
            con.Open()
            Dim cb4 As String = "Update Result_Given set Given = @d1  where StudentID = @d2"
            cmd = New SqlCommand(cb4)
            cmd.Parameters.AddWithValue("@d1", Drop)
            cmd.Parameters.AddWithValue("@d2", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            'New Table Connection for Result_Receive table to update

            con = New SqlConnection(cs)
            con.Open()
            Dim cq5 As String = "Update Result_Receive set Status = @d1, Subject = @d2, Receive = @d3,  NOFM = @d4  where StudentID = @d5"
            cmd = New SqlCommand(cq5)
            cmd.Parameters.AddWithValue("@d1", Drop)
            cmd.Parameters.AddWithValue("@d2", Drop)
            cmd.Parameters.AddWithValue("@d3", Drop)
            cmd.Parameters.AddWithValue("@d4", Drop)
            cmd.Parameters.AddWithValue("@d5", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            'New Table Connection for FullReport table to update

            con = New SqlConnection(cs)
            con.Open()
            Dim cq6 As String = "Update FullReport Set RegistrationNo = @d1 where StudentID = @d2"
            cmd = New SqlCommand(cq6)
            cmd.Parameters.AddWithValue("@d1", A)
            cmd.Parameters.AddWithValue("@d2", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            'New Table Connection for Student table to update

            con = New SqlConnection(cs)
            con.Open()
            Dim cq7 As String = "Update Student Set RegisterNo = @d1 where StudentID = @d2"
            cmd = New SqlCommand(cq7)
            cmd.Parameters.AddWithValue("@d1", A)
            cmd.Parameters.AddWithValue("@d2", txtStudentID.Text)
            cmd.Connection = con
            cmd.ExecuteNonQuery()

            'New Table Connection for Admission_Cancel table to insert record

            con = New SqlConnection(cs)
            con.Open()
            Dim cq8 As String = "insert into Admission_Cancel(StudentID, Name, Course, Session, FeesRefound, Reason, Date, Status) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)"
            cmd = New SqlCommand(cq8)
            cmd.Parameters.AddWithValue("@d1", txtStudentID.Text)
            cmd.Parameters.AddWithValue("@d2", txtStudentName.Text)
            cmd.Parameters.AddWithValue("@d3", txtCourse.Text)
            cmd.Parameters.AddWithValue("@d4", txtSession.Text)
            cmd.Parameters.AddWithValue("@d5", txtFeesRefound.Text)
            cmd.Parameters.AddWithValue("@d6", txtReason.Text)
            cmd.Parameters.AddWithValue("@d7", dtpdate.Text)
            cmd.Parameters.AddWithValue("@d8", cmbStatus.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                If lbluserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lbluserID.Text, lblUserName.Text, "deleted the Student '" & txtStudentName.Text & "'")
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Reset()
            Else
                MessageBox.Show("No record found !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            con.Close()
            If Me.StartPosition = FormStartPosition.CenterParent Then
                Me.Close()
                FrmStudentM.Reset()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class