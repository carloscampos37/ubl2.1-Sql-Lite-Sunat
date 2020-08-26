Public Class FE_ProvinciasBE

Private mProvinciaCodigo As String
Private mProvinciaDescripcion As String
Private mRegionCodigo As String

#Region "Propiedades"
Public Property ProvinciaCodigo() As String
	Get
		Return(mProvinciaCodigo)
	End Get
	Set (Value As String)
		mProvinciaCodigo = Value
	End Set
End Property
Public Property ProvinciaDescripcion() As String
	Get
		Return(mProvinciaDescripcion)
	End Get
	Set (Value As String)
		mProvinciaDescripcion = Value
	End Set
End Property
Public Property RegionCodigo() As String
	Get
		Return(mRegionCodigo)
	End Get
	Set (Value As String)
		mRegionCodigo = Value
	End Set
End Property
#End Region

End Class 
