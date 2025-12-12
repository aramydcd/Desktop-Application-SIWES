Module Module1


    Sub Main()

        Console.WriteLine("4REAL GLOBAL GRADE POINT AVERAGE(GPA) CALCULATOR")
        Console.WriteLine("------------------------------------------------")

        Dim SDT101_Score, MAP102_Score, NS103_Score, WAP104_Score, UIUX105_Score, AGD106_Score As Decimal
        Dim SDT101_Unit, MAP102_Unit, NS103_Unit, WAP104_Unit, UIUX105_Unit, AGD106_Unit, TCU As Integer
        Dim SDT101_GP, MAP102_GP, NS103_GP, WAP104_GP, UIUX105_GP, AGD106_GP, TGP As Double
        Dim GPA, Again As String


        Do

            'Software Development (3 Unit)
            Console.WriteLine(vbLf & "ENTER EXAM SCORE FOR SOFTWARE DEVELOPMENT(3 UNIT COURSE):")
            SDT101_Score = Console.ReadLine()
            SDT101_Unit = 3

            If (SDT101_Score <= 100) Then

                'Mobile App (5 Unit)
                Console.WriteLine("ENTER EXAM SCORE FOR MOBILE APPLICATION(5 UNIT COURSE):")
                MAP102_Score = Console.ReadLine()
                MAP102_Unit = 5

                If (MAP102_Score <= 100) Then

                    'Networking And Security (3 Unit)
                    Console.WriteLine("ENTER EXAM SCORE FOR NETWORKING AND SECURITY(3 UNIT COURSE):")
                    NS103_Score = Console.ReadLine()
                    NS103_Unit = 3

                    If (NS103_Score <= 100) Then

                        'Web App (5 Unit)
                        Console.WriteLine("ENTER EXAM SCORE FOR WEB APPLICATION(5 UNIT COURSE):")
                        WAP104_Score = Console.ReadLine()
                        WAP104_Unit = 5

                        If (WAP104_Score <= 100) Then

                            'User Interface And User Experience (2 Unit)
                            Console.WriteLine("ENTER EXAM SCORE FOR USER INTERFACE AND USER EXPERIENCE(2 UNIT COURSE):")
                            UIUX105_Score = Console.ReadLine()
                            UIUX105_Unit = 2

                            If (UIUX105_Score <= 100) Then

                                'Advance graphic design (2 Unit)
                                Console.WriteLine("ENTER EXAM SCORE FOR ADVANCE GRAPHIC DESIGN(2 UNIT COURSE):")
                                AGD106_Score = Console.ReadLine()
                                AGD106_Unit = 2

                                If (AGD106_Score <= 100) Then

                                    MAP102_GP = MyFunction.CalculateGradePoint(MAP102_Score, MAP102_Unit)
                                    SDT101_GP = MyFunction.CalculateGradePoint(SDT101_Score, SDT101_Unit)
                                    NS103_GP = MyFunction.CalculateGradePoint(NS103_Score, NS103_Unit)
                                    WAP104_GP = MyFunction.CalculateGradePoint(WAP104_Score, WAP104_Unit)
                                    UIUX105_GP = MyFunction.CalculateGradePoint(UIUX105_Score, UIUX105_Unit)
                                    AGD106_GP = MyFunction.CalculateGradePoint(AGD106_Score, AGD106_Unit)

                                    'Total Grade Point(TGP)
                                    TGP = SDT101_GP + MAP102_GP + NS103_GP + WAP104_GP + UIUX105_GP + AGD106_GP

                                    'Total Course Unit(TCU)
                                    TCU = SDT101_Unit + MAP102_Unit + NS103_Unit + WAP104_Unit + UIUX105_Unit + AGD106_Unit

                                    'Grade Point Average
                                    GPA = Format(TGP / TCU, ("N2"))

                                    Console.WriteLine()
                                    Console.WriteLine("--------------------------------------------")
                                    Console.WriteLine("TOTAL GRADE POINT(TGP): " + Format(TGP, ("N2")).ToString)
                                    Console.WriteLine("TOTAL COURSE UNIT(TCU): " + Format(TCU, ("N2")).ToString)
                                    Console.WriteLine("GRADE POINT AVERAGE(GPA): " + GPA + " " + MyFunction.GradePointAverageInWord(GPA))
                                    Console.WriteLine("--------------------------------------------")


                                Else
                                    MyFunction.ErrorMessage()
                                End If

                            Else
                                MyFunction.ErrorMessage()

                            End If

                        Else
                            MyFunction.ErrorMessage()
                        End If

                    Else
                        MyFunction.ErrorMessage()
                    End If

                Else
                    MyFunction.ErrorMessage()
                End If

            Else
                MyFunction.ErrorMessage()
            End If

            Console.WriteLine("Do you want to continue? Press any key for YES, N for NO")
            Again = Console.ReadLine()
        Loop Until (Again = "n")
        End


        Console.ReadLine()

    End Sub
End Module
