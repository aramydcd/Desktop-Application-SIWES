Module FactorialCalc

    Sub Main()
        Console.WriteLine("FACTORIAL CALCULATOR")
        Console.WriteLine("--------------------")
        Dim num, fact As Integer
        Dim Again As String


        Do
            Console.WriteLine(vbLf & "ENTER NUMBER ")
            num = Console.ReadLine()

            Console.WriteLine("--------------------")
            fact = MyFunction.LoopFactorialCalc(num)
            Console.WriteLine("FACTORIAL: " & fact.ToString)

            'fact = MyFunction.RecursiveFactorialCalc(num)
            'Console.WriteLine("FACTORIAL: " & fact.ToString)
            Console.WriteLine("--------------------")

            Console.WriteLine(vbLf & "Press any key to CONTINUE, Q for Quit/Exit")
            Again = Console.ReadLine().ToLower

        Loop Until (Again = "q")
        End


        Console.ReadLine()

    End Sub

End Module
