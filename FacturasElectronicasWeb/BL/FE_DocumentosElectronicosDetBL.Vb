Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_DocumentosElectronicosDetBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_DocumentosElectronicosDetBE As FE_DocumentosElectronicosDetBE) As Boolean
Dim objFE_DocumentosElectronicosDetDA As New FE_DocumentosElectronicosDetDA
Try
Return objFE_DocumentosElectronicosDetDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_DocumentosElectronicosDetBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_DocumentosElectronicosDetDA As New FE_DocumentosElectronicosDetDA
Try
Return objFE_DocumentosElectronicosDetDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
