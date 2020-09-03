Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ComunicacionBajaDetDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ComunicacionBajaDetBE As FE_ComunicacionBajaDetBE) As Boolean
Dim ColParameters As SqlParameterCollection
Dim lpParameter As SqlParameter
Try
	ColParameters = New SqlCommand().Parameters

	lpParameter = New SqlParameter("@Base", SqlDbType.VarChar, 50)
	lpParameter.Value = vBaseData
	 ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Tipo", SqlDbType.Int)
	lpParameter.Value = vTipo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ClienteRazonSocial", SqlDbType.VarChar,60)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.ClienteRazonSocial
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@clienteRuc", SqlDbType.VarChar,11)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.clienteRuc
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ComunicacionBaja_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.ComunicacionBaja_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ComunicacionbajaItem", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.ComunicacionbajaItem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@CorrelativoEnvio", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.CorrelativoEnvio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaAct", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.FechaAct
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MotivoBaja_id", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.MotivoBaja_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumeroDocumento", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.NumeroDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@SerieDocumento", SqlDbType.VarChar,4)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.SerieDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipoDocumento", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_ComunicacionBajaDetBE.TipoDocumento
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ComunicacionBajaDet_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	MsgBox(objConexionDC.cError)

 End If 
Return True

Catch ex As Exception
	Throw ex
End Try
End Function
Public Function ConsultarProc(ByVal vBaseData As String, ByVal vTipo As Integer, ByVal vCadConexProc As String,Optional ByVal vCondicion As String = "") As DataTable
Dim ColParameters As SqlParameterCollection
Dim lpParameter As SqlParameter
Dim dt As New DataTable
Try
ColParameters = New SqlCommand().Parameters

lpParameter = New SqlParameter("@Base", SqlDbType.VarChar, 50)
lpParameter.Value = vBaseData
 ColParameters.Add(lpParameter)

lpParameter = New SqlParameter("@Tipo", SqlDbType.Int)
lpParameter.Value = vTipo
ColParameters.Add(lpParameter)

lpParameter = New SqlParameter("@Condicion", SqlDbType.VarChar, 250)
lpParameter.Value = vCondicion
 ColParameters.Add(lpParameter)

dt=objConexionDC.ConsultarProc("FE_ComunicacionBajaDet_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class
