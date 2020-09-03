Public Class FE_ComunicacionBajaDetBE

Private mEmpresaCodigo As String
Private mComunicacionBaja_id As Int32
Private mComunicacionbajaItem As Int32
Private mclienteRuc As String
Private mTipoDocumento As String
Private mSerieDocumento As String
Private mNumeroDocumento As String
Private mClienteRazonSocial As String
Private mMotivoBaja_id As String
Private mCorrelativoEnvio As Int32
Private mFechaAct As DateTime

#Region "Propiedades"
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property ComunicacionBaja_id() As Int32
	Get
		Return(mComunicacionBaja_id)
	End Get
	Set (Value As Int32)
		mComunicacionBaja_id = Value
	End Set
End Property
Public Property ComunicacionbajaItem() As Int32
	Get
		Return(mComunicacionbajaItem)
	End Get
	Set (Value As Int32)
		mComunicacionbajaItem = Value
	End Set
End Property
Public Property clienteRuc() As String
	Get
		Return(mclienteRuc)
	End Get
	Set (Value As String)
		mclienteRuc = Value
	End Set
End Property
Public Property TipoDocumento() As String
	Get
		Return(mTipoDocumento)
	End Get
	Set (Value As String)
		mTipoDocumento = Value
	End Set
End Property
Public Property SerieDocumento() As String
	Get
		Return(mSerieDocumento)
	End Get
	Set (Value As String)
		mSerieDocumento = Value
	End Set
End Property
Public Property NumeroDocumento() As String
	Get
		Return(mNumeroDocumento)
	End Get
	Set (Value As String)
		mNumeroDocumento = Value
	End Set
End Property
Public Property ClienteRazonSocial() As String
	Get
		Return(mClienteRazonSocial)
	End Get
	Set (Value As String)
		mClienteRazonSocial = Value
	End Set
End Property
Public Property MotivoBaja_id() As String
	Get
		Return(mMotivoBaja_id)
	End Get
	Set (Value As String)
		mMotivoBaja_id = Value
	End Set
End Property
Public Property CorrelativoEnvio() As Int32
	Get
		Return(mCorrelativoEnvio)
	End Get
	Set (Value As Int32)
		mCorrelativoEnvio = Value
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
#End Region

End Class 
