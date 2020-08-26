Imports DataAccess
Imports BusinessEntities
Imports System.Data
Public Class Listapre1BL

Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, ByVal objListapre1BE As Listapre1BE) As Boolean
Dim objListapre1DA As New Listapre1DA
Try
Return objListapre1DA.GrabarProc(vBaseData, vTipo,vCadConexProc, objListapre1BE)
Catch ex As Exception
Throw ex
End try
End Function

Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer,ByVal vCadConexProc As String, Optional vCondicion as string="") As Datatable
Dim objListapre1DA As New Listapre1DA
Try
Return objListapre1DA.ConsultarProc(vBaseData, vTipo,vCadConexProc, vCondicion)
Catch ex As Exception
Throw ex
End try
End Function

End Class
