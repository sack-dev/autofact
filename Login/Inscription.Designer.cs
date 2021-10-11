
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
            this.nomuti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inscription = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.mdputi = new System.Windows.Forms.TextBox();
            this.mailuti = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mdputi2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomuti
            // 
            this.nomuti.Location = new System.Drawing.Point(274, 71);
            this.nomuti.Name = "nomuti";
            this.nomuti.Size = new System.Drawing.Size(175, 20);
            this.nomuti.TabIndex = 1;
            this.nomuti.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Utilisateur :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inscription :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_inscription
            // 
            this.btn_inscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_inscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscription.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_inscription.Location = new System.Drawing.Point(299, 226);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(150, 30);
            this.btn_inscription.TabIndex = 5;
            this.btn_inscription.Text = "S\'inscrire";
            this.btn_inscription.UseVisualStyleBackColor = false;
            this.btn_inscription.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_annuler.Location = new System.Drawing.Point(44, 226);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(150, 30);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.button1_Click);
            // 
            // mdputi
            // 
            this.mdputi.Location = new System.Drawing.Point(274, 155);
            this.mdputi.Name = "mdputi";
            this.mdputi.Size = new System.Drawing.Size(175, 20);
            this.mdputi.TabIndex = 3;
            this.mdputi.UseSystemPasswordChar = true;
            this.mdputi.TextChanged += new System.EventHandler(this.mdputi_TextChanged);
            // 
            // mailuti
            // 
            this.mailuti.Location = new System.Drawing.Point(274, 111);
            this.mailuti.Name = "mailuti";
            this.mailuti.Size = new System.Drawing.Size(175, 20);
            this.mailuti.TabIndex = 2;
            this.mailuti.TextChanged += new System.EventHandler(this.mailuti_TextChanged);
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.Location = new System.Drawing.Point(41, 157);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(116, 18);
            this.mdp.TabIndex = 1;
            this.mdp.Text = "Mot De Passe :";
            this.mdp.Click += new System.EventHandler(this.mdp_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(41, 113);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(61, 18);
            this.Email.TabIndex = 0;
            this.Email.Text = "E-Mail :";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirmation Mot De Passe :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mdputi2
            // 
            this.mdputi2.Location = new System.Drawing.Point(274, 194);
            this.mdputi2.Name = "mdputi2";
            this.mdputi2.Size = new System.Drawing.Size(175, 20);
            this.mdputi2.TabIndex = 9;
            this.mdputi2.UseSystemPasswordChar = true;
            this.mdputi2.TextChanged += new System.EventHandler(this.mdputi2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 63);
            this.panel1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.mdputi2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomuti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.mailuti);
            this.Controls.Add(this.mdputi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inscription;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.TextBox mdputi;
        private System.Windows.Forms.TextBox mailuti;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomuti;
        private System.Windows.Forms.TextBox mdputi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}