Imports System.Data.SqlClient
Imports System.IO
Public Class frmOtherCenters

    Private Sub frmOtherCenters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    '------------------ Function Section Start --------------

    Sub Reset()
        txtCenterCode.Text = ""
        txtCenterName.Text = ""
        txtCenterLocation.Text = ""
        txtOwner.Text = ""
        txtContactNo.Text = ""
        SaveBtn.Enabled = True
        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False
        GetData()
    End Sub

    Sub GetData()
        Try
           
            Dim A As String = "Select RTRIM(CenterCode) As [Center Code], RTRIM(Name) As [Center Name], RTRIM(Location) As [Location], RTRIM(Owner) As Owner, RTRIM(COntactNo) As [Contact No] from OtherCenter order by CenterCode"
            Dim B As String = "OtherCenter"
            Dim C As New DataGridView
            C = dgw
            Data(A, B, C)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = " delete from CenterCode where CenterCode = @d1"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", txtCenterCode.Text)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()

            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "delete from OtherCenter where CenterCode=@d1"
            cmd = New SqlCommand(cb1)
            cmd.Parameters.AddWithValue("@d1", txtCenterCode.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "Update the Center Details '" & txtCenterName.Text & "' has Center Code '" & txtCenterCode.Text & "'"

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, st)
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                
                GetData()
                Reset()
            Else
                MessageBox.Show("No Record Found !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '---------------------- Function Section End -------------

    '--------------- Button Section Start -----------------

    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        Reset()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If Len(Trim(txtCenterCode.Text)) = 0 Then
            MessageBox.Show("Please enter Center Code ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCenterCode.Focus()
            Exit Sub
        End If

        If Len(Trim(txtCenterName.Text)) = 0 Then
            MessageBox.Show("Please enter Center Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCenterName.Focus()
            Exit Sub
        End If

        If Len(Trim(txtOwner.Text)) = 0 Then
            MessageBox.Show("Please enter Owner Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtOwner.Focus()
            Exit Sub
        End If

        If Len(Trim(txtCenterLocation.Text)) = 0 Then
            MessageBox.Show("Please enter Location ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCenterLocation.Focus()
            Exit Sub
        End If

        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("Please enter Contact No. ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Exit Sub
        End If

        If txtContactNo.Text.Length < 10 Then
            MessageBox.Show("Contact No is not Vaild !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select CenterCode from OtherCenter where CenterCode = @d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtCenterCode.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MessageBox.Show("Center is Already Exists !", "Information", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtCenterCode.Text = ""
                txtCenterCode.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into OtherCenter(CenterCode, Name, Owner, Location, ContactNo) VALUES (@d1, @d2, @d3,@d4,@d5)"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", txtCenterCode.Text)
            cmd.Parameters.AddWithValue("@d2", txtCenterName.Text)
            cmd.Parameters.AddWithValue("@d3", txtOwner.Text)
            cmd.Parameters.AddWithValue("@d4", txtCenterLocation.Text)
            cmd.Parameters.AddWithValue("@d5", txtContactNo.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            con = New SqlConnection(cs)
            con.Open()
            Dim cc As String = "insert into CenterCode(CenterCode) Values(@d1)"
            cmd = New SqlCommand(cc)
            cmd.Parameters.AddWithValue("@d1", txtCenterCode.Text)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

            Dim st As String = "added the New Center Details '" & txtCenterName.Text & "' has Center Code '" & txtCenterCode.Text & "'"

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, st)
                MessageBox.Show("Successfully Saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            GetData()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            If Len(Trim(txtCenterCode.Text)) = 0 Then
                MessageBox.Show("Unable to Update. Please select Center Code ?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCenterCode.Focus()
            Else
                If Len(Trim(txtCenterCode.Text)) = 0 Then
                    MessageBox.Show("Please enter Center Code ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCenterCode.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtCenterName.Text)) = 0 Then
                    MessageBox.Show("Please enter Center Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCenterName.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtCenterLocation.Text)) = 0 Then
                    MessageBox.Show("Please enter Location ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCenterLocation.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtOwner.Text)) = 0 Then
                    MessageBox.Show("Please enter Owner Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtOwner.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtContactNo.Text)) = 0 Then
                    MessageBox.Show("Please enter Contact No. ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtContactNo.Focus()
                    Exit Sub
                End If

                If txtContactNo.Text.Length < 10 Then
                    MessageBox.Show("Contact No is not Vaild !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtContactNo.Focus()
                    Exit Sub
                End If

                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "Update OtherCenter set CenterCode = @d1, Name = @d2, Owner = @d3, Location = @d4, ContactNo = @d5 where CenterCode = @d6"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtCenterCode.Text)
                cmd.Parameters.AddWithValue("@d2", txtCenterName.Text)
                cmd.Parameters.AddWithValue("@d3", txtOwner.Text)
                cmd.Parameters.AddWithValue("@d4", txtCenterLocation.Text)
                cmd.Parameters.AddWithValue("@d5", txtContactNo.Text)
                cmd.Parameters.AddWithValue("@d6", txtCenterCodeChange.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "Update CenterCode set CenterCode = @d1 where CenterCode = @d2"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtCenterCode.Text)
                cmd.Parameters.AddWithValue("@d2", txtCenterCodeChange.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Update the Center Details '" & txtCenterName.Text & "' has Center Code '" & txtCenterCode.Text & "'")
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
                GetData()
                Reset()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If Len(Trim(txtCenterCode.Text)) = 0 Then
                MessageBox.Show("Unable to Delete !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MessageBox.Show("Do You really wnat to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                    DeleteRecord()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------- Button Section End -----------------

    '------------------ DataGridView Section Start ------------------

    Private Sub dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim row As DataGridViewRow = dgw.SelectedRows(0)

            txtCenterCode.Text = row.Cells(0).Value.ToString
            txtCenterName.Text = row.Cells(1).Value.ToString
            txtCenterLocation.Text = row.Cells(2).Value.ToString
            txtOwner.Text = row.Cells(3).Value.ToString
            txtContactNo.Text = row.Cells(4).Value.ToString
            txtCenterCodeChange.Text = row.Cells(0).Value.ToString
            UpdateBtn.Enabled = True
            DeleteBtn.Enabled = True
            SaveBtn.Enabled = False
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

    '--------------- DatGridview section End ----------------

End Class