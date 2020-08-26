Public Class FE_DocumentosBajasDetBE

Private mEstadoAnulado As Boolean
Private mEmpresaCodigo As String
Private mDocumentosBajas_Id As Int32
Private mDocumentosBajasCorrel As Int32
Private mNumerodeAceptacion As String
Private mTipoDocumento As String
Private mSerieDocumento As String
Private mNumeroDocumento As Int32
Private mNumeroDocumentoFinal As Int32
Private mEstadoEnvioSunat_id As Int32
Private mIdentidadcodigo As Int32
Private mClienteCodigo As String
Private mClienteRazonSocial As String
Private mMonedaCodigo As String
Private mPorcentajeIsc As Decimal
Private mTotalImporteGravado As Decimal
Private mTotalImporteDsctoGlobal As Decimal
Private mTotalImporteDsctoItem As Decimal
Private mTotalImporteExonerado As Decimal
Private mTotalImporteInafecto As Decimal
Private mTotalImporteISC As Decimal
Private mTotalImporteIGV As Decimal
Private mTotalImporteOtros As Decimal
Private mTotalImporteGratuitas As Decimal
Private mTotalImporteVenta As Decimal
Private mTipoDocumentoModifica As String
Private mSerieDocumentoModifica As String
Private mNumeroDocumentoModifica As String
Private mTipoMotivoNota As String
Private mDescripcionMotivoNota As String
Private mEnvioSedePrincipal As Boolean

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
Public Property DocumentosBajas_Id() As Int32
	Get
		Return(mDocumentosBajas_Id)
	End Get
	Set (Value As Int32)
		mDocumentosBajas_Id = Value
	End Set
End Property
Public Property DocumentosBajasCorrel() As Int32
	Get
		Return(mDocumentosBajasCorrel)
	End Get
	Set (Value As Int32)
		mDocumentosBajasCorrel = Value
	End Set
End Property
Public Property NumerodeAceptacion() As String
	Get
		Return(mNumerodeAceptacion)
	End Get
	Set (Value As String)
		mNumerodeAceptacion = Value
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
Public Property Identidadcodigo() As Int32
	Get
		Return(mIdentidadcodigo)
	End Get
	Set (Value As Int32)
		mIdentidadcodigo = Value
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
Public Property PorcentajeIsc() As Decimal
	Get
		Return(mPorcentajeIsc)
	End Get
	Set (Value As Decimal)
		mPorcentajeIsc = Value
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
Public Property TotalImporteDsctoGlobal() As Decimal
	Get
		Return(mTotalImporteDsctoGlobal)
	End Get
	Set (Value As Decimal)
		mTotalImporteDsctoGlobal = Value
	End Set
End Property
Public Property TotalImporteDsctoItem() As Decimal
	Get
		Return(mTotalImporteDsctoItem)
	End Get
	Set (Value As Decimal)
		mTotalImporteDsctoItem = Value
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
Public Property TotalImporteIGV() As Decimal
	Get
		Return(mTotalImporteIGV)
	End Get
	Set (Value As Decimal)
		mTotalImporteIGV = Value
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
Public Property TotalImporteGratuitas() As Decimal
	Get
		Return(mTotalImporteGratuitas)
	End Get
	Set (Value As Decimal)
		mTotalImporteGratuitas = Value
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
Public Property TipoMotivoNota() As String
	Get
		Return(mTipoMotivoNota)
	End Get
	Set (Value As String)
		mTipoMotivoNota = Value
	End Set
End Property
Public Property DescripcionMotivoNota() As String
	Get
		Return(mDescripcionMotivoNota)
	End Get
	Set (Value As String)
		mDescripcionMotivoNota = Value
	End Set
End Property
Public Property EnvioSedePrincipal() As Boolean
	Get
		Return(mEnvioSedePrincipal)
	End Get
	Set (Value As Boolean)
		mEnvioSedePrincipal = Value
	End Set
End Property
#End Region

End Class 
