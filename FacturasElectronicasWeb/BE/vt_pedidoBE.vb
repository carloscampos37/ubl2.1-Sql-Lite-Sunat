Public Class vt_pedidoBE

Private mempresacodigo As String
Private mpedidonumero As String
Private mmodovtacodigo As String
Private mformapagocodigo As String
Private mvendedorcodigo As String
Private mpedidomoneda As String
Private mpedidofecha As DateTime
Private mpuntovtacodigo As String
Private mpedidoestado As String
Private mpedidolistaprec As String
Private mpedidoautorizacion As String
Private mclienteruc As String
Private mclientecodigo As String
Private mclienterazonsocial As String
Private mclientedireccion As String
Private mpedidomensaje As String
Private mclientedistrito As String
Private mpedidotipcambio As Double
Private mpedidotarjetacred As String
Private mpedidoemisionfact As Boolean
Private mpedidonrofact As String
Private mpedidonroboleta As String
Private mpedidonrogiarem As String
Private mpedidoordencompra As String
Private mpedidocondicionfactura As String
Private mpedidodiaspago As Double
Private mpedidototbruto As Decimal
Private mpedidototalotros As Decimal
Private mpedidototalflete As Decimal
Private mpedidomontodsctoglobal As Decimal
Private mpedidomontodsctocliente As Decimal
Private mpedidomontodsctoppago As Decimal
Private mpedidomontodsctovtaoficina As Decimal
Private mpedidototaldsctoxitem As Decimal
Private mpedidototaldsctoxlinea As Decimal
Private mpedidodsctoglobal As Double
Private mpedidototaldsctoxprom As Decimal
Private mpedidodsctocliente As Double
Private mpedidodsctoppago As Double
Private mpedidodsctovtaoficina As Double
Private mpedidototimpuesto As Decimal
Private mpedidototinafecto As Decimal
Private mpedidototneto As Decimal
Private mpedidototitem As Double
Private mpedidofechafact As DateTime
Private malmacencodigo As String
Private mpedidofechapag As DateTime
Private mpedidonotaped As String
Private mpedidoporccomision As Double
Private mpedidoentrega As String
Private mpedidofechaanu As DateTime
Private mestadoreg As Boolean
Private musuariocodigo As String
Private mfechaact As DateTime
Private mpedidotipofac As String
Private mpedidotiporefe As String
Private mpedidonrorefe As String
Private mpedidofechasunat As DateTime
Private mpedidoobserva As String
Private mtransportecodigo As String
Private mtipocontactocodigo As String
Private mprofesionalcodigo As String
Private mhoraentrega As String
Private mPEDIDOATENDIDO As String
Private mpedidoventadiferida As Int32
Private mproyectocodigo As String
Private mPedidodelDia As Int32
Private mPedidoPagoCaja As Int32
Private mPedidoDocumentoSerie As String
Private mPedidoDocumentoNumero As Int32
Private mPedidoDocumentoNumerofinal As Int32
Private mTipoDocModifica As String
Private mSerieDocModifica As String
Private mNumeroDocModifica As Int32
Private mEnvioSedePrincipal As Boolean

#Region "Propiedades"
Public Property empresacodigo() As String
	Get
		Return(mempresacodigo)
	End Get
	Set (Value As String)
		mempresacodigo = Value
	End Set
End Property
Public Property pedidonumero() As String
	Get
		Return(mpedidonumero)
	End Get
	Set (Value As String)
		mpedidonumero = Value
	End Set
End Property
Public Property modovtacodigo() As String
	Get
		Return(mmodovtacodigo)
	End Get
	Set (Value As String)
		mmodovtacodigo = Value
	End Set
End Property
Public Property formapagocodigo() As String
	Get
		Return(mformapagocodigo)
	End Get
	Set (Value As String)
		mformapagocodigo = Value
	End Set
End Property
Public Property vendedorcodigo() As String
	Get
		Return(mvendedorcodigo)
	End Get
	Set (Value As String)
		mvendedorcodigo = Value
	End Set
End Property
Public Property pedidomoneda() As String
	Get
		Return(mpedidomoneda)
	End Get
	Set (Value As String)
		mpedidomoneda = Value
	End Set
End Property
Public Property pedidofecha() As DateTime
	Get
		Return(mpedidofecha)
	End Get
	Set (Value As DateTime)
		mpedidofecha = Value
	End Set
End Property
Public Property puntovtacodigo() As String
	Get
		Return(mpuntovtacodigo)
	End Get
	Set (Value As String)
		mpuntovtacodigo = Value
	End Set
End Property
Public Property pedidoestado() As String
	Get
		Return(mpedidoestado)
	End Get
	Set (Value As String)
		mpedidoestado = Value
	End Set
End Property
Public Property pedidolistaprec() As String
	Get
		Return(mpedidolistaprec)
	End Get
	Set (Value As String)
		mpedidolistaprec = Value
	End Set
End Property
Public Property pedidoautorizacion() As String
	Get
		Return(mpedidoautorizacion)
	End Get
	Set (Value As String)
		mpedidoautorizacion = Value
	End Set
End Property
Public Property clienteruc() As String
	Get
		Return(mclienteruc)
	End Get
	Set (Value As String)
		mclienteruc = Value
	End Set
End Property
Public Property clientecodigo() As String
	Get
		Return(mclientecodigo)
	End Get
	Set (Value As String)
		mclientecodigo = Value
	End Set
End Property
Public Property clienterazonsocial() As String
	Get
		Return(mclienterazonsocial)
	End Get
	Set (Value As String)
		mclienterazonsocial = Value
	End Set
End Property
Public Property clientedireccion() As String
	Get
		Return(mclientedireccion)
	End Get
	Set (Value As String)
		mclientedireccion = Value
	End Set
End Property
Public Property pedidomensaje() As String
	Get
		Return(mpedidomensaje)
	End Get
	Set (Value As String)
		mpedidomensaje = Value
	End Set
End Property
Public Property clientedistrito() As String
	Get
		Return(mclientedistrito)
	End Get
	Set (Value As String)
		mclientedistrito = Value
	End Set
End Property
Public Property pedidotipcambio() As Double
	Get
		Return(mpedidotipcambio)
	End Get
	Set (Value As Double)
		mpedidotipcambio = Value
	End Set
End Property
Public Property pedidotarjetacred() As String
	Get
		Return(mpedidotarjetacred)
	End Get
	Set (Value As String)
		mpedidotarjetacred = Value
	End Set
End Property
Public Property pedidoemisionfact() As Boolean
	Get
		Return(mpedidoemisionfact)
	End Get
	Set (Value As Boolean)
		mpedidoemisionfact = Value
	End Set
End Property
Public Property pedidonrofact() As String
	Get
		Return(mpedidonrofact)
	End Get
	Set (Value As String)
		mpedidonrofact = Value
	End Set
End Property
Public Property pedidonroboleta() As String
	Get
		Return(mpedidonroboleta)
	End Get
	Set (Value As String)
		mpedidonroboleta = Value
	End Set
End Property
Public Property pedidonrogiarem() As String
	Get
		Return(mpedidonrogiarem)
	End Get
	Set (Value As String)
		mpedidonrogiarem = Value
	End Set
End Property
Public Property pedidoordencompra() As String
	Get
		Return(mpedidoordencompra)
	End Get
	Set (Value As String)
		mpedidoordencompra = Value
	End Set
End Property
Public Property pedidocondicionfactura() As String
	Get
		Return(mpedidocondicionfactura)
	End Get
	Set (Value As String)
		mpedidocondicionfactura = Value
	End Set
End Property
Public Property pedidodiaspago() As Double
	Get
		Return(mpedidodiaspago)
	End Get
	Set (Value As Double)
		mpedidodiaspago = Value
	End Set
End Property
Public Property pedidototbruto() As Decimal
	Get
		Return(mpedidototbruto)
	End Get
	Set (Value As Decimal)
		mpedidototbruto = Value
	End Set
End Property
Public Property pedidototalotros() As Decimal
	Get
		Return(mpedidototalotros)
	End Get
	Set (Value As Decimal)
		mpedidototalotros = Value
	End Set
End Property
Public Property pedidototalflete() As Decimal
	Get
		Return(mpedidototalflete)
	End Get
	Set (Value As Decimal)
		mpedidototalflete = Value
	End Set
End Property
Public Property pedidomontodsctoglobal() As Decimal
	Get
		Return(mpedidomontodsctoglobal)
	End Get
	Set (Value As Decimal)
		mpedidomontodsctoglobal = Value
	End Set
End Property
Public Property pedidomontodsctocliente() As Decimal
	Get
		Return(mpedidomontodsctocliente)
	End Get
	Set (Value As Decimal)
		mpedidomontodsctocliente = Value
	End Set
End Property
Public Property pedidomontodsctoppago() As Decimal
	Get
		Return(mpedidomontodsctoppago)
	End Get
	Set (Value As Decimal)
		mpedidomontodsctoppago = Value
	End Set
End Property
Public Property pedidomontodsctovtaoficina() As Decimal
	Get
		Return(mpedidomontodsctovtaoficina)
	End Get
	Set (Value As Decimal)
		mpedidomontodsctovtaoficina = Value
	End Set
End Property
Public Property pedidototaldsctoxitem() As Decimal
	Get
		Return(mpedidototaldsctoxitem)
	End Get
	Set (Value As Decimal)
		mpedidototaldsctoxitem = Value
	End Set
End Property
Public Property pedidototaldsctoxlinea() As Decimal
	Get
		Return(mpedidototaldsctoxlinea)
	End Get
	Set (Value As Decimal)
		mpedidototaldsctoxlinea = Value
	End Set
End Property
Public Property pedidodsctoglobal() As Double
	Get
		Return(mpedidodsctoglobal)
	End Get
	Set (Value As Double)
		mpedidodsctoglobal = Value
	End Set
End Property
Public Property pedidototaldsctoxprom() As Decimal
	Get
		Return(mpedidototaldsctoxprom)
	End Get
	Set (Value As Decimal)
		mpedidototaldsctoxprom = Value
	End Set
End Property
Public Property pedidodsctocliente() As Double
	Get
		Return(mpedidodsctocliente)
	End Get
	Set (Value As Double)
		mpedidodsctocliente = Value
	End Set
End Property
Public Property pedidodsctoppago() As Double
	Get
		Return(mpedidodsctoppago)
	End Get
	Set (Value As Double)
		mpedidodsctoppago = Value
	End Set
End Property
Public Property pedidodsctovtaoficina() As Double
	Get
		Return(mpedidodsctovtaoficina)
	End Get
	Set (Value As Double)
		mpedidodsctovtaoficina = Value
	End Set
End Property
Public Property pedidototimpuesto() As Decimal
	Get
		Return(mpedidototimpuesto)
	End Get
	Set (Value As Decimal)
		mpedidototimpuesto = Value
	End Set
End Property
Public Property pedidototinafecto() As Decimal
	Get
		Return(mpedidototinafecto)
	End Get
	Set (Value As Decimal)
		mpedidototinafecto = Value
	End Set
End Property
Public Property pedidototneto() As Decimal
	Get
		Return(mpedidototneto)
	End Get
	Set (Value As Decimal)
		mpedidototneto = Value
	End Set
End Property
Public Property pedidototitem() As Double
	Get
		Return(mpedidototitem)
	End Get
	Set (Value As Double)
		mpedidototitem = Value
	End Set
End Property
Public Property pedidofechafact() As DateTime
	Get
		Return(mpedidofechafact)
	End Get
	Set (Value As DateTime)
		mpedidofechafact = Value
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
Public Property pedidofechapag() As DateTime
	Get
		Return(mpedidofechapag)
	End Get
	Set (Value As DateTime)
		mpedidofechapag = Value
	End Set
End Property
Public Property pedidonotaped() As String
	Get
		Return(mpedidonotaped)
	End Get
	Set (Value As String)
		mpedidonotaped = Value
	End Set
End Property
Public Property pedidoporccomision() As Double
	Get
		Return(mpedidoporccomision)
	End Get
	Set (Value As Double)
		mpedidoporccomision = Value
	End Set
End Property
Public Property pedidoentrega() As String
	Get
		Return(mpedidoentrega)
	End Get
	Set (Value As String)
		mpedidoentrega = Value
	End Set
End Property
Public Property pedidofechaanu() As DateTime
	Get
		Return(mpedidofechaanu)
	End Get
	Set (Value As DateTime)
		mpedidofechaanu = Value
	End Set
End Property
Public Property estadoreg() As Boolean
	Get
		Return(mestadoreg)
	End Get
	Set (Value As Boolean)
		mestadoreg = Value
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
Public Property pedidotipofac() As String
	Get
		Return(mpedidotipofac)
	End Get
	Set (Value As String)
		mpedidotipofac = Value
	End Set
End Property
Public Property pedidotiporefe() As String
	Get
		Return(mpedidotiporefe)
	End Get
	Set (Value As String)
		mpedidotiporefe = Value
	End Set
End Property
Public Property pedidonrorefe() As String
	Get
		Return(mpedidonrorefe)
	End Get
	Set (Value As String)
		mpedidonrorefe = Value
	End Set
End Property
Public Property pedidofechasunat() As DateTime
	Get
		Return(mpedidofechasunat)
	End Get
	Set (Value As DateTime)
		mpedidofechasunat = Value
	End Set
End Property
Public Property pedidoobserva() As String
	Get
		Return(mpedidoobserva)
	End Get
	Set (Value As String)
		mpedidoobserva = Value
	End Set
End Property
Public Property transportecodigo() As String
	Get
		Return(mtransportecodigo)
	End Get
	Set (Value As String)
		mtransportecodigo = Value
	End Set
End Property
Public Property tipocontactocodigo() As String
	Get
		Return(mtipocontactocodigo)
	End Get
	Set (Value As String)
		mtipocontactocodigo = Value
	End Set
End Property
Public Property profesionalcodigo() As String
	Get
		Return(mprofesionalcodigo)
	End Get
	Set (Value As String)
		mprofesionalcodigo = Value
	End Set
End Property
Public Property horaentrega() As String
	Get
		Return(mhoraentrega)
	End Get
	Set (Value As String)
		mhoraentrega = Value
	End Set
End Property
Public Property PEDIDOATENDIDO() As String
	Get
		Return(mPEDIDOATENDIDO)
	End Get
	Set (Value As String)
		mPEDIDOATENDIDO = Value
	End Set
End Property
Public Property pedidoventadiferida() As Int32
	Get
		Return(mpedidoventadiferida)
	End Get
	Set (Value As Int32)
		mpedidoventadiferida = Value
	End Set
End Property
Public Property proyectocodigo() As String
	Get
		Return(mproyectocodigo)
	End Get
	Set (Value As String)
		mproyectocodigo = Value
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
Public Property PedidoPagoCaja() As Int32
	Get
		Return(mPedidoPagoCaja)
	End Get
	Set (Value As Int32)
		mPedidoPagoCaja = Value
	End Set
End Property
Public Property PedidoDocumentoSerie() As String
	Get
		Return(mPedidoDocumentoSerie)
	End Get
	Set (Value As String)
		mPedidoDocumentoSerie = Value
	End Set
End Property
Public Property PedidoDocumentoNumero() As Int32
	Get
		Return(mPedidoDocumentoNumero)
	End Get
	Set (Value As Int32)
		mPedidoDocumentoNumero = Value
	End Set
End Property
Public Property PedidoDocumentoNumerofinal() As Int32
	Get
		Return(mPedidoDocumentoNumerofinal)
	End Get
	Set (Value As Int32)
		mPedidoDocumentoNumerofinal = Value
	End Set
End Property
Public Property TipoDocModifica() As String
	Get
		Return(mTipoDocModifica)
	End Get
	Set (Value As String)
		mTipoDocModifica = Value
	End Set
End Property
Public Property SerieDocModifica() As String
	Get
		Return(mSerieDocModifica)
	End Get
	Set (Value As String)
		mSerieDocModifica = Value
	End Set
End Property
Public Property NumeroDocModifica() As Int32
	Get
		Return(mNumeroDocModifica)
	End Get
	Set (Value As Int32)
		mNumeroDocModifica = Value
	End Set
End Property
Public Property EnvioSedePrincipal() As Boolean
	Get
		Return(mEnvioSedePrincipal)
	End Get
	Set (Value As Boolean)
		mEnvioSedePrincipal = Value
	End Set
End Property
#End Region

End Class 
