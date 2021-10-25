Imports FontAwesome.Sharp
Public Class Form1
    'fileds
    Private currentBtn As IconButton
    Private leftBtn As Panel
    Private currentopen As Windows.Forms.Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBtn = New Panel()
        leftBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBtn)
    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableBtn()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBtn.BackColor = customColor
            leftBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBtn.Visible = True
            leftBtn.BringToFront()

            Iconform.IconChar = currentBtn.IconChar
            Iconform.IconColor = customColor
        End If
    End Sub

    Private Sub DisableBtn()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
        End If
    End Sub
    Private Sub OpenFormChilld(chilldform As Windows.Forms.Form)
        If currentopen IsNot Nothing Then
            currentopen.Close()
        End If
        currentopen = chilldform

        chilldform.TopLevel = False
        chilldform.FormBorderStyle = FormBorderStyle.None
        chilldform.Dock = DockStyle.Fill
        PanelDeks.Controls.Add(chilldform)
        PanelDeks.Tag = chilldform
        chilldform.BringToFront()
        chilldform.Show()
        Formname.Text = chilldform.Text
    End Sub

    Private Sub btna_Click(sender As Object, e As EventArgs) Handles btna.Click
        ActivateButton(sender, Color.FromArgb(21, 151, 229))
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        ActivateButton(sender, Color.FromArgb(21, 151, 229))
        OpenFormChilld(New FormCoures)
    End Sub

    Private Sub btne_Click(sender As Object, e As EventArgs) Handles btne.Click
        ActivateButton(sender, Color.FromArgb(21, 151, 229))
        OpenFormChilld(New FormEnrollment)
    End Sub

    Private Sub btns_Click_1(sender As Object, e As EventArgs) Handles btns.Click
        ActivateButton(sender, Color.FromArgb(21, 151, 229))
        OpenFormChilld(New FormStudent)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentopen IsNot Nothing Then
            currentopen.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        leftBtn.Visible = False
        Iconform.IconChar = IconChar.Home
        Iconform.IconColor = Color.DeepSkyBlue
        Formname.Text = "Home"
    End Sub

End Class
