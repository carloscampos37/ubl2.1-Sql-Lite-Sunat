Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class Fe_RegionesBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFe_RegionesBE As Fe_RegionesBE) As Boolean
Dim objFe_RegionesDA As New Fe_RegionesDA
Try
Return objFe_RegionesDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFe_RegionesBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFe_RegionesDA As New Fe_RegionesDA
Try
Return objFe_RegionesDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
