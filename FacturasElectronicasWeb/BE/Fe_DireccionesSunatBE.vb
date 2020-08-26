Public Class Fe_DireccionesSunatBE

Private mDireccionSunat_Id As Int32
Private mDireccionSunatTipo As String
Private mDireccionSunatUrl As String
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property DireccionSunat_Id() As Int32
	Get
		Return(mDireccionSunat_Id)
	End Get
	Set (Value As Int32)
		mDireccionSunat_Id = Value
	End Set
End Property
Public Property DireccionSunatTipo() As String
	Get
		Return(mDireccionSunatTipo)
	End Get
	Set (Value As String)
		mDireccionSunatTipo = Value
	End Set
End Property
Public Property DireccionSunatUrl() As String
	Get
		Return(mDireccionSunatUrl)
	End Get
	Set (Value As String)
		mDireccionSunatUrl = Value
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
