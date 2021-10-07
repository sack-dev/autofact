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

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

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
            try
            {
                if (nomuti.Text != string.Empty || mailuti.Text != string.Empty ||  mdputi.Text != string.Empty || mdputi2.Text != string.Empty)
                {
                    if (mdputi.Text == mdputi2.Text)
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
                            string insert = "INSERT INTO utilisateur(NOM_UTILISATEUR, MAIL, MDP) VALUES (@nom_utilisateur,@email,@mdp)";
                            MySqlCommand cmd = new MySqlCommand(insert, connection);
                            cmd.Parameters.AddWithValue("@nom_utilisateur", nomuti.Text);
                            cmd.Parameters.AddWithValue("@email", mailuti.Text);
                            cmd.Parameters.AddWithValue("@mdp", mdputi.Text);
                            cmd.ExecuteNonQuery();
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
                connection.Close();
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
