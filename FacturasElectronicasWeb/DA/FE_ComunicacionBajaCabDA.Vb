Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_ComunicacionBajaCabDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_ComunicacionBajaCabBE As FE_ComunicacionBajaCabBE) As Boolean
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

	lpParameter = New SqlParameter("@ArchivoXmlAceptado", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.ArchivoXmlAceptado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ComunicacionBaja_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.ComunicacionBaja_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Establecimiento_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.Establecimiento_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EstadoEnvioSunat_id", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.EstadoEnvioSunat_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaAct", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.FechaAct
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechadeBaja", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.FechadeBaja
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@FechaEnvio", SqlDbType.DateTime)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.FechaEnvio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@IdentificadorEnvio", SqlDbType.VarChar,30)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.IdentificadorEnvio
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@MensajeRecepcion", SqlDbType.VarChar,60)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.MensajeRecepcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NroDocumentos", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.NroDocumentos
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@NumerodeAceptacion", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.NumerodeAceptacion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Usuariocodigo", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_ComunicacionBajaCabBE.Usuariocodigo
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_ComunicacionBajaCab_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_ComunicacionBajaCab_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class
