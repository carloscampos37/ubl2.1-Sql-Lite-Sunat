Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_DocumentosElectronicosDetItemBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_DocumentosElectronicosDetItemBE As FE_DocumentosElectronicosDetItemBE) As Boolean
Dim objFE_DocumentosElectronicosDetItemDA As New FE_DocumentosElectronicosDetItemDA
Try
Return objFE_DocumentosElectronicosDetItemDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_DocumentosElectronicosDetItemBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_DocumentosElectronicosDetItemDA As New FE_DocumentosElectronicosDetItemDA
Try
Return objFE_DocumentosElectronicosDetItemDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
