Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntities
Public Class FE_DocumentosElectronicosDetItemDA
Public Function GrabarProc(ByVal vBaseData As String, ByVal vTipo As Integer,byVal vCadConexProc as String, ByVal objClsFE_DocumentosElectronicosDetItemBE As FE_DocumentosElectronicosDetItemBE) As Boolean
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
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.DocumentosElectronicos_id
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentosElectronicosCorrel", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.DocumentosElectronicosCorrel
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@DocumentosElectronicosCorrelItem", SqlDbType.VarChar,10)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.DocumentosElectronicosCorrelItem
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@EmpresaCodigo", SqlDbType.VarChar,3)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.EmpresaCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ItemDescuento", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ItemDescuento
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ItemExonerado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ItemExonerado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ItemGravado", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ItemGravado
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ItemIGV", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ItemIGV
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ItemInafecto", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ItemInafecto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ItemISC", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ItemISC
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ItemOtros", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ItemOtros
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ItemVenta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ItemVenta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PrecioLista", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.PrecioLista
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@PrecioVta", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.PrecioVta
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@Productocantidad", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.Productocantidad
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ProductoCodigo", SqlDbType.VarChar,20)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ProductoCodigo
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@ProductoDescripcion", SqlDbType.VarChar,100)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.ProductoDescripcion
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipodeImpuesto", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.TipodeImpuesto
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipodeISC", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.TipodeISC
	ColParameters.Add(lpParameter)

	lpParameter = New SqlParameter("@TipodePrecio", SqlDbType.VarChar,2)
	lpParameter.Value = objClsFE_DocumentosElectronicosDetItemBE.TipodePrecio
	ColParameters.Add(lpParameter)


objConexionDC.GrabarProc("FE_DocumentosElectronicosDetItem_PRO", vCadConexProc, ColParameters, 600)

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

dt=objConexionDC.ConsultarProc("FE_DocumentosElectronicosDetItem_PRO", vCadConexProc, ColParameters, 600)

IF objConexionDC.cError <> "" Then 

	Throw New Exception(objConexionDC.cError)

 End If 
Return dt

Catch ex As Exception
	Throw ex
End Try
End Function
End Class
