Public Class vt_puntoventaBE

Private mpuntovtacodigo As String
Private mpuntovtadescripcion As String
Private mpuntovtanropedido As Boolean
Private mpuntovtanroguia As Boolean
Private mpuntovtanrofact As Boolean
Private mpuntovtanroguiarem As Boolean
Private mpuntovtanotaabono As Boolean
Private mpuntovtanotacargo As Boolean
Private mpuntovtaautomat As Boolean
Private musuariocodigo As String
Private mfechaact As DateTime
Private mpuntovtaticket As Boolean
Private mcodigocajavtas As String
Private mdireccioncomercial As String
Private madministraproyectos As Int32
Private mcodigocajavtasDol As String
Private mpuntovtanroBoleta As Boolean
Private mcodigocajavtassoles As String
Private mpuntovtaNumDocumentos As Boolean
Private mpuntovtaventasAuto As Boolean

#Region "Propiedades"
Public Property puntovtacodigo() As String
	Get
		Return(mpuntovtacodigo)
	End Get
	Set (Value As String)
		mpuntovtacodigo = Value
	End Set
End Property
Public Property puntovtadescripcion() As String
	Get
		Return(mpuntovtadescripcion)
	End Get
	Set (Value As String)
		mpuntovtadescripcion = Value
	End Set
End Property
Public Property puntovtanropedido() As Boolean
	Get
		Return(mpuntovtanropedido)
	End Get
	Set (Value As Boolean)
		mpuntovtanropedido = Value
	End Set
End Property
Public Property puntovtanroguia() As Boolean
	Get
		Return(mpuntovtanroguia)
	End Get
	Set (Value As Boolean)
		mpuntovtanroguia = Value
	End Set
End Property
Public Property puntovtanrofact() As Boolean
	Get
		Return(mpuntovtanrofact)
	End Get
	Set (Value As Boolean)
		mpuntovtanrofact = Value
	End Set
End Property
Public Property puntovtanroguiarem() As Boolean
	Get
		Return(mpuntovtanroguiarem)
	End Get
	Set (Value As Boolean)
		mpuntovtanroguiarem = Value
	End Set
End Property
Public Property puntovtanotaabono() As Boolean
	Get
		Return(mpuntovtanotaabono)
	End Get
	Set (Value As Boolean)
		mpuntovtanotaabono = Value
	End Set
End Property
Public Property puntovtanotacargo() As Boolean
	Get
		Return(mpuntovtanotacargo)
	End Get
	Set (Value As Boolean)
		mpuntovtanotacargo = Value
	End Set
End Property
Public Property puntovtaautomat() As Boolean
	Get
		Return(mpuntovtaautomat)
	End Get
	Set (Value As Boolean)
		mpuntovtaautomat = Value
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
Public Property puntovtaticket() As Boolean
	Get
		Return(mpuntovtaticket)
	End Get
	Set (Value As Boolean)
		mpuntovtaticket = Value
	End Set
End Property
Public Property codigocajavtas() As String
	Get
		Return(mcodigocajavtas)
	End Get
	Set (Value As String)
		mcodigocajavtas = Value
	End Set
End Property
Public Property direccioncomercial() As String
	Get
		Return(mdireccioncomercial)
	End Get
	Set (Value As String)
		mdireccioncomercial = Value
	End Set
End Property
Public Property administraproyectos() As Int32
	Get
		Return(madministraproyectos)
	End Get
	Set (Value As Int32)
		madministraproyectos = Value
	End Set
End Property
Public Property codigocajavtasDol() As String
	Get
		Return(mcodigocajavtasDol)
	End Get
	Set (Value As String)
		mcodigocajavtasDol = Value
	End Set
End Property
Public Property puntovtanroBoleta() As Boolean
	Get
		Return(mpuntovtanroBoleta)
	End Get
	Set (Value As Boolean)
		mpuntovtanroBoleta = Value
	End Set
End Property
Public Property codigocajavtassoles() As String
	Get
		Return(mcodigocajavtassoles)
	End Get
	Set (Value As String)
		mcodigocajavtassoles = Value
	End Set
End Property
Public Property puntovtaNumDocumentos() As Boolean
	Get
		Return(mpuntovtaNumDocumentos)
	End Get
	Set (Value As Boolean)
		mpuntovtaNumDocumentos = Value
	End Set
End Property
Public Property puntovtaventasAuto() As Boolean
	Get
		Return(mpuntovtaventasAuto)
	End Get
	Set (Value As Boolean)
		mpuntovtaventasAuto = Value
	End Set
End Property
#End Region

End Class 
