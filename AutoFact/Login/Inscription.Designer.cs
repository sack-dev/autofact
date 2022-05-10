
namespace Login
{
    partial class Inscription
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
            this.NomUti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Inscrire = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.MdpUti = new System.Windows.Forms.TextBox();
            this.MailUti = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MdpUti2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AfficherMdp = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomUti
            // 
            this.NomUti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUti.Location = new System.Drawing.Point(427, 92);
            this.NomUti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NomUti.Name = "NomUti";
            this.NomUti.Size = new System.Drawing.Size(319, 30);
            this.NomUti.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(100, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Utilisateur :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(300, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inscription :";
            // 
            // Inscrire
            // 
            this.Inscrire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Inscrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inscrire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inscrire.ForeColor = System.Drawing.SystemColors.Window;
            this.Inscrire.Location = new System.Drawing.Point(427, 369);
            this.Inscrire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inscrire.Name = "Inscrire";
            this.Inscrire.Size = new System.Drawing.Size(267, 49);
            this.Inscrire.TabIndex = 5;
            this.Inscrire.Text = "S\'inscrire";
            this.Inscrire.UseVisualStyleBackColor = false;
            this.Inscrire.Click += new System.EventHandler(this.Inscrire_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.ForeColor = System.Drawing.SystemColors.Window;
            this.Annuler.Location = new System.Drawing.Point(100, 369);
            this.Annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(267, 49);
            this.Annuler.TabIndex = 6;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // MdpUti
            // 
            this.MdpUti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdpUti.Location = new System.Drawing.Point(427, 215);
            this.MdpUti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MdpUti.Name = "MdpUti";
            this.MdpUti.Size = new System.Drawing.Size(319, 30);
            this.MdpUti.TabIndex = 3;
            this.MdpUti.UseSystemPasswordChar = true;
            // 
            // MailUti
            // 
            this.MailUti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailUti.Location = new System.Drawing.Point(427, 154);
            this.MailUti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MailUti.Name = "MailUti";
            this.MailUti.Size = new System.Drawing.Size(319, 30);
            this.MailUti.TabIndex = 2;
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mdp.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.ForeColor = System.Drawing.SystemColors.Window;
            this.mdp.Location = new System.Drawing.Point(100, 215);
            this.mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(163, 25);
            this.mdp.TabIndex = 1;
            this.mdp.Text = "Mot De Passe :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Email.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.Window;
            this.Email.Location = new System.Drawing.Point(100, 154);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(86, 25);
            this.Email.TabIndex = 0;
            this.Email.Text = "E-Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(100, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirmation Mot De Passe :";
            // 
            // MdpUti2
            // 
            this.MdpUti2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdpUti2.Location = new System.Drawing.Point(427, 277);
            this.MdpUti2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MdpUti2.Name = "MdpUti2";
            this.MdpUti2.Size = new System.Drawing.Size(319, 30);
            this.MdpUti2.TabIndex = 4;
            this.MdpUti2.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.AfficherMdp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 492);
            this.panel1.TabIndex = 10;
            // 
            // AfficherMdp
            // 
            this.AfficherMdp.AutoSize = true;
            this.AfficherMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.AfficherMdp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficherMdp.ForeColor = System.Drawing.SystemColors.Window;
            this.AfficherMdp.Location = new System.Drawing.Point(550, 315);
            this.AfficherMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AfficherMdp.Name = "AfficherMdp";
            this.AfficherMdp.Size = new System.Drawing.Size(197, 23);
            this.AfficherMdp.TabIndex = 7;
            this.AfficherMdp.Text = "Afficher les caractères";
            this.AfficherMdp.UseVisualStyleBackColor = false;
            this.AfficherMdp.CheckedChanged += new System.EventHandler(this.AfficherMdp_CheckedChanged);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.MdpUti2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomUti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Inscrire);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.MailUti);
            this.Controls.Add(this.MdpUti);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inscription";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Inscrire;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.TextBox MdpUti;
        private System.Windows.Forms.TextBox MailUti;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomUti;
        private System.Windows.Forms.TextBox MdpUti2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox AfficherMdp;
    }
}