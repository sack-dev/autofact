using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Login
{
    public partial class FormLogin : Form
    {
        Form accueil;
        public FormLogin (Form accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
        }

        //Connexion à la BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Bouton Inscription
            Hide();
            Inscription x = new Inscription(accueil);
            x.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {   
            //Bouton Se Connecter
            connection.Open();
            string selectSalt = "SELECT SALT FROM utilisateur WHERE MAIL='" + mailuti.Text + "'";
            MySqlCommand cmdSalt = new MySqlCommand(selectSalt, connection);
            string salt = cmdSalt.ExecuteScalar().ToString();
            string select = "SELECT count(*) FROM utilisateur WHERE MAIL='" + mailuti.Text + "' AND MDP='" + BCrypt.Net.BCrypt.HashPassword(mdputi.Text, salt) + "'";
            MySqlCommand cmd = new MySqlCommand(select, connection);
            int result = int.Parse(cmd.ExecuteScalar().ToString());
            if (result == 1)
            {
              Hide();
              accueil.Hide();
              AccueilCo x = new AccueilCo();
              x.Show();
            }
            else
            {
                MessageBox.Show("Mot de Passe Incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mdputi_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Affichage du Mot de Passe en Clair
            if (checkBox1.Checked)
                mdputi.UseSystemPasswordChar = false;
            else
                mdputi.UseSystemPasswordChar = true;
        }
    }
}
