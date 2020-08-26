Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_DocumentosBajasDetBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_DocumentosBajasDetBE As FE_DocumentosBajasDetBE) As Boolean
Dim objFE_DocumentosBajasDetDA As New FE_DocumentosBajasDetDA
Try
Return objFE_DocumentosBajasDetDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_DocumentosBajasDetBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_DocumentosBajasDetDA As New FE_DocumentosBajasDetDA
Try
Return objFE_DocumentosBajasDetDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
