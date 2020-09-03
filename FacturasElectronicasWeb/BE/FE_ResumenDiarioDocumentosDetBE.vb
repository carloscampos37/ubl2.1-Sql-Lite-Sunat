Public Class FE_ResumenDiarioDocumentosDetBE

Private mEstadoAnulado As Boolean
Private mEmpresaCodigo As String
Private mResumendiario_id As Int32
Private mResumendiarioCorrel As Int32
Private mTipoDocumento As String
Private mSerieDocumento As String
Private mNumerodeAceptacion As String
Private mNumerodeDocumentos As Int32
Private mNumeroDocumento As Int32
Private mNumeroDocumentoFinal As Int32
Private mEstadoEnvioSunat_id As Int32
Private mMonedaCodigo As String
Private mTotalImporteDsctoGlobal As Decimal
Private mTotalImporteExonerado As Decimal
Private mTotalImporteGravado As Decimal
Private mTotalImporteIGV As Decimal
Private mTotalImporteInafecto As Decimal
Private mTotalImporteVenta As Decimal
Private mMensajeRecepcion As String
Private mArchivoXmlAceptado As String
Private mGrupodeEnvioSunat As Int32

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
Public Property Resumendiario_id() As Int32
	Get
		Return(mResumendiario_id)
	End Get
	Set (Value As Int32)
		mResumendiario_id = Value
	End Set
End Property
Public Property ResumendiarioCorrel() As Int32
	Get
		Return(mResumendiarioCorrel)
	End Get
	Set (Value As Int32)
		mResumendiarioCorrel = Value
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
Public Property NumerodeAceptacion() As String
	Get
		Return(mNumerodeAceptacion)
	End Get
	Set (Value As String)
		mNumerodeAceptacion = Value
	End Set
End Property
Public Property NumerodeDocumentos() As Int32
	Get
		Return(mNumerodeDocumentos)
	End Get
	Set (Value As Int32)
		mNumerodeDocumentos = Value
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
Public Property MonedaCodigo() As String
	Get
		Return(mMonedaCodigo)
	End Get
	Set (Value As String)
		mMonedaCodigo = Value
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
Public Property TotalImporteExonerado() As Decimal
	Get
		Return(mTotalImporteExonerado)
	End Get
	Set (Value As Decimal)
		mTotalImporteExonerado = Value
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
Public Property TotalImporteIGV() As Decimal
	Get
		Return(mTotalImporteIGV)
	End Get
	Set (Value As Decimal)
		mTotalImporteIGV = Value
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
Public Property TotalImporteVenta() As Decimal
	Get
		Return(mTotalImporteVenta)
	End Get
	Set (Value As Decimal)
		mTotalImporteVenta = Value
	End Set
End Property
Public Property MensajeRecepcion() As String
	Get
		Return(mMensajeRecepcion)
	End Get
	Set (Value As String)
		mMensajeRecepcion = Value
	End Set
End Property
Public Property ArchivoXmlAceptado() As String
	Get
		Return(mArchivoXmlAceptado)
	End Get
	Set (Value As String)
		mArchivoXmlAceptado = Value
	End Set
End Property
Public Property GrupodeEnvioSunat() As Int32
	Get
		Return(mGrupodeEnvioSunat)
	End Get
	Set (Value As Int32)
		mGrupodeEnvioSunat = Value
	End Set
End Property
#End Region

End Class 
