Public Class FE_EmpresasDatosAdicionalesBE

Private mEmpresaCodigo As String
Private mCarpetaEnviosXml As String
Private mcarpetaRecepcionXml As String
Private mCarpetaBajasXml As String
Private mCarpetaRecepcionBajas As String
Private mCarpetaCertificadoDigital As String
Private mEmpresaCorreoelectronico As String
Private mCaracteresEspeciales As Boolean
Private mResolucionSunat As String
Private mListaUrlSunat As String

#Region "Propiedades"
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property CarpetaEnviosXml() As String
	Get
		Return(mCarpetaEnviosXml)
	End Get
	Set (Value As String)
		mCarpetaEnviosXml = Value
	End Set
End Property
Public Property carpetaRecepcionXml() As String
	Get
		Return(mcarpetaRecepcionXml)
	End Get
	Set (Value As String)
		mcarpetaRecepcionXml = Value
	End Set
End Property
Public Property CarpetaBajasXml() As String
	Get
		Return(mCarpetaBajasXml)
	End Get
	Set (Value As String)
		mCarpetaBajasXml = Value
	End Set
End Property
Public Property CarpetaRecepcionBajas() As String
	Get
		Return(mCarpetaRecepcionBajas)
	End Get
	Set (Value As String)
		mCarpetaRecepcionBajas = Value
	End Set
End Property
Public Property CarpetaCertificadoDigital() As String
	Get
		Return(mCarpetaCertificadoDigital)
	End Get
	Set (Value As String)
		mCarpetaCertificadoDigital = Value
	End Set
End Property
Public Property EmpresaCorreoelectronico() As String
	Get
		Return(mEmpresaCorreoelectronico)
	End Get
	Set (Value As String)
		mEmpresaCorreoelectronico = Value
	End Set
End Property
Public Property CaracteresEspeciales() As Boolean
	Get
		Return(mCaracteresEspeciales)
	End Get
	Set (Value As Boolean)
		mCaracteresEspeciales = Value
	End Set
End Property
Public Property ResolucionSunat() As String
	Get
		Return(mResolucionSunat)
	End Get
	Set (Value As String)
		mResolucionSunat = Value
	End Set
End Property
Public Property ListaUrlSunat() As String
	Get
		Return(mListaUrlSunat)
	End Get
	Set (Value As String)
		mListaUrlSunat = Value
	End Set
End Property
#End Region

End Class 
