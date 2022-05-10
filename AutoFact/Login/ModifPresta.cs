using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login
{
    public partial class ModifPresta : Form
    {
        int IDP = 0;
        DataGridView dgv = new DataGridView();

        public ModifPresta(DataGridViewRow row, DataGridView dgv1)
        {
            InitializeComponent();
            Grid(row, dgv1);
        }

        private void Grid(DataGridViewRow row, DataGridView dgv1)
        {
            //Remplissage à partir du DataGridView
            dgv = dgv1;
            try
            {
                IDP = int.Parse(row.Cells[0].Value.ToString());
                NomPresta.Text = row.Cells[1].Value.ToString();
                TVAPresta.Text = row.Cells[2].Value.ToString();
                PrixPresta.Text = row.Cells[3].Value.ToString().Replace(",", ".");
            }
            catch
            {
                IDP = int.Parse(row.Cells[2].Value.ToString());
                NomPresta.Text = row.Cells[3].Value.ToString();
                TVAPresta.Text = row.Cells[4].Value.ToString();
                PrixPresta.Text = row.Cells[5].Value.ToString().Replace(",", ".");
            }
        }

        //Connexion BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);

        private void ModifierPresta_Click(object sender, EventArgs e)
        {
            //Bouton Modifier Prestation
            string modif = "UPDATE prestation SET NOM=@nom, TVA=@TVA, PRIX=@prix WHERE IDP=@IDP";
            MySqlCommand cmd = new MySqlCommand(modif, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@IDP", IDP);
            cmd.Parameters.AddWithValue("@nom", NomPresta.Text);
            cmd.Parameters.AddWithValue("@TVA", TVAPresta.Text);
            cmd.Parameters.AddWithValue("@prix", PrixPresta.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Prestation modifiée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDP`, `NOM`, `TVA`, `PRIX` FROM `prestation`", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv.DataSource = dtbl;

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
