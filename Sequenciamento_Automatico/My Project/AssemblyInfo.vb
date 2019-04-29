Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security

' As informações gerais sobre um assembly são controladas por meio do seguinte 
' conjunto de atributos. Altere estes valores de atributo para modificar as informações
' associadas a um assembly.

' Examine os valores dos atributos do assembly

<Assembly: AssemblyTitle("Sequenciamento_Automatico")> 
<Assembly: AssemblyDescription("")> 
<Assembly: AssemblyCompany("")> 
<Assembly: AssemblyProduct("Sequenciamento_Automatico")> 
<Assembly: AssemblyCopyright("Copyright ©  2019")> 
<Assembly: AssemblyTrademark("")> 

' Definir ComVisible como false oculta os tipos neste assembly 
' para componentes COM.  Caso precise acessar um tipo neste assembly a partir de 
' COM, defina o atributo ComVisible como true nesse tipo.
<Assembly: ComVisible(False)>

'O GUID a seguir é para a ID de typelib quando este projeto é exposto a COM
<Assembly: Guid("0fa76a3b-712c-4e31-8e62-fda96d132cab")> 

' As informações da versão de um assembly consistem nos quatro valores a seguir:
'
'      Versão Principal
'      Versão Secundária 
'      Número da Versão
'      Revisão
'
' É possível especificar todos os valores ou usar como padrão os Números da Versão e da Revisão 
' utilizando o "*" como mostrado abaixo:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")> 
<Assembly: AssemblyFileVersion("1.0.0.0")> 

Friend Module DesignTimeConstants
    Public Const RibbonTypeSerializer As String = "Microsoft.VisualStudio.Tools.Office.Ribbon.Serialization.RibbonTypeCodeDomSerializer, Microsoft.VisualStudio.Tools.Office.Designer, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Public Const RibbonBaseTypeSerializer As String = "System.ComponentModel.Design.Serialization.TypeCodeDomSerializer, System.Design"
    Public Const RibbonDesigner As String = "Microsoft.VisualStudio.Tools.Office.Ribbon.Design.RibbonDesigner, Microsoft.VisualStudio.Tools.Office.Designer, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
End Module
