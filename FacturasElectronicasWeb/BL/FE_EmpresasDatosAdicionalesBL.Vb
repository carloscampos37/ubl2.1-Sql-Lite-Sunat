Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class FE_EmpresasDatosAdicionalesBL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objFE_EmpresasDatosAdicionalesBE As FE_EmpresasDatosAdicionalesBE) As Boolean
Dim objFE_EmpresasDatosAdicionalesDA As New FE_EmpresasDatosAdicionalesDA
Try
Return objFE_EmpresasDatosAdicionalesDA.GrabarProc(vBaseData, vTipo,vCadConexProc, objFE_EmpresasDatosAdicionalesBE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objFE_EmpresasDatosAdicionalesDA As New FE_EmpresasDatosAdicionalesDA
Try
Return objFE_EmpresasDatosAdicionalesDA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
