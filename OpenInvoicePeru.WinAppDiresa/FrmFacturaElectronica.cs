using OpenInvoicePeru.Comun.Dto.Intercambio;
using OpenInvoicePeru.Comun.Dto.Modelos;
using OpenInvoicePeru.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Configuration;
using System.Linq;
using OpenInvoicePeru.Datos;
using OpenInvoicePeru.WinApp.Properties;

namespace OpenInvoicePeru.ApiClientCSharp
{

    public partial class FrmFacturaElectronica : Form
    {
        #region variables
        
        private readonly HttpClient _client;
        public string RutaArchivo { get; set; }

        public DataTable DtEmpresa;
        public DataTable DtDocumentos;
        public DataTable DtArticulos;
        string SQL = "";
        public Contribuyente vEmisor;
        DocumentoElectronico Documento = new DocumentoElectronico();

        private readonly string _baseUrl = "http://localhost/OpenInvoicePeru/api";

        // Private ReadOnly _urlSunat As String = "https://e-beta.sunat.gob.pe/ol-ti-itcpfegem-beta/billService"
        private readonly string _urlSunat = "https://www.sunat.gob.pe/ol-ti-itcpgem-sqa/billService";

        private const string FormatoFecha = "yyyy-MM-dd";
        string ServidorE = "campos.hostbsd,com";
        string ServidorGENE = "campos.hostbsd.com";
        string BDEmpresaE = "facturaselectronicas";
        string VGCnxSqlE = "Server=campos.hostbsd.com;database=facturaselectronicas;User ID=sa;Password=Aa12345*";
        string VGGeneralSqlE = "Server=campos.hostbsd.com;database=facturaselectronicas;User ID=sa;Password=Aa12345*";

        #endregion variables

        #region constructores

        public FrmFacturaElectronica()
        {
            InitializeComponent();
            _client = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["UrlOpenInvoicePeruApi"])
            };
            Load += (s, e) =>
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    using (var ctx = new OpenInvoicePeruDb())
                    {
                        direccionSunatBindingSource.DataSource = ctx.DireccionesSunat.ToList();
                        direccionSunatBindingSource.ResetBindings(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException?.Message, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            };
        }

        #endregion constructores

        #region funciones

        private async void CrearFacturas(int ii)
        {
            try
            {
                txtResult.Text = txtResult.Text + "Ejemplo Factura";
                var idDoc = Convert.ToString(DtDocumentos.Rows[ii]["Seriedocumento"] + "-" +
                                             DtDocumentos.Rows[ii]["NumeroDocumento"]);
                string vletras = Convert.ToString(DtDocumentos.Rows[ii]["letras"]);
                DocumentoElectronico documento = new DocumentoElectronico();

                documento.Emisor = vEmisor;
                documento.Receptor = new Contribuyente
                {
                    NroDocumento = Convert.ToString(DtDocumentos.Rows[ii]["clienteruc"]),
                    TipoDocumento = "6",
                    NombreLegal = Convert.ToString(DtDocumentos.Rows[ii]["ClienterazonSocial"]),
                };
                documento.IdDocumento = idDoc;
                documento.FechaEmision = Convert.ToString(DtDocumentos.Rows[ii]["Fechadocumento"]);
                documento.Moneda = "PEN";
                documento.MontoEnLetras = vletras;
                documento.CalculoIgv = 0.18m;
                documento.CalculoIsc = 0.00m;
                documento.CalculoDetraccion = 0.00m;
                documento.TipoDocumento = "01";
                documento.TotalIgv = 18;
                documento.TotalVenta = 118;
                documento.Gravadas = 100;
                documento.Items = new List<DetalleDocumento>();


                string codigoTipoDoc;
                string metodoApi;
                metodoApi = "";
                switch (cboTipoDoc.SelectedIndex)
                {
                    case 0:
                        codigoTipoDoc = "01";
                        break;
                    case 1:
                        codigoTipoDoc = "03";
                        break;
                    case 2:
                        codigoTipoDoc = "07";
                        metodoApi = "api/GenerarNotaCredito";
                        break;
                    case 3:
                        codigoTipoDoc = "08";
                        metodoApi = "api/GenerarNotaDebito";
                        break;
                    case 4:
                        codigoTipoDoc = "20";
                        break;
                    case 5:
                        codigoTipoDoc = "40";
                        break;
                    case 6:
                        codigoTipoDoc = "RC";
                        break;
                    case 7:
                        codigoTipoDoc = "RA";
                        break;
                    case 8:
                        codigoTipoDoc = "09";
                        break;
                    default:
                        codigoTipoDoc = "01";
                        break;
                }
                if (string.IsNullOrEmpty(idDoc))
                    throw new InvalidOperationException("La Serie y el Correlativo no pueden estar vacíos");

                if (metodoApi == "")
                    metodoApi = "api/GenerarNotaCredito";


                var response = await _client.PostAsJsonAsync(metodoApi, documento);
                var respuesta = await response.Content.ReadAsAsync<DocumentoResponse>();
                if (!respuesta.Exito)
                    throw new ApplicationException(respuesta.MensajeError);

                String vRutaXml = Convert.ToString(DtDocumentos.Rows[ii]["CarpetaEnviosXml"]);
                RutaArchivo = Path.Combine(vRutaXml,
                    $"{documento.IdDocumento}.xml");

                File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(respuesta.TramaXmlSinFirma));

                var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(RutaArchivo));

                String vRutaCertificado = Convert.ToString(DtEmpresa.Rows[0]["CarpetaCertificadoDigital"]) +
                                          Convert.ToString(DtEmpresa.Rows[0]["NombreCertificadoDigital"]);

                var firmadoRequest = new FirmadoRequest
                {
                    TramaXmlSinFirma = tramaXmlSinFirma,
                    CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(vRutaCertificado)),
                    PasswordCertificado = Convert.ToString(DtEmpresa.Rows[0]["PasswCertificadoDigital"]),
                    UnSoloNodoExtension = rbRetenciones.Checked || rbResumen.Checked
                };

                var jsonFirmado = await _client.PostAsJsonAsync("api/Firmar", firmadoRequest);
                var respuestaFirmado = await jsonFirmado.Content.ReadAsAsync<FirmadoResponse>();
                if (!respuestaFirmado.Exito)
                    throw new ApplicationException(respuestaFirmado.MensajeError);

                var enviarDocumentoRequest = new EnviarDocumentoRequest
                {
                    Ruc = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]),
                    UsuarioSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaUsuarioSol"]),
                    ClaveSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaClaveSol"]),
                    EndPointUrl = ValorSeleccionado(),
                    IdDocumento = idDoc,
                    TipoDocumento = codigoTipoDoc,
                    TramaXmlFirmado = respuestaFirmado.TramaXmlFirmado
                };

                var apiMetodo = rbResumen.Checked && codigoTipoDoc != "09"
                    ? "api/EnviarResumen"
                    : "api/EnviarDocumento";

                var jsonEnvioDocumento = await _client.PostAsJsonAsync(apiMetodo, enviarDocumentoRequest);

                RespuestaComunConArchivo respuestaEnvio;
                if (!rbResumen.Checked)
                {
                    respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarDocumentoResponse>();
                    var rpta = (EnviarDocumentoResponse)respuestaEnvio;
                    txtResult.Text =
                        $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.MensajeRespuesta} siendo las {
                                DateTime.Now
                            }";
                    try
                    {
                        if (rpta.Exito && !string.IsNullOrEmpty(rpta.TramaZipCdr))
                        {
                            File.WriteAllBytes($"{WinApp.Program.CarpetaXml}\\{respuestaEnvio.NombreArchivo}",
                                Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                            File.WriteAllBytes($"{WinApp.Program.CarpetaCdr}\\R-{respuestaEnvio.NombreArchivo}",
                                Convert.FromBase64String(rpta.TramaZipCdr));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarResumenResponse>();
                    var rpta = (EnviarResumenResponse)respuestaEnvio;
                    txtResult.Text = $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.NroTicket}";
                }

                if (!respuestaEnvio.Exito)
                    throw new ApplicationException(respuestaEnvio.MensajeError);

                if (chkVoz.Checked)
                    Hablar();
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private static Contribuyente CrearEmisor(DataTable DtEmpresa)

        {
            try
            {
                Contribuyente Dtx = new Contribuyente();
                Dtx.NroDocumento = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]);
                Dtx.TipoDocumento = "6";
                Dtx.Direccion = Convert.ToString(DtEmpresa.Rows[0]["EmpresaDIRECCION"]);
                Dtx.Urbanizacion = Convert.ToString(DtEmpresa.Rows[0]["Empresaurbanizacion"]);
                Dtx.Departamento = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRegion"]);
                Dtx.Provincia = Convert.ToString(DtEmpresa.Rows[0]["EmpresaProvincia"]);
                Dtx.Distrito = Convert.ToString(DtEmpresa.Rows[0]["Empresadistrito"]);
                Dtx.NombreComercial = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRazonComercial"]);
                Dtx.NombreLegal = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRazonSocial"]);
                Dtx.Ubigeo = Convert.ToString(DtEmpresa.Rows[0]["Ubigeo_id"]);
                return Dtx;
            }
            catch
            {
                return null;
            }
            ;
        }
        public static DetalleDocumento DetalleItem(DataTable DtArticulos, int i)
        {
            decimal vPrecioUnitario = 0;

            try
            {
                if ((double) Convert.ToDecimal(DtArticulos.Rows[i]["Productocantidad"]) == 0)
                {
                    vPrecioUnitario = Convert.ToDecimal(DtArticulos.Rows[i]["Preciovta"]);
                }
                else
                {
                    vPrecioUnitario = Convert.ToDecimal(DtArticulos.Rows[i]["Preciovta"]) /
                                      Convert.ToDecimal(DtArticulos.Rows[i]["Productocantidad"]);
                }

                DetalleDocumento detalle = new DetalleDocumento
                {
                    Id = i + 1,
                    Cantidad = Convert.ToDecimal(DtArticulos.Rows[i]["Productocantidad"]),
                    PrecioReferencial = vPrecioUnitario,
                    PrecioUnitario = vPrecioUnitario,
                    TipoPrecio = "01",
                    CodigoItem = Convert.ToString(DtArticulos.Rows[i]["ProductoCodigo"]),
                    Descripcion = Convert.ToString(DtArticulos.Rows[i]["Productodescripcion"]),
                    UnidadMedida = "KG",
                    Impuesto = Convert.ToDecimal(DtArticulos.Rows[i]["ItemIgv"]),
                    TipoImpuesto = "10",
                    TotalVenta = Convert.ToDecimal(DtArticulos.Rows[i]["ItemVenta"]),
                    Suma = Convert.ToDecimal(DtArticulos.Rows[i]["ItemVenta"]),
                };
                return detalle;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable ConsultarTabla(string vSQL, string vCadConex, int vCommandTimeOut = 800)
        {
            string cError = "";
            try
            {
                string strConn = "";
                strConn = vCadConex;
                SqlConnection oConn = new SqlConnection(vCadConex);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(vSQL, oConn);
                da.Fill(dt1);
                oConn.Close();
                return dt1;
            }
            catch (Exception ex)
            {
                cError = ex.Message;
                return null;
            }
        }
        private void Hablar()
        {
            if (string.IsNullOrEmpty(txtResult.Text)) return;
            var synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();
            synth.SpeakAsync(txtResult.Text);
        }
        private string ValorSeleccionado()
        {
            var direccionSunat = direccionSunatBindingSource.Current as DireccionSunat;
            return direccionSunat == null ? string.Empty : direccionSunat.Descripcion;
        }

        #endregion funciones

        #region botones
        private void FrmFacturaElectronica_Load(object sender, EventArgs e)
        {
            String SQL = "";

            SQL ="SELECT  a.*, EmpresaUsuarioSol, EmpresaClaveSol, NombreCertificadoDigital, PasswCertificadoDigital, CarpetaCertificadoDigital, FechaVigenciaCertificado, CarpetaEnviosXml, carpetaRecepcionXml, CarpetaBajasXml, CarpetaRecepcionBajas FROM facturaselectronicas.[dbo].[FE_Empresas] a ";
            SQL = SQL +"INNER JOIN facturaselectronicas.[dbo].FE_EmpresasSeguridad b ON a.Empresacodigo=b.EmpresaCodigo INNER JOIN facturaselectronicas.[dbo].FE_EmpresasDatosAdicionales c ON a.Empresacodigo= c.EmpresaCodigo WHERE a.Empresacodigo='01'";

            DtEmpresa = ConsultarTabla(SQL, VGGeneralSqlE);

        }
 private void BntGenerar_Click(object sender, EventArgs e)
 {
     SQL = " SELECT Establecimiento_id,Fechadocumento,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01',1), ";
                SQL+=" b.* FROM dbo.FE_DocumentosElectronicosCab a ";
            SQL = SQL + "  INNER join FE_DocumentosElectronicosDet b ON a.empresacodigo = b.empresacodigo ";
            SQL = SQL + " AND a.documentoselectronicos_id = b.documentoselectronicos_id ";
            SQL = SQL + " WHERE fechadocumento = '" + DtpFecha.Text + "'";

            DtDocumentos = ConsultarTabla(SQL, VGGeneralSqlE);
            DgvConsulta.DataSource = DtDocumentos;


        }

        private void BntSunat_Click(object sender, EventArgs e)
        {
            {
                txtResult.Text = "";
                txtResult.Text = "Proceso de generacion de boletas , factura/boletas ";
                try
                {
                    for (int i = 0; i <= DtDocumentos.Rows.Count - 1; i++)
                    {
                        vEmisor = CrearEmisor(DtEmpresa);
                        CrearFacturas(i);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion botones
        
    }
}