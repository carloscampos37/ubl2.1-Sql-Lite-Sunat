namespace OpenInvoicePeru.ServicioOse
{
    public interface IServicioSunatConsultas : IServicioSunat
    {
        RespuestaSincrono ConsultarConstanciaDeRecepcion(DatosDocumento request);
    }
}