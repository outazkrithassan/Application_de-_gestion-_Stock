namespace Application_de__gestion__Stock.RAP
{
    partial class FRM_RAPORT
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
            this.RPAfficher = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPAfficher
            // 
            this.RPAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RPAfficher.LocalReport.ReportEmbeddedResource = "Application_de__gestion__Stock.RAP.RPT_Produit.rdlc";
            this.RPAfficher.Location = new System.Drawing.Point(2, 1);
            this.RPAfficher.Name = "RPAfficher";
            this.RPAfficher.ServerReport.BearerToken = null;
            this.RPAfficher.Size = new System.Drawing.Size(588, 437);
            this.RPAfficher.TabIndex = 0;
            this.RPAfficher.Load += new System.EventHandler(this.RPAfficher_Load);
            // 
            // FRM_RAPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 437);
            this.Controls.Add(this.RPAfficher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_RAPORT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.FRM_RAPORT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RPAfficher;
    }
}