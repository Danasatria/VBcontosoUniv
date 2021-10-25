<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnrollment
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboG = New System.Windows.Forms.ComboBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TextEID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboCS = New System.Windows.Forms.ComboBox()
        Me.ComboSD = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.ComboG)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.TextEID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboCS)
        Me.GroupBox1.Controls.Add(Me.ComboSD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 495)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form"
        '
        'ComboG
        '
        Me.ComboG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboG.FormattingEnabled = True
        Me.ComboG.Location = New System.Drawing.Point(8, 309)
        Me.ComboG.Name = "ComboG"
        Me.ComboG.Size = New System.Drawing.Size(204, 28)
        Me.ComboG.TabIndex = 11
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Location = New System.Drawing.Point(1, 420)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(216, 29)
        Me.BtnEdit.TabIndex = 10
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Location = New System.Drawing.Point(0, 455)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(217, 29)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Input"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TextEID
        '
        Me.TextEID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextEID.Location = New System.Drawing.Point(8, 66)
        Me.TextEID.Name = "TextEID"
        Me.TextEID.Size = New System.Drawing.Size(204, 27)
        Me.TextEID.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "EnrollmentID"
        '
        'ComboCS
        '
        Me.ComboCS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboCS.FormattingEnabled = True
        Me.ComboCS.Location = New System.Drawing.Point(8, 145)
        Me.ComboCS.Name = "ComboCS"
        Me.ComboCS.Size = New System.Drawing.Size(204, 28)
        Me.ComboCS.TabIndex = 5
        '
        'ComboSD
        '
        Me.ComboSD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboSD.FormattingEnabled = True
        Me.ComboSD.Location = New System.Drawing.Point(8, 231)
        Me.ComboSD.Name = "ComboSD"
        Me.ComboSD.Size = New System.Drawing.Size(204, 28)
        Me.ComboSD.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "StudentID"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CourseID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(230, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 495)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Table"
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(443, 411)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(123, 29)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(550, 361)
        Me.DataGridView1.TabIndex = 0
        '
        'FormEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 495)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEnrollment"
        Me.Text = "FormEnrollment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboCS As ComboBox
    Friend WithEvents ComboSD As ComboBox
    Friend WithEvents ComboGD As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextEID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents ComboG As ComboBox
End Class
