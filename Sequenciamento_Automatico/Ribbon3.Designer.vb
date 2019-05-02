Partial Class Ribbon3
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Exigido para suporte ao Designer de Composição da Classe Windows.Forms
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'Esta chamada é exigida pelo Designer de Componentes.
        InitializeComponent()

    End Sub

    'O componente substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Designer de Componentes
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Designer de Componentes
    'Pode ser modificado usando o Designer de Componentes.
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Sequenciamento = Me.Factory.CreateRibbonTab
        Me.Configuracao = Me.Factory.CreateRibbonGroup
        Me.Sequenciamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sequenciamento
        '
        Me.Sequenciamento.Groups.Add(Me.Configuracao)
        Me.Sequenciamento.Label = "Sequenciamento"
        Me.Sequenciamento.Name = "Sequenciamento"
        '
        'Configuracao
        '
        Me.Configuracao.Label = "Configuração"
        Me.Configuracao.Name = "Configuracao"
        '
        'Ribbon3
        '
        Me.Name = "Ribbon3"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Sequenciamento)
        Me.Sequenciamento.ResumeLayout(False)
        Me.Sequenciamento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Sequenciamento As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Configuracao As Microsoft.Office.Tools.Ribbon.RibbonGroup
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon3() As Ribbon3
        Get
            Return Me.GetRibbon(Of Ribbon3)()
        End Get
    End Property
End Class
