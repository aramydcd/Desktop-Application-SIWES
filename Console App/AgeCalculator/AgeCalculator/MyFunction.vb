Module MyFunction
    Dim UserDayOfBirth, UserMonthOfBirth, UserYearOfBirth, YearOld, MonthOld, DayOld, AppNumberOfYears, MonthInAYear As Integer
    Dim DOBIsValid = False

    Dim SystemCurrentDate As DateTime = DateTime.Today

    Dim CurrentDay = SystemCurrentDate.Day
    Dim CurrentMonth = SystemCurrentDate.Month
    Dim CurrentYear = SystemCurrentDate.Year

    Sub ValidateUserDateOfBirth()
        Dim stDay, stMonth, stYear As String
 
        Console.WriteLine("ENTER YEAR OF BIRTH:")
        stYear = Console.ReadLine()

        If (Integer.TryParse(stYear, UserYearOfBirth) And ((UserYearOfBirth <= CurrentYear) And (UserYearOfBirth >= 1))) Then
            Console.WriteLine(vbLf + "ENTER MONTH OF BIRTH:")
            stMonth = Console.ReadLine()

            If (Integer.TryParse(stMonth, UserMonthOfBirth) And ((UserMonthOfBirth <= 12) And (UserMonthOfBirth >= 1))) Then
                Dim daysInMonth = GetDaysInMonth(UserYearOfBirth, UserMonthOfBirth)

                Console.WriteLine(vbLf + "ENTER DAY OF BIRTH:")
                stDay = Console.ReadLine()
                If (Integer.TryParse(stDay, UserDayOfBirth) And ((UserDayOfBirth >= 1) And (UserDayOfBirth <= daysInMonth))) Then
                    DOBIsValid = True
                Else
                    'error message for invalid day
                    Console.WriteLine(vbLf & "---------------------------------------")
                    Console.WriteLine("Invalid Day Of Birth, Please Try Again!")
                    Console.WriteLine("---------------------------------------")

                End If
            Else
                'Error message for invalid month
                Console.WriteLine(vbLf & "-----------------------------------------")
                Console.WriteLine("Invalid Month Of Birth, Please Try Again!")
                Console.WriteLine("-----------------------------------------")

            End If
        Else
            'error Message for Invalid year
            Console.WriteLine(vbLf & "----------------------------------------")
            Console.WriteLine("Invalid Year Of Birth, Please Try Again!")
            Console.WriteLine("----------------------------------------")

        End If

    End Sub

    Function GetDaysInMonth(ByVal year As Integer, ByVal month As Integer) As Integer

        Return Date.DaysInMonth(year, month)

    End Function

    Sub DisplayAge()

        ValidateUserDateOfBirth()
        If (DOBIsValid) Then
            GetAge()
            Dim CurrentDate As String = CurrentDay.ToString + "/" + CurrentMonth.ToString + "/" + CurrentYear.ToString
            Dim BirthDate As String = UserDayOfBirth.ToString + "/" + UserMonthOfBirth.ToString + "/" + UserYearOfBirth.ToString

            Console.WriteLine()
            Console.WriteLine("-------------------------------------------------")
            Console.WriteLine("Your age using the provided Birth date: " + BirthDate)
            Console.WriteLine()
            Console.WriteLine("As at today: " + CurrentDate)
            Console.WriteLine()
            Console.WriteLine("You are: " + YearOld.ToString + " Year(s) " + MonthOld.ToString + " Month(s) " + DayOld.ToString + " Day(s) Old")
            Console.WriteLine("-------------------------------------------------")

        End If

    End Sub

    Sub GetAge()
        Dim MonthInAYear = 12
        Dim DaysInLastMonth = GetDaysInMonth(CurrentYear, (CurrentMonth - 1))

        'GET THE APPROXIMATE NUMBER OF YEAR
        AppNumberOfYears = CurrentYear - UserYearOfBirth

        If (UserMonthOfBirth < CurrentMonth) Then
            'BIRTH DAY/MONTH HAVE PASS IN CURRENT YEAR
            YearOld = AppNumberOfYears
            'IF DAYOFBIRTH = CURRENTDAY
            MonthOld = CurrentMonth - UserMonthOfBirth
            If (UserDayOfBirth > CurrentDay) Then
                MonthOld -= 1
                DayOld = (DaysInLastMonth - UserDayOfBirth) + CurrentDay
            ElseIf (UserDayOfBirth < CurrentDay) Then
                DayOld = CurrentDay - UserDayOfBirth

            End If
        ElseIf (UserMonthOfBirth = CurrentMonth) Then
            'CURRENT MONTH IS BIRTH MONTH IN CURRENT YEAR
            YearOld = AppNumberOfYears 'IF BIRTHDAY IS TODAY
            If (UserDayOfBirth < CurrentDay) Then
                'BIRTHDAY HAVE PASS IN CURRENT MONTH
                DayOld = CurrentDay - UserDayOfBirth
            ElseIf (UserDayOfBirth > CurrentDay) Then
                'BIRTHDAY IS UPCOMING IN CURRENT MONTH
                YearOld -= 1
                MonthOld = 11
                DayOld = (DaysInLastMonth - UserDayOfBirth) + CurrentDay
            End If
        Else
            'BIRTH DAY/MONTH IS UPCOMING IN CURRENT YEAR
            YearOld = AppNumberOfYears - 1
            MonthOld = (MonthInAYear - UserMonthOfBirth) + (CurrentMonth - 1)
            If (UserDayOfBirth = CurrentDay) Then
                MonthOld += 1
            ElseIf (UserDayOfBirth > CurrentDay) Then
                DayOld = (DaysInLastMonth - UserDayOfBirth) + CurrentDay
            Else
                MonthOld += 1
                DayOld = CurrentDay - UserDayOfBirth
            End If
        End If
    End Sub
End Module
