Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ParametrosBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ParametrosBE As FE_ParametrosBE) As Boolean
Dim objFE_ParametrosDA As New FE_ParametrosDA
Try
Return objFE_ParametrosDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ParametrosBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ParametrosDA As New FE_ParametrosDA
Try
Return objFE_ParametrosDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
