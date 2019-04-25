// ReSharper disable InconsistentNaming

namespace OpenInvoicePeru.Comun.Constantes
{
    public static class EspacioNombres
    {
        public const string xmlnsInvoice = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
        public const string xmlnsCreditNote = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2";
        public const string xmlnsDebitNote = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2";
        public const string xmlnsVoidedDocuments = "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1";
        public const string xmlnsSummaryDocuments = "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1";
        public const string xmlnsRetention = "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1";
        public const string xmlnsPerception = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1";
        public const string xmlnsDespatchAdvice = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2";

        public const string listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01";

        public const string sac = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1";
        public const string cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
        public const string cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        public const string udt = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2";
        public const string ccts = "urn:un:unece:uncefact:documentation:2";
        public const string ext = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";
        public const string qdt = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2";

 
        public const string ar = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2";
        public const string nodoId = "/ar:ApplicationResponse/cbc:ID";
        public const string nodoResponseDate = "/ar:ApplicationResponse/cbc:ResponseDate";
        public const string nodoResponseTime = "ar:ApplicationResponse/cbc:ResponseTime";
        public const string nodoResponseCode = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode";
        public const string nodoDescription = "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description";
    }

    public static class Http
    {
        public const string ds = "http://www.w3.org/2000/09/xmldsig#";
        public const string xsi = "http://www.w3.org/2001/XMLSchema-instance";
        public const string wssecurity = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

        public const string canonicaAlgor = "http://www.w3.org/TR/2001/REC-xmlc14n-20010315";
        public const string SignatureAlgor = "http://www.w3.org/2000/09/xmldsig#rsasha1";
        public const string transformAlgor = "http://www.w3.org/2000/09/xmldsig#envelopedsignature";
        public const string digestAlgor = "http://www.w3.org/2000/09/xmldsig#sha1";
    }

    public static class Sunat
    {
        public const string schemeName = "SUNAT:Identificador de Tipo de Operación";

        public const string TaxIdentifier = "Tax Scheme Identifier";
        public const string taxCategory = "Tax Category Identifier";

        public const string tipoPrecio = "SUNAT:Indicador de Tipo de Precio";
        public const string peSunat = "PE:SUNAT";
        public const string documentoIdentidad = "SUNAT:Identificador de Documento de Identidad";
        public const string AfectacionIgv = "SUNAT:Codigo de Tipo de Afectación del IGV";
        public const string TipoDocumento = "SUNAT:Identificador de Tipo de Documento";

        public const string currenty = "Currency";
        public const string unece = "United Nations Economic Commission for Europe";
        public const string catalogos = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo";

        public const string iso5305 = "UN/ECE 5305";
        public const string iso5152 = "UN/ECE 5153";
        public const string iso4217 = "ISO 4217 Alpha";
        public const string iso20 = "UN/ECE rec 20";
        public const string iso5153 = "UN/ECE 5153";
        public const string unspec = "UNSPSC";
        public const string gs1Use = "GS1 US";

    }
}