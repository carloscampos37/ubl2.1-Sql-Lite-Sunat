Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_modoventaBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_modoventaBE As vt_modoventaBE) As Boolean
Dim objvt_modoventaDA As New vt_modoventaDA
Try
Return objvt_modoventaDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_modoventaBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_modoventaDA As New vt_modoventaDA
Try
Return objvt_modoventaDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
