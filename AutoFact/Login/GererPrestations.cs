using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login
{
    public partial class GererPrestations : Form
    {
        public GererPrestations()
        {
            InitializeComponent();
        }

        //Connexion BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapt;

        private void GererPrestations_Load(object sender, EventArgs e)
        {
            this.BindGrid();
            RechercheDonnees("");
        }

        public void RechercheDonnees(string valueToSearch)
        {
            string query = "SELECT * FROM prestation WHERE CONCAT (`IDP`, `NOM`, `TVA`, `PRIX`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView.DataSource = table;
        }

        private void BindGrid()
        {
            //Création des colonnes IDP, Nom, TVA, et Prix
            DataGridView.AllowUserToAddRows = false;
            DataGridView.Columns.Clear();
            DataGridViewColumn IDP = new DataGridViewTextBoxColumn
            {
                Name = "IDP",
                HeaderText = "IDP",
                DataPropertyName = "IDP",
                Width = 100
            };
            DataGridView.Columns.Insert(0, IDP);

            DataGridViewColumn nom = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nom",
                Name = "Nom",
                DataPropertyName = "Nom",
                Width = 100
            };
            DataGridView.Columns.Insert(1, nom);

            DataGridViewColumn TVA = new DataGridViewTextBoxColumn
            {
                Name = "TVA",
                HeaderText = "TVA (%)",
                DataPropertyName = "TVA",
                Width = 100
            };
            DataGridView.Columns.Insert(2, TVA);

            DataGridViewColumn prix = new DataGridViewTextBoxColumn
            {
                Name = "Prix",
                HeaderText = "Prix (€)",
                DataPropertyName = "Prix",
                Width = 100
            };
            DataGridView.Columns.Insert(3, prix);

            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT IDP, NOM, TVA, PRIX FROM prestation", connection);
            adapt.Fill(dt);
            DataGridView.DataSource = dt;
            connection.Close();

            //Création Bouton Modifier
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn
            {
                HeaderText = "Modifier",
                Width = 60,
                Name = "btnUpdate",
                Text = "Modifier",
                UseColumnTextForButtonValue = true
            };
            DataGridView.Columns.Insert(4, btnUpdate);
            btnUpdate.FlatStyle = FlatStyle.Flat;

            //Création Bouton Supprimer
            DataGridViewButtonColumn btnSuppr = new DataGridViewButtonColumn
            {
                HeaderText = "Supprimer",
                Width = 60,
                Name = "buttonSuppr",
                Text = "Supprimer",
                UseColumnTextForButtonValue = true
            };
            DataGridView.Columns.Insert(5, btnSuppr);
            btnSuppr.FlatStyle = FlatStyle.Flat;
        }

        private void Recherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Recherche
            string valueToSearch = Recherche.Text.ToString();
            RechercheDonnees(valueToSearch);
        }

        private void Chercher_Click(object sender, EventArgs e)
        {
            //Bouton Chercher
            string valueToSearch = Recherche.Text.ToString();
            RechercheDonnees(valueToSearch);
        }

        private void AjouterPresta_Click(object sender, EventArgs e)
        {
            //Bouton Ajout Prestation
            AjoutPresta Client = new AjoutPresta(DataGridView);
            Client.Show();
            DataGridView.Refresh();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bouton Supprimer
            if (e.ColumnIndex == DataGridView.Columns["buttonSuppr"].Index)
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Voulez vous supprimer ce client ayant pour ID {0}?", row.Cells["IDP"].Value), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection connection = new MySqlConnection(dsnConnection);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM prestation WHERE IDP = @IDP", connection);
                    cmd.Parameters.AddWithValue("@IDP", row.Cells["IDP"].Value);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    this.BindGrid();
                }
            }

            //Bouton Modifier
            if (e.ColumnIndex == DataGridView.Columns["btnUpdate"].Index)
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Voulez vous modifier ce client ayant pour ID {0}?", row.Cells["IDP"].Value), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ModifPresta Presta = new ModifPresta(row, DataGridView);
                    Presta.Show();
                    this.BindGrid();
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            //Bouton Home
            Close();
            AccueilCo x = new AccueilCo();
            x.Show();
        }

        private void Deconnexion_Click(object sender, EventArgs e)
        {
            //Connection à la BDD
            string dsnConnection = "Server=localhost; Database=AUTOFACT1; Uid=root; Password=''; SSL Mode='None'";
            MySqlConnection connection = new MySqlConnection(dsnConnection);

            // Bouton Deconnexion
            connection.Close();
            Close();
            Accueil x = new Accueil();
            x.Show();
        }
    }
}
