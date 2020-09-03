Public Class Fe_RegionesBE

Private mRegionCodigo As String
Private mRegionDescripcion As String

#Region "Propiedades"
Public Property RegionCodigo() As String
	Get
		Return(mRegionCodigo)
	End Get
	Set (Value As String)
		mRegionCodigo = Value
	End Set
End Property
Public Property RegionDescripcion() As String
	Get
		Return(mRegionDescripcion)
	End Get
	Set (Value As String)
		mRegionDescripcion = Value
	End Set
End Property
#End Region

End Class 
