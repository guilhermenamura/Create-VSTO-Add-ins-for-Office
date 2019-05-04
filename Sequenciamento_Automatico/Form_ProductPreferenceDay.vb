Imports System.Windows.Forms

Public Class Form_ProductPreferenceDay
    Public index As Integer

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        My.Settings.productpreferenceday = ""
        Call returnar()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        'save in App.config

        If txt_Id.Text = " " Or txt_Product.Text = " " Or (cmb_Startin.Text.Trim().Length = 0) Or (cmb_Type.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(btn_Add, "Verifique ter preenchido todos os dados!")
            MsgBox("ERROR")
            Exit Sub
        End If
        My.Settings.productpreferenceday = My.Settings.productpreferenceday + " " + txt_Id.Text + ";" _
                + txt_Product.Text + ";" + cmb_Type.SelectedItem.ToString() + ";" + cmb_Startin.SelectedItem.ToString()


        MsgBox(My.Settings.productpreferenceday)
        Call returnar()
    End Sub

    Private Sub Form_ProductPreferenceDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call returnar()
    End Sub



    Private Sub dtg_StartPreference_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_StartPreference.CellClick
        index = e.RowIndex

        ContextMenuStrip1.Show(Cursor.Position)


        Try
            txt_Id.Text = dtg_StartPreference.Rows(index).Cells(0).Value.ToString()
            txt_Product.Text = dtg_StartPreference.Rows(index).Cells(1).Value.ToString()
            cmb_Type.SelectedItem = dtg_StartPreference.Rows(index).Cells(2).Value.ToString()
            cmb_Startin.SelectedItem = dtg_StartPreference.Rows(index).Cells(3).Value.ToString()

        Catch

        End Try

    End Sub

    Private Sub REMOVELINEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMOVELINEToolStripMenuItem.Click
        Dim rowselected As DataGridViewRow
        Dim productselect(3) As String
        rowselected = dtg_StartPreference.Rows(index)

        'relay data and do search in App.config


        productselect(0) = rowselected.Cells(0).Value.ToString()
        productselect(1) = rowselected.Cells(1).Value.ToString()
        productselect(2) = rowselected.Cells(2).Value.ToString()
        productselect(3) = rowselected.Cells(3).Value.ToString()


        Dim phrases() As String = Split(My.Settings.productpreferenceday, " ")
        Dim x As Integer = 0
        Dim findtheproductinarray As Boolean = False
        Dim y As Integer = 0

        My.Settings.productpreferenceday = ""

        For Each phrase In phrases

            If phrase = (productselect(0) + ";" + productselect(1) + ";" + productselect(2) + ";" + productselect(3)) Then

                dtg_StartPreference.Rows.RemoveAt(dtg_StartPreference.Rows(index).Index)
                findtheproductinarray = True

                txt_Id.Text = ""
                txt_Product.Text = ""
                cmb_Type.Text = ""
                cmb_Startin.Text = ""
                findtheproductinarray = True

                phrases(y) = ""

                y = y + 1


            End If

            x = x + 1

        Next

        For Each phrase In phrases

            If phrase <> "" And phrase <> (productselect(0) + ";" + productselect(1) + ";" + productselect(2) + ";" + productselect(3)) Then
                My.Settings.productpreferenceday = My.Settings.productpreferenceday + " " + phrase

            End If
        Next

        MsgBox(My.Settings.productpreferenceday)

        Call returnar()

    End Sub

    Private Sub btn_Add_Validated(sender As Object, e As EventArgs) Handles btn_Add.Validated
        If (txt_Id.Text.Trim().Length = 0) Or (txt_Product.Text.Trim().Length = 0) Or (cmb_Type.Text.Trim().Length = 0) Or (cmb_Startin.Text.Trim().Length = 0) Then

            ErrorProvider1.SetError(btn_Add, "Verifique ter preenchido todos os dados!")

        Else
            ErrorProvider1.SetError(btn_Add, "")
        End If
    End Sub

    Private Sub cmb_Startin_Validated(sender As Object, e As EventArgs) Handles cmb_Startin.Validated
        If (cmb_Startin.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(cmb_Startin, "Selecione o dia que deseja separar para o produto!")

        Else
            ErrorProvider1.SetError(cmb_Startin, "")
        End If
    End Sub

    Private Sub cmb_Type_Validated(sender As Object, e As EventArgs) Handles cmb_Type.Validated
        If (cmb_Type.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(cmb_Type, "Selecione o tipo do material!")

        Else
            ErrorProvider1.SetError(cmb_Type, "")
        End If
    End Sub

    Private Sub txt_Product_Validated(sender As Object, e As EventArgs) Handles txt_Product.Validated
        If (txt_Product.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(txt_Product, "Informe um produto!")

        Else
            ErrorProvider1.SetError(txt_Product, "")
        End If
    End Sub

    Private Sub txt_Id_Validated(sender As Object, e As EventArgs) Handles txt_Id.Validated
        If (txt_Id.Text.Trim().Length = 0) Then
            ErrorProvider1.SetError(txt_Id, "Informe uma Id Valida respeitando a sequencia!")

        Else
            ErrorProvider1.SetError(txt_Id, "")
        End If
    End Sub



    Public Sub returnar()



        dtg_StartPreference.Rows.Clear()
        dtg_StartPreference.Refresh()




        dtg_StartPreference.Columns.Add("id", "Id")
        dtg_StartPreference.Columns.Add("product", "Product")
        dtg_StartPreference.Columns.Add("type", "Type")
        dtg_StartPreference.Columns.Add("startin", "Start In")



        Dim phrases() As String = Split(My.Settings.productpreferenceday, " ")
        Dim x As Integer = 0
        For Each phrase In phrases

            Dim words() As String = Split(phrase, ";")

            dtg_StartPreference.Rows.Insert(x, words)

            x = x + 1

        Next

        dtg_StartPreference.Rows.RemoveAt(0)

    End Sub





End Class