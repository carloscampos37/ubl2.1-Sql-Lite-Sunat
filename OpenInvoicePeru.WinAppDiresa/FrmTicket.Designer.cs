namespace OpenInvoicePeru.WinApp
{
    partial class FrmTicket : PlantillaBase
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
            this.TxtNroTicket = new System.Windows.Forms.TextBox();
            this.BntOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNroTicket
            // 
            this.TxtNroTicket.Location = new System.Drawing.Point(70, 31);
            this.TxtNroTicket.Name = "TxtNroTicket";
            this.TxtNroTicket.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtNroTicket.Size = new System.Drawing.Size(143, 22);
            this.TxtNroTicket.TabIndex = 0;
            // 
            // BntOK
            // 
            this.BntOK.Location = new System.Drawing.Point(70, 82);
            this.BntOK.Name = "BntOK";
            this.BntOK.Size = new System.Drawing.Size(119, 23);
            this.BntOK.TabIndex = 1;
            this.BntOK.Text = "Aceptar";
            this.BntOK.UseVisualStyleBackColor = true;
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 163);
            this.Controls.Add(this.BntOK);
            this.Controls.Add(this.TxtNroTicket);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTicket";
            this.ShowInTaskbar = false;
            this.Text = "Ingrese el N° de Ticket";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNroTicket;
        private System.Windows.Forms.Button BntOK;
    }
}