
namespace Login
{
    partial class FormLogin
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_redirection = new System.Windows.Forms.Button();
            this.btn_connection = new System.Windows.Forms.Button();
            this.mdputi = new System.Windows.Forms.TextBox();
            this.mailuti = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(287, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Afficher les caractères";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_redirection
            // 
            this.btn_redirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_redirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redirection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_redirection.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_redirection.Location = new System.Drawing.Point(295, 164);
            this.btn_redirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_redirection.Name = "btn_redirection";
            this.btn_redirection.Size = new System.Drawing.Size(150, 30);
            this.btn_redirection.TabIndex = 5;
            this.btn_redirection.Text = "Créer un Compte";
            this.btn_redirection.UseVisualStyleBackColor = false;
            this.btn_redirection.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_connection
            // 
            this.btn_connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connection.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_connection.Location = new System.Drawing.Point(82, 164);
            this.btn_connection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(150, 30);
            this.btn_connection.TabIndex = 4;
            this.btn_connection.Text = "Se Connecter";
            this.btn_connection.UseVisualStyleBackColor = false;
            this.btn_connection.Click += new System.EventHandler(this.button1_Click);
            // 
            // mdputi
            // 
            this.mdputi.Location = new System.Drawing.Point(268, 110);
            this.mdputi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mdputi.Name = "mdputi";
            this.mdputi.Size = new System.Drawing.Size(175, 20);
            this.mdputi.TabIndex = 2;
            this.mdputi.UseSystemPasswordChar = true;
            this.mdputi.TextChanged += new System.EventHandler(this.mdputi_TextChanged);
            // 
            // mailuti
            // 
            this.mailuti.Location = new System.Drawing.Point(268, 72);
            this.mailuti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailuti.Name = "mailuti";
            this.mailuti.Size = new System.Drawing.Size(175, 20);
            this.mailuti.TabIndex = 1;
            this.mailuti.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.Location = new System.Drawing.Point(79, 112);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(116, 18);
            this.mdp.TabIndex = 1;
            this.mdp.Text = "Mot De Passe :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(79, 74);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(61, 18);
            this.Email.TabIndex = 0;
            this.Email.Text = "E-Mail :";
            this.Email.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connexion :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 63);
            this.panel1.TabIndex = 1;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btn_redirection);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.mdputi);
            this.Controls.Add(this.mailuti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Button btn_redirection;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.TextBox mdputi;
        private System.Windows.Forms.TextBox mailuti;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

