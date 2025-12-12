Public Class Index

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        End

    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Black
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub
End Class
