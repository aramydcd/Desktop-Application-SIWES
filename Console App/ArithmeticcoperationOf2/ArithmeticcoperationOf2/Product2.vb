Module Product2

    Sub Main()

        Console.WriteLine("THIS PROGRAM CALCULATE THE PRODUCT OF TWO  NUMBERS")
        Console.WriteLine("----------------------------------------------")


        Dim num1, num2, result As Integer

        Console.WriteLine("ENTER FIRST NUMBER: ")
        num1 = Console.ReadLine()

        Console.WriteLine("ENTER SECOND NUMBER: ")
        num2 = Console.ReadLine()

        result = num1 * num2
        Console.WriteLine("PRODUCT: " & result.ToString)


        Console.ReadLine()

    End Sub

End Module
