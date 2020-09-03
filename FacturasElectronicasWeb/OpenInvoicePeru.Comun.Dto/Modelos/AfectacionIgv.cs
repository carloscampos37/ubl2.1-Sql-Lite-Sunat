using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenInvoicePeru.Comun.Dto.Modelos
{
   public  class AfectacionIgv
    {
        [JsonProperty(Required = Required.Always)]
        public string Id { get; set; }
        
        [JsonProperty(Required = Required.Always)]
        public string Codigo { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Nombre { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Nemotecnico { get; set; }
        
    }
}
