Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_DocumentosFEBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_DocumentosFEBE As FE_DocumentosFEBE) As Boolean
Dim objFE_DocumentosFEDA As New FE_DocumentosFEDA
Try
Return objFE_DocumentosFEDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_DocumentosFEBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_DocumentosFEDA As New FE_DocumentosFEDA
Try
Return objFE_DocumentosFEDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
