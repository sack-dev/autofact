
namespace Login
{
    partial class AjoutClient
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
            this.AjouterClient = new System.Windows.Forms.Button();
            this.Adresse = new System.Windows.Forms.Label();
            this.AdresseClient = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.TelClient = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.Label();
            this.MailClient = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.NomClient = new System.Windows.Forms.TextBox();
            this.Modifier = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VilleClient = new System.Windows.Forms.TextBox();
            this.CPClient = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.Label();
            this.codepostal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AjouterClient
            // 
            this.AjouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.AjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterClient.ForeColor = System.Drawing.SystemColors.Window;
            this.AjouterClient.Location = new System.Drawing.Point(225, 315);
            this.AjouterClient.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterClient.Name = "AjouterClient";
            this.AjouterClient.Size = new System.Drawing.Size(150, 40);
            this.AjouterClient.TabIndex = 39;
            this.AjouterClient.Text = "Ajouter";
            this.AjouterClient.UseVisualStyleBackColor = false;
            this.AjouterClient.Click += new System.EventHandler(this.AjouterClient_Click);
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(30, 220);
            this.Adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(82, 19);
            this.Adresse.TabIndex = 37;
            this.Adresse.Text = "Adresse :";
            // 
            // AdresseClient
            // 
            this.AdresseClient.BackColor = System.Drawing.SystemColors.Window;
            this.AdresseClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseClient.Location = new System.Drawing.Point(150, 220);
            this.AdresseClient.Margin = new System.Windows.Forms.Padding(2);
            this.AdresseClient.MaxLength = 200;
            this.AdresseClient.Name = "AdresseClient";
            this.AdresseClient.Size = new System.Drawing.Size(181, 26);
            this.AdresseClient.TabIndex = 36;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel.Location = new System.Drawing.Point(30, 180);
            this.Tel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(100, 19);
            this.Tel.TabIndex = 35;
            this.Tel.Text = "Téléphone :";
            // 
            // TelClient
            // 
            this.TelClient.BackColor = System.Drawing.SystemColors.Window;
            this.TelClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelClient.Location = new System.Drawing.Point(150, 180);
            this.TelClient.Margin = new System.Windows.Forms.Padding(2);
            this.TelClient.MaxLength = 10;
            this.TelClient.Name = "TelClient";
            this.TelClient.Size = new System.Drawing.Size(108, 26);
            this.TelClient.TabIndex = 34;
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.Location = new System.Drawing.Point(30, 140);
            this.Mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(49, 19);
            this.Mail.TabIndex = 33;
            this.Mail.Text = "Mail :";
            // 
            // MailClient
            // 
            this.MailClient.BackColor = System.Drawing.SystemColors.Window;
            this.MailClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailClient.Location = new System.Drawing.Point(150, 140);
            this.MailClient.Margin = new System.Windows.Forms.Padding(2);
            this.MailClient.MaxLength = 100;
            this.MailClient.Name = "MailClient";
            this.MailClient.Size = new System.Drawing.Size(181, 26);
            this.MailClient.TabIndex = 32;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(30, 100);
            this.Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(55, 19);
            this.Nom.TabIndex = 31;
            this.Nom.Text = "Nom :";
            // 
            // NomClient
            // 
            this.NomClient.BackColor = System.Drawing.SystemColors.Window;
            this.NomClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomClient.Location = new System.Drawing.Point(150, 100);
            this.NomClient.Margin = new System.Windows.Forms.Padding(2);
            this.NomClient.MaxLength = 50;
            this.NomClient.Name = "NomClient";
            this.NomClient.Size = new System.Drawing.Size(181, 26);
            this.NomClient.TabIndex = 30;
            // 
            // Modifier
            // 
            this.Modifier.AutoSize = true;
            this.Modifier.Font = new System.Drawing.Font("Arial Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.SystemColors.Window;
            this.Modifier.Location = new System.Drawing.Point(80, 30);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(233, 26);
            this.Modifier.TabIndex = 30;
            this.Modifier.Text = "Ajouter un nouveau client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 84);
            this.panel1.TabIndex = 38;
            // 
            // VilleClient
            // 
            this.VilleClient.BackColor = System.Drawing.SystemColors.Window;
            this.VilleClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VilleClient.Location = new System.Drawing.Point(150, 260);
            this.VilleClient.Margin = new System.Windows.Forms.Padding(2);
            this.VilleClient.MaxLength = 200;
            this.VilleClient.Name = "VilleClient";
            this.VilleClient.Size = new System.Drawing.Size(181, 26);
            this.VilleClient.TabIndex = 40;
            // 
            // CPClient
            // 
            this.CPClient.BackColor = System.Drawing.SystemColors.Window;
            this.CPClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPClient.Location = new System.Drawing.Point(150, 300);
            this.CPClient.Margin = new System.Windows.Forms.Padding(2);
            this.CPClient.MaxLength = 5;
            this.CPClient.Name = "CPClient";
            this.CPClient.Size = new System.Drawing.Size(62, 26);
            this.CPClient.TabIndex = 41;
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ville.Location = new System.Drawing.Point(30, 260);
            this.Ville.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(51, 19);
            this.Ville.TabIndex = 42;
            this.Ville.Text = "Ville :";
            // 
            // codepostal
            // 
            this.codepostal.AutoSize = true;
            this.codepostal.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codepostal.Location = new System.Drawing.Point(30, 300);
            this.codepostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codepostal.Name = "codepostal";
            this.codepostal.Size = new System.Drawing.Size(111, 19);
            this.codepostal.TabIndex = 43;
            this.codepostal.Text = "Code postal :";
            // 
            // AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.codepostal);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.CPClient);
            this.Controls.Add(this.VilleClient);
            this.Controls.Add(this.AjouterClient);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.AdresseClient);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.TelClient);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.MailClient);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.NomClient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AjoutClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AjouterClient;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.TextBox AdresseClient;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.TextBox TelClient;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.TextBox MailClient;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox NomClient;
        private System.Windows.Forms.Label Modifier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox VilleClient;
        private System.Windows.Forms.TextBox CPClient;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.Label codepostal;
    }
}