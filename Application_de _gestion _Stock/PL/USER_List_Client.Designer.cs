namespace Application_de__gestion__Stock.PL
{
    partial class USER_List_Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_List_Client));
            this.panel3 = new System.Windows.Forms.Panel();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgClient = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comborechercher = new System.Windows.Forms.ComboBox();
            this.textrecherche = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonsupremeClient = new System.Windows.Forms.Button();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.buttonajouterClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(438, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 2);
            this.panel3.TabIndex = 18;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 101.0787F;
            this.Column7.HeaderText = "Pays";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.FillWeight = 101.0787F;
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 101.0787F;
            this.Column5.HeaderText = "Telephone";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 101.0787F;
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 101.0787F;
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 101.0787F;
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
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
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dvgClient
            // 
            this.dvgClient.AllowUserToAddRows = false;
            this.dvgClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7,
            this.Column6});
            this.dvgClient.EnableHeadersVisualStyles = false;
            this.dvgClient.Location = new System.Drawing.Point(28, 140);
            this.dvgClient.Name = "dvgClient";
            this.dvgClient.RowHeadersVisible = false;
            this.dvgClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgClient.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgClient.Size = new System.Drawing.Size(773, 375);
            this.dvgClient.TabIndex = 17;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 101.0787F;
            this.Column6.HeaderText = "Ville";
            this.Column6.Name = "Column6";
            // 
            // comborechercher
            // 
            this.comborechercher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comborechercher.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comborechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborechercher.FormattingEnabled = true;
            this.comborechercher.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.comborechercher.Location = new System.Drawing.Point(166, 81);
            this.comborechercher.Name = "comborechercher";
            this.comborechercher.Size = new System.Drawing.Size(220, 33);
            this.comborechercher.TabIndex = 16;
            // 
            // textrecherche
            // 
            this.textrecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textrecherche.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textrecherche.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrecherche.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textrecherche.Location = new System.Drawing.Point(438, 83);
            this.textrecherche.Multiline = true;
            this.textrecherche.Name = "textrecherche";
            this.textrecherche.Size = new System.Drawing.Size(210, 30);
            this.textrecherche.TabIndex = 15;
            this.textrecherche.Text = "Rechercher";
            this.textrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textrecherche.TextChanged += new System.EventHandler(this.textrecherche_TextChanged);
            this.textrecherche.Enter += new System.EventHandler(this.textrecherche_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(28, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 3);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(28, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 3);
            this.panel1.TabIndex = 13;
            // 
            // buttonsupremeClient
            // 
            this.buttonsupremeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsupremeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonsupremeClient.FlatAppearance.BorderSize = 0;
            this.buttonsupremeClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsupremeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupremeClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonsupremeClient.Image = ((System.Drawing.Image)(resources.GetObject("buttonsupremeClient.Image")));
            this.buttonsupremeClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsupremeClient.Location = new System.Drawing.Point(571, 2);
            this.buttonsupremeClient.Name = "buttonsupremeClient";
            this.buttonsupremeClient.Size = new System.Drawing.Size(230, 53);
            this.buttonsupremeClient.TabIndex = 12;
            this.buttonsupremeClient.Text = "Supprimer";
            this.buttonsupremeClient.UseVisualStyleBackColor = false;
            this.buttonsupremeClient.Click += new System.EventHandler(this.buttonsupremeClient_Click);
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonModifierClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonModifierClient.FlatAppearance.BorderSize = 0;
            this.buttonModifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModifierClient.Image = ((System.Drawing.Image)(resources.GetObject("buttonModifierClient.Image")));
            this.buttonModifierClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierClient.Location = new System.Drawing.Point(297, 2);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(230, 53);
            this.buttonModifierClient.TabIndex = 11;
            this.buttonModifierClient.Text = "Modifier";
            this.buttonModifierClient.UseVisualStyleBackColor = false;
            this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // buttonajouterClient
            // 
            this.buttonajouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonajouterClient.FlatAppearance.BorderSize = 0;
            this.buttonajouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonajouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajouterClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonajouterClient.Image = ((System.Drawing.Image)(resources.GetObject("buttonajouterClient.Image")));
            this.buttonajouterClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonajouterClient.Location = new System.Drawing.Point(28, 2);
            this.buttonajouterClient.Name = "buttonajouterClient";
            this.buttonajouterClient.Size = new System.Drawing.Size(230, 53);
            this.buttonajouterClient.TabIndex = 10;
            this.buttonajouterClient.Text = "Ajouter";
            this.buttonajouterClient.UseVisualStyleBackColor = false;
            this.buttonajouterClient.Click += new System.EventHandler(this.buttonajouterClient_Click);
            // 
            // USER_List_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dvgClient);
            this.Controls.Add(this.comborechercher);
            this.Controls.Add(this.textrecherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonsupremeClient);
            this.Controls.Add(this.buttonModifierClient);
            this.Controls.Add(this.buttonajouterClient);
            this.Name = "USER_List_Client";
            this.Size = new System.Drawing.Size(829, 528);
            this.Load += new System.EventHandler(this.USER_List_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dvgClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox comborechercher;
        private System.Windows.Forms.TextBox textrecherche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonsupremeClient;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonajouterClient;
    }
}
