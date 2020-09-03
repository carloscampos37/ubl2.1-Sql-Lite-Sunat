Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_parametroventaBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_parametroventaBE As vt_parametroventaBE) As Boolean
Dim objvt_parametroventaDA As New vt_parametroventaDA
Try
Return objvt_parametroventaDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_parametroventaBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_parametroventaDA As New vt_parametroventaDA
Try
Return objvt_parametroventaDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
