Imports System.Data.SqlClient

Public Class User_Main

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

    Private Sub User_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        frmHome.lblUserID.Text = lblUserID.Text
        frmHome.lblUserName.Text = lblUserName.Text
        frmHome.cmbSession.Text = cmbSession.Text
        switchpanel(frmHome)
        lblDateTime.Text = System.DateTime.Now
        SessionChange()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub
      
    '------------------------- Code to  Move Form -------------------

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

    '------------------------- Windows Buttons to Close & Minimaze ----------------------

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox3_Click_1(sender As Object, e As EventArgs) Handles minimizePic.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '---------------------- Function Section Start --------------------------

    Sub switchpanel(ByRef panel As Form)
        ContantPanel.Controls.Clear()
        panel.TopLevel = False
        ContantPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub Backup()
        With SaveFileDialog1
            .InitialDirectory = "C:\"
            .FileName = "DrishtiDb"
            .Filter = "Database Backup file(*.bak)|*.bak"
            .RestoreDirectory = True
            If Not .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Try
                    Cursor = Cursors.WaitCursor
                    Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("DrishtiDB.mdf") + ";Integrated Security=True"), _
                        Command As New SqlCommand("backup database [" & System.Windows.Forms.Application.StartupPath & "\DrishtiDB.mdf] to disk='" & .FileName & "'with init,stats=10", conn)
                        conn.Open()
                        Command.ExecuteNonQuery()
                        conn.Close()
                    End Using

                    Dim st As String = "sucessfully performed the backup"
                    If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                        MessageBox.Show("successfully performed", "database backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        LogFunc(lblUserID.Text, lblUserName.Text, st)
                        MessageBox.Show("successfully performed", "database backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Cursor = Cursors.Arrow
                End Try
            End If
        End With
    End Sub

    'Sub Backup()
    '    Try
    '        Cursor = Cursors.WaitCursor
    '        Timer1.Enabled = True
    '        If (Not System.IO.Directory.Exists("c:\dbbackup")) Then
    '            System.IO.Directory.CreateDirectory("c:\dbbackup")
    '        End If
    '        Dim destdir As String = "c:\dbbackup\drishti " & DateTime.Now.ToString("dd-mm-yyyy_hh-mm-ss") & ".bak"
    '        con = New SqlConnection(cs)
    '        con.Open()
    '        Dim cb As String = "backup database [" & System.Windows.Forms.Application.StartupPath & "\DrishtiDB1.mdf] to disk='" & destdir & "'with init,stats=10"
    '        cmd = New SqlCommand(cb)
    '        cmd.Connection = con
    '        cmd.ExecuteReader()
    '        con.Close()

    '        Dim st As String = "sucessfully performed the backup"

    '        If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
    '            MessageBox.Show("successfully performed", "database backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            LogFunc(lblUserID.Text, lblUserName.Text, st)
    '            MessageBox.Show("successfully performed", "database backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '        Cursor = Cursors.Arrow
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Sub Restore()
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer1.Enabled = True
                SqlConnection.ClearAllPools()
                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "USE Master ALTER DATABASE [" & System.Windows.Forms.Application.StartupPath & "\DrishtiDB.mdf] SET Single_User WITH Rollback Immediate Restore database [" & System.Windows.Forms.Application.StartupPath & "\DrishtiDB.mdf] FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE [" & System.Windows.Forms.Application.StartupPath & "\DrishtiDB.mdf] SET Multi_User "
                'Dim cb As String = "RESTORE DATABASE [" & System.Windows.Forms.Application.StartupPath & "\DrishtiDB.mdf] FROM disk='" & OpenFileDialog1.FileName & "'"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.ExecuteReader()
            End If

            Dim st As String = "Sucessfully performed the restore"
            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, st)
                MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Arrow
        End Try
    End Sub

    Sub SessionChange()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select Session From Session_Master order by ID", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbSession.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbSession.Items.Add(drow(0).ToString())
            Next
            con.Close()

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select Session from Session_Master where ID = (Select Max(ID) from Session_Master)", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = New DataTable
            dtable = ds.Tables(0)
            cmbSession.Text = dtable.Rows(0)("Session").ToString
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----------------------  Function Section End ------------------------

    Private Sub LogoutMenu2_Click(sender As Object, e As EventArgs) Handles LogoutMenu2.Click
        Try
            If MessageBox.Show("Do you want Backup database before logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Backup()
                If lblUserID.Text <> "146546" And lblUserName.Text <> "Deepak" Then
                    Dim st As String = "Successfully Logged Out"
                    LogFunc(lblUserID.Text, lblUserName.Text, st)

                End If
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CurrentSessionbtn_Click(sender As Object, e As EventArgs) Handles CurrentSessionbtn.Click
        SessionChange()
    End Sub

    '----------------------- Menu1 Start ------------------------------

    Private Sub CenterInfoMenu1_Click(sender As Object, e As EventArgs) Handles CenterInfoMenu1.Click
        FrmCenterInfo.lblUserType.Text = lblUserType.Text
        FrmCenterInfo.lblUserID.Text = lblUserID.Text
        FrmCenterInfo.lblUserName.Text = lblUserName.Text
        FrmCenterInfo.ShowDialog()
    End Sub

    Private Sub OtherCentersMenu1_Click(sender As Object, e As EventArgs) Handles OtherCentersMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmOtherCenters.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmOtherCenters.Text)
        frmOtherCenters.lblUserID.Text = lblUserID.Text
        frmOtherCenters.lblUserName.Text = lblUserName.Text
        frmOtherCenters.Reset()
        switchpanel(frmOtherCenters)
    End Sub

    Private Sub ManageCourseMenu1_Click(sender As Object, e As EventArgs) Handles ManageCourseMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmCourse.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmCourse.Text)
        frmCourse.lblUserID.Text = lblUserID.Text
        frmCourse.lblUserName.Text = lblUserName.Text
        frmCourse.Reset()
        switchpanel(frmCourse)
    End Sub

    Private Sub SessionMenu1_Click(sender As Object, e As EventArgs) Handles SessionMenu1.Click
        frmSession.lblUserID.Text = lblUserID.Text
        frmSession.lblUserName.Text = lblUserName.Text
        frmSession.lblUserType.Text = lblUserType.Text
        frmSession.Reset()
        frmSession.ShowDialog()
    End Sub

    Private Sub AddStudentMenu1_Click(sender As Object, e As EventArgs) Handles AddStudentMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmStudent.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmStudent.Text)
        FrmStudent.lblUserID.Text = lblUserID.Text
        FrmStudent.lblUserName.Text = lblUserName.Text
        FrmStudent.Reset()
        switchpanel(FrmStudent)
    End Sub

    Private Sub UpdateDeleteMenu1_Click(sender As Object, e As EventArgs) Handles UpdateDeleteMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmStudentM.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmStudentM.Text)
        FrmStudentM.lblUserID.Text = lblUserID.Text
        FrmStudentM.lblUserName.Text = lblUserName.Text
        FrmStudentM.Reset()
        switchpanel(FrmStudentM)
    End Sub

    Private Sub AddStuRegisterNoMenu1_Click(sender As Object, e As EventArgs) Handles AddStuRegisterNoMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmAddRegistrationNo.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmAddRegistrationNo.Text)
        FrmAddRegistrationNo.lblUserID.Text = lblUserID.Text
        FrmAddRegistrationNo.lblUserName.Text = lblUserName.Text
        FrmAddRegistrationNo.Reset()
        switchpanel(FrmAddRegistrationNo)
    End Sub

    Private Sub StudentRecordMenu1_Click(sender As Object, e As EventArgs) Handles StudentRecordMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmStudentRecord.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmStudentRecord.Text)
        frmStudentRecord.lblSession.Text = cmbSession.Text
        frmStudentRecord.Reset()
        switchpanel(frmStudentRecord)
    End Sub

    Private Sub FeeMenu1_Click(sender As Object, e As EventArgs) Handles FeeMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmDepositfees.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmDepositfees.Text)
        frmDepositfees.lblUserID.Text = lblUserID.Text
        frmDepositfees.lblUserName.Text = lblUserName.Text
        frmDepositfees.lblusertype.Text = lblUserType.Text
        frmDepositfees.Reset()
        switchpanel(frmDepositfees)
    End Sub

    Private Sub BackupMenu1_Click(sender As Object, e As EventArgs) Handles BackupMenu1.Click
        Backup()
    End Sub

    Private Sub RestoreMenu1_Click(sender As Object, e As EventArgs) Handles RestoreMenu1.Click
        Restore()
    End Sub

    Private Sub GivenResultMenu1_Click(sender As Object, e As EventArgs) Handles GivenResultMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmResultGiven.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmResultGiven.Text)
        FrmResultGiven.lblUserID.Text = lblUserID.Text
        FrmResultGiven.lblUserName.Text = lblUserName.Text
        FrmResultGiven.Reset()
        switchpanel(FrmResultGiven)
    End Sub

    Private Sub ReceiveResultMenu1_Click(sender As Object, e As EventArgs) Handles ReceiveResultMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmResultGiven.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmResultGiven.Text)
        frmResultReceive.lblUserID.Text = lblUserID.Text
        frmResultReceive.lblUserName.Text = lblUserName.Text
        frmResultReceive.Reset()
        switchpanel(frmResultReceive)
    End Sub

    Private Sub DiscountMenu1_Click(sender As Object, e As EventArgs) Handles DiscountMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmDiscount.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmDiscount.Text)
        FrmDiscount.lblUserID.Text = lblUserID.Text
        FrmDiscount.lblUserName.Text = lblUserName.Text
        FrmDiscount.lblSession.Text = cmbSession.Text
        FrmDiscount.Reset()
        switchpanel(FrmDiscount)
    End Sub

    Private Sub CourseMaterialMenu1_Click(sender As Object, e As EventArgs) Handles CourseMaterialMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmCourseMaterial.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmCourseMaterial.Text)
        FrmCourseMaterial.lblUserID.Text = lblUserID.Text
        FrmCourseMaterial.lblUserName.Text = lblUserName.Text
        FrmCourseMaterial.Reset()
        switchpanel(FrmCourseMaterial)
    End Sub

    Private Sub ExamFromMenu1_Click(sender As Object, e As EventArgs) Handles ExamFromMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmExamFromSB.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmExamFromSB.Text)
        FrmExamFromSB.lblUserID.Text = lblUserID.Text
        FrmExamFromSB.lblUserName.Text = lblUserName.Text
        FrmExamFromSB.Reset()
        switchpanel(FrmExamFromSB)
    End Sub

    Private Sub AssignementMenu1_Click(sender As Object, e As EventArgs) Handles AssignementMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmAssignement.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmAssignement.Text)
        FrmAssignement.lblUserID.Text = lblUserID.Text
        FrmAssignement.lblUserName.Text = lblUserName.Text
        FrmAssignement.Reset()
        switchpanel(FrmAssignement)
    End Sub

    Private Sub LateFeesMenu1_Click(sender As Object, e As EventArgs) Handles OtherFeesMenu1.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmOtherFees.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmOtherFees.Text)
        FrmOtherFees.lblUserID.Text = lblUserID.Text
        FrmOtherFees.lblUserName.Text = lblUserName.Text
        FrmOtherFees.Reset()
        switchpanel(FrmOtherFees)
    End Sub

    Private Sub CalculatorMenu1_Click(sender As Object, e As EventArgs) Handles CalculatorMenu1.Click
        System.Diagnostics.Process.Start("Calc.exe")
    End Sub

    Private Sub NotePadMenu1_Click(sender As Object, e As EventArgs) Handles NotePadMenu1.Click
        System.Diagnostics.Process.Start("NotePad.exe")
    End Sub

    Private Sub WordPadMenu1_Click(sender As Object, e As EventArgs) Handles WordPadMenu1.Click
        System.Diagnostics.Process.Start("WordPad.exe")
    End Sub

    Private Sub MSWordMenu1_Click(sender As Object, e As EventArgs) Handles MSWordMenu1.Click
        System.Diagnostics.Process.Start("WinWord.exe")
    End Sub

    Private Sub MSPaintMenu1_Click(sender As Object, e As EventArgs) Handles MSPaintMenu1.Click
        System.Diagnostics.Process.Start("MSPaint.exe")
    End Sub

    Private Sub TaskManagerMenu1_Click(sender As Object, e As EventArgs) Handles TaskManagerMenu1.Click
        System.Diagnostics.Process.Start("TaskMgr.exe")
    End Sub

    Private Sub SystemInfoManu1_Click(sender As Object, e As EventArgs)
        'switchpanel(FrmSystemInfo)
    End Sub

    Private Sub AboutDeveloperMenu1_Click(sender As Object, e As EventArgs) Handles AboutDeveloperMenu1.Click
        About_Developer.ShowDialog()
    End Sub

    Private Sub AboutSoftwareMenu1_Click(sender As Object, e As EventArgs) Handles AboutSoftwareMenu1.Click
        FrmAboutBox.ShowDialog()
    End Sub

    '------------------------------- Menu1 End --------------------------------

        '------------------------------- Menu2 start ------------------------------

    Private Sub HomeMenu2_Click(sender As Object, e As EventArgs) Handles HomeMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmHome.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmHome.Text)
        frmHome.lblUserName.Text = lblUserName.Text
        frmHome.cmbSession.Text = cmbSession.Text
        frmHome.Reset()
        switchpanel(frmHome)
    End Sub

    Private Sub BackupMenu2_Click(sender As Object, e As EventArgs) Handles BackupMenu2.Click
        Backup()
    End Sub

    Private Sub RestoreMenu2_Click(sender As Object, e As EventArgs) Handles RestoreMenu2.Click
        Restore()
    End Sub

    Private Sub AddStudentMenu2_Click(sender As Object, e As EventArgs) Handles AddStudentMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmStudent.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmStudent.Text)
        FrmStudent.lblUserID.Text = lblUserID.Text
        FrmStudent.lblUserName.Text = lblUserName.Text
        FrmStudent.Reset()
        switchpanel(FrmStudent)
    End Sub

    Private Sub UpdateDeleteMenu2_Click(sender As Object, e As EventArgs) Handles UpdateDeleteMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmStudentM.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmStudentM.Text)
        FrmAdmissioncancel.Close()
        FrmStudentM.lblUserID.Text = lblUserID.Text
        FrmStudentM.lblUserName.Text = lblUserName.Text
        FrmStudentM.Reset()
        switchpanel(FrmStudentM)
    End Sub

    Private Sub AddStuRegisterNoMenu2_Click(sender As Object, e As EventArgs) Handles AddStuRegisterNoMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmAddRegistrationNo.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmAddRegistrationNo.Text)
        FrmAddRegistrationNo.lblUserID.Text = lblUserID.Text
        FrmAddRegistrationNo.lblUserName.Text = lblUserName.Text
        FrmAddRegistrationNo.Reset()
        switchpanel(FrmAddRegistrationNo)
    End Sub

    Private Sub PaymentMenu2_Click(sender As Object, e As EventArgs) Handles PaymentMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmDepositfees.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmDepositfees.Text)
        frmDepositfees.lblUserID.Text = lblUserID.Text
        frmDepositfees.lblUserName.Text = lblUserName.Text
        frmDepositfees.lblusertype.Text = lblUserType.Text
        frmDepositfees.Reset()
        switchpanel(frmDepositfees)
    End Sub

    Private Sub DiscountMenu2_Click(sender As Object, e As EventArgs) Handles DiscountMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmDiscount.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmDiscount.Text)
        FrmDiscount.lblUserID.Text = lblUserID.Text
        FrmDiscount.lblUserName.Text = lblUserName.Text
        FrmDiscount.lblSession.Text = cmbSession.Text
        FrmDiscount.Reset()
        switchpanel(FrmDiscount)
    End Sub

    Private Sub GivenResultMenu2_Click(sender As Object, e As EventArgs) Handles GivenResultMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmResultGiven.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmResultGiven.Text)
        FrmResultGiven.lblUserID.Text = lblUserID.Text
        FrmResultGiven.lblUserName.Text = lblUserName.Text
        FrmResultGiven.Reset()
        switchpanel(FrmResultGiven)
    End Sub

    Private Sub ReceiveResultMenu2_Click(sender As Object, e As EventArgs) Handles ReceiveResultMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmResultReceive.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmResultReceive.Text)
        frmResultReceive.lblUserID.Text = lblUserID.Text
        frmResultReceive.lblUserName.Text = lblUserName.Text
        frmResultReceive.Reset()
        switchpanel(frmResultReceive)
    End Sub

    Private Sub CourseMaterialMenu2_Click(sender As Object, e As EventArgs) Handles CourseMaterialMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmCourseMaterial.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmCourseMaterial.Text)
        FrmCourseMaterial.lblUserID.Text = lblUserID.Text
        FrmCourseMaterial.lblUserName.Text = lblUserName.Text
        FrmCourseMaterial.Reset()
        switchpanel(FrmCourseMaterial)
    End Sub

    Private Sub AssignementMenu2_Click(sender As Object, e As EventArgs) Handles AssignementMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmAssignement.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmAssignement.Text)
        FrmAssignement.lblUserID.Text = lblUserID.Text
        FrmAssignement.lblUserName.Text = lblUserName.Text
        FrmAssignement.Reset()
        switchpanel(FrmAssignement)
    End Sub

    Private Sub ExamFromMenu2_Click(sender As Object, e As EventArgs) Handles ExamFromMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmExamFromSB.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmExamFromSB.Text)
        FrmExamFromSB.lblUserID.Text = lblUserID.Text
        FrmExamFromSB.lblUserName.Text = lblUserName.Text
        FrmExamFromSB.Reset()
        switchpanel(FrmExamFromSB)
    End Sub

    Private Sub LateFeesMenu2_Click(sender As Object, e As EventArgs) Handles OtherFeesMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmOtherFees.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmOtherFees.Text)
        FrmOtherFees.lblUserID.Text = lblUserID.Text
        FrmOtherFees.lblUserName.Text = lblUserName.Text
        FrmOtherFees.Reset()
        switchpanel(FrmOtherFees)
    End Sub

    Private Sub StudentRecordMenu2_Click(sender As Object, e As EventArgs) Handles StudentRecordMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmStudentRecord.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmStudentRecord.Text)
        frmStudentRecord.lblUserID.Text = lblUserID.Text
        frmStudentRecord.lblUserName.Text = lblUserName.Text
        frmStudentRecord.lblSession.Text = cmbSession.Text
        frmStudentRecord.Reset()
        switchpanel(frmStudentRecord)
    End Sub

    Private Sub FeesRecordMenu2_Click(sender As Object, e As EventArgs) Handles FeesRecordMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmFeesrecord.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmFeesrecord.Text)
        frmFeesrecord.lblSession.Text = cmbSession.Text
        frmFeesrecord.Reset()
        switchpanel(frmFeesrecord)
    End Sub

    Private Sub BooksRecordMenu2_Click(sender As Object, e As EventArgs) Handles BooksRecordMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmCourseMaterialRecord.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmCourseMaterialRecord.Text)
        FrmCourseMaterialRecord.lblSession.Text = cmbSession.Text
        FrmCourseMaterialRecord.Reset()
        switchpanel(FrmCourseMaterialRecord)
    End Sub

    Private Sub ReceiveResultRecordMenu2_Click(sender As Object, e As EventArgs) Handles ReceiveResultRecordMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmResultReceiveRecord.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmResultReceiveRecord.Text)
        FrmResultReceiveRecord.lblSession.Text = cmbSession.Text
        FrmResultReceiveRecord.Reset()
        switchpanel(FrmResultReceiveRecord)
    End Sub

    Private Sub GivenResultRecord2_Click(sender As Object, e As EventArgs) Handles GivenResultRecord2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", frmResultGivenRecord.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", frmResultGivenRecord.Text)
        frmResultGivenRecord.lblSession.Text = cmbSession.Text
        frmResultGivenRecord.Reset()
        switchpanel(frmResultGivenRecord)
    End Sub

    Private Sub ReportsMenu2_Click(sender As Object, e As EventArgs) Handles ReportsMenu2.Click
        Me.Text = String.Format("{0} - Drishti Computer Institute", FrmFullReport.Text)
        lblSoftName.Text = String.Format("{0} - Drishti Computer Institute", FrmFullReport.Text)
        Me.Text = FrmFullReport.Text
        FrmFullReport.Reset()
        switchpanel(FrmFullReport)
    End Sub

    '------------------------------ Menu2 End ----------------------

        '------------- Comboboox index change Section start ---------------------

      

        '------------------------------ Menu2 End ----------------------

        '------------- Comboboox index change Section start ---------------------

    Private Sub cmbSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSession.SelectedIndexChanged
        FrmCourseMaterialRecord.lblSession.Text = cmbSession.Text
        FrmDiscount.lblSession.Text = cmbSession.Text
        frmFeesrecord.lblSession.Text = cmbSession.Text
        frmResultGivenRecord.lblSession.Text = cmbSession.Text
        FrmResultReceiveRecord.lblSession.Text = cmbSession.Text
        frmStudentRecord.lblSession.Text = cmbSession.Text
    End Sub

End Class