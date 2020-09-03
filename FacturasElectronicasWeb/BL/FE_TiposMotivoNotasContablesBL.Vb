Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_TiposMotivoNotasContablesBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_TiposMotivoNotasContablesBE As FE_TiposMotivoNotasContablesBE) As Boolean
Dim objFE_TiposMotivoNotasContablesDA As New FE_TiposMotivoNotasContablesDA
Try
Return objFE_TiposMotivoNotasContablesDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_TiposMotivoNotasContablesBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_TiposMotivoNotasContablesDA As New FE_TiposMotivoNotasContablesDA
Try
Return objFE_TiposMotivoNotasContablesDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
