Imports System.Data.SqlClient
Imports System.IO

Public Class frmHome
    Dim Sum0 As Integer = 0
    Dim Sum1 As Integer = 0
    Dim Sum2 As Integer = 0


    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SessionChange()
        DisplayUserPic()
        calculate_Sum_Session_Receive()
        Calculate_Sum_Balance()
        Calculate_Total_Student()
        Calculate_Total_Student_Session()
        GetPaymentDueList()
    End Sub

    Sub Reset()
        calculate_Sum_Session_Receive()
        Calculate_Sum_Balance()
        Calculate_Total_Student()
        Calculate_Total_Student_Session()
        GetPaymentDueList()
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

    Sub DisplayUserPic()
        If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
            UserPic.Image = My.Resources.photo
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select photo from CenterInfo", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = New DataTable
            dtable = ds.Tables(0)

            Dim data As Byte() = DirectCast(dtable.Rows(0)("Photo"), Byte())
            Dim ms As New MemoryStream(data)
            LogoPic.Image = Image.FromStream(ms)
            con.Close()

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select Photo from UserDetails where UserID = '" & lblUserID.Text & "' and Name = '" & lblUserName.Text & "'", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = New DataTable
            dtable = ds.Tables(0)

            Dim data1 As Byte() = DirectCast(dtable.Rows(0)("Photo"), Byte())
            Dim ms1 As New MemoryStream(data1)
            UserPic.Image = Image.FromStream(ms1)
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    'Calculate receive fees in current session

    Sub calculate_Sum_Session_Receive()
        con = New SqlConnection(cs)
        con.Open()
        Dim sum As String = "SELECT Sum(TotalFeesPaid) As Sum0 from FullReport where Session = '" & cmbSession.Text & "'"
        cmd = New SqlCommand(sum)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            Sum0 = 0
            lblTotalFeesSession.Text = Sum0.ToString
        Else
            Sum0 = cmd.ExecuteScalar
            lblTotalFeesSession.Text = Sum0.ToString
        End If
        con.Close()
    End Sub

    'Calculate Balance fees in Current Session

    Sub Calculate_Sum_Balance()
        con = New SqlConnection(cs)
        con.Open()
        Dim sum As String = "SELECT Sum(Balance) As Sum2 from FullReport where Session = '" & cmbSession.Text & "'"
        cmd = New SqlCommand(sum)
        cmd.Connection = con
        If (IsDBNull(cmd.ExecuteScalar)) Then
            Sum2 = 0
            lblTotalBalanceSession.Text = Sum2.ToString
        Else
            Sum2 = cmd.ExecuteScalar
            lblTotalBalanceSession.Text = Sum2.ToString
        End If
        con.Close()
    End Sub

    'Calculate total Student in Center

    Sub Calculate_Total_Student()
        con = New SqlConnection(cs)
        con.Open()
        Dim st As String = "select Count(StudentID) As SID from Student"
        cmd = New SqlCommand(st)
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("SID").ToString() <> "" Then
            lblTotalStudent.Text = Integer.Parse(rdr("SID").ToString())
        Else
            lblTotalStudent.Text = 0
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    'calculate total student in current session

    Sub Calculate_Total_Student_Session()
        con = New SqlConnection(cs)
        con.Open()
        Dim st As String = "select Count(StudentID) As SID from Student where Session = '" & cmbSession.Text & "'"
        cmd = New SqlCommand(st)
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If rdr("SID").ToString() <> "" Then
            lblTotalStudentSession.Text = Integer.Parse(rdr("SID").ToString())
        Else
            lblTotalStudentSession.Text = 0
        End If
        rdr.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Close()
    End Sub

    'Payment Due List

    Sub GetPaymentDueList()
        Try
            Dim A As String = "SELECT RTRIM(StudentID) As [Student ID], RTRIM(StuName) As [Name], RTRIM(Course) As [Course], RTRIM(TotalFees) As [Total Fees (Course + Exam)], RTRIM(TotalFeesPaid) As [Total Paid], RTRIM(Balance) As [Fees Due] from FullReport where Session = '" & cmbSession.Text & "' and Balance >= 0"
            Dim B As String = "FullReport"
            Dim C As New DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Session Change Session

    Private Sub cmbSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSession.SelectedIndexChanged
        Reset()
        calculate_Sum_Session_Receive()
        Calculate_Sum_Balance()
        Calculate_Total_Student_Session()
        GetPaymentDueList()
    End Sub

    ' Current Session btn event

    Private Sub CurrentSessionbtn_Click(sender As Object, e As EventArgs) Handles CurrentSessionbtn.Click
        SessionChange()
    End Sub

End Class