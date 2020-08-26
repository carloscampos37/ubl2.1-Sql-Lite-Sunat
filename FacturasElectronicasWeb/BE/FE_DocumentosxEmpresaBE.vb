Public Class FE_DocumentosxEmpresaBE

Private mEmpresaCodigo As String
Private mDocumentoCodigo As String
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
Public Property DocumentoCodigo() As String
	Get
		Return(mDocumentoCodigo)
	End Get
	Set (Value As String)
		mDocumentoCodigo = Value
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
