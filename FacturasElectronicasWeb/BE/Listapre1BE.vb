Public Class Listapre1BE

Private mproductocodigo As String
Private mproductodescripcion As String
Private mproductoprecvta As Double
Private mproductodescrcorta As String
Private mgrupovtacodigo As String
Private mproductofamiliacodigo As String
Private mproductocategoriacodigo As String
Private mproductotipo As String
Private mproductoporcimpto As Double
Private mproductoestunidreferencia As Boolean
Private munidadfactorconv As Double
Private mproductoprecvtaofi As Double
Private mproductoprecvtareparto As Double
Private munidadcodigo As String
Private munidadreferencial As String
Private mmonedacodigo As String
Private mempresacodigo As String
Private mproductoprecvtaMayor As Double
Private mproductoprecvtaPresentacion As Int32
Private mproductoprecvtaEtiqueta03 As Double
Private mproductoprecvtaEtiqueta06 As Double
Private mproductoprecvtaEtiqueta12 As Double
Private mDescuento1 As Decimal

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
Public Property productodescrcorta() As String
	Get
		Return(mproductodescrcorta)
	End Get
	Set (Value As String)
		mproductodescrcorta = Value
	End Set
End Property
Public Property grupovtacodigo() As String
	Get
		Return(mgrupovtacodigo)
	End Get
	Set (Value As String)
		mgrupovtacodigo = Value
	End Set
End Property
Public Property productofamiliacodigo() As String
	Get
		Return(mproductofamiliacodigo)
	End Get
	Set (Value As String)
		mproductofamiliacodigo = Value
	End Set
End Property
Public Property productocategoriacodigo() As String
	Get
		Return(mproductocategoriacodigo)
	End Get
	Set (Value As String)
		mproductocategoriacodigo = Value
	End Set
End Property
Public Property productotipo() As String
	Get
		Return(mproductotipo)
	End Get
	Set (Value As String)
		mproductotipo = Value
	End Set
End Property
Public Property productoporcimpto() As Double
	Get
		Return(mproductoporcimpto)
	End Get
	Set (Value As Double)
		mproductoporcimpto = Value
	End Set
End Property
Public Property productoestunidreferencia() As Boolean
	Get
		Return(mproductoestunidreferencia)
	End Get
	Set (Value As Boolean)
		mproductoestunidreferencia = Value
	End Set
End Property
Public Property unidadfactorconv() As Double
	Get
		Return(munidadfactorconv)
	End Get
	Set (Value As Double)
		munidadfactorconv = Value
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
Public Property unidadcodigo() As String
	Get
		Return(munidadcodigo)
	End Get
	Set (Value As String)
		munidadcodigo = Value
	End Set
End Property
Public Property unidadreferencial() As String
	Get
		Return(munidadreferencial)
	End Get
	Set (Value As String)
		munidadreferencial = Value
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
Public Property empresacodigo() As String
	Get
		Return(mempresacodigo)
	End Get
	Set (Value As String)
		mempresacodigo = Value
	End Set
End Property
Public Property productoprecvtaMayor() As Double
	Get
		Return(mproductoprecvtaMayor)
	End Get
	Set (Value As Double)
		mproductoprecvtaMayor = Value
	End Set
End Property
Public Property productoprecvtaPresentacion() As Int32
	Get
		Return(mproductoprecvtaPresentacion)
	End Get
	Set (Value As Int32)
		mproductoprecvtaPresentacion = Value
	End Set
End Property
Public Property productoprecvtaEtiqueta03() As Double
	Get
		Return(mproductoprecvtaEtiqueta03)
	End Get
	Set (Value As Double)
		mproductoprecvtaEtiqueta03 = Value
	End Set
End Property
Public Property productoprecvtaEtiqueta06() As Double
	Get
		Return(mproductoprecvtaEtiqueta06)
	End Get
	Set (Value As Double)
		mproductoprecvtaEtiqueta06 = Value
	End Set
End Property
Public Property productoprecvtaEtiqueta12() As Double
	Get
		Return(mproductoprecvtaEtiqueta12)
	End Get
	Set (Value As Double)
		mproductoprecvtaEtiqueta12 = Value
	End Set
End Property
Public Property Descuento1() As Decimal
	Get
		Return(mDescuento1)
	End Get
	Set (Value As Decimal)
		mDescuento1 = Value
	End Set
End Property
#End Region

End Class 
