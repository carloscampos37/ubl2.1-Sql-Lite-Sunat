Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ResumenDiarioDocumentosCabDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ResumenDiarioDocumentosCabBE As FE_ResumenDiarioDocumentosCabBE) As Boolean
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

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EnvioSedePrincipal", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ResumenDiarioDocumentosCabBE.EnvioSedePrincipal=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Establecimiento_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.Establecimiento_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ResumenDiarioDocumentosCabBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaAct", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.fechaAct
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaDocumento", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.FechaDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaEnvio", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.FechaEnvio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@HostName", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.HostName
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@IdentificadorEnvio", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.IdentificadorEnvio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Pedido_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.Pedido_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Resumendiario_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.Resumendiario_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuarioCodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ResumenDiarioDocumentosCabBE.usuarioCodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ResumenDiarioDocumentosCab_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_ResumenDiarioDocumentosCab_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class
