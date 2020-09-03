Public Class Fe_EstadosdeEnvioSunatBE

Private mEstadoEnvioSunat_id As Int32
Private mEstadoEnvioDescripcion As String
Private mEstadoEnvioCierre As Boolean
Private mEstadoAnulado As Boolean

#Region "Propiedades"
Public Property EstadoEnvioSunat_id() As Int32
	Get
		Return(mEstadoEnvioSunat_id)
	End Get
	Set (Value As Int32)
		mEstadoEnvioSunat_id = Value
	End Set
End Property
Public Property EstadoEnvioDescripcion() As String
	Get
		Return(mEstadoEnvioDescripcion)
	End Get
	Set (Value As String)
		mEstadoEnvioDescripcion = Value
	End Set
End Property
Public Property EstadoEnvioCierre() As Boolean
	Get
		Return(mEstadoEnvioCierre)
	End Get
	Set (Value As Boolean)
		mEstadoEnvioCierre = Value
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
