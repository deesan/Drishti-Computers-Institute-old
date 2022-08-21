Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports System.Security.Cryptography

Module ModFunc
    Public Sub LogFunc(ByVal st1 As String, ByVal st2 As String, ByVal st3 As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "insert into Logs(UserID, Name, Date, Operation) values(@d1, @d2, @d3, @d4)"
        cmd = New SqlCommand(cb)
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@d1", st1)
        cmd.Parameters.AddWithValue("@d2", st2)
        cmd.Parameters.AddWithValue("@d3", System.DateTime.Now)
        cmd.Parameters.AddWithValue("@d4", st3)
        cmd.ExecuteReader()
        con.Close()
    End Sub

    Public Sub Data(ByVal S1 As String, ByVal S2 As String, ByVal S3 As DataGridView)
        con = New SqlConnection(cs)
        con.Open()
        cmd = New SqlCommand(S1, con)
        adp = New SqlDataAdapter(cmd)
        ds = New DataSet()
        adp.Fill(ds, S2)
        S3.DataSource = ds.Tables(S2).DefaultView
        con.Close()
    End Sub

End Module
