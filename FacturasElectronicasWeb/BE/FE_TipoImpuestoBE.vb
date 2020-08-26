Public Class FE_TipoImpuestoBE

Private mTipoImpuestoCodigo As String
Private mTipoImpuestoDescripcion As String
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property TipoImpuestoCodigo() As String
	Get
		Return(mTipoImpuestoCodigo)
	End Get
	Set (Value As String)
		mTipoImpuestoCodigo = Value
	End Set
End Property
Public Property TipoImpuestoDescripcion() As String
	Get
		Return(mTipoImpuestoDescripcion)
	End Get
	Set (Value As String)
		mTipoImpuestoDescripcion = Value
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
