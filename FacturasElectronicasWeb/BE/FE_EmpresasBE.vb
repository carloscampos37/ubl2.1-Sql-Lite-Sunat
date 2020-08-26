Public Class FE_EmpresasBE

Private mEmpresaCodigo As String
Private mEmpresaRazonSocial As String
Private mEmpresaRazonComercial As String
Private mEmpresaRuc As String
Private mEmpresaDireccion As String
Private mEmpresaUrbanizacion As String
Private mEmpresaDistrito As String
Private mEmpresaProvincia As String
Private mEmpresaRegion As String
Private mUbigeo_id As String
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property EmpresaRazonSocial() As String
	Get
		Return(mEmpresaRazonSocial)
	End Get
	Set (Value As String)
		mEmpresaRazonSocial = Value
	End Set
End Property
Public Property EmpresaRazonComercial() As String
	Get
		Return(mEmpresaRazonComercial)
	End Get
	Set (Value As String)
		mEmpresaRazonComercial = Value
	End Set
End Property
Public Property EmpresaRuc() As String
	Get
		Return(mEmpresaRuc)
	End Get
	Set (Value As String)
		mEmpresaRuc = Value
	End Set
End Property
Public Property EmpresaDireccion() As String
	Get
		Return(mEmpresaDireccion)
	End Get
	Set (Value As String)
		mEmpresaDireccion = Value
	End Set
End Property
Public Property EmpresaUrbanizacion() As String
	Get
		Return(mEmpresaUrbanizacion)
	End Get
	Set (Value As String)
		mEmpresaUrbanizacion = Value
	End Set
End Property
Public Property EmpresaDistrito() As String
	Get
		Return(mEmpresaDistrito)
	End Get
	Set (Value As String)
		mEmpresaDistrito = Value
	End Set
End Property
Public Property EmpresaProvincia() As String
	Get
		Return(mEmpresaProvincia)
	End Get
	Set (Value As String)
		mEmpresaProvincia = Value
	End Set
End Property
Public Property EmpresaRegion() As String
	Get
		Return(mEmpresaRegion)
	End Get
	Set (Value As String)
		mEmpresaRegion = Value
	End Set
End Property
Public Property Ubigeo_id() As String
	Get
		Return(mUbigeo_id)
	End Get
	Set (Value As String)
		mUbigeo_id = Value
	End Set
End Property
Public Property EstadoAnulado() As Boolean
	Get
		Return(mEstadoAnulado)
	End Get
	Set (Value As Boolean)
		mEstadoAnulado = Value
	End Set
End Property
#End Region

End Class 
