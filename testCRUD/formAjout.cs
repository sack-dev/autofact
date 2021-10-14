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
    public partial class formAjout : Form
    {
        public formAjout()
        {
            InitializeComponent();
        }
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
       static MySqlConnection con = new MySqlConnection(dsnConnection);

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            con.Open();
            string insert = "INSERT INTO client(NOM,MAIL,TEL,ADRESSE) VALUES (@nom, @mail, @tel, @adresse)";
            MySqlCommand cmd = new MySqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client créé avec succès");
            con.Close();
            Close();
        }
    }
}
