Public Class MAEARTBE

Private mACODIGO As String
Private mACODIGO2 As String
Private mADESCRI As String
Private mADESCRI2 As String
Private mcodigodebarras As String
Private mAFAMILIA As String
Private mALINEA As String
Private mAMODELO As String
Private mAUNIDAD As String
Private mAGRUPO As String
Private mACUENTA As String
Private mAFSERIE As String
Private mAPRECIO As Double
Private mADESCTO As Double
Private mAPRECOM As Double
Private mACODPRO As String
Private mAFECHA As DateTime
Private mACASILLERO As String
Private mAFSTOCK As String
Private mAUSER As String
Private mEstadoAnulado As Boolean
Private mAFECVEN As DateTime
Private mACODMON As String
Private mATIPO As String
Private mACOMENTA As String
Private mAFLOTE As String
Private mAFDECI As String
Private mAUNIART As Double
Private mAPESO As Double
Private mAISCPOR As Double
Private mAIGVPOR As Double
Private mAHORA As DateTime
Private mAFPRELIB As String
Private mAFRESTA As String
Private mAFUNIREF As String
Private mAUNIREF As String
Private mAFACREF As Double
Private mAPDIS As Double
Private mAPCOM As Double
Private mACODMONC As String
Private mAFLAGIGV As Boolean
Private mACOLOR As String
Private mAMARCA As String
Private mATALLA As String
Private mPA As String
Private mTALLA As String
Private mestadodetraccion As Boolean
Private mtipodecambio As Double
Private mProductoFiscalizado As Boolean
Private mStockMinimo As Double
Private mproyectocodigo As String
Private mProductoBonificacion As Boolean

#Region "Propiedades"
Public Property ACODIGO() As String
	Get
		Return(mACODIGO)
	End Get
	Set (Value As String)
		mACODIGO = Value
	End Set
End Property
Public Property ACODIGO2() As String
	Get
		Return(mACODIGO2)
	End Get
	Set (Value As String)
		mACODIGO2 = Value
	End Set
End Property
Public Property ADESCRI() As String
	Get
		Return(mADESCRI)
	End Get
	Set (Value As String)
		mADESCRI = Value
	End Set
End Property
Public Property ADESCRI2() As String
	Get
		Return(mADESCRI2)
	End Get
	Set (Value As String)
		mADESCRI2 = Value
	End Set
End Property
Public Property codigodebarras() As String
	Get
		Return(mcodigodebarras)
	End Get
	Set (Value As String)
		mcodigodebarras = Value
	End Set
End Property
Public Property AFAMILIA() As String
	Get
		Return(mAFAMILIA)
	End Get
	Set (Value As String)
		mAFAMILIA = Value
	End Set
End Property
Public Property ALINEA() As String
	Get
		Return(mALINEA)
	End Get
	Set (Value As String)
		mALINEA = Value
	End Set
End Property
Public Property AMODELO() As String
	Get
		Return(mAMODELO)
	End Get
	Set (Value As String)
		mAMODELO = Value
	End Set
End Property
Public Property AUNIDAD() As String
	Get
		Return(mAUNIDAD)
	End Get
	Set (Value As String)
		mAUNIDAD = Value
	End Set
End Property
Public Property AGRUPO() As String
	Get
		Return(mAGRUPO)
	End Get
	Set (Value As String)
		mAGRUPO = Value
	End Set
End Property
Public Property ACUENTA() As String
	Get
		Return(mACUENTA)
	End Get
	Set (Value As String)
		mACUENTA = Value
	End Set
End Property
Public Property AFSERIE() As String
	Get
		Return(mAFSERIE)
	End Get
	Set (Value As String)
		mAFSERIE = Value
	End Set
End Property
Public Property APRECIO() As Double
	Get
		Return(mAPRECIO)
	End Get
	Set (Value As Double)
		mAPRECIO = Value
	End Set
End Property
Public Property ADESCTO() As Double
	Get
		Return(mADESCTO)
	End Get
	Set (Value As Double)
		mADESCTO = Value
	End Set
End Property
Public Property APRECOM() As Double
	Get
		Return(mAPRECOM)
	End Get
	Set (Value As Double)
		mAPRECOM = Value
	End Set
End Property
Public Property ACODPRO() As String
	Get
		Return(mACODPRO)
	End Get
	Set (Value As String)
		mACODPRO = Value
	End Set
End Property
Public Property AFECHA() As DateTime
	Get
		Return(mAFECHA)
	End Get
	Set (Value As DateTime)
		mAFECHA = Value
	End Set
End Property
Public Property ACASILLERO() As String
	Get
		Return(mACASILLERO)
	End Get
	Set (Value As String)
		mACASILLERO = Value
	End Set
End Property
Public Property AFSTOCK() As String
	Get
		Return(mAFSTOCK)
	End Get
	Set (Value As String)
		mAFSTOCK = Value
	End Set
End Property
Public Property AUSER() As String
	Get
		Return(mAUSER)
	End Get
	Set (Value As String)
		mAUSER = Value
	End Set
End Property
Public Property EstadoAnulado() As Boolean
	Get
		Return(mEstadoAnulado)
	End Get
	Set (Value As Boolean)
		mEstadoAnulado = Value
	End Set
End Property
Public Property AFECVEN() As DateTime
	Get
		Return(mAFECVEN)
	End Get
	Set (Value As DateTime)
		mAFECVEN = Value
	End Set
End Property
Public Property ACODMON() As String
	Get
		Return(mACODMON)
	End Get
	Set (Value As String)
		mACODMON = Value
	End Set
End Property
Public Property ATIPO() As String
	Get
		Return(mATIPO)
	End Get
	Set (Value As String)
		mATIPO = Value
	End Set
End Property
Public Property ACOMENTA() As String
	Get
		Return(mACOMENTA)
	End Get
	Set (Value As String)
		mACOMENTA = Value
	End Set
End Property
Public Property AFLOTE() As String
	Get
		Return(mAFLOTE)
	End Get
	Set (Value As String)
		mAFLOTE = Value
	End Set
End Property
Public Property AFDECI() As String
	Get
		Return(mAFDECI)
	End Get
	Set (Value As String)
		mAFDECI = Value
	End Set
End Property
Public Property AUNIART() As Double
	Get
		Return(mAUNIART)
	End Get
	Set (Value As Double)
		mAUNIART = Value
	End Set
End Property
Public Property APESO() As Double
	Get
		Return(mAPESO)
	End Get
	Set (Value As Double)
		mAPESO = Value
	End Set
End Property
Public Property AISCPOR() As Double
	Get
		Return(mAISCPOR)
	End Get
	Set (Value As Double)
		mAISCPOR = Value
	End Set
End Property
Public Property AIGVPOR() As Double
	Get
		Return(mAIGVPOR)
	End Get
	Set (Value As Double)
		mAIGVPOR = Value
	End Set
End Property
Public Property AHORA() As DateTime
	Get
		Return(mAHORA)
	End Get
	Set (Value As DateTime)
		mAHORA = Value
	End Set
End Property
Public Property AFPRELIB() As String
	Get
		Return(mAFPRELIB)
	End Get
	Set (Value As String)
		mAFPRELIB = Value
	End Set
End Property
Public Property AFRESTA() As String
	Get
		Return(mAFRESTA)
	End Get
	Set (Value As String)
		mAFRESTA = Value
	End Set
End Property
Public Property AFUNIREF() As String
	Get
		Return(mAFUNIREF)
	End Get
	Set (Value As String)
		mAFUNIREF = Value
	End Set
End Property
Public Property AUNIREF() As String
	Get
		Return(mAUNIREF)
	End Get
	Set (Value As String)
		mAUNIREF = Value
	End Set
End Property
Public Property AFACREF() As Double
	Get
		Return(mAFACREF)
	End Get
	Set (Value As Double)
		mAFACREF = Value
	End Set
End Property
Public Property APDIS() As Double
	Get
		Return(mAPDIS)
	End Get
	Set (Value As Double)
		mAPDIS = Value
	End Set
End Property
Public Property APCOM() As Double
	Get
		Return(mAPCOM)
	End Get
	Set (Value As Double)
		mAPCOM = Value
	End Set
End Property
Public Property ACODMONC() As String
	Get
		Return(mACODMONC)
	End Get
	Set (Value As String)
		mACODMONC = Value
	End Set
End Property
Public Property AFLAGIGV() As Boolean
	Get
		Return(mAFLAGIGV)
	End Get
	Set (Value As Boolean)
		mAFLAGIGV = Value
	End Set
End Property
Public Property ACOLOR() As String
	Get
		Return(mACOLOR)
	End Get
	Set (Value As String)
		mACOLOR = Value
	End Set
End Property
Public Property AMARCA() As String
	Get
		Return(mAMARCA)
	End Get
	Set (Value As String)
		mAMARCA = Value
	End Set
End Property
Public Property ATALLA() As String
	Get
		Return(mATALLA)
	End Get
	Set (Value As String)
		mATALLA = Value
	End Set
End Property
Public Property PA() As String
	Get
		Return(mPA)
	End Get
	Set (Value As String)
		mPA = Value
	End Set
End Property
Public Property TALLA() As String
	Get
		Return(mTALLA)
	End Get
	Set (Value As String)
		mTALLA = Value
	End Set
End Property
Public Property estadodetraccion() As Boolean
	Get
		Return(mestadodetraccion)
	End Get
	Set (Value As Boolean)
		mestadodetraccion = Value
	End Set
End Property
Public Property tipodecambio() As Double
	Get
		Return(mtipodecambio)
	End Get
	Set (Value As Double)
		mtipodecambio = Value
	End Set
End Property
Public Property ProductoFiscalizado() As Boolean
	Get
		Return(mProductoFiscalizado)
	End Get
	Set (Value As Boolean)
		mProductoFiscalizado = Value
	End Set
End Property
Public Property StockMinimo() As Double
	Get
		Return(mStockMinimo)
	End Get
	Set (Value As Double)
		mStockMinimo = Value
	End Set
End Property
Public Property proyectocodigo() As String
	Get
		Return(mproyectocodigo)
	End Get
	Set (Value As String)
		mproyectocodigo = Value
	End Set
End Property
Public Property ProductoBonificacion() As Boolean
	Get
		Return(mProductoBonificacion)
	End Get
	Set (Value As Boolean)
		mProductoBonificacion = Value
	End Set
End Property
#End Region

End Class 
