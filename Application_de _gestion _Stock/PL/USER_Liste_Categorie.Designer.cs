namespace Application_de__gestion__Stock.PL
{
    partial class USER_Liste_Categorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Liste_Categorie));
            this.dvgCategorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textrecherche = new System.Windows.Forms.TextBox();
            this.buttonajouterCategorie = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonImprimerTouts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCategorie
            // 
            this.dvgCategorie.AllowUserToAddRows = false;
            this.dvgCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCategorie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Modifier,
            this.Supprimer});
            this.dvgCategorie.EnableHeadersVisualStyles = false;
            this.dvgCategorie.Location = new System.Drawing.Point(27, 67);
            this.dvgCategorie.Name = "dvgCategorie";
            this.dvgCategorie.RowHeadersVisible = false;
            this.dvgCategorie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgCategorie.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dvgCategorie.Size = new System.Drawing.Size(773, 408);
            this.dvgCategorie.TabIndex = 28;
            this.dvgCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCategorie_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 101.0787F;
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 91.37056F;
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 101.0787F;
            this.Column2.HeaderText = "Nom Categorie";
            this.Column2.Name = "Column2";
            // 
            // Modifier
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle10;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            this.Supprimer.DefaultCellStyle = dataGridViewCellStyle11;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(400, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 3);
            this.panel3.TabIndex = 27;
            // 
            // textrecherche
            // 
            this.textrecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textrecherche.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textrecherche.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrecherche.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textrecherche.Location = new System.Drawing.Point(400, 14);
            this.textrecherche.Multiline = true;
            this.textrecherche.Name = "textrecherche";
            this.textrecherche.Size = new System.Drawing.Size(339, 31);
            this.textrecherche.TabIndex = 26;
            this.textrecherche.Text = "Rechercher";
            this.textrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textrecherche.TextChanged += new System.EventHandler(this.textrecherche_TextChanged);
            this.textrecherche.Enter += new System.EventHandler(this.textrecherche_Enter);
            this.textrecherche.Leave += new System.EventHandler(this.textrecherche_Leave);
            // 
            // buttonajouterCategorie
            // 
            this.buttonajouterCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonajouterCategorie.FlatAppearance.BorderSize = 0;
            this.buttonajouterCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonajouterCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajouterCategorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonajouterCategorie.Image = ((System.Drawing.Image)(resources.GetObject("buttonajouterCategorie.Image")));
            this.buttonajouterCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonajouterCategorie.Location = new System.Drawing.Point(28, 3);
            this.buttonajouterCategorie.Name = "buttonajouterCategorie";
            this.buttonajouterCategorie.Size = new System.Drawing.Size(255, 53);
            this.buttonajouterCategorie.TabIndex = 25;
            this.buttonajouterCategorie.Text = "Ajouter";
            this.buttonajouterCategorie.UseVisualStyleBackColor = false;
            this.buttonajouterCategorie.Click += new System.EventHandler(this.buttonajouterCategorie_Click);
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
            this.buttonExcel.Location = new System.Drawing.Point(526, 481);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(275, 45);
            this.buttonExcel.TabIndex = 30;
            this.buttonExcel.Text = "Souvgarder dans Excel";
            this.buttonExcel.UseVisualStyleBackColor = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonImprimerTouts
            // 
            this.buttonImprimerTouts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImprimerTouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonImprimerTouts.FlatAppearance.BorderSize = 0;
            this.buttonImprimerTouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimerTouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonImprimerTouts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonImprimerTouts.Image = ((System.Drawing.Image)(resources.GetObject("buttonImprimerTouts.Image")));
            this.buttonImprimerTouts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImprimerTouts.Location = new System.Drawing.Point(27, 481);
            this.buttonImprimerTouts.Name = "buttonImprimerTouts";
            this.buttonImprimerTouts.Size = new System.Drawing.Size(275, 45);
            this.buttonImprimerTouts.TabIndex = 29;
            this.buttonImprimerTouts.Text = "Imprimer Touts";
            this.buttonImprimerTouts.UseVisualStyleBackColor = false;
            this.buttonImprimerTouts.Click += new System.EventHandler(this.buttonImprimerTouts_Click);
            // 
            // USER_Liste_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgCategorie);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textrecherche);
            this.Controls.Add(this.buttonajouterCategorie);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonImprimerTouts);
            this.Name = "USER_Liste_Categorie";
            this.Size = new System.Drawing.Size(829, 528);
            this.Load += new System.EventHandler(this.USER_Liste_Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textrecherche;
        private System.Windows.Forms.Button buttonajouterCategorie;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonImprimerTouts;
    }
}
