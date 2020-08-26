Public Class vt_modoventaBE

Private mmodovtacodigo As String
Private mmodovtadescripcion As String
Private mmodovtadescrcorta As String
Private mmodovtaingpedido As Boolean
Private mmodovtainghojatrab As Boolean
Private mmodovtaingguiarem As Boolean
Private mmodovtactrlinventario As Boolean
Private mmodovtaunidadmedida As String
Private mmodovtadscto As String
Private mmodovtacopiasfact As Double
Private mmodovtacopiasboleta As Double
Private mmodovtacopiasguiarem As Double
Private mmodovtacopiashojatrab As Double
Private mmodovtacopiasticket As Double
Private mmodovtaimpuestos As Boolean
Private mmodovtacontrolcorr As Boolean
Private mmodovtanumautom As Boolean
Private mmodovtacorrguiarem As Boolean
Private mdocumentocodigo As String
Private mmodovtacrtlfact As Double
Private mmodovtaactctacte As Boolean
Private mmodovtaitemxdoc As Double
Private mmodovtaingcodclie As Boolean
Private mmodovtaingformapag As Boolean
Private mmodovtainghastafact As Boolean
Private mmodovtainghastahoja As Boolean
Private mmodovtasolemitfact As Boolean
Private mmodovtaemiteguia As Boolean
Private mmodovtaemitehoja As Boolean
Private mmodovtausafactconv As Boolean
Private musuariocodigo As String
Private mfechaact As DateTime
Private mmodovtacanje As String
Private mmodovtaalmacen As String
Private mpuntovtacodigo As String
Private mmodovtacopiasBO As Int32

#Region "Propiedades"
Public Property modovtacodigo() As String
	Get
		Return(mmodovtacodigo)
	End Get
	Set (Value As String)
		mmodovtacodigo = Value
	End Set
End Property
Public Property modovtadescripcion() As String
	Get
		Return(mmodovtadescripcion)
	End Get
	Set (Value As String)
		mmodovtadescripcion = Value
	End Set
End Property
Public Property modovtadescrcorta() As String
	Get
		Return(mmodovtadescrcorta)
	End Get
	Set (Value As String)
		mmodovtadescrcorta = Value
	End Set
End Property
Public Property modovtaingpedido() As Boolean
	Get
		Return(mmodovtaingpedido)
	End Get
	Set (Value As Boolean)
		mmodovtaingpedido = Value
	End Set
End Property
Public Property modovtainghojatrab() As Boolean
	Get
		Return(mmodovtainghojatrab)
	End Get
	Set (Value As Boolean)
		mmodovtainghojatrab = Value
	End Set
End Property
Public Property modovtaingguiarem() As Boolean
	Get
		Return(mmodovtaingguiarem)
	End Get
	Set (Value As Boolean)
		mmodovtaingguiarem = Value
	End Set
End Property
Public Property modovtactrlinventario() As Boolean
	Get
		Return(mmodovtactrlinventario)
	End Get
	Set (Value As Boolean)
		mmodovtactrlinventario = Value
	End Set
End Property
Public Property modovtaunidadmedida() As String
	Get
		Return(mmodovtaunidadmedida)
	End Get
	Set (Value As String)
		mmodovtaunidadmedida = Value
	End Set
End Property
Public Property modovtadscto() As String
	Get
		Return(mmodovtadscto)
	End Get
	Set (Value As String)
		mmodovtadscto = Value
	End Set
End Property
Public Property modovtacopiasfact() As Double
	Get
		Return(mmodovtacopiasfact)
	End Get
	Set (Value As Double)
		mmodovtacopiasfact = Value
	End Set
End Property
Public Property modovtacopiasboleta() As Double
	Get
		Return(mmodovtacopiasboleta)
	End Get
	Set (Value As Double)
		mmodovtacopiasboleta = Value
	End Set
End Property
Public Property modovtacopiasguiarem() As Double
	Get
		Return(mmodovtacopiasguiarem)
	End Get
	Set (Value As Double)
		mmodovtacopiasguiarem = Value
	End Set
End Property
Public Property modovtacopiashojatrab() As Double
	Get
		Return(mmodovtacopiashojatrab)
	End Get
	Set (Value As Double)
		mmodovtacopiashojatrab = Value
	End Set
End Property
Public Property modovtacopiasticket() As Double
	Get
		Return(mmodovtacopiasticket)
	End Get
	Set (Value As Double)
		mmodovtacopiasticket = Value
	End Set
End Property
Public Property modovtaimpuestos() As Boolean
	Get
		Return(mmodovtaimpuestos)
	End Get
	Set (Value As Boolean)
		mmodovtaimpuestos = Value
	End Set
End Property
Public Property modovtacontrolcorr() As Boolean
	Get
		Return(mmodovtacontrolcorr)
	End Get
	Set (Value As Boolean)
		mmodovtacontrolcorr = Value
	End Set
End Property
Public Property modovtanumautom() As Boolean
	Get
		Return(mmodovtanumautom)
	End Get
	Set (Value As Boolean)
		mmodovtanumautom = Value
	End Set
End Property
Public Property modovtacorrguiarem() As Boolean
	Get
		Return(mmodovtacorrguiarem)
	End Get
	Set (Value As Boolean)
		mmodovtacorrguiarem = Value
	End Set
End Property
Public Property documentocodigo() As String
	Get
		Return(mdocumentocodigo)
	End Get
	Set (Value As String)
		mdocumentocodigo = Value
	End Set
End Property
Public Property modovtacrtlfact() As Double
	Get
		Return(mmodovtacrtlfact)
	End Get
	Set (Value As Double)
		mmodovtacrtlfact = Value
	End Set
End Property
Public Property modovtaactctacte() As Boolean
	Get
		Return(mmodovtaactctacte)
	End Get
	Set (Value As Boolean)
		mmodovtaactctacte = Value
	End Set
End Property
Public Property modovtaitemxdoc() As Double
	Get
		Return(mmodovtaitemxdoc)
	End Get
	Set (Value As Double)
		mmodovtaitemxdoc = Value
	End Set
End Property
Public Property modovtaingcodclie() As Boolean
	Get
		Return(mmodovtaingcodclie)
	End Get
	Set (Value As Boolean)
		mmodovtaingcodclie = Value
	End Set
End Property
Public Property modovtaingformapag() As Boolean
	Get
		Return(mmodovtaingformapag)
	End Get
	Set (Value As Boolean)
		mmodovtaingformapag = Value
	End Set
End Property
Public Property modovtainghastafact() As Boolean
	Get
		Return(mmodovtainghastafact)
	End Get
	Set (Value As Boolean)
		mmodovtainghastafact = Value
	End Set
End Property
Public Property modovtainghastahoja() As Boolean
	Get
		Return(mmodovtainghastahoja)
	End Get
	Set (Value As Boolean)
		mmodovtainghastahoja = Value
	End Set
End Property
Public Property modovtasolemitfact() As Boolean
	Get
		Return(mmodovtasolemitfact)
	End Get
	Set (Value As Boolean)
		mmodovtasolemitfact = Value
	End Set
End Property
Public Property modovtaemiteguia() As Boolean
	Get
		Return(mmodovtaemiteguia)
	End Get
	Set (Value As Boolean)
		mmodovtaemiteguia = Value
	End Set
End Property
Public Property modovtaemitehoja() As Boolean
	Get
		Return(mmodovtaemitehoja)
	End Get
	Set (Value As Boolean)
		mmodovtaemitehoja = Value
	End Set
End Property
Public Property modovtausafactconv() As Boolean
	Get
		Return(mmodovtausafactconv)
	End Get
	Set (Value As Boolean)
		mmodovtausafactconv = Value
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
Public Property modovtacanje() As String
	Get
		Return(mmodovtacanje)
	End Get
	Set (Value As String)
		mmodovtacanje = Value
	End Set
End Property
Public Property modovtaalmacen() As String
	Get
		Return(mmodovtaalmacen)
	End Get
	Set (Value As String)
		mmodovtaalmacen = Value
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
Public Property modovtacopiasBO() As Int32
	Get
		Return(mmodovtacopiasBO)
	End Get
	Set (Value As Int32)
		mmodovtacopiasBO = Value
	End Set
End Property
#End Region

End Class 
