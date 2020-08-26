Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_DocumentosxEmpresaBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_DocumentosxEmpresaBE As FE_DocumentosxEmpresaBE) As Boolean
Dim objFE_DocumentosxEmpresaDA As New FE_DocumentosxEmpresaDA
Try
Return objFE_DocumentosxEmpresaDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_DocumentosxEmpresaBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_DocumentosxEmpresaDA As New FE_DocumentosxEmpresaDA
Try
Return objFE_DocumentosxEmpresaDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
