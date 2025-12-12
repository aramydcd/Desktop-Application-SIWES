Public Class Form1


    Dim CourseLabel() As System.Windows.Forms.Label
    Dim CourseScore() As System.Windows.Forms.TextBox
    Dim CourseCodeTxt() As System.Windows.Forms.Button
    Dim CourseUnitTxt() As System.Windows.Forms.Button

    Dim CourseCodeArray As String() = {"SDT101", "MAP102", "NS103", "WAP104", "UIUX105", "AGD106"}
    Dim CourseTitles As String() = {"SOFTWARE DEVELOPMENT", "MOBILE APPLICATION", "NETWORKING AND SECURITY", "WEB APPLICATION",
                                    "PRODUCT DESIGN", "ADVANCE GRAPHIC DESIGN"}
    Dim CourseUnit As Integer() = {3, 5, 3, 5, 2, 2}

    Dim ExamScore As Double() = {0, 0, 0, 0, 0, 0}
    Dim ExamScorePoint As Double() = {0, 0, 0, 0, 0, 0}
    Dim GradePoint As Double() = {0, 0, 0, 0, 0, 0}
    Dim Remarks As String() = {"", "", "", "", "", ""}

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim confirm = MessageBox.Show("Are you sure you want to close!", "4REAL GLOBAL GRADE POINT CALCULATOR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (confirm.Equals("No")) Then
            Me.Refresh()
        End If

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NormalSize()
        GetData()
        ManipulateLabel(CourseLabel)
        LoopTextBox()
    End Sub

    Sub GetData()
        CourseLabel = {L1, L2, L3, L4, L5, L6}
        CourseScore = {T1, T2, T3, T4, T5, T6}
        CourseCodeTxt = {CC1, CC2, CC3, CC4, CC5, CC6}
        CourseUnitTxt = {CU1, CU2, CU3, CU4, CU5, CU6}
    End Sub

    Sub Enlarge()
        MainPanel.Width = 1273
        Me.Width = 1313
        LineShape1.Visible = True
    End Sub

    Sub NormalSize()
        MainPanel.Width = 830
        Me.Width = 874
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

    Sub ShowTable()

        Table1.Rows.Clear()
        For counter = 0 To 5
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

    Private Sub Table1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Table1.ClearSelection()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NormalSize()

        ExamScore = {0, 0, 0, 0, 0, 0}
        ExamScorePoint = {0, 0, 0, 0, 0, 0}
        GradePoint = {0, 0, 0, 0, 0, 0}
        Table1.Rows.Clear()
        ClearTxt()

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
            Enlarge()
            ShowTable()

        End If
        
    End Sub
End Class
