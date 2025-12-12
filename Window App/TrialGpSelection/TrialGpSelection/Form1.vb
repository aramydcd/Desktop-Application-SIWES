Public Class Form1

    Private Sub ComboBoxLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxLevel.SelectedIndexChanged
        Dim SelectedLevel = ComboBoxLevel.SelectedItem.ToString()

        If (SelectedLevel = "ND1") Then
            Label3.Text = "NATIONAL DIPLOMA 1"
        ElseIf (SelectedLevel = "ND2") Then
            Label3.Text = "NATIONAL DIPLOMA 2"
        ElseIf (SelectedLevel = "HND1") Then
            Label3.Text = "HIGHER NATIONAL DIPLOMA 1"
        Else
            Label3.Text = "HIGHER NATIONAL DIPLOMA 2"
        End If
           

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
