Imports System.Data.SqlClient
Imports System.IO
Public Class frmManageUser

    Private Sub frmManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
    End Sub

    '---------------- Function Section Start ---------

    Sub Reset()
        txtUserID.Text = ""
        cmbUsertype.SelectedIndex = -1
        txtPassword.Text = ""
        txtName.Text = ""
        txtFName.Text = ""
        cmbGender.SelectedIndex = -1
        dtpDoB.Text = Today
        cmbCategory.SelectedIndex = -1
        txtEmailID.Text = ""
        txtContactNo.Text = ""
        txtWorktype.Text = ""
        dtpDoJ.Text = Today
        txtAddress.Text = ""
        PIC1.Image = My.Resources.photo
        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False
        RegisterBtn.Enabled = True
        txtName.Focus()
        Getdata()
    End Sub

    Sub Getdata()
        'Try
        '    con = New SqlConnection(cs)
        '    con.Open()
        '    adp = New SqlDataAdapter()
        '    adp.SelectCommand = New SqlCommand("Select Photo, RTRIM(Name) as [User Name], RTRIM(FName) as [Father's Name], RTRIM(Gender) as [Gender],Convert(DateTime,DoB,103) as [Date Of Birth], RTRIM(Category) as [Category], RTRIM(UserID) as [User ID], RTRIM(Password) as [Password], RTRIM(UserType) as [User Type], RTRIM(WorkType) as [Work Type], Convert(DateTime,DoJ,103) as [Joining Date], RTRIM(EmailID) as [Email ID], RTRIM(ContactNo) as [Contact No], RTRIM(Address) as [Address] from Userdetails", con)
        '    dtable = New DataTable
        '    adp.Fill(dtable)

        '    dgw.RowTemplate.Height = 75
        '    Dim imgc As New DataGridViewImageColumn()
        '    dgw.DataSource = dtable
        '    imgc = dgw.Columns(0)
        '    imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

        '    con.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("Select Photo, RTRIM(Name), RTRIM(FName), RTRIM(Gender), RTRIM(DoB), RTRIM(Category), RTRIM(UserID), RTRIM(Password), RTRIM(UserType), RTRIM(WorkType), RTRIM(DoJ), RTRIM(EmailID), RTRIM(ContactNo), RTRIM(Address) from Userdetails", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0

            con = New SqlConnection(cs)
            con.Open()
            Dim cb2 As String = "delete from Userlogin where UserID = @d1"
            cmd = New SqlCommand(cb2)
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()

            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from UserDetails where UserID=@d1"
            cmd = New SqlCommand(cq)
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "deleted the User '" & txtName.Text & "' has User id '" & txtUserID.Text & "'")
                    MessageBox.Show("Successfully deleted.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                
                Getdata()
                Reset()
            Else
                MessageBox.Show("No Record found !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------- Function Section End -----------------

    '------------- Button Section Start ----------------------

    'Image Button section start

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PIC1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        PIC1.Image = My.Resources.photo
    End Sub

    'Image Button Section End

    'Form Button Section Start

    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        Reset()
    End Sub

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Try

            If Len(Trim(txtUserID.Text)) = 0 Then
                MessageBox.Show("Please Enter UserID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserID.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbUsertype.Text)) = 0 Then
                MessageBox.Show("Please Select Usertype ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbUsertype.Focus()
                Exit Sub
            End If

            If Len(Trim(txtPassword.Text)) = 0 Then
                MessageBox.Show("Please Enter Password ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Focus()
                Exit Sub
            End If

            If txtPassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = ""
                txtPassword.Focus()
                Exit Sub
            End If

            If Len(Trim(txtName.Text)) = 0 Then
                MessageBox.Show("Please Enter Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtName.Focus()
                Exit Sub
            End If

            If Len(Trim(txtFName.Text)) = 0 Then
                MessageBox.Show("Please Enter Father's Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtFName.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbGender.Text)) = 0 Then
                MessageBox.Show("Please Select Gender ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbGender.Focus()
                Exit Sub
            End If

            If Len(Trim(cmbCategory.Text)) = 0 Then
                MessageBox.Show("Please Select Category ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbCategory.Focus()
                Exit Sub
            End If

            If Len(Trim(txtEmailID.Text)) = 0 Then
                MessageBox.Show("Please Enter Email ID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmailID.Focus()
                Exit Sub
            End If

            If Len(Trim(txtContactNo.Text)) = 0 Then
                MessageBox.Show("Please Enter Contact No. ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContactNo.Focus()
                Exit Sub
            End If

            If Len(Trim(txtWorktype.Text)) = 0 Then
                MessageBox.Show("Please Enter Work Type ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtWorktype.Focus()
                Exit Sub
            End If

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please Enter Address ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddress.Focus()
                Exit Sub
            End If

            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "Select UserID from UserDetails where UserID = @d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("User ID Already Exsits !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserID.Text = ""
                txtUserID.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into UserDetails(Photo, UserID, Password, UserType, Name, FName, Gender, DoB, Category, EmailID, ContactNo, Worktype, DoJ, Address) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PIC1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d1", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.Parameters.AddWithValue("@d2", txtUserID.Text)
            cmd.Parameters.AddWithValue("@d3", txtPassword.Text)
            cmd.Parameters.AddWithValue("@d4", cmbUsertype.Text)
            cmd.Parameters.AddWithValue("@d5", txtName.Text)
            cmd.Parameters.AddWithValue("@d6", txtFName.Text)
            cmd.Parameters.AddWithValue("@d7", cmbGender.Text)
            cmd.Parameters.AddWithValue("@d8", dtpDoB.Text)
            cmd.Parameters.AddWithValue("@d9", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@d10", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d11", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d12", txtWorktype.Text)
            cmd.Parameters.AddWithValue("@d13", dtpDoJ.Text)
            cmd.Parameters.AddWithValue("@d14", txtAddress.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into Userlogin(UserID, Password, UserType, Name) values(@d1, @d2, @d3, @d4)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Parameters.AddWithValue("@d2", txtPassword.Text)
            cmd.Parameters.AddWithValue("@d3", cmbUsertype.Text)
            cmd.Parameters.AddWithValue("@d4", txtName.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, "added new User '" & txtName.Text & "' has User ID '" & txtUserID.Text & "'")
                MessageBox.Show("Successfully saved.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
            Getdata()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try

            If Len(Trim(txtUserID.Text)) = 0 Then

                MessageBox.Show("Unable to Update. Please select User ID ?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                If Len(Trim(txtUserID.Text)) = 0 Then
                    MessageBox.Show("Please Enter UserID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUserID.Focus()
                    Exit Sub
                End If

                If Len(Trim(cmbUsertype.Text)) = 0 Then
                    MessageBox.Show("Please Select Usertype ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cmbUsertype.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtPassword.Text)) = 0 Then
                    MessageBox.Show("Please Enter Password ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtName.Text)) = 0 Then
                    MessageBox.Show("Please Enter Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtName.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtFName.Text)) = 0 Then
                    MessageBox.Show("Please Enter Father's Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtFName.Focus()
                    Exit Sub
                End If

                If Len(Trim(cmbGender.Text)) = 0 Then
                    MessageBox.Show("Please Select Gender ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cmbGender.Focus()
                    Exit Sub
                End If

                If Len(Trim(cmbCategory.Text)) = 0 Then
                    MessageBox.Show("Please Select Category ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cmbCategory.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtEmailID.Text)) = 0 Then
                    MessageBox.Show("Please Enter Email ID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtEmailID.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtContactNo.Text)) = 0 Then
                    MessageBox.Show("Please Enter Contact No. ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtContactNo.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtWorktype.Text)) = 0 Then
                    MessageBox.Show("Please Enter Work Type ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtWorktype.Focus()
                    Exit Sub
                End If

                If Len(Trim(txtAddress.Text)) = 0 Then
                    MessageBox.Show("Please Enter Address ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtAddress.Focus()
                    Exit Sub
                End If

                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "Update UserDetails set Photo = @d1, Name = @d2, FName = @d3, Gender = @d4, DoB = @d5, Category = @d6, UserID = @d7, Password = @d8, UserType = @d9, WorkType = @d10, DoJ = @d11, EmailID = @d12, ContactNo = @d13, Address = @d14 where UserID = @d15"
                cmd = New SqlCommand(cb)
                cmd.Connection = con

                Dim ms As New MemoryStream()
                Dim bmpImage As New Bitmap(PIC1.Image)
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@d1", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.Parameters.AddWithValue("@d2", txtName.Text)
                cmd.Parameters.AddWithValue("@d3", txtFName.Text)
                cmd.Parameters.AddWithValue("@d4", cmbGender.Text)
                cmd.Parameters.AddWithValue("@d5", dtpDoB.Text)
                cmd.Parameters.AddWithValue("@d6", cmbCategory.Text)
                cmd.Parameters.AddWithValue("@d7", txtUserID.Text)
                cmd.Parameters.AddWithValue("@d8", txtPassword.Text)
                cmd.Parameters.AddWithValue("@d9", cmbUsertype.Text)
                cmd.Parameters.AddWithValue("@d10", txtWorktype.Text)
                cmd.Parameters.AddWithValue("@d11", dtpDoJ.Text)
                cmd.Parameters.AddWithValue("@d12", txtEmailID.Text)
                cmd.Parameters.AddWithValue("@d13", txtContactNo.Text)
                cmd.Parameters.AddWithValue("@d14", txtAddress.Text)
                cmd.Parameters.AddWithValue("@d15", txtUserIDchange.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                con = New SqlConnection(cs)
                con.Open()
                Dim cb1 As String = "Update UserLogin Set UserID = @d1, Password = @d2, UserType = @d3, Name = @d4 where UserID = @d5 "
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
                cmd.Parameters.AddWithValue("@d2", txtPassword.Text)
                cmd.Parameters.AddWithValue("@d3", cmbUsertype.Text)
                cmd.Parameters.AddWithValue("@d4", txtName.Text)
                cmd.Parameters.AddWithValue("@d5", txtUserIDchange.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    LogFunc(lblUserID.Text, lblUserName.Text, "Update the User '" & txtName.Text & "' has User ID '" & txtUserID.Text & "'")
                    MessageBox.Show("Successfully Updated.", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                RegisterBtn.Enabled = False
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
                Getdata()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If Len(Trim(txtUserID.Text)) = 0 Then
                MessageBox.Show("Unable to delete", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                    DeleteRecord()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Form Button Section End

    '--------- Button Section End ----------------

    '------------- DataGridView Section Start ---------------

    Private Sub dgw_MouseClick1(sender As Object, e As MouseEventArgs) Handles dgw.MouseClick
        Try
            Dim row As DataGridViewRow = dgw.SelectedRows(0)

            Dim data As Byte() = DirectCast(row.Cells(0).Value, Byte())
            Dim ms As New MemoryStream(data)
            PIC1.Image = Image.FromStream(ms)

            txtName.Text = row.Cells(1).Value.ToString
            txtFName.Text = row.Cells(2).Value.ToString
            cmbGender.Text = row.Cells(3).Value.ToString
            dtpDoB.Text = row.Cells(4).Value.ToString
            cmbCategory.Text = row.Cells(5).Value.ToString
            txtUserID.Text = row.Cells(6).Value.ToString
            txtUserIDchange.Text = row.Cells(6).Value.ToString
            txtPassword.Text = row.Cells(7).Value.ToString
            cmbUsertype.Text = row.Cells(8).Value.ToString
            txtWorktype.Text = row.Cells(9).Value.ToString
            dtpDoJ.Text = row.Cells(10).Value.ToString
            txtEmailID.Text = row.Cells(11).Value.ToString
            txtContactNo.Text = row.Cells(12).Value.ToString
            txtAddress.Text = row.Cells(13).Value.ToString
            UpdateBtn.Enabled = True
            DeleteBtn.Enabled = True
            RegisterBtn.Enabled = False
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

    '------------- DataGridView Section End ----------------

End Class