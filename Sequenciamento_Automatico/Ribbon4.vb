'TODO: siga estas etapas para habilitar o item da Faixa de Opções (XML):

'1: Copie o bloco de código a seguir para a classe ThisAddin, ThisWorkbook ou ThisDocument.

'Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
'    Return New Ribbon4()
'End Function

'2. Crie métodos de retorno de chamadas na região "Retornos de Chamada da Faixa de Opções" desta classe para manipular ações do usuário
'   ações, como clicar em um botão. Observação: se você tiver exportado esta Faixa de Opções do
'   designer da Faixa de Opções, mova seu código dos manipuladores de evento para os métodos de retorno de chamada e
'   modifique o código par atrabalhar com o modelo de programação de extensibilidade da Faixa de Opções (RibbonX).

'3. Atribua atributos às marcas de controle no arquivo XML da Faixa de Opções para identificar os métodos de retorno de chamada apropriados em seu código.

'Para obter mais informações, consulte a documentação XML da Faixa de Opções na Ajuda do Visual Studio Tools para Office.

<Runtime.InteropServices.ComVisible(True)> _
Public Class Ribbon4
    Implements Office.IRibbonExtensibility

    Private ribbon As Office.IRibbonUI

    Public Sub New()
    End Sub

    Public Function GetCustomUI(ByVal ribbonID As String) As String Implements Office.IRibbonExtensibility.GetCustomUI
        Return GetResourceText("Sequenciamento_Automatico.Ribbon4.xml")
    End Function

#Region "Retornos de Chamada da Faixa de Opções"
    'Crie métodos de retorno de chamada aqui. Para obter mais informações sobre como adicionar métodos de retorno de chamada, visite https://go.microsoft.com/fwlink/?LinkID=271226
    Public Sub Ribbon_Load(ByVal ribbonUI As Office.IRibbonUI)
        Me.ribbon = ribbonUI
    End Sub



#End Region

#Region "Auxiliares"

    Private Shared Function GetResourceText(ByVal resourceName As String) As String
        Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Dim resourceNames() As String = asm.GetManifestResourceNames()
        For i As Integer = 0 To resourceNames.Length - 1
            If String.Compare(resourceName, resourceNames(i), StringComparison.OrdinalIgnoreCase) = 0 Then
                Using resourceReader As IO.StreamReader = New IO.StreamReader(asm.GetManifestResourceStream(resourceNames(i)))
                    If resourceReader IsNot Nothing Then
                        Return resourceReader.ReadToEnd()
                    End If
                End Using
            End If
        Next
        Return Nothing
    End Function

#End Region

End Class
