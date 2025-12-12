Module Module1

    Sub Main()
        Console.WriteLine("IERATION/LOOP STRUCTURE IN VB.NET")
        'For....Next --------> Syntax
        'For Var = Starting Number TO Last Number STEP n
        '    Statement
        'Next


        'Do..... Loop While --------> Syntax
        'Do
        '    Statement
        '    Increment/Decrement
        'Loop While (Condition)


        'Do.....Loop Until -------> Syntax
        'Do
        '    Statement
        'Loop Until (Condition)

        Dim CourseUnit As Integer()
        CourseUnit = {3, 3, 3, 2, 3, 2, 2, 2}
        Dim len = CourseUnit.Length
        Console.WriteLine(len)

        Console.ReadLine()


    End Sub

End Module
