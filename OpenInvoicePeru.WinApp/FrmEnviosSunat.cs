﻿using Class;
using OpenInvoicePeru.Comun.Dto.Intercambio;
using OpenInvoicePeru.Comun.Dto.Modelos;
using OpenInvoicePeru.WinApp.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OpenInvoicePeru.WinApp
{
    public partial class FrmEnviosSunat : Form
    {
        #region Variables Privadas

        public DataTable DtEmpresa;
        public DataTable DtDocumentos;
        public DataTable DtArticulos;
        public DataTable DtAceptados;

        public readonly HttpClient _client;
        public string vRutaArchivoXML;
        public string vRutaXml = "";
        public string vRutaCdr = "";
        public Int32 vRegistros = 0;

        private ModFunciones ModFunc = new ModFunciones();

        private const string FormatoFecha = "yyyy-MM-dd";

        // geresa
        //  private string VGCnxSqlE = "Server=190.119.219.134;database=facturaselectronicas;User ID=diresa;Password=12345";

        // iren
        //  string VGCnxSqlE = "Server=172.16.44.38;database=iren;User ID=sa;Password=12345";
        //  private string VGCnxSqlE = "Server=(local)  ;database=iren;User ID=sa;Password=12345";

        // Cesaris
        //   private string VGCnxSqlE = "Server=servidor;database=facturaselectronicas;User ID=sa;Password=12345";

        // local
        //      private string VGCnxSqlE = "Server=(local);database=cesarisfe;User ID=sa;Password=12345";

        //   private string VGCnxSqlE = "Server=jck;database=facturaselectronicas;User ID=sa;Password=12345";

        //private string VGCnxSqlE = "Server=servidor;database=facturaselectronicas;User ID=sa;Password=Aa12345";
        private string VGCnxSqlE = Settings.Default.CadenaConexion;

        public string vFechaXml;
        public string vUrlSunat = "";
        public string vTipoDoc = "";
        public int vtipoEnvio = 0;
        public string SQL = "";
        public int vMaximoIItem = 400;

        #endregion Variables Privadas

        #region Constructor

        public FrmEnviosSunat()
        {
            InitializeComponent();

            _client = new HttpClient { BaseAddress = new Uri(ConfigurationManager.AppSettings["UrlOpenInvoicePeruApi"]) };

            Load += (s, e) =>
            {
                try
                {
                    DataTable Dtx;
                    Cursor.Current = Cursors.WaitCursor;
                    Ctr_AyuUrlDoc.CadenaCone = VGCnxSqlE;
                    Ctr_AyuDocumento.CadenaCone = VGCnxSqlE;
                    Ctr_AyuEmpresas.CadenaCone = VGCnxSqlE;

                    Ctr_AyuEmpresas.Filtro = " EstadoAnulado=0 ";
                    SQL = " Select * from FeEmpresas where " + Ctr_AyuEmpresas.Filtro;
                    Dtx = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
                    if (Dtx.Rows.Count == 1)
                    {
                        Ctr_AyuEmpresas.Codigo = Convert.ToString(Dtx.Rows[0]["id"]);
                        Ctr_AyuEmpresas.EjecAyuda();
                    }

                    Ctr_AyuUrlDoc.Filtro = " EstadoAnulado=0 ";
                    SQL = " Select * from FeDireccionesSunat where " + Ctr_AyuUrlDoc.Filtro;
                    Dtx = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
                    if (Dtx.Rows.Count == 1)
                    {
                        Ctr_AyuUrlDoc.Codigo = Convert.ToString(Dtx.Rows[0]["DireccionSunatID"]);
                        Ctr_AyuUrlDoc.EjecAyuda();
                    }

                    Ctr_AyuDocumento.Filtro = " EstadoAnulado=0 ";
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

        #endregion Constructor

        #region CrearDocumentos

        private async void CrearFacturas(int ii)
        {
            string idDoc = Convert.ToString(DtDocumentos.Rows[ii]["Seriedocumento"] + "-" + DtDocumentos.Rows[ii]["NumeroDocumento"]);

            vRutaArchivoXML = Path.Combine(vRutaXml, $"{idDoc}.xml");

            if (string.IsNullOrEmpty(idDoc))
                throw new InvalidOperationException("La Serie y el Correlativo no pueden estar vacíos");

            var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(vRutaArchivoXML));
            String vRutaCertificado = Convert.ToString(DtEmpresa.Rows[0]["CarpetaCertificadoDigital"]) +
                                                    Convert.ToString(DtEmpresa.Rows[0]["NombreCertificadoDigital"]);
            try
            {
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

                File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                ReemplaCaracteres(Convert.ToString(vRutaArchivoXML));

                var TramaXML = Convert.ToBase64String(File.ReadAllBytes(vRutaArchivoXML));

                var enviarDocumentoRequest = new EnviarDocumentoRequest
                {
                    Ruc = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]),
                    UsuarioSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaUsuarioSol"]),
                    ClaveSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaClaveSol"]),
                    EndPointUrl = vUrlSunat,
                    IdDocumento = idDoc,
                    TipoDocumento = vTipoDoc,
                    //   TramaXmlFirmado = respuestaFirmado.TramaXmlFirmado
                    TramaXmlFirmado = TramaXML
                };

                var apiMetodo = "api/EnviarDocumento";
                var jsonEnvioDocumento = await _client.PostAsJsonAsync(apiMetodo, enviarDocumentoRequest);

                RespuestaComunConArchivo respuestaEnvio;
                if (!rbResumen.Checked)
                {
                    respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarDocumentoResponse>();
                    var rpta = (EnviarDocumentoResponse)respuestaEnvio;
                    txtResult.Text = txtResult.Text + idDoc + " " + $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.MensajeRespuesta} siendo las {DateTime.Now}{Environment.NewLine}";
                    try
                    {
                        if (rpta.Exito && !string.IsNullOrEmpty(rpta.TramaZipCdr))
                        {
                            vRutaArchivoXML = $"{respuestaEnvio.NombreArchivo}";
                            vRutaArchivoXML = Path.Combine(vRutaCdr, vRutaArchivoXML);

                            File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                            vRutaArchivoXML = "R-" + $"{respuestaEnvio.NombreArchivo}";
                            vRutaArchivoXML = Path.Combine(vRutaCdr, vRutaArchivoXML);

                            File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(rpta.TramaZipCdr));
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
                    txtResult.Text = txtResult.Text + $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.NroTicket}{Environment.NewLine}";
                }

                if (!respuestaEnvio.Exito)
                    throw new ApplicationException(respuestaEnvio.MensajeError);

                // if (chkVoz.Checked)
                //   Hablar();
            }
            catch (Exception ex)
            {
                txtResult.Text = txtResult.Text + ex.Message + Environment.NewLine;
                // if (chkVoz.Checked)
                //   Hablar();
            }
        }

        private async void CrearResumen()
        {
            try
            {
                if (string.IsNullOrEmpty(vFechaXml))
                    throw new InvalidOperationException("La Serie y el Correlativo no pueden estar vacíos");

                var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(vRutaArchivoXML));
                String vRutaCertificado = Convert.ToString(DtEmpresa.Rows[0]["CarpetaCertificadoDigital"]) +
                                                        Convert.ToString(DtEmpresa.Rows[0]["NombreCertificadoDigital"]);
                string vCertificado = Convert.ToBase64String(File.ReadAllBytes(vRutaCertificado));
                string vPassword = Convert.ToString(DtEmpresa.Rows[0]["PasswCertificadoDigital"]);

                var firmadoRequest = new FirmadoRequest
                {
                    TramaXmlSinFirma = tramaXmlSinFirma,
                    CertificadoDigital = vCertificado,
                    PasswordCertificado = vPassword,
                    UnSoloNodoExtension = true
                };

                var jsonFirmado = await _client.PostAsJsonAsync("api/Firmar", firmadoRequest);
                var respuestaFirmado = await jsonFirmado.Content.ReadAsAsync<FirmadoResponse>();

                File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                ReemplaCaracteres(Convert.ToString(vRutaArchivoXML));

                if (!respuestaFirmado.Exito)
                    throw new ApplicationException(respuestaFirmado.MensajeError);

                var TramaXML = Convert.ToBase64String(File.ReadAllBytes(vRutaArchivoXML));

                var enviarDocumentoRequest = new EnviarDocumentoRequest
                {
                    Ruc = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]),
                    UsuarioSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaUsuarioSol"]),
                    ClaveSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaClaveSol"]),
                    EndPointUrl = vUrlSunat,
                    IdDocumento = vFechaXml,
                    TipoDocumento = vTipoDoc,
                    TramaXmlFirmado = TramaXML  // respuestaFirmado.TramaXmlFirmado
                };

                var apiMetodo = "api/EnviarResumen";
                var jsonEnvioDocumento = await _client.PostAsJsonAsync(apiMetodo, enviarDocumentoRequest);

                RespuestaComunConArchivo respuestaEnvio;
                respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarResumenResponse>();
                var rpta = (EnviarResumenResponse)respuestaEnvio;

                txtResult.Text = txtResult.Text + "  " + $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.NroTicket}{Environment.NewLine}";
                txtNroTicket.Text = rpta.NroTicket;
                TxtXml.Text = vRutaArchivoXML;

                if (!string.IsNullOrEmpty(txtNroTicket.Text))
                {
                    ActualizaNroTicket();
                }

                if (!respuestaEnvio.Exito)
                    throw new ApplicationException(respuestaEnvio.MensajeError);

                if (chkVoz.Checked)
                    Hablar();
            }
            catch (Exception ex)
            {
                txtResult.Text = txtResult.Text + Environment.NewLine + ex.Message;
                // if (chkVoz.Checked)
                //     Hablar();
            }
        }

        private async void CrearBajas()
        {
            try
            {
                if (string.IsNullOrEmpty(vFechaXml))
                    throw new InvalidOperationException("La Serie y el Correlativo no pueden estar vacíos");

                var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(vRutaArchivoXML));
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

                File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                ReemplaCaracteres(Convert.ToString(vRutaArchivoXML));

                if (!respuestaFirmado.Exito)
                    throw new ApplicationException(respuestaFirmado.MensajeError);

                var TramaXML = Convert.ToBase64String(File.ReadAllBytes(vRutaArchivoXML));

                var enviarDocumentoRequest = new EnviarDocumentoRequest
                {
                    Ruc = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]),
                    UsuarioSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaUsuarioSol"]),
                    ClaveSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaClaveSol"]),
                    EndPointUrl = vUrlSunat,
                    IdDocumento = vFechaXml,
                    TipoDocumento = vTipoDoc,
                    TramaXmlFirmado = TramaXML
                };

                var apiMetodo = "api/EnviarResumen";
                var jsonEnvioDocumento = await _client.PostAsJsonAsync(apiMetodo, enviarDocumentoRequest);

                RespuestaComunConArchivo respuestaEnvio;
                respuestaEnvio = await jsonEnvioDocumento.Content.ReadAsAsync<EnviarResumenResponse>();
                var rpta = (EnviarResumenResponse)respuestaEnvio;
                txtResult.Text = txtResult.Text + "\n" + $@"{Resources.procesoCorrecto}{Environment.NewLine}{rpta.NroTicket}{Environment.NewLine}";

                if (!respuestaEnvio.Exito)
                    throw new ApplicationException(respuestaEnvio.MensajeError);

                if (!string.IsNullOrEmpty(rpta.NroTicket))
                {
                    ActualizaNroTicket();
                }

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

        #endregion CrearDocumentos

        #region Generacion XML

        private async void CrearXmlFact(int ii)
        {
            try
            {
                string idDoc = Convert.ToString(DtDocumentos.Rows[ii]["Seriedocumento"] + "-" +
                                                 DtDocumentos.Rows[ii]["NumeroDocumento"]);
                string vletras = Convert.ToString(DtDocumentos.Rows[ii]["letras"]);

                decimal vDscto = 0;
                string vNroDocumento = Convert.ToString(DtDocumentos.Rows[ii]["clienteID"]);
                string vTipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["IdentidadID"]);
                string vNombreLegal = Convert.ToString(DtDocumentos.Rows[ii]["ClienterazonSocial"]);

                string vNombre = Convert.ToString(DtDocumentos.Rows[ii]["nombre"]);
                string vNemoTecnico = Convert.ToString(DtDocumentos.Rows[ii]["nombre"]);
                string vCodigo = Convert.ToString(DtDocumentos.Rows[ii]["codigo"]);
                string vId = Convert.ToString(DtDocumentos.Rows[ii]["Id"]);

                DocumentoElectronico _xDocumento = new DocumentoElectronico
                {
                    Emisor = CrearEmisor(DtEmpresa),
                    Receptor = new Contribuyente
                    {
                        NroDocumento = vNroDocumento,
                        TipoDocumento = vTipoDocumento,
                        NombreLegal = vNombreLegal,
                    },
                };
                _xDocumento.IdDocumento = idDoc;
                _xDocumento.FechaEmision = DtpFechaDoc.Value.ToString(FormatoFecha);
                _xDocumento.Moneda = "PEN";
                _xDocumento.MontoEnLetras = vletras;
                _xDocumento.CalculoIgv = 18m;
                _xDocumento.CalculoIsc = Convert.ToDecimal(DtDocumentos.Rows[ii]["porcentajeIsc"]);
                _xDocumento.CalculoDetraccion = 0.00m;
                _xDocumento.TipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["documentoID"]);
                _xDocumento.TotalGravadas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGravado"]);
                _xDocumento.TotalInafectas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteinafecto"]);
                _xDocumento.TotalExoneradas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteexonerado"]);
                _xDocumento.TotalGratuitas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGratuitas"]);
                _xDocumento.TotalOtrosTributos = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteOtros"]);
                _xDocumento.TotalIsc = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteisc"]);
                _xDocumento.TotalIgv = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteIgv"]);
                _xDocumento.DescuentoGlobal = vDscto;
                _xDocumento.TotalVenta = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteventa"]);
                _xDocumento.Items = new List<DetalleDocumento>();

                // nuevo 2.1
                _xDocumento.PorcentajeIgv = Convert.ToDecimal(DtDocumentos.Rows[ii]["PorcentajeIgv"]);
                _xDocumento.FechaRegistro = DtpFechaDoc.Value.ToString(FormatoFecha);
                _xDocumento.AnexoSunat = Convert.ToString(DtDocumentos.Rows[ii]["AnexoSunat"]);
                _xDocumento.NroPedido = Convert.ToString(DtDocumentos.Rows[ii]["pedidonumero"]);

                DtArticulos = DetalleArticulos(DtDocumentos, ii);
                _xDocumento.TotItem = DtArticulos.Rows.Count;
                for (int i3 = 0; i3 <= DtArticulos.Rows.Count - 1; i3++)
                {
                    _xDocumento.Items.Add(DetalleItem(DtArticulos, i3));
                }

                string vNroDocumentoModifica = Convert.ToString(DtDocumentos.Rows[ii]["SeriedocumentoModifica"]) + "-" + Convert.ToString(DtDocumentos.Rows[ii]["NumeroDocumentoModifica"]);
                string vTipoDoc = Convert.ToString(DtDocumentos.Rows[ii]["DocumentoID"]);

                if (vTipoDoc == "07" || vTipoDoc == "08")
                {
                    // nota de credito
                    var vRelacionado = new OpenInvoicePeru.Comun.Dto.Modelos.DocumentoRelacionado
                    {
                        TipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["TipoDocumentoModifica"]),
                        NroDocumento = vNroDocumentoModifica
                    };
                    _xDocumento.Relacionados.Add(vRelacionado);

                    // nota de debito
                    var vDiscrepancia = new OpenInvoicePeru.Comun.Dto.Modelos.Discrepancia
                    {
                        Tipo = Convert.ToString(DtDocumentos.Rows[ii]["TipodocumentoModifica"]),
                        NroReferencia = vNroDocumentoModifica,
                        Descripcion = Convert.ToString(DtDocumentos.Rows[ii]["DescripcionMotivoNota"])
                    };
                    _xDocumento.Discrepancias.Add(vDiscrepancia);
                }
                string _metodoApi = "";
                switch (vTipoDoc)
                {
                    case "07":
                        _metodoApi = "api/GenerarNotaCredito";
                        break;

                    case "08":
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

                //        String vRutaXml = Convert.ToString(DtEmpresa.Rows[0]["CarpetaEnviosXml"]);
                vRutaArchivoXML = Path.Combine(vRutaXml, $"{_xDocumento.IdDocumento}.xml");

                File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(respuesta.TramaXmlSinFirma));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtResult.Text = txtResult.Text + ex.Message + Environment.NewLine;
            }
        }

        private async void CrearXmlBajas()
        {
            try
            {
                vFechaXml = "RA-" + Convert.ToString(DtpFechaEnvioDoc.Value.Year);
                vFechaXml += ModFunc.Derecha("0" + Convert.ToString(DtpFechaEnvioDoc.Value.Month), 2);
                vFechaXml += ModFunc.Derecha("0" + Convert.ToString(DtpFechaEnvioDoc.Value.Day), 2);
                vFechaXml += "-012";

                OpenInvoicePeru.Comun.Dto.Modelos.ComunicacionBaja ComunicacionBaja = new Comun.Dto.Modelos.ComunicacionBaja
                {
                    IdDocumento = vFechaXml,
                    FechaEmision = DtpFechaEnvioDoc.Value.ToString(FormatoFecha),
                    FechaReferencia = DtpFechaEnvioDoc.Value.ToString(FormatoFecha),
                    Emisor = CrearEmisor(DtEmpresa),
                    Bajas = new List<OpenInvoicePeru.Comun.Dto.Modelos.DocumentoBaja>()
                };

                for (int i3 = 0; i3 <= DtDocumentos.Rows.Count - 1; i3++)
                {
                    OpenInvoicePeru.Comun.Dto.Modelos.DocumentoBaja DocumentoBajasItem = new OpenInvoicePeru.Comun.Dto.Modelos.DocumentoBaja
                    {
                        Id = i3 + 1,
                        Correlativo = Convert.ToString(DtDocumentos.Rows[i3]["NumeroDocumento"]),
                        TipoDocumento = Convert.ToString(DtDocumentos.Rows[i3]["TipoDocumento"]),
                        Serie = Convert.ToString(DtDocumentos.Rows[i3]["SerieDocumento"]),
                        MotivoBaja = "Anulación por otro tipo de documento"
                    };

                    ComunicacionBaja.Bajas.Add(DocumentoBajasItem);
                }

                string _metodoApi = "api/GenerarComunicacionBaja";
                var response = await _client.PostAsJsonAsync(_metodoApi, ComunicacionBaja);

                var respuesta = await response.Content.ReadAsAsync<DocumentoResponse>();

                if (!respuesta.Exito)
                    throw new ApplicationException(respuesta.MensajeError);

                vRutaArchivoXML = ComunicacionBaja.IdDocumento;
                vRutaArchivoXML = Path.Combine(vRutaXml, $"{vRutaArchivoXML}.xml");

                File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(respuesta.TramaXmlSinFirma));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void CrearXmlResumen1()
        {
            try
            {
                vFechaXml = "RC-" + Convert.ToString(DtpFechaEnvioDoc.Value.Year);
                vFechaXml += ModFunc.Derecha("0" + Convert.ToString(DtpFechaEnvioDoc.Value.Month), 2);
                vFechaXml += ModFunc.Derecha("0" + Convert.ToString(DtpFechaEnvioDoc.Value.Day), 2);
                vFechaXml += "-00" + Convert.ToString(DtDocumentos.Rows[0]["item"]);

                Comun.Dto.Modelos.ResumenDiario ResumenDiario = new Comun.Dto.Modelos.ResumenDiario
                {
                    IdDocumento = vFechaXml,
                    //       ResumenDiario.IdDocumento = TxtRuc.Text;
                    FechaEmision = Convert.ToString(DtpFechaEnvioDoc.Text),
                    FechaReferencia = Convert.ToString(DtpFechaDoc.Text),
                    Emisor = CrearEmisor(DtEmpresa),

                    Resumenes = new List<GrupoResumen>()
                };

                for (int ii = 0; ii <= DtDocumentos.Rows.Count - 1; ii++)
                {
                    decimal vDscto = 0;

                    GrupoResumen DocumentoResumenItem = new GrupoResumen();

                    string vIdDocumento = DocumentoResumenItem.Serie = Convert.ToString(DtDocumentos.Rows[ii]["SerieDocumento"]) + "-";
                    vIdDocumento += DtDocumentos.Rows[ii]["NumeroDocumento"];

                    DocumentoResumenItem.Id = ii + 1;
                    DocumentoResumenItem.TipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["TipoDocumento"]);
                    DocumentoResumenItem.Serie = Convert.ToString(DtDocumentos.Rows[ii]["serieDocumento"]);
                    DocumentoResumenItem.CorrelativoInicio = Convert.ToInt32(DtDocumentos.Rows[ii]["numeroDocumento"]);
                    DocumentoResumenItem.CorrelativoFin = Convert.ToInt32(DtDocumentos.Rows[ii]["numeroDocumentofinal"]);
                    DocumentoResumenItem.Moneda = "PEN";

                    DocumentoResumenItem.Gravadas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGravado"]);
                    DocumentoResumenItem.Inafectas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteinafecto"]);
                    DocumentoResumenItem.Exoneradas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteexonerado"]);
                    DocumentoResumenItem.TotalIgv = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteIgv"]);
                    DocumentoResumenItem.TotalDescuentos = vDscto;
                    DocumentoResumenItem.TotalIsc = 0;
                    DocumentoResumenItem.Gratuitas = 0;
                    DocumentoResumenItem.TotalVenta = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteventa"]);

                    ResumenDiario.Resumenes.Add(DocumentoResumenItem);
                }
                string _metodoApi = "api/GenerarResumenDiario/v1";
                var response = await _client.PostAsJsonAsync(_metodoApi, ResumenDiario);

                var respuesta = await response.Content.ReadAsAsync<DocumentoResponse>();

                if (!respuesta.Exito)
                    throw new ApplicationException(respuesta.MensajeError);

                vRutaArchivoXML = vFechaXml;
                vRutaArchivoXML = Path.Combine(vRutaXml, $"{vRutaArchivoXML}.xml");

                File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(respuesta.TramaXmlSinFirma));
                ModFunc.ActualizaItemDia(Ctr_AyuEmpresas.Codigo, DtpFechaDoc.Text, VGCnxSqlE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void CrearXmlResumen2()
        {
            try
            {
                vFechaXml = "RC-" + Convert.ToString(DtpFechaEnvioDoc.Value.Year);
                vFechaXml += ModFunc.Derecha("0" + Convert.ToString(DtpFechaEnvioDoc.Value.Month), 2);
                vFechaXml += ModFunc.Derecha("0" + Convert.ToString(DtpFechaEnvioDoc.Value.Day), 2);
                vFechaXml += "-00" + Convert.ToString(DtDocumentos.Rows[0]["item"]);

                ResumenDiarioNuevo ResumenDiario = new ResumenDiarioNuevo
                {
                    IdDocumento = vFechaXml,
                    FechaEmision = Convert.ToString(DtpFechaEnvioDoc.Text),
                    FechaReferencia = Convert.ToString(DtpFechaDoc.Text),
                    Emisor = CrearEmisor(DtEmpresa),

                    Resumenes = new List<GrupoResumenNuevo>()
                };

                for (int ii = 0; ii <= DtDocumentos.Rows.Count - 1; ii++)
                {
                    decimal vDscto = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteDsctoGlobal"]);
                    string vNroDocumento = Convert.ToString(DtDocumentos.Rows[ii]["clienteID"]);
                    string vTipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["IdentidadID"]);
                    string vNombreLegal = Convert.ToString(DtDocumentos.Rows[ii]["ClienterazonSocial"]);

                    GrupoResumenNuevo DocumentoResumenItem = new GrupoResumenNuevo();
                    string vIdDocumento = DocumentoResumenItem.Serie = Convert.ToString(DtDocumentos.Rows[ii]["SerieDocumento"]) + "-";
                    vIdDocumento += DtDocumentos.Rows[ii]["NumeroDocumento"];

                    DocumentoResumenItem.Id = ii + 1;
                    DocumentoResumenItem.TipoDocumento = Convert.ToString(DtDocumentos.Rows[ii]["DocumentoID"]);
                    DocumentoResumenItem.IdDocumento = vIdDocumento;
                    DocumentoResumenItem.NroDocumentoReceptor = vNroDocumento;
                    DocumentoResumenItem.TipoDocumentoReceptor = vTipoDocumento;
                    DocumentoResumenItem.CodigoEstadoItem = 1;

                    string vNroModifica = Convert.ToString(DtDocumentos.Rows[ii]["SeriedocumentoModifica"]) + "-" + Convert.ToString(DtDocumentos.Rows[ii]["NumeroDocumentoModifica"]);
                    if (DocumentoResumenItem.TipoDocumento == "07" || DocumentoResumenItem.TipoDocumento == "08")
                    {
                        DocumentoResumenItem.TipoDocumentoRelacionado = Convert.ToString(DtDocumentos.Rows[ii]["TipoDocumentoModifica"]);
                        DocumentoResumenItem.DocumentoRelacionado = vNroModifica;
                    }

                    DocumentoResumenItem.Moneda = "PEN";

                    DocumentoResumenItem.Gravadas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGravado"]);
                    DocumentoResumenItem.Inafectas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteinafecto"]);
                    DocumentoResumenItem.Exoneradas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteexonerado"]);
                    DocumentoResumenItem.Gratuitas = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteGratuitas"]);
                    DocumentoResumenItem.TotalIsc = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteisc"]);
                    DocumentoResumenItem.TotalIgv = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteIgv"]);
                    DocumentoResumenItem.TotalDescuentos = vDscto;
                    DocumentoResumenItem.TotalVenta = Convert.ToDecimal(DtDocumentos.Rows[ii]["TotalImporteventa"]);
                    DocumentoResumenItem.TotalOtrosImpuestos = 0;
                    DocumentoResumenItem.CodigoEstadoItem = 1;
                    DocumentoResumenItem.Exportacion = 0;

                    ResumenDiario.Resumenes.Add(DocumentoResumenItem);
                }
                string _metodoApi = "api/GenerarResumenDiario/v2";
                var response = await _client.PostAsJsonAsync(_metodoApi, ResumenDiario);

                var respuesta = await response.Content.ReadAsAsync<DocumentoResponse>();

                if (!respuesta.Exito)
                    throw new ApplicationException(respuesta.MensajeError);

                vRutaArchivoXML = vFechaXml;
                vRutaArchivoXML = Path.Combine(vRutaXml, $"{vRutaArchivoXML}.xml");

                File.WriteAllBytes(vRutaArchivoXML, Convert.FromBase64String(respuesta.TramaXmlSinFirma));
                ModFunc.ActualizaItemDia(Ctr_AyuEmpresas.Codigo, DtpFechaDoc.Text, VGCnxSqlE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Generacion XML

        #region Metodos Privados

        private DataTable DetalleArticulos(DataTable dt, int iii)
        {
            DataTable dtx = new DataTable();
            try
            {
                string vEmpresa = Convert.ToString(dt.Rows[iii]["EmpresaID"]);
                string vNroDoc = Convert.ToString(dt.Rows[iii]["documentoselectronicosCabid"]);
                string vCorrelDoc = Convert.ToString(dt.Rows[iii]["ID"]);



                SQL = " SELECT ProductodescripcionP=isnull(d.ProductoDescripcion,''''),Producto,UnidadMedidaId,b.*, c.* FROM ";
                SQL += " dbo.FE_DocumentosElectronicosCab a INNER join .dbo.FE_DocumentosElectronicosDet b ON a.ID = b.documentoselectronicoscabID ";
                SQL += " INNER join .dbo.FE_DocumentosElectronicosDetItem c ON b.ID  = c.documentoselectronicosDetID ";
                SQL += " LEFT join .dbo.FE_Productos d ON c.ProductoID= d.ID ";
                SQL += " WHERE a.empresaID='" + vEmpresa + "' AND fechadocumento ='" + DtpFechaDoc.Text + "' AND c.documentoselectronicosDetID=" + vCorrelDoc + "";

                dtx = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
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
                Contribuyente Dtx = new Contribuyente
                {
                    NroDocumento = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRuc"]),
                    TipoDocumento = "6",
                    Direccion = Convert.ToString(DtEmpresa.Rows[0]["EmpresaDIRECCION"]),
                    Urbanizacion = Convert.ToString(DtEmpresa.Rows[0]["Empresaurbanizacion"]),
                    Departamento = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRegion"]),
                    Provincia = Convert.ToString(DtEmpresa.Rows[0]["EmpresaProvincia"]),
                    Distrito = Convert.ToString(DtEmpresa.Rows[0]["Empresadistrito"]),
                    NombreComercial = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRazonComercial"]),
                    NombreLegal = Convert.ToString(DtEmpresa.Rows[0]["EmpresaRazonSocial"]),
                    Ubigeo = Convert.ToString(DtEmpresa.Rows[0]["Ubigeo_id"])
                };
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
                string vDescripcion = "";
                if (Convert.ToString(DtArticulos.Rows[i]["Productodescripcion"]) != "")
                {
                    vDescripcion = Convert.ToString(DtArticulos.Rows[i]["Productodescripcion"]);
                }
                else
                {
                    vDescripcion = "DIESEL B5";
                }

                DetalleDocumento detalle = new DetalleDocumento
                {
                    Id = Convert.ToInt32(i + 1),
                    Cantidad = Convert.ToDecimal(DtArticulos.Rows[i]["Productocantidad"]),
                    PrecioReferencial = vPrecioUnitario,
                    PrecioUnitario = vPrecioUnitario,
                    TipoPrecio = Convert.ToString(DtArticulos.Rows[i]["TipodePrecioID"]),
                    CodigoItem = Convert.ToString(DtArticulos.Rows[i]["Producto"]),
                    Descripcion = vDescripcion,
                    UnidadMedida = "NIU",
                    Impuesto = Convert.ToDecimal(DtArticulos.Rows[i]["ItemIgv"]),
                    TipoImpuesto = Convert.ToString(DtArticulos.Rows[i]["TipodeImpuestoID"]),
                    ImpuestoSelectivo = Convert.ToDecimal(DtArticulos.Rows[i]["itemIsc"]),
                    OtroImpuesto = 0,
                    ItemGravado = Convert.ToDecimal(DtArticulos.Rows[i]["ItemGravado"]),
                    ItemVenta = Convert.ToDecimal(DtArticulos.Rows[i]["ItemVenta"]),
                    ItemSuma = Convert.ToDecimal(DtArticulos.Rows[i]["ItemVenta"])
                };

                return detalle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void ReemplaCaracteres(string file)
        {
            {
                StreamReader reader = new StreamReader(file);
                string content = reader.ReadToEnd();
                reader.Close();

                content = Regex.Replace(content, "�", "");
                content = Regex.Replace(content, "ú", "u");

                StreamWriter writer = new StreamWriter(file);
                writer.Write(content);
                writer.Close();
            }
        }

        public void LlenaCombo(ComboBox Combo, string dato, string cnn)
        {
            DataTable rsql = new DataTable();
            Combo.Items.Clear();
            rsql = ModFunc.ConsultarTabla(dato, VGCnxSqlE);
            if (rsql.Rows.Count > 0)
            {
                for (int i = 0; i <= rsql.Rows.Count - 1; i++)
                {
                    Combo.Items.Add(rsql.Rows[i][0].ToString() + "-" + rsql.Rows[i][1].ToString());
                }
                Combo.SelectedIndex = 0;
            }
        }

        private void GeneraAceptados()
        {
            try
            {
                SQL = " SELECT b.* FROM dbo.FeResumenDiarioDocumentosCab a ";
                SQL += " INNER JOIN dbo.FeResumenDiarioDocumentosDet b ON a.Id = b.ResumendiarioCabID  ";
                SQL += " WHERE a.EmpresaID='" + Ctr_AyuEmpresas.Codigo + "' AND fechadocumento = '" + DtpFechaDoc.Text + "'";
                SQL += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by Establecimientoid ";
                DtAceptados = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
            }
            catch
            {
            }
        }

        private void ActualizaNroTicket()
        {
            for (int i = 0; i <= DtDocumentos.Rows.Count - 1; i++)
            {
            }
        }

        #endregion Metodos Privados

        #region Botones

        private void BntGenera_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";

            SQL = " SELECT a.empresaID, a.Establecimientoid,Fechadocumento,b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01'),AnexoSunat,d.* ";
            SQL += " FROM dbo.FEDocumentosElectronicosCab a ";
            SQL = SQL + "  INNER join FeDocumentosElectronicosDet b ON a.ID = b.documentoselectronicoscabID ";
            SQL = SQL + "  INNER join FeEstablecimientos c ON a.establecimientoID = c.ID ";
            SQL += " inner join .dbo.FeAfectacionIgv d ON b.AfectacionIgv= d.Id  ";
            SQL = SQL + " WHERE a.EmpresaID='" + Ctr_AyuEmpresas.Codigo + "' AND fechadocumento = '" + DtpFechaDoc.Text + "'";

            if (vTipoDoc == "RC")
            {
                SQL = " SELECT  Item=IdentificadorEnvio+1,EstablecimientoID,Fechadocumento,grupo=b.GrupodeEnvioSunat, c.*,Letras=[dbo].fn_NumeroEnLetra(c.TotalImporteVenta,'01') ";
                SQL += " FROM dbo.FeResumenDiarioDocumentosCab a ";
                SQL += " INNER JOIN dbo.FeResumenDiarioDocumentosDet b ON a.ID = b.ResumendiarioCabID  ";
                SQL += " INNER join FeResumenDiarioDocumentosDetItem c ON b.ID = c.ResumendiarioDetID ";
                SQL += " WHERE a.EmpresaID='" + Ctr_AyuEmpresas.Codigo + "' AND fechadocumento = '" + DtpFechaDoc.Text + "'";
                SQL += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 AND b.GrupodeEnvioSunat=" + TxtGrupo.Text + " Order by IdentificadorEnvio ";
            }
            else
                        if (vTipoDoc == "RA")
            {
                SQL = " SELECT Item=IdentificadorEnvio+1,Establecimiento_id,Fechadocumento,b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01') ";
                SQL += " FROM dbo.FE_ComunicacionBajaCab  a ";
                SQL += "  INNER join FE_ComunicacionBajaDet b ON a.empresacodigo = b.empresacodigo ";
                SQL += " AND a.ComunicacionBaja_id = b.ComunicacionBaja_id ";
                SQL += " WHERE a.Empresacodigo='" + Ctr_AyuEmpresas.Codigo + "' AND fechadocumento = '" + DtpFechaDoc.Text + "'";
                SQL += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0   ";
                SQL += " AND b.GrupodeEnvioSunat=" + TxtGrupo.Text + " Order by Establecimientoid ";
                SQL += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by Establecimientoid ";
            }
            else
            {
                SQL += "AND DocumentoID='" + vTipoDoc + "'";
                SQL += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by EstablecimientoID ";
            }

            DtDocumentos = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
            DgvConsulta.DataSource = DtDocumentos;

            txtNroReg.Text = Convert.ToString(DtDocumentos.Rows.Count);
            txtResult.Text = "";
            //     txtResult.Text = "Proceso de generacion de factura/boletas XML "+"\n";
            try
            {
                if (DtDocumentos.Rows.Count > 0)
                {
                    if ((DtDocumentos.Rows.Count > 0) & (DtDocumentos.Rows.Count <= vMaximoIItem))
                    {
                        txtVtas.Text = Convert.ToString(ModFunc.Totalventas(DtDocumentos));
                        BntGrupos.Visible = false;
                        BntGeneraEnvios.Visible = false;
                        BntEnvioSunat.Visible = true;
                        GeneraAceptados();
                    }
                    else
                    {
                        MessageBox.Show(" EXISTE MAS DE 500 DOCUMENTOS ,FAVOR DE PROCESAR GENERACION DE GRUPOS ");
                        txtVtas.Text = Convert.ToString(ModFunc.Totalventas(DtDocumentos));
                        BntGrupos.Visible = true;
                        BntGeneraEnvios.Visible = false;
                        BntEnvioSunat.Visible = false;
                        return;
                    }

                    // Creacion de directorio empresa
                    vRutaXml = Convert.ToString(DtEmpresa.Rows[0]["CarpetaEnviosXml"]);
                    vRutaArchivoXML = Ctr_AyuEmpresas.Codigo;
                    vRutaArchivoXML = ModFunc.CreacionDirectorio(vRutaXml, vRutaArchivoXML);

                    // Creacion de directorio de facturas electronicas

                    // Creacion de directorio año
                    vRutaXml = vRutaArchivoXML;
                    vRutaArchivoXML = Convert.ToString(DtpFechaDoc.Value.Year);
                    vRutaArchivoXML = ModFunc.CreacionDirectorio(vRutaXml, vRutaArchivoXML);

                    // Creacion de directorio mes

                    vRutaXml = vRutaArchivoXML;
                    vRutaArchivoXML = ModFunc.DesMes(ModFunc.Derecha("0" + Convert.ToString(DtpFechaDoc.Value.Month), 2));
                    vRutaArchivoXML = ModFunc.CreacionDirectorio(vRutaXml, vRutaArchivoXML);

                    // Creacion de directorio XML

                    vRutaXml = vRutaArchivoXML;
                    vRutaCdr = vRutaXml;
                    vRutaArchivoXML = "XML";
                    vRutaXml = ModFunc.CreacionDirectorio(vRutaXml, vRutaArchivoXML);

                    vRutaArchivoXML = "CDR";
                    vRutaCdr = ModFunc.CreacionDirectorio(vRutaCdr, vRutaArchivoXML);
                }
                switch (vTipoDoc)
                {
                    case "RA":
                        CrearXmlBajas();
                        break;

                    case "RC":
                        CrearXmlResumen2();
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

        private void BntGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                SQL = " SELECT b.* FROM dbo.FE_ResumenDiarioDocumentosCab a ";
                SQL += " INNER JOIN dbo.FE_ResumenDiarioDocumentosDet b ON a.empresacodigo = b.empresacodigo AND a.Resumendiario_id = b.Resumendiario_id  ";
                SQL += " WHERE a.Empresacodigo='" + Ctr_AyuEmpresas.Codigo + "' AND fechadocumento = '" + DtpFechaDoc.Text + "'";
                SQL += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by Establecimiento_id ";
                DtAceptados = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
                int vNumReg = 0;
                int vcontador = 1;
                BntGrupos.Visible = false;
                if (DtAceptados.Rows.Count > 0)
                {
                    for (int ii = 0; ii <= DtAceptados.Rows.Count - 1; ii++)
                    {
                        vNumReg += (int)DtAceptados.Rows[ii]["NumerodeDocumentos"];
                        if (!(vNumReg <= vMaximoIItem))
                        {
                            vcontador += 1;
                            vNumReg = (int)DtAceptados.Rows[ii]["NumerodeDocumentos"];
                        }
                        SQL = " UPDATE FE_ResumenDiarioDocumentosDet SET GrupodeEnvioSunat=" + vcontador;
                        SQL += " WHERE empresacodigo ='" + (string)DtAceptados.Rows[ii]["empresacodigo"] + "' AND Resumendiario_id =" + (int)DtAceptados.Rows[ii]["Resumendiario_id"];
                        SQL += " AND ResumendiarioCorrel=" + (int)DtAceptados.Rows[ii]["ResumendiarioCorrel"];

                        ModFunc.GrabarTabla(SQL, VGCnxSqlE);
                    }
                    txtGenerados.Text = Convert.ToString(vcontador);
                    TxtGrupo.Text = "1";
                    MessageBox.Show("Proceso concluido ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BntEnvioSunat_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = "";
                if (vTipoDoc == "RC")
                {
                    CrearResumen();
                }
                else
                if (vTipoDoc == "RA")
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

                BntEnvioSunat.Visible = false;
                BntGeneraEnvios.Visible = false;
            }
            catch
            {
                BntEnvioSunat.Visible = false;
                BntGeneraEnvios.Visible = true;
            }
        }

        private async void BtnConsultaTicket_Click(object sender, EventArgs e)
        {
            string vPath = "";
            string vNro = "";
            try
            {
                Cursor = Cursors.WaitCursor;
                vNro = txtNroTicket.Text;
                var consultaTicketRequest = new ConsultaTicketRequest
                {
                    Ruc = TxtRuc.Text,
                    UsuarioSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaUsuarioSol"]),
                    ClaveSol = Convert.ToString(DtEmpresa.Rows[0]["EmpresaclaveSol"]),
                    EndPointUrl = vUrlSunat,
                    IdDocumento = TxtXml.Text,
                    NroTicket = txtNroTicket.Text
                };

                var jsonConsultaTicket = await _client.PostAsJsonAsync("api/ConsultarTicket", consultaTicketRequest);

                var respuestaEnvio = await jsonConsultaTicket.Content.ReadAsAsync<EnviarDocumentoResponse>();

                string vStr = "";
                Boolean vOk = false;
                txtResult.Text = "";
                if (!respuestaEnvio.Exito)
                {
                    vStr = " Servidor SUNAT no responde ";
                }
                else
                {
                    if (!string.IsNullOrEmpty(respuestaEnvio.MensajeError))
                    {
                        vStr = respuestaEnvio.MensajeError;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(respuestaEnvio.MensajeRespuesta))
                        {
                            vOk = true;
                            vStr = respuestaEnvio.MensajeRespuesta;
                        }
                    }

                    if (vOk)
                    {
                        vPath = vRutaCdr;
                        vPath += Path.Combine(vPath, $"/{respuestaEnvio.NombreArchivo}.zip");

                        //      File.WriteAllBytes($"{Program.CarpetaCdr}\\R-{respuestaEnvio.NombreArchivo}.zip",
                        File.WriteAllBytes(vPath, Convert.FromBase64String(respuestaEnvio.TramaZipCdr));

                        vStr = $@"{Resources.procesoCorrecto}{Environment.NewLine}{respuestaEnvio.MensajeRespuesta}";

                        //         ModFunc.ActualizaEnviosDia(DtAceptados, Convert.ToString(DtDocumentos.Rows[0]["item"]), vNro, VGCnxSqlE);
                    }
                }
                txtResult.Text = $@"{vStr}";
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

        private void BntXml_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ofd = new OpenFileDialog())
                {
                    ofd.Title = Resources.seleccionXml;
                    ofd.Filter = Resources.formatosXml;
                    ofd.FilterIndex = 1;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        TxtXml.Text = ofd.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Botones

        #region textBox

        private void Ctr_AyuUrlDoc_AlDevolverDato(object Sender, DataRow e)
        {
            DataTable Dtx = new DataTable();
            SQL = " SELECT DireccionSunatUrl FROM fedireccionesSunat where ID='" + Ctr_AyuUrlDoc.Codigo + "'";
            Dtx = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
            vUrlSunat = (string)Dtx.Rows[0][0];
        }

        private void Ctr_AyuEmpresas_AlDevolverDato(object Sender, DataRow e)
        {
            SQL = "SELECT  * FROM [v_FEDatosGeneralesEmpresas] WHERE ID='" + Ctr_AyuEmpresas.Codigo + "'";

            DtEmpresa = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
            if (DtEmpresa.Rows.Count > 0)
            {
                TxtRuc.Text = (string)DtEmpresa.Rows[0]["Empresaruc"];
                TxtDireccion.Text = (string)DtEmpresa.Rows[0]["DireccionCompleta"];
            }
        }

        private void DtpFechaDoc_ValueChanged(object sender, EventArgs e)
        {
            BntEnvioSunat.Visible = false;
            BntGeneraEnvios.Visible = true;
            DtpFechaEnvioDoc.Text = DtpFechaDoc.Text;
            TxtGrupo.Text = "0";
        }

        private void DtpFechaEnvioDoc_ValueChanged(object sender, EventArgs e)
        {
            BntEnvioSunat.Visible = false;
            BntGeneraEnvios.Visible = true;
        }

        private void Ctr_AyuDocumento_AlDevolverDato(object Sender, DataRow e)
        {
            DataTable Dtx = new DataTable();
            SQL = " SELECT * FROM feDocumentosFE where ID='" + Ctr_AyuDocumento.Codigo + "'";
            Dtx = ModFunc.ConsultarTabla(SQL, VGCnxSqlE);
            vTipoDoc = (string)Dtx.Rows[0]["ID"];
            vtipoEnvio = (int)Dtx.Rows[0]["tipoenvioid"];
            BntEnvioSunat.Visible = false;
            BntGeneraEnvios.Visible = true;
            if (vtipoEnvio == 1)
            {
                rbDocumentos.Checked = true;
            }
            else
            {
                if (vtipoEnvio == 2)
                {
                    rbRetenciones.Checked = true;
                }
                else
                {
                    rbResumen.Checked = true;
                }
            }
        }

        #endregion textBox


    }
}