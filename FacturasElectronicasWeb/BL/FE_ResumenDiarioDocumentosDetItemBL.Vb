Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ResumenDiarioDocumentosDetItemBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ResumenDiarioDocumentosDetItemBE As FE_ResumenDiarioDocumentosDetItemBE) As Boolean
Dim objFE_ResumenDiarioDocumentosDetItemDA As New FE_ResumenDiarioDocumentosDetItemDA
Try
Return objFE_ResumenDiarioDocumentosDetItemDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ResumenDiarioDocumentosDetItemBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ResumenDiarioDocumentosDetItemDA As New FE_ResumenDiarioDocumentosDetItemDA
Try
Return objFE_ResumenDiarioDocumentosDetItemDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
