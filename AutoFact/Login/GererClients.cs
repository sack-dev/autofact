using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login
{
    public partial class GererClients : Form
    {
        public GererClients()
        {
            InitializeComponent();
        }

        //Connexion BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapt;

        private void GererClients_Load(object sender, EventArgs e)
        {
            this.BindGrid();
            RechercheDonnees("");
        }

        public void RechercheDonnees(string valueToSearch)
        {
            //Module de recherche
            string query = "SELECT * FROM client WHERE CONCAT (`IDC`, `NOM`, `MAIL`, `TEL`, `ADRESSE`,`VILLE`,`CODE_POSTAL`) like '%" + valueToSearch + "%'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView.DataSource = table;
        }

        private void BindGrid()
        {
            //Création des colonnes IDC, Nom, Mail, Telephone, Adresse, Ville et Code Postal
            DataGridView.AllowUserToAddRows = false;
            DataGridView.Columns.Clear();
            DataGridViewColumn IDC = new DataGridViewTextBoxColumn
            {
                Name = "IDC",
                HeaderText = "IDC",
                DataPropertyName = "IDC",
                Width = 100
            };
            DataGridView.Columns.Insert(0, IDC);

            DataGridViewColumn nom = new DataGridViewTextBoxColumn
            {
                Name = "Nom",
                HeaderText = "Nom",
                DataPropertyName = "Nom",
                Width = 100
            };
            DataGridView.Columns.Insert(1, nom);

            DataGridViewColumn mail = new DataGridViewTextBoxColumn
            {
                Name = "Mail",
                HeaderText = "Mail",
                DataPropertyName = "Mail",
                Width = 100
            };
            DataGridView.Columns.Insert(2, mail);

            DataGridViewColumn tel = new DataGridViewTextBoxColumn
            {
                Name = "Tel",
                HeaderText = "Telephone",
                DataPropertyName = "Tel",
                Width = 100
            };
            DataGridView.Columns.Insert(3, tel);

            DataGridViewColumn adresse = new DataGridViewTextBoxColumn
            {
                Name = "Adresse",
                HeaderText = "Adresse",
                DataPropertyName = "Adresse",
                Width = 100
            };
            DataGridView.Columns.Insert(4, adresse);

            DataGridViewColumn ville = new DataGridViewTextBoxColumn
            {
                Name = "Ville",
                HeaderText = "Ville",
                DataPropertyName = "Ville",
                Width = 100
            };
            DataGridView.Columns.Insert(5, ville);

            DataGridViewColumn code_postal = new DataGridViewTextBoxColumn
            {
                Name = "code_postal",
                HeaderText = "Code postal",
                DataPropertyName = "code_postal",
                Width = 100
            };
            DataGridView.Columns.Insert(6, code_postal);

            //Remplissage DataGridView
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM client", connection);
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
            DataGridView.Columns.Insert(7, btnUpdate);
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
            DataGridView.Columns.Insert(8, btnSuppr);
            btnSuppr.FlatStyle = FlatStyle.Flat;
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            //Bouton Rechercher
            string valueToSearch = Chercher.Text.ToString();
            RechercheDonnees(valueToSearch);
        }

        private void AjouterClient_Click(object sender, EventArgs e)
        {
            //Bouton Ajouter Client
            AjoutClient Client = new AjoutClient(DataGridView);
            Client.Show();
            DataGridView.Refresh();
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
            //Bouton Deconnexion
            connection.Close();
            Close();
            Accueil x = new Accueil();
            x.Show();
        }

        private void Chercher_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Barre de Recherche
            string valueToSearch = Chercher.Text.ToString();
            RechercheDonnees(valueToSearch);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bouton Supprimer
            if (e.ColumnIndex == DataGridView.Columns["buttonSuppr"].Index)
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Voulez vous supprimer ce client ayant pour ID {0}?", row.Cells["IDC"].Value), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection connection = new MySqlConnection(dsnConnection);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM client WHERE IDC = @IDC", connection);
                    cmd.Parameters.AddWithValue("@IDC", row.Cells["IDC"].Value);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    this.BindGrid();
                }
            }

            //Bouton Modifier 
            if (e.ColumnIndex == DataGridView.Columns["btnUpdate"].Index)
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Voulez vous modifier ce client ayant pour ID {0}?", row.Cells["IDC"].Value), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ModifClient Client = new ModifClient(row, DataGridView);
                    Client.Show();
                    this.BindGrid();
                }
            }
        }
    }
}

