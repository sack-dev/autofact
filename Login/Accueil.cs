using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //Bouton Connexion
            FormLogin x = new FormLogin(this);
            x.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            //Bouton Home
            Hide();
            Accueil x = new Accueil();
            x.Show();
        }
    }
}
