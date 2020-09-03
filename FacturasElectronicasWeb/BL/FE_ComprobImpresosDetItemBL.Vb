Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ComprobImpresosDetItemBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ComprobImpresosDetItemBE As FE_ComprobImpresosDetItemBE) As Boolean
Dim objFE_ComprobImpresosDetItemDA As New FE_ComprobImpresosDetItemDA
Try
Return objFE_ComprobImpresosDetItemDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ComprobImpresosDetItemBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ComprobImpresosDetItemDA As New FE_ComprobImpresosDetItemDA
Try
Return objFE_ComprobImpresosDetItemDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
