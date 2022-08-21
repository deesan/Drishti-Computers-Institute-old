Imports System.Data.SqlClient

Public Class frmFeesrecord

    Dim sum0 As Integer = 0
    Dim Sum1 As Integer = 0
    Dim Sum2 As Integer = 0

    Private Sub frmFeesrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Text = Today
        dtpTo.Text = Today
        FillSession()
        Getdata()
        Calculate_Sum_Session_Total()
        calculate_Sum_Session_Receive()
        calculateDue()
    End Sub

    '------------- Function Section Start -------------------

    Sub Reset()
        txtStuNameIDSearch.Text = ""
        txtCourseSearch.Text = ""
        cmbSessionSearch.SelectedIndex = -1
        Getdata()
        FillSession()
        Calculate_Sum_Session_Total()
        calculate_Sum_Session_Receive()
        calculateDue()
    End Sub

    Sub Getdata()
        Try
            Dim A As String = "Select RTRIM(ReciptNo) As [Receipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session],RTRIM(TotalCouFees) As [Course Fees], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [ExamFees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalpaidFees) As [Total Paid], RTRIM(PaymentDue) As [Balance] , RTRIM(UserName) As [User] from FeesPayment where Session = '" & lblSession.Text & "'"
            Dim B As String = "FeesPayment"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            cmbSessionSearch.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSessionSearch.Items.Add(drow(0).ToString())
            Next
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub calculate_Sum_Session_Receive()
        con = New SqlConnection(cs)
        con.Open()
        Dim sum As String = "SELECT Sum(TotalpaidFees) As Sum0 from FeesPayment where Session = '" & lblSession.Text & "'"
        cmd = New SqlCommand(sum)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            sum0 = 0
            lblreceiveFees.Text = sum0.ToString
        Else
            sum0 = cmd.ExecuteScalar
            lblreceiveFees.Text = sum0.ToString
        End If
        con.Close()
    End Sub

    Sub Calculate_Sum_Session_Total()
        con = New SqlConnection(cs)
        con.Open()
        Dim cb1 As String = "SELECT sum(CourseFees) As Sum1 from Student where Session = '" & lblSession.Text & "'"
        cmd = New SqlCommand(cb1)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            Sum1 = 0
            lblCourseFees.Text = Sum1.ToString
        Else
            Sum1 = cmd.ExecuteScalar
            lblCourseFees.Text = Sum1.ToString
        End If
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        con = New SqlConnection(cs)
        con.Open()
        Dim cb2 As String = "SELECT Sum(ExamFees) As Sum2 from Student where Session = '" & lblSession.Text & "'"
        cmd = New SqlCommand(cb2)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            Sum2 = 0
            lblExamFees.Text = Sum2.ToString
        Else
            Sum2 = cmd.ExecuteScalar
            lblExamFees.Text = Sum2.ToString
        End If
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Dim num1 As Double
        num1 = CDec(Val(lblCourseFees.Text) + Val(lblExamFees.Text))
        num1 = Math.Round(num1, 2)
        lblTotalFees.Text = num1

    End Sub

    Sub calculatetotalFees()
        Dim num1 As Double
        num1 = CDec(Val(lblCourseFees.Text) + Val(lblExamFees.Text))
        num1 = Math.Round(num1, 2)
        lblTotalFees.Text = num1
    End Sub

    Sub calculateDue()
        Dim num1 As Double
        num1 = CDec(Val(lblTotalFees.Text) - Val(lblreceiveFees.Text))
        num1 = Math.Round(num1, 2)
        lblDue.Text = num1
    End Sub

    '---------- Function Section End ------------------

    '----------------- Textbox, Label & Combobox - Text & Index Change section Start -------------

    Private Sub txtStuNameIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStuNameIDSearch.TextChanged
        Label10.Visible = True
        Label12.Visible = True
        lblTotalFees.Visible = True
        lblDue.Visible = True
        If txtStuNameIDSearch.Text <> "" Then
            Try
                Dim A As String = "Select RTRIM(ReciptNo) As [Receipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session],RTRIM(TotalCouFees) As [Course Fees], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [ExamFees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalpaidFees) As [Total Paid], RTRIM(PaymentDue) As [Balance] ,RTRIM(UserName) As [User] from FeesPayment where StuName like'" & txtStuNameIDSearch.Text & "%' or StudentID = '" & txtStuNameIDSearch.Text & "' order by StudentID"   ' and Session = '" & lblSession.Text & "'
                Dim B As String = "FeesPayment"
                Dim C As DataGridView
                C = dgw
                Data(A, B, C)

                '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "SELECT Sum(TotalpaidFees) As Sum0 from FeesPayment where StuName like'" & txtStuNameIDSearch.Text & "%' or StudentID = '" & txtStuNameIDSearch.Text & "'"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                If (IsDBNull(cmd.ExecuteScalar)) Then
                    sum0 = 0
                    lblreceiveFees.Text = sum0.ToString
                Else
                    sum0 = cmd.ExecuteScalar
                    lblreceiveFees.Text = sum0.ToString
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()

                '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "SELECT sum(Balance) As Sum1 from FullReport where StuName like'" & txtStuNameIDSearch.Text & "%' or StudentID = '" & txtStuNameIDSearch.Text & "'"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                If (IsDBNull(cmd.ExecuteScalar)) Then
                    Sum1 = 0
                    lblDue.Text = Sum1.ToString
                Else
                    Sum1 = cmd.ExecuteScalar
                    lblDue.Text = Sum1.ToString
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()

                '--------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb2 As String = "SELECT sum(CourseFees) As Sum1 from Student where StuName like'" & txtStuNameIDSearch.Text & "%' or StudentID = '" & txtStuNameIDSearch.Text & "'"
                cmd = New SqlCommand(cb2)
                cmd.Connection = con
                If (IsDBNull(cmd.ExecuteScalar)) Then
                    Sum1 = 0
                    lblCourseFees.Text = Sum1.ToString
                Else
                    Sum1 = cmd.ExecuteScalar
                    lblCourseFees.Text = Sum1.ToString
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb3 As String = "SELECT Sum(ExamFees) As Sum2 from Student where StuName like'" & txtStuNameIDSearch.Text & "%' or StudentID = '" & txtStuNameIDSearch.Text & "'"
                cmd = New SqlCommand(cb3)
                cmd.Connection = con
                If (IsDBNull(cmd.ExecuteScalar)) Then
                    Sum2 = 0
                    lblExamFees.Text = Sum2.ToString
                Else
                    Sum2 = cmd.ExecuteScalar
                    lblExamFees.Text = Sum2.ToString
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()

                '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                Dim num1 As Double
                num1 = CDec(Val(lblCourseFees.Text) + Val(lblExamFees.Text))
                num1 = Math.Round(num1, 2)
                lblTotalFees.Text = num1
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Getdata()
            Calculate_Sum_Session_Total()
            calculate_Sum_Session_Receive()
            calculateDue()
        End If
    End Sub

    Private Sub txtCourseSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCourseSearch.TextChanged
        Label10.Visible = True
        Label12.Visible = True
        lblTotalFees.Visible = True
        lblDue.Visible = True
        If txtCourseSearch.Text <> "" Then
            Try
                Dim A As String = "Select RTRIM(ReciptNo) As [Receipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session],RTRIM(TotalCouFees) As [Course Fees], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [ExamFees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalpaidFees) As [Total Paid], RTRIM(PaymentDue) As [Balance] ,RTRIM(UserName) As [User] from FeesPayment where Course like'" & txtCourseSearch.Text & "%' and Session = '" & lblSession.Text & "' order by StudentID"
                Dim B As String = "FeesPayment"
                Dim C As DataGridView
                C = dgw
                Data(A, B, C)

                '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "SELECT Sum(TotalpaidFees) As Sum0 from FeesPayment where Course like'" & txtCourseSearch.Text & "%'"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                If (IsDBNull(cmd.ExecuteScalar)) Then
                    sum0 = 0
                    lblreceiveFees.Text = sum0.ToString
                Else
                    sum0 = cmd.ExecuteScalar
                    lblreceiveFees.Text = sum0.ToString
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()

                '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "SELECT sum(Balance) As Sum1 from FullReport where Course like'" & txtCourseSearch.Text & "%'"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                If (IsDBNull(cmd.ExecuteScalar)) Then
                    Sum1 = 0
                    lblDue.Text = Sum1.ToString
                Else
                    Sum1 = cmd.ExecuteScalar
                    lblDue.Text = Sum1.ToString
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()

                '--------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb2 As String = "SELECT sum(CourseFees) As Sum1 from Student where CourseName like'" & txtCourseSearch.Text & "%'"
                cmd = New SqlCommand(cb2)
                cmd.Connection = con
                If (IsDBNull(cmd.ExecuteScalar)) Then
                    Sum1 = 0
                    lblCourseFees.Text = Sum1.ToString
                Else
                    Sum1 = cmd.ExecuteScalar
                    lblCourseFees.Text = Sum1.ToString
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                con = New SqlConnection(cs)
                con.Open()
                Dim cb3 As String = "SELECT Sum(ExamFees) As Sum2 from Student where CourseName like'" & txtCourseSearch.Text & "%'"
                cmd = New SqlCommand(cb3)
                cmd.Connection = con
                If (IsDBNull(cmd.ExecuteScalar)) Then
                    Sum2 = 0
                    lblExamFees.Text = Sum2.ToString
                Else
                    Sum2 = cmd.ExecuteScalar
                    lblExamFees.Text = Sum2.ToString
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()

                '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                Dim num1 As Double
                num1 = CDec(Val(lblCourseFees.Text) + Val(lblExamFees.Text))
                num1 = Math.Round(num1, 2)
                lblTotalFees.Text = num1
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Getdata()
            Calculate_Sum_Session_Total()
            calculate_Sum_Session_Receive()
            calculateDue()
        End If
    End Sub

    Private Sub cmbSessionSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSessionSearch.SelectedIndexChanged
        Label10.Visible = True
        Label12.Visible = True
        lblTotalFees.Visible = True
        lblDue.Visible = True
        Try
            Dim A As String = "Select RTRIM(ReciptNo) As [Receipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session],RTRIM(TotalCouFees) As [Course Fees], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [ExamFees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalpaidFees) As [Total Paid], RTRIM(PaymentDue) As [Balance] ,RTRIM(UserName) As [User] from FeesPayment where Session = '" & cmbSessionSearch.Text & "'"
            Dim B As String = "FeesPayment"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "SELECT Sum(TotalpaidFees) As Sum0 from FeesPayment where Session = '" & cmbSessionSearch.Text & "'"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                sum0 = 0
                lblreceiveFees.Text = sum0.ToString
            Else
                sum0 = cmd.ExecuteScalar
                lblreceiveFees.Text = sum0.ToString
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "SELECT sum(Balance) As Sum1 from FullReport where Session = '" & cmbSessionSearch.Text & "'"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Sum1 = 0
                lblDue.Text = Sum1.ToString
            Else
                Sum1 = cmd.ExecuteScalar
                lblDue.Text = Sum1.ToString
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            '--------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb2 As String = "SELECT sum(CourseFees) As Sum1 from Student where Session = '" & cmbSessionSearch.Text & "%'"
            cmd = New SqlCommand(cb2)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Sum1 = 0
                lblCourseFees.Text = Sum1.ToString
            Else
                Sum1 = cmd.ExecuteScalar
                lblCourseFees.Text = Sum1.ToString
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb3 As String = "SELECT Sum(ExamFees) As Sum2 from Student where Session = '" & cmbSessionSearch.Text & "%'"
            cmd = New SqlCommand(cb3)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Sum2 = 0
                lblExamFees.Text = Sum2.ToString
            Else
                Sum2 = cmd.ExecuteScalar
                lblExamFees.Text = Sum2.ToString
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Dim num1 As Double
            num1 = CDec(Val(lblCourseFees.Text) + Val(lblExamFees.Text))
            num1 = Math.Round(num1, 2)
            lblTotalFees.Text = num1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblSession_TextChanged(sender As Object, e As EventArgs) Handles lblSession.TextChanged
        Reset()
        Label10.Visible = True
        Label12.Visible = True
        lblTotalFees.Visible = True
        lblDue.Visible = True
        Getdata()
        Calculate_Sum_Session_Total()
        calculate_Sum_Session_Receive()
        calculateDue()
    End Sub

    '--------------- Textbox, Label & Combobox - Text & Index Change section End ---------------------

    '------------- Button section Start -----------------

    'Reset Button

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
        Label10.Visible = True
        Label12.Visible = True
        lblTotalFees.Visible = True
        lblDue.Visible = True
        Calculate_Sum_Session_Total()
        calculate_Sum_Session_Receive()
        calculateDue()
    End Sub

    'Search Button

    Private Sub SearchBtn1_Click(sender As Object, e As EventArgs) Handles SearchBtn1.Click
        Label10.Visible = True
        Label12.Visible = True
        lblTotalFees.Visible = True
        lblDue.Visible = True
        If Len(Trim(txtCourseSearch.Text)) = 0 Then
            MessageBox.Show("Please Enter Course ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCourseSearch.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbSessionSearch.Text)) = 0 Then
            MessageBox.Show("Please Select Session ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSessionSearch.Focus()
            Exit Sub
        End If

        Label10.Visible = True
        Label12.Visible = True
        lblTotalFees.Visible = True
        lblDue.Visible = True

        Try
            Dim A As String = "Select RTRIM(ReciptNo) As [Receipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session],RTRIM(TotalCouFees) As [Course Fees], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [ExamFees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalpaidFees) As [Total Paid], RTRIM(PaymentDue) As [Balance] ,RTRIM(UserName) As [User] from FeesPayment where Course like'" & txtCourseSearch.Text & "%' and Session = '" & cmbSessionSearch.Text & "' order by StudentID"
            Dim B As String = "FeesPayment"
            Dim C As DataGridView
            C = dgw
            Data(A, B, C)

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "SELECT Sum(TotalpaidFees) As Sum0 from FeesPayment where Course like'" & txtStuNameIDSearch.Text & "%' and Session = '" & cmbSessionSearch.Text & "'"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                sum0 = 0
                lblreceiveFees.Text = sum0.ToString
            Else
                sum0 = cmd.ExecuteScalar
                lblreceiveFees.Text = sum0.ToString
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "SELECT sum(Balance) As Sum1 from FullReport where Course like'" & txtStuNameIDSearch.Text & "%' and Session = '" & cmbSessionSearch.Text & "'"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Sum1 = 0
                lblDue.Text = Sum1.ToString
            Else
                Sum1 = cmd.ExecuteScalar
                lblDue.Text = Sum1.ToString
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            '--------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb2 As String = "SELECT sum(CourseFees) As Sum1 from Student where CourseName like'" & txtCourseSearch.Text & "%' and Session = '" & cmbSessionSearch.Text & "'"
            cmd = New SqlCommand(cb2)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Sum1 = 0
                lblCourseFees.Text = Sum1.ToString
            Else
                Sum1 = cmd.ExecuteScalar
                lblCourseFees.Text = Sum1.ToString
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb3 As String = "SELECT Sum(ExamFees) As Sum2 from Student where CourseName like'" & txtCourseSearch.Text & "%' and Session = '" & cmbSessionSearch.Text & "'"
            cmd = New SqlCommand(cb3)
            cmd.Connection = con
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Sum2 = 0
                lblExamFees.Text = Sum2.ToString
            Else
                Sum2 = cmd.ExecuteScalar
                lblExamFees.Text = Sum2.ToString
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Dim num1 As Double
            num1 = CDec(Val(lblCourseFees.Text) + Val(lblExamFees.Text))
            num1 = Math.Round(num1, 2)
            lblTotalFees.Text = num1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchBtn2_Click(sender As Object, e As EventArgs) Handles SearchBtn2.Click
        Label10.Visible = False
        Label12.Visible = False
        lblTotalFees.Visible = False
        lblDue.Visible = False
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(ReciptNo) As [Receipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session],RTRIM(TotalCouFees) As [Course Fees], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [ExamFees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalpaidFees) As [Total Paid], RTRIM(PaymentDue) As [Balance] , RTRIM(UserName) As [User] from FeesPayment where Date between @d1 and @d2 order by StudentID", con)
            cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpFrom.Value.Date
            cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpTo.Value.Date
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            'dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        con = New SqlConnection(cs)
        con.Open()
        Dim c1 As String = "SELECT Sum(TotalpaidFees) As Sum0 from FeesPayment where Date between @d1 and @d2"
        cmd = New SqlCommand(c1)
        cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpFrom.Value.Date
        cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpTo.Value.Date
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            sum0 = 0
            lblreceiveFees.Text = sum0.ToString
        Else
            sum0 = cmd.ExecuteScalar
            lblreceiveFees.Text = sum0.ToString
        End If
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    '--------------- Button section End --------------------

    '-------------------- DataGridView section Start ------------------

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