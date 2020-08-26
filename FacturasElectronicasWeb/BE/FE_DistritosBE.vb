Public Class FE_DistritosBE

Private mDistritoCodigo As String
Private mDistritoDescripcion As String
Private mProvinciaCodigo As String

#Region "Propiedades"
Public Property DistritoCodigo() As String
	Get
		Return(mDistritoCodigo)
	End Get
	Set (Value As String)
		mDistritoCodigo = Value
	End Set
End Property
Public Property DistritoDescripcion() As String
	Get
		Return(mDistritoDescripcion)
	End Get
	Set (Value As String)
		mDistritoDescripcion = Value
	End Set
End Property
Public Property ProvinciaCodigo() As String
	Get
		Return(mProvinciaCodigo)
	End Get
	Set (Value As String)
		mProvinciaCodigo = Value
	End Set
End Property
#End Region

End Class 
