﻿using Newtonsoft.Json;

using OpenInvoicePeru.Comun.Dto.Contratos;
using System.Collections.Generic;

namespace OpenInvoicePeru.Comun.Dto.Modelos
{
    public class DocumentoElectronico : IDocumentoElectronico
    {
        [JsonProperty(Required = Required.Always)]
        public string IdDocumento { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string TipoDocumento { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Contribuyente Emisor { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Contribuyente Receptor { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string FechaEmision { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Moneda { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public string TipoOperacion { get; set; }

        public decimal Gravadas { get; set; }

        public decimal Gratuitas { get; set; }

        public decimal Inafectas { get; set; }

        public decimal Exoneradas { get; set; }

        public decimal DescuentoGlobal { get; set; }

        [JsonProperty(Required = Required.Always)]
        public List<DetalleDocumento> Items { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal TotalVenta { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal TotalIgv { get; set; }

        public decimal TotalIsc { get; set; }

        public decimal TotalOtrosTributos { get; set; }

        [JsonIgnore]
        public string MontoEnLetras { get; set; }

        public string PlacaVehiculo { get; set; }

        public decimal MontoPercepcion { get; set; }

        public decimal MontoDetraccion { get; set; }

        public List<DatoAdicional> DatoAdicionales { get; set; }

        public string TipoDocAnticipo { get; set; }

        public string DocAnticipo { get; set; }

        public string MonedaAnticipo { get; set; }

        public decimal MontoAnticipo { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public DatosGuia DatosGuiaTransportista { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public List<DocumentoRelacionado> Relacionados { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public List<DocumentoRelacionado> OtrosDocumentosRelacionados { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public List<Discrepancia> Discrepancias { get; set; }

        [JsonProperty(Required = Required.AllowNull)]
        public string NroOrdenCompra { get; set; }

        [JsonIgnore]
        public decimal CalculoIgv { get; set; }

        [JsonIgnore]
        public decimal CalculoIsc { get; set; }

        [JsonIgnore]
        public decimal CalculoDetraccion { get; set; }

        public DocumentoElectronico()
        {
            Emisor = new Contribuyente
            {
                TipoDocumento = "6" // RUC.
            };
            Receptor = new Contribuyente
            {
                TipoDocumento = "6" // RUC.
            };
            CalculoIgv = 0.18m;
            CalculoIsc = 0.10m;
            CalculoDetraccion = 0.04m;
            Items = new List<DetalleDocumento>();
            DatoAdicionales = new List<DatoAdicional>();
            Relacionados = new List<DocumentoRelacionado>();
            OtrosDocumentosRelacionados = new List<DocumentoRelacionado>();
            Discrepancias = new List<Discrepancia>();
            TipoDocumento = "01"; // Factura.
            TipoOperacion = "01"; // Venta Interna.
            Moneda = "PEN"; // Soles.
            MontoEnLetras = string.Empty;
        }
    }
}