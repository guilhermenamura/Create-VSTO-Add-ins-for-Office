<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_NPExceptionDay
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
        Me.lst_NPExceptions = New System.Windows.Forms.ListBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Remove = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lst_NPExceptions)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 408)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NP:"
        '
        'lst_NPExceptions
        '
        Me.lst_NPExceptions.FormattingEnabled = True
        Me.lst_NPExceptions.Location = New System.Drawing.Point(12, 19)
        Me.lst_NPExceptions.Name = "lst_NPExceptions"
        Me.lst_NPExceptions.Size = New System.Drawing.Size(220, 381)
        Me.lst_NPExceptions.TabIndex = 0
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(3, 13)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(129, 35)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Remove)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Location = New System.Drawing.Point(250, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 101)
        Me.Panel1.TabIndex = 2
        '
        'btn_Remove
        '
        Me.btn_Remove.Location = New System.Drawing.Point(3, 54)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(129, 35)
        Me.btn_Remove.TabIndex = 2
        Me.btn_Remove.Text = "Remove"
        Me.btn_Remove.UseVisualStyleBackColor = True
        '
        'Form_NPExceptionDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 424)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_NPExceptionDay"
        Me.Text = "Form_NPExceptionDay"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents lst_NPExceptions As Windows.Forms.ListBox
    Friend WithEvents btn_add As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btn_Remove As Windows.Forms.Button
End Class
