Imports System.Windows.Forms
Imports TaskScheduler.Index
Imports TaskScheduler.CreateAcc

Module Main
    Private frmLogin As New Index()
    Private frmCreateAcc As New CreateAcc()

    Sub ShowLogin()
        frmLogin.ShowDialog()
    End Sub

    Sub ShowCreate()
        frmCreateAcc.ShowDialog()
    End Sub

    Sub Main()
        ShowCreate()

    End Sub

End Module
