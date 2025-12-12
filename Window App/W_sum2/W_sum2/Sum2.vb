Imports System

Public Class Sum2

    Private Sub CalculateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateBtn.Click

        Dim num1, num2, result As Double

        Num1Txt.ForeColor = Color.Black
        Num2Txt.ForeColor = Color.Black
        If (Double.TryParse(Num1Txt.Text, num1)) Then
            If (Double.TryParse(Num2Txt.Text, num2)) Then
                result = num1 + num2
                ResultTxt.Text = result
            Else
                Num2Txt.ForeColor = Color.Red
            End If

        Else
            Num1Txt.ForeColor = Color.Red
        End If


        If (ResultTxt.Text <> "") Then
            ClearBtn.Visible = True

        End If

    End Sub

    Private Sub ClearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBtn.Click

        Num1Txt.Text = ""
        Num2Txt.Text = ""
        ResultTxt.Text = ""
        ClearBtn.Visible = False

    End Sub

End Class
