Imports System.Data.SqlClient

Public Class frmDepositfees

    Private Sub frmDepositfees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DrishtiDataSet.FeesPayment' table. You can move, or remove it, as needed.
        ReciptNo_Auto()

        'If lblusertype.Text = "Admin" Then
        '    UpdateBtn.Visible = True
        '    GetDataBtn.Location = New Point(890, 274)
        '    printBtn.Location = New Point(890, 274)
        'End If
        dtpDate.Text = System.DateTime.Now

        If txtStudentID.Text = "" Then
            Me.AcceptButton = SearchBtn
        Else
            Me.AcceptButton = SaveBtn
        End If
    End Sub

    '------------------ Function Section Start -------------------

    ' Reset All field value as by default 

    Sub Reset()
        txtStudentIDSearch.Text = ""
        txtStudentID.Text = ""
        txtStudentName.Text = ""
        txtFHName.Text = ""
        txtMName.Text = ""
        txtMobileNo.Text = ""
        txtCourse.Text = ""
        txtSession.Text = ""
        txtTCfees.Text = ""
        cmbPaymentMode.SelectedIndex = -1
        txtRegoistrationFees.Text = ""
        txtProspectusFees.Text = ""
        txtTuitionfees.Text = ""
        txtExamfees.Text = ""
        txtOtherFees.Text = ""
        txtOtherfeesDetails.Text = ""
        txtPreviousDue.Text = ""
        txtPreviousTotalFees.Text = ""
        txtTotalPaid.Text = ""
        txtBalance.Text = ""
        txtGrandTotal.Text = ""
        SaveBtn.Enabled = True
        UpdateBtn.Enabled = False
        printBtn.Enabled = False
        GetDataBtn.Enabled = True
        dtpDate.Text = System.DateTime.Now

        txtStudentIDSearch.Focus()

        ReciptNo_Auto()
        OtherFeesIDAuto()
    End Sub  ' Down

    ' other fees table id Ganarator

    Sub OtherFeesIDAuto()
        con = New SqlConnection(cs)
        con.Open()
        Dim st As String = "select Count(ID) As ID from OtherFees"
        cmd = New SqlCommand(st)
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("ID").ToString() <> "" Then
            lblOtherfeesID.Text = Integer.Parse(rdr("ID").ToString()) + 1
        Else
            lblOtherfeesID.Text = 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub  ' Down

    ' Recipt No Ganarator

    Sub ReciptNo_Auto()
        con = New SqlConnection(cs)
        con.Open()
        Dim st As String = "select Count(ReciptNo) As SID from FeesPayment"
        cmd = New SqlCommand(st)
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("SID").ToString() <> "" Then
            txtReciptNo.Text = "R" & Integer.Parse(rdr("SID").ToString()) + 1
        Else
            txtReciptNo.Text = "R" & 1
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub  ' Down

    ' Calculate Previous total paid of Student

    Sub Calculate_Previous_Total_Paid()
        con = New SqlConnection(cs)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = "SELECT TotalFeesPaid from FullReport where StudentID=@d1"
        cmd.Parameters.AddWithValue("@d1", txtStudentIDSearch.Text)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtPreviousTotalFees.Text = rdr.GetValue(0)
        Else
            txtPreviousTotalFees.Text = 0
        End If
        If (rdr IsNot Nothing) Then
            rdr.Close()
        End If
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub  ' Down

    ' Calculate Previous balance of Student

    Sub Previous_Due()
        con = New SqlConnection(cs)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = "SELECT Balance from FullReport where StudentID=@d1"
        cmd.Parameters.AddWithValue("@d1", txtStudentIDSearch.Text)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtPreviousDue.Text = rdr.GetValue(0)
        Else
            txtPreviousDue.Text = 0
        End If
        If (rdr IsNot Nothing) Then
            rdr.Close()
        End If
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub  ' Down

    ' Calculate all fees field at a time when enter any fees 

    Sub Calculate_All()
        Dim num1 As Double
        num1 = CDec(Val(txtRegoistrationFees.Text) + Val(txtProspectusFees.Text) + Val(txtTuitionfees.Text) + Val(txtExamfees.Text) + Val(txtOtherFees.Text))
        num1 = Math.Round(num1, 2)
        txtTotalPaid.Text = num1
    End Sub  ' Down

    ' Calculate balance at a time when enter the fees

    Sub Calculate_Balance()
        Dim num1 As Double
        num1 = CDec(Val(txtPreviousDue.Text) - Val(txtTotalPaid.Text))
        num1 = Math.Round(num1, 2)
        txtBalance.Text = num1
    End Sub  ' Down

    ' Print the Recipt

    Sub Print()
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New Feesrecipt 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "Select FeesPayment.ReciptNo, FeesPayment.Date, FeesPayment.StudentID, FeesPayment.StuName, FeesPayment.FHName, FeesPayment.MName, FeesPayment.MobileNo, FeesPayment.Course, FeesPayment.Session, FeesPayment.TotalCouFees, FeesPayment.PaymentMode, FeesPayment.RegistrationFees, FeesPayment.ProspectusFees, FeesPayment.TuitionFees, FeesPayment.ExamFees, FeesPayment.OtherFees, FeesPayment.OtherFeesDetails, FeesPayment.GrandTotalPaid, FeesPayment.TotalpaidFees, FeesPayment.PaymentDue, FeesPayment.UserName from FeesPayment where FeesPayment.ReciptNo = '" & txtReciptNo.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "FeesPayment")
            rpt.SetDataSource(myDS)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Arrow
        End Try

    End Sub  ' Down

    '------------------ Function Section End -----------------

    '----------------- Textbox - Text Change Section Start--------------

    Private Sub cmbPaymentMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMode.SelectedIndexChanged
        If cmbPaymentMode.Text = "By Online" Then
            cmbOOptions.Enabled = True
        Else
            cmbOOptions.SelectedIndex = -1
            cmbOOptions.Enabled = False
        End If
    End Sub

    ' Down

    Private Sub txtRegoistrationFees_TextChanged(sender As Object, e As EventArgs) Handles txtRegoistrationFees.TextChanged
        Calculate_All()
    End Sub

    ' Down

    Private Sub txtProspectusFees_TextChanged(sender As Object, e As EventArgs) Handles txtProspectusFees.TextChanged
        Calculate_All()
    End Sub

    ' Down

    Private Sub txtTuitionfees_TextChanged(sender As Object, e As EventArgs) Handles txtTuitionfees.TextChanged
        Calculate_All()
    End Sub

    ' Down

    Private Sub txtExamfees_TextChanged(sender As Object, e As EventArgs) Handles txtExamfees.TextChanged
        Calculate_All()
    End Sub

    Private Sub txtOtherFees_TextChanged(sender As Object, e As EventArgs) Handles txtOtherFees.TextChanged
        Calculate_All()
    End Sub

    Private Sub txtOtherfeesDetails_TextChanged(sender As Object, e As EventArgs) Handles txtOtherfeesDetails.TextChanged
        If txtOtherfeesDetails.Text = "alf" Or txtOtherfeesDetails.Text = "ALF" Or txtOtherfeesDetails.Text = "elf" Or txtOtherfeesDetails.Text = "ELF" Or txtOtherfeesDetails.Text = "Project Fee" Or txtOtherfeesDetails.Text = "project fees" Then
            Dim num1 As Double
            num1 = CDec(Val(txtTCfees.Text) + Val(txtOtherFees.Text))
            num1 = Math.Round(num1, 2)
            txtTCfees.Text = num1

            Dim num2 As Double
            num2 = CDec(Val(txtPreviousDue.Text) + Val(txtOtherFees.Text))
            num2 = Math.Round(num2, 2)
            txtPreviousDue.Text = num2
        Else
            txtBalance.Text = "0"
        End If
    End Sub

    Private Sub txtTotalPaid_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPaid.TextChanged
        Dim num1 As Double
        num1 = CDec(Val(txtPreviousTotalFees.Text) + Val(txtTotalPaid.Text))
        num1 = Math.Round(num1, 2)
        txtGrandTotal.Text = num1

        Calculate_Balance()
    End Sub

    Private Sub txtPreviousDue_TextChanged(sender As Object, e As EventArgs) Handles txtPreviousDue.TextChanged
        Calculate_Balance()
    End Sub

    '----------------- Textbox - Text Change Section Start--------------------

    '---------------- Button Section Start ------------------

    'Search Button

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select StudentID, StuName, FName, MName, Course, Session, MobileNo, TotalFees from FullReport where StudentID = '" & txtStudentIDSearch.Text & "'", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = New DataTable
            dtable = ds.Tables(0)

            txtStudentID.Text = dtable.Rows(0)("StudentID").ToString
            txtStudentName.Text = dtable.Rows(0)("StuName").ToString
            txtFHName.Text = dtable.Rows(0)("FName").ToString
            txtMName.Text = dtable.Rows(0)("MName").ToString
            txtCourse.Text = dtable.Rows(0)("Course").ToString
            txtSession.Text = dtable.Rows(0)("Session").ToString
            txtMobileNo.Text = dtable.Rows(0)("MobileNo").ToString
            txtTCfees.Text = dtable.Rows(0)("TotalFees").ToString

            Previous_Due()
            Calculate_Previous_Total_Paid()
            SaveBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Main Buttons

    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If Len(Trim(txtStudentID.Text)) = 0 Then
            MessageBox.Show("Please Retrieve student info ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentIDSearch.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbPaymentMode.Text)) = 0 Then
            MessageBox.Show("Please Select Payment Mode ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPaymentMode.Focus()
            Exit Sub
        End If
        If cmbPaymentMode.Text = "By Online" And Len(Trim(cmbOOptions.Text)) = 0 Then
            MessageBox.Show("Please Select Payment Options ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbOOptions.Focus()
            Exit Sub
        End If
        If txtTotalPaid.Text = "0" Then
            MessageBox.Show("Please Enter Fees ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRegoistrationFees.Focus()
            Exit Sub
        End If
        If txtOtherFees.Text <> "" Then
            If Len(Trim(txtOtherfeesDetails.Text)) = 0 Then
                MessageBox.Show("Please Enter Other Fees Details.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtOtherfeesDetails.Focus()
                Exit Sub
            End If
        End If

        Try

            ' new sql connection for FeesPayment table --- insert fees details in particular student

            If txtBalance.Text = "0" Then     ' if balance is equal to  0 then balance is equal to previous Due.
                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "insert into FeesPayment(ReciptNo, Date, StudentID, StuName, FHName, MName, MobileNo, Course, Session, PaymentMode, Options, RegistrationFees, ProspectusFees, TuitionFees, ExamFees, OtherFees, OtherFeesDetails, GrandTotalPaid, TotalCouFees, TotalpaidFees, PaymentDue, UserName) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19, @d20, @d21, @d22)"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtReciptNo.Text)
                cmd.Parameters.AddWithValue("@d2", dtpDate.Text)
                cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d4", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d5", txtFHName.Text)
                cmd.Parameters.AddWithValue("@d6", txtMName.Text)
                cmd.Parameters.AddWithValue("@d7", txtMobileNo.Text)
                cmd.Parameters.AddWithValue("@d8", txtCourse.Text)
                cmd.Parameters.AddWithValue("@d9", txtSession.Text)
                cmd.Parameters.AddWithValue("@d10", cmbPaymentMode.Text)
                cmd.Parameters.AddWithValue("@d11", cmbOOptions.Text)
                cmd.Parameters.AddWithValue("@d12", txtRegoistrationFees.Text)
                cmd.Parameters.AddWithValue("@d13", txtProspectusFees.Text)
                cmd.Parameters.AddWithValue("@d14", txtTuitionfees.Text)
                cmd.Parameters.AddWithValue("@d15", txtExamfees.Text)
                cmd.Parameters.AddWithValue("@d16", txtOtherFees.Text)
                cmd.Parameters.AddWithValue("@d17", txtOtherfeesDetails.Text)
                cmd.Parameters.AddWithValue("@d18", txtBalance.Text)
                cmd.Parameters.AddWithValue("@d19", txtBalance.Text)
                cmd.Parameters.AddWithValue("@d20", txtTotalPaid.Text)
                cmd.Parameters.AddWithValue("@d21", txtBalance.Text)
                cmd.Parameters.AddWithValue("@d22", lblUserName.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else                                        ' if balance is not to equal in 0 then balance is equal to calculate new balance depend on fees.
                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "insert into FeesPayment(ReciptNo, Date, StudentID, StuName, FHName, MName, MobileNo, Course, Session, PaymentMode, Options, RegistrationFees, ProspectusFees, TuitionFees, ExamFees, OtherFees, OtherFeesDetails, GrandTotalPaid, TotalCouFees, TotalpaidFees, PaymentDue, UserName) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19, @d20, @d21, @d22)"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtReciptNo.Text)
                cmd.Parameters.AddWithValue("@d2", dtpDate.Text)
                cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d4", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d5", txtFHName.Text)
                cmd.Parameters.AddWithValue("@d6", txtMName.Text)
                cmd.Parameters.AddWithValue("@d7", txtMobileNo.Text)
                cmd.Parameters.AddWithValue("@d8", txtCourse.Text)
                cmd.Parameters.AddWithValue("@d9", txtSession.Text)
                cmd.Parameters.AddWithValue("@d10", cmbPaymentMode.Text)
                cmd.Parameters.AddWithValue("@d11", cmbOOptions.Text)
                cmd.Parameters.AddWithValue("@d12", txtRegoistrationFees.Text)
                cmd.Parameters.AddWithValue("@d13", txtProspectusFees.Text)
                cmd.Parameters.AddWithValue("@d14", txtTuitionfees.Text)
                cmd.Parameters.AddWithValue("@d15", txtExamfees.Text)
                cmd.Parameters.AddWithValue("@d16", txtOtherFees.Text)
                cmd.Parameters.AddWithValue("@d17", txtOtherfeesDetails.Text)
                cmd.Parameters.AddWithValue("@d18", txtGrandTotal.Text)
                cmd.Parameters.AddWithValue("@d19", txtTCfees.Text)
                cmd.Parameters.AddWithValue("@d20", txtTotalPaid.Text)
                cmd.Parameters.AddWithValue("@d21", txtBalance.Text)
                cmd.Parameters.AddWithValue("@d22", lblUserName.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            End If


            ' new sql connection for fullreport table --- update fees details in particular student
            ' if the balane is equal to 0 then update totalfeespaid, totalfees, balance on particular student id. if balance is not equal to 0 then do not update datafield.

            If txtBalance.Text <> "0" Then
                con = New SqlConnection(cs)
                con.Open()
                Dim cb3 As String = "Update FullReport set TotalFeesPaid = @d1, TotalFees = @d2, Balance = @d3 where StudentID = @d4"
                cmd = New SqlCommand(cb3)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtGrandTotal.Text)
                cmd.Parameters.AddWithValue("@d2", txtTCfees.Text)
                cmd.Parameters.AddWithValue("@d3", txtBalance.Text)
                cmd.Parameters.AddWithValue("@d4", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            End If

            ' new sql connection for fullreport - update 

            ' if otherfeesdetails is ALF then update ALF, TotalFees in calculated fees depend on fees
            If txtOtherfeesDetails.Text = "Addmissin Late Fees" Or txtOtherfeesDetails.Text = "ALF" Or txtOtherfeesDetails.Text = "admission late fees" Or txtOtherfeesDetails.Text = "alf" Then
                con = New SqlConnection(cs)
                con.Open()
                Dim cb5 As String = "Update FullReport set   ALF = @d2 where StudentID = @d4"
                cmd = New SqlCommand(cb5)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d2", txtOtherFees.Text)
                cmd.Parameters.AddWithValue("@d4", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                ' if otherfeesdetails is ALF then update ELF, TotalFees in calculated fees depend on fees
            ElseIf txtOtherfeesDetails.Text = "Exam Late Fees" Or txtOtherfeesDetails.Text = "ELF" Or txtOtherfeesDetails.Text = "exam late fees" Or txtOtherfeesDetails.Text = "elf" Then
                con = New SqlConnection(cs)
                con.Open()
                Dim cb6 As String = "Update FullReport set  ELF = @d2 where StudentID = @d4"
                cmd = New SqlCommand(cb6)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d2", txtOtherFees.Text)
                cmd.Parameters.AddWithValue("@d4", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                ' if otherfeesdetails is ALF then update ProjectFees, TotalFees in calculated fees depend on fees
            ElseIf txtOtherfeesDetails.Text = "Project Fee" Or txtOtherfeesDetails.Text = "project fees" Then
                con = New SqlConnection(cs)
                con.Open()
                Dim cb7 As String = "Update FullReport set  ProjectFees = @d2 where StudentID = @d4"
                cmd = New SqlCommand(cb7)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d2", txtOtherFees.Text)
                cmd.Parameters.AddWithValue("@d4", txtStudentID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            End If

            ' new sql connection for otherfees table - insert other fees in particular student

            If txtBalance.Text = "0" Then     ' insert into a new record in other fees table
                con = New SqlConnection(cs)
                con.Open()
                Dim cb4 As String = "insert into OtherFees(ID, StudentID, StuName, Course, Session, Fees, Details, Date1) values(@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8)"
                cmd = New SqlCommand(cb4)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", lblOtherfeesID.Text)
                cmd.Parameters.AddWithValue("@d2", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@d3", txtStudentName.Text)
                cmd.Parameters.AddWithValue("@d4", txtCourse.Text)
                cmd.Parameters.AddWithValue("@d5", txtSession.Text)
                cmd.Parameters.AddWithValue("@d6", txtOtherFees.Text)
                cmd.Parameters.AddWithValue("@d7", txtOtherfeesDetails.Text)
                cmd.Parameters.AddWithValue("@d8", dtpDate.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            End If

            ' Message the successfully paid

            Dim st As String = "Take the fees of Rs. '" & txtTotalPaid.Text & "' on Recipt No. '" & txtReciptNo.Text & "'"

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully paid.", "Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, st)
                MessageBox.Show("Successfully paid.", "Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            SaveBtn.Enabled = False
            con.Close()
            Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GetDataBtn_Click(sender As Object, e As EventArgs) Handles GetDataBtn.Click
        FrmFeesRecord1.ShowDialog()
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        Print()
    End Sub

    'Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click

    '    If Len(Trim(txtStudentID.Text)) = 0 Then
    '        MessageBox.Show("Please Retrieve student info ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtStudentIDSearch.Focus()
    '        Exit Sub
    '    End If

    '    If Len(Trim(cmbPaymentMode.Text)) = 0 Then
    '        MessageBox.Show("Please Select Payment Mode ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        cmbPaymentMode.Focus()
    '        Exit Sub
    '    End If

    '    If cmbPaymentMode.Text = "By Online" And Len(Trim(cmbOOptions.Text)) = 0 Then
    '        MessageBox.Show("Please Select Payment Options ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        cmbOOptions.Focus()
    '        Exit Sub
    '    End If

    '    If txtTotalPaid.Text = "0" Then
    '        MessageBox.Show("Please Enter Fees ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtRegoistrationFees.Focus()
    '        Exit Sub
    '    End If

    '    If txtOtherFees.Text <> "" Then
    '        If Len(Trim(txtOtherfeesDetails.Text)) = 0 Then
    '            MessageBox.Show("Please Enter Other Fees Details.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            txtOtherfeesDetails.Focus()
    '            Exit Sub
    '        End If
    '    End If


    '    Try

    '        ' new sql connection for FeesPayment table --- Update fees details in particular student

    '        If txtBalance.Text = "0" Then     ' if balance is equal to  0 then balance is equal to previous Due.
    '            con = New SqlConnection(cs)
    '            con.Open()
    '            Dim cb As String = "Update FeesPayment set Date = @d2, PaymentMode = @d3, RegistrationFees = @d4, ProspectusFees = @d5, TuitionFees = @d6, ExamFees = @d7, OtherFees = @d8, OtherFeesDetails = @d9, GrandTotalPaid = @d10, TotalCouFees = 11, TotalpaidFees = @d12, PaymentDue = @d13, UserName = @d14 where ReciptNo = @d1"
    '            cmd = New SqlCommand(cb)
    '            cmd.Connection = con
    '            cmd.Parameters.AddWithValue("@d1", txtReciptNo.Text)
    '            cmd.Parameters.AddWithValue("@d2", dtpDate.Text)
    '            cmd.Parameters.AddWithValue("@d3", cmbPaymentMode.Text)
    '            cmd.Parameters.AddWithValue("@d4", txtRegoistrationFees.Text)
    '            cmd.Parameters.AddWithValue("@d5", txtProspectusFees.Text)
    '            cmd.Parameters.AddWithValue("@d6", txtTuitionfees.Text)
    '            cmd.Parameters.AddWithValue("@d7", txtExamfees.Text)
    '            cmd.Parameters.AddWithValue("@d8", txtOtherFees.Text)
    '            cmd.Parameters.AddWithValue("@d9", txtOtherfeesDetails.Text)
    '            cmd.Parameters.AddWithValue("@d10", txtBalance.Text)
    '            cmd.Parameters.AddWithValue("@d11", txtBalance.Text)
    '            cmd.Parameters.AddWithValue("@d12", txtTotalPaid.Text)
    '            cmd.Parameters.AddWithValue("@d13", txtBalance.Text)
    '            cmd.Parameters.AddWithValue("@d14", lblUserName.Text)
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '        Else                                        ' if balance is not to equal in 0 then balance is equal to calculate new balance depend on fees.
    '            con = New SqlConnection(cs)
    '            con.Open()
    '            Dim cb As String = "Update FeesPayment set Date = @d2, PaymentMode = @d3, RegistrationFees = @d4, ProspectusFees = @d5, TuitionFees = @d6, ExamFees = @d7, OtherFees = @d8, OtherFeesDetails = @d9, GrandTotalPaid = @d10, TotalCouFees = @d11, TotalpaidFees = @d12, PaymentDue = @d13, UserName = @d14 where ReciptNo = @d1"
    '            cmd = New SqlCommand(cb)
    '            cmd.Connection = con
    '            cmd.Parameters.AddWithValue("@d1", txtReciptNo.Text)
    '            cmd.Parameters.AddWithValue("@d2", dtpDate.Text)
    '            cmd.Parameters.AddWithValue("@d3", cmbPaymentMode.Text)
    '            cmd.Parameters.AddWithValue("@d4", txtRegoistrationFees.Text)
    '            cmd.Parameters.AddWithValue("@d5", txtProspectusFees.Text)
    '            cmd.Parameters.AddWithValue("@d6", txtTuitionfees.Text)
    '            cmd.Parameters.AddWithValue("@d7", txtExamfees.Text)
    '            cmd.Parameters.AddWithValue("@d8", txtOtherFees.Text)
    '            cmd.Parameters.AddWithValue("@d9", txtOtherfeesDetails.Text)
    '            cmd.Parameters.AddWithValue("@d10", txtGrandTotal.Text)
    '            cmd.Parameters.AddWithValue("@d11", txtTCfees.Text)
    '            cmd.Parameters.AddWithValue("@d12", txtTotalPaid.Text)
    '            cmd.Parameters.AddWithValue("@d13", txtBalance.Text)
    '            cmd.Parameters.AddWithValue("@d14", lblUserName.Text)
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '        End If


    '        ' new sql connection for fullreport table --- update fees details in particular student
    '        ' if the balane is equal to 0 then update totalfeespaid, totalfees, balance on particular student id. if balance is not equal to 0 then do not update datafield.

    '        If txtBalance.Text <> "0" Then
    '            con = New SqlConnection(cs)
    '            con.Open()
    '            Dim cb3 As String = "Update FullReport set TotalFeesPaid = @d1, TotalFees = @d2, Balance = @d3 where StudentID = @d4"
    '            cmd = New SqlCommand(cb3)
    '            cmd.Connection = con
    '            cmd.Parameters.AddWithValue("@d1", txtGrandTotal.Text)
    '            cmd.Parameters.AddWithValue("@d2", txtTCfees.Text)
    '            cmd.Parameters.AddWithValue("@d3", txtBalance.Text)
    '            cmd.Parameters.AddWithValue("@d4", txtStudentID.Text)
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '        End If



    '        ' new sql connection for fullreport - update 

    '        ' if otherfeesdetails is ALF then update ALF, TotalFees in calculated fees depend on fees
    '        If txtOtherfeesDetails.Text = "Addmissin Late Fees" Or txtOtherfeesDetails.Text = "ALF" Or txtOtherfeesDetails.Text = "admission late fees" Or txtOtherfeesDetails.Text = "alf" Then
    '            con = New SqlConnection(cs)
    '            con.Open()
    '            Dim cb2 As String = "Update FullReport set ALF = @d1 where StudentID = @d3"
    '            cmd = New SqlCommand(cb2)
    '            cmd.Connection = con
    '            cmd.Parameters.AddWithValue("@d1", txtOtherFees.Text)
    '            cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '            ' if otherfeesdetails is ALF then update ELF, TotalFees in calculated fees depend on fees
    '        ElseIf txtOtherfeesDetails.Text = "Exam Late Fees" Or txtOtherfeesDetails.Text = "ELF" Or txtOtherfeesDetails.Text = "exam late fees" Or txtOtherfeesDetails.Text = "elf" Then
    '            con = New SqlConnection(cs)
    '            con.Open()
    '            Dim cb2 As String = "Update FullReport set ELF = @d1 where StudentID = @d3"
    '            cmd = New SqlCommand(cb2)
    '            cmd.Connection = con
    '            cmd.Parameters.AddWithValue("@d1", txtOtherFees.Text)
    '            cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '            ' if otherfeesdetails is ALF then update ProjectFees, TotalFees in calculated fees depend on fees
    '        ElseIf txtOtherfeesDetails.Text = "Project Fee" Or txtOtherfeesDetails.Text = "project fees" Then
    '            con = New SqlConnection(cs)
    '            con.Open()
    '            Dim cb2 As String = "Update FullReport set ProjectFees = @d1 where StudentID = @d3"
    '            cmd = New SqlCommand(cb2)
    '            cmd.Connection = con
    '            cmd.Parameters.AddWithValue("@d1", txtOtherFees.Text)
    '            cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '        End If

    '        ' new sql connection for otherfees table - update other fees in particular student  depend on feesDetails and studentID

    '        If txtBalance.Text = "0" Then
    '            con = New SqlConnection(cs)
    '            con.Open()
    '            Dim cb3 As String = "Update OtherFees Set Fees = @d1 where  Details = @d2 and StudentID = @d3"
    '            cmd = New SqlCommand(cb3)
    '            cmd.Connection = con
    '            cmd.Parameters.AddWithValue("@d1", txtOtherFees.Text)
    '            cmd.Parameters.AddWithValue("@d2", txtOtherfeesDetails.Text)
    '            cmd.Parameters.AddWithValue("@d3", txtStudentID.Text)
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '        End If

    '        ' Message the successfully paid

    '        Dim st As String = "Update the fees details of Rs. '" & txtTotalPaid.Text & "' Recipt No. '" & txtReciptNo.Text & "'"
    '        If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
    '            MessageBox.Show("Successfully Update.", "Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            LogFunc(lblUserID.Text, lblUserName.Text, st)
    '            MessageBox.Show("Successfully Update.", "Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '        SaveBtn.Enabled = False
    '        con.Close()
    '        Print()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    '---------------- Button Section Start ------------

End Class