
namespace Login
{
    partial class Connexion
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AfficherMdp = new System.Windows.Forms.CheckBox();
            this.NewCompte = new System.Windows.Forms.Button();
            this.SeConnecter = new System.Windows.Forms.Button();
            this.MdpUti = new System.Windows.Forms.TextBox();
            this.MailUti = new System.Windows.Forms.TextBox();
            this.LabelMdp = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelConnexion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AfficherMdp
            // 
            this.AfficherMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AfficherMdp.AutoSize = true;
            this.AfficherMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.AfficherMdp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficherMdp.ForeColor = System.Drawing.SystemColors.Window;
            this.AfficherMdp.Location = new System.Drawing.Point(365, 165);
            this.AfficherMdp.Margin = new System.Windows.Forms.Padding(4);
            this.AfficherMdp.Name = "AfficherMdp";
            this.AfficherMdp.Size = new System.Drawing.Size(197, 23);
            this.AfficherMdp.TabIndex = 3;
            this.AfficherMdp.Text = "Afficher les caractères";
            this.AfficherMdp.UseVisualStyleBackColor = false;
            this.AfficherMdp.CheckedChanged += new System.EventHandler(this.AfficherMdp_CheckedChanged);
            // 
            // NewCompte
            // 
            this.NewCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.NewCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCompte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCompte.ForeColor = System.Drawing.SystemColors.Window;
            this.NewCompte.Location = new System.Drawing.Point(320, 200);
            this.NewCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NewCompte.Name = "NewCompte";
            this.NewCompte.Size = new System.Drawing.Size(200, 40);
            this.NewCompte.TabIndex = 5;
            this.NewCompte.Text = "Créer un Compte";
            this.NewCompte.UseVisualStyleBackColor = false;
            this.NewCompte.Click += new System.EventHandler(this.NewCompte_Click);
            // 
            // SeConnecter
            // 
            this.SeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SeConnecter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeConnecter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeConnecter.ForeColor = System.Drawing.SystemColors.Window;
            this.SeConnecter.Location = new System.Drawing.Point(75, 200);
            this.SeConnecter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SeConnecter.Name = "SeConnecter";
            this.SeConnecter.Size = new System.Drawing.Size(200, 40);
            this.SeConnecter.TabIndex = 4;
            this.SeConnecter.Text = "Se Connecter";
            this.SeConnecter.UseVisualStyleBackColor = false;
            this.SeConnecter.Click += new System.EventHandler(this.SeConnecter_Click);
            // 
            // MdpUti
            // 
            this.MdpUti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MdpUti.Location = new System.Drawing.Point(320, 125);
            this.MdpUti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MdpUti.Name = "MdpUti";
            this.MdpUti.Size = new System.Drawing.Size(240, 30);
            this.MdpUti.TabIndex = 2;
            this.MdpUti.UseSystemPasswordChar = true;
            // 
            // MailUti
            // 
            this.MailUti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MailUti.Location = new System.Drawing.Point(320, 75);
            this.MailUti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MailUti.Name = "MailUti";
            this.MailUti.Size = new System.Drawing.Size(240, 30);
            this.MailUti.TabIndex = 1;
            // 
            // LabelMdp
            // 
            this.LabelMdp.AutoSize = true;
            this.LabelMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LabelMdp.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMdp.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelMdp.Location = new System.Drawing.Point(75, 125);
            this.LabelMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMdp.Name = "LabelMdp";
            this.LabelMdp.Size = new System.Drawing.Size(163, 25);
            this.LabelMdp.TabIndex = 1;
            this.LabelMdp.Text = "Mot De Passe :";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LabelEmail.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelEmail.Location = new System.Drawing.Point(75, 75);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(86, 25);
            this.LabelEmail.TabIndex = 0;
            this.LabelEmail.Text = "E-Mail :";
            // 
            // LabelConnexion
            // 
            this.LabelConnexion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelConnexion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConnexion.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelConnexion.Location = new System.Drawing.Point(225, 15);
            this.LabelConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelConnexion.Name = "LabelConnexion";
            this.LabelConnexion.Size = new System.Drawing.Size(175, 30);
            this.LabelConnexion.TabIndex = 7;
            this.LabelConnexion.Text = "Connexion :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.NewCompte);
            this.panel1.Controls.Add(this.LabelConnexion);
            this.panel1.Controls.Add(this.SeConnecter);
            this.panel1.Controls.Add(this.AfficherMdp);
            this.panel1.Controls.Add(this.LabelEmail);
            this.panel1.Controls.Add(this.MailUti);
            this.panel1.Controls.Add(this.MdpUti);
            this.panel1.Controls.Add(this.LabelMdp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 338);
            this.panel1.TabIndex = 1;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelMdp;
        private System.Windows.Forms.Button NewCompte;
        private System.Windows.Forms.Button SeConnecter;
        private System.Windows.Forms.TextBox MdpUti;
        private System.Windows.Forms.TextBox MailUti;
        private System.Windows.Forms.CheckBox AfficherMdp;
        private System.Windows.Forms.Label LabelConnexion;
        private System.Windows.Forms.Panel panel1;
    }
}

