﻿using System;
using System.Threading.Tasks;
using System.Web.Http;
using Jck.Comun.Dto.Intercambio;
using Jck.Comun.Dto.Modelos;
using Jck.Firmado;
using Jck.WebApi;
using Jck.Xml;
using Microsoft.Practices.Unity;

namespace Jck.webApi.Controllers
{
    public class GenerarFacturaController : ApiController
    {
        private readonly IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;

        public GenerarFacturaController(ISerializador serializador)
        {
            _serializador = serializador;
            _documentoXml = _documentoXml = UnityConfig.GetConfiguredContainer()
                .Resolve<IDocumentoXml>(GetType().Name);
        }

        [HttpPost]
        public async Task<DocumentoResponse> Post([FromBody] DocumentoElectronico documento)
        {
            var response = new DocumentoResponse();
            try
            {
                var invoice = _documentoXml.Generar(documento);
                response.TramaXmlSinFirma = await _serializador.GenerarXml(invoice);
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
