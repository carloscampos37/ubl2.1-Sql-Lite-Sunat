Public Class FE_TipoEnvioSunatBE

Private mTipoEnvio_Id As Int32
Private mTipoEnvioDescripcion As String
Private mWebService As String

#Region "Propiedades"
Public Property TipoEnvio_Id() As Int32
	Get
		Return(mTipoEnvio_Id)
	End Get
	Set (Value As Int32)
		mTipoEnvio_Id = Value
	End Set
End Property
Public Property TipoEnvioDescripcion() As String
	Get
		Return(mTipoEnvioDescripcion)
	End Get
	Set (Value As String)
		mTipoEnvioDescripcion = Value
	End Set
End Property
Public Property WebService() As String
	Get
		Return(mWebService)
	End Get
	Set (Value As String)
		mWebService = Value
	End Set
End Property
#End Region

End Class 
