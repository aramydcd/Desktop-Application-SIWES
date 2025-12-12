Public Class Form1

    Dim CourseCodeArray As String()
    Dim CourseTitles As String()
    Dim CourseUnit As Integer()
    Dim CourseHeight As Integer()
    Dim TCU, Len As Integer
    Dim TCH As Integer
    Dim SelectedSemester, SelectedLevel As String

    Dim CourseCodeTxt() As System.Windows.Forms.Button
    Dim CourseUnitTxt() As System.Windows.Forms.Button

    Dim SelectionIsConfirmed = False


    Private Sub LevelBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelBox.SelectedIndexChanged
        SelectedLevel = LevelBox.SelectedItem.ToString()

    End Sub

    Private Sub SemesterBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterBox.SelectedIndexChanged
        SelectedSemester = SemesterBox.SelectedItem.ToString()

    End Sub

    Sub GetData(ByVal Level As String, ByVal Semester As String)

        If (Level = "ND I") Then
            If (Semester = "FIRST") Then
                'ND1 FIRST SEMESTER
                CourseCodeArray = {"COM111", "COM112", "COM113", "COM114", "COM115", "MTH111", "GNS101", "GNS111"}
                CourseTitles = {"INTRODUCTION TO COMPUTING", "INTRO. TO DIGITAL ELECTRONICS", "INTRODUCTION TO PROGRAMMING", "STATISTICS FOR COMPUTING I ",
                                "COMPUTER APP. PACKAGES I", "LOGIC AND LINEAR ALGEBRA", "USE OF ENGLISH I", "CITIZENSHIP EDUCATION I"}
                CourseUnit = {3, 3, 3, 2, 3, 2, 2, 2}
                CourseHeight = {4, 4, 4, 2, 4, 2, 2, 4}
            Else
                'ND1 SECOND SEMESTER
                CourseCodeArray = {"COM121", "COM122", "COM123", "COM124", "COM125", "COM126", "GNS128", "GNS102", "EED126", "GNS228"}
                CourseTitles = {"PROGRAMMING USING C LANGUAGE", "INTRODUCTION TO INTERNET", "PROGRAMMING USING JAVA I", "DATA STRUCTURE AND ALGORITHMS",
                                "INTRO. TO SYS. ANALYSIS AND DESIGN", "PC UPGRADE AND MAINTENANCE", "CITIZENSHIP EDUCATION II", "COMMUNICATION IN ENGLISH",
                                "PRACTICE OF ENTERPRENEURSHIP", "RESERACH METHOD"}
                CourseUnit = {3, 3, 3, 3, 2, 3, 2, 2, 2, 2}
                CourseHeight = {4, 3, 4, 3, 3, 4, 2, 2, 2, 2}
            End If
            

        ElseIf (Level = "ND II") Then
            If (Semester = "FIRST") Then
                'ND2 FIRST SEMESTER
                CourseCodeArray = {"COM211", "COM212", "COM213", "COM214", "COM215", "COM 216", "SIW219", "GNS201", "EED126"}
                CourseTitles = {"PROGRAMMING USING JAVA II", "INTRO. TO SYSTEM PROGRAMMING", "UNIFIED MODELLING LANG.", "COM. SYS. AND TROUBLESHOOTING",
                                "COMPUTER APP. PACKAGES II", "STATISTICS FOR COMPUTING I ", "SIWES", "USE OF ENGLISH II", "PRACTICE OF ENTERPRENEURSHIP"}
                CourseUnit = {3, 2, 3, 3, 3, 2, 4, 2, 2}
                CourseHeight = {4, 2, 4, 3, 4, 2, 4, 2, 2}
            Else
                'ND2 SECOND SEMESTER
                CourseCodeArray = {"COM221", "COM222", "COM223", "COM224", "COM225", "COM 226", "GNS204", "COM227"}
                CourseTitles = {"BASIC COMPUTER NETWORKING", "SEMINAR ON COM. AND SOCIETY", "BASIC HARDWARE MAINTENANCE",
                                "MANAGEMENT INFO. SYS.", "WEB TECHNOLOGY", "FILE ORG. AND MANAGEMENT", "COMMUNICATION IN ENGLISH II",
                                 "PROJECT"}
                CourseUnit = {3, 2, 2, 2, 3, 2, 2, 4}
                CourseHeight = {4, 2, 3, 3, 5, 3, 2, 6}
            End If
        

        End If

    End Sub
  

    Private Sub ConfirmSelectionBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmSelectionBtn.Click
        ConfirmNow()
        If (SelectionIsConfirmed) Then
            UpdateSelectionDataTable()
        End If
    End Sub

    Sub ConfirmNow()
        If ((SelectedLevel = "") And (SelectedSemester = "")) Then
            MsgBox("Please,provide the necessary information to continue!")
        Else
            If (SelectedLevel = "") Then
                MsgBox("Please,Choose a Level to continue!")

            ElseIf (SelectedSemester = "") Then
                MsgBox("Please,Choose Semester to continue!")
            Else
                SelectionValid()
            End If
            
        End If
    End Sub

    Sub SelectionValid()
        SelectionIsConfirmed = True
        LabelData.Text = SelectedSemester + " SEMESTER " + SelectedLevel
        SelectionPanel.Visible = False
        LabelData.Visible = True
        DataPanel.Visible = True
    End Sub


    Sub UpdateSelectionDataTable()
        GetData(SelectedLevel, SelectedSemester)
        Len = CourseUnit.Length - 1

        For counter = 0 To (CourseUnit.Length - 1)
            SelectionDataView.Rows.Add(counter + 1, CourseCodeArray(counter), CourseTitles(counter), CourseUnit(counter), CourseHeight(counter))
        Next
        If ((SelectedLevel = "ND1") And (SelectedSemester = "FIRST")) Then
            SelectionDataView.ScrollBars = ScrollBars.None
        Else
            SelectionDataView.ScrollBars = ScrollBars.Vertical
        End If
    End Sub

    Private Sub SelectionDataView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectionDataView.SelectionChanged
        SelectionDataView.ClearSelection()
    End Sub

    Private Sub ButtonClearSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearSelect.Click
        SelectionDataView.Rows.Clear()
        DataPanel.Visible = False
        SelectionPanel.Visible = True
        LabelData.Visible = False
    End Sub

    Dim LabelStore(Len) As System.Windows.Forms.Label
    Dim CourseScore(Len) As System.Windows.Forms.TextBox
    Dim ScoreStore As New List(Of Double)()

    Dim ExamScore(Len) As Double
    Dim ExamScorePoint(Len) As Double
    Dim GradePoint(Len) As Double
    Dim Remarks(Len) As String

    Private Sub ButtonStartCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStartCalc.Click
        DataPanel.Visible = False
        If (SelectedLevel = "ND I") Then
            If (SelectedSemester = "FIRST") Then
                ShowND1_FirstSemester()
            Else
                ShowND1_SecondSemester()
            End If

        ElseIf (SelectedLevel = "ND II") Then
            If (SelectedSemester = "FIRST") Then
                ShowND2_FirstSemester()
            Else
                ShowND2_SecondSemester()
            End If
        End If
        ManipulateLabel(LabelStore)
        LoopTextBox()
        ShowActionBtn()

    End Sub

    Sub ShowND1_FirstSemester()
        Nd1Panel1.Visible = True
        LabelStore = {L1, L2, L3, L4, L5, L6, L7, L8}
        CourseScore = {T1, T2, T3, T4, T5, T6, T7, T8}
        CourseCodeTxt = {CC1, CC2, CC3, CC4, CC5, CC6, CC7, CC8}
        CourseUnitTxt = {CU1, CU2, CU3, CU4, CU5, CU6, CU7, CU8}
        ExamScore = {0, 0, 0, 0, 0, 0, 0, 0}
        ExamScorePoint = {0, 0, 0, 0, 0, 0, 0, 0}
        GradePoint = {0, 0, 0, 0, 0, 0, 0, 0}
        Remarks = {"", "", "", "", "", "", "", ""}
    End Sub

    Sub ShowND1_SecondSemester()
        Nd1Panel2.Visible = True
        LabelStore = {L11, L12, L13, L14, L15, L16, L17, L18, L19, L10}
        CourseScore = {T11, T12, T13, T14, T15, T16, T17, T18, T19, T10}
        CourseCodeTxt = {CC11, CC12, CC13, CC14, CC15, CC16, CC17, CC18, CC19, CC10}
        CourseUnitTxt = {CU11, CU12, CU13, CU14, CU15, CU16, CU17, CU18, CU19, CU10}
        ExamScore = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        ExamScorePoint = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        GradePoint = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Remarks = {"", "", "", "", "", "", "", "", "", ""}
    End Sub

    Sub ShowND2_FirstSemester()
        Nd2Panel1.Visible = True
        LabelStore = {L21, L22, L23, L24, L25, L26, L27, L28, L29}
        CourseScore = {T21, T22, T23, T24, T25, T26, T27, T28, T29}
        CourseCodeTxt = {CC21, CC22, CC23, CC24, CC25, CC26, CC27, CC28, CC29}
        CourseUnitTxt = {CU21, CU22, CU23, CU24, CU25, CU26, CU27, CU28, CU29}
        ExamScore = {0, 0, 0, 0, 0, 0, 0, 0, 0}
        ExamScorePoint = {0, 0, 0, 0, 0, 0, 0, 0, 0}
        GradePoint = {0, 0, 0, 0, 0, 0, 0, 0, 0}
        Remarks = {"", "", "", "", "", "", "", "", ""}
    End Sub

    Sub ShowND2_SecondSemester()
        Nd2Panel2.Visible = True
        LabelStore = {L31, L32, L33, L34, L35, L36, L37, L38}
        CourseScore = {T31, T32, T33, T34, T35, T36, T37, T38}
        CourseCodeTxt = {CC31, CC32, CC33, CC34, CC35, CC36, CC37, CC38}
        CourseUnitTxt = {CU31, CU32, CU33, CU34, CU35, CU36, CU37, CU38}
        ExamScore = {0, 0, 0, 0, 0, 0, 0, 0}
        ExamScorePoint = {0, 0, 0, 0, 0, 0, 0, 0}
        GradePoint = {0, 0, 0, 0, 0, 0, 0, 0}
        Remarks = {"", "", "", "", "", "", "", ""}
    End Sub

    Sub ManipulateLabel(ByVal LabelStore() As System.Windows.Forms.Label)
        For counter = 0 To (CourseTitles.Length - 1)
            LabelStore(counter).Text = CourseTitles(counter).ToUpper + " (" + CourseCodeArray(counter) + ")"
            CourseCodeTxt(counter).Text = CourseCodeArray(counter)
            CourseUnitTxt(counter).Text = CourseUnit(counter)
        Next
    End Sub

    Sub validateInput(ByVal ScoreTxt As System.Windows.Forms.TextBox, ByVal id As Integer)
        Dim ScoreValue As Double

        If (ScoreTxt.Text <> "") Then
            If ((Double.TryParse(ScoreTxt.Text, ScoreValue))) Then
                If (ScoreValue > 100) Then
                    ScoreTxt.Text = ScoreTxt.Text.Remove(ScoreTxt.Text.Length - 1)
                    MessageBox.Show("Score has exceed the limit of 100", "4REAL GLOBAL GRADE POINT CALCULATOR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ExamScore(id) = ScoreValue
                    Dim point = GetScorePoint(ScoreValue)
                    ExamScorePoint(id) = point
                    GradePoint(id) = CalculateGradePoint(point, id)

                End If

            Else
                If (ScoreTxt.Text.Length > 0) Then
                    ScoreTxt.Text = ScoreTxt.Text.Remove(ScoreTxt.Text.Length - 1)
                    MessageBox.Show("Score Can Only Be Numbers!", "4REAL GLOBAL GP APP", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If
        Else
            ExamScore(id) = 0
        End If
    End Sub

    Sub LoopTextBox()
        For Each tb As TextBox In CourseScore
            AddHandler tb.TextChanged, AddressOf Box_TextChanged
        Next
    End Sub

    Private Sub Box_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim tb As TextBox = DirectCast(sender, TextBox)
        ' MessageBox.Show("Text Changed in {tb.Name}")
        Dim index = Array.IndexOf(CourseScore, tb)
        validateInput(tb, index)

    End Sub

    Sub ClearTxt()

        For Each tb As TextBox In CourseScore
            tb.Text = ""
        Next

    End Sub

    Sub ShowActionBtn()
        ButtonSubmit.Visible = True
        ButtonClear.Visible = True
    End Sub

    Sub HideActionBtn()
        ButtonSubmit.Visible = False
        ButtonClear.Visible = False

        Nd1Panel1.Visible = False
        Nd1Panel2.Visible = False
        Nd2Panel1.Visible = False
        Nd2Panel2.Visible = False

        ResultDetails.Visible = True

    End Sub


    Function CalculateGradePoint(ByVal ExamScorePoint As Double, ByVal id As Integer) As Double
        'FUNCTION PROPERTIES:
        '-PARAMETER: ExamScore REPRESENT THE SCORE FOR THE CURRENT COURSE BEEN PROCESSED
        '-RETURN VALUE: A DOUBLE REPRESENTING THE   GRADE POINT OF THE ExamScore

        Dim GradePoint As Double
        GradePoint = ExamScorePoint * CourseUnit(id)

        Return GradePoint

    End Function

    Function GetScorePoint(ByVal ExamScore As Double) As Double
        'FUNCTION PROPERTIES:
        '-PARAMETER: ExamScore REPRESENT THE SCORE FOR THE CURRENT COURSE BEEN PROCESSED
        '-RETURN VALUE: A DOUBLE REPRESENTING THE SCORE POINT OF THE ExamScore

        If ((ExamScore >= 75) And (ExamScore <= 100)) Then
            Return 4.0 'A
        ElseIf ((ExamScore >= 70) And (ExamScore <= 74)) Then
            Return 3.5 'AB
        ElseIf ((ExamScore >= 65) And (ExamScore <= 69.9)) Then
            Return 3.25 'B
        ElseIf ((ExamScore >= 60) And (ExamScore <= 64)) Then
            Return 3.0 'BC
        ElseIf ((ExamScore >= 55) And (ExamScore <= 59.9)) Then
            Return 2.75 'C
        ElseIf ((ExamScore >= 50) And (ExamScore <= 54)) Then
            Return 2.5 'CD
        ElseIf ((ExamScore >= 45) And (ExamScore <= 49.9)) Then
            Return 2.25 'D
        ElseIf ((ExamScore >= 40) And (ExamScore <= 44)) Then
            Return 2.0 'E
        Else
            Return 0.0 'F
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



    Sub ShowTable()

        Table1.Rows.Clear()
        For counter = 0 To (CourseUnit.Length - 1)
            If (CourseScore(counter).Text = "") Then
                GradePoint(counter) = 0
                Check()
                Table1.Rows.Add(CourseCodeArray(counter), "-", CourseUnit(counter), "-", "-")
            Else

                If (ExamScore(counter) >= 40) Then
                    Remarks(counter) = "Pass"

                Else
                    Remarks(counter) = "Fail"

                End If
                Dim Remark = Remarks(counter)
                Check()
                Table1.Rows.Add(CourseCodeArray(counter), ExamScore(counter), CourseUnit(counter), GradePoint(counter), Remark)
            End If
        Next

    End Sub


  

    Sub Check()
        SumExamScoreTxt.Text = ExamScore.Sum
        SumCUTxt.Text = Format(CourseUnit.Sum, ("N2"))
        TGPTxt.Text = Format(GradePoint.Sum, ("N2"))

        Dim GPA = GradePoint.Sum / CourseUnit.Sum
        GPATxt.Text = Format(GPA, ("N2"))
        GPAText.Text = GradePointAverageInWord(GPA)
    End Sub

    Private Sub ButtonSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmit.Click
        Dim empty = False
        For Each tb As TextBox In CourseScore
            If (tb.Text = "") Then
                empty = True
                MessageBox.Show("Provide score for all course!", "4REAL GLOBAL GP APP", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit For
            End If
        Next

        If Not (empty) Then
            HideActionBtn()
            ShowTable()

        End If

    End Sub

    Private Sub Table1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Table1.SelectionChanged
        Table1.ClearSelection()
    End Sub


    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        ExamScore = {0, 0, 0, 0, 0, 0}
        ExamScorePoint = {0, 0, 0, 0, 0, 0}
        GradePoint = {0, 0, 0, 0, 0, 0}
        Table1.Rows.Clear()
        ClearTxt()
    End Sub
End Class
