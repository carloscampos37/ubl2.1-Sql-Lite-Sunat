Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_AfectacionIgvBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_AfectacionIgvBE As FE_AfectacionIgvBE) As Boolean
Dim objFE_AfectacionIgvDA As New FE_AfectacionIgvDA
Try
Return objFE_AfectacionIgvDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_AfectacionIgvBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_AfectacionIgvDA As New FE_AfectacionIgvDA
Try
Return objFE_AfectacionIgvDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
