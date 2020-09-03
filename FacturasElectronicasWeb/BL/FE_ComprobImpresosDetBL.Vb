Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ComprobImpresosDetBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ComprobImpresosDetBE As FE_ComprobImpresosDetBE) As Boolean
Dim objFE_ComprobImpresosDetDA As New FE_ComprobImpresosDetDA
Try
Return objFE_ComprobImpresosDetDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ComprobImpresosDetBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ComprobImpresosDetDA As New FE_ComprobImpresosDetDA
Try
Return objFE_ComprobImpresosDetDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
