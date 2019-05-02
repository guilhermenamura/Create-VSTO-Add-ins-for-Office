Imports System.IO.File
Imports System
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Windows.Forms

Public Class Form_ImportDirectory

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fbd1 As String
        Using dialog As New FolderBrowserDialog

            If dialog.ShowDialog() = DialogResult.OK Then
                fbd1 = dialog.SelectedPath.ToString()
                TextBox1.Text = fbd1

            End If
        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mensagem As Object

        mensagem = MsgBox("The current path is: " + My.Settings.name + " do you want to replace?", vbOKCancel)
        If mensagem = MsgBoxResult.Ok Then
            My.Settings.name = TextBox1.Text
            My.Settings.Save()
        End If



    End Sub

    Private Sub Form_ImportDirectory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.name

    End Sub
End Class