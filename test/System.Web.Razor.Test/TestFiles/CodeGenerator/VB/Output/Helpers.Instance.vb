'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:N.N.NNNNN.N
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System

Namespace TestOutput
Public Class Helpers

#ExternalSource("Helpers.vbhtml", 1)
Public Function Bold(s as String) As Template

#End ExternalSource
Return New Template(Sub (__razor_helper_writer)

#ExternalSource("Helpers.vbhtml", 1)
                         
    s = s.ToUpper()


#End ExternalSource
WriteLiteralTo(__razor_helper_writer, "    ")

WriteLiteralTo(__razor_helper_writer, "<strong>")


#ExternalSource("Helpers.vbhtml", 3)
WriteTo(__razor_helper_writer, s)


#End ExternalSource
WriteLiteralTo(__razor_helper_writer, "</strong>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Helpers.vbhtml", 4)


#End ExternalSource
End Sub)
End Function

#ExternalSource("Helpers.vbhtml", 6)
Public Function Italic(s as String) As Template

#End ExternalSource
Return New Template(Sub (__razor_helper_writer)

#ExternalSource("Helpers.vbhtml", 6)
                           
    s = s.ToUpper()


#End ExternalSource
WriteLiteralTo(__razor_helper_writer, "    ")

WriteLiteralTo(__razor_helper_writer, "<em>")


#ExternalSource("Helpers.vbhtml", 8)
WriteTo(__razor_helper_writer, s)


#End ExternalSource
WriteLiteralTo(__razor_helper_writer, "</em>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Helpers.vbhtml", 9)


#End ExternalSource
End Sub)
End Function

Public Sub New()
MyBase.New
End Sub
Public Overrides Sub Execute()
WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Helpers.vbhtml",11)
Write(Bold("Hello"))


#End ExternalSource
End Sub
End Class
End Namespace
