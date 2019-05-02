Imports Microsoft.Office.Tools.Ribbon

Imports Sequenciamento_Automatico.Form_ImportDirectory
Imports System



Public Class Ribbonbar1

    Private Sub Ribbonbar1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn_directoryimport_Click(sender As Object, e As RibbonControlEventArgs) Handles btn_directoryimport.Click

        Dim form1 As New Form_ImportDirectory
        form1.Show()

    End Sub

    Private Sub btn_SequencingInterval_Click(sender As Object, e As RibbonControlEventArgs) Handles btn_SequencingInterval.Click
        Dim form2 As New Form_IntervalSequenceControl
        form2.Show()

    End Sub

    Private Sub btn_NPException_Click(sender As Object, e As RibbonControlEventArgs) Handles btn_NPException.Click
        Dim form3 As New Form_NPExceptionDay

        form3.Show()
    End Sub

    Private Sub btn_PStandardDay_Click(sender As Object, e As RibbonControlEventArgs) Handles btn_PStandardDay.Click
        Dim form4 As New Form_PStandardDay

        form4.Show()
    End Sub
End Class
