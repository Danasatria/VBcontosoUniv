Imports System.Data.SqlClient
Public Class FormStudent
    Dim Conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim ds As DataSet
    Dim LokasiDB As String
    Sub Koneksi()
        LokasiDB = "data source=MSI;initial catalog=Contoso;integrated security =true"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Sub kondisiAwal()
        Call Koneksi()
        da = New SqlDataAdapter("Select * from student", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Student")
        DataGridView1.DataSource = (ds.Tables("Student"))
        Call kosong()
    End Sub
    Sub kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DateTimePicker1.Text = ""
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Dim InputData As String = "insert into Student values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Text & "')"
        Cmd = New SqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input success")
        Call kondisiAwal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Koneksi()
        Dim EditData As String = "update Student set LastName='" & TextBox1.Text & "',FirstMidName='" & TextBox2.Text & "',EnrollmentDate='" & DateTimePicker1.Text & "' where ID = '" & TextBox3.Text & "'"
        Cmd = New SqlCommand(EditData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Edit success")
        Call kondisiAwal()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Koneksi()
        Dim DeleteData As String = "Delete Student where ID = '" & TextBox3.Text & "'"
        Cmd = New SqlCommand(DeleteData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Delete success")
        Call kondisiAwal()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox3.Text = DataGridView1.Item(0, i).Value
        TextBox1.Text = DataGridView1.Item(1, i).Value
        TextBox2.Text = DataGridView1.Item(2, i).Value
        DateTimePicker1.Text = DataGridView1.Item(3, i).Value
    End Sub
End Class
