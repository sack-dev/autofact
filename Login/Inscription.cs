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
    public partial class Inscription : Form
    {
        Form accueil;
        public Inscription(Form accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
        }

        //Connection BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Salt + Hash du Mot de passe
            string Password = mdputi.Text;
            string Salt = BCrypt.Net.BCrypt.GenerateSalt();
            string Hash = BCrypt.Net.BCrypt.HashPassword(Password, Salt);
            bool PasswordMatch = BCrypt.Net.BCrypt.Verify(Password, Hash);

            //Salt + Hash du Mot de passe
            string verifPassword = mdputi2.Text;
            string verifSalt = BCrypt.Net.BCrypt.GenerateSalt();
            string verifHash = BCrypt.Net.BCrypt.HashPassword(verifPassword, verifSalt);
            bool verifPasswordMatch = BCrypt.Net.BCrypt.Verify(verifPassword, verifHash);

            try
            {
                //Bouton S'Inscrire
                connection.Open();
                if (nomuti.Text != string.Empty && mailuti.Text != string.Empty &&  mdputi.Text != string.Empty && mdputi2.Text != string.Empty)
                {
                    if (PasswordMatch == verifPasswordMatch)
                    {
                        string select = "SELECT * FROM `utilisateur` WHERE `MAIL`= '" + mailuti.Text + "'";
                        MySqlCommand read = new MySqlCommand(select, connection);
                        MySqlDataReader rd = read.ExecuteReader();
                        if (rd.Read())
                        {
                            rd.Close();
                            MessageBox.Show("Ce mail a déjà été utilisé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            rd.Close();
                            string insert = "INSERT INTO utilisateur(NOM_UTILISATEUR, MAIL, MDP, SALT) VALUES (@nom_utilisateur,@email,@mdp, @salt)";
                            MySqlCommand cmd = new MySqlCommand(insert, connection);
                            cmd.Parameters.AddWithValue("@nom_utilisateur", nomuti.Text);
                            cmd.Parameters.AddWithValue("@email", mailuti.Text);
                            cmd.Parameters.AddWithValue("@mdp", verifHash);
                            cmd.Parameters.AddWithValue("@salt", verifSalt);
                            cmd.ExecuteNonQuery();

                            Hide();
                            FormLogin x = new FormLogin(accueil);
                            x.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Les deux mots de passes doivent être identiques !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    {
                        MessageBox.Show("Veuillez remplir toutes les cases et/ou renseignez un email valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Echec lors de la connection à la base de donnée");
                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Bouton Annuler
            Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Mdputi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Mdp_Click(object sender, EventArgs e)
        {

        }

        private void Mailuti_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mdputi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
