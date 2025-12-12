Public Class Form1

    Private Sub Closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Closebtn.Click
        Me.Close()
    End Sub


    Private Sub Closebtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Closebtn.MouseHover
        ForeColor = Color.White
    End Sub


    Private Sub Closebtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Closebtn.MouseLeave
        ForeColor = Color.Black
    End Sub


    Private Sub Logbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logbtn.Click
        PanelWelcome.Hide()
        PanelLogIn.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ContainerLogin.Hide()
        PanelCreateAcc.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub
End Class
