Public Class FE_EmpresasSeguridadBE

Private mEmpresaCodigo As String
Private mEmpresaUsuarioSol As String
Private mEmpresaClaveSol As String
Private mNombreCertificadoDigital As String
Private mPasswCertificadoDigital As String
Private mFechaVigenciaCertificado As DateTime
Private mCorreoElectronicoFactelect As String
Private mPasswCorreoElectronico As String
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property EmpresaUsuarioSol() As String
	Get
		Return(mEmpresaUsuarioSol)
	End Get
	Set (Value As String)
		mEmpresaUsuarioSol = Value
	End Set
End Property
Public Property EmpresaClaveSol() As String
	Get
		Return(mEmpresaClaveSol)
	End Get
	Set (Value As String)
		mEmpresaClaveSol = Value
	End Set
End Property
Public Property NombreCertificadoDigital() As String
	Get
		Return(mNombreCertificadoDigital)
	End Get
	Set (Value As String)
		mNombreCertificadoDigital = Value
	End Set
End Property
Public Property PasswCertificadoDigital() As String
	Get
		Return(mPasswCertificadoDigital)
	End Get
	Set (Value As String)
		mPasswCertificadoDigital = Value
	End Set
End Property
Public Property FechaVigenciaCertificado() As DateTime
	Get
		Return(mFechaVigenciaCertificado)
	End Get
	Set (Value As DateTime)
		mFechaVigenciaCertificado = Value
	End Set
End Property
Public Property CorreoElectronicoFactelect() As String
	Get
		Return(mCorreoElectronicoFactelect)
	End Get
	Set (Value As String)
		mCorreoElectronicoFactelect = Value
	End Set
End Property
Public Property PasswCorreoElectronico() As String
	Get
		Return(mPasswCorreoElectronico)
	End Get
	Set (Value As String)
		mPasswCorreoElectronico = Value
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
