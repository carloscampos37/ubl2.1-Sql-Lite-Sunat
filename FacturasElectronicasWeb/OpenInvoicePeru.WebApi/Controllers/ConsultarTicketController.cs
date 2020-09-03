using System;
using System.Threading.Tasks;
using System.Web.Http;
using Jck.Comun.Dto.Intercambio;
using Jck.Firmado;
using Jck.Servicio;

namespace Jck.webApi.Controllers
{
    public class ConsultarTicketController : ApiController
    {
        private readonly IServicioSunatDocumentos _servicioSunatDocumentos;
        private readonly ISerializador _serializador;

        public ConsultarTicketController(IServicioSunatDocumentos servicioSunatDocumentos, ISerializador serializador)
        {
            _servicioSunatDocumentos = servicioSunatDocumentos;
            _serializador = serializador;
        }

        [HttpPost]
        public async Task<EnviarDocumentoResponse> Post([FromBody] ConsultaTicketRequest request)
        {
            var response = new EnviarDocumentoResponse();

            try
            {
                _servicioSunatDocumentos.Inicializar(new ParametrosConexion
                {
                    Ruc = request.Ruc,
                    UserName = request.UsuarioSol,
                    Password = request.ClaveSol,
                    EndPointUrl = request.EndPointUrl
                });

                var resultado = _servicioSunatDocumentos.ConsultarTicket(request.NroTicket);

                if (!resultado.Exito)
                {
                    response.Exito = false;
                    response.MensajeError = resultado.MensajeError;
                }
                else
                    response = await _serializador.GenerarDocumentoRespuesta(resultado.ConstanciaDeRecepcion);
            }
            catch (Exception ex)
            {
                response.MensajeError = ex.Source == "DotNetZip" ? "El Ticket no existe" : ex.Message;
                response.Pila = ex.StackTrace;
                response.Exito = false;
            }

            return response;
        }
    }
}
