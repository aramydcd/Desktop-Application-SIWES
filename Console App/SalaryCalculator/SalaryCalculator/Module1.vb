Module Module1
    Sub Main()
        Console.WriteLine("THIS SOFTWARE DEDUCT FIVE PERCENT(%) FROM STAFF SALARY")
        Console.WriteLine("------------------------------------------------------")
        Dim InitialSalary, PercentageAmount, FinalSalary As Double

        Console.WriteLine("ENTER STAFF SALARY:")
        Console.WriteLine("------------------------------------------------------")

        InitialSalary = Console.ReadLine()

        PercentageAmount = (InitialSalary * 5) / 100
        FinalSalary = InitialSalary - PercentageAmount

        Console.WriteLine("------------------------------------------------------")
        Console.WriteLine("INITIAL SALARY: " & (Format(InitialSalary, "N2")))
        Console.WriteLine("PERCENTAGE AMOUNT: " & (Format(PercentageAmount, "N2")))
        Console.WriteLine("FINAL SALARY: " & (Format(FinalSalary, "N2")))

        Console.ReadLine()

    End Sub
End Module
