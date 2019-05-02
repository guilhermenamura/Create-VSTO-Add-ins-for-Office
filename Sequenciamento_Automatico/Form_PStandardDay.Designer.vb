<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PStandardDay
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chklst_PStandardDays = New System.Windows.Forms.CheckedListBox()
        Me.btn_Apply = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chklst_PStandardDays)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P Standard Day:"
        '
        'chklst_PStandardDays
        '
        Me.chklst_PStandardDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklst_PStandardDays.FormattingEnabled = True
        Me.chklst_PStandardDays.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.chklst_PStandardDays.Location = New System.Drawing.Point(6, 29)
        Me.chklst_PStandardDays.Name = "chklst_PStandardDays"
        Me.chklst_PStandardDays.Size = New System.Drawing.Size(136, 151)
        Me.chklst_PStandardDays.TabIndex = 0
        '
        'btn_Apply
        '
        Me.btn_Apply.Location = New System.Drawing.Point(79, 207)
        Me.btn_Apply.Name = "btn_Apply"
        Me.btn_Apply.Size = New System.Drawing.Size(75, 23)
        Me.btn_Apply.TabIndex = 1
        Me.btn_Apply.Text = "Apply"
        Me.btn_Apply.UseVisualStyleBackColor = True
        '
        'Form_PStandardDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(166, 246)
        Me.Controls.Add(Me.btn_Apply)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_PStandardDay"
        Me.Text = "Form_PStandardDay"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents chklst_PStandardDays As Windows.Forms.CheckedListBox
    Friend WithEvents btn_Apply As Windows.Forms.Button
End Class
