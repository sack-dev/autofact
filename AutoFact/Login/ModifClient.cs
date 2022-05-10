using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login
{
    public partial class ModifClient : Form
    {
        int IDC = 0;
        DataGridView dgv = new DataGridView();

        public ModifClient(DataGridViewRow row, DataGridView dgv1)
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
                IDC = int.Parse(row.Cells[2].Value.ToString());
                NomClient.Text = row.Cells[3].Value.ToString();
                MailClient.Text = row.Cells[4].Value.ToString();
                TelClient.Text = row.Cells[5].Value.ToString();
                AdresseClient.Text = row.Cells[6].Value.ToString();
                VilleClient.Text = row.Cells[7].Value.ToString();
                CPClient.Text = row.Cells[8].Value.ToString();
            }
            catch
            {
                IDC = int.Parse(row.Cells[0].Value.ToString());
                NomClient.Text = row.Cells[1].Value.ToString();
                MailClient.Text = row.Cells[2].Value.ToString();
                TelClient.Text = row.Cells[3].Value.ToString();
                AdresseClient.Text = row.Cells[4].Value.ToString();
                VilleClient.Text = row.Cells[5].Value.ToString();
                CPClient.Text = row.Cells[6].Value.ToString();
            }
        }

        //Connexion BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);

        private void ModifierClient_Click(object sender, EventArgs e)
        {
            //Bouton Modifier Client
            string modif = "UPDATE client SET NOM=@nom, MAIL=@mail, TEL=@tel, ADRESSE=@adresse, VILLE=@ville, CODE_POSTAL=@code_postal WHERE IDC=@IDC";
            MySqlCommand cmd = new MySqlCommand(modif, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@IDC", IDC);
            cmd.Parameters.AddWithValue("@nom", NomClient.Text);
            cmd.Parameters.AddWithValue("@mail", MailClient.Text);
            cmd.Parameters.AddWithValue("@tel", TelClient.Text);
            cmd.Parameters.AddWithValue("@adresse", AdresseClient.Text);
            cmd.Parameters.AddWithValue("@ville", VilleClient.Text);
            cmd.Parameters.AddWithValue("@code_postal", CPClient.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Client modifié avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDC`, `NOM`, `MAIL`, `TEL`, `ADRESSE`,`VILLE`,`CODE_POSTAL` FROM `client`", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv.DataSource = dtbl;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Name == "btnSuppr")
                {
                    column.DisplayIndex = 8;
                }
                else if (column.Name == "btnUpdate")
                {
                    column.DisplayIndex = 7;
                }
            }
            connection.Close();
            Close();
        }
    }
}
