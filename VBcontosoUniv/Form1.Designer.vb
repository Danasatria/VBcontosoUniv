<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btns = New FontAwesome.Sharp.IconButton()
        Me.btne = New FontAwesome.Sharp.IconButton()
        Me.btnc = New FontAwesome.Sharp.IconButton()
        Me.btna = New FontAwesome.Sharp.IconButton()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Formname = New System.Windows.Forms.Label()
        Me.Iconform = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDeks = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Iconform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDeks.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.btns)
        Me.PanelMenu.Controls.Add(Me.btne)
        Me.PanelMenu.Controls.Add(Me.btnc)
        Me.PanelMenu.Controls.Add(Me.btna)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 570)
        Me.PanelMenu.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btns
        '
        Me.btns.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btns.FlatAppearance.BorderSize = 0
        Me.btns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btns.ForeColor = System.Drawing.Color.Gainsboro
        Me.btns.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btns.IconColor = System.Drawing.Color.White
        Me.btns.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btns.IconSize = 31
        Me.btns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btns.Location = New System.Drawing.Point(0, 136)
        Me.btns.Name = "btns"
        Me.btns.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btns.Size = New System.Drawing.Size(220, 60)
        Me.btns.TabIndex = 7
        Me.btns.Text = "Student"
        Me.btns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btns.UseVisualStyleBackColor = True
        '
        'btne
        '
        Me.btne.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btne.FlatAppearance.BorderSize = 0
        Me.btne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btne.ForeColor = System.Drawing.Color.Gainsboro
        Me.btne.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.btne.IconColor = System.Drawing.Color.White
        Me.btne.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btne.IconSize = 32
        Me.btne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btne.Location = New System.Drawing.Point(0, 196)
        Me.btne.Name = "btne"
        Me.btne.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btne.Size = New System.Drawing.Size(220, 60)
        Me.btne.TabIndex = 6
        Me.btne.Text = "Enrollment"
        Me.btne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btne.UseVisualStyleBackColor = True
        '
        'btnc
        '
        Me.btnc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnc.FlatAppearance.BorderSize = 0
        Me.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnc.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnc.IconChar = FontAwesome.Sharp.IconChar.ListOl
        Me.btnc.IconColor = System.Drawing.Color.White
        Me.btnc.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnc.IconSize = 32
        Me.btnc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnc.Location = New System.Drawing.Point(0, 256)
        Me.btnc.Name = "btnc"
        Me.btnc.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnc.Size = New System.Drawing.Size(220, 60)
        Me.btnc.TabIndex = 5
        Me.btnc.Text = "Coures"
        Me.btnc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnc.UseVisualStyleBackColor = True
        '
        'btna
        '
        Me.btna.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btna.FlatAppearance.BorderSize = 0
        Me.btna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btna.ForeColor = System.Drawing.Color.Gainsboro
        Me.btna.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        Me.btna.IconColor = System.Drawing.Color.White
        Me.btna.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btna.IconSize = 32
        Me.btna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btna.Location = New System.Drawing.Point(0, 316)
        Me.btna.Name = "btna"
        Me.btna.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btna.Size = New System.Drawing.Size(220, 60)
        Me.btna.TabIndex = 4
        Me.btna.Text = "About"
        Me.btna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btna.UseVisualStyleBackColor = True
        '
        'PictureLogo
        '
        Me.PictureLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(100, 50)
        Me.PictureLogo.TabIndex = 0
        Me.PictureLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Formname)
        Me.Panel1.Controls.Add(Me.Iconform)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 75)
        Me.Panel1.TabIndex = 1
        '
        'Formname
        '
        Me.Formname.AutoSize = True
        Me.Formname.ForeColor = System.Drawing.Color.Gainsboro
        Me.Formname.Location = New System.Drawing.Point(64, 30)
        Me.Formname.Name = "Formname"
        Me.Formname.Size = New System.Drawing.Size(50, 20)
        Me.Formname.TabIndex = 1
        Me.Formname.Text = "Home"
        '
        'Iconform
        '
        Me.Iconform.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Iconform.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Iconform.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.Iconform.IconColor = System.Drawing.Color.DeepSkyBlue
        Me.Iconform.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconform.Location = New System.Drawing.Point(24, 24)
        Me.Iconform.Name = "Iconform"
        Me.Iconform.Size = New System.Drawing.Size(34, 32)
        Me.Iconform.TabIndex = 0
        Me.Iconform.TabStop = False
        '
        'PanelDeks
        '
        Me.PanelDeks.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelDeks.Controls.Add(Me.PictureBox2)
        Me.PanelDeks.Controls.Add(Me.Label3)
        Me.PanelDeks.Controls.Add(Me.Label1)
        Me.PanelDeks.Controls.Add(Me.Label5)
        Me.PanelDeks.Controls.Add(Me.Label2)
        Me.PanelDeks.Controls.Add(Me.PictureBox5)
        Me.PanelDeks.Controls.Add(Me.PictureBox4)
        Me.PanelDeks.Controls.Add(Me.PictureBox3)
        Me.PanelDeks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDeks.Location = New System.Drawing.Point(220, 75)
        Me.PanelDeks.Name = "PanelDeks"
        Me.PanelDeks.Size = New System.Drawing.Size(811, 495)
        Me.PanelDeks.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(304, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 125)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(641, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 28)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(183, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Smk Taruna Bhakti"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(382, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 28)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TKJ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(121, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RPL"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(584, 242)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(159, 148)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(325, 242)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(159, 148)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(64, 242)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 148)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 570)
        Me.Controls.Add(Me.PanelDeks)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Iconform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDeks.ResumeLayout(False)
        Me.PanelDeks.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PictureLogo As PictureBox
    Friend WithEvents btne As FontAwesome.Sharp.IconButton
    Friend WithEvents btnc As FontAwesome.Sharp.IconButton
    Friend WithEvents btna As FontAwesome.Sharp.IconButton
    Friend WithEvents iconh As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Formname As Label
    Friend WithEvents Iconform As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btns As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDeks As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
