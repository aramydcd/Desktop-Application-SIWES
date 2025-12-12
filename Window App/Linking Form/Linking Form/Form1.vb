Public Class Form1
    Dim form2 As New Form2()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        form2.ShowDialog()
    End Sub
End Class
