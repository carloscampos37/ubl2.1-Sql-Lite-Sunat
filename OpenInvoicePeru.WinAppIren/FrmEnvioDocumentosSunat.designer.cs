namespace OpenInvoicePeru.Forms
{
    partial class FrmenviarSunat
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
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.chkVoz = new System.Windows.Forms.CheckBox();
            this.btnConsultaTicket = new System.Windows.Forms.Button();
            this.rbResumen = new System.Windows.Forms.RadioButton();
            this.rbRetenciones = new System.Windows.Forms.RadioButton();
            this.rbDocumentos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.direccionSunatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboUrlServicio = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BntGeneraXml = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.BntEnvio = new System.Windows.Forms.Button();
            this.BntGenerar = new System.Windows.Forms.Button();
            this.LblCodigoEmpresa = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.BntBuscaXml = new System.Windows.Forms.Button();
            this.DtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionSunatBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
           // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.BackColor = System.Drawing.Color.White;
            this.cboTipoDoc.DisplayMember = "Descripcion";
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "Factura",
            "Boleta",
            "Nota de Crédito",
            "Nota de Débito",
            "Retención",
            "Percepción",
            "Resumen Diario",
            "Comunicacion de Baja",
            "Guía de Remisión"});
            this.cboTipoDoc.Location = new System.Drawing.Point(640, 17);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(151, 21);
            this.cboTipoDoc.TabIndex = 112;
            this.cboTipoDoc.ValueMember = "Descripcion";
            // 
            // chkVoz
            // 
            this.chkVoz.AutoSize = true;
            this.chkVoz.Checked = true;
            this.chkVoz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVoz.Location = new System.Drawing.Point(130, 67);
            this.chkVoz.Name = "chkVoz";
            this.chkVoz.Size = new System.Drawing.Size(112, 17);
            this.chkVoz.TabIndex = 111;
            this.chkVoz.Text = "Hablar en voz alta";
            this.chkVoz.UseVisualStyleBackColor = true;
            // 
            // btnConsultaTicket
            // 
            this.btnConsultaTicket.Location = new System.Drawing.Point(672, 55);
            this.btnConsultaTicket.Name = "btnConsultaTicket";
            this.btnConsultaTicket.Size = new System.Drawing.Size(115, 36);
            this.btnConsultaTicket.TabIndex = 110;
            this.btnConsultaTicket.Text = "Consultar N° Ticket";
            this.btnConsultaTicket.UseVisualStyleBackColor = true;
            this.btnConsultaTicket.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // rbResumen
            // 
            this.rbResumen.AutoSize = true;
            this.rbResumen.Location = new System.Drawing.Point(15, 66);
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
            this.rbRetenciones.Location = new System.Drawing.Point(15, 43);
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
            this.rbDocumentos.Location = new System.Drawing.Point(15, 20);
            this.rbDocumentos.Name = "rbDocumentos";
            this.rbDocumentos.Size = new System.Drawing.Size(140, 17);
            this.rbDocumentos.TabIndex = 6;
            this.rbDocumentos.TabStop = true;
            this.rbDocumentos.Text = "Factura, Boleta, NC, ND";
            this.rbDocumentos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbResumen);
            this.groupBox1.Controls.Add(this.rbRetenciones);
            this.groupBox1.Controls.Add(this.rbDocumentos);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(820, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 91);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de documentos";
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Location = new System.Drawing.Point(6, 16);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.Size = new System.Drawing.Size(751, 364);
            this.DgvConsulta.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DgvConsulta);
            this.tabPage1.Controls.Add(this.BntEnvio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboUrlServicio
            // 
            this.cboUrlServicio.DisplayMember = "Codigo";
            this.cboUrlServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrlServicio.FormattingEnabled = true;
            this.cboUrlServicio.Location = new System.Drawing.Point(463, 17);
            this.cboUrlServicio.Name = "cboUrlServicio";
            this.cboUrlServicio.Size = new System.Drawing.Size(160, 21);
            this.cboUrlServicio.TabIndex = 103;
            this.cboUrlServicio.ValueMember = "Descripcion";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 412);
            this.tabControl1.TabIndex = 108;
            // 
            // BntGeneraXml
            // 
            this.BntGeneraXml.Location = new System.Drawing.Point(260, 55);
            this.BntGeneraXml.Name = "BntGeneraXml";
            this.BntGeneraXml.Size = new System.Drawing.Size(93, 38);
            this.BntGeneraXml.TabIndex = 107;
            this.BntGeneraXml.Text = "Procesar SUNAT";
            this.BntGeneraXml.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(820, 108);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(244, 412);
            this.txtResult.TabIndex = 106;
            // 
            // BntEnvio
            // 
            this.BntEnvio.Location = new System.Drawing.Point(569, -32);
            this.BntEnvio.Name = "BntEnvio";
            this.BntEnvio.Size = new System.Drawing.Size(93, 38);
            this.BntEnvio.TabIndex = 105;
            this.BntEnvio.Text = "Envio SUNAT";
            this.BntEnvio.UseVisualStyleBackColor = true;
            // 
            // BntGenerar
            // 
            this.BntGenerar.Location = new System.Drawing.Point(10, 55);
            this.BntGenerar.Name = "BntGenerar";
            this.BntGenerar.Size = new System.Drawing.Size(94, 38);
            this.BntGenerar.TabIndex = 104;
            this.BntGenerar.Text = "Generar registros";
            this.BntGenerar.UseVisualStyleBackColor = true;
            // 
            // LblCodigoEmpresa
            // 
            this.LblCodigoEmpresa.AutoSize = true;
            this.LblCodigoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoEmpresa.Location = new System.Drawing.Point(13, 20);
            this.LblCodigoEmpresa.Name = "LblCodigoEmpresa";
            this.LblCodigoEmpresa.Size = new System.Drawing.Size(58, 13);
            this.LblCodigoEmpresa.TabIndex = 102;
            this.LblCodigoEmpresa.Text = " Codigo -";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(359, 18);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(98, 20);
            this.DtpFecha.TabIndex = 101;
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresa.Location = new System.Drawing.Point(77, 21);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(276, 13);
            this.LblEmpresa.TabIndex = 100;
            this.LblEmpresa.Text = "---------------- Razon social Empresa .-----------------";
            // 
            // BntBuscaXml
            // 
            this.BntBuscaXml.Location = new System.Drawing.Point(564, 68);
            this.BntBuscaXml.Name = "BntBuscaXml";
            this.BntBuscaXml.Size = new System.Drawing.Size(75, 23);
            this.BntBuscaXml.TabIndex = 113;
            this.BntBuscaXml.Text = "XML";
            this.BntBuscaXml.UseVisualStyleBackColor = true;
            this.BntBuscaXml.Click += new System.EventHandler(this.BntXml_Click);
            // 
            // DtpFechaEnvio
            // 
            this.DtpFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaEnvio.Location = new System.Drawing.Point(359, 62);
            this.DtpFechaEnvio.Name = "DtpFechaEnvio";
            this.DtpFechaEnvio.Size = new System.Drawing.Size(98, 20);
            this.DtpFechaEnvio.TabIndex = 114;
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(437, 82);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(100, 20);
            this.txtNroTicket.TabIndex = 115;
            // 
            // FrmEnvioDocumentosSunat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 536);
            this.Controls.Add(this.txtNroTicket);
            this.Controls.Add(this.DtpFechaEnvio);
            this.Controls.Add(this.BntBuscaXml);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.chkVoz);
            this.Controls.Add(this.btnConsultaTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboUrlServicio);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BntGeneraXml);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.BntGenerar);
            this.Controls.Add(this.LblCodigoEmpresa);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.LblEmpresa);
            this.Name = "FrmEnvioDocumentosSunat";
            this.Text = "FrmEnvioDocumentosSunat";
            this.Load += new System.EventHandler(this.FrmEnvioDocumentosSunat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionSunatBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.CheckBox chkVoz;
        private System.Windows.Forms.Button btnConsultaTicket;
        private System.Windows.Forms.RadioButton rbResumen;
        private System.Windows.Forms.RadioButton rbRetenciones;
        private System.Windows.Forms.RadioButton rbDocumentos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.BindingSource direccionSunatBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.ComboBox cboUrlServicio;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.Button BntGeneraXml;
        private System.Windows.Forms.TextBox txtResult;
        internal System.Windows.Forms.Button BntEnvio;
        internal System.Windows.Forms.Button BntGenerar;
        internal System.Windows.Forms.Label LblCodigoEmpresa;
        internal System.Windows.Forms.DateTimePicker DtpFecha;
        internal System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.Button BntBuscaXml;
        internal System.Windows.Forms.DateTimePicker DtpFechaEnvio;
        private System.Windows.Forms.TextBox txtNroTicket;
    }
}