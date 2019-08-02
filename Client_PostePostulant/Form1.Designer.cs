namespace Client_PostePostulant
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.comboBoxGetAll = new System.Windows.Forms.ComboBox();
            this.CheckedListBoxLangages = new System.Windows.Forms.CheckedListBox();
            this.buttonLangages = new System.Windows.Forms.Button();
            this.dataGridViewMatches = new System.Windows.Forms.DataGridView();
            this.buttonChercherPostes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(35, 34);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(306, 29);
            this.buttonGetAll.TabIndex = 1;
            this.buttonGetAll.Text = "Lister les postulants";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            this.buttonGetAll.Click += new System.EventHandler(this.ButtonGetAll_Click);
            // 
            // comboBoxGetAll
            // 
            this.comboBoxGetAll.FormattingEnabled = true;
            this.comboBoxGetAll.Location = new System.Drawing.Point(35, 69);
            this.comboBoxGetAll.Name = "comboBoxGetAll";
            this.comboBoxGetAll.Size = new System.Drawing.Size(303, 24);
            this.comboBoxGetAll.TabIndex = 2;
            // 
            // CheckedListBoxLangages
            // 
            this.CheckedListBoxLangages.FormattingEnabled = true;
            this.CheckedListBoxLangages.Location = new System.Drawing.Point(35, 164);
            this.CheckedListBoxLangages.Name = "CheckedListBoxLangages";
            this.CheckedListBoxLangages.Size = new System.Drawing.Size(152, 174);
            this.CheckedListBoxLangages.TabIndex = 3;
            this.CheckedListBoxLangages.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxLangages_SelectedIndexChanged);
            // 
            // buttonLangages
            // 
            this.buttonLangages.Location = new System.Drawing.Point(35, 129);
            this.buttonLangages.Name = "buttonLangages";
            this.buttonLangages.Size = new System.Drawing.Size(152, 29);
            this.buttonLangages.TabIndex = 4;
            this.buttonLangages.Text = "Chercher Langages";
            this.buttonLangages.UseVisualStyleBackColor = true;
            this.buttonLangages.Click += new System.EventHandler(this.ButtonLangages_Click);
            // 
            // dataGridViewMatches
            // 
            this.dataGridViewMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatches.Location = new System.Drawing.Point(214, 164);
            this.dataGridViewMatches.Name = "dataGridViewMatches";
            this.dataGridViewMatches.RowTemplate.Height = 24;
            this.dataGridViewMatches.Size = new System.Drawing.Size(515, 259);
            this.dataGridViewMatches.TabIndex = 5;
            // 
            // buttonChercherPostes
            // 
            this.buttonChercherPostes.Location = new System.Drawing.Point(214, 129);
            this.buttonChercherPostes.Name = "buttonChercherPostes";
            this.buttonChercherPostes.Size = new System.Drawing.Size(139, 29);
            this.buttonChercherPostes.TabIndex = 6;
            this.buttonChercherPostes.Text = "Chercher Postes";
            this.buttonChercherPostes.UseVisualStyleBackColor = true;
            this.buttonChercherPostes.Click += new System.EventHandler(this.ButtonChercherPostes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.buttonChercherPostes);
            this.Controls.Add(this.dataGridViewMatches);
            this.Controls.Add(this.buttonLangages);
            this.Controls.Add(this.CheckedListBoxLangages);
            this.Controls.Add(this.comboBoxGetAll);
            this.Controls.Add(this.buttonGetAll);
            this.Name = "Form1";
            this.Text = "Postulants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.ComboBox comboBoxGetAll;
        private System.Windows.Forms.CheckedListBox CheckedListBoxLangages;
        private System.Windows.Forms.Button buttonLangages;
        private System.Windows.Forms.DataGridView dataGridViewMatches;
        private System.Windows.Forms.Button buttonChercherPostes;
    }
}

