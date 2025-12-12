Public Class Form1
    Dim row = 10
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        'DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")
        'DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")
        'DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")
        'DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")
        'DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")
        'DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")
        'DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")
        'DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (row <= 5) Then
            DataGridView1.ScrollBars = ScrollBars.None
        End If

        DataGridView1.Height = DataGridView1.Height + (row * 21)

        DataGridView1.Visible = True
        DataGridView1.Rows.Add("1", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("2", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("3", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("4", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("5", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("6", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("7", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("8", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("9", "100,000", "9000", "109,000")
        DataGridView1.Rows.Add("10", "100,000", "9000", "109,000")

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.ClearSelection()
    End Sub
End Class
