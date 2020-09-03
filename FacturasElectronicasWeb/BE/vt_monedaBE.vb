Public Class vt_monedaBE

Private mmonedacodigo As String
Private mmonedadescripcion As String
Private mmonedasimbolo As String
Private musuariocodigo As String
Private mfechaact As DateTime

#Region "Propiedades"
Public Property monedacodigo() As String
	Get
		Return(mmonedacodigo)
	End Get
	Set (Value As String)
		mmonedacodigo = Value
	End Set
End Property
Public Property monedadescripcion() As String
	Get
		Return(mmonedadescripcion)
	End Get
	Set (Value As String)
		mmonedadescripcion = Value
	End Set
End Property
Public Property monedasimbolo() As String
	Get
		Return(mmonedasimbolo)
	End Get
	Set (Value As String)
		mmonedasimbolo = Value
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
