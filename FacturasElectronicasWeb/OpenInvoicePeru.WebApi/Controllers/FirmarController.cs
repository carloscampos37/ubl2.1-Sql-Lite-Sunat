using System;
using System.Threading.Tasks;
using System.Web.Http;
using Jck.Comun.Dto.Intercambio;
using  Jck.Firmado;

namespace Jck.webApi.Controllers
{
    public class FirmarController : ApiController
    {
        private readonly ICertificador _certificador;

        public FirmarController(ICertificador certificador)
        {
            _certificador = certificador;
        }

        [HttpPost]
        public async Task<FirmadoResponse> Post([FromBody]FirmadoRequest request)
        {
            var response = new FirmadoResponse();

            try
            {
                response = await _certificador.FirmarXml(request);
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
