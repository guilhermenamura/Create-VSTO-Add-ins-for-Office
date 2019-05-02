Public Class Form_NPExceptionDay
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_NPExceptions.SelectedIndexChanged


    End Sub

    Private Sub Form_NPExceptionDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_NPExceptions.Items.Clear()
        Dim palavras As String() = Split(My.Settings.npexceptionday, " ")
        Dim palavra As String
        For Each palavra In palavras

            If palavra <> "" Then
                lst_NPExceptions.Items.Add(palavra)
            End If

        Next
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim form1 As New Form_CalendarAddNPExceptionDay
        form1.Show()


    End Sub

    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click

        Dim palavras As String() = Split(My.Settings.npexceptionday, " ")
        Dim palavra As String


        'first remove from the visual list
        For Each palavra In palavras
            If palavra = "" Or palavra = lst_NPExceptions.SelectedItem Then
                lst_NPExceptions.Items.Remove(palavra)

            End If
        Next
        'now actualize the Settings
        palavra = ""
        My.Settings.npexceptionday = ""

        For Each palavra In lst_NPExceptions.Items


            My.Settings.npexceptionday = My.Settings.npexceptionday + " " + palavra

        Next

    End Sub

    Private Sub Form_NPExceptionDay_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        lst_NPExceptions.Items.Clear()
        Dim palavras As String() = Split(My.Settings.npexceptionday, " ")
        Dim palavra As String
        For Each palavra In palavras

            If palavra <> "" Then
                lst_NPExceptions.Items.Add(palavra)
            End If

        Next


    End Sub
End Class