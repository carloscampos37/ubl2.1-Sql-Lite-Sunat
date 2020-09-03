Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ResumenDiarioDocumentosDetBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ResumenDiarioDocumentosDetBE As FE_ResumenDiarioDocumentosDetBE) As Boolean
Dim objFE_ResumenDiarioDocumentosDetDA As New FE_ResumenDiarioDocumentosDetDA
Try
Return objFE_ResumenDiarioDocumentosDetDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ResumenDiarioDocumentosDetBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ResumenDiarioDocumentosDetDA As New FE_ResumenDiarioDocumentosDetDA
Try
Return objFE_ResumenDiarioDocumentosDetDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
