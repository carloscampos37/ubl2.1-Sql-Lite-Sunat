Public Class FE_EstablecimientosBE

Private mEmpresaCodigo As String
Private mEstablecimiento_id As String
Private mEstablecimientoDescripcion As String
Private mVendedor_id As String
Private mMicrored_id As String
Private mestablecimientoDireccion As String
Private mHabilitadoFactDiaria As Boolean
Private mHabilitadoFactPreimpresa As Boolean
Private mUsuarioCodigo As String
Private mHostName As String
Private mAnexoSunat As String

#Region "Propiedades"
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
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
Public Property EstablecimientoDescripcion() As String
	Get
		Return(mEstablecimientoDescripcion)
	End Get
	Set (Value As String)
		mEstablecimientoDescripcion = Value
	End Set
End Property
Public Property Vendedor_id() As String
	Get
		Return(mVendedor_id)
	End Get
	Set (Value As String)
		mVendedor_id = Value
	End Set
End Property
Public Property Microred_id() As String
	Get
		Return(mMicrored_id)
	End Get
	Set (Value As String)
		mMicrored_id = Value
	End Set
End Property
Public Property establecimientoDireccion() As String
	Get
		Return(mestablecimientoDireccion)
	End Get
	Set (Value As String)
		mestablecimientoDireccion = Value
	End Set
End Property
Public Property HabilitadoFactDiaria() As Boolean
	Get
		Return(mHabilitadoFactDiaria)
	End Get
	Set (Value As Boolean)
		mHabilitadoFactDiaria = Value
	End Set
End Property
Public Property HabilitadoFactPreimpresa() As Boolean
	Get
		Return(mHabilitadoFactPreimpresa)
	End Get
	Set (Value As Boolean)
		mHabilitadoFactPreimpresa = Value
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
Public Property HostName() As String
	Get
		Return(mHostName)
	End Get
	Set (Value As String)
		mHostName = Value
	End Set
End Property
Public Property AnexoSunat() As String
	Get
		Return(mAnexoSunat)
	End Get
	Set (Value As String)
		mAnexoSunat = Value
	End Set
End Property
#End Region

End Class 
