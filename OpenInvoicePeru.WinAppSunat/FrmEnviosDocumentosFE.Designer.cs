using System.Windows.Forms;

namespace Jck.WinApp
{
    partial class FrmEnviosDocumentosFE : PlantillaBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnviosDocumentosFE));
            this.direccionSunatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNroReg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVtas = new System.Windows.Forms.TextBox();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inafecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalvta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabDatosGenerales = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctr_AyuDocumentos = new Ctr_Ayuda.Ctr_Ayuda();
            this.ctr_AyuUrl = new Ctr_Ayuda.Ctr_Ayuda();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRuc = new System.Windows.Forms.TextBox();
            this.Ctr_AyuEmpresa = new Ctr_Ayuda.Ctr_Ayuda();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.BntXml = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtXml = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.BntGenerar = new System.Windows.Forms.Button();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkVoz = new System.Windows.Forms.CheckBox();
            this.BntSunat = new System.Windows.Forms.Button();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbResumen = new System.Windows.Forms.RadioButton();
            this.rbRetenciones = new System.Windows.Forms.RadioButton();
            this.rbDocumentos = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.direccionSunatBindingSource)).BeginInit();
            this.tabData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.tabDatosGenerales.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // direccionSunatBindingSource
            // 
            this.direccionSunatBindingSource.DataSource = typeof(Jck.Entidades.DireccionSunat);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(975, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Resultados";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(944, 22);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(213, 308);
            this.txtResult.TabIndex = 65;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tabPage1);
            this.tabData.Controls.Add(this.tabPage2);
            this.tabData.Location = new System.Drawing.Point(12, 206);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1175, 368);
            this.tabData.TabIndex = 100;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtNroReg);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtVtas);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Controls.Add(this.DgvConsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1167, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Procesos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(261, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 110;
            this.label12.Text = "Nuero de registros";
            // 
            // txtNroReg
            // 
            this.txtNroReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroReg.Location = new System.Drawing.Point(401, 310);
            this.txtNroReg.Name = "txtNroReg";
            this.txtNroReg.Size = new System.Drawing.Size(117, 25);
            this.txtNroReg.TabIndex = 109;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(591, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 108;
            this.label11.Text = "Total Ventas";
            // 
            // txtVtas
            // 
            this.txtVtas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVtas.Location = new System.Drawing.Point(721, 309);
            this.txtVtas.Name = "txtVtas";
            this.txtVtas.Size = new System.Drawing.Size(117, 25);
            this.txtVtas.TabIndex = 107;
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.AllowUserToAddRows = false;
            this.DgvConsulta.AllowUserToDeleteRows = false;
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Tipodoc,
            this.Serie,
            this.Numero,
            this.RazonSocial,
            this.ClienteCodigo,
            this.Importe,
            this.igv,
            this.Inafecto,
            this.Totalvta});
            this.DgvConsulta.Location = new System.Drawing.Point(3, 22);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.ReadOnly = true;
            this.DgvConsulta.Size = new System.Drawing.Size(935, 271);
            this.DgvConsulta.TabIndex = 0;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "item";
            this.Item.FillWeight = 50F;
            this.Item.HeaderText = "N. Envio";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 49;
            // 
            // Tipodoc
            // 
            this.Tipodoc.DataPropertyName = "TipoDocumento";
            this.Tipodoc.FillWeight = 40F;
            this.Tipodoc.HeaderText = "Tipo Doc";
            this.Tipodoc.Name = "Tipodoc";
            this.Tipodoc.ReadOnly = true;
            this.Tipodoc.Width = 30;
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "SerieDocumento";
            this.Serie.FillWeight = 60F;
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            this.Serie.Width = 40;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numerodocumento";
            this.Numero.FillWeight = 60F;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 60;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "ClienteRazonSocial";
            this.RazonSocial.FillWeight = 200F;
            this.RazonSocial.HeaderText = "Razon social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 88;
            // 
            // ClienteCodigo
            // 
            this.ClienteCodigo.DataPropertyName = "ClienteCodigo";
            this.ClienteCodigo.HeaderText = "Codigo";
            this.ClienteCodigo.Name = "ClienteCodigo";
            this.ClienteCodigo.ReadOnly = true;
            this.ClienteCodigo.Width = 70;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "TotalimporteGravado";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 90;
            // 
            // igv
            // 
            this.igv.DataPropertyName = "TotalImporteIgv";
            this.igv.HeaderText = "Igv";
            this.igv.Name = "igv";
            this.igv.ReadOnly = true;
            this.igv.Width = 90;
            // 
            // Inafecto
            // 
            this.Inafecto.DataPropertyName = "TotalimporteInafecto";
            this.Inafecto.HeaderText = "Inafecto";
            this.Inafecto.Name = "Inafecto";
            this.Inafecto.ReadOnly = true;
            this.Inafecto.Width = 90;
            // 
            // Totalvta
            // 
            this.Totalvta.DataPropertyName = "TotalImporteventa";
            this.Totalvta.HeaderText = "Total Vta";
            this.Totalvta.Name = "Totalvta";
            this.Totalvta.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1167, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabDatosGenerales
            // 
            this.tabDatosGenerales.Controls.Add(this.tabPage3);
            this.tabDatosGenerales.Controls.Add(this.tabPage4);
            this.tabDatosGenerales.Location = new System.Drawing.Point(12, 3);
            this.tabDatosGenerales.Name = "tabDatosGenerales";
            this.tabDatosGenerales.SelectedIndex = 0;
            this.tabDatosGenerales.Size = new System.Drawing.Size(1161, 197);
            this.tabDatosGenerales.TabIndex = 101;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1153, 172);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Procesos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.ctr_AyuDocumentos);
            this.panel1.Controls.Add(this.ctr_AyuUrl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtRuc);
            this.panel1.Controls.Add(this.Ctr_AyuEmpresa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNroTicket);
            this.panel1.Controls.Add(this.BntXml);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtXml);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DtpFechaEnvio);
            this.panel1.Controls.Add(this.BntGenerar);
            this.panel1.Controls.Add(this.DtpFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkVoz);
            this.panel1.Controls.Add(this.BntSunat);
            this.panel1.Controls.Add(this.btnGetStatus);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(7, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 153);
            this.panel1.TabIndex = 1;
            // 
            // ctr_AyuDocumentos
            // 
            this.ctr_AyuDocumentos.CampoDevCod = "DocumentoCodigo";
            this.ctr_AyuDocumentos.CampoDevDesc = "DocumentoDescripcion";
            this.ctr_AyuDocumentos.Codigo = "";
            this.ctr_AyuDocumentos.Descripcion = "";
            this.ctr_AyuDocumentos.Filtro = "";
            this.ctr_AyuDocumentos.ListaAlias = "Codigo,Descripcion";
            this.ctr_AyuDocumentos.ListaCampos = "DocumentoCodigo,DocumentoDescripcion";
            this.ctr_AyuDocumentos.Location = new System.Drawing.Point(882, 28);
            this.ctr_AyuDocumentos.LongCod = "2";
            this.ctr_AyuDocumentos.LongDesc = "50";
            this.ctr_AyuDocumentos.Name = "ctr_AyuDocumentos";
            this.ctr_AyuDocumentos.NombreTabla = "fe_DocumentosFE";
            this.ctr_AyuDocumentos.Requerido = true;
            this.ctr_AyuDocumentos.Size = new System.Drawing.Size(202, 16);
            this.ctr_AyuDocumentos.TabIndex = 117;
            this.ctr_AyuDocumentos.Titulo = null;
            this.ctr_AyuDocumentos.AlDevolverDato += new Ctr_Ayuda.Ctr_Ayuda.AlDevolverDatoEventHandler(this.ctr_AyuDocumentos_AlDevolverDato);
            this.ctr_AyuDocumentos.Load += new System.EventHandler(this.ctr_AyuDocumentos_Load);
            // 
            // ctr_AyuUrl
            // 
            this.ctr_AyuUrl.CampoDevCod = "DireccionSunat_id";
            this.ctr_AyuUrl.CampoDevDesc = "DireccionSunatTipo";
            this.ctr_AyuUrl.Codigo = "";
            this.ctr_AyuUrl.Descripcion = "";
            this.ctr_AyuUrl.Filtro = "";
            this.ctr_AyuUrl.ListaAlias = "Codigo,Direccion,Urk";
            this.ctr_AyuUrl.ListaCampos = "DireccionSunat_id,DireccionSunattipo,Direccionsunaturl";
            this.ctr_AyuUrl.Location = new System.Drawing.Point(645, 27);
            this.ctr_AyuUrl.LongCod = "3";
            this.ctr_AyuUrl.LongDesc = "50";
            this.ctr_AyuUrl.Name = "ctr_AyuUrl";
            this.ctr_AyuUrl.NombreTabla = "fe_DireccionesSunat";
            this.ctr_AyuUrl.Requerido = true;
            this.ctr_AyuUrl.Size = new System.Drawing.Size(227, 17);
            this.ctr_AyuUrl.TabIndex = 115;
            this.ctr_AyuUrl.Titulo = null;
            this.ctr_AyuUrl.AlDevolverDato += new Ctr_Ayuda.Ctr_Ayuda.AlDevolverDatoEventHandler(this.ctr_AyuUrl_AlDevolverDato);
            this.ctr_AyuUrl.Load += new System.EventHandler(this.ctr_AyuUrl_Load);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(469, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 113;
            this.label9.Text = "Direccion Fiscal";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(279, 72);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(430, 27);
            this.TxtDireccion.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(69, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 111;
            this.label8.Text = "Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(318, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 110;
            this.label7.Text = "RUC";
            // 
            // TxtRuc
            // 
            this.TxtRuc.Location = new System.Drawing.Point(279, 27);
            this.TxtRuc.Name = "TxtRuc";
            this.TxtRuc.Size = new System.Drawing.Size(109, 21);
            this.TxtRuc.TabIndex = 109;
            // 
            // Ctr_AyuEmpresa
            // 
            this.Ctr_AyuEmpresa.CampoDevCod = "EmpresaCodigo";
            this.Ctr_AyuEmpresa.CampoDevDesc = "EmpresaRazonSocial";
            this.Ctr_AyuEmpresa.Codigo = "";
            this.Ctr_AyuEmpresa.Descripcion = "";
            this.Ctr_AyuEmpresa.Filtro = "";
            this.Ctr_AyuEmpresa.ListaAlias = "Codigo,razonSocial";
            this.Ctr_AyuEmpresa.ListaCampos = "EmpresaCodigo,EmpresaRazonSocial";
            this.Ctr_AyuEmpresa.Location = new System.Drawing.Point(20, 26);
            this.Ctr_AyuEmpresa.LongCod = "3";
            this.Ctr_AyuEmpresa.LongDesc = "50";
            this.Ctr_AyuEmpresa.Name = "Ctr_AyuEmpresa";
            this.Ctr_AyuEmpresa.NombreTabla = "fe_Empresas";
            this.Ctr_AyuEmpresa.Requerido = true;
            this.Ctr_AyuEmpresa.Size = new System.Drawing.Size(239, 18);
            this.Ctr_AyuEmpresa.TabIndex = 108;
            this.Ctr_AyuEmpresa.Titulo = null;
            this.Ctr_AyuEmpresa.AlDevolverDato += new Ctr_Ayuda.Ctr_Ayuda.AlDevolverDatoEventHandler(this.Ctr_AyuEmpresa_AlDevolverDato);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(701, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 107;
            this.label6.Text = "Nro. de Ticket";
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(801, 121);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(117, 21);
            this.txtNroTicket.TabIndex = 106;
            // 
            // BntXml
            // 
            this.BntXml.Location = new System.Drawing.Point(645, 121);
            this.BntXml.Name = "BntXml";
            this.BntXml.Size = new System.Drawing.Size(39, 25);
            this.BntXml.TabIndex = 105;
            this.BntXml.Text = "XML";
            this.BntXml.UseVisualStyleBackColor = true;
            this.BntXml.Click += new System.EventHandler(this.BntXml_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(525, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 104;
            this.label5.Text = "Documento XML";
            // 
            // TxtXml
            // 
            this.TxtXml.Location = new System.Drawing.Point(279, 125);
            this.TxtXml.Name = "TxtXml";
            this.TxtXml.Size = new System.Drawing.Size(357, 21);
            this.TxtXml.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(507, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 102;
            this.label4.Text = "Fecha Envio SUNAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(391, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "Fecha Documento";
            // 
            // DtpFechaEnvio
            // 
            this.DtpFechaEnvio.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaEnvio.Location = new System.Drawing.Point(510, 28);
            this.DtpFechaEnvio.Name = "DtpFechaEnvio";
            this.DtpFechaEnvio.Size = new System.Drawing.Size(98, 21);
            this.DtpFechaEnvio.TabIndex = 100;
            this.DtpFechaEnvio.ValueChanged += new System.EventHandler(this.DtpFechaEnvio_ValueChanged);
            // 
            // BntGenerar
            // 
            this.BntGenerar.BackColor = System.Drawing.Color.Gold;
            this.BntGenerar.Location = new System.Drawing.Point(727, 61);
            this.BntGenerar.Name = "BntGenerar";
            this.BntGenerar.Size = new System.Drawing.Size(104, 44);
            this.BntGenerar.TabIndex = 98;
            this.BntGenerar.Text = "Generar registros";
            this.BntGenerar.UseVisualStyleBackColor = false;
            this.BntGenerar.Click += new System.EventHandler(this.BntGenerar_Click);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(394, 28);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(98, 23);
            this.DtpFecha.TabIndex = 96;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(934, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Tipo de Documento:";
            // 
            // chkVoz
            // 
            this.chkVoz.AutoSize = true;
            this.chkVoz.BackColor = System.Drawing.Color.Transparent;
            this.chkVoz.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkVoz.Checked = true;
            this.chkVoz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVoz.ForeColor = System.Drawing.Color.White;
            this.chkVoz.Location = new System.Drawing.Point(853, 67);
            this.chkVoz.Name = "chkVoz";
            this.chkVoz.Size = new System.Drawing.Size(103, 31);
            this.chkVoz.TabIndex = 80;
            this.chkVoz.Text = "Hablar en voz alta";
            this.chkVoz.UseVisualStyleBackColor = false;
            // 
            // BntSunat
            // 
            this.BntSunat.BackColor = System.Drawing.Color.Lime;
            this.BntSunat.Location = new System.Drawing.Point(962, 54);
            this.BntSunat.Name = "BntSunat";
            this.BntSunat.Size = new System.Drawing.Size(104, 48);
            this.BntSunat.TabIndex = 77;
            this.BntSunat.Text = "&Enviar a SUNAT";
            this.BntSunat.UseVisualStyleBackColor = false;
            this.BntSunat.Click += new System.EventHandler(this.BntSunat_Click);
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.BackColor = System.Drawing.Color.MistyRose;
            this.btnGetStatus.Location = new System.Drawing.Point(937, 115);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(129, 32);
            this.btnGetStatus.TabIndex = 76;
            this.btnGetStatus.Text = "Consultar N° Ticket";
            this.btnGetStatus.UseVisualStyleBackColor = false;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(694, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "Url del Servicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.rbResumen);
            this.groupBox1.Controls.Add(this.rbRetenciones);
            this.groupBox1.Controls.Add(this.rbDocumentos);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(20, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 84);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de documentos";
            // 
            // rbResumen
            // 
            this.rbResumen.AutoSize = true;
            this.rbResumen.Location = new System.Drawing.Point(7, 62);
            this.rbResumen.Name = "rbResumen";
            this.rbResumen.Size = new System.Drawing.Size(197, 17);
            this.rbResumen.TabIndex = 8;
            this.rbResumen.TabStop = true;
            this.rbResumen.Text = "Resumen y Comunicacion de baja";
            this.rbResumen.UseVisualStyleBackColor = true;
            // 
            // rbRetenciones
            // 
            this.rbRetenciones.AutoSize = true;
            this.rbRetenciones.Location = new System.Drawing.Point(6, 41);
            this.rbRetenciones.Name = "rbRetenciones";
            this.rbRetenciones.Size = new System.Drawing.Size(187, 17);
            this.rbRetenciones.TabIndex = 7;
            this.rbRetenciones.TabStop = true;
            this.rbRetenciones.Text = "Retenciones, Percepciones y GR";
            this.rbRetenciones.UseVisualStyleBackColor = true;
            // 
            // rbDocumentos
            // 
            this.rbDocumentos.AutoSize = true;
            this.rbDocumentos.Checked = true;
            this.rbDocumentos.Location = new System.Drawing.Point(6, 20);
            this.rbDocumentos.Name = "rbDocumentos";
            this.rbDocumentos.Size = new System.Drawing.Size(145, 17);
            this.rbDocumentos.TabIndex = 6;
            this.rbDocumentos.TabStop = true;
            this.rbDocumentos.Text = "Factura, Boleta, NC, ND";
            this.rbDocumentos.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 21);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1153, 172);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Consultas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FrmEnviosDocumentosFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1185, 581);
            this.Controls.Add(this.tabDatosGenerales);
            this.Controls.Add(this.tabData);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEnviosDocumentosFE";
            this.Text = "v";
            this.Load += new System.EventHandler(this.FrmEnviosDocumentosFE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.direccionSunatBindingSource)).EndInit();
            this.tabData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.tabDatosGenerales.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource direccionSunatBindingSource;
        private Label label2;
        private TextBox txtResult;
        private TabControl tabData;
        private TabPage tabPage1;
        private DataGridView DgvConsulta;
        private TabPage tabPage2;
        private TabControl tabDatosGenerales;
        private TabPage tabPage3;
        private Panel panel1;
        private Label label9;
        private TextBox TxtDireccion;
        private Label label8;
        private Label label7;
        private TextBox TxtRuc;
        internal Ctr_Ayuda.Ctr_Ayuda Ctr_AyuEmpresa;
        private Label label6;
        private TextBox txtNroTicket;
        private Button BntXml;
        private Label label5;
        private TextBox TxtXml;
        private Label label4;
        private Label label3;
        internal DateTimePicker DtpFechaEnvio;
        internal Button BntGenerar;
        internal DateTimePicker DtpFecha;
        private Label label1;
        private CheckBox chkVoz;
        private Button BntSunat;
        private Button btnGetStatus;
        private Label label10;
        private GroupBox groupBox1;
        private RadioButton rbResumen;
        private RadioButton rbRetenciones;
        private RadioButton rbDocumentos;
        private TabPage tabPage4;
        internal Ctr_Ayuda.Ctr_Ayuda ctr_AyuUrl;
        internal Ctr_Ayuda.Ctr_Ayuda ctr_AyuDocumentos;
        private Label label12;
        private TextBox txtNroReg;
        private Label label11;
        private TextBox txtVtas;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Tipodoc;
        private DataGridViewTextBoxColumn Serie;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn ClienteCodigo;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn igv;
        private DataGridViewTextBoxColumn Inafecto;
        private DataGridViewTextBoxColumn Totalvta;
    }
}