Imports MSScriptControl
Imports System.IO

Public Class ScriptPlug

    Public PluginPath As String

    Function GetURL(ByVal PluginName As String, ByVal Keyword As String) As String
        Dim scriptObj As New ScriptControl
        Dim retVal As String
        scriptObj.Language = "VBScript"
        scriptObj.AddCode(System.IO.File.ReadAllText(PluginPath + "\" + PluginName + ".vbs"))
        retVal = scriptObj.Run("GetURL", Keyword)
        Return retVal
    End Function


    Function GetSuggestions(ByVal PluginName As String, ByVal JSONData As String) As String
        Dim scriptObj As New ScriptControl
        Dim retVal As String
        scriptObj.Language = "VBScript"
        scriptObj.AddCode(System.IO.File.ReadAllText(PluginPath + "\" + PluginName + ".vbs"))
        retVal = scriptObj.Run("GetSuggestions", JSONData)
        Return retVal
    End Function



    Function GetPluginList() As ArrayList
        Dim retVal As New ArrayList
        For Each objFile In Directory.GetFiles(PluginPath)
            objFile = Path.GetFileName(objFile)
            If objFile.ToUpper().EndsWith(".VBS") Then
                retVal.Add(Path.GetFileNameWithoutExtension(objFile))
            End If
        Next
        Return retVal
    End Function

End Class
