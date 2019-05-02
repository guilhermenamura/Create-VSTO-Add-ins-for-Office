Public Class calendarfinishsequencing
    Private Sub calendarfinishsequencing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With MonthCalendar1
            .ShowToday = False
            .ShowTodayCircle = False

        End With
        My.Settings.finishsequencing = MonthCalendar1.SelectionStart



    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class
