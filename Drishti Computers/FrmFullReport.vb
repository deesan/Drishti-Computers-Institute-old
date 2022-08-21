Imports System.Data.SqlClient

Public Class FrmFullReport


    Private Sub FrmFullReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDataPrintableRecord()
        GetDataFeesRecord()
        GetDataStuExportRecord()
        FillSession()
    End Sub

    ' custom tabcontrol section start

    Private Sub PrrepBtn_Click(sender As Object, e As EventArgs) Handles PRBtn.Click
        SDEPanel.Visible = False
        FDEPanel.Visible = False
        PRPanel.Visible = True
    End Sub

    Private Sub SDEBtn_Click(sender As Object, e As EventArgs) Handles SDEBtn.Click
        PRPanel.Visible = False
        FDEPanel.Visible = False
        SDEPanel.Visible = True
    End Sub

    Private Sub FDEBtn_Click(sender As Object, e As EventArgs) Handles FDEBtn.Click
        SDEPanel.Visible = False
        PRPanel.Visible = False
        FDEPanel.Visible = True
    End Sub

    ' custom tabcontrol section end

    '------------ Function Secction Start ------------

    Sub Reset()
        cmbReportSession.SelectedIndex = -1
        cmbStuDataSession.SelectedIndex = -1
        cmbFeesDataSession.SelectedIndex = -1
        GetDataPrintableRecord()
        GetDataFeesRecord()
        GetDataStuExportRecord()
        FillSession()
    End Sub

    Sub GetDataPrintableRecord()
        Try
            Dim B As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(RegistrationNo) As [Registration No.], RTRIM(StuName) As [Name], RTRIM(FName) As [F/H Name], RTRIM(MName) As [MName], RTRIM(DoB) As [DoB], RTRIM(Mobileno) As [Mobile No.], RTRIM(Session) As [Session], RTRIM(Course) As [Course], RTRIM(TotalFeesPaid) As [Total Fees Paid], RTRIM(TotalCouFees) As [Course Fees] , RTRIM(ExamFees) As [Exam Fees], RTRIM(ALF) As [ALF], RTRIM(ELF) As [ELF], RTRIM(ProjectFees) As [Project Fees], RTRIM(TotalFees) As [Total Fees], RTRIM(Discount) As [Less], RTRIM(Balance) As [Balance], RTRIM(Remark) As [Remark], RTRIM(Result) As [Result], RTRIM(MReceive) As [MReceive], RTRIM(MGiven) As [MGiven], RTRIM(GivenDate) As [MGiven Date] from FullReport order by StudentID ASC"
            Dim C As String = "FullReport"
            Dim E As New DataGridView
            E = dgwSessionReport
            Data(B, C, E)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub       ' Print Full Report

    Sub GetDataFeesRecord()
        Try
            Dim B As String = "SELECT RTRIM(ReciptNo) As [Recipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [Exam Fees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalCouFees) As [Total Fees], RTRIM(TotalpaidFees) As [Total Paid Fees], RTRIM(PaymentDue) As [Payment Due], RTRIM(UserName) As [User Name] FROM FeesPayment order by StudentID ASC"
            Dim C As String = "FullReport"
            Dim E As New DataGridView
            E = dgwFeesDataExport
            Data(B, C, E)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub      'Export Fees Data  

    Sub GetDataStuExportRecord()
        Try
            Dim B As String = "Select RTRIM(StudentID) As [Student ID], RTRIM(RegistrationNo) As [Registration No.], RTRIM(StuName) As [Name], RTRIM(FName) As [F/H Name], RTRIM(MName) As [MName], RTRIM(DoB) As [DoB], RTRIM(Mobileno) As [Mobile No.], RTRIM(Session) As [Session], RTRIM(Course) As [Course], RTRIM(TotalFeesPaid) As [Total Fees Paid], RTRIM(TotalCouFees) As [Course Fees] , RTRIM(ExamFees) As [Exam Fees], RTRIM(ALF) As [ALF], RTRIM(ELF) As [ELF], RTRIM(ProjectFees) As [Project Fees], RTRIM(TotalFees) As [Total Fees], RTRIM(Discount) As [Less], RTRIM(Balance) As [Balance], RTRIM(Remark) As [Remark], RTRIM(Result) As [Result], RTRIM(MReceive) As [MReceive], RTRIM(MGiven) As [MGiven], RTRIM(GivenDate) As [MGiven Date] from FullReport order by StudentID ASC"
            Dim C As String = "FullReport"
            Dim E As New DataGridView
            E = dgwStuDatExport
            Data(B, C, E)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub         ' Export Student data

    Sub FillSession()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select Session From Session_Master order by ID", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbReportSession.Items.Clear()
            cmbStuDataSession.Items.Clear()
            cmbFeesDataSession.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbReportSession.Items.Add(drow(0).ToString())
                cmbStuDataSession.Items.Add(drow(0).ToString())
                cmbFeesDataSession.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------------- Function Secction Start -------------------

    '------------- Combobox - Index Change Secction Start --------------

    ' print data session change

    Private Sub cmbReportSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReportSession.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(StudentID) As [Student ID], RTRIM(RegistrationNo) As [Registration No.], RTRIM(StuName) As [Name], RTRIM(FName) As [F/H Name], RTRIM(MName) As [MName], RTRIM(DoB) As [DoB], RTRIM(Mobileno) As [Mobile No.], RTRIM(Session) As [Session], RTRIM(Course) As [Course], RTRIM(TotalFeesPaid) As [Total Fees Paid], RTRIM(TotalCouFees) As [Course Fees] , RTRIM(ExamFees) As [Exam Fees], RTRIM(ALF) As [ALF], RTRIM(ELF) As [ELF], RTRIM(ProjectFees) As [Project Fees], RTRIM(TotalFees) As [Total Fees], RTRIM(Discount) As [Less], RTRIM(Balance) As [Balance], RTRIM(Remark) As [Remark], RTRIM(Result) As [Result], RTRIM(MReceive) As [MReceive], RTRIM(MGiven) As [MGiven], RTRIM(GivenDate) As [MGiven Date] from FullReport where Session = @d1 order by StudentID", con)
            cmd.Parameters.AddWithValue("@d1", cmbReportSession.Text)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "FullReport")
            dgwSessionReport.DataSource = ds.Tables("FullReport").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' fees fata export session change

    Private Sub cmbFeesDataSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFeesDataSession.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(ReciptNo) As [Recipt No], RTRIM(Date) As [Date], RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Student Name], RTRIM(Course) As [Course], RTRIM(Session) As [Session], RTRIM(PaymentMode) As [Payment Mode], RTRIM(RegistrationFees) As [Registration Fees], RTRIM(ProspectusFees) As [Prospectus Fees], RTRIM(TuitionFees) As [Tuition Fees], RTRIM(ExamFees) As [Exam Fees], RTRIM(OtherFees) As [Other Fees], RTRIM(OtherFeesDetails) As [Other Fees Details], RTRIM(GrandTotalPaid) As [Grand Total Paid], RTRIM(TotalCouFees) As [Total Course Fees], RTRIM(TotalpaidFees) As [Total Paid Fees], RTRIM(PaymentDue) As [Payment Due], RTRIM(UserName) As [User Name] FROM FeesPayment where Session = @d1 order by StudentID", con)
            cmd.Parameters.AddWithValue("@d1", cmbFeesDataSession.Text)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "FeesPayment")
            dgwFeesDataExport.DataSource = ds.Tables("FeesPayment").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' student data export session change

    Private Sub cmbStuDataSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStuDataSession.SelectedIndexChanged
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select RTRIM(StudentID) As [Student ID], RTRIM(RegistrationNo) As [Registration No.], RTRIM(StuName) As [Name], RTRIM(FName) As [F/H Name], RTRIM(MName) As [MName], RTRIM(DoB) As [DoB], RTRIM(Mobileno) As [Mobile No.], RTRIM(Session) As [Session], RTRIM(Course) As [Course], RTRIM(TotalFeesPaid) As [Total Fees Paid], RTRIM(TotalCouFees) As [Course Fees] , RTRIM(ExamFees) As [Exam Fees], RTRIM(ALF) As [ALF], RTRIM(ELF) As [ELF], RTRIM(ProjectFees) As [Project Fees], RTRIM(TotalFees) As [Total Fees], RTRIM(Discount) As [Less], RTRIM(Balance) As [Balance], RTRIM(Remark) As [Remark], RTRIM(Result) As [Result], RTRIM(MReceive) As [MReceive], RTRIM(MGiven) As [MGiven], RTRIM(GivenDate) As [MGiven Date] from FullReport where Session = @d1 order by StudentID", con)
            cmd.Parameters.AddWithValue("@d1", cmbStuDataSession.Text)
            adp = New SqlDataAdapter(cmd)
            ds = New DataSet()
            adp.Fill(ds, "FullReport")
            dgwStuDatExport.DataSource = ds.Tables("FullReport").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----- Combobox - Index Change Secction End -------------

    '----------- Button Secction Start -------------

    Private Sub PrintBtn_Click_1(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Try
            If Len(Trim(cmbReportSession.Text)) = 0 Then
                MessageBox.Show("Please select Session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbReportSession.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Dim rpt As New FullReport 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT FullReport.StudentID, FullReport.RegistrationNo, FullReport.StuName, FullReport.FName, FullReport.MName, FullReport.DoB, FullReport.Mobileno, FullReport.Session, FullReport.Course, FullReport.TotalFeesPaid, FullReport.TotalCouFees, FullReport.ExamFees, FullReport.ALF, FullReport.ELF, FullReport.ProjectFees, FullReport.TotalFees, FullReport.Discount, FullReport.Balance, FullReport.Remark, FullReport.Result, FullReport.MReceive, FullReport.MGiven, FullReport.GivenDate FROM FullReport where FullReport.Session = '" & cmbReportSession.Text & "' order by StudentID"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Session_Master")
            myDA.Fill(myDS, "FullReport")
            rpt.SetDataSource(myDS)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub FeesDataExportBtn_Click(sender As Object, e As EventArgs) Handles FeesDataExportBtn.Click
        frmReport.CrystalReportViewer1.ShowCopyButton = False
        frmReport.CrystalReportViewer1.ShowGotoPageButton = False
        frmReport.CrystalReportViewer1.ShowPageNavigateButtons = False
        frmReport.CrystalReportViewer1.ShowParameterPanelButton = False
        Try
            If Len(Trim(cmbFeesDataSession.Text)) = 0 Then
                MessageBox.Show("Please select Session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbFeesDataSession.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Dim rpt As New FeesdataExport 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT FeesPayment.ReciptNo, FeesPayment.Date, FeesPayment.StudentID, FeesPayment.StuName, FeesPayment.Course, FeesPayment.Session, FeesPayment.PaymentMode, FeesPayment.Options, FeesPayment.RegistrationFees, FeesPayment.ProspectusFees, FeesPayment.TuitionFees, FeesPayment.ExamFees, FeesPayment.OtherFees, FeesPayment.OtherFeesDetails, FeesPayment.GrandTotalPaid, FeesPayment.TotalCouFees, FeesPayment.TotalpaidFees, FeesPayment.PaymentDue, FeesPayment.UserName FROM FeesPayment where FeesPayment.Session = '" & cmbFeesDataSession.Text & "' order by StudentID"
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
    End Sub

    Private Sub StuDataExportBtn_Click(sender As Object, e As EventArgs) Handles StuDataExportBtn.Click
        frmReport.CrystalReportViewer1.ShowCopyButton = False
        frmReport.CrystalReportViewer1.ShowGotoPageButton = False
        frmReport.CrystalReportViewer1.ShowPageNavigateButtons = False
        frmReport.CrystalReportViewer1.ShowParameterPanelButton = False
        Try
            If Len(Trim(cmbStuDataSession.Text)) = 0 Then
                MessageBox.Show("Please select Session", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbStuDataSession.Focus()
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Dim rpt As New FullReport 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT FullReport.StudentID, FullReport.RegistrationNo, FullReport.StuName, FullReport.FName, FullReport.MName, FullReport.DoB, FullReport.Mobileno, FullReport.Session, FullReport.Course, FullReport.TotalFeesPaid, FullReport.TotalCouFees, FullReport.ExamFees, FullReport.ALF, FullReport.ELF, FullReport.ProjectFees, FullReport.TotalFees, FullReport.Discount, FullReport.Balance, FullReport.Remark, FullReport.Result, FullReport.MReceive, FullReport.MGiven, FullReport.GivenDate FROM FullReport where FullReport.Session = '" & cmbReportSession.Text & "' order by StudentID"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "FullReport")
            rpt.SetDataSource(myDS)
            frmReport.CrystalReportViewer1.ReportSource = rpt
            frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Arrow
        End Try
    End Sub

    '------- Button Secction Start -----------

    '---------- DataGridView Secction Start --------------

    Private Sub dgwFeesDataExport_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgwFeesDataExport.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgwSessionReport.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgwSessionReport.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub dgwSessionReport_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgwSessionReport.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgwSessionReport.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgwSessionReport.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub dgwStuDatExport_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgwStuDatExport.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgwSessionReport.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgwSessionReport.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

End Class