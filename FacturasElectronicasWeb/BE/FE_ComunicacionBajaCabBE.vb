Public Class FE_ComunicacionBajaCabBE

Private mEmpresaCodigo As String
Private mComunicacionBaja_id As Int32
Private mEstablecimiento_id As String
Private mFechadeBaja As DateTime
Private mIdentificadorEnvio As String
Private mFechaEnvio As DateTime
Private mNroDocumentos As Int32
Private mFechaAct As DateTime
Private mUsuariocodigo As String
Private mEstadoEnvioSunat_id As Int32
Private mNumerodeAceptacion As String
Private mMensajeRecepcion As String
Private mArchivoXmlAceptado As String

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
Public Property Establecimiento_id() As String
	Get
		Return(mEstablecimiento_id)
	End Get
	Set (Value As String)
		mEstablecimiento_id = Value
	End Set
End Property
Public Property FechadeBaja() As DateTime
	Get
		Return(mFechadeBaja)
	End Get
	Set (Value As DateTime)
		mFechadeBaja = Value
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
Public Property FechaEnvio() As DateTime
	Get
		Return(mFechaEnvio)
	End Get
	Set (Value As DateTime)
		mFechaEnvio = Value
	End Set
End Property
Public Property NroDocumentos() As Int32
	Get
		Return(mNroDocumentos)
	End Get
	Set (Value As Int32)
		mNroDocumentos = Value
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
Public Property Usuariocodigo() As String
	Get
		Return(mUsuariocodigo)
	End Get
	Set (Value As String)
		mUsuariocodigo = Value
	End Set
End Property
Public Property EstadoEnvioSunat_id() As Int32
	Get
		Return(mEstadoEnvioSunat_id)
	End Get
	Set (Value As Int32)
		mEstadoEnvioSunat_id = Value
	End Set
End Property
Public Property NumerodeAceptacion() As String
	Get
		Return(mNumerodeAceptacion)
	End Get
	Set (Value As String)
		mNumerodeAceptacion = Value
	End Set
End Property
Public Property MensajeRecepcion() As String
	Get
		Return(mMensajeRecepcion)
	End Get
	Set (Value As String)
		mMensajeRecepcion = Value
	End Set
End Property
Public Property ArchivoXmlAceptado() As String
	Get
		Return(mArchivoXmlAceptado)
	End Get
	Set (Value As String)
		mArchivoXmlAceptado = Value
	End Set
End Property
#End Region

End Class 
