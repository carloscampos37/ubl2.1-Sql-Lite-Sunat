Public Class FE_ResumenDiarioDocumentosCabBE

Private mEstadoAnulado As Boolean
Private mEmpresaCodigo As String
Private mResumendiario_id As Int32
Private mFechaDocumento As DateTime
Private mEstablecimiento_id As String
Private mFechaEnvio As DateTime
Private mIdentificadorEnvio As String
Private musuarioCodigo As String
Private mfechaAct As DateTime
Private mHostName As String
Private mPedido_id As Int32
Private mEnvioSedePrincipal As Boolean

#Region "Propiedades"
Public Property EstadoAnulado() As Boolean
	Get
		Return(mEstadoAnulado)
	End Get
	Set (Value As Boolean)
		mEstadoAnulado = Value
	End Set
End Property
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property Resumendiario_id() As Int32
	Get
		Return(mResumendiario_id)
	End Get
	Set (Value As Int32)
		mResumendiario_id = Value
	End Set
End Property
Public Property FechaDocumento() As DateTime
	Get
		Return(mFechaDocumento)
	End Get
	Set (Value As DateTime)
		mFechaDocumento = Value
	End Set
End Property
Public Property Establecimiento_id() As String
	Get
		Return(mEstablecimiento_id)
	End Get
	Set (Value As String)
		mEstablecimiento_id = Value
	End Set
End Property
Public Property FechaEnvio() As DateTime
	Get
		Return(mFechaEnvio)
	End Get
	Set (Value As DateTime)
		mFechaEnvio = Value
	End Set
End Property
Public Property IdentificadorEnvio() As String
	Get
		Return(mIdentificadorEnvio)
	End Get
	Set (Value As String)
		mIdentificadorEnvio = Value
	End Set
End Property
Public Property usuarioCodigo() As String
	Get
		Return(musuarioCodigo)
	End Get
	Set (Value As String)
		musuarioCodigo = Value
	End Set
End Property
Public Property fechaAct() As DateTime
	Get
		Return(mfechaAct)
	End Get
	Set (Value As DateTime)
		mfechaAct = Value
	End Set
End Property
Public Property HostName() As String
	Get
		Return(mHostName)
	End Get
	Set (Value As String)
		mHostName = Value
	End Set
End Property
Public Property Pedido_id() As Int32
	Get
		Return(mPedido_id)
	End Get
	Set (Value As Int32)
		mPedido_id = Value
	End Set
End Property
Public Property EnvioSedePrincipal() As Boolean
	Get
		Return(mEnvioSedePrincipal)
	End Get
	Set (Value As Boolean)
		mEnvioSedePrincipal = Value
	End Set
End Property
#End Region

End Class 
