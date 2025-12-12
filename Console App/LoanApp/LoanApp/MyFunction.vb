Module MyFunction

    Sub GenerateLoanInformation(ByVal LoanAmount As Double, ByVal LoanDuration As Integer, Optional ByVal FixedInterest As Double = 1.5)
        'FUNCTION PROPERTIES:
        '- PARAMETER: LOAN AMOUNT
        '             LOAN DURATION IN MONTH
        '- OUTPUT: A TABLE SHOWING THE TOTAL BREAKDOWN OF LOAN REPAYMENT WITHIN THE DURATION IN MONTH AND IT CORRESPONDING INTEREST

        Dim MonthlyRepayment, MonthlyInterest, TotalMonthlyRepayment, TotalMonthlyInterestAfterDuration,
            TotalMonthlyRepaymentAfterDuration As Double
        Dim counter As Integer

        MonthlyRepayment = LoanAmount / LoanDuration
        Console.WriteLine("----------------------------------------")
        Console.WriteLine("LOAN INFORMATION AND REPAYMENT BREAKDOWN")
        Console.WriteLine("----------------------------------------")
        Console.WriteLine("LOAN AMOUNT: N" & Format(LoanAmount, ("N2")).ToString)
        Console.WriteLine("LOAN DURATION(MONTH): " & LoanDuration.ToString)
        Console.WriteLine("PERCENTAGE INTEREST(%): " & FixedInterest.ToString & "%")
        Console.WriteLine("-------------------------------------------------------------------------")
        Console.WriteLine("|MONTHS | MONTHLY REPAYMENT | MONTHLY INTEREST | TOTAL MONTHLY REPAYMENT|")

        For counter = 1 To LoanDuration
            Dim newCounter, newMonthlyRepayment, newMonthlyInterest, newTotalMonthlyRepayment As String

            MonthlyInterest = (FixedInterest / 100) * LoanAmount
            TotalMonthlyRepayment = MonthlyRepayment + MonthlyInterest
            newCounter = " " + counter.ToString
            newMonthlyRepayment = "N" + Format(MonthlyRepayment, ("N2")).ToString
            newMonthlyInterest = "N" + Format(MonthlyInterest, ("N2")).ToString
            newTotalMonthlyRepayment = "N" + Format(TotalMonthlyRepayment, ("N2")).ToString
            TotalMonthlyInterestAfterDuration += MonthlyInterest
            TotalMonthlyRepaymentAfterDuration += TotalMonthlyRepayment

            Console.WriteLine("|-------|-------------------|------------------|------------------------|")
            Console.WriteLine(newCounter + "       " + newMonthlyRepayment + "         " + newMonthlyInterest + "          " +
                              newTotalMonthlyRepayment + "              ")
            LoanAmount -= MonthlyRepayment
        Next
        Console.WriteLine("----------------------------|------------------|-------------------------")
        Console.WriteLine(" TOTAL AFTER " + LoanDuration.ToString + " MONTH/S      |N" + Format(TotalMonthlyInterestAfterDuration, ("N2")) +
                          "        |N" + Format(TotalMonthlyRepaymentAfterDuration, ("N2")) + "             |")
        Console.WriteLine("-------------------------------------------------------------------------")

    End Sub

    Sub RestartProgram(ByVal CallingVar As String)
        'FUNCTION PROPERTIES:
        '- PARAMETER: CallingVar REPRESENT A VARIABLE WHICH VALUE IS USE TO DETERMINE IF PROGRAM SHOULD RESTART OR NOT.

        Do
            Console.WriteLine(vbLf & "DO YOU WANT TO KEEP CALCULATING? Press Y/ENTER FOR YES, N/Q FOR NO/QUIT")
            CallingVar = Console.ReadLine().ToUpper

            If ((CallingVar = "Y") Or (CallingVar = "")) Then
                Console.Clear()
                Exit Do
            ElseIf ((CallingVar = "N") Or (CallingVar = "Q")) Then
                End
                Exit Do
            Else
                CallingVar = " "
            End If

        Loop While True

    End Sub

    Function ErrorMessageForString(ByVal PlaceOfError As String) As String
        'FUNCTION PROPERTIES:
        '- PARAMETER: PlaceOfError REPRESENT THE VARIABLE THAT HOLD THE VALUE FOR WHICH USER INPUT WAS INVALID
        '- RETURN: A STRING OF ERROR MESSAGE

        Return "Invalid input. Please enter a valid " + PlaceOfError + "."
    End Function

End Module
