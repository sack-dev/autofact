using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login
{
    public partial class AjoutClient : Form
    {
        DataGridView dgv = new DataGridView();
        public AjoutClient(DataGridView dgv1)
        {
            InitializeComponent();
            dgv = dgv1;
        }

        //Connexion BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);

        private void AjouterClient_Click(object sender, EventArgs e)
        {
            //Ajout Client
            connection.Open();
            string insert = "INSERT INTO client(NOM,MAIL,TEL,ADRESSE,VILLE,CODE_POSTAL) VALUES (@nom, @mail, @tel, @adresse, @ville, @code_postal)";
            MySqlCommand cmd = new MySqlCommand(insert, connection);
            cmd.Parameters.AddWithValue("@nom", NomClient.Text);
            cmd.Parameters.AddWithValue("@mail", MailClient.Text);
            cmd.Parameters.AddWithValue("@tel", TelClient.Text);
            cmd.Parameters.AddWithValue("@adresse", AdresseClient.Text);
            cmd.Parameters.AddWithValue("@ville", VilleClient.Text);
            cmd.Parameters.AddWithValue("@code_postal", CPClient.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client créé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            connection.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDC`, `NOM`, `MAIL`, `TEL`, `ADRESSE`,`VILLE`,`CODE_POSTAL` FROM `client`", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv.DataSource = dtbl;
            //Création des boutons modifier et supprimer
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
