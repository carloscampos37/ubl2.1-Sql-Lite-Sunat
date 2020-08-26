Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_DocumentosElectronicosCabDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_DocumentosElectronicosCabBE As FE_DocumentosElectronicosCabBE) As Boolean
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

	lpParameter = New SqlParameter("@DocumentosElectronicos_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.DocumentosElectronicos_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EnvioSedePrincipal", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_DocumentosElectronicosCabBE.EnvioSedePrincipal=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Establecimiento_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.Establecimiento_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoAnulado", SqlDbType.VarChar,1)
	lpParameter.Value =iif( objClsFE_DocumentosElectronicosCabBE.EstadoAnulado=true,1,0) 
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@fechaAct", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.fechaAct
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaDocumento", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.FechaDocumento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaEnvio", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.FechaEnvio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@HostName", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.HostName
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@IdentificadorEnvio", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.IdentificadorEnvio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Pedido_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.Pedido_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@usuarioCodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosCabBE.usuarioCodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_DocumentosElectronicosCab_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_DocumentosElectronicosCab_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class
