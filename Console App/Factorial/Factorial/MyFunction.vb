Module MyFunction

    Function LoopFactorialCalc(ByVal n As Integer) As Integer
        'FUNCTION PROPERTIES:
        '- PARAMETER: n REPRESENT THE INTEGER TO PROCESS IT FACTORIAL USING LOOP/ITERATION
        '- RETURN VALUE: THE FACTORIAL OF n

        Dim result As Integer
        result = 1

        While (n >= 1)
            result *= n
            n -= 1
        End While

        Return result
    End Function

    Function RecursiveFactorialCalc(ByVal n As Integer) As Integer
        'FUNCTION PROPERTIES:
        '- PARAMETER: n REPRESENT THE INTEGER TO PROCESS IT FACTORIAL USING RECURSIVE FUNCTION
        '- RETURN VALUE: THE FACTORIAL OF n

        Dim result As Integer
        result = 1

        If (n <= 1) Then
            Return result
        Else
            result *= n * RecursiveFactorialCalc(n - 1)

        End If

        Return result

    End Function


End Module
