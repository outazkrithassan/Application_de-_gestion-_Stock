namespace Application_de__gestion__Stock.PL
{
    partial class USER_Liste_Produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Liste_Produit));
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textrecherche = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonACT = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonImprimerTouts = new System.Windows.Forms.Button();
            this.buttonImprimerSelect = new System.Windows.Forms.Button();
            this.btnAfficherProduit = new System.Windows.Forms.Button();
            this.buttonsupremeProduit = new System.Windows.Forms.Button();
            this.buttonModifierProduit = new System.Windows.Forms.Button();
            this.buttonajouterProduit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Catigorie";
            this.Column5.Name = "Column5";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(45, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 2);
            this.panel3.TabIndex = 31;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantite";
            this.Column3.Name = "Column3";
            // 
            // textrecherche
            // 
            this.textrecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textrecherche.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textrecherche.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrecherche.ForeColor = System.Drawing.Color.DimGray;
            this.textrecherche.Location = new System.Drawing.Point(45, 70);
            this.textrecherche.Multiline = true;
            this.textrecherche.Name = "textrecherche";
            this.textrecherche.Size = new System.Drawing.Size(460, 30);
            this.textrecherche.TabIndex = 29;
            this.textrecherche.Text = "Rechercher";
            this.textrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textrecherche.TextChanged += new System.EventHandler(this.textrecherche_TextChanged);
            this.textrecherche.Enter += new System.EventHandler(this.textrecherche_Enter);
            this.textrecherche.Leave += new System.EventHandler(this.textrecherche_Leave);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(28, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 3);
            this.panel1.TabIndex = 27;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 91.37056F;
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 101.0787F;
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dvgProduit
            // 
            this.dvgProduit.AllowUserToAddRows = false;
            this.dvgProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.Location = new System.Drawing.Point(16, 118);
            this.dvgProduit.Name = "dvgProduit";
            this.dvgProduit.RowHeadersVisible = false;
            this.dvgProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgProduit.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgProduit.Size = new System.Drawing.Size(796, 357);
            this.dvgProduit.TabIndex = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(28, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 3);
            this.panel2.TabIndex = 28;
            // 
            // buttonACT
            // 
            this.buttonACT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonACT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonACT.FlatAppearance.BorderSize = 0;
            this.buttonACT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonACT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonACT.Image = ((System.Drawing.Image)(resources.GetObject("buttonACT.Image")));
            this.buttonACT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonACT.Location = new System.Drawing.Point(616, 66);
            this.buttonACT.Name = "buttonACT";
            this.buttonACT.Size = new System.Drawing.Size(185, 38);
            this.buttonACT.TabIndex = 36;
            this.buttonACT.Text = "Actualiser";
            this.buttonACT.UseVisualStyleBackColor = false;
            this.buttonACT.Click += new System.EventHandler(this.buttonACT_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonExcel.FlatAppearance.BorderSize = 0;
            this.buttonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExcel.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcel.Image")));
            this.buttonExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcel.Location = new System.Drawing.Point(535, 484);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(274, 45);
            this.buttonExcel.TabIndex = 35;
            this.buttonExcel.Text = "Souvgarder dans Excel";
            this.buttonExcel.UseVisualStyleBackColor = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonImprimerTouts
            // 
            this.buttonImprimerTouts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonImprimerTouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonImprimerTouts.FlatAppearance.BorderSize = 0;
            this.buttonImprimerTouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimerTouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonImprimerTouts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonImprimerTouts.Image = ((System.Drawing.Image)(resources.GetObject("buttonImprimerTouts.Image")));
            this.buttonImprimerTouts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImprimerTouts.Location = new System.Drawing.Point(294, 484);
            this.buttonImprimerTouts.Name = "buttonImprimerTouts";
            this.buttonImprimerTouts.Size = new System.Drawing.Size(235, 45);
            this.buttonImprimerTouts.TabIndex = 34;
            this.buttonImprimerTouts.Text = "Imprimer Touts";
            this.buttonImprimerTouts.UseVisualStyleBackColor = false;
            this.buttonImprimerTouts.Click += new System.EventHandler(this.buttonImprimerTouts_Click);
            // 
            // buttonImprimerSelect
            // 
            this.buttonImprimerSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImprimerSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonImprimerSelect.FlatAppearance.BorderSize = 0;
            this.buttonImprimerSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimerSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonImprimerSelect.Image = ((System.Drawing.Image)(resources.GetObject("buttonImprimerSelect.Image")));
            this.buttonImprimerSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImprimerSelect.Location = new System.Drawing.Point(22, 484);
            this.buttonImprimerSelect.Name = "buttonImprimerSelect";
            this.buttonImprimerSelect.Size = new System.Drawing.Size(266, 45);
            this.buttonImprimerSelect.TabIndex = 33;
            this.buttonImprimerSelect.Text = "Imprimer PR couche";
            this.buttonImprimerSelect.UseVisualStyleBackColor = false;
            this.buttonImprimerSelect.Click += new System.EventHandler(this.buttonImprimerSelect_Click);
            // 
            // btnAfficherProduit
            // 
            this.btnAfficherProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAfficherProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnAfficherProduit.FlatAppearance.BorderSize = 0;
            this.btnAfficherProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficherProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAfficherProduit.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficherProduit.Image")));
            this.btnAfficherProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficherProduit.Location = new System.Drawing.Point(616, -1);
            this.btnAfficherProduit.Name = "btnAfficherProduit";
            this.btnAfficherProduit.Size = new System.Drawing.Size(185, 53);
            this.btnAfficherProduit.TabIndex = 32;
            this.btnAfficherProduit.Text = "Afficher";
            this.btnAfficherProduit.UseVisualStyleBackColor = false;
            this.btnAfficherProduit.Click += new System.EventHandler(this.btnAfficherProduit_Click);
            // 
            // buttonsupremeProduit
            // 
            this.buttonsupremeProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonsupremeProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonsupremeProduit.FlatAppearance.BorderSize = 0;
            this.buttonsupremeProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsupremeProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupremeProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonsupremeProduit.Image = ((System.Drawing.Image)(resources.GetObject("buttonsupremeProduit.Image")));
            this.buttonsupremeProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsupremeProduit.Location = new System.Drawing.Point(420, -1);
            this.buttonsupremeProduit.Name = "buttonsupremeProduit";
            this.buttonsupremeProduit.Size = new System.Drawing.Size(185, 53);
            this.buttonsupremeProduit.TabIndex = 26;
            this.buttonsupremeProduit.Text = "Supprimer";
            this.buttonsupremeProduit.UseVisualStyleBackColor = false;
            this.buttonsupremeProduit.Click += new System.EventHandler(this.buttonsupremeProduit_Click);
            // 
            // buttonModifierProduit
            // 
            this.buttonModifierProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonModifierProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonModifierProduit.FlatAppearance.BorderSize = 0;
            this.buttonModifierProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModifierProduit.Image = ((System.Drawing.Image)(resources.GetObject("buttonModifierProduit.Image")));
            this.buttonModifierProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierProduit.Location = new System.Drawing.Point(224, -1);
            this.buttonModifierProduit.Name = "buttonModifierProduit";
            this.buttonModifierProduit.Size = new System.Drawing.Size(185, 53);
            this.buttonModifierProduit.TabIndex = 25;
            this.buttonModifierProduit.Text = "Modifier";
            this.buttonModifierProduit.UseVisualStyleBackColor = false;
            this.buttonModifierProduit.Click += new System.EventHandler(this.buttonModifierProduit_Click);
            // 
            // buttonajouterProduit
            // 
            this.buttonajouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonajouterProduit.FlatAppearance.BorderSize = 0;
            this.buttonajouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonajouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajouterProduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonajouterProduit.Image = ((System.Drawing.Image)(resources.GetObject("buttonajouterProduit.Image")));
            this.buttonajouterProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonajouterProduit.Location = new System.Drawing.Point(28, -1);
            this.buttonajouterProduit.Name = "buttonajouterProduit";
            this.buttonajouterProduit.Size = new System.Drawing.Size(185, 53);
            this.buttonajouterProduit.TabIndex = 24;
            this.buttonajouterProduit.Text = "Ajouter";
            this.buttonajouterProduit.UseVisualStyleBackColor = false;
            this.buttonajouterProduit.Click += new System.EventHandler(this.buttonajouterProduit_Click);
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonACT);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonImprimerTouts);
            this.Controls.Add(this.buttonImprimerSelect);
            this.Controls.Add(this.btnAfficherProduit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textrecherche);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonsupremeProduit);
            this.Controls.Add(this.buttonModifierProduit);
            this.Controls.Add(this.buttonajouterProduit);
            this.Controls.Add(this.dvgProduit);
            this.Controls.Add(this.panel2);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(829, 528);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonACT;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonImprimerTouts;
        private System.Windows.Forms.Button buttonImprimerSelect;
        private System.Windows.Forms.Button btnAfficherProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textrecherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonsupremeProduit;
        private System.Windows.Forms.Button buttonModifierProduit;
        private System.Windows.Forms.Button buttonajouterProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel2;
    }
}
