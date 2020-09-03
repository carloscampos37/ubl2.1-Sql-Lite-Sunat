Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_EstablecimientosBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_EstablecimientosBE As FE_EstablecimientosBE) As Boolean
Dim objFE_EstablecimientosDA As New FE_EstablecimientosDA
Try
Return objFE_EstablecimientosDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_EstablecimientosBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_EstablecimientosDA As New FE_EstablecimientosDA
Try
Return objFE_EstablecimientosDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
