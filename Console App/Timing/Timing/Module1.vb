Module Module1

    Sub Main()
        Console.WriteLine("Welcome to the quiz! V1")

        ' Ask first question
        Console.WriteLine("What is your name?")
        Dim name As String = Console.ReadLine()

        ' Create a stopwatch
        Dim stopwatch As New Stopwatch()
        stopwatch.Start()

        ' Wait for 2 seconds
        While stopwatch.ElapsedMilliseconds < 2000
            ' Do nothing
        End While
        stopwatch.Stop()

        ' Ask second question
        Console.WriteLine("How old are you?")
        Dim age As String = Console.ReadLine()

        ' Create a new stopwatch
        stopwatch.Reset()
        stopwatch.Start()

        ' Wait for 3 seconds
        While stopwatch.ElapsedMilliseconds < 3000
            ' Do nothing
        End While
        stopwatch.Stop()

        ' Ask third question
        Console.WriteLine("Where are you from?")
        Dim location As String = Console.ReadLine()

        Console.WriteLine("Thank you for answering the questions!")
        Console.WriteLine()

        Console.WriteLine("Welcome to the quiz! V2")

        ' Ask first question
        Console.WriteLine("What is your name?")
        name = Console.ReadLine()

        ' Wait for 2 seconds
        System.Threading.Thread.Sleep(2000)

        ' Ask second question
        Console.WriteLine("How old are you?")
        age = Console.ReadLine()

        ' Wait for 3 seconds
        System.Threading.Thread.Sleep(3000)

        ' Ask third question
        Console.WriteLine("Where are you from?")
        location = Console.ReadLine()

        Console.WriteLine("Thank you for answering the questions!")

        Console.ReadLine()

    End Sub

End Module
