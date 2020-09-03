Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class Fe_DireccionesSunatBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFe_DireccionesSunatBE As Fe_DireccionesSunatBE) As Boolean
Dim objFe_DireccionesSunatDA As New Fe_DireccionesSunatDA
Try
Return objFe_DireccionesSunatDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFe_DireccionesSunatBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFe_DireccionesSunatDA As New Fe_DireccionesSunatDA
Try
Return objFe_DireccionesSunatDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
