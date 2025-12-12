Public Class CreateAccountForm

    'Dim form1 As New Form1()

    Private Sub Closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Closebtn.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class