Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_EmpresasBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_EmpresasBE As FE_EmpresasBE) As Boolean
Dim objFE_EmpresasDA As New FE_EmpresasDA
Try
Return objFE_EmpresasDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_EmpresasBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_EmpresasDA As New FE_EmpresasDA
Try
Return objFE_EmpresasDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
