Module Module1

    Sub Main()
        Console.WriteLine("MULTIPLICATION TABLE")
        Console.WriteLine("--------------------")

        Dim num As Integer = 5
        Dim TableLength As Integer = 12
        'Dim counter As Integer
        Dim Again As String

        Do
            Console.WriteLine(vbLf & "ENTER NUMBER")
            num = Console.ReadLine()
            MyFunction.MultiplicationTableGenerator(num)

            Console.WriteLine(vbLf & "---------------------------------------------------------------")
            Console.WriteLine(vbLf & "Do you want to continue? Enter any key for YES, N for NO")
            Again = Console.ReadLine().ToLower
            Console.WriteLine("---------------------------------------------------------------")
        Loop Until (Again = "n")
        End
        Console.ReadLine()

    End Sub

End Module
