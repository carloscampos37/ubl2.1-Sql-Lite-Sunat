Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class vt_sistemaBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objvt_sistemaBE As vt_sistemaBE) As Boolean
Dim objvt_sistemaDA As New vt_sistemaDA
Try
Return objvt_sistemaDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objvt_sistemaBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objvt_sistemaDA As New vt_sistemaDA
Try
Return objvt_sistemaDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
