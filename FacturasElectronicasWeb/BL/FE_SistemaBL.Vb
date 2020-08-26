Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_SistemaBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_SistemaBE As FE_SistemaBE) As Boolean
Dim objFE_SistemaDA As New FE_SistemaDA
Try
Return objFE_SistemaDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_SistemaBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_SistemaDA As New FE_SistemaDA
Try
Return objFE_SistemaDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
