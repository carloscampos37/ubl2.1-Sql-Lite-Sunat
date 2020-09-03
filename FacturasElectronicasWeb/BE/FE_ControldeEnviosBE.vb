Public Class FE_ControldeEnviosBE

Private mEmpresaCodigo As String
Private mFechaEmision As DateTime
Private mPuntovtaCodigo As String
Private mDocumentosElectronicos As Boolean
Private mComunicacionbajas As Boolean
Private mResumenDiario As Boolean
Private mEstadoCierreSunat As Boolean

#Region "Propiedades"
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property FechaEmision() As DateTime
	Get
		Return(mFechaEmision)
	End Get
	Set (Value As DateTime)
		mFechaEmision = Value
	End Set
End Property
Public Property PuntovtaCodigo() As String
	Get
		Return(mPuntovtaCodigo)
	End Get
	Set (Value As String)
		mPuntovtaCodigo = Value
	End Set
End Property
Public Property DocumentosElectronicos() As Boolean
	Get
		Return(mDocumentosElectronicos)
	End Get
	Set (Value As Boolean)
		mDocumentosElectronicos = Value
	End Set
End Property
Public Property Comunicacionbajas() As Boolean
	Get
		Return(mComunicacionbajas)
	End Get
	Set (Value As Boolean)
		mComunicacionbajas = Value
	End Set
End Property
Public Property ResumenDiario() As Boolean
	Get
		Return(mResumenDiario)
	End Get
	Set (Value As Boolean)
		mResumenDiario = Value
	End Set
End Property
Public Property EstadoCierreSunat() As Boolean
	Get
		Return(mEstadoCierreSunat)
	End Get
	Set (Value As Boolean)
		mEstadoCierreSunat = Value
	End Set
End Property
#End Region

End Class 
