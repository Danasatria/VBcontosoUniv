Imports System.Data.SqlClient
Public Class FormEnrollment
    Dim Conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim ds As DataSet
    Dim LokasiDB As String
    Sub Koneksi()
        LokasiDB = "data source=MSI;initial catalog=contoso;integrated security =true"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Sub KondisiAwal()
        Call Koneksi()
        da = New SqlDataAdapter("Select * from enrollment", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Enrollment")
        DataGridView1.DataSource = (ds.Tables("Enrollment"))
        Call kosong()
    End Sub
    Sub Kosong()
        TextEID.Text = ""
        ComboCS.Text = ""
        ComboSD.Text = ""
        ComboG.Text = ""
    End Sub

    Private Sub FormEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()

        Try
            Dim Cmd As New SqlCommand("Select * from Student ", Conn)

            Dim Ad As New SqlDataAdapter(Cmd)

            Dim Table As New DataTable()

            Ad.Fill(Table)

            ComboSD.DataSource = Table
            ComboSD.DisplayMember = "LastName"
            ComboSD.ValueMember = "ID"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try

        Try
            Dim Cmd As New SqlCommand("Select * from Course", Conn)

            Dim Ad As New SqlDataAdapter(Cmd)

            Dim Table As New DataTable()

            Ad.Fill(Table)

            ComboCS.DataSource = Table
            ComboCS.DisplayMember = "Title"
            ComboCS.ValueMember = "CourseID"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try

        Try
            Dim Cmd As New SqlCommand("Select * from Grade", Conn)

            Dim Ad As New SqlDataAdapter(Cmd)

            Dim Table As New DataTable()

            Ad.Fill(Table)

            ComboG.DataSource = Table
            ComboG.DisplayMember = "Grade"
            ComboG.ValueMember = "GradeID"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Call Koneksi()
        Dim insert As String
        insert = "set identity_insert Enrollment on; "
        insert &= "insert into Enrollment (EnrollmentID, CourseID, StudentID, Grade) values ('" & TextEID.Text & "','" & ComboCS.DropDownStyle & "','" & ComboSD.DropDownStyle & "','" & ComboG.DropDownStyle & "'); "
        insert &= "set identity_insert Enrollment off; "
        Cmd = New SqlCommand(insert, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input success")
        Call KondisiAwal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Call Koneksi()
        Dim EditData As String = "update Enrollment set CourseID='" & ComboCS.SelectedIndex & "',StudentID='" & ComboSD.SelectedIndex & "',Grade='" & ComboG.SelectedIndex & "' where EnrollmentID = '" & TextEID.Text & "'"
        Cmd = New SqlCommand(EditData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Edit success")
        Call KondisiAwal()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Call Koneksi()
        Dim DeleteData As String = "Delete Enrollment where EnrollmentID = '" & TextEID.Text & "'"
        Cmd = New SqlCommand(DeleteData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Delete success")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextEID.Text = DataGridView1.Item(0, i).Value
        ComboCS.Text = DataGridView1.Item(1, i).Value
        ComboSD.Text = DataGridView1.Item(2, i).Value
        ComboG.Text = DataGridView1.Item(3, i).Value
    End Sub

End Class