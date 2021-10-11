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
        public Inscription()
        {
            InitializeComponent();
        }

        //Connection BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
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
                if (nomuti.Text != string.Empty && mailuti.Text != string.Empty &&  mdputi.Text != string.Empty && mdputi2.Text != string.Empty)
                {
                    if (PasswordMatch == verifPasswordMatch)
                    {
                        connection.Open();
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
                            MessageBox.Show("Inscription Réussie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mdputi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void mdp_Click(object sender, EventArgs e)
        {

        }

        private void mailuti_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdputi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
