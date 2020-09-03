Public Class FE_ProductosBE

Private mEmpresaCodigo As String
Private mProductoCodigo As String
Private mProductoServicios As Boolean
Private mProductoDescripcion As String
Private mUnidadMedida_Id As String
Private mPorcentajeIgv As Decimal
Private mPrecioVta As Decimal
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
Public Property ProductoCodigo() As String
	Get
		Return(mProductoCodigo)
	End Get
	Set (Value As String)
		mProductoCodigo = Value
	End Set
End Property
Public Property ProductoServicios() As Boolean
	Get
		Return(mProductoServicios)
	End Get
	Set (Value As Boolean)
		mProductoServicios = Value
	End Set
End Property
Public Property ProductoDescripcion() As String
	Get
		Return(mProductoDescripcion)
	End Get
	Set (Value As String)
		mProductoDescripcion = Value
	End Set
End Property
Public Property UnidadMedida_Id() As String
	Get
		Return(mUnidadMedida_Id)
	End Get
	Set (Value As String)
		mUnidadMedida_Id = Value
	End Set
End Property
Public Property PorcentajeIgv() As Decimal
	Get
		Return(mPorcentajeIgv)
	End Get
	Set (Value As Decimal)
		mPorcentajeIgv = Value
	End Set
End Property
Public Property PrecioVta() As Decimal
	Get
		Return(mPrecioVta)
	End Get
	Set (Value As Decimal)
		mPrecioVta = Value
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
