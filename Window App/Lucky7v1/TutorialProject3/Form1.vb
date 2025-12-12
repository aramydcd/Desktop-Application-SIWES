Public Class ApplicationForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Visible = False ' hide picture
        Label1.Text = CStr(Int(Rnd() * 10)) ' pick numbers
        Label5.Text = CStr(Int(Rnd() * 10))
        Label2.Text = CStr(Int(Rnd() * 10))
        ' if any number is 7 display picture and beep
        If (Label1.Text = "7") Or (Label2.Text = "7") _
        Or (Label5.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
        End If
    End Sub

    Private Sub Button2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub ApplicationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()

    End Sub
End Class




