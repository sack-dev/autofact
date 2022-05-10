
namespace Login
{
    partial class Document
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectClient = new System.Windows.Forms.ComboBox();
            this.DescriptionDoc = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.SaveFacture = new System.Windows.Forms.Button();
            this.SaveDevis = new System.Windows.Forms.Button();
            this.Déconnexion = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quantite = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Déconnexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 6);
            this.panel1.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1333, 6);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // SelectClient
            // 
            this.SelectClient.FormattingEnabled = true;
            this.SelectClient.Location = new System.Drawing.Point(333, 80);
            this.SelectClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectClient.Name = "SelectClient";
            this.SelectClient.Size = new System.Drawing.Size(265, 24);
            this.SelectClient.TabIndex = 22;
            // 
            // DescriptionDoc
            // 
            this.DescriptionDoc.Location = new System.Drawing.Point(900, 80);
            this.DescriptionDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionDoc.Name = "DescriptionDoc";
            this.DescriptionDoc.Size = new System.Drawing.Size(265, 22);
            this.DescriptionDoc.TabIndex = 23;
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.Location = new System.Drawing.Point(133, 80);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(184, 23);
            this.Client.TabIndex = 32;
            this.Client.Text = "Selection du Client :";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(633, 80);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(241, 23);
            this.Description.TabIndex = 33;
            this.Description.Text = "Description du Document :";
            // 
            // SaveFacture
            // 
            this.SaveFacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SaveFacture.CausesValidation = false;
            this.SaveFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFacture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFacture.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveFacture.Location = new System.Drawing.Point(860, 620);
            this.SaveFacture.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveFacture.Name = "SaveFacture";
            this.SaveFacture.Size = new System.Drawing.Size(267, 62);
            this.SaveFacture.TabIndex = 35;
            this.SaveFacture.Text = "Enregistrer la Facture";
            this.SaveFacture.UseVisualStyleBackColor = false;
            this.SaveFacture.Click += new System.EventHandler(this.SaveFacture_Click);
            // 
            // SaveDevis
            // 
            this.SaveDevis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SaveDevis.CausesValidation = false;
            this.SaveDevis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDevis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDevis.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveDevis.Location = new System.Drawing.Point(210, 620);
            this.SaveDevis.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveDevis.Name = "SaveDevis";
            this.SaveDevis.Size = new System.Drawing.Size(267, 62);
            this.SaveDevis.TabIndex = 37;
            this.SaveDevis.Text = "Enregistrer le Devis";
            this.SaveDevis.UseVisualStyleBackColor = false;
            this.SaveDevis.Click += new System.EventHandler(this.SaveDevis_Click);
            // 
            // Déconnexion
            // 
            this.Déconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Déconnexion.Image = global::Login.Properties.Resources.deconnection;
            this.Déconnexion.Location = new System.Drawing.Point(1200, 62);
            this.Déconnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Déconnexion.Name = "Déconnexion";
            this.Déconnexion.Size = new System.Drawing.Size(67, 62);
            this.Déconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Déconnexion.TabIndex = 38;
            this.Déconnexion.TabStop = false;
            this.Déconnexion.Click += new System.EventHandler(this.Déconnexion_Click);
            // 
            // Home
            // 
            this.Home.Image = global::Login.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(40, 62);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(67, 62);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 39;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantite,
            this.Nom,
            this.TVA,
            this.Prix});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(40, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 468);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "QUANTITE";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.quantite.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantite.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.quantite.HeaderText = "Quantité";
            this.quantite.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantite.MinimumWidth = 8;
            this.quantite.Name = "quantite";
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "NOM";
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            // 
            // TVA
            // 
            this.TVA.DataPropertyName = "TVA";
            this.TVA.HeaderText = "TVA";
            this.TVA.MinimumWidth = 8;
            this.TVA.Name = "TVA";
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "PRIX";
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 8;
            this.Prix.Name = "Prix";
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Déconnexion);
            this.Controls.Add(this.SaveDevis);
            this.Controls.Add(this.SaveFacture);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.DescriptionDoc);
            this.Controls.Add(this.SelectClient);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document";
            this.Load += new System.EventHandler(this.Document_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Déconnexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox SelectClient;
        private System.Windows.Forms.TextBox DescriptionDoc;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button SaveFacture;
        private System.Windows.Forms.Button SaveDevis;
        private System.Windows.Forms.PictureBox Déconnexion;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
    }
}