Public Class FE_UnidadMedidaBE

Private mUnidadMedida_id As String
Private mUnidadDescripcion As String
Private mEquivalenciaSunat As String
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property UnidadMedida_id() As String
	Get
		Return(mUnidadMedida_id)
	End Get
	Set (Value As String)
		mUnidadMedida_id = Value
	End Set
End Property
Public Property UnidadDescripcion() As String
	Get
		Return(mUnidadDescripcion)
	End Get
	Set (Value As String)
		mUnidadDescripcion = Value
	End Set
End Property
Public Property EquivalenciaSunat() As String
	Get
		Return(mEquivalenciaSunat)
	End Get
	Set (Value As String)
		mEquivalenciaSunat = Value
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
