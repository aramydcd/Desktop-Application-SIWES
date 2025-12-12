Public Class LoginForm

    Dim form2 As New CreateAccountForm()

    Private Sub Closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Closebtn.Click
        Me.Close()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        form2.Show()
        Me.Hide()
    End Sub
End Class

