using Newtonsoft.Json;

namespace OpenInvoicePeru.Comun.Dto.Modelos
{
    public class DetalleDocumento
    {
        [JsonProperty(Required = Required.Always)]
        public int Id { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal Cantidad { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string UnidadMedida { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string CodigoItem { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Descripcion { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal PrecioUnitario { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal PrecioReferencial { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string TipoPrecio { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string TipoImpuesto { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal Impuesto { get; set; }

        public decimal ImpuestoSelectivo { get; set; }

        public decimal OtroImpuesto { get; set; }

        public decimal Descuento { get; set; }

        public string PlacaVehiculo { get; set; }

        // nuevo

        public AfectacionIgv AfectacionIgv { get; set; }

        public decimal ItemGravado { get; set; }

        public decimal ItemInafecto { get; set; }

        public decimal ItemExonerado { get; set; }

         [JsonProperty(Required = Required.Always)]
        public decimal ItemVenta { get; set; }

        [JsonProperty(Required = Required.Always)]
        public decimal ItemSuma { get; set; }

        public DetalleDocumento()
        {
            Id = 1;
            UnidadMedida = "NIU";
            TipoPrecio = "01";
            TipoImpuesto = "10";
            ItemExonerado = 0;
            ItemInafecto = 0;
            ItemGravado = 0;
        }
    }
}