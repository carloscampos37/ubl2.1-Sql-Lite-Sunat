namespace OpenInvoicePeru.ServicioSunat
{
    public interface IServicioSunatConsultas : IServicioSunat
    {
        RespuestaSincrono ConsultarConstanciaDeRecepcion(DatosDocumento request);
    }
}