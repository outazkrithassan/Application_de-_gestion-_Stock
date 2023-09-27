namespace Application_de__gestion__Stock.PL
{
    partial class USER_Liste_Commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Liste_Commande));
            this.dvgCommande = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateF = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DateD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonajouterCommande = new System.Windows.Forms.Button();
            this.buttonImprimerCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCommande
            // 
            this.dvgCommande.AllowUserToAddRows = false;
            this.dvgCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCommande.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dvgCommande.EnableHeadersVisualStyles = false;
            this.dvgCommande.Location = new System.Drawing.Point(26, 60);
            this.dvgCommande.Name = "dvgCommande";
            this.dvgCommande.RowHeadersVisible = false;
            this.dvgCommande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgCommande.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCommande.Size = new System.Drawing.Size(776, 420);
            this.dvgCommande.TabIndex = 31;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 91.37056F;
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Client";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total HT";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TVA";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TOTAL TTC";
            this.Column7.Name = "Column7";
            // 
            // DateF
            // 
            this.DateF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateF.Location = new System.Drawing.Point(505, 23);
            this.DateF.Name = "DateF";
            this.DateF.Size = new System.Drawing.Size(248, 26);
            this.DateF.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(580, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date Fin :";
            // 
            // DateD
            // 
            this.DateD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateD.Location = new System.Drawing.Point(247, 23);
            this.DateD.Name = "DateD";
            this.DateD.Size = new System.Drawing.Size(248, 26);
            this.DateD.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(299, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date Début :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(756, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonajouterCommande
            // 
            this.buttonajouterCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonajouterCommande.FlatAppearance.BorderSize = 0;
            this.buttonajouterCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonajouterCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajouterCommande.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonajouterCommande.Image = ((System.Drawing.Image)(resources.GetObject("buttonajouterCommande.Image")));
            this.buttonajouterCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonajouterCommande.Location = new System.Drawing.Point(27, -3);
            this.buttonajouterCommande.Name = "buttonajouterCommande";
            this.buttonajouterCommande.Size = new System.Drawing.Size(210, 57);
            this.buttonajouterCommande.TabIndex = 25;
            this.buttonajouterCommande.Text = "Ajouter";
            this.buttonajouterCommande.UseVisualStyleBackColor = false;
            this.buttonajouterCommande.Click += new System.EventHandler(this.buttonajouterCommande_Click);
            // 
            // buttonImprimerCommand
            // 
            this.buttonImprimerCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImprimerCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonImprimerCommand.FlatAppearance.BorderSize = 0;
            this.buttonImprimerCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimerCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonImprimerCommand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonImprimerCommand.Image = ((System.Drawing.Image)(resources.GetObject("buttonImprimerCommand.Image")));
            this.buttonImprimerCommand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImprimerCommand.Location = new System.Drawing.Point(527, 486);
            this.buttonImprimerCommand.Name = "buttonImprimerCommand";
            this.buttonImprimerCommand.Size = new System.Drawing.Size(275, 45);
            this.buttonImprimerCommand.TabIndex = 32;
            this.buttonImprimerCommand.Text = "Imprimer Commande";
            this.buttonImprimerCommand.UseVisualStyleBackColor = false;
            this.buttonImprimerCommand.Click += new System.EventHandler(this.buttonImprimerCommand_Click);
            // 
            // USER_Liste_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgCommande);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonajouterCommande);
            this.Controls.Add(this.buttonImprimerCommand);
            this.Name = "USER_Liste_Commande";
            this.Size = new System.Drawing.Size(829, 528);
            this.Load += new System.EventHandler(this.USER_Liste_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DateF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonajouterCommande;
        private System.Windows.Forms.Button buttonImprimerCommand;
    }
}
