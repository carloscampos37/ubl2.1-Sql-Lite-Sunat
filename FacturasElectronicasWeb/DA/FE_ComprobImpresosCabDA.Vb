Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ComprobImpresosCabDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ComprobImpresosCabBE As FE_ComprobImpresosCabBE) As Boolean
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

	lpParameter = New SqlParameter("@ComprobImpreso_Id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.ComprobImpreso_Id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EnvioSedePrincipal", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ComprobImpresosCabBE.EnvioSedePrincipal=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Establecimiento_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.Establecimiento_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_ComprobImpresosCabBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaAct", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.FechaAct
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaDocumento", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.FechaDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@HostName", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.HostName
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@IdentificadorEnvio", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.IdentificadorEnvio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MotivoContigencia", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.MotivoContigencia
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Pedido_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.Pedido_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@UsuarioCodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComprobImpresosCabBE.UsuarioCodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ComprobImpresosCab_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_ComprobImpresosCab_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class
