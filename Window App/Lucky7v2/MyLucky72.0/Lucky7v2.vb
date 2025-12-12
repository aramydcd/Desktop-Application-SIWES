Public Class Lucky7v2

    Dim Username As String

    ' Private Sub ButtonStartGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'ButtonStart.Cursor = Cursors.AppStarting
    ''Panel3.BackColor = Color.White
    'PanelGame.Visible = True
    'Panel2.Visible = True


    'ButtonStart.Visible = False
    'ButtonEnd.Visible = True



    '  End Sub



    Private Sub ButtonEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'ButtonEnd.Cursor = Cursors.AppStarting
        'PanelGame.Visible = False
        'ButtonEnd.Visible = False
        'ButtonStart.Visible = True
        'End



    End Sub

    ' PictureBox1.Visible = False ' hide picture



    Private Sub ButtonSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Label37.ForeColor = Color.Red
        'Label38.ForeColor = Color.Red
        'Label39.ForeColor = Color.Red

        'Label37.Text = CStr(Int(Rnd() * 10)) ' pick numbers
        'Label38.Text = CStr(Int(Rnd() * 10))
        'Label39.Text = CStr(Int(Rnd() * 10))


        '' if any number is 7 display picture and beep
        'If (Label37.Text = "7") Or (Label38.Text = "7") _
        'Or (Label39.Text = "7") Then

        '    If (Label37.Text = "7") Then
        '        Label37.ForeColor = Color.AntiqueWhite
        '    End If

        '    If (Label38.Text = "7") Then
        '        Label38.ForeColor = Color.AntiqueWhite
        '    End If

        '    If (Label39.Text = "7") Then
        '        Label39.ForeColor = Color.AntiqueWhite
        '    End If

        '    'PictureBox1.Visible = True
        '    Beep()

        '    MsgBox(Prompt:="You Win!!", Title:="Congratulation")
        'End If





    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Randomize()
    End Sub

    'Button Click start

    Private Sub ButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonSubmitName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmitName.Click

        Username = TextBoxName.Text
        ButtonSubmitName.Cursor = Cursors.AppStarting
        PanelWelcome.Visible = False
        PanelAbout.Visible = True


    End Sub

    Private Sub ButtonNextAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNextAbout.Click

        ButtonNextAbout.Cursor = Cursors.AppStarting
        PanelAbout.Visible = False
        PanelHow.Visible = True

    End Sub

    Private Sub ButtonHowNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHowNext.Click

        'SplitContainer2.Panel2.BackgroundImage = "C:\Users\ADMIN\OneDrive\Pictures\falling_coin"
        ButtonHowNext.Cursor = Cursors.AppStarting
        PanelHow.Visible = False
        LabelPlayerName.Text = Username
        PanelDashboard.Visible = True

    End Sub


    Private Sub ButtonStartGame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonStartGame.Click

        End
        'Here is where The Game begins
        'Coin counter at the top,Timer Or total spin left


    End Sub
    'Button click End


    'Button Hover Start



    Private Sub ButtonSubmitName_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSubmitName.MouseHover

        ButtonSubmitName.BackColor = Color.White
        ButtonSubmitName.ForeColor = Color.Navy

    End Sub

    Private Sub ButtonSubmitName_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSubmitName.MouseLeave

        ButtonSubmitName.BackColor = Color.Navy
        ButtonSubmitName.ForeColor = Color.White

    End Sub

    'Private Sub ButtonStart_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)

    '    ButtonStart.BackColor = Color.White
    '    ButtonStart.ForeColor = Color.Navy

    'End Sub

    'Private Sub ButtonStart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    '    ButtonStart.BackColor = Color.Navy
    '    ButtonStart.ForeColor = Color.White

    'End Sub

    Private Sub ButtonNextAbout_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNextAbout.MouseHover

        ButtonNextAbout.BackColor = Color.White
        ButtonNextAbout.ForeColor = Color.Navy

    End Sub

    Private Sub ButtonNextAbout_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNextAbout.MouseLeave

        ButtonNextAbout.BackColor = Color.Navy
        ButtonNextAbout.ForeColor = Color.White

    End Sub

    Private Sub ButtonHowNext_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonHowNext.MouseHover

        ButtonHowNext.BackColor = Color.White
        ButtonHowNext.ForeColor = Color.Navy

    End Sub

    Private Sub ButtonHowNext_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonHowNext.MouseLeave

        ButtonHowNext.BackColor = Color.Navy
        ButtonHowNext.ForeColor = Color.White

    End Sub

    Private Sub ButtonStartGame_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonStartGame.MouseHover

        ButtonStartGame.BackColor = Color.White
        ButtonStartGame.ForeColor = Color.Navy

    End Sub

    Private Sub ButtonStartGame_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonStartGame.MouseLeave

        ButtonStartGame.BackColor = Color.Navy
        ButtonStartGame.ForeColor = Color.White

    End Sub

    'Button Hover End


End Class
