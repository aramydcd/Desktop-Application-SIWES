Module Module1

    Sub Main()
        Console.WriteLine("THIS PROGRAM CALCULATE LARGEST OF THREE(3) NUMBERS")
        Console.WriteLine("---------------------------------------------------")

        'VARIABLE DECLARATION
        Dim a, b, c As Integer

        'INPUT
        Console.WriteLine("Enter first number:")
        a = Console.ReadLine()
        Console.WriteLine("Enter second number:")
        b = Console.ReadLine()
        Console.WriteLine("Enter last number:")
        c = Console.ReadLine()

        'PROCESS AND OUTPUT
        Console.WriteLine("-----------------------------------")
        If ((a > b) And (a > c)) Then
            Console.WriteLine(a.ToString + " is the largest")
        ElseIf ((b > a) And (b > c)) Then
            Console.WriteLine(b.ToString + " is the largest")
        ElseIf ((c > a) And (c > b)) Then
            Console.WriteLine(c.ToString + " is the largest")
        Else
            Console.WriteLine("The are Equal")

        End If
        Console.WriteLine("-----------------------------------")

        Console.ReadLine()

    End Sub

End Module
