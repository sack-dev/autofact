using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login
{
    public partial class AjoutPresta : Form
    {
        DataGridView dgv = new DataGridView();
        public AjoutPresta(DataGridView dgv1)
        {
            InitializeComponent();
            dgv = dgv1;
        }

        //Connexion BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);

        private void AjouterClient_Click(object sender, EventArgs e)
        {
            //Ajout Prestation
            connection.Open();
            string insert = "INSERT INTO prestation(NOM,TVA,PRIX) VALUES (@nom, @TVA, @prix)";
            MySqlCommand cmd = new MySqlCommand(insert, connection);
            cmd.Parameters.AddWithValue("@nom", NomPresta.Text);
            cmd.Parameters.AddWithValue("@TVA", TVAPresta.Text);
            cmd.Parameters.AddWithValue("@prix", PrixPresta.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Prestation créée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            connection.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDP`, `NOM`,`TVA`,`PRIX` FROM `prestation`", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv.DataSource = dtbl;

            //Création des boutons modifier et supprimer
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Name == "btnSuppr")
                {
                    column.DisplayIndex = 5;
                }
                else if (column.Name == "btnUpdate")
                {
                    column.DisplayIndex = 4;
                }
            }
            connection.Close();
            Close();
        }
    }
}
