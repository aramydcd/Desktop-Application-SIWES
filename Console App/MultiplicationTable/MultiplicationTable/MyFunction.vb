Module MyFunction

    Sub MultiplicationTableGenerator(ByVal n As Integer, Optional ByVal TableLength As Integer = 12)

        Console.WriteLine("MULTIPLICATION TABLE " + n.ToString)
        Console.WriteLine("--------------------------")

        Dim counter As Integer

        For counter = 1 To TableLength
            Console.WriteLine(n.ToString + " x " + counter.ToString + " = " + (n * counter).ToString)

        Next

    End Sub
End Module
