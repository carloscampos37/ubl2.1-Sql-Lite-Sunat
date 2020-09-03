namespace OpenInvoicePeru.WinApp
{
    partial class FrmEnviosSunat
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGenerados = new System.Windows.Forms.TextBox();
            this.BntGrupos = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNroReg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVtas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalvta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inafecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtGrupo = new System.Windows.Forms.TextBox();
            this.Ctr_AyuDocumento = new Ctr_Ayuda.Ctr_Ayuda();
            this.Ctr_AyuUrlDoc = new Ctr_Ayuda.Ctr_Ayuda();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRuc = new System.Windows.Forms.TextBox();
            this.Ctr_AyuEmpresas = new Ctr_Ayuda.Ctr_Ayuda();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.BntXml = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtXml = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFechaEnvioDoc = new System.Windows.Forms.DateTimePicker();
            this.BntGeneraEnvios = new System.Windows.Forms.Button();
            this.DtpFechaDoc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkVoz = new System.Windows.Forms.CheckBox();
            this.BntEnvioSunat = new System.Windows.Forms.Button();
            this.BtnConsultaTicket = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbResumen = new System.Windows.Forms.RadioButton();
            this.rbRetenciones = new System.Windows.Forms.RadioButton();
            this.rbDocumentos = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PROCESOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txtGenerados);
            this.panel2.Controls.Add(this.BntGrupos);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtNroReg);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtVtas);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DgvConsulta);
            this.panel2.Location = new System.Drawing.Point(6, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 337);
            this.panel2.TabIndex = 4;
            // 
            // txtGenerados
            // 
            this.txtGenerados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerados.Location = new System.Drawing.Point(126, 299);
            this.txtGenerados.Name = "txtGenerados";
            this.txtGenerados.Size = new System.Drawing.Size(64, 25);
            this.txtGenerados.TabIndex = 118;
            // 
            // BntGrupos
            // 
            this.BntGrupos.BackColor = System.Drawing.Color.Yellow;
            this.BntGrupos.Location = new System.Drawing.Point(19, 295);
            this.BntGrupos.Name = "BntGrupos";
            this.BntGrupos.Size = new System.Drawing.Size(101, 37);
            this.BntGrupos.TabIndex = 117;
            this.BntGrupos.Text = "Generacion de grupos";
            this.BntGrupos.UseVisualStyleBackColor = false;
            this.BntGrupos.Click += new System.EventHandler(this.BntGrupos_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(337, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 116;
            this.label12.Text = "Nuero de registros";
            // 
            // txtNroReg
            // 
            this.txtNroReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroReg.Location = new System.Drawing.Point(510, 300);
            this.txtNroReg.Name = "txtNroReg";
            this.txtNroReg.Size = new System.Drawing.Size(117, 25);
            this.txtNroReg.TabIndex = 115;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(668, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 114;
            this.label14.Text = "Total Ventas";
            // 
            // txtVtas
            // 
            this.txtVtas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVtas.Location = new System.Drawing.Point(798, 299);
            this.txtVtas.Name = "txtVtas";
            this.txtVtas.Size = new System.Drawing.Size(117, 25);
            this.txtVtas.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(843, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 78;
            this.label11.Text = "Resultados";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(812, 18);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(213, 271);
            this.txtResult.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(907, -17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 76;
            this.label2.Text = "Resultados";
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.AllowUserToAddRows = false;
            this.DgvConsulta.AllowUserToDeleteRows = false;
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Column1,
            this.Tipodoc,
            this.Serie,
            this.Numero,
            this.Totalvta,
            this.ClienteCodigo,
            this.RazonSocial,
            this.Importe,
            this.igv,
            this.Inafecto});
            this.DgvConsulta.Location = new System.Drawing.Point(19, 18);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.ReadOnly = true;
            this.DgvConsulta.Size = new System.Drawing.Size(786, 271);
            this.DgvConsulta.TabIndex = 74;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "grupo";
            this.Column1.HeaderText = "Grupo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
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
            // Totalvta
            // 
            this.Totalvta.DataPropertyName = "TotalImporteventa";
            this.Totalvta.HeaderText = "Total Vta";
            this.Totalvta.Name = "Totalvta";
            this.Totalvta.ReadOnly = true;
            // 
            // ClienteCodigo
            // 
            this.ClienteCodigo.DataPropertyName = "clienteCodigo";
            this.ClienteCodigo.HeaderText = "Codigo";
            this.ClienteCodigo.Name = "ClienteCodigo";
            this.ClienteCodigo.ReadOnly = true;
            this.ClienteCodigo.Width = 70;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtGrupo);
            this.panel1.Controls.Add(this.Ctr_AyuDocumento);
            this.panel1.Controls.Add(this.Ctr_AyuUrlDoc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtRuc);
            this.panel1.Controls.Add(this.Ctr_AyuEmpresas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNroTicket);
            this.panel1.Controls.Add(this.BntXml);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtXml);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DtpFechaEnvioDoc);
            this.panel1.Controls.Add(this.BntGeneraEnvios);
            this.panel1.Controls.Add(this.DtpFechaDoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkVoz);
            this.panel1.Controls.Add(this.BntEnvioSunat);
            this.panel1.Controls.Add(this.BtnConsultaTicket);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(5, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 165);
            this.panel1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(584, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 119;
            this.label13.Text = "Grupo";
            // 
            // TxtGrupo
            // 
            this.TxtGrupo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGrupo.Location = new System.Drawing.Point(582, 26);
            this.TxtGrupo.Multiline = true;
            this.TxtGrupo.Name = "TxtGrupo";
            this.TxtGrupo.Size = new System.Drawing.Size(28, 27);
            this.TxtGrupo.TabIndex = 118;
            this.TxtGrupo.Text = "0";
            // 
            // Ctr_AyuDocumento
            // 
            this.Ctr_AyuDocumento.CampoDevCod = "DocumentoCodigo";
            this.Ctr_AyuDocumento.CampoDevDesc = "DocumentoDescripcion";
            this.Ctr_AyuDocumento.Codigo = "";
            this.Ctr_AyuDocumento.Descripcion = "";
            this.Ctr_AyuDocumento.Filtro = "";
            this.Ctr_AyuDocumento.ListaAlias = "Codigo,Descripcion";
            this.Ctr_AyuDocumento.ListaCampos = "DocumentoCodigo,DocumentoDescripcion";
            this.Ctr_AyuDocumento.Location = new System.Drawing.Point(822, 36);
            this.Ctr_AyuDocumento.LongCod = "2";
            this.Ctr_AyuDocumento.LongDesc = "50";
            this.Ctr_AyuDocumento.Name = "Ctr_AyuDocumento";
            this.Ctr_AyuDocumento.NombreTabla = "fe_DocumentosFE";
            this.Ctr_AyuDocumento.Requerido = true;
            this.Ctr_AyuDocumento.Size = new System.Drawing.Size(202, 16);
            this.Ctr_AyuDocumento.TabIndex = 117;
            this.Ctr_AyuDocumento.Titulo = null;
            this.Ctr_AyuDocumento.AlDevolverDato += new Ctr_Ayuda.Ctr_Ayuda.AlDevolverDatoEventHandler(this.Ctr_AyuDocumento_AlDevolverDato);
            // 
            // Ctr_AyuUrlDoc
            // 
            this.Ctr_AyuUrlDoc.CampoDevCod = "DireccionSunat_id";
            this.Ctr_AyuUrlDoc.CampoDevDesc = "DireccionSunatTipo";
            this.Ctr_AyuUrlDoc.Codigo = "";
            this.Ctr_AyuUrlDoc.Descripcion = "";
            this.Ctr_AyuUrlDoc.Filtro = "";
            this.Ctr_AyuUrlDoc.ListaAlias = "Codigo,Direccion,Urk";
            this.Ctr_AyuUrlDoc.ListaCampos = "DireccionSunat_id,DireccionSunattipo,Direccionsunaturl";
            this.Ctr_AyuUrlDoc.Location = new System.Drawing.Point(616, 36);
            this.Ctr_AyuUrlDoc.LongCod = "3";
            this.Ctr_AyuUrlDoc.LongDesc = "50";
            this.Ctr_AyuUrlDoc.Name = "Ctr_AyuUrlDoc";
            this.Ctr_AyuUrlDoc.NombreTabla = "fe_DireccionesSunat";
            this.Ctr_AyuUrlDoc.Requerido = true;
            this.Ctr_AyuUrlDoc.Size = new System.Drawing.Size(219, 17);
            this.Ctr_AyuUrlDoc.TabIndex = 115;
            this.Ctr_AyuUrlDoc.Titulo = null;
            this.Ctr_AyuUrlDoc.AlDevolverDato += new Ctr_Ayuda.Ctr_Ayuda.AlDevolverDatoEventHandler(this.Ctr_AyuUrlDoc_AlDevolverDato);
            this.Ctr_AyuUrlDoc.Load += new System.EventHandler(this.Ctr_AyuUrlDoc_Load);
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
            this.TxtDireccion.Location = new System.Drawing.Point(257, 73);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(389, 27);
            this.TxtDireccion.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 8);
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
            this.label7.Location = new System.Drawing.Point(286, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 110;
            this.label7.Text = "RUC";
            // 
            // TxtRuc
            // 
            this.TxtRuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRuc.Location = new System.Drawing.Point(257, 28);
            this.TxtRuc.Name = "TxtRuc";
            this.TxtRuc.Size = new System.Drawing.Size(104, 25);
            this.TxtRuc.TabIndex = 109;
            // 
            // Ctr_AyuEmpresas
            // 
            this.Ctr_AyuEmpresas.CampoDevCod = "EmpresaCodigo";
            this.Ctr_AyuEmpresas.CampoDevDesc = "EmpresaRazonSocial";
            this.Ctr_AyuEmpresas.Codigo = "";
            this.Ctr_AyuEmpresas.Descripcion = "";
            this.Ctr_AyuEmpresas.Filtro = "";
            this.Ctr_AyuEmpresas.ListaAlias = "Codigo,razonSocial";
            this.Ctr_AyuEmpresas.ListaCampos = "EmpresaCodigo,EmpresaRazonSocial";
            this.Ctr_AyuEmpresas.Location = new System.Drawing.Point(26, 28);
            this.Ctr_AyuEmpresas.LongCod = "3";
            this.Ctr_AyuEmpresas.LongDesc = "50";
            this.Ctr_AyuEmpresas.Name = "Ctr_AyuEmpresas";
            this.Ctr_AyuEmpresas.NombreTabla = "fe_Empresas";
            this.Ctr_AyuEmpresas.Requerido = true;
            this.Ctr_AyuEmpresas.Size = new System.Drawing.Size(239, 18);
            this.Ctr_AyuEmpresas.TabIndex = 108;
            this.Ctr_AyuEmpresas.Titulo = null;
            this.Ctr_AyuEmpresas.AlDevolverDato += new Ctr_Ayuda.Ctr_Ayuda.AlDevolverDatoEventHandler(this.Ctr_AyuEmpresas_AlDevolverDato);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(732, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 107;
            this.label6.Text = "Nro. de Ticket";
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(712, 126);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(117, 20);
            this.txtNroTicket.TabIndex = 106;
            // 
            // BntXml
            // 
            this.BntXml.Location = new System.Drawing.Point(652, 123);
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
            this.TxtXml.Location = new System.Drawing.Point(257, 126);
            this.TxtXml.Name = "TxtXml";
            this.TxtXml.Size = new System.Drawing.Size(389, 20);
            this.TxtXml.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(467, 9);
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
            this.label3.Location = new System.Drawing.Point(352, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "Fecha Documento";
            // 
            // DtpFechaEnvioDoc
            // 
            this.DtpFechaEnvioDoc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEnvioDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEnvioDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaEnvioDoc.Location = new System.Drawing.Point(467, 28);
            this.DtpFechaEnvioDoc.Name = "DtpFechaEnvioDoc";
            this.DtpFechaEnvioDoc.Size = new System.Drawing.Size(95, 25);
            this.DtpFechaEnvioDoc.TabIndex = 100;
            this.DtpFechaEnvioDoc.ValueChanged += new System.EventHandler(this.DtpFechaEnvioDoc_ValueChanged);
            // 
            // BntGeneraEnvios
            // 
            this.BntGeneraEnvios.BackColor = System.Drawing.Color.Gold;
            this.BntGeneraEnvios.Location = new System.Drawing.Point(652, 60);
            this.BntGeneraEnvios.Name = "BntGeneraEnvios";
            this.BntGeneraEnvios.Size = new System.Drawing.Size(104, 44);
            this.BntGeneraEnvios.TabIndex = 98;
            this.BntGeneraEnvios.Text = "Generar registros";
            this.BntGeneraEnvios.UseVisualStyleBackColor = false;
            this.BntGeneraEnvios.Click += new System.EventHandler(this.BntGenera_Click);
            // 
            // DtpFechaDoc
            // 
            this.DtpFechaDoc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDoc.Location = new System.Drawing.Point(367, 28);
            this.DtpFechaDoc.Name = "DtpFechaDoc";
            this.DtpFechaDoc.Size = new System.Drawing.Size(89, 25);
            this.DtpFechaDoc.TabIndex = 96;
            this.DtpFechaDoc.ValueChanged += new System.EventHandler(this.DtpFechaDoc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(859, 9);
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
            this.chkVoz.Location = new System.Drawing.Point(790, 66);
            this.chkVoz.Name = "chkVoz";
            this.chkVoz.Size = new System.Drawing.Size(97, 31);
            this.chkVoz.TabIndex = 80;
            this.chkVoz.Text = "Hablar en voz alta";
            this.chkVoz.UseVisualStyleBackColor = false;
            // 
            // BntEnvioSunat
            // 
            this.BntEnvioSunat.BackColor = System.Drawing.Color.Lime;
            this.BntEnvioSunat.Location = new System.Drawing.Point(893, 60);
            this.BntEnvioSunat.Name = "BntEnvioSunat";
            this.BntEnvioSunat.Size = new System.Drawing.Size(109, 48);
            this.BntEnvioSunat.TabIndex = 77;
            this.BntEnvioSunat.Text = "&Enviar a SUNAT";
            this.BntEnvioSunat.UseVisualStyleBackColor = false;
            this.BntEnvioSunat.Click += new System.EventHandler(this.BntEnvioSunat_Click);
            // 
            // BtnConsultaTicket
            // 
            this.BtnConsultaTicket.BackColor = System.Drawing.Color.MistyRose;
            this.BtnConsultaTicket.Location = new System.Drawing.Point(894, 119);
            this.BtnConsultaTicket.Name = "BtnConsultaTicket";
            this.BtnConsultaTicket.Size = new System.Drawing.Size(108, 32);
            this.BtnConsultaTicket.TabIndex = 76;
            this.BtnConsultaTicket.Text = "Consultar N° Ticket";
            this.BtnConsultaTicket.UseVisualStyleBackColor = false;
            this.BtnConsultaTicket.Click += new System.EventHandler(this.BtnConsultaTicket_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(684, 8);
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
            this.groupBox1.Size = new System.Drawing.Size(221, 84);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de documentos";
            // 
            // rbResumen
            // 
            this.rbResumen.AutoSize = true;
            this.rbResumen.Location = new System.Drawing.Point(7, 62);
            this.rbResumen.Name = "rbResumen";
            this.rbResumen.Size = new System.Drawing.Size(186, 17);
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
            this.rbRetenciones.Size = new System.Drawing.Size(183, 17);
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
            this.rbDocumentos.Size = new System.Drawing.Size(140, 17);
            this.rbDocumentos.TabIndex = 6;
            this.rbDocumentos.TabStop = true;
            this.rbDocumentos.Text = "Factura, Boleta, NC, ND";
            this.rbDocumentos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DOCUMENTOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmEnviosSunat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 566);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmEnviosSunat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEnviosSunat";
            this.Load += new System.EventHandler(this.FrmEnviosSunat_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtGrupo;
        internal Ctr_Ayuda.Ctr_Ayuda Ctr_AyuDocumento;
        internal Ctr_Ayuda.Ctr_Ayuda Ctr_AyuUrlDoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtRuc;
        internal Ctr_Ayuda.Ctr_Ayuda Ctr_AyuEmpresas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.Button BntXml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtXml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker DtpFechaEnvioDoc;
        internal System.Windows.Forms.Button BntGeneraEnvios;
        internal System.Windows.Forms.DateTimePicker DtpFechaDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkVoz;
        private System.Windows.Forms.Button BntEnvioSunat;
        private System.Windows.Forms.Button BtnConsultaTicket;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbResumen;
        private System.Windows.Forms.RadioButton rbRetenciones;
        private System.Windows.Forms.RadioButton rbDocumentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtGenerados;
        private System.Windows.Forms.Button BntGrupos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNroReg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtVtas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalvta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inafecto;
    }
}