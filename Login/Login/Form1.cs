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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 x = new Form2();
            x.Show();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string select = "SELECT count(*) FROM utilisateur WHERE MAIL='" + mailuti.Text + "' AND MDP='" + mdputi.Text + "'";
                MySqlCommand cmd = new MySqlCommand(select, connection);
                int result = int.Parse(cmd.ExecuteScalar().ToString());
                if (result == 1)
                {
                    MessageBox.Show("Connection Réussie !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Redirection
                }
                else
                {
                    MessageBox.Show("Mot de Passe Incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Echec lors de la connection à la base de donnée");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdputi_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                mdputi.UseSystemPasswordChar = false;
            else
                mdputi.UseSystemPasswordChar = true;
        }
    }
}
