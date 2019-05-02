Public Class Form_CalendarAddNPExceptionDay
    Private Sub Form_CalendarAddNPExceptionDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With MonthCalendar1
            .ShowToday = False
            .ShowTodayCircle = False


        End With
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        My.Settings.npexceptionday = My.Settings.npexceptionday + " " + MonthCalendar1.SelectionStart
        ActiveForm.Close()
    End Sub
End Class