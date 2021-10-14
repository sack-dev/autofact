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
    public partial class AccueilCo : Form
    {
        public AccueilCo()
        {
            InitializeComponent();
        }

        private void AccueilCo_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //Connection à la BDD
            string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
            MySqlConnection connection = new MySqlConnection(dsnConnection);
            // Bouton Deconnection
            connection.Close();
            Hide();
            Accueil x = new Accueil();
            x.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            //Bouton Home
            Hide();
            AccueilCo x = new AccueilCo();
            x.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
