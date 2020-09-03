Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_puntoventaBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_puntoventaBE As vt_puntoventaBE) As Boolean
Dim objvt_puntoventaDA As New vt_puntoventaDA
Try
Return objvt_puntoventaDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_puntoventaBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_puntoventaDA As New vt_puntoventaDA
Try
Return objvt_puntoventaDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
