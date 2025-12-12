Module Module1

    Sub Main()
        Console.WriteLine("4REAL GLOBAL GRADE POINT AVERAGE(GPA) CALCULATOR")
        Console.WriteLine("------------------------------------------------")

        Dim CourseCodeArray As String() = {"SDT101", "MAP102", "NS103", "WAP104", "UIUX105", "AGD106"}
        Dim CourseTitles As String() = {"SOFTWARE DEVELOPMENT (3 UNIT COURSE)", "MOBILE APPLICATION (5 UNIT COURSE)",
                                        "NETWORKING AND SECURITY (3 UNIT COURSE)", "WEB APPLICATION (5 UNIT COURSE)",
                                        "USER INTERFACE AND USER EXPERIENCE (2 UNIT COURSE)",
                                        "ADVANCE GRAPHIC DESIGN (2 UNIT COURSE)"}
        Dim CourseUnit As Integer() = {3, 5, 3, 5, 2, 2}
        Dim CourseGp(5) As Double

        CourseGp = MyFunction.CalculateGradePoint(CourseTitles, CourseUnit)

        Dim TotalGradePoints As Double = CourseGp.Sum
        Dim TotalCourseUnits As Double = CourseUnit.Sum


        Dim GradePointAverage As String = Format(TotalGradePoints / TotalCourseUnits, ("N2"))

        Console.WriteLine()
        Console.WriteLine("--------------------------------------------")
        Console.WriteLine("TOTAL GRADE POINT(TGP): " + Format(TotalGradePoints, ("N2")).ToString)
        Console.WriteLine("TOTAL COURSE UNIT(TCU): " + Format(TotalCourseUnits, ("N2")).ToString)
        Console.WriteLine("GRADE POINT AVERAGE(GPA): " + GradePointAverage +
                          " " + MyFunction.GradePointAverageInWord(GradePointAverage))
        Console.WriteLine("--------------------------------------------")

        Console.ReadLine()
    End Sub

End Module
