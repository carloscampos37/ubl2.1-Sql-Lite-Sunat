using OpenInvoicePeru.FacturasElectronicas;
using System.Windows.Forms;

namespace OpenInvoicePeru.FacturasElectronicas
{
    partial class FrmEnviarDocumentosSunat : PlantillaBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.direccionSunatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblEmpresaCodigo = new System.Windows.Forms.Label();
            this.LblEmpresaDescripcion = new System.Windows.Forms.Label();
            this.DtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BntGeneraXml = new System.Windows.Forms.Button();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkVoz = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbResumen = new System.Windows.Forms.RadioButton();
            this.rbRetenciones = new System.Windows.Forms.RadioButton();
            this.rbDocumentos = new System.Windows.Forms.RadioButton();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.cboUrlServicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.direccionSunatBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionSunatBindingSource
            // 
            this.direccionSunatBindingSource.DataSource = typeof(OpenInvoicePeru.Entidades.DireccionSunat);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.LblEmpresaCodigo);
            this.panel1.Controls.Add(this.LblEmpresaDescripcion);
            this.panel1.Controls.Add(this.DtpFechaEnvio);
            this.panel1.Controls.Add(this.DtpFecha);
            this.panel1.Controls.Add(this.BntGeneraXml);
            this.panel1.Controls.Add(this.txtNroTicket);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSource);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkVoz);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnGen);
            this.panel1.Controls.Add(this.btnGetStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboTipoDoc);
            this.panel1.Controls.Add(this.cboUrlServicio);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 146);
            this.panel1.TabIndex = 0;
            // 
            // LblEmpresaCodigo
            // 
            this.LblEmpresaCodigo.AutoSize = true;
            this.LblEmpresaCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LblEmpresaCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresaCodigo.Location = new System.Drawing.Point(70, 11);
            this.LblEmpresaCodigo.Name = "LblEmpresaCodigo";
            this.LblEmpresaCodigo.Size = new System.Drawing.Size(88, 15);
            this.LblEmpresaCodigo.TabIndex = 90;
            this.LblEmpresaCodigo.Text = "Url del Servicio:";
            // 
            // LblEmpresaDescripcion
            // 
            this.LblEmpresaDescripcion.AutoSize = true;
            this.LblEmpresaDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.LblEmpresaDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresaDescripcion.Location = new System.Drawing.Point(26, 36);
            this.LblEmpresaDescripcion.Name = "LblEmpresaDescripcion";
            this.LblEmpresaDescripcion.Size = new System.Drawing.Size(73, 15);
            this.LblEmpresaDescripcion.TabIndex = 89;
            this.LblEmpresaDescripcion.Text = "Razon Social";
            // 
            // DtpFechaEnvio
            // 
            this.DtpFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaEnvio.Location = new System.Drawing.Point(253, 88);
            this.DtpFechaEnvio.Name = "DtpFechaEnvio";
            this.DtpFechaEnvio.Size = new System.Drawing.Size(92, 21);
            this.DtpFechaEnvio.TabIndex = 88;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(253, 33);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(92, 21);
            this.DtpFecha.TabIndex = 87;
            // 
            // BntGeneraXml
            // 
            this.BntGeneraXml.Location = new System.Drawing.Point(595, 3);
            this.BntGeneraXml.Name = "BntGeneraXml";
            this.BntGeneraXml.Size = new System.Drawing.Size(99, 28);
            this.BntGeneraXml.TabIndex = 86;
            this.BntGeneraXml.Text = "Documentos";
            this.BntGeneraXml.UseVisualStyleBackColor = true;
            this.BntGeneraXml.Click += new System.EventHandler(this.BntGeneraXml_Click);
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(722, 66);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(117, 21);
            this.txtNroTicket.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 85;
            this.label5.Text = "Fecha Envio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 84;
            this.label6.Text = "Fecha Docum.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 83;
            this.label4.Text = "Documento XML";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(253, 115);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(317, 21);
            this.txtSource.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Tipo de Documento:";
            // 
            // chkVoz
            // 
            this.chkVoz.AutoSize = true;
            this.chkVoz.Checked = true;
            this.chkVoz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVoz.Location = new System.Drawing.Point(595, 37);
            this.chkVoz.Name = "chkVoz";
            this.chkVoz.Size = new System.Drawing.Size(118, 17);
            this.chkVoz.TabIndex = 80;
            this.chkVoz.Text = "Hablar en voz alta";
            this.chkVoz.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(595, 102);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 34);
            this.btnBrowse.TabIndex = 78;
            this.btnBrowse.Text = "E&xaminar XML";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(595, 60);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(103, 30);
            this.btnGen.TabIndex = 77;
            this.btnGen.Text = "&Enviar a SUNAT";
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(732, 100);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(107, 36);
            this.btnGetStatus.TabIndex = 76;
            this.btnGetStatus.Text = "Consultar N° Ticket";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Serie-Correlativo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(428, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "Url del Servicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbResumen);
            this.groupBox1.Controls.Add(this.rbRetenciones);
            this.groupBox1.Controls.Add(this.rbDocumentos);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 83);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de documentos";
            // 
            // rbResumen
            // 
            this.rbResumen.AutoSize = true;
            this.rbResumen.Location = new System.Drawing.Point(15, 66);
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
            this.rbRetenciones.Location = new System.Drawing.Point(15, 43);
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
            this.rbDocumentos.Location = new System.Drawing.Point(15, 20);
            this.rbDocumentos.Name = "rbDocumentos";
            this.rbDocumentos.Size = new System.Drawing.Size(145, 17);
            this.rbDocumentos.TabIndex = 6;
            this.rbDocumentos.TabStop = true;
            this.rbDocumentos.Text = "Factura, Boleta, NC, ND";
            this.rbDocumentos.UseVisualStyleBackColor = true;
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
            this.cboTipoDoc.Location = new System.Drawing.Point(389, 71);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(181, 21);
            this.cboTipoDoc.TabIndex = 58;
            this.cboTipoDoc.ValueMember = "Descripcion";
            // 
            // cboUrlServicio
            // 
            this.cboUrlServicio.BackColor = System.Drawing.Color.White;
            this.cboUrlServicio.DataSource = this.direccionSunatBindingSource;
            this.cboUrlServicio.DisplayMember = "Codigo";
            this.cboUrlServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrlServicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUrlServicio.FormattingEnabled = true;
            this.cboUrlServicio.Location = new System.Drawing.Point(389, 29);
            this.cboUrlServicio.Name = "cboUrlServicio";
            this.cboUrlServicio.Size = new System.Drawing.Size(181, 21);
            this.cboUrlServicio.TabIndex = 57;
            this.cboUrlServicio.ValueMember = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "Resultados";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(553, 42);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(242, 350);
            this.txtResult.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DgvConsulta);
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 411);
            this.panel2.TabIndex = 73;
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Location = new System.Drawing.Point(21, 42);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.Size = new System.Drawing.Size(506, 349);
            this.DgvConsulta.TabIndex = 73;
            // 
            // FrmEnviarSunat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(860, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmEnviarSunat";
            this.Text = "OpenInvoicePeru - Prueba de Envio a SUNAT";
            this.Load += new System.EventHandler(this.FrmEnviarSunat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.direccionSunatBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource direccionSunatBindingSource;
        private Panel panel1;
        private Label label1;
        private CheckBox chkVoz;
        private Button btnGen;
        private Button btnGetStatus;
        private Label label3;
        private Label label2;
        private Label label10;
        private GroupBox groupBox1;
        private TextBox txtResult;
        private TextBox txtNroTicket;
        internal ComboBox cboTipoDoc;
        private ComboBox cboUrlServicio;
        private RadioButton rbDocumentos;
        private RadioButton rbRetenciones;
        private RadioButton rbResumen;
        private Button btnBrowse;
        private TextBox txtSource;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LblEmpresaCodigo;
        private Label LblEmpresaDescripcion;
        private DateTimePicker DtpFechaEnvio;
        private DateTimePicker DtpFecha;
        private Button BntGeneraXml;
        private Panel panel2;
        private DataGridView DgvConsulta;
    }
}