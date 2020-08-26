Public Class VT_DocumentoBE

Private mDocumentoCodigo As String
Private mdocumentodescripcion As String
Private mdocumentodescrcorta As String
Private mdocumentoregventas As Boolean
Private mdocumentovalidaruc As Boolean
Private mDocumentoResumenSunat As Boolean
Private musuariocodigo As String
Private mfechaact As DateTime
Private mdocumentotipo As String
Private mCodigoSunat As String
Private mTipoEnvio_Id As Int32

#Region "Propiedades"
Public Property DocumentoCodigo() As String
	Get
		Return(mDocumentoCodigo)
	End Get
	Set (Value As String)
		mDocumentoCodigo = Value
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
Public Property documentodescrcorta() As String
	Get
		Return(mdocumentodescrcorta)
	End Get
	Set (Value As String)
		mdocumentodescrcorta = Value
	End Set
End Property
Public Property documentoregventas() As Boolean
	Get
		Return(mdocumentoregventas)
	End Get
	Set (Value As Boolean)
		mdocumentoregventas = Value
	End Set
End Property
Public Property documentovalidaruc() As Boolean
	Get
		Return(mdocumentovalidaruc)
	End Get
	Set (Value As Boolean)
		mdocumentovalidaruc = Value
	End Set
End Property
Public Property DocumentoResumenSunat() As Boolean
	Get
		Return(mDocumentoResumenSunat)
	End Get
	Set (Value As Boolean)
		mDocumentoResumenSunat = Value
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
Public Property documentotipo() As String
	Get
		Return(mdocumentotipo)
	End Get
	Set (Value As String)
		mdocumentotipo = Value
	End Set
End Property
Public Property CodigoSunat() As String
	Get
		Return(mCodigoSunat)
	End Get
	Set (Value As String)
		mCodigoSunat = Value
	End Set
End Property
Public Property TipoEnvio_Id() As Int32
	Get
		Return(mTipoEnvio_Id)
	End Get
	Set (Value As Int32)
		mTipoEnvio_Id = Value
	End Set
End Property
#End Region

End Class 
