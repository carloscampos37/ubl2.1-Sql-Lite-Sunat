Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class VT_DocumentoBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objVT_DocumentoBE As VT_DocumentoBE) As Boolean
Dim objVT_DocumentoDA As New VT_DocumentoDA
Try
Return objVT_DocumentoDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objVT_DocumentoBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objVT_DocumentoDA As New VT_DocumentoDA
Try
Return objVT_DocumentoDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
