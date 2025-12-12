Module Module1
    Sub Main()
        Console.WriteLine("SIMPLE CALCULATOR")
        Console.WriteLine("-------------------")
        Dim Firstnumber, SecondNumber As Decimal
        Dim OperatorKey, result As String

        Console.WriteLine("ENTER FIRST NUMBER:")
        Firstnumber = Console.ReadLine()
        Console.WriteLine(vbLf & "PRESS 1 TO ADD" & vbLf & "PRESS 2 TO SUBTRACT" & vbLf & "PRESS 3 TO MULTIPLY" & vbLf & "PRESS 4 TO DIVIDE")
        OperatorKey = Console.ReadLine()

        If ((OperatorKey = "1") Or (OperatorKey = "2") Or (OperatorKey = "3") Or (OperatorKey = "4")) Then
            Console.WriteLine(vbLf & "ENTER SECOND NUMBER:")
            SecondNumber = Console.ReadLine()

            If (OperatorKey = "1") Then
                result = Firstnumber + SecondNumber

            ElseIf (OperatorKey = "2") Then
                result = Firstnumber - SecondNumber

            ElseIf (OperatorKey = "3") Then
                result = Firstnumber * SecondNumber

            Else
                If ((Firstnumber = 0) Or (SecondNumber = 0)) Then
                    result = "Can't divide by 0"
                Else
                    result = Firstnumber / SecondNumber
                End If

            End If

            Console.WriteLine("-------------------")
            Console.WriteLine("RESULT: " & result)
            Console.WriteLine("-------------------")

        Else
            Console.WriteLine("--------------------")
            Console.WriteLine("Invalid Operator Key")
            Console.WriteLine("--------------------")

        End If
        Console.ReadLine()

    End Sub
End Module
