Module MyFunction
    Function GetScore(ByVal CourseTitle() As String) As Double()
        'FUNCTION PROPERTIES:
        '-PARAMETER: CourseTitle REPRESENT AN ARRAY OF STRINGS OF COURSE TITLES IN ORDER
        '-RETURN VALUE: AN ARRAY OF DOUBLE REPRESENTING TH COLLECTED VALID SCORE FOR EACH COURSES IN ORDER

        Dim AllValidScores(5) As Double
        For index = 0 To (CourseTitle.Length - 1)
            While True
                Dim UserScore As String
                Dim ScoreValue As Double
                Console.WriteLine(vbLf & "ENTER EXAM SCORE FOR " & CourseTitle(index) & ":")
                UserScore = Console.ReadLine()
                If (Double.TryParse(UserScore, ScoreValue) And ((ScoreValue >= -100) And (ScoreValue <= 100))) Then
                    AllValidScores(index) = ScoreValue
                    Exit While
                Else
                    ErrorMessage()
                End If
            End While
        Next
        Return AllValidScores
    End Function

    Sub ErrorMessage()
        'THIS FUNCTION PRINT AN ERROR MESSAGE
        Console.WriteLine("------------------------------------------------")
        Console.WriteLine("SCORE CAN ONLY BE WITHIN THE RANGE(-100 TO 100)!")
        Console.WriteLine("------------------------------------------------")

    End Sub

    Function CalculateGradePoint(ByVal CourseTitle() As String, ByVal CourseUnits() As Integer) As Double()
        'FUNCTION PROPERTIES:
        '-PARAMETER: CourseTitle REPRESENT AN ARRAY OF STRINGS OF COURSE TITLES IN ORDER
        '           CourseUnits REPRESENT AN ARRAY OF INTEGERS OF COURSE UNITS IN ORDER
        '-RETURN VALUE: AN ARRAY OF DOUBLE REPRESENTING THE GRADE POINT OF SCORES IN ORDER 

        Dim Scores As Double() = MyFunction.GetScore(CourseTitle)
        Dim GradePoints(5) As Double
        For index = 0 To (Scores.Length - 1)
            GradePoints(index) = GetScorePoint(Scores(index)) * CourseUnits(index)
        Next
        Return GradePoints
    End Function

    Function GetScorePoint(ByVal ExamScore As Double) As Double
        'FUNCTION PROPERTIES:
        '-PARAMETER: ExamScore REPRESENT THE SCORE FOR THE CURRENT COURSE BEEN PROCESSED
        '-RETURN VALUE: A DOUBLE REPRESENTING THE SCORE POINT OF THE ExamScore

        If ((ExamScore >= 80) And (ExamScore <= 100)) Then
            Return 4.0 'A
        ElseIf ((ExamScore >= 70) And (ExamScore <= 79.9)) Then
            Return 3.5 'AB
        ElseIf ((ExamScore >= 60) And (ExamScore <= 69.9)) Then
            Return 3.0 'B
        ElseIf ((ExamScore >= 50) And (ExamScore <= 59.9)) Then
            Return 2.5 'C
        ElseIf ((ExamScore >= 40) And (ExamScore <= 49.9)) Then
            Return 2.0 'D
        Else
            Return 1.99 'E
        End If

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
