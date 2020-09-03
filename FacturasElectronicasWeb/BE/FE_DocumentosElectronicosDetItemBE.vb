Public Class FE_DocumentosElectronicosDetItemBE

Private mEmpresaCodigo As String
Private mDocumentosElectronicos_id As Int32
Private mDocumentosElectronicosCorrel As Int32
Private mDocumentosElectronicosCorrelItem As Int32
Private mProductoCodigo As String
Private mProductoDescripcion As String
Private mProductocantidad As Decimal
Private mPrecioLista As Decimal
Private mPrecioVta As Decimal
Private mTipodePrecio As String
Private mTipodeImpuesto As String
Private mTipodeISC As String
Private mItemGravado As Decimal
Private mItemDescuento As Decimal
Private mItemExonerado As Decimal
Private mItemInafecto As Decimal
Private mItemISC As Decimal
Private mItemIGV As Decimal
Private mItemOtros As Decimal
Private mItemVenta As Decimal

#Region "Propiedades"
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property DocumentosElectronicos_id() As Int32
	Get
		Return(mDocumentosElectronicos_id)
	End Get
	Set (Value As Int32)
		mDocumentosElectronicos_id = Value
	End Set
End Property
Public Property DocumentosElectronicosCorrel() As Int32
	Get
		Return(mDocumentosElectronicosCorrel)
	End Get
	Set (Value As Int32)
		mDocumentosElectronicosCorrel = Value
	End Set
End Property
Public Property DocumentosElectronicosCorrelItem() As Int32
	Get
		Return(mDocumentosElectronicosCorrelItem)
	End Get
	Set (Value As Int32)
		mDocumentosElectronicosCorrelItem = Value
	End Set
End Property
Public Property ProductoCodigo() As String
	Get
		Return(mProductoCodigo)
	End Get
	Set (Value As String)
		mProductoCodigo = Value
	End Set
End Property
Public Property ProductoDescripcion() As String
	Get
		Return(mProductoDescripcion)
	End Get
	Set (Value As String)
		mProductoDescripcion = Value
	End Set
End Property
Public Property Productocantidad() As Decimal
	Get
		Return(mProductocantidad)
	End Get
	Set (Value As Decimal)
		mProductocantidad = Value
	End Set
End Property
Public Property PrecioLista() As Decimal
	Get
		Return(mPrecioLista)
	End Get
	Set (Value As Decimal)
		mPrecioLista = Value
	End Set
End Property
Public Property PrecioVta() As Decimal
	Get
		Return(mPrecioVta)
	End Get
	Set (Value As Decimal)
		mPrecioVta = Value
	End Set
End Property
Public Property TipodePrecio() As String
	Get
		Return(mTipodePrecio)
	End Get
	Set (Value As String)
		mTipodePrecio = Value
	End Set
End Property
Public Property TipodeImpuesto() As String
	Get
		Return(mTipodeImpuesto)
	End Get
	Set (Value As String)
		mTipodeImpuesto = Value
	End Set
End Property
Public Property TipodeISC() As String
	Get
		Return(mTipodeISC)
	End Get
	Set (Value As String)
		mTipodeISC = Value
	End Set
End Property
Public Property ItemGravado() As Decimal
	Get
		Return(mItemGravado)
	End Get
	Set (Value As Decimal)
		mItemGravado = Value
	End Set
End Property
Public Property ItemDescuento() As Decimal
	Get
		Return(mItemDescuento)
	End Get
	Set (Value As Decimal)
		mItemDescuento = Value
	End Set
End Property
Public Property ItemExonerado() As Decimal
	Get
		Return(mItemExonerado)
	End Get
	Set (Value As Decimal)
		mItemExonerado = Value
	End Set
End Property
Public Property ItemInafecto() As Decimal
	Get
		Return(mItemInafecto)
	End Get
	Set (Value As Decimal)
		mItemInafecto = Value
	End Set
End Property
Public Property ItemISC() As Decimal
	Get
		Return(mItemISC)
	End Get
	Set (Value As Decimal)
		mItemISC = Value
	End Set
End Property
Public Property ItemIGV() As Decimal
	Get
		Return(mItemIGV)
	End Get
	Set (Value As Decimal)
		mItemIGV = Value
	End Set
End Property
Public Property ItemOtros() As Decimal
	Get
		Return(mItemOtros)
	End Get
	Set (Value As Decimal)
		mItemOtros = Value
	End Set
End Property
Public Property ItemVenta() As Decimal
	Get
		Return(mItemVenta)
	End Get
	Set (Value As Decimal)
		mItemVenta = Value
	End Set
End Property
#End Region

End Class 
