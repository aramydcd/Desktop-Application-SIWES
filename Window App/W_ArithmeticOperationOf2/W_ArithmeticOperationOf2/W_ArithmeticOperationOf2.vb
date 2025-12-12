Imports System

Public Class W_ArithmeticOperationOf2

    Dim num1, num2, result As Double
    Dim UserChoosenOperator As String = ""


    Private Sub SumBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumBtn.Click

        UserChoosenOperator = "+"
        OperatorTxt.Text = UserChoosenOperator

    End Sub

    Private Sub DifferenceBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DifferenceBtn.Click

        UserChoosenOperator = "-"
        OperatorTxt.Text = UserChoosenOperator

    End Sub

    Private Sub FractionBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FractionBtn.Click

        UserChoosenOperator = "/"
        OperatorTxt.Text = UserChoosenOperator

    End Sub

    Private Sub ProductBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductBtn.Click

        UserChoosenOperator = "*"
        OperatorTxt.Text = UserChoosenOperator

    End Sub


    Function ProcessOperation(ByVal UserChoosenOperator As String) As Double
        'FUNCTION PROPERTIES:
        '- PARAMETER: UserChoosenOperator WHICH CAN EITHER BE +,-,/, OR *
        '- RETURN VALUE: A DOUBLE WHICH IS A RESULT ON THE TWO OPERAND USER INPUTED USING THE UserChoosenOperator

        If (UserChoosenOperator = "+") Then
            Return num1 + num2
        ElseIf (UserChoosenOperator = "-") Then
            Return num1 - num2
        ElseIf (UserChoosenOperator = "/") Then
            Return num1 / num2
        Else
            Return num1 * num2
        End If

    End Function

    Private Sub CalculateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateBtn.Click

        NonEditTxts()

        If (((num1 = 0) Or (num2 = 0)) And (UserChoosenOperator = "/")) Then
            ResultTxt.Text = "CANNOT DIVIDE BY 0"
        Else
            result = ProcessOperation(UserChoosenOperator)
            ResultTxt.Text = result
        End If

        ShowResult()

        If (ResultTxt.Text <> "") Then
            HideNote()
            ClearBtn.Visible = True
        End If

    End Sub

    Private Sub ClearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBtn.Click

        Num1Txt.Text = ""
        Num2Txt.Text = ""
        EditTxts()
        UserChoosenOperator = ""
        OperatorTxt.Text = ""
        HideOperator()
        HideTxt2()
        OperatorTxt.Visible = False
        HideResult()
        ShowNote()

    End Sub


    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click

        End

    End Sub

    Private Sub Num1Txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num1Txt.TextChanged
        If (Num1Txt.Text <> "") Then
            If (Double.TryParse(Num1Txt.Text, num1)) Then
                CheckCalc()
                ShowOperator()
            Else
                Num1Txt.Text = ""
                'MsgBox("Please enter a number!")
            End If

        Else
            CheckCalc()
            If (UserChoosenOperator = "") Then
                HideOperator()
            End If

        End If

    End Sub

    Private Sub Num2Txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num2Txt.TextChanged

        If (Num2Txt.Text <> "") Then
            If (Double.TryParse(Num2Txt.Text, num2)) Then
                CheckCalc()
            Else
                Num2Txt.Text = ""
            End If
        Else
            CheckCalc()
        End If

    End Sub

    Private Sub OperatorTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperatorTxt.TextChanged

        OperatorTxt.Visible = True
        If (UserChoosenOperator <> "") Then
            ShowTxt2()
        End If

    End Sub

    Sub CheckCalc()
        If ((Num1Txt.Text = "") Or (Num2Txt.Text = "") Or (UserChoosenOperator = "")) Then
            CalculateBtn.Enabled = False
        Else
            CalculateBtn.Enabled = True
        End If
    End Sub

    Sub ShowOperator()
        Label5.Enabled = True
        SumBtn.Enabled = True
        ProductBtn.Enabled = True
        DifferenceBtn.Enabled = True
        FractionBtn.Enabled = True
    End Sub

    Sub HideOperator()
        Label5.Enabled = False
        SumBtn.Enabled = False
        ProductBtn.Enabled = False
        DifferenceBtn.Enabled = False
        FractionBtn.Enabled = False
    End Sub

    Sub ShowTxt2()
        Label3.Enabled = True
        Num2Txt.BorderStyle = BorderStyle.None
        Num2Txt.ReadOnly = False
    End Sub

    Sub HideTxt2()
        Label3.Enabled = False
        Num2Txt.BorderStyle = BorderStyle.FixedSingle
        Num2Txt.ReadOnly = True
    End Sub

    Sub ShowResult()
        Label4.Visible = True
        ResultTxt.Visible = True
    End Sub

    Sub HideResult()
        Label4.Visible = False
        ResultTxt.Visible = False
    End Sub

    Sub HideNote()
        CloseTxt.Visible = False
        CloseBtn.Visible = False
    End Sub

    Sub ShowNote()
        CloseTxt.Visible = True
        CloseBtn.Visible = True
    End Sub

    Sub NonEditTxts()
        Num1Txt.ReadOnly = True
        Num1Txt.BorderStyle = BorderStyle.FixedSingle
        Num2Txt.ReadOnly = True
        Num2Txt.BorderStyle = BorderStyle.FixedSingle
        HideOperator()
    End Sub

    Sub EditTxts()
        Num1Txt.ReadOnly = False
        Num1Txt.BorderStyle = BorderStyle.None
        Num2Txt.ReadOnly = False
        Num2Txt.BorderStyle = BorderStyle.None
        ShowOperator()
    End Sub
End Class
