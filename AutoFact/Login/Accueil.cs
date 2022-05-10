using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            //Bouton Connexion
            Connexion x = new Connexion(this);
            x.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            //Bouton Home
            Hide();
            Accueil x = new Accueil();
            x.Show();
        }
    }
}
