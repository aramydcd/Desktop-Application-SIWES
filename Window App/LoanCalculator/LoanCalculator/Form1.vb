Public Class Form1
    Dim LoanAmount As Double
    Dim LoanDuration As Integer
    Dim MonthlyRepayment, MonthlyInterest, TotalMonthlyRepayment, TotalMonthlyInterestAfterDuration, TotalMonthlyRepaymentAfterDuration As Double
    Dim FixedInterest = 1.5
    Dim isValid = False


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate.Click
        CheckCalc()
        If (isValid) Then
            If ((LoanAmount >= 100) And Not (AmountTxt.Text = "")) Then
                Me.Height = 602
                LoadDataTable()
            Else
                DataGridView1.Visible = False
                HideTotal()
                MsgBox("You Are Only Eligible To Borrow N100 And Above!")
            End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.ClearSelection()
    End Sub

    Private Sub AmountTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmountTxt.TextChanged
        resetLoanDataTable()
        If (AmountTxt.Text <> "") Then
            If ((Double.TryParse(AmountTxt.Text, LoanAmount) And (LoanAmount > 0))) Then
                ' CheckCalc()

            Else
                If (AmountTxt.Text = "0") Then
                    AmountTxt.Text = ""
                    MessageBox.Show("Loan Amount Should Be Greater Than 0!", "Loan App", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (AmountTxt.Text.Length > 0) Then
                    AmountTxt.Text = AmountTxt.Text.Remove(AmountTxt.Text.Length - 1)
                    MessageBox.Show("Loan Amount Can Only Be Numbers!", "Loan App", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If
        End If

    End Sub

    Private Sub DurationTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DurationTxt.TextChanged
        resetLoanDataTable()
        If (DurationTxt.Text <> "") Then
            If ((Integer.TryParse(DurationTxt.Text, LoanDuration) And (LoanDuration > 0))) Then
                ' CheckCalc()

            Else
                If (DurationTxt.Text = "0") Then
                    DurationTxt.Text = ""
                    MessageBox.Show("Loan Duration In Month Should Be Greater Than 0!", "Loan App", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (DurationTxt.Text.Length > 0) Then
                    DurationTxt.Text = DurationTxt.Text.Remove(DurationTxt.Text.Length - 1)
                    MessageBox.Show("Loan Duration In Month Can Only Be Numbers!", "Loan App", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If

    End Sub

    Sub resetLoanDataTable()
        Me.Height = 271
        isValid = False
        HideTotal()
        DataGridView1.Rows.Clear()
        DataGridView1.Visible = False
        TotalMonthlyInterestAfterDuration = 0
        TotalMonthlyRepaymentAfterDuration = 0
    End Sub

    Sub CheckCalc()
        If ((AmountTxt.Text = "") And (DurationTxt.Text = "")) Then
            MessageBox.Show("Please,provide Loan Amount and Loan Duration to continue!", "Loan App", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (AmountTxt.Text = "") Then
            MessageBox.Show("Please,provide Loan Amount to continue!", "Loan App", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (DurationTxt.Text = "") Then
            MessageBox.Show("Please,provide Loan Duration to continue!", "Loan App", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            isValid = True

        End If
    End Sub

    Sub GetLoanInformation()

        MonthlyRepayment = LoanAmount / LoanDuration

        Dim amount = LoanAmount

        For monthValue = 1 To LoanDuration
            Dim newMonthValue, newMonthlyRepayment, newMonthlyInterest, newTotalMonthlyRepayment As String

            MonthlyInterest = (FixedInterest / 100) * amount
            TotalMonthlyRepayment = MonthlyRepayment + MonthlyInterest

            newMonthValue = " " + monthValue.ToString
            newMonthlyRepayment = "N" + Format(MonthlyRepayment, ("N2")).ToString
            newMonthlyInterest = "N" + Format(MonthlyInterest, ("N2")).ToString
            newTotalMonthlyRepayment = "N" + Format(TotalMonthlyRepayment, ("N2")).ToString

            DataGridView1.Rows.Add(newMonthValue, newMonthlyRepayment, newMonthlyInterest, newTotalMonthlyRepayment)

            TotalMonthlyInterestAfterDuration += MonthlyInterest
            TotalMonthlyRepaymentAfterDuration += TotalMonthlyRepayment

            amount -= MonthlyRepayment
        Next
    End Sub

    Sub LoadDataTable()
        Dim row = LoanDuration
        Dim BottomSpace = 0

        DataGridView1.ScrollBars = ScrollBars.None

        If (row < 5) Then
            If (row > 2) Then
                BottomSpace += row - 2
            End If
            DataGridView1.Height = 43 + (row * (26 + BottomSpace))
        ElseIf (row = 5) Then
            DataGridView1.Height = 188
        Else
            DataGridView1.Height = 188
            DataGridView1.ScrollBars = ScrollBars.Vertical
        End If

        GetLoanInformation()
        DataGridView1.Visible = True

        TotalMonthlyInterestTXT.Text = "N" + Format(TotalMonthlyInterestAfterDuration, ("N2")).ToString
        TotalMonthlyRepayementTXT.Text = "N" + Format(TotalMonthlyRepaymentAfterDuration, ("N2")).ToString
        Label5.Text = "TOTAL AFTER " + LoanDuration.ToString + " MONTH/S"
        ShowTotal()

    End Sub

    Sub ShowTotal()
        Label7.Visible = True
        Label6.Visible = True
        Label5.Visible = True
        TotalMonthlyInterestTXT.Visible = True
        TotalMonthlyRepayementTXT.Visible = True
        ClearBtn.Visible = True
    End Sub

    Sub HideTotal()
        Label5.Visible = False
        Label7.Visible = False
        Label6.Visible = False
        TotalMonthlyInterestTXT.Visible = False
        TotalMonthlyRepayementTXT.Visible = False
        ClearBtn.Visible = False
    End Sub

    Sub ResetVar()
        LoanAmount = 0
        LoanDuration = 0
        TotalMonthlyInterestAfterDuration = 0
        TotalMonthlyRepaymentAfterDuration = 0
    End Sub

    Private Sub ClearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBtn.Click
        AmountTxt.Text = ""
        DurationTxt.Text = ""
        ResetVar()
        HideTotal()
        Me.Height = 271

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 271
    End Sub

End Class
