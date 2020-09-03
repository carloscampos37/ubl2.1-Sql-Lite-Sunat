Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_DistritosBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_DistritosBE As FE_DistritosBE) As Boolean
Dim objFE_DistritosDA As New FE_DistritosDA
Try
Return objFE_DistritosDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_DistritosBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_DistritosDA As New FE_DistritosDA
Try
Return objFE_DistritosDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
