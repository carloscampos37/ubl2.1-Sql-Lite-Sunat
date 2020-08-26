Public Class FE_TipoPrecioVentasBE

Private mTipoPrecioCodigo As String
Private mTipoPrecioDescripcion As String
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property TipoPrecioCodigo() As String
	Get
		Return(mTipoPrecioCodigo)
	End Get
	Set (Value As String)
		mTipoPrecioCodigo = Value
	End Set
End Property
Public Property TipoPrecioDescripcion() As String
	Get
		Return(mTipoPrecioDescripcion)
	End Get
	Set (Value As String)
		mTipoPrecioDescripcion = Value
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
