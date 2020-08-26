Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_DocumentosBajasCabBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_DocumentosBajasCabBE As FE_DocumentosBajasCabBE) As Boolean
Dim objFE_DocumentosBajasCabDA As New FE_DocumentosBajasCabDA
Try
Return objFE_DocumentosBajasCabDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_DocumentosBajasCabBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_DocumentosBajasCabDA As New FE_DocumentosBajasCabDA
Try
Return objFE_DocumentosBajasCabDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
