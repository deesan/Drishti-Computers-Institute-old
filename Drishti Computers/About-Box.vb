Public NotInheritable Class FrmAboutBox

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

    Private Sub FrmAboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        LabelAbout.Text = String.Format("About {0}", ApplicationTitle)
        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        LabelDevelopedby.Text = My.Application.Info.CompanyName
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelDescription.Text = My.Application.Info.Description
        LabelDescription.MaximumSize = New Size(482, 80)
        LabelDescription.AutoSize = True
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

    ' Close Section

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        Me.Close()
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Me.Close()
    End Sub

End Class
