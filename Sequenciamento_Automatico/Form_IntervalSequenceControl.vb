Public Class Form_IntervalSequenceControl
    Private Sub Form_IntervalSequenceControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_StartSequencing.Text = My.Settings.startsequencing
        btn_FinishSequencing.Text = My.Settings.finishsequencing


    End Sub

    Private Sub btn_Apply_Click(sender As Object, e As EventArgs) Handles btn_Apply.Click
        My.Settings.startsequencing = btn_StartSequencing.Text
        My.Settings.finishsequencing = btn_FinishSequencing.Text

        My.Settings.Save()
        ActiveForm.Close()

    End Sub

    Private Sub btn_StartSequencing_Click(sender As Object, e As EventArgs) Handles btn_StartSequencing.Click

        Dim form1 As New Form_CalendarStartSequencing


        form1.Show()

    End Sub

    Private Sub btn_FinishSequencing_Click(sender As Object, e As EventArgs) Handles btn_FinishSequencing.Click
        Dim form2 As New Form_CalendarFinishSequencing



        form2.Show()
    End Sub

    Private Sub Form_IntervalSequenceControl_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        btn_StartSequencing.Text = My.Settings.startsequencing
        btn_FinishSequencing.Text = My.Settings.finishsequencing

    End Sub
End Class