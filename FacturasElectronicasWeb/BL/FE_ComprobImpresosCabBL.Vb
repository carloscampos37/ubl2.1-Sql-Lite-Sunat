Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ComprobImpresosCabBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ComprobImpresosCabBE As FE_ComprobImpresosCabBE) As Boolean
Dim objFE_ComprobImpresosCabDA As New FE_ComprobImpresosCabDA
Try
Return objFE_ComprobImpresosCabDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ComprobImpresosCabBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ComprobImpresosCabDA As New FE_ComprobImpresosCabDA
Try
Return objFE_ComprobImpresosCabDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
