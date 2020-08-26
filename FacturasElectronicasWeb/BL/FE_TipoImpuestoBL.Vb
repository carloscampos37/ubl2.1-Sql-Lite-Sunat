Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_TipoImpuestoBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_TipoImpuestoBE As FE_TipoImpuestoBE) As Boolean
Dim objFE_TipoImpuestoDA As New FE_TipoImpuestoDA
Try
Return objFE_TipoImpuestoDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_TipoImpuestoBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_TipoImpuestoDA As New FE_TipoImpuestoDA
Try
Return objFE_TipoImpuestoDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
