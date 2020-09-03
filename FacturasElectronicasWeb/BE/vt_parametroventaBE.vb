Public Class vt_parametroventaBE

Private mempresacodigo As String
Private mparamvtadesc As String
Private mparamvtadescor As String
Private mparamvtadirec As String
Private mparamvtaestdesc As Boolean
Private mparamvtadescto As Double
Private mparamvtatelefonos As String
Private mparamvtafax As String
Private mmonedacodigo As String
Private mparamvtaestigv As Boolean
Private mparamvtaporcigv As Double
Private malmacencodigo As String
Private mparamvtamensaje As String
Private mparamvtalistaprec As Boolean
Private mparamvtatipcambref As Double
Private mparamvtacomisionvendedor As Boolean
Private mparamvtaformaemision As Boolean
Private mparamvtaboleta As Boolean
Private mparamvtamasivo As Boolean
Private mstockcomp As Boolean
Private musuariocodigo As String
Private mfechaact As DateTime
Private mcodigotransaccionventa As String
Private mtiporedondeocobrar As Int32
Private mkitvirtual As Boolean
Private mminimodetraccion As Double
Private mtesoreriaenlinea As Boolean
Private mPedidosSinfacturar As Boolean
Private mventasBM As Int32
Private mAjustesSolesxDolares As Boolean
Private mFacturacionenlineaContab As Boolean
Private mRangodePrecios As Boolean
Private mPorcentajeCredito As Decimal
Private mcuentaVtaImporte As String
Private mcuentaIgv As String
Private mcuentaVtaTotSoles As String
Private mcuentaVtaTotDolares As String
Private mparamvtaValorUit As Decimal

#Region "Propiedades"
Public Property empresacodigo() As String
	Get
		Return(mempresacodigo)
	End Get
	Set (Value As String)
		mempresacodigo = Value
	End Set
End Property
Public Property paramvtadesc() As String
	Get
		Return(mparamvtadesc)
	End Get
	Set (Value As String)
		mparamvtadesc = Value
	End Set
End Property
Public Property paramvtadescor() As String
	Get
		Return(mparamvtadescor)
	End Get
	Set (Value As String)
		mparamvtadescor = Value
	End Set
End Property
Public Property paramvtadirec() As String
	Get
		Return(mparamvtadirec)
	End Get
	Set (Value As String)
		mparamvtadirec = Value
	End Set
End Property
Public Property paramvtaestdesc() As Boolean
	Get
		Return(mparamvtaestdesc)
	End Get
	Set (Value As Boolean)
		mparamvtaestdesc = Value
	End Set
End Property
Public Property paramvtadescto() As Double
	Get
		Return(mparamvtadescto)
	End Get
	Set (Value As Double)
		mparamvtadescto = Value
	End Set
End Property
Public Property paramvtatelefonos() As String
	Get
		Return(mparamvtatelefonos)
	End Get
	Set (Value As String)
		mparamvtatelefonos = Value
	End Set
End Property
Public Property paramvtafax() As String
	Get
		Return(mparamvtafax)
	End Get
	Set (Value As String)
		mparamvtafax = Value
	End Set
End Property
Public Property monedacodigo() As String
	Get
		Return(mmonedacodigo)
	End Get
	Set (Value As String)
		mmonedacodigo = Value
	End Set
End Property
Public Property paramvtaestigv() As Boolean
	Get
		Return(mparamvtaestigv)
	End Get
	Set (Value As Boolean)
		mparamvtaestigv = Value
	End Set
End Property
Public Property paramvtaporcigv() As Double
	Get
		Return(mparamvtaporcigv)
	End Get
	Set (Value As Double)
		mparamvtaporcigv = Value
	End Set
End Property
Public Property almacencodigo() As String
	Get
		Return(malmacencodigo)
	End Get
	Set (Value As String)
		malmacencodigo = Value
	End Set
End Property
Public Property paramvtamensaje() As String
	Get
		Return(mparamvtamensaje)
	End Get
	Set (Value As String)
		mparamvtamensaje = Value
	End Set
End Property
Public Property paramvtalistaprec() As Boolean
	Get
		Return(mparamvtalistaprec)
	End Get
	Set (Value As Boolean)
		mparamvtalistaprec = Value
	End Set
End Property
Public Property paramvtatipcambref() As Double
	Get
		Return(mparamvtatipcambref)
	End Get
	Set (Value As Double)
		mparamvtatipcambref = Value
	End Set
End Property
Public Property paramvtacomisionvendedor() As Boolean
	Get
		Return(mparamvtacomisionvendedor)
	End Get
	Set (Value As Boolean)
		mparamvtacomisionvendedor = Value
	End Set
End Property
Public Property paramvtaformaemision() As Boolean
	Get
		Return(mparamvtaformaemision)
	End Get
	Set (Value As Boolean)
		mparamvtaformaemision = Value
	End Set
End Property
Public Property paramvtaboleta() As Boolean
	Get
		Return(mparamvtaboleta)
	End Get
	Set (Value As Boolean)
		mparamvtaboleta = Value
	End Set
End Property
Public Property paramvtamasivo() As Boolean
	Get
		Return(mparamvtamasivo)
	End Get
	Set (Value As Boolean)
		mparamvtamasivo = Value
	End Set
End Property
Public Property stockcomp() As Boolean
	Get
		Return(mstockcomp)
	End Get
	Set (Value As Boolean)
		mstockcomp = Value
	End Set
End Property
Public Property usuariocodigo() As String
	Get
		Return(musuariocodigo)
	End Get
	Set (Value As String)
		musuariocodigo = Value
	End Set
End Property
Public Property fechaact() As DateTime
	Get
		Return(mfechaact)
	End Get
	Set (Value As DateTime)
		mfechaact = Value
	End Set
End Property
Public Property codigotransaccionventa() As String
	Get
		Return(mcodigotransaccionventa)
	End Get
	Set (Value As String)
		mcodigotransaccionventa = Value
	End Set
End Property
Public Property tiporedondeocobrar() As Int32
	Get
		Return(mtiporedondeocobrar)
	End Get
	Set (Value As Int32)
		mtiporedondeocobrar = Value
	End Set
End Property
Public Property kitvirtual() As Boolean
	Get
		Return(mkitvirtual)
	End Get
	Set (Value As Boolean)
		mkitvirtual = Value
	End Set
End Property
Public Property minimodetraccion() As Double
	Get
		Return(mminimodetraccion)
	End Get
	Set (Value As Double)
		mminimodetraccion = Value
	End Set
End Property
Public Property tesoreriaenlinea() As Boolean
	Get
		Return(mtesoreriaenlinea)
	End Get
	Set (Value As Boolean)
		mtesoreriaenlinea = Value
	End Set
End Property
Public Property PedidosSinfacturar() As Boolean
	Get
		Return(mPedidosSinfacturar)
	End Get
	Set (Value As Boolean)
		mPedidosSinfacturar = Value
	End Set
End Property
Public Property ventasBM() As Int32
	Get
		Return(mventasBM)
	End Get
	Set (Value As Int32)
		mventasBM = Value
	End Set
End Property
Public Property AjustesSolesxDolares() As Boolean
	Get
		Return(mAjustesSolesxDolares)
	End Get
	Set (Value As Boolean)
		mAjustesSolesxDolares = Value
	End Set
End Property
Public Property FacturacionenlineaContab() As Boolean
	Get
		Return(mFacturacionenlineaContab)
	End Get
	Set (Value As Boolean)
		mFacturacionenlineaContab = Value
	End Set
End Property
Public Property RangodePrecios() As Boolean
	Get
		Return(mRangodePrecios)
	End Get
	Set (Value As Boolean)
		mRangodePrecios = Value
	End Set
End Property
Public Property PorcentajeCredito() As Decimal
	Get
		Return(mPorcentajeCredito)
	End Get
	Set (Value As Decimal)
		mPorcentajeCredito = Value
	End Set
End Property
Public Property cuentaVtaImporte() As String
	Get
		Return(mcuentaVtaImporte)
	End Get
	Set (Value As String)
		mcuentaVtaImporte = Value
	End Set
End Property
Public Property cuentaIgv() As String
	Get
		Return(mcuentaIgv)
	End Get
	Set (Value As String)
		mcuentaIgv = Value
	End Set
End Property
Public Property cuentaVtaTotSoles() As String
	Get
		Return(mcuentaVtaTotSoles)
	End Get
	Set (Value As String)
		mcuentaVtaTotSoles = Value
	End Set
End Property
Public Property cuentaVtaTotDolares() As String
	Get
		Return(mcuentaVtaTotDolares)
	End Get
	Set (Value As String)
		mcuentaVtaTotDolares = Value
	End Set
End Property
Public Property paramvtaValorUit() As Decimal
	Get
		Return(mparamvtaValorUit)
	End Get
	Set (Value As Decimal)
		mparamvtaValorUit = Value
	End Set
End Property
#End Region

End Class 
