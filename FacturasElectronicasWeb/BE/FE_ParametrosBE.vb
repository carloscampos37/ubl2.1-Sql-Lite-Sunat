Public Class FE_ParametrosBE

Private mEmpresaCodigo As String
Private mCodigoProductoUnico As Boolean
Private mImporteMinimoDni As Decimal
Private mConsolidaPtosVtasFE As Boolean

#Region "Propiedades"
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property CodigoProductoUnico() As Boolean
	Get
		Return(mCodigoProductoUnico)
	End Get
	Set (Value As Boolean)
		mCodigoProductoUnico = Value
	End Set
End Property
Public Property ImporteMinimoDni() As Decimal
	Get
		Return(mImporteMinimoDni)
	End Get
	Set (Value As Decimal)
		mImporteMinimoDni = Value
	End Set
End Property
Public Property ConsolidaPtosVtasFE() As Boolean
	Get
		Return(mConsolidaPtosVtasFE)
	End Get
	Set (Value As Boolean)
		mConsolidaPtosVtasFE = Value
	End Set
End Property
#End Region

End Class 
