Public Class FE_ComprobImpresosCabBE

Private mEstadoAnulado As Boolean
Private mEmpresaCodigo As String
Private mComprobImpreso_Id As Int32
Private mEstablecimiento_id As String
Private mFechaDocumento As DateTime
Private mMotivoContigencia As Int32
Private mUsuarioCodigo As String
Private mFechaAct As DateTime
Private mHostName As String
Private mIdentificadorEnvio As String
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
Public Property ComprobImpreso_Id() As Int32
	Get
		Return(mComprobImpreso_Id)
	End Get
	Set (Value As Int32)
		mComprobImpreso_Id = Value
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
Public Property FechaDocumento() As DateTime
	Get
		Return(mFechaDocumento)
	End Get
	Set (Value As DateTime)
		mFechaDocumento = Value
	End Set
End Property
Public Property MotivoContigencia() As Int32
	Get
		Return(mMotivoContigencia)
	End Get
	Set (Value As Int32)
		mMotivoContigencia = Value
	End Set
End Property
Public Property UsuarioCodigo() As String
	Get
		Return(mUsuarioCodigo)
	End Get
	Set (Value As String)
		mUsuarioCodigo = Value
	End Set
End Property
Public Property FechaAct() As DateTime
	Get
		Return(mFechaAct)
	End Get
	Set (Value As DateTime)
		mFechaAct = Value
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
Public Property IdentificadorEnvio() As String
	Get
		Return(mIdentificadorEnvio)
	End Get
	Set (Value As String)
		mIdentificadorEnvio = Value
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
