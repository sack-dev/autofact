using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Login
{
    public partial class AccueilCo : Form
    {
        public AccueilCo()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            //Bouton Home
            Hide();
            AccueilCo x = new AccueilCo();
            x.Show();
        }

        private void Déconnexion_Click(object sender, EventArgs e)
        {
            //Connection BDD
            string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
            MySqlConnection connection = new MySqlConnection(dsnConnection);

            // Bouton Déconnexion
            connection.Close();
            Hide();
            Accueil x = new Accueil();
            x.Show();
            x.Refresh();
        }

        private void Document_Click(object sender, EventArgs e)
        {
            //Bouton Document
            Hide();
            Document x = new Document();
            x.Show();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            //Bouton Clients
            Hide();
            GererClients x = new GererClients();
            x.Show();
        }

        private void Prestations_Click(object sender, EventArgs e)
        {
            //Bouton Prestations
            Hide();
            GererPrestations x = new GererPrestations();
            x.Show();
        }

        private void Graphique_Click(object sender, EventArgs e)
        {
            //Bouton Graphiques
            Hide();
            Chart chart2 = new Chart();
            Graphiques x = new Graphiques(sender, e, chart2);
            x.Show();
        }
    }
}
