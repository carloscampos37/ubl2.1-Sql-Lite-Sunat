Public Class vt_vendedorBE

Private mvendedorcodigo As String
Private mvendedornombres As String
Private mvendedorle As String
Private mvendedordireccion As String
Private mvendedorruc As String
Private mvendedortelefono As String
Private mvendedorreferencia As String
Private mvendedorcomis1 As Double
Private mvendedorcomis2 As Double
Private mvendedorcomis3 As Double
Private mestadoreg As Boolean
Private musuariocodigo As String
Private mfechaact As DateTime

#Region "Propiedades"
Public Property vendedorcodigo() As String
	Get
		Return(mvendedorcodigo)
	End Get
	Set (Value As String)
		mvendedorcodigo = Value
	End Set
End Property
Public Property vendedornombres() As String
	Get
		Return(mvendedornombres)
	End Get
	Set (Value As String)
		mvendedornombres = Value
	End Set
End Property
Public Property vendedorle() As String
	Get
		Return(mvendedorle)
	End Get
	Set (Value As String)
		mvendedorle = Value
	End Set
End Property
Public Property vendedordireccion() As String
	Get
		Return(mvendedordireccion)
	End Get
	Set (Value As String)
		mvendedordireccion = Value
	End Set
End Property
Public Property vendedorruc() As String
	Get
		Return(mvendedorruc)
	End Get
	Set (Value As String)
		mvendedorruc = Value
	End Set
End Property
Public Property vendedortelefono() As String
	Get
		Return(mvendedortelefono)
	End Get
	Set (Value As String)
		mvendedortelefono = Value
	End Set
End Property
Public Property vendedorreferencia() As String
	Get
		Return(mvendedorreferencia)
	End Get
	Set (Value As String)
		mvendedorreferencia = Value
	End Set
End Property
Public Property vendedorcomis1() As Double
	Get
		Return(mvendedorcomis1)
	End Get
	Set (Value As Double)
		mvendedorcomis1 = Value
	End Set
End Property
Public Property vendedorcomis2() As Double
	Get
		Return(mvendedorcomis2)
	End Get
	Set (Value As Double)
		mvendedorcomis2 = Value
	End Set
End Property
Public Property vendedorcomis3() As Double
	Get
		Return(mvendedorcomis3)
	End Get
	Set (Value As Double)
		mvendedorcomis3 = Value
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
#End Region

End Class 
