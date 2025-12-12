Module Module1

    Sub Main()
        Console.WriteLine("THIS SOFTWARE CALCULATE SIMPLE INTEREST")
        Console.WriteLine("----------------------------------------")

        'VARIABLE DECLARATION
        Dim Principal, SimpleInterest As Double
        Dim Rate, Time As Integer

        'USER INPUT/DATA
        Console.WriteLine("Principal: ")
        Principal = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Rate(%): ")
        Rate = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Time(Year): ")
        Time = Console.ReadLine()

        'PROCESSING OF USER INPUT/DATA
        SimpleInterest = (Principal * Rate * Time) / 100

        Console.WriteLine("----------------------------------------")
        'OUTPUT
        Console.WriteLine("Simple Interest: $" & SimpleInterest.ToString("N2"))
        Console.WriteLine("----------------------------------------")

        Console.ReadLine()

    End Sub

End Module