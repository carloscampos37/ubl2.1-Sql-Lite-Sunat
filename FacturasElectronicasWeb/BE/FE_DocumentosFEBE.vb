Public Class FE_DocumentosFEBE

Private mdocumentocodigo As String
Private mdocumentodescripcion As String
Private mTipoEnvio_id As Int32
Private mEstadoAnulado As Boolean
Private musuariocodigo As String
Private mfechaact As DateTime

#Region "Propiedades"
Public Property documentocodigo() As String
	Get
		Return(mdocumentocodigo)
	End Get
	Set (Value As String)
		mdocumentocodigo = Value
	End Set
End Property
Public Property documentodescripcion() As String
	Get
		Return(mdocumentodescripcion)
	End Get
	Set (Value As String)
		mdocumentodescripcion = Value
	End Set
End Property
Public Property TipoEnvio_id() As Int32
	Get
		Return(mTipoEnvio_id)
	End Get
	Set (Value As Int32)
		mTipoEnvio_id = Value
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
