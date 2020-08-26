Public Class FE_ComprobImpresosDetItemBE

Private mEstadoAnulado As Boolean
Private mEmpresaCodigo As String
Private mComprobImpreso_Id As Int32
Private mComprobImpresoCorrel As Int32
Private mComprobImpresoCorrelItem As Int32
Private mTipoDocumento As String
Private mSerieDocumento As String
Private mNumeroDocumento As Int32
Private mNumeroDocumentoFinal As Int32
Private mEstadoEnvioSunat_id As Int32
Private mIdentidadCodigo As Int32
Private mClienteCodigo As String
Private mClienteRazonSocial As String
Private mMonedaCodigo As String
Private mTotalImporteGravado As Decimal
Private mTotalImporteExonerado As Decimal
Private mTotalImporteInafecto As Decimal
Private mTotalImporteISC As Decimal
Private mtotalImporteIGV As Decimal
Private mTotalImporteOtros As Decimal
Private mTotalImporteVenta As Decimal
Private mTipoDocumentoModifica As String
Private mSerieDocumentoModifica As String
Private mNumeroDocumentoModifica As String

#Region "Propiedades"
Public Property EstadoAnulado() As Boolean
	Get
		Return(mEstadoAnulado)
	End Get
	Set (Value As Boolean)
		mEstadoAnulado = Value
	End Set
End Property
Public Property EmpresaCodigo() As String
	Get
		Return(mEmpresaCodigo)
	End Get
	Set (Value As String)
		mEmpresaCodigo = Value
	End Set
End Property
Public Property ComprobImpreso_Id() As Int32
	Get
		Return(mComprobImpreso_Id)
	End Get
	Set (Value As Int32)
		mComprobImpreso_Id = Value
	End Set
End Property
Public Property ComprobImpresoCorrel() As Int32
	Get
		Return(mComprobImpresoCorrel)
	End Get
	Set (Value As Int32)
		mComprobImpresoCorrel = Value
	End Set
End Property
Public Property ComprobImpresoCorrelItem() As Int32
	Get
		Return(mComprobImpresoCorrelItem)
	End Get
	Set (Value As Int32)
		mComprobImpresoCorrelItem = Value
	End Set
End Property
Public Property TipoDocumento() As String
	Get
		Return(mTipoDocumento)
	End Get
	Set (Value As String)
		mTipoDocumento = Value
	End Set
End Property
Public Property SerieDocumento() As String
	Get
		Return(mSerieDocumento)
	End Get
	Set (Value As String)
		mSerieDocumento = Value
	End Set
End Property
Public Property NumeroDocumento() As Int32
	Get
		Return(mNumeroDocumento)
	End Get
	Set (Value As Int32)
		mNumeroDocumento = Value
	End Set
End Property
Public Property NumeroDocumentoFinal() As Int32
	Get
		Return(mNumeroDocumentoFinal)
	End Get
	Set (Value As Int32)
		mNumeroDocumentoFinal = Value
	End Set
End Property
Public Property EstadoEnvioSunat_id() As Int32
	Get
		Return(mEstadoEnvioSunat_id)
	End Get
	Set (Value As Int32)
		mEstadoEnvioSunat_id = Value
	End Set
End Property
Public Property IdentidadCodigo() As Int32
	Get
		Return(mIdentidadCodigo)
	End Get
	Set (Value As Int32)
		mIdentidadCodigo = Value
	End Set
End Property
Public Property ClienteCodigo() As String
	Get
		Return(mClienteCodigo)
	End Get
	Set (Value As String)
		mClienteCodigo = Value
	End Set
End Property
Public Property ClienteRazonSocial() As String
	Get
		Return(mClienteRazonSocial)
	End Get
	Set (Value As String)
		mClienteRazonSocial = Value
	End Set
End Property
Public Property MonedaCodigo() As String
	Get
		Return(mMonedaCodigo)
	End Get
	Set (Value As String)
		mMonedaCodigo = Value
	End Set
End Property
Public Property TotalImporteGravado() As Decimal
	Get
		Return(mTotalImporteGravado)
	End Get
	Set (Value As Decimal)
		mTotalImporteGravado = Value
	End Set
End Property
Public Property TotalImporteExonerado() As Decimal
	Get
		Return(mTotalImporteExonerado)
	End Get
	Set (Value As Decimal)
		mTotalImporteExonerado = Value
	End Set
End Property
Public Property TotalImporteInafecto() As Decimal
	Get
		Return(mTotalImporteInafecto)
	End Get
	Set (Value As Decimal)
		mTotalImporteInafecto = Value
	End Set
End Property
Public Property TotalImporteISC() As Decimal
	Get
		Return(mTotalImporteISC)
	End Get
	Set (Value As Decimal)
		mTotalImporteISC = Value
	End Set
End Property
Public Property totalImporteIGV() As Decimal
	Get
		Return(mtotalImporteIGV)
	End Get
	Set (Value As Decimal)
		mtotalImporteIGV = Value
	End Set
End Property
Public Property TotalImporteOtros() As Decimal
	Get
		Return(mTotalImporteOtros)
	End Get
	Set (Value As Decimal)
		mTotalImporteOtros = Value
	End Set
End Property
Public Property TotalImporteVenta() As Decimal
	Get
		Return(mTotalImporteVenta)
	End Get
	Set (Value As Decimal)
		mTotalImporteVenta = Value
	End Set
End Property
Public Property TipoDocumentoModifica() As String
	Get
		Return(mTipoDocumentoModifica)
	End Get
	Set (Value As String)
		mTipoDocumentoModifica = Value
	End Set
End Property
Public Property SerieDocumentoModifica() As String
	Get
		Return(mSerieDocumentoModifica)
	End Get
	Set (Value As String)
		mSerieDocumentoModifica = Value
	End Set
End Property
Public Property NumeroDocumentoModifica() As String
	Get
		Return(mNumeroDocumentoModifica)
	End Get
	Set (Value As String)
		mNumeroDocumentoModifica = Value
	End Set
End Property
#End Region

End Class 
