Public Class Form_PStandardDay

    Private Sub Form_PStandardDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim diasp As String() = Split(My.Settings.pstandarday, " ")

        'find the days in app.config
        For Each diap In diasp

            If diap = "Sunday" Then
                chklst_PStandardDays.SetItemChecked(0, True)
            ElseIf diap = "Monday" Then
                chklst_PStandardDays.SetItemChecked(1, True)
            ElseIf diap = "Tuesday" Then
                chklst_PStandardDays.SetItemChecked(2, True)
            ElseIf diap = "Wednesday" Then
                chklst_PStandardDays.SetItemChecked(3, True)
            ElseIf diap = "Thursday" Then
                chklst_PStandardDays.SetItemChecked(4, True)
            ElseIf diap = "Friday" Then
                chklst_PStandardDays.SetItemChecked(5, True)
            ElseIf diap = "Saturday" Then
                chklst_PStandardDays.SetItemChecked(6, True)

            End If


        Next

    End Sub

    Private Sub btn_Apply_Click(sender As Object, e As EventArgs) Handles btn_Apply.Click

        My.Settings.pstandarday = ""
        For Each item As Object In chklst_PStandardDays.CheckedItems

            My.Settings.pstandarday = item + " " + My.Settings.pstandarday
        Next

    End Sub

End Class



