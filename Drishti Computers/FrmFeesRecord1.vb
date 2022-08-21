Imports System.Data.SqlClient

Public Class FrmFeesRecord1

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

    Private Sub FeesRecord1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
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

    '----------------- Function Section Start --------------------

    Sub Getdata()
        Try
            Dim A As String = "Select RTRIM(ReciptNo) As [Receipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(FHName) As [F/H Name], RTRIM(MName) As [Mother's Name], RTRIM(MobileNo) As [Mobile No], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [ExamFees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalCouFees) As [Total Fees], RTRIM(TotalpaidFees) As [Total Paid], RTRIM(PaymentDue) As [Balance], RTRIM(UserName) As [User Name] from FeesPayment"
            Dim B As String = "FeesPayment"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--------------- Function Section End --------------------------

    '-------------------- Textbox & Combobox - Text & Index Change Section Start -----------

    Private Sub txtStudentNameIDSearch_TextChanged(sender As Object, e As EventArgs)
        Try
            Dim A As String = "Select RTRIM(ReciptNo) As [Receipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(FHName) As [F/H Name], RTRIM(MName) As [Mother's Name], RTRIM(MobileNo) As [Mobile No], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [ExamFees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalCouFees) As [Total Fees], RTRIM(TotalpaidFees) As [Total Paid], RTRIM(PaymentDue) As [Balance], RTRIM(UserName) As [User Name] from FeesPayment where StuName like'" & txtStudentNameIDSearch.Text & "%' or StudentID like'" & txtStudentNameIDSearch.Text & "%' order by StudentID"
            Dim B As String = "FeesPayment"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------------- Textbox & Combobox - Text & Index Change Section End -----------------

    '---------------- Button Section Start --------------

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        txtStudentNameIDSearch.Text = ""
        Getdata()
        txtStudentNameIDSearch.Focus()
    End Sub

    '--------------- Button Section End ----------------

    '---------------- DataGridView Section Start ----------------

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim row As DataGridViewRow = dgw.SelectedRows(0)

            Me.Hide()
            frmDepositfees.Reset()
            frmDepositfees.txtReciptNo.Text = row.Cells(0).Value.ToString
            frmDepositfees.dtpDate.Text = row.Cells(1).Value.ToString
            frmDepositfees.txtStudentID.Text = row.Cells(2).Value.ToString
            frmDepositfees.txtStudentName.Text = row.Cells(3).Value.ToString
            frmDepositfees.txtFHName.Text = row.Cells(4).Value.ToString
            frmDepositfees.txtMName.Text = row.Cells(5).Value.ToString
            frmDepositfees.txtMobileNo.Text = row.Cells(6).Value.ToString
            frmDepositfees.txtCourse.Text = row.Cells(7).Value.ToString
            frmDepositfees.txtSession.Text = row.Cells(8).Value.ToString
            frmDepositfees.cmbPaymentMode.Text = row.Cells(9).Value.ToString
            frmDepositfees.txtRegoistrationFees.Text = row.Cells(10).Value.ToString
            frmDepositfees.txtProspectusFees.Text = row.Cells(11).Value.ToString
            frmDepositfees.txtTuitionfees.Text = row.Cells(12).Value.ToString
            frmDepositfees.txtExamfees.Text = row.Cells(13).Value.ToString
            frmDepositfees.txtOtherFees.Text = row.Cells(14).Value.ToString
            frmDepositfees.txtOtherfeesDetails.Text = row.Cells(15).Value.ToString
            frmDepositfees.txtPreviousTotalFees.Text = row.Cells(16).Value.ToString
            frmDepositfees.txtTCfees.Text = row.Cells(17).Value.ToString
            frmDepositfees.txtTotalPaid.Text = row.Cells(18).Value.ToString
            frmDepositfees.txtPreviousDue.Text = row.Cells(19).Value.ToString
            frmDepositfees.txtBalance.Text = row.Cells(19).Value.ToString
            frmDepositfees.printBtn.Enabled = True
            frmDepositfees.UpdateBtn.Enabled = True
            frmDepositfees.SaveBtn.Enabled = False
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

    '---------------- DataGridView Section Start ----------------

    'Close Picture Section

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Close()
    End Sub

End Class