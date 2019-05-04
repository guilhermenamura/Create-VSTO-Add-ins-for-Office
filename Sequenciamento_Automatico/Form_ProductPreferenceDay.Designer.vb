<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ProductPreferenceDay
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.cmb_Startin = New System.Windows.Forms.ComboBox()
        Me.cmb_Type = New System.Windows.Forms.ComboBox()
        Me.txt_Product = New System.Windows.Forms.TextBox()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.dtg_StartPreference = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.REMOVELINEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtg_StartPreference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Add)
        Me.GroupBox2.Controls.Add(Me.cmb_Startin)
        Me.GroupBox2.Controls.Add(Me.cmb_Type)
        Me.GroupBox2.Controls.Add(Me.txt_Product)
        Me.GroupBox2.Controls.Add(Me.txt_Id)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(544, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 179)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation:"
        '
        'btn_Add
        '
        Me.btn_Add.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_Add.Location = New System.Drawing.Point(135, 132)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(79, 43)
        Me.btn_Add.TabIndex = 0
        Me.btn_Add.Text = "+"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'cmb_Startin
        '
        Me.cmb_Startin.FormattingEnabled = True
        Me.cmb_Startin.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmb_Startin.Location = New System.Drawing.Point(71, 105)
        Me.cmb_Startin.Name = "cmb_Startin"
        Me.cmb_Startin.Size = New System.Drawing.Size(143, 21)
        Me.cmb_Startin.TabIndex = 7
        '
        'cmb_Type
        '
        Me.cmb_Type.FormattingEnabled = True
        Me.cmb_Type.Items.AddRange(New Object() {"SIMPLES", "EXTENSO", "ESPECIAL"})
        Me.cmb_Type.Location = New System.Drawing.Point(70, 78)
        Me.cmb_Type.Name = "cmb_Type"
        Me.cmb_Type.Size = New System.Drawing.Size(144, 21)
        Me.cmb_Type.TabIndex = 6
        '
        'txt_Product
        '
        Me.txt_Product.Location = New System.Drawing.Point(69, 50)
        Me.txt_Product.Name = "txt_Product"
        Me.txt_Product.Size = New System.Drawing.Size(145, 20)
        Me.txt_Product.TabIndex = 5
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(68, 22)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(146, 20)
        Me.txt_Id.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Start In:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Reset)
        Me.GroupBox1.Controls.Add(Me.dtg_StartPreference)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 209)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "START Preference:"
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(6, 172)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(44, 20)
        Me.btn_Reset.TabIndex = 2
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'dtg_StartPreference
        '
        Me.dtg_StartPreference.AllowUserToAddRows = False
        Me.dtg_StartPreference.AllowUserToDeleteRows = False
        Me.dtg_StartPreference.AllowUserToOrderColumns = True
        Me.dtg_StartPreference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_StartPreference.ColumnHeadersVisible = False
        Me.dtg_StartPreference.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtg_StartPreference.Location = New System.Drawing.Point(6, 19)
        Me.dtg_StartPreference.MultiSelect = False
        Me.dtg_StartPreference.Name = "dtg_StartPreference"
        Me.dtg_StartPreference.ReadOnly = True
        Me.dtg_StartPreference.Size = New System.Drawing.Size(503, 147)
        Me.dtg_StartPreference.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REMOVELINEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(148, 26)
        '
        'REMOVELINEToolStripMenuItem
        '
        Me.REMOVELINEToolStripMenuItem.Name = "REMOVELINEToolStripMenuItem"
        Me.REMOVELINEToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.REMOVELINEToolStripMenuItem.Text = "REMOVE LINE"
        '
        'Form_ProductPreferenceDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 237)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_ProductPreferenceDay"
        Me.Text = "Form_ProductPreferenceDay"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtg_StartPreference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents btn_Add As Windows.Forms.Button
    Friend WithEvents cmb_Startin As Windows.Forms.ComboBox
    Friend WithEvents cmb_Type As Windows.Forms.ComboBox
    Friend WithEvents txt_Product As Windows.Forms.TextBox
    Friend WithEvents txt_Id As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btn_Reset As Windows.Forms.Button
    Protected WithEvents dtg_StartPreference As Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As Windows.Forms.ErrorProvider
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents REMOVELINEToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
