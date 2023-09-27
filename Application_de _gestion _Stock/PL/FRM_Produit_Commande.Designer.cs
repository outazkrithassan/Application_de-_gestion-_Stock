namespace Application_de__gestion__Stock.PL
{
    partial class FRM_Produit_Commande
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
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textRemise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textQuantite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPrix = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpproduit = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.grpproduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonEnregistrer.FlatAppearance.BorderSize = 0;
            this.buttonEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrer.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEnregistrer.Location = new System.Drawing.Point(120, 317);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(293, 43);
            this.buttonEnregistrer.TabIndex = 36;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = false;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "%";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(272, 226);
            this.textTotal.Multiline = true;
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(195, 31);
            this.textTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "- - Total  - - - - - - - -";
            // 
            // textRemise
            // 
            this.textRemise.Location = new System.Drawing.Point(272, 136);
            this.textRemise.Multiline = true;
            this.textRemise.Name = "textRemise";
            this.textRemise.Size = new System.Drawing.Size(170, 31);
            this.textRemise.TabIndex = 5;
            this.textRemise.TextChanged += new System.EventHandler(this.textRemise_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "- - Remise  - - - - - - - -";
            // 
            // textQuantite
            // 
            this.textQuantite.Location = new System.Drawing.Point(272, 49);
            this.textQuantite.Multiline = true;
            this.textQuantite.Name = "textQuantite";
            this.textQuantite.Size = new System.Drawing.Size(195, 31);
            this.textQuantite.TabIndex = 3;
            this.textQuantite.TextChanged += new System.EventHandler(this.textQuantite_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "- - Quantité  - - - - - - - -";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Cursor = System.Windows.Forms.Cursors.No;
            this.lbStock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.ForeColor = System.Drawing.Color.White;
            this.lbStock.Location = new System.Drawing.Point(75, 144);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(26, 25);
            this.lbStock.TabIndex = 48;
            this.lbStock.Text = "ls";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Cursor = System.Windows.Forms.Cursors.No;
            this.lbNom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(75, 82);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(30, 25);
            this.lbNom.TabIndex = 47;
            this.lbNom.Text = "ln";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(15, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Stock :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbPrix);
            this.groupBox2.Controls.Add(this.lbStock);
            this.groupBox2.Controls.Add(this.lbNom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(6, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détail Produit";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Cursor = System.Windows.Forms.Cursors.No;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(75, 32);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 25);
            this.labelID.TabIndex = 51;
            this.labelID.Text = "ll";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.No;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(15, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Id :";
            // 
            // lbPrix
            // 
            this.lbPrix.AutoSize = true;
            this.lbPrix.Cursor = System.Windows.Forms.Cursors.No;
            this.lbPrix.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrix.ForeColor = System.Drawing.Color.White;
            this.lbPrix.Location = new System.Drawing.Point(75, 209);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(31, 25);
            this.lbPrix.TabIndex = 49;
            this.lbPrix.Text = "lp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.No;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(15, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nom :";
            // 
            // grpproduit
            // 
            this.grpproduit.Controls.Add(this.label6);
            this.grpproduit.Controls.Add(this.textTotal);
            this.grpproduit.Controls.Add(this.label3);
            this.grpproduit.Controls.Add(this.textRemise);
            this.grpproduit.Controls.Add(this.label2);
            this.grpproduit.Controls.Add(this.textQuantite);
            this.grpproduit.Controls.Add(this.label1);
            this.grpproduit.Controls.Add(this.groupBox2);
            this.grpproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpproduit.ForeColor = System.Drawing.SystemColors.Control;
            this.grpproduit.Location = new System.Drawing.Point(1, 12);
            this.grpproduit.Name = "grpproduit";
            this.grpproduit.Size = new System.Drawing.Size(479, 299);
            this.grpproduit.TabIndex = 35;
            this.grpproduit.TabStop = false;
            this.grpproduit.Text = "Vendre Produit";
            // 
            // FRM_Produit_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(479, 369);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.grpproduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Produit_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.FRM_Produit_Commande_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpproduit.ResumeLayout(false);
            this.grpproduit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textRemise;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textQuantite;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbStock;
        public System.Windows.Forms.Label lbNom;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lbPrix;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox grpproduit;
    }
}