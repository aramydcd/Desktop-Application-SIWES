Module MyFunction

    Sub ErrorMessage()
        'THIS FUNCTION PRINT AN ERROR MESSAGE
        Console.WriteLine("--------------------------------------")
        Console.WriteLine("EXAM SCORE CANNOT BE GREATER THAN 100")
        Console.WriteLine("--------------------------------------")
    End Sub

    Function CalculateGradePoint(ByVal ExamScore As Double, ByVal CourseUnit As Integer) As Double
        'THIS FUNCTION RETURNS THE GRADE POINT(GP) OF A COURSE USING A GIVEN EXAM SCORE AND COURSE UNIT

        Dim ExamScorePoint, GP As Double

        If ((ExamScore >= 80) And (ExamScore <= 100)) Then
            ExamScorePoint = 4.0 'A
        ElseIf ((ExamScore >= 70) And (ExamScore <= 79.9)) Then
            ExamScorePoint = 3.5 'AB
        ElseIf ((ExamScore >= 60) And (ExamScore <= 69.9)) Then
            ExamScorePoint = 3.0 'B
        ElseIf ((ExamScore >= 50) And (ExamScore <= 59.9)) Then
            ExamScorePoint = 2.5 'C
        ElseIf ((ExamScore >= 40) And (ExamScore <= 49.9)) Then
            ExamScorePoint = 2.0 'D
        Else
            ExamScorePoint = 1.99 'E
        End If

        'Console.WriteLine(Format(ExamScorePoint, "N2"))
        'Console.WriteLine("ExamScorePoint: " & ExamScorePoint)

        GP = ExamScorePoint * CourseUnit
        Return GP

    End Function


    Function GradePointAverageInWord(ByVal GPA As String) As String
        'THIS FUNCTION COLLECT A GPA VALUE AND RETURN IT'S WORD EQUIVALENT

        If ((GPA >= 3.5) And (GPA <= 4.0)) Then
            Return "Distinction"
        ElseIf ((GPA >= 3.0) And (GPA <= 3.49)) Then
            Return "Upper Credit"
        ElseIf ((GPA >= 2.5) And (GPA <= 2.99)) Then
            Return "Lower Credit"
        ElseIf ((GPA >= 2.0) And (GPA <= 2.49)) Then
            Return "Pass"
        Else
            Return "Advice to withdraw!"
        End If

    End Function

End Module
