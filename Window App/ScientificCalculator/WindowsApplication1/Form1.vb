'Module Module1
'    Sub Main()
'        Dim fn, Sn, Op As String
'        If 


'    End Sub
'End Module


Public Class Calculator
    Dim fn, Sn As String
    Dim OperationHasStarted, FnIsValid, SnIsValid As Boolean

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OperationHasStarted = False

    End Sub

    Private Sub btnzero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnzero.Click
        If (ResultInterface.Text <> "0") Then
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "0"
            Else
                ResultInterface.Text += "0"
            End If

            fn = ResultInterface.Text

        End If

    End Sub

    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "1"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "1"
            Else
                ResultInterface.Text += "1"
            End If

        End If

        fn = ResultInterface.Text
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "2"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "2"
            Else
                ResultInterface.Text += "2"
            End If

        End If
        fn = ResultInterface.Text
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "3"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "3"
            Else
                ResultInterface.Text += "3"
            End If

        End If
        fn = ResultInterface.Text
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "4"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "4"
            Else
                ResultInterface.Text += "4"
            End If

        End If
        fn = ResultInterface.Text
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "5"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "5"
            Else
                ResultInterface.Text += "5"
            End If

        End If
        fn = ResultInterface.Text
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "6"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "6"
            Else
                ResultInterface.Text += "6"
            End If

        End If
        fn = ResultInterface.Text
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "7"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "7"
            Else
                ResultInterface.Text += "7"
            End If

        End If
        fn = ResultInterface.Text
    End Sub

    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "8"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "8"
            Else
                ResultInterface.Text += "8"
            End If

        End If
        fn = ResultInterface.Text
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "9"
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "9"
            Else
                ResultInterface.Text += "9"
            End If

        End If
        fn = ResultInterface.Text
    End Sub

    Private Sub btnPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriod.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "."
        Else
            If (OperationHasStarted) Then
                UserInterfaceFeedback.Text += "."
            Else
                ResultInterface.Text += "."
            End If

        End If
        fn = ResultInterface.Text
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click

        ResultInterface.Text = "0"
        ResultInterface.Visible = False ' hj
        fn = "0"

    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click


        UserInterfaceFeedback.Visible = True 'rtyuhijk
        UserInterfaceFeedback.Text = fn 'gfhjk


    End Sub

    Private Sub btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplus.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "0"
        Else
            OperationHasStarted = True
            UserInterfaceFeedback.Visible = True
            fn = ResultInterface.Text

            UserInterfaceFeedback.Text += "+"
        End If

    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "0"
        Else
            OperationHasStarted = True
            UserInterfaceFeedback.Visible = True
            fn = ResultInterface.Text

            UserInterfaceFeedback.Text += "-"

        End If

    End Sub

    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduct.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "0"
        Else
            OperationHasStarted = True
            UserInterfaceFeedback.Visible = True
            fn = ResultInterface.Text

            UserInterfaceFeedback.Text += "*"

        End If

    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click

        If (ResultInterface.Text = "0") Then
            ResultInterface.Text = "0"
        Else
            OperationHasStarted = True
            UserInterfaceFeedback.Visible = True
            fn = ResultInterface.Text

            UserInterfaceFeedback.Text += "/"

        End If

    End Sub

    Private Sub ResultInterface_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultInterface.Click

    End Sub
End Class
