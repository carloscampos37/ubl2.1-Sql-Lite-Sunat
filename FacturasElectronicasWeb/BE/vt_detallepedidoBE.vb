Public Class vt_detallepedidoBE

Private mempresacodigo As String
Private mpedidonumero As String
Private mdetpeditem As String
Private mdetpedcantpedida As Double
Private mdetpedcantpedidaref As Double
Private mdetpedcantdespach As Double
Private mdetpedcantdespachref As Double
Private mdetpedcantentreg As Double
Private mdetpedcantentregref As Double
Private mdetpedcantdevol As Double
Private mdetpedcantdevolref As Double
Private mdetpedfactorconv As Double
Private mdetpedpreciocosto As Double
Private mproductocodigo As String
Private munidadcodigo As String
Private mdetpedpreciopact As Double
Private mdetpeddsctoxitem As Double
Private munidadreferencial As String
Private mdetpeddsctoxlinea As Double
Private mdetpeddsctoxprom As Double
Private mdetpedporcimp As Double
Private mdetpedimpbruto As Double
Private mdetpedmontdsctoxitem As Double
Private mdetpedmontodsctoxlinea As Double
Private mdetpedmontodsctoxprom As Double
Private mdetpedmontoimpto As Double
Private mDetPedMontoImpInafecto As Decimal
Private mdetpedmontoprecvta As Double
Private mdetpedporccomis As Double
Private mdetpedcostopromed As Double
Private mdetpedestado As String
Private mdetpedpartida As String
Private mdetpedmetrica As String
Private mdetpedobservacion As String
Private mpedidodocumentoNumero As Int32

#Region "Propiedades"
Public Property empresacodigo() As String
	Get
		Return(mempresacodigo)
	End Get
	Set (Value As String)
		mempresacodigo = Value
	End Set
End Property
Public Property pedidonumero() As String
	Get
		Return(mpedidonumero)
	End Get
	Set (Value As String)
		mpedidonumero = Value
	End Set
End Property
Public Property detpeditem() As String
	Get
		Return(mdetpeditem)
	End Get
	Set (Value As String)
		mdetpeditem = Value
	End Set
End Property
Public Property detpedcantpedida() As Double
	Get
		Return(mdetpedcantpedida)
	End Get
	Set (Value As Double)
		mdetpedcantpedida = Value
	End Set
End Property
Public Property detpedcantpedidaref() As Double
	Get
		Return(mdetpedcantpedidaref)
	End Get
	Set (Value As Double)
		mdetpedcantpedidaref = Value
	End Set
End Property
Public Property detpedcantdespach() As Double
	Get
		Return(mdetpedcantdespach)
	End Get
	Set (Value As Double)
		mdetpedcantdespach = Value
	End Set
End Property
Public Property detpedcantdespachref() As Double
	Get
		Return(mdetpedcantdespachref)
	End Get
	Set (Value As Double)
		mdetpedcantdespachref = Value
	End Set
End Property
Public Property detpedcantentreg() As Double
	Get
		Return(mdetpedcantentreg)
	End Get
	Set (Value As Double)
		mdetpedcantentreg = Value
	End Set
End Property
Public Property detpedcantentregref() As Double
	Get
		Return(mdetpedcantentregref)
	End Get
	Set (Value As Double)
		mdetpedcantentregref = Value
	End Set
End Property
Public Property detpedcantdevol() As Double
	Get
		Return(mdetpedcantdevol)
	End Get
	Set (Value As Double)
		mdetpedcantdevol = Value
	End Set
End Property
Public Property detpedcantdevolref() As Double
	Get
		Return(mdetpedcantdevolref)
	End Get
	Set (Value As Double)
		mdetpedcantdevolref = Value
	End Set
End Property
Public Property detpedfactorconv() As Double
	Get
		Return(mdetpedfactorconv)
	End Get
	Set (Value As Double)
		mdetpedfactorconv = Value
	End Set
End Property
Public Property detpedpreciocosto() As Double
	Get
		Return(mdetpedpreciocosto)
	End Get
	Set (Value As Double)
		mdetpedpreciocosto = Value
	End Set
End Property
Public Property productocodigo() As String
	Get
		Return(mproductocodigo)
	End Get
	Set (Value As String)
		mproductocodigo = Value
	End Set
End Property
Public Property unidadcodigo() As String
	Get
		Return(munidadcodigo)
	End Get
	Set (Value As String)
		munidadcodigo = Value
	End Set
End Property
Public Property detpedpreciopact() As Double
	Get
		Return(mdetpedpreciopact)
	End Get
	Set (Value As Double)
		mdetpedpreciopact = Value
	End Set
End Property
Public Property detpeddsctoxitem() As Double
	Get
		Return(mdetpeddsctoxitem)
	End Get
	Set (Value As Double)
		mdetpeddsctoxitem = Value
	End Set
End Property
Public Property unidadreferencial() As String
	Get
		Return(munidadreferencial)
	End Get
	Set (Value As String)
		munidadreferencial = Value
	End Set
End Property
Public Property detpeddsctoxlinea() As Double
	Get
		Return(mdetpeddsctoxlinea)
	End Get
	Set (Value As Double)
		mdetpeddsctoxlinea = Value
	End Set
End Property
Public Property detpeddsctoxprom() As Double
	Get
		Return(mdetpeddsctoxprom)
	End Get
	Set (Value As Double)
		mdetpeddsctoxprom = Value
	End Set
End Property
Public Property detpedporcimp() As Double
	Get
		Return(mdetpedporcimp)
	End Get
	Set (Value As Double)
		mdetpedporcimp = Value
	End Set
End Property
Public Property detpedimpbruto() As Double
	Get
		Return(mdetpedimpbruto)
	End Get
	Set (Value As Double)
		mdetpedimpbruto = Value
	End Set
End Property
Public Property detpedmontdsctoxitem() As Double
	Get
		Return(mdetpedmontdsctoxitem)
	End Get
	Set (Value As Double)
		mdetpedmontdsctoxitem = Value
	End Set
End Property
Public Property detpedmontodsctoxlinea() As Double
	Get
		Return(mdetpedmontodsctoxlinea)
	End Get
	Set (Value As Double)
		mdetpedmontodsctoxlinea = Value
	End Set
End Property
Public Property detpedmontodsctoxprom() As Double
	Get
		Return(mdetpedmontodsctoxprom)
	End Get
	Set (Value As Double)
		mdetpedmontodsctoxprom = Value
	End Set
End Property
Public Property detpedmontoimpto() As Double
	Get
		Return(mdetpedmontoimpto)
	End Get
	Set (Value As Double)
		mdetpedmontoimpto = Value
	End Set
End Property
Public Property DetPedMontoImpInafecto() As Decimal
	Get
		Return(mDetPedMontoImpInafecto)
	End Get
	Set (Value As Decimal)
		mDetPedMontoImpInafecto = Value
	End Set
End Property
Public Property detpedmontoprecvta() As Double
	Get
		Return(mdetpedmontoprecvta)
	End Get
	Set (Value As Double)
		mdetpedmontoprecvta = Value
	End Set
End Property
Public Property detpedporccomis() As Double
	Get
		Return(mdetpedporccomis)
	End Get
	Set (Value As Double)
		mdetpedporccomis = Value
	End Set
End Property
Public Property detpedcostopromed() As Double
	Get
		Return(mdetpedcostopromed)
	End Get
	Set (Value As Double)
		mdetpedcostopromed = Value
	End Set
End Property
Public Property detpedestado() As String
	Get
		Return(mdetpedestado)
	End Get
	Set (Value As String)
		mdetpedestado = Value
	End Set
End Property
Public Property detpedpartida() As String
	Get
		Return(mdetpedpartida)
	End Get
	Set (Value As String)
		mdetpedpartida = Value
	End Set
End Property
Public Property detpedmetrica() As String
	Get
		Return(mdetpedmetrica)
	End Get
	Set (Value As String)
		mdetpedmetrica = Value
	End Set
End Property
Public Property detpedobservacion() As String
	Get
		Return(mdetpedobservacion)
	End Get
	Set (Value As String)
		mdetpedobservacion = Value
	End Set
End Property
Public Property pedidodocumentoNumero() As Int32
	Get
		Return(mpedidodocumentoNumero)
	End Get
	Set (Value As Int32)
		mpedidodocumentoNumero = Value
	End Set
End Property
#End Region

End Class 
