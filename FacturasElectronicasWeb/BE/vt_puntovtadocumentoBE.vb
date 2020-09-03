Public Class vt_puntovtadocumentoBE

Private mempresacodigo As String
Private mpuntovtacodigo As String
Private mdocumentocodigo As String
Private mpuntovtadocserie As String
Private mpuntovtadoccorr As String
Private mpuntovtaguia1 As String
Private mpuntovtaguia2 As String
Private musuariocodigo As String
Private mNumeracionAutomatica As Boolean
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property empresacodigo() As String
	Get
		Return(mempresacodigo)
	End Get
	Set (Value As String)
		mempresacodigo = Value
	End Set
End Property
Public Property puntovtacodigo() As String
	Get
		Return(mpuntovtacodigo)
	End Get
	Set (Value As String)
		mpuntovtacodigo = Value
	End Set
End Property
Public Property documentocodigo() As String
	Get
		Return(mdocumentocodigo)
	End Get
	Set (Value As String)
		mdocumentocodigo = Value
	End Set
End Property
Public Property puntovtadocserie() As String
	Get
		Return(mpuntovtadocserie)
	End Get
	Set (Value As String)
		mpuntovtadocserie = Value
	End Set
End Property
Public Property puntovtadoccorr() As String
	Get
		Return(mpuntovtadoccorr)
	End Get
	Set (Value As String)
		mpuntovtadoccorr = Value
	End Set
End Property
Public Property puntovtaguia1() As String
	Get
		Return(mpuntovtaguia1)
	End Get
	Set (Value As String)
		mpuntovtaguia1 = Value
	End Set
End Property
Public Property puntovtaguia2() As String
	Get
		Return(mpuntovtaguia2)
	End Get
	Set (Value As String)
		mpuntovtaguia2 = Value
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
Public Property NumeracionAutomatica() As Boolean
	Get
		Return(mNumeracionAutomatica)
	End Get
	Set (Value As Boolean)
		mNumeracionAutomatica = Value
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
