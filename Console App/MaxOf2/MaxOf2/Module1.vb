Module Module1
    Sub Main()
        Console.WriteLine("THIS PROGRAM CALCULATE LARGEST OF TWO(2) NUMBERS")
        Console.WriteLine("---------------------------------------------------")

        'Dim ad(4) As Integer
        'ad(0) = 1
        'ad(1) = 2
        'ad(2) = 3
        'ad(3) = 4
        'ad(4) = 5
        'Console.WriteLine(ad.Length)
        'Console.WriteLine(Array.IndexOf(ad, 4))

        'VARIABLE DECLARATION
        Dim a, b As Integer

        'INPUT
        Console.WriteLine("Enter first number:")
        a = Console.ReadLine()
        Console.WriteLine("Enter second number:")
        b = Console.ReadLine()

        'PROCESS AND OUTPUT
        Console.WriteLine("-----------------------------------")
        If (a > b) Then
            Console.WriteLine(a.ToString + " is the largest")
        ElseIf (b > a) Then
            Console.WriteLine(b.ToString + " is the largest")
        Else
            Console.WriteLine("The are Equal")

        End If
        Console.WriteLine("-----------------------------------")

        Console.ReadLine()
    End Sub

End Module
