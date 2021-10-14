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

namespace testCRUD
{
    public partial class Form1 : Form 
    {


// Création de la connexion à la BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection con = new MySqlConnection(dsnConnection);
        
//
        MySqlCommand command = new MySqlCommand();
       
//
        MySqlDataAdapter adapt;
        
//
        int IDC = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        //Ajout d'un client
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtMail.Text != "" && txtTel.Text != "" && txtAdresse.Text != "")
            {
                string insert = "INSERT INTO client(NOM,MAIL,TEL,ADRESSE) VALUES (@nom, @mail, @tel, @adresse)";
                MySqlCommand cmd = new MySqlCommand(insert, con);
                con.Open();
                cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le client créé avec succès");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs");
            }
        }

    // Vide les cases
    private void ClearData()
        {
            txtNom.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";
            txtAdresse.Text = "";
            IDC = 0;
        }

// Remplissage du DataGridView avec les données de la BDD
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM client", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

// Supprime un client
        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (IDC != 0)
            {
                string suppr = "DELETE FROM client WHERE IDC = @IDC";
                MySqlCommand cmd = new MySqlCommand(suppr, con);
                con.Open();
                cmd.Parameters.AddWithValue("@IDC", dataGridView1.SelectedCells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Le client supprimé avec succès");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un client pour le supprimer");
            }
        }

// Rempli les cases avec les données de la ligne selectionnée
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDC = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAdresse.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

// Modifie le client
        private void Modifier_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtMail.Text != "" && txtTel.Text != "" && txtAdresse.Text != "" )
            {
                string modif = "UPDATE client SET NOM=@nom, MAIL=@mail, TEL=@tel, ADRESSE=@adresse WHERE IDC=@IDC";
                MySqlCommand cmd = new MySqlCommand(modif, con);
                con.Open();
                cmd.Parameters.AddWithValue("@IDC", IDC);
                cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Le client modifié avec succès");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un client pour le modifier");
            }
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tel_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }


    }   
}
/*
            Instanciation obj Person

           Person ... = new Person (Tous les champs saisi par le user)
            */


/*
 Requête insert person dans la BDD 
 */