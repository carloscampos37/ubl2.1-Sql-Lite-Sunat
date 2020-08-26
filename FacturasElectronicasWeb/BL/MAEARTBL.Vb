Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class MAEARTBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objMAEARTBE As MAEARTBE) As Boolean
Dim objMAEARTDA As New MAEARTDA
Try
Return objMAEARTDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objMAEARTBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objMAEARTDA As New MAEARTDA
Try
Return objMAEARTDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
