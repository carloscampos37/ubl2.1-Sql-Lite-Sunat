Public Class FE_SistemaBE

Private mEmpresacodigo As String
Private mCorrelativoComprobImpreso As Int32
Private mCorrrelativodocumentoelectronico As Int32
Private mCorrelativoComunicacionBaja As Int32
Private mCorrrelativoResumenDiario As Int32
Private mEsquemaInafecto As Boolean
Private mFechaAct As DateTime

#Region "Propiedades"
Public Property Empresacodigo() As String
	Get
		Return(mEmpresacodigo)
	End Get
	Set (Value As String)
		mEmpresacodigo = Value
	End Set
End Property
Public Property CorrelativoComprobImpreso() As Int32
	Get
		Return(mCorrelativoComprobImpreso)
	End Get
	Set (Value As Int32)
		mCorrelativoComprobImpreso = Value
	End Set
End Property
Public Property Corrrelativodocumentoelectronico() As Int32
	Get
		Return(mCorrrelativodocumentoelectronico)
	End Get
	Set (Value As Int32)
		mCorrrelativodocumentoelectronico = Value
	End Set
End Property
Public Property CorrelativoComunicacionBaja() As Int32
	Get
		Return(mCorrelativoComunicacionBaja)
	End Get
	Set (Value As Int32)
		mCorrelativoComunicacionBaja = Value
	End Set
End Property
Public Property CorrrelativoResumenDiario() As Int32
	Get
		Return(mCorrrelativoResumenDiario)
	End Get
	Set (Value As Int32)
		mCorrrelativoResumenDiario = Value
	End Set
End Property
Public Property EsquemaInafecto() As Boolean
	Get
		Return(mEsquemaInafecto)
	End Get
	Set (Value As Boolean)
		mEsquemaInafecto = Value
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
