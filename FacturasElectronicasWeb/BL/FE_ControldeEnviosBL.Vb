Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_ControldeEnviosBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_ControldeEnviosBE As FE_ControldeEnviosBE) As Boolean
Dim objFE_ControldeEnviosDA As New FE_ControldeEnviosDA
Try
Return objFE_ControldeEnviosDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_ControldeEnviosBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_ControldeEnviosDA As New FE_ControldeEnviosDA
Try
Return objFE_ControldeEnviosDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
