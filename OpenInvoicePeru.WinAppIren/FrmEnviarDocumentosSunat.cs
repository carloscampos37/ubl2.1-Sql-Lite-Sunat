using FacturasElectronicas;
using OpenInvoicePeru.Class;
using OpenInvoicePeru.Comun.Dto.Intercambio;
using OpenInvoicePeru.Comun.Dto.Modelos;
using OpenInvoicePeru.Datos;
using OpenInvoicePeru.Entidades;
using OpenInvoicePeru.facturasElectronicas.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace OpenInvoicePeru.FacturasElectronicas
{
    public partial class FrmEnviarDocumentosSunat : global::FacturasElectronicas.PlantillaBase

    {
         
        #region Variables Privadas

        private string VGCnxSqlE = "Server=jck;database=facturaselectronicas;User ID=sa;Password=12345";
        ModFunciones Modfunc = new ModFunciones();
        private readonly HttpClient _client;

        public DataTable DtEmpresa;
        public DataTable DtDocumentos;
        public DataTable DtArticulos;
        public string RutaArchivo { get; set; }
        private string SQL = "";
        private const string FormatoFecha = "yyyy-MM-dd";
       public string vFechaXml;
        public string CodigoTipoDoc;

        #endregion Variables Privadas


        #region Constructor

        public FrmEnviarDocumentosSunat()
        {
            InitializeComponent();

            _client = new HttpClient { BaseAddress = new Uri(ConfigurationManager.AppSettings["UrlOpenInvoicePeruApi"]) };

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
                    MessageBox.Show(ex.Message + ex.InnerException?.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            };
        }

        #endregion Constructor

        #region Generacion XML
        private async void CrearXmlFact(int ii)
        {
            try
            {
                string idDoc = Convert.ToString(DtDocumentos.Rows[ii]["Seriedocumento"] + "-" +
                                                 DtDocumentos.Rows[ii]["NumeroDocumento"]);
                string vletras = Convert.ToString(DtDocumentos.Rows[ii]["letras"]);

                decimal vDscto = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteDsctoGlobal"]) + Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteDsctoItem"]);
                string vNroDocumento = Convert.ToString(DtDocumentos.Rows[ii]["clientecodigo"]);
                string vTipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["IdentidadCodigo"]);
                string vNombreLegal = Convert.ToString(DtDocumentos.Rows[ii]["ClienterazonSocial"]);

                DocumentoElectronico _xDocumento = new DocumentoElectronico();

                _xDocumento.Emisor = CrearEmisor(DtEmpresa);
                _xDocumento.Receptor = new Contribuyente
                {
                    NroDocumento = vNroDocumento,
                    TipoDocumento = vTipoDocumento,
                    NombreLegal = vNombreLegal,
                };
                _xDocumento.IdDocumento = idDoc;
                _xDocumento.FechaEmision = Convert.ToString(DtDocumentos.Rows[ii]["Fechadocumento"]);
                _xDocumento.Moneda = "PEN";
                _xDocumento.MontoEnLetras = vletras;
                _xDocumento.CalculoIgv = 18m;
                _xDocumento.CalculoIsc = Convert.ToDecimal(DtDocumentos.Rows[ii]["porcentajeIsc"]);
                _xDocumento.CalculoDetraccion = 0.00m;
                _xDocumento.TipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["tipodocumento"]);
                _xDocumento.Gravadas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGravado"]);
                _xDocumento.Inafectas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteinafecto"]);
                _xDocumento.Exoneradas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteexonerado"]);
                _xDocumento.Gratuitas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGratuitas"]);
                _xDocumento.TotalIsc = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteisc"]);
                _xDocumento.TotalIgv = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteIgv"]);
                _xDocumento.DescuentoGlobal = vDscto;
                _xDocumento.TotalVenta = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteventa"]);
                _xDocumento.Items = new List<DetalleDocumento>();

                DtArticulos = DetalleArticulos(DtDocumentos, ii);
                for (int i3 = 0; i3 <= DtArticulos.Rows.Count - 1; i3++)
                {
                    _xDocumento.Items.Add(DetalleItem(DtArticulos, i3));
                }

                string vNroDocumentoModifica = Convert.ToString(DtDocumentos.Rows[ii]["SeriedocumentoModifica"]) + "-" + Convert.ToString(DtDocumentos.Rows[ii]["NumeroDocumentoModifica"]);
                string vTipoDoc = Convert.ToString(DtDocumentos.Rows[ii]["TipoDocumento"]);

                if (vTipoDoc == "07" || vTipoDoc == "08")
                {
                    // nota de credito
                    var vRelacionado = new OpenInvoicePeru.Comun.Dto.Modelos.DocumentoRelacionado();
                    vRelacionado.TipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["TipoDocumentoModifica"]);
                    vRelacionado.NroDocumento = vNroDocumentoModifica;
                    _xDocumento.Relacionados.Add(vRelacionado);

                    // nota de debito
                    var vDiscrepancia = new OpenInvoicePeru.Comun.Dto.Modelos.Discrepancia();
                    vDiscrepancia.Tipo = Convert.ToString(DtDocumentos.Rows[ii]["TipodocumentoModifica"]);
                    vDiscrepancia.NroReferencia = vNroDocumentoModifica;
                    vDiscrepancia.Descripcion = Convert.ToString(DtDocumentos.Rows[ii]["DescripcionMotivoNota"]);
                    _xDocumento.Discrepancias.Add(vDiscrepancia);
                }
                string _metodoApi = "";
                switch (cboTipoDoc.SelectedIndex)
                {
                    case 2:
                        _metodoApi = "api/GenerarNotaCredito";
                        break;

                    case 3:
                        _metodoApi = "api/GenerarNotaDebito";
                        break;

                    default:
                        _metodoApi = "api/GenerarFactura";
                        break;
                }

                var response = await _client.PostAsJsonAsync(_metodoApi, _xDocumento);

                var respuesta = await response.Content.ReadAsAsync<DocumentoResponse>();

                if (!respuesta.Exito)
                    throw new ApplicationException(respuesta.MensajeError);

                String vRutaXml = Convert.ToString(DtEmpresa.Rows[0]["CarpetaEnviosXml"]);
                RutaArchivo = Path.Combine(vRutaXml, $"{_xDocumento.IdDocumento}.xml");

                File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(respuesta.TramaXmlSinFirma));
            }
            catch (Exception ex)
            {
                string cerror = ex.Message;
                MessageBox.Show(ex.Message);
                txtResult.Text = txtResult.Text + "\n" + ex.Message;
            }
        }
        private async void CrearFacturas(int ii)
        {
            try
            {

                string codigoTipoDoc;
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
                        break;

                    case 3:
                        codigoTipoDoc = "08";
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

                string idDoc = Convert.ToString(DtDocumentos.Rows[ii]["Seriedocumento"] + "-" + DtDocumentos.Rows[ii]["NumeroDocumento"]);

                String vRutaXml = Convert.ToString(DtEmpresa.Rows[0]["CarpetaEnviosXml"]);
                RutaArchivo = Path.Combine(vRutaXml, $"{idDoc}.xml");

                if (string.IsNullOrEmpty(idDoc))
                    throw new InvalidOperationException("La Serie y el Correlativo no pueden estar vacíos");

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

                var apiMetodo = rbResumen.Checked && codigoTipoDoc != "09" ? "api/EnviarResumen" : "api/EnviarDocumento";
                var jsonEnvioDocumento = await _client.PostAsJsonAsync(apiMetodo, enviarDocumentoRequest);

                RespuestaComunConArchivo respuestaEnvio;
                if (!rbResumen.Checked)
                {
                    respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarDocumentoResponse>();
                    var rpta = (EnviarDocumentoResponse)respuestaEnvio;
                    txtResult.Text = txtResult.Text + "\n" + idDoc + " " + $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.MensajeRespuesta} siendo las {DateTime.Now}{Environment.NewLine}";
                    try
                    {
                        if (rpta.Exito && !string.IsNullOrEmpty(rpta.TramaZipCdr))
                        {
                            File.WriteAllBytes($"{Program.CarpetaXml}\\{respuestaEnvio.NombreArchivo}",
                                Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                            File.WriteAllBytes($"{Program.CarpetaCdr}\\R-{respuestaEnvio.NombreArchivo}",
                                Convert.FromBase64String(rpta.TramaZipCdr));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarResumenResponse>();
                    var rpta = (EnviarResumenResponse)respuestaEnvio;
                    txtResult.Text = txtResult.Text + "\n" + $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.NroTicket}{Environment.NewLine}";
                }

                if (!respuestaEnvio.Exito)
                    throw new ApplicationException(respuestaEnvio.MensajeError);

                if (chkVoz.Checked)
                    Hablar();

            }
            catch (Exception ex)
            {
                txtResult.Text = txtResult.Text + Environment.NewLine + ex.Message;
                if (chkVoz.Checked)
                    Hablar();

            }
        }
        private async void CrearXmlBajas()
        {
            try
            {
                vFechaXml = "RA-" + Convert.ToString(DtpFechaEnvio.Value.Year);
                vFechaXml += Modfunc.Derecha("0" + Convert.ToString(DtpFechaEnvio.Value.Month), 2);
                vFechaXml += Modfunc.Derecha("0" + Convert.ToString(DtpFechaEnvio.Value.Day), 2);
                vFechaXml += "-002";

                OpenInvoicePeru.Comun.Dto.Modelos.ComunicacionBaja ComunicacionBaja = new Comun.Dto.Modelos.ComunicacionBaja();

                ComunicacionBaja.IdDocumento = vFechaXml;
                ComunicacionBaja.FechaEmision = DtpFechaEnvio.Value.ToString(FormatoFecha);
                ComunicacionBaja.FechaReferencia = DtpFecha.Value.ToString(FormatoFecha);
                ComunicacionBaja.Emisor = CrearEmisor(DtEmpresa);
                ComunicacionBaja.Bajas = new List<OpenInvoicePeru.Comun.Dto.Modelos.DocumentoBaja>();

                for (int i3 = 0; i3 <= DtDocumentos.Rows.Count - 1; i3++)
                {
                    OpenInvoicePeru.Comun.Dto.Modelos.DocumentoBaja DocumentoBajasItem = new OpenInvoicePeru.Comun.Dto.Modelos.DocumentoBaja();
                    DocumentoBajasItem.Id = i3 + 1;
                    DocumentoBajasItem.Correlativo = Convert.ToString(DtDocumentos.Rows[i3]["NumeroDocumento"]);
                    DocumentoBajasItem.TipoDocumento = Convert.ToString(DtDocumentos.Rows[i3]["TipoDocumento"]);
                    DocumentoBajasItem.Serie = Convert.ToString(DtDocumentos.Rows[i3]["SerieDocumento"]);
                    DocumentoBajasItem.MotivoBaja = "Anulación por otro tipo de documento";

                    ComunicacionBaja.Bajas.Add(DocumentoBajasItem);
                }

                string _metodoApi = "api/GenerarComunicacionBaja";
                var response = await _client.PostAsJsonAsync(_metodoApi, ComunicacionBaja);

                var respuesta = await response.Content.ReadAsAsync<DocumentoResponse>();

                if (!respuesta.Exito)
                    throw new ApplicationException(respuesta.MensajeError);

                String vRutaXml = Convert.ToString(DtEmpresa.Rows[0]["CarpetaEnviosXml"]);
                RutaArchivo = ComunicacionBaja.IdDocumento;
                //     RutaArchivo = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]) + "-" + ComunicacionBaja.IdDocumento;
                RutaArchivo = Path.Combine(vRutaXml, $"{RutaArchivo}.xml");

                File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(respuesta.TramaXmlSinFirma));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void CrearBajas()
        {
            try
            {


                String vRutaXml = Convert.ToString(DtEmpresa.Rows[0]["CarpetaEnviosXml"]);

                if (string.IsNullOrEmpty(vFechaXml))
                    throw new InvalidOperationException("La Serie y el Correlativo no pueden estar vacíos");

                var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(RutaArchivo));
                String vRutaCertificado = Convert.ToString(DtEmpresa.Rows[0]["CarpetaCertificadoDigital"]) +
                                                        Convert.ToString(DtEmpresa.Rows[0]["NombreCertificadoDigital"]);

                var firmadoRequest = new FirmadoRequest
                {
                    TramaXmlSinFirma = tramaXmlSinFirma,
                    CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(vRutaCertificado)),
                    PasswordCertificado = Convert.ToString(DtEmpresa.Rows[0]["PasswCertificadoDigital"]),
                    UnSoloNodoExtension = true
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
                    IdDocumento = vFechaXml,
                    TipoDocumento = CodigoTipoDoc,
                    TramaXmlFirmado = respuestaFirmado.TramaXmlFirmado
                };

                var apiMetodo = "api/EnviarResumen";
                var jsonEnvioDocumento = await _client.PostAsJsonAsync(apiMetodo, enviarDocumentoRequest);

                RespuestaComunConArchivo respuestaEnvio;
                respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarResumenResponse>();
                var rpta = (EnviarResumenResponse)respuestaEnvio;
                txtResult.Text = txtResult.Text + "\n" + $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.NroTicket}{Environment.NewLine}";

                if (!respuestaEnvio.Exito)
                    throw new ApplicationException(respuestaEnvio.MensajeError);

                if (chkVoz.Checked)
                    Hablar();

            }
            catch (Exception ex)
            {
                txtResult.Text = txtResult.Text + Environment.NewLine + ex.Message;
                if (chkVoz.Checked)
                    Hablar();

            }
        }
        private async void CrearXmlResumen()
        {
            try
            {
                vFechaXml = "RC-" + Convert.ToString(DtpFechaEnvio.Value.Year);
                vFechaXml += Modfunc.Derecha("0" + Convert.ToString(DtpFechaEnvio.Value.Month), 2);
                vFechaXml += Modfunc.Derecha("0" + Convert.ToString(DtpFechaEnvio.Value.Day), 2);
                vFechaXml += "-004";

                ResumenDiarioNuevo ResumenDiario = new ResumenDiarioNuevo();

                ResumenDiario.IdDocumento = vFechaXml;
                ResumenDiario.FechaEmision = DtpFechaEnvio.Value.ToString(FormatoFecha);
                ResumenDiario.FechaReferencia = DtpFecha.Value.ToString(FormatoFecha);
                ResumenDiario.Emisor = CrearEmisor(DtEmpresa);
                ResumenDiario.Resumenes = new List<GrupoResumenNuevo>();

                for (int ii = 0; ii <= DtDocumentos.Rows.Count - 1; ii++)
                {
                    decimal vDscto = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteDsctoGlobal"]) + Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteDsctoItem"]);

                    GrupoResumenNuevo DocumentoResumenItem = new GrupoResumenNuevo();

                    DocumentoResumenItem.Id = 13 + 1;
                    DocumentoResumenItem.TipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["TipoDocumento"]);
                    DocumentoResumenItem.Serie = Convert.ToString(DtDocumentos.Rows[ii]["SerieDocumento"]);
                    DocumentoResumenItem.CorrelativoInicio = Convert.ToInt32(DtDocumentos.Rows[ii]["NumeroDocumento"]);
                    DocumentoResumenItem.CorrelativoFin = Convert.ToInt32(DtDocumentos.Rows[ii]["NumeroDocumentoFinal"]);
                    DocumentoResumenItem.Gravadas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGravado"]);
                    DocumentoResumenItem.Inafectas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteinafecto"]);
                    DocumentoResumenItem.Exoneradas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteexonerado"]);
                    DocumentoResumenItem.Gratuitas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGratuitas"]);
                    DocumentoResumenItem.TotalIsc = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteisc"]);
                    DocumentoResumenItem.TotalIgv = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteIgv"]);
                    DocumentoResumenItem.TotalDescuentos = vDscto;
                    DocumentoResumenItem.TotalVenta = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteventa"]);

                    ResumenDiario.Resumenes.Add(DocumentoResumenItem);
                }
                string _metodoApi = "api/GenerarResumenDiario/v2";
                var response = await _client.PostAsJsonAsync(_metodoApi, ResumenDiario);

                var respuesta = await response.Content.ReadAsAsync<DocumentoResponse>();

                if (!respuesta.Exito)
                    throw new ApplicationException(respuesta.MensajeError);

                String vRutaXml = Convert.ToString(DtEmpresa.Rows[0]["CarpetaEnviosXml"]);
                RutaArchivo = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]) + "-" + vFechaXml;
                RutaArchivo = Path.Combine(vRutaXml, $"{RutaArchivo}.xml");

                File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(respuesta.TramaXmlSinFirma));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void CrearResumen()
        {
            try
            {

                String vRutaXml = Convert.ToString(DtEmpresa.Rows[0]["CarpetaEnviosXml"]);

                if (string.IsNullOrEmpty(vFechaXml))
                    throw new InvalidOperationException("La Serie y el Correlativo no pueden estar vacíos");

                var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(RutaArchivo));
                String vRutaCertificado = Convert.ToString(DtEmpresa.Rows[0]["CarpetaCertificadoDigital"]) +
                                                        Convert.ToString(DtEmpresa.Rows[0]["NombreCertificadoDigital"]);

                var firmadoRequest = new FirmadoRequest
                {
                    TramaXmlSinFirma = tramaXmlSinFirma,
                    CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(vRutaCertificado)),
                    PasswordCertificado = Convert.ToString(DtEmpresa.Rows[0]["PasswCertificadoDigital"]),
                    UnSoloNodoExtension = true
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
                    IdDocumento = vFechaXml,
                    TipoDocumento = CodigoTipoDoc,
                    TramaXmlFirmado = respuestaFirmado.TramaXmlFirmado
                };

                var apiMetodo = "api/EnviarResumen";
                var jsonEnvioDocumento = await _client.PostAsJsonAsync(apiMetodo, enviarDocumentoRequest);

                RespuestaComunConArchivo respuestaEnvio;
                respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarResumenResponse>();
                var rpta = (EnviarResumenResponse)respuestaEnvio;
                txtResult.Text = txtResult.Text + "\n" + $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.NroTicket}{Environment.NewLine}";

                if (!respuestaEnvio.Exito)
                    throw new ApplicationException(respuestaEnvio.MensajeError);

                if (chkVoz.Checked)
                    Hablar();

            }
            catch (Exception ex)
            {
                txtResult.Text = txtResult.Text + Environment.NewLine + ex.Message;
                if (chkVoz.Checked)
                    Hablar();

            }
        }

        #endregion Generacion XML

        #region Metodos Privados

        private DataTable DetalleArticulos(DataTable dt, int iii)
        {
            DataTable dtx = new DataTable();
            try
            {
                string vEmpresa = Convert.ToString(dt.Rows[iii]["EmpresaCodigo"]);
                string vNroDoc = Convert.ToString(dt.Rows[iii]["documentoselectronicos_id"]);
                string vCorrelDoc = Convert.ToString(dt.Rows[iii]["DocumentosElectronicosCorrel"]);

                SQL = " SELECT Productodescripcion,ProductoServicios,PorcentajeIgv,UnidadMedida_Id,b.*, c.* FROM ";
                SQL += " dbo.FE_DocumentosElectronicosCab a INNER join .dbo.FE_DocumentosElectronicosDet b ON a.empresacodigo = b.empresacodigo ";
                SQL += " AND a.documentoselectronicos_id = b.documentoselectronicos_id INNER join .dbo.FE_DocumentosElectronicosDetItem c ";
                SQL += " ON b.empresacodigo = c.empresacodigo AND b.documentoselectronicos_id = c.documentoselectronicos_id AND b.DocumentosElectronicosCorrel=c.DocumentosElectronicosCorrel ";
                SQL += " LEFT join .dbo.FE_Productos d ON c.empresacodigo= d.empresacodigo AND c.ProductoCodigo= d.ProductoCodigo ";
                SQL += " WHERE a.empresacodigo='" + vEmpresa + "' AND fechadocumento ='" + DtpFecha.Text + "' AND b.documentoselectronicos_id=" + vNroDoc + " AND b.DocumentosElectronicosCorrel=" + vCorrelDoc + "";

                dtx = ConsultarTabla(SQL, VGCnxSqlE);
                return dtx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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
                if (Convert.ToDecimal(DtArticulos.Rows[i]["Productocantidad"]) == 0)
                {
                    vPrecioUnitario = Convert.ToDecimal(DtArticulos.Rows[i]["Preciovta"]);
                }
                else
                {
                    vPrecioUnitario = Convert.ToDecimal(DtArticulos.Rows[i]["Preciovta"]);
                }

                DetalleDocumento detalle = new DetalleDocumento();

                detalle.Id = Convert.ToInt32(i + 1);
                detalle.Cantidad = Convert.ToDecimal(DtArticulos.Rows[i]["Productocantidad"]);
                detalle.PrecioReferencial = vPrecioUnitario;
                detalle.PrecioUnitario = vPrecioUnitario;
                detalle.TipoPrecio = Convert.ToString(DtArticulos.Rows[i]["TipodePrecio"]);
                detalle.CodigoItem = Convert.ToString(DtArticulos.Rows[i]["ProductoCodigo"]);
                detalle.Descripcion = Convert.ToString(DtArticulos.Rows[i]["Productodescripcion"]);
                detalle.UnidadMedida = "NIU";
                detalle.Impuesto = Convert.ToDecimal(DtArticulos.Rows[i]["ItemIgv"]);
                detalle.TipoImpuesto = Convert.ToString(DtArticulos.Rows[i]["TipodeImpuesto"]);
                detalle.ImpuestoSelectivo = Convert.ToDecimal(DtArticulos.Rows[i]["itemIsc"]);
                detalle.TotalVenta = Convert.ToDecimal(DtArticulos.Rows[i]["ItemVenta"]);
                detalle.Suma = Convert.ToDecimal(DtArticulos.Rows[i]["ItemVenta"]);

                return detalle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        #endregion Metodos Privados


        private void FrmEnviarSunat_Load(object sender, EventArgs e)
        {
                       String SQL = "";
            SQL = "SELECT  * FROM [dbo].v_FE_DatosGeneralesEmpresas WHERE Empresacodigo='001'";
            DtEmpresa = ConsultarTabla(SQL, VGCnxSqlE);
            LblEmpresaCodigo.Text = Convert.ToString(DtEmpresa.Rows[0]["Empresacodigo"]);
            LblEmpresaDescripcion.Text = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRazonsocial"]);

        }

        private async void btnGetStatus_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNroTicket.Text)) return;
                var consultaTicketRequest = new ConsultaTicketRequest
                {
                    Ruc = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]),
                    UsuarioSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaUsuarioSol"]),
                    ClaveSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaClaveSol"]),
                    EndPointUrl = ValorSeleccionado(),
                    IdDocumento = "RC-20170908-001.xml",
                    NroTicket = txtNroTicket.Text
                };

                var jsonConsultaTicket = await _client.PostAsJsonAsync("api/ConsultarTicket", consultaTicketRequest);
                var respuestaEnvio = await jsonConsultaTicket.Content.ReadAsAsync<EnviarDocumentoResponse>();

                if (!respuestaEnvio.Exito || !string.IsNullOrEmpty(respuestaEnvio.MensajeError))
                    throw new InvalidOperationException(respuestaEnvio.MensajeError);

                File.WriteAllBytes($"{Program.CarpetaCdr}\\R-{respuestaEnvio.NombreArchivo}.zip",
                    Convert.FromBase64String(respuestaEnvio.TramaZipCdr));

                txtResult.Text = $@"{Resources.procesoCorrecto}{Environment.NewLine}{respuestaEnvio.MensajeRespuesta}";

                Hablar();
            }
            catch (Exception ex)
            {
                txtResult.Text += ex.Message + Environment.NewLine;
            }

        }

        private void BntGeneraXml_Click(object sender, EventArgs e)
        {
            switch (cboTipoDoc.SelectedIndex)
            {
                case 0:
                    CodigoTipoDoc = "01";
                    break;

                case 1:
                    CodigoTipoDoc = "02";
                    break;

                case 2:
                    CodigoTipoDoc = "07";
                    break;

                case 3:
                    CodigoTipoDoc = "08";
                    break;

                case 6:
                    CodigoTipoDoc = "RC";
                    break;

                case 7:
                    CodigoTipoDoc = "RA";
                    break;

                default:
                    CodigoTipoDoc = "01";
                    break;
            }

            SQL = " SELECT Establecimiento_id,Fechadocumento,b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01',1) ";
            SQL += " FROM dbo.FE_DocumentosElectronicosCab a ";
            SQL = SQL + "  INNER join FE_DocumentosElectronicosDet b ON a.empresacodigo = b.empresacodigo ";
            SQL = SQL + " AND a.documentoselectronicos_id = b.documentoselectronicos_id ";
            SQL = SQL + " WHERE a.Empresacodigo='" + LblEmpresaCodigo.Text + "' AND fechadocumento = '" + DtpFecha.Text + "'";

            if (CodigoTipoDoc == "RA")
            {
                SQL += "AND TipoDocumentoModifica='" + CodigoTipoDoc + "'";
            }
            else
                if (CodigoTipoDoc == "RC")
            {
                SQL += "AND TipoDocumentoModifica='" + CodigoTipoDoc + "'";
            }
            else
            {
                SQL += "AND TipoDocumento='" + CodigoTipoDoc + "'";
            }

            SQL += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 ";

            DtDocumentos = ConsultarTabla(SQL, VGCnxSqlE);
            DgvConsulta.DataSource = DtDocumentos;

            txtResult.Text = "";
            //     txtResult.Text = "Proceso de generacion de factura/boletas XML "+"\n";
            try
            {
                switch (CodigoTipoDoc)
                {
                    case "RA":
                        CrearXmlBajas();
                        break;

                    case "RC":
                        CrearXmlResumen();
                        break;

                    default:
                  
                        for (int ii = 0; ii <= DtDocumentos.Rows.Count - 1; ii++)
                        {
                            CrearXmlFact(ii);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = "";
                if (cboTipoDoc.SelectedIndex == 6)
                {
                    CrearResumen();
                }
                else
                if (cboTipoDoc.SelectedIndex == 7)
                {
                    CrearBajas();
                }
                else
                {
                    for (int ii = 0; ii <= DtDocumentos.Rows.Count - 1; ii++)
                    {
                        CrearFacturas(ii);
                    }
                }
            }
            catch
            {
            }

        }

    }
}