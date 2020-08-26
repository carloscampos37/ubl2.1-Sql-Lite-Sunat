Public Class vt_sistemaBE

Private mid As Int32
Private mtipoanaliticocodigo As String
Private mfamiliaproyectos As String
Private mempresaasientosautomaticos As Int32
Private mgenerapedidotemporal As Int32
Private mpedidotipovena As String
Private mimpresionvisual As Int32
Private mcodigosduplicados As Int32
Private mtemporalpedidos As Int32
Private mPreciototalxfraccion As Boolean
Private mAdministravuelto As Boolean
Private mAdministratipoPago As Boolean
Private mDefaultClienteEventual As Boolean
Private mCodigoPetroleo As String
Private mContabilizaFacturacion As Boolean
Private mPedidotresPasos As Boolean
Private mFechadeTrabajo As DateTime
Private mPedidodelDia As Int32
Private mAdmiteNegativos As Boolean
Private mSaldosxLoteSerie As Boolean
Private mUtilidadMinima As Boolean
Private mPuntoVtxCliente As Boolean
Private mPagosencaja As Boolean
Private mCarpetaLibrosElectronicos As String
Private mCarpetaFacturasElectronicas As String
Private mFacturasElectronicas As Boolean
Private mConsolidaPtosVtasFE As Boolean

#Region "Propiedades"
Public Property id() As Int32
	Get
		Return(mid)
	End Get
	Set (Value As Int32)
		mid = Value
	End Set
End Property
Public Property tipoanaliticocodigo() As String
	Get
		Return(mtipoanaliticocodigo)
	End Get
	Set (Value As String)
		mtipoanaliticocodigo = Value
	End Set
End Property
Public Property familiaproyectos() As String
	Get
		Return(mfamiliaproyectos)
	End Get
	Set (Value As String)
		mfamiliaproyectos = Value
	End Set
End Property
Public Property empresaasientosautomaticos() As Int32
	Get
		Return(mempresaasientosautomaticos)
	End Get
	Set (Value As Int32)
		mempresaasientosautomaticos = Value
	End Set
End Property
Public Property generapedidotemporal() As Int32
	Get
		Return(mgenerapedidotemporal)
	End Get
	Set (Value As Int32)
		mgenerapedidotemporal = Value
	End Set
End Property
Public Property pedidotipovena() As String
	Get
		Return(mpedidotipovena)
	End Get
	Set (Value As String)
		mpedidotipovena = Value
	End Set
End Property
Public Property impresionvisual() As Int32
	Get
		Return(mimpresionvisual)
	End Get
	Set (Value As Int32)
		mimpresionvisual = Value
	End Set
End Property
Public Property codigosduplicados() As Int32
	Get
		Return(mcodigosduplicados)
	End Get
	Set (Value As Int32)
		mcodigosduplicados = Value
	End Set
End Property
Public Property temporalpedidos() As Int32
	Get
		Return(mtemporalpedidos)
	End Get
	Set (Value As Int32)
		mtemporalpedidos = Value
	End Set
End Property
Public Property Preciototalxfraccion() As Boolean
	Get
		Return(mPreciototalxfraccion)
	End Get
	Set (Value As Boolean)
		mPreciototalxfraccion = Value
	End Set
End Property
Public Property Administravuelto() As Boolean
	Get
		Return(mAdministravuelto)
	End Get
	Set (Value As Boolean)
		mAdministravuelto = Value
	End Set
End Property
Public Property AdministratipoPago() As Boolean
	Get
		Return(mAdministratipoPago)
	End Get
	Set (Value As Boolean)
		mAdministratipoPago = Value
	End Set
End Property
Public Property DefaultClienteEventual() As Boolean
	Get
		Return(mDefaultClienteEventual)
	End Get
	Set (Value As Boolean)
		mDefaultClienteEventual = Value
	End Set
End Property
Public Property CodigoPetroleo() As String
	Get
		Return(mCodigoPetroleo)
	End Get
	Set (Value As String)
		mCodigoPetroleo = Value
	End Set
End Property
Public Property ContabilizaFacturacion() As Boolean
	Get
		Return(mContabilizaFacturacion)
	End Get
	Set (Value As Boolean)
		mContabilizaFacturacion = Value
	End Set
End Property
Public Property PedidotresPasos() As Boolean
	Get
		Return(mPedidotresPasos)
	End Get
	Set (Value As Boolean)
		mPedidotresPasos = Value
	End Set
End Property
Public Property FechadeTrabajo() As DateTime
	Get
		Return(mFechadeTrabajo)
	End Get
	Set (Value As DateTime)
		mFechadeTrabajo = Value
	End Set
End Property
Public Property PedidodelDia() As Int32
	Get
		Return(mPedidodelDia)
	End Get
	Set (Value As Int32)
		mPedidodelDia = Value
	End Set
End Property
Public Property AdmiteNegativos() As Boolean
	Get
		Return(mAdmiteNegativos)
	End Get
	Set (Value As Boolean)
		mAdmiteNegativos = Value
	End Set
End Property
Public Property SaldosxLoteSerie() As Boolean
	Get
		Return(mSaldosxLoteSerie)
	End Get
	Set (Value As Boolean)
		mSaldosxLoteSerie = Value
	End Set
End Property
Public Property UtilidadMinima() As Boolean
	Get
		Return(mUtilidadMinima)
	End Get
	Set (Value As Boolean)
		mUtilidadMinima = Value
	End Set
End Property
Public Property PuntoVtxCliente() As Boolean
	Get
		Return(mPuntoVtxCliente)
	End Get
	Set (Value As Boolean)
		mPuntoVtxCliente = Value
	End Set
End Property
Public Property Pagosencaja() As Boolean
	Get
		Return(mPagosencaja)
	End Get
	Set (Value As Boolean)
		mPagosencaja = Value
	End Set
End Property
Public Property CarpetaLibrosElectronicos() As String
	Get
		Return(mCarpetaLibrosElectronicos)
	End Get
	Set (Value As String)
		mCarpetaLibrosElectronicos = Value
	End Set
End Property
Public Property CarpetaFacturasElectronicas() As String
	Get
		Return(mCarpetaFacturasElectronicas)
	End Get
	Set (Value As String)
		mCarpetaFacturasElectronicas = Value
	End Set
End Property
Public Property FacturasElectronicas() As Boolean
	Get
		Return(mFacturasElectronicas)
	End Get
	Set (Value As Boolean)
		mFacturasElectronicas = Value
	End Set
End Property
Public Property ConsolidaPtosVtasFE() As Boolean
	Get
		Return(mConsolidaPtosVtasFE)
	End Get
	Set (Value As Boolean)
		mConsolidaPtosVtasFE = Value
	End Set
End Property
#End Region

End Class 
