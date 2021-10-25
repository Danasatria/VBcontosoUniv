<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCoures
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
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.TextCS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextTL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btnedit)
        Me.GroupBox1.Controls.Add(Me.Btnadd)
        Me.GroupBox1.Controls.Add(Me.TextCS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextTL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 450)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form"
        '
        'Btnedit
        '
        Me.Btnedit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnedit.Location = New System.Drawing.Point(3, 389)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(216, 29)
        Me.Btnedit.TabIndex = 7
        Me.Btnedit.Text = "Edit"
        Me.Btnedit.UseVisualStyleBackColor = True
        '
        'Btnadd
        '
        Me.Btnadd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnadd.Location = New System.Drawing.Point(3, 418)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(216, 29)
        Me.Btnadd.TabIndex = 6
        Me.Btnadd.Text = "Input"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'TextCS
        '
        Me.TextCS.Location = New System.Drawing.Point(6, 217)
        Me.TextCS.Name = "TextCS"
        Me.TextCS.Size = New System.Drawing.Size(189, 27)
        Me.TextCS.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Credits"
        '
        'TextTL
        '
        Me.TextTL.Location = New System.Drawing.Point(6, 137)
        Me.TextTL.Name = "TextTL"
        Me.TextTL.Size = New System.Drawing.Size(189, 27)
        Me.TextTL.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Title"
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(6, 65)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(125, 27)
        Me.TextID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btndelete)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(222, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 450)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Table"
        '
        'Btndelete
        '
        Me.Btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndelete.Location = New System.Drawing.Point(443, 403)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(123, 29)
        Me.Btndelete.TabIndex = 8
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(550, 361)
        Me.DataGridView1.TabIndex = 0
        '
        'FormCoures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCoures"
        Me.Text = "FormCoures"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btnadd As Button
    Friend WithEvents TextCS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextTL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btndelete As Button
    Friend WithEvents Btnedit As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
