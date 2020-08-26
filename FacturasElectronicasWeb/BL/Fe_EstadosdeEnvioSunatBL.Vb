Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class Fe_EstadosdeEnvioSunatBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFe_EstadosdeEnvioSunatBE As Fe_EstadosdeEnvioSunatBE) As Boolean
Dim objFe_EstadosdeEnvioSunatDA As New Fe_EstadosdeEnvioSunatDA
Try
Return objFe_EstadosdeEnvioSunatDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFe_EstadosdeEnvioSunatBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFe_EstadosdeEnvioSunatDA As New Fe_EstadosdeEnvioSunatDA
Try
Return objFe_EstadosdeEnvioSunatDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
