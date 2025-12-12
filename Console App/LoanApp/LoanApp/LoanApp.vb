Imports System
Module LoanApp
    Sub Main()
        Dim stLoanAmount, stLoanDuration As String
        Dim RestartChoice As String = " "
        Dim Msg As String = ""
        Do
            Console.WriteLine("LOAN APP")
            Console.WriteLine("--------")
            Try
                Console.WriteLine(vbLf & "ENTER LOAN AMOUNT(N):")
                stLoanAmount = Console.ReadLine()
                Msg = MyFunction.ErrorMessageForString("loan amount")
                Dim LoanAmount As Double = Double.Parse(stLoanAmount)
                If (LoanAmount >= 1) Then
                    Console.WriteLine(vbLf & "ENTER LOAN DURATION(MONTH):")
                    stLoanDuration = Console.ReadLine()
                    Msg = MyFunction.ErrorMessageForString("loan duration")
                    Dim LoanDuration As Decimal = Decimal.Parse(stLoanDuration)
                    If (LoanDuration >= 1) Then
                        MyFunction.GenerateLoanInformation(LoanAmount, LoanDuration)
                        MyFunction.RestartProgram(RestartChoice)
                    Else
                        Console.WriteLine()
                        Console.WriteLine("-----------------------------------------")
                        Console.WriteLine("LOAN DURATION SHOULD BE 1 MONTH AND ABOVE")
                        Console.WriteLine("-----------------------------------------")
                        MyFunction.RestartProgram(RestartChoice)
                    End If
                Else
                    Console.WriteLine()
                    Console.WriteLine("-------------------------------------")
                    Console.WriteLine("LOAN AMOUNT SHOULD BE N1.00 AND ABOVE")
                    Console.WriteLine("-------------------------------------")
                    MyFunction.RestartProgram(RestartChoice)
                End If
            Catch ex As FormatException
                Console.WriteLine()
                Console.WriteLine("------------------------------------------------")
                Console.WriteLine(Msg)
                Console.WriteLine("------------------------------------------------")
                MyFunction.RestartProgram(RestartChoice)
            End Try
        Loop Until (RestartChoice = "N")
        RestartChoice = "N"
        Console.ReadLine()
    End Sub
End Module
