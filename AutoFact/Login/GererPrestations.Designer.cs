
namespace Login
{
    partial class GererPrestations
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Chercher = new System.Windows.Forms.Button();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.AjouterPresta = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.PictureBox();
            this.Deconnexion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deconnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel5.Location = new System.Drawing.Point(0, 30);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1000, 5);
            this.panel5.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 5);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Login.Properties.Resources.Logo_Autofact;
            this.pictureBox1.Location = new System.Drawing.Point(350, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.Chercher);
            this.panel2.Controls.Add(this.Recherche);
            this.panel2.Controls.Add(this.DataGridView);
            this.panel2.Controls.Add(this.AjouterPresta);
            this.panel2.Location = new System.Drawing.Point(5, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 400);
            this.panel2.TabIndex = 22;
            // 
            // Chercher
            // 
            this.Chercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Chercher.Location = new System.Drawing.Point(175, 15);
            this.Chercher.Margin = new System.Windows.Forms.Padding(2);
            this.Chercher.Name = "Chercher";
            this.Chercher.Size = new System.Drawing.Size(50, 30);
            this.Chercher.TabIndex = 16;
            this.Chercher.Text = "🔎";
            this.Chercher.UseVisualStyleBackColor = true;
            this.Chercher.Click += new System.EventHandler(this.Chercher_Click);
            // 
            // Recherche
            // 
            this.Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Recherche.Location = new System.Drawing.Point(20, 18);
            this.Recherche.Margin = new System.Windows.Forms.Padding(2);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(150, 24);
            this.Recherche.TabIndex = 14;
            this.Recherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recherche_KeyPress);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView.ColumnHeadersHeight = 50;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.DataGridView.Location = new System.Drawing.Point(20, 55);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 100;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(932, 328);
            this.DataGridView.TabIndex = 12;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // AjouterPresta
            // 
            this.AjouterPresta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AjouterPresta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.AjouterPresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterPresta.Font = new System.Drawing.Font("Arial", 11F);
            this.AjouterPresta.ForeColor = System.Drawing.SystemColors.Window;
            this.AjouterPresta.Location = new System.Drawing.Point(800, 10);
            this.AjouterPresta.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterPresta.Name = "AjouterPresta";
            this.AjouterPresta.Size = new System.Drawing.Size(150, 40);
            this.AjouterPresta.TabIndex = 0;
            this.AjouterPresta.Text = "Nouvelle Prestation";
            this.AjouterPresta.UseVisualStyleBackColor = false;
            this.AjouterPresta.Click += new System.EventHandler(this.AjouterPresta_Click);
            // 
            // Home
            // 
            this.Home.Image = global::Login.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(30, 50);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(50, 50);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 26;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Deconnexion
            // 
            this.Deconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Deconnexion.Image = global::Login.Properties.Resources.deconnection;
            this.Deconnexion.Location = new System.Drawing.Point(900, 50);
            this.Deconnexion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(50, 50);
            this.Deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Deconnexion.TabIndex = 27;
            this.Deconnexion.TabStop = false;
            this.Deconnexion.Click += new System.EventHandler(this.Deconnexion_Click);
            // 
            // GererPrestations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Deconnexion);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GererPrestations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer les prestations";
            this.Load += new System.EventHandler(this.GererPrestations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deconnexion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Chercher;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button AjouterPresta;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox Deconnexion;
    }
}