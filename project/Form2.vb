Public Class Form2
    Dim r As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "provider=microsoft.ace.oledb.12.0;data source=C:\Users\Owner\Documents\Database1.accdb"
        con.Open()
        MsgBox("connected")
        Dim sql As String = "select * from stock;"
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        da.Fill(ds, "stock")
        TextBox1.Text = ds.Tables("stock").Rows(r).Item(0)
        TextBox2.Text = ds.Tables("stock").Rows(r).Item(1)
        TextBox3.Text = ds.Tables("stock").Rows(r).Item(2)
        r = r + 1
        con.Close()

    End Sub
End Class