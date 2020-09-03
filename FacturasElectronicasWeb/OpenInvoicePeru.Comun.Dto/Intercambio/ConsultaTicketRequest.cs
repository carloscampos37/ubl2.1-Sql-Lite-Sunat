using Newtonsoft.Json;
using OpenInvoicePeru.Comun.Dto.Intercambio;

namespace OpenInvoicePeru.Comun.Dto.Intercambio
{
    public class ConsultaTicketRequest : EnvioDocumentoComun
    {
        [JsonProperty(Required = Required.Always)]
        public string NroTicket { get; set; }
    }
}