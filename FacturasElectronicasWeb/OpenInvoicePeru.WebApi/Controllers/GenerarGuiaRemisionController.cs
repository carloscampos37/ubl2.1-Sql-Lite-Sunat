using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Jck.Comun.Dto.Intercambio;
using Jck.Comun.Dto.Modelos;
using Jck.Firmado;
using Jck.Xml;
using Jck.WebApi;

namespace Jck.webApi.Controllers
{
    public class GenerarGuiaRemisionController : ApiController
    {

        private readonly IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;

        public GenerarGuiaRemisionController(ISerializador serializador)
        {
            _serializador = serializador;
            _documentoXml = _documentoXml = UnityConfig.GetConfiguredContainer()
                .Resolve<IDocumentoXml>(GetType().Name);
        }

        [HttpPost]
        public async Task<DocumentoResponse> Post([FromBody] GuiaRemision documento)
        {
            var response = new DocumentoResponse();
            try
            {
                var notaCredito = _documentoXml.Generar(documento);
                response.TramaXmlSinFirma = await _serializador.GenerarXml(notaCredito);
                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.MensajeError = ex.Message;
                response.Pila = ex.StackTrace;
                response.Exito = false;
            }

            return response;
        }
    }
}