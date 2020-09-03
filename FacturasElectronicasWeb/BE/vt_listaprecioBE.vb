Public Class vt_listaprecioBE

Private mproductocodigo As String
Private mproductodescripcion As String
Private mproductoprecvta As Double
Private mproductoprecvtaofi As Double
Private mproductoprecvtareparto As Double
Private musuariocodigo As String
Private mfechaact As DateTime

#Region "Propiedades"
Public Property productocodigo() As String
	Get
		Return(mproductocodigo)
	End Get
	Set (Value As String)
		mproductocodigo = Value
	End Set
End Property
Public Property productodescripcion() As String
	Get
		Return(mproductodescripcion)
	End Get
	Set (Value As String)
		mproductodescripcion = Value
	End Set
End Property
Public Property productoprecvta() As Double
	Get
		Return(mproductoprecvta)
	End Get
	Set (Value As Double)
		mproductoprecvta = Value
	End Set
End Property
Public Property productoprecvtaofi() As Double
	Get
		Return(mproductoprecvtaofi)
	End Get
	Set (Value As Double)
		mproductoprecvtaofi = Value
	End Set
End Property
Public Property productoprecvtareparto() As Double
	Get
		Return(mproductoprecvtareparto)
	End Get
	Set (Value As Double)
		mproductoprecvtareparto = Value
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
