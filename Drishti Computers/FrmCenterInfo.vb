Imports System.Data.SqlClient
Imports System.IO

Public Class FrmCenterInfo

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

    Private Sub FrmCenterInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
        If lblUserType.Text = "User" Then
            EditBtn.Visible = False
        End If

        If txtCenterCodeChange.Text = "" Then
            SaveBtn.Enabled = True
        Else
            SaveBtn.Enabled = False
        End If

        If SaveBtn.Enabled = False Then
            Me.AcceptButton = UpdateBtn
        End If
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

    '---------------------- Function Section Start ----------------

    Sub Getdata()
        Try
            con = New SqlConnection(cs)
            con.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("Select * from CenterInfo", con)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = New DataTable
            dtable = ds.Tables(0)

            txtCenterCode.Text = dtable.Rows(0)("CenterCode").ToString
            txtCenterName.Text = dtable.Rows(0)("Name").ToString
            txtOwner.Text = dtable.Rows(0)("Owner").ToString
            txtEmailID.Text = dtable.Rows(0)("EmailID").ToString
            txtWebsite.Text = dtable.Rows(0)("Website").ToString
            txtEstablishedYear.Text = dtable.Rows(0)("EstablishYear").ToString
            txtContactNo.Text = dtable.Rows(0)("ContactNo").ToString
            txtAltContactNo.Text = dtable.Rows(0)("AltContactNo").ToString
            txtAddress.Text = dtable.Rows(0)("Address").ToString

            Dim data As Byte() = DirectCast(dtable.Rows(0)("Photo"), Byte())
            Dim ms As New MemoryStream(data)
            PIC1.Image = Image.FromStream(ms)

            txtCenterCodeChange.Text = dtable.Rows(0)("CenterCode").ToString

            '------------------------------------------- Preview Section ----------------------------------------------------------------------------

            lblCenterCode.Text = dtable.Rows(0)("CenterCode").ToString
            lblCenterName.Text = dtable.Rows(0)("Name").ToString
            lblOwner.Text = dtable.Rows(0)("Owner").ToString
            lblEmailID.Text = dtable.Rows(0)("EmailID").ToString
            lblWebsite.Text = dtable.Rows(0)("Website").ToString
            lblEstablishedYear.Text = dtable.Rows(0)("EstablishYear").ToString
            lblContactNo.Text = dtable.Rows(0)("ContactNo").ToString
            lblAltContactNo.Text = dtable.Rows(0)("AltContactNo").ToString
            lblAddress.Text = dtable.Rows(0)("Address").ToString

            Dim data1 As Byte() = DirectCast(dtable.Rows(0)("Photo"), Byte())
            Dim ms1 As New MemoryStream(data1)
            LogoPIC.Image = Image.FromStream(ms1)

        Catch ex As Exception
            MessageBox.Show("Enter the Center Details", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    '--------------------- Function Section End ---------------

    '-------------------- Button Section Start ---------------

    'Preview Mode Buttons

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Guna2GroupBox1.Visible = False
        EditBtn.Visible = False
        CloseBtn.Visible = False
        Guna2GroupBox2.Visible = True
        SaveBtn.Visible = True
        UpdateBtn.Visible = True
        PreviewBtn.Visible = True
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    'Edit Mode Button

    'Edit ModeImage Contral Buttons

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

    'Edit Mode Main Buttons

    Private Sub PreviewBtn_Click(sender As Object, e As EventArgs) Handles PreviewBtn.Click
        Guna2GroupBox1.Visible = True
        EditBtn.Visible = True
        CloseBtn.Visible = True
        Guna2GroupBox2.Visible = False
        SaveBtn.Visible = False
        UpdateBtn.Visible = False
        PreviewBtn.Visible = False
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If Len(Trim(txtCenterName.Text)) = 0 Then
                MessageBox.Show("Please enter Center Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCenterName.Focus()
                Exit Sub
            End If

            If Len(Trim(txtOwner.Text)) = 0 Then
                MessageBox.Show("Please select Owner Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtOwner.Focus()
                Exit Sub
            End If

            If Len(Trim(txtEmailID.Text)) = 0 Then
                MessageBox.Show("Please enter Email ID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmailID.Focus()
                Exit Sub
            End If

            If Len(Trim(txtCenterCode.Text)) = 0 Then
                MessageBox.Show("Please enter Center Code ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCenterCode.Focus()
                Exit Sub
            End If

            If Len(Trim(txtEstablishedYear.Text)) = 0 Then
                MessageBox.Show("Please enter Establish Year ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEstablishedYear.Focus()
                Exit Sub
            End If

            If Len(Trim(txtContactNo.Text)) = 0 Then
                MessageBox.Show("Please enter Contact No. ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContactNo.Focus()
                Exit Sub
            End If

            If Len(Trim(txtEmailID.Text)) = 0 Then
                MessageBox.Show("Please enter Email ID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmailID.Focus()
                Exit Sub
            End If

            If txtContactNo.Text.Length < 8 Then
                MessageBox.Show("Contact No. is not vaild !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContactNo.Focus()
                Exit Sub
            End If

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Address ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddress.Focus()
                Exit Sub
            End If

            '----------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into CenterInfo(Name, Owner, EmailID, Website, CenterCode, EstablishYear, ContactNo, AltContactno, Address, Photo) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtCenterName.Text)
            cmd.Parameters.AddWithValue("@d2", txtOwner.Text)
            cmd.Parameters.AddWithValue("@d3", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d4", txtWebsite.Text)
            cmd.Parameters.AddWithValue("@d5", txtCenterCode.Text)
            cmd.Parameters.AddWithValue("@d6", txtEstablishedYear.Text)
            cmd.Parameters.AddWithValue("@d7", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d8", txtAltContactNo.Text)
            cmd.Parameters.AddWithValue("@d9", txtAddress.Text)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PIC1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d10", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            con.Close()

            '-------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into CenterCode(CenterCode) values(@d1)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtCenterCode.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            '---------------------------------------------------------------------------------------------------------------

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, "added Center Information '" & txtCenterName.Text & "' has Center Code '" & txtCenterCode.Text & "'")
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            SaveBtn.Enabled = False
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            Getdata()
            frmHome.DisplayUserPic()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            If Len(Trim(txtCenterName.Text)) = 0 Then
                MessageBox.Show("Please enter Center Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCenterName.Focus()
                Exit Sub
            End If

            If Len(Trim(txtOwner.Text)) = 0 Then
                MessageBox.Show("Please select Owner Name ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtOwner.Focus()
                Exit Sub
            End If

            If Len(Trim(txtEmailID.Text)) = 0 Then
                MessageBox.Show("Please enter Email ID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmailID.Focus()
                Exit Sub
            End If

            If Len(Trim(txtCenterCode.Text)) = 0 Then
                MessageBox.Show("Please enter Center Code ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCenterCode.Focus()
                Exit Sub
            End If

            If Len(Trim(txtEstablishedYear.Text)) = 0 Then
                MessageBox.Show("Please enter Establish Year ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEstablishedYear.Focus()
                Exit Sub
            End If

            If Len(Trim(txtContactNo.Text)) = 0 Then
                MessageBox.Show("Please enter Contact No. ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContactNo.Focus()
                Exit Sub
            End If

            If Len(Trim(txtEmailID.Text)) = 0 Then
                MessageBox.Show("Please enter Email ID ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmailID.Focus()
                Exit Sub
            End If

            If txtContactNo.Text.Length < 8 Then
                MessageBox.Show("Contact No. is not vaild !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContactNo.Focus()
                Exit Sub
            End If

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Address ?", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddress.Focus()
                Exit Sub
            End If

            '------------------------------------------------------------------------------------------------------------------------

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update CenterInfo Set Name = @d1, Owner = @d2, EmailID = @d3, Website = @d4, CenterCode = @d5, EstablishYear = @d6, ContactNo = @d7, AltContactno = @d8, Address = @d9, Photo = @d10 where CenterCode = @d11"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtCenterName.Text)
            cmd.Parameters.AddWithValue("@d2", txtOwner.Text)
            cmd.Parameters.AddWithValue("@d3", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d4", txtWebsite.Text)
            cmd.Parameters.AddWithValue("@d5", txtCenterCode.Text)
            cmd.Parameters.AddWithValue("@d6", txtEstablishedYear.Text)
            cmd.Parameters.AddWithValue("@d7", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d8", txtAltContactNo.Text)
            cmd.Parameters.AddWithValue("@d9", txtAddress.Text)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PIC1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d10", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.Parameters.AddWithValue("@d11", txtCenterCodeChange.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            '------------------------------------------------------------------------------------------------------------------------

            If lblUserID.Text = "146546" And lblUserName.Text = "Deepak" Then
                MessageBox.Show("Successfully Update", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                LogFunc(lblUserID.Text, lblUserName.Text, "Update Center Information '" & txtCenterName.Text & "' has Center Code '" & txtCenterCode.Text & "'")
                MessageBox.Show("Successfully Update", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            SaveBtn.Enabled = False
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()

            Getdata()
            frmHome.DisplayUserPic()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------- Button Section End --------------

    'Close Picture

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Close()
    End Sub

End Class