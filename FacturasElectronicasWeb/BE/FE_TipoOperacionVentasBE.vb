Public Class FE_TipoOperacionVentasBE

Private mTipoOperacionCodigo As String
Private mTipoOperacionDescripcion As String

#Region "Propiedades"
Public Property TipoOperacionCodigo() As String
	Get
		Return(mTipoOperacionCodigo)
	End Get
	Set (Value As String)
		mTipoOperacionCodigo = Value
	End Set
End Property
Public Property TipoOperacionDescripcion() As String
	Get
		Return(mTipoOperacionDescripcion)
	End Get
	Set (Value As String)
		mTipoOperacionDescripcion = Value
	End Set
End Property
#End Region

End Class 
