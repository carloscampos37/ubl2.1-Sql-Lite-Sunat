Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_EmpresasSeguridadBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_EmpresasSeguridadBE As FE_EmpresasSeguridadBE) As Boolean
Dim objFE_EmpresasSeguridadDA As New FE_EmpresasSeguridadDA
Try
Return objFE_EmpresasSeguridadDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_EmpresasSeguridadBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_EmpresasSeguridadDA As New FE_EmpresasSeguridadDA
Try
Return objFE_EmpresasSeguridadDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
