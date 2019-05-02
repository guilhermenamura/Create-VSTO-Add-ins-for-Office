Public Class calendarstartsequencing
    Private Sub calendarstartsequencing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With MonthCalendar1
            .ShowToday = False
            .ShowTodayCircle = False

        End With
        My.Settings.startsequencing = MonthCalendar1.SelectionStart


    End Sub
End Class
