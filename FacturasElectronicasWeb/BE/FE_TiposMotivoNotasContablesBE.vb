Public Class FE_TiposMotivoNotasContablesBE

Private mDocumentoCodigo As String
Private mTipoMotivoNota As String
Private mTipoMotivoDescripcion As String
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property DocumentoCodigo() As String
	Get
		Return(mDocumentoCodigo)
	End Get
	Set (Value As String)
		mDocumentoCodigo = Value
	End Set
End Property
Public Property TipoMotivoNota() As String
	Get
		Return(mTipoMotivoNota)
	End Get
	Set (Value As String)
		mTipoMotivoNota = Value
	End Set
End Property
Public Property TipoMotivoDescripcion() As String
	Get
		Return(mTipoMotivoDescripcion)
	End Get
	Set (Value As String)
		mTipoMotivoDescripcion = Value
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
