
namespace Login
{
    partial class ModifPresta
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
            this.pourcent = new System.Windows.Forms.Label();
            this.euro = new System.Windows.Forms.Label();
            this.Prix = new System.Windows.Forms.Label();
            this.PrixPresta = new System.Windows.Forms.TextBox();
            this.ModifierPresta = new System.Windows.Forms.Button();
            this.TVA = new System.Windows.Forms.Label();
            this.TVAPresta = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.NomPresta = new System.Windows.Forms.TextBox();
            this.Modifier = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pourcent
            // 
            this.pourcent.AutoSize = true;
            this.pourcent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pourcent.Location = new System.Drawing.Point(170, 180);
            this.pourcent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pourcent.Name = "pourcent";
            this.pourcent.Size = new System.Drawing.Size(25, 19);
            this.pourcent.TabIndex = 67;
            this.pourcent.Text = "%";
            // 
            // euro
            // 
            this.euro.AutoSize = true;
            this.euro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euro.Location = new System.Drawing.Point(225, 230);
            this.euro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.euro.Name = "euro";
            this.euro.Size = new System.Drawing.Size(18, 19);
            this.euro.TabIndex = 66;
            this.euro.Text = "€";
            // 
            // Prix
            // 
            this.Prix.AutoSize = true;
            this.Prix.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prix.Location = new System.Drawing.Point(30, 225);
            this.Prix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(49, 19);
            this.Prix.TabIndex = 64;
            this.Prix.Text = "Prix :";
            // 
            // PrixPresta
            // 
            this.PrixPresta.BackColor = System.Drawing.SystemColors.Window;
            this.PrixPresta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixPresta.Location = new System.Drawing.Point(130, 225);
            this.PrixPresta.Margin = new System.Windows.Forms.Padding(2);
            this.PrixPresta.MaxLength = 10;
            this.PrixPresta.Name = "PrixPresta";
            this.PrixPresta.Size = new System.Drawing.Size(95, 26);
            this.PrixPresta.TabIndex = 63;
            // 
            // ModifierPresta
            // 
            this.ModifierPresta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ModifierPresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierPresta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierPresta.ForeColor = System.Drawing.SystemColors.Window;
            this.ModifierPresta.Location = new System.Drawing.Point(225, 265);
            this.ModifierPresta.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierPresta.Name = "ModifierPresta";
            this.ModifierPresta.Size = new System.Drawing.Size(150, 40);
            this.ModifierPresta.TabIndex = 62;
            this.ModifierPresta.Text = "Modifier";
            this.ModifierPresta.UseVisualStyleBackColor = false;
            this.ModifierPresta.Click += new System.EventHandler(this.ModifierPresta_Click);
            // 
            // TVA
            // 
            this.TVA.AutoSize = true;
            this.TVA.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVA.Location = new System.Drawing.Point(30, 175);
            this.TVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TVA.Name = "TVA";
            this.TVA.Size = new System.Drawing.Size(49, 19);
            this.TVA.TabIndex = 60;
            this.TVA.Text = "TVA :";
            // 
            // TVAPresta
            // 
            this.TVAPresta.BackColor = System.Drawing.SystemColors.Window;
            this.TVAPresta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVAPresta.Location = new System.Drawing.Point(130, 175);
            this.TVAPresta.Margin = new System.Windows.Forms.Padding(2);
            this.TVAPresta.MaxLength = 5;
            this.TVAPresta.Name = "TVAPresta";
            this.TVAPresta.Size = new System.Drawing.Size(37, 26);
            this.TVAPresta.TabIndex = 59;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(30, 125);
            this.Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(55, 19);
            this.Nom.TabIndex = 57;
            this.Nom.Text = "Nom :";
            // 
            // NomPresta
            // 
            this.NomPresta.BackColor = System.Drawing.SystemColors.Window;
            this.NomPresta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomPresta.Location = new System.Drawing.Point(130, 125);
            this.NomPresta.Margin = new System.Windows.Forms.Padding(2);
            this.NomPresta.MaxLength = 100;
            this.NomPresta.Name = "NomPresta";
            this.NomPresta.Size = new System.Drawing.Size(181, 26);
            this.NomPresta.TabIndex = 56;
            // 
            // Modifier
            // 
            this.Modifier.AutoSize = true;
            this.Modifier.Font = new System.Drawing.Font("Arial Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.SystemColors.Window;
            this.Modifier.Location = new System.Drawing.Point(85, 30);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(212, 26);
            this.Modifier.TabIndex = 30;
            this.Modifier.Text = "Modifier une Prestation";
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
            this.panel1.TabIndex = 61;
            // 
            // ModifPresta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.pourcent);
            this.Controls.Add(this.euro);
            this.Controls.Add(this.Prix);
            this.Controls.Add(this.PrixPresta);
            this.Controls.Add(this.ModifierPresta);
            this.Controls.Add(this.TVA);
            this.Controls.Add(this.TVAPresta);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.NomPresta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifPresta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier une prestation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pourcent;
        private System.Windows.Forms.Label euro;
        private System.Windows.Forms.Label Prix;
        private System.Windows.Forms.TextBox PrixPresta;
        private System.Windows.Forms.Button ModifierPresta;
        private System.Windows.Forms.Label TVA;
        private System.Windows.Forms.TextBox TVAPresta;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox NomPresta;
        private System.Windows.Forms.Label Modifier;
        private System.Windows.Forms.Panel panel1;
    }
}