Public Class FE_AfectacionIgvBE

Private mId As String
Private mCodigo As String
Private mNombre As String
Private mMenotecnico As String

#Region "Propiedades"
Public Property Id() As String
	Get
		Return(mId)
	End Get
	Set (Value As String)
		mId = Value
	End Set
End Property
Public Property Codigo() As String
	Get
		Return(mCodigo)
	End Get
	Set (Value As String)
		mCodigo = Value
	End Set
End Property
Public Property Nombre() As String
	Get
		Return(mNombre)
	End Get
	Set (Value As String)
		mNombre = Value
	End Set
End Property
Public Property Menotecnico() As String
	Get
		Return(mMenotecnico)
	End Get
	Set (Value As String)
		mMenotecnico = Value
	End Set
End Property
#End Region

End Class 
