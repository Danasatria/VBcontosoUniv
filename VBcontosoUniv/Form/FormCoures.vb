Imports System.Data.SqlClient
Public Class FormCoures
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
    Sub KondisiAwal()
        Call Koneksi()
        da = New SqlDataAdapter("Select * from course", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Course")
        DataGridView1.DataSource = (ds.Tables("Course"))
        Call kosong()
    End Sub
    Sub Kosong()
        TextID.Text = ""
        TextTL.Text = ""
        TextCS.Text = ""
    End Sub

    Private Sub FormCoures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        Call Koneksi()
        Dim InputData1 As String = "insert into Course values ('" & TextID.Text & "','" & TextTL.Text & "','" & TextCS.Text & "')"
        Cmd = New SqlCommand(InputData1, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input success")
        Call KondisiAwal()
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles Btnedit.Click
        Call Koneksi()
        Dim EditData As String = "update Course set Title='" & TextTL.Text & "',Credits='" & TextCS.Text & "' where CourseID= '" & TextID.Text & "'"
        Cmd = New SqlCommand(EditData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Edit success")
        Call KondisiAwal()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Call Koneksi()
        Dim DeleteData As String = "Delete Course where CourseID = '" & TextID.Text & "'"
        Cmd = New SqlCommand(DeleteData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Delete success")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextID.Text = DataGridView1.Item(0, i).Value
        TextTL.Text = DataGridView1.Item(1, i).Value
        TextCS.Text = DataGridView1.Item(2, i).Value
    End Sub
End Class