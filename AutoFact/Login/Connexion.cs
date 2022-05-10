using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Connexion : Form
    {
        public static string utilisateur;

        public Connexion()
        {
            InitializeComponent();
        }

        Form Accueil;

        public Connexion(Form Accueil)
        {
            InitializeComponent();
            this.Accueil = Accueil;
        }

        //Connexion BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);

        private void SeConnecter_Click(object sender, EventArgs e)
        {
            //Bouton Se Connecter
            connection.Open();
            string selectSalt = "SELECT SALT FROM utilisateur WHERE MAIL='" + MailUti.Text + "'";
            MySqlCommand cmdSalt = new MySqlCommand(selectSalt, connection);
            string salt = cmdSalt.ExecuteScalar().ToString();
            string select = "SELECT count(*) FROM utilisateur WHERE MAIL='" + MailUti.Text + "' AND MDP='" + BCrypt.Net.BCrypt.HashPassword(MdpUti.Text, salt) + "'";
            MySqlCommand cmd = new MySqlCommand(select, connection);
            int result = int.Parse(cmd.ExecuteScalar().ToString());
            if (result == 1)
            {
                Accueil.Hide();
                Hide();
                utilisateur = MailUti.Text;
                AccueilCo x = new AccueilCo();
                x.Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou Mot de Passe Incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void AfficherMdp_CheckedChanged(object sender, EventArgs e)
        {
            //Affichage du Mot de Passe en Clair
            if (AfficherMdp.Checked)
                MdpUti.UseSystemPasswordChar = false;
            else
                MdpUti.UseSystemPasswordChar = true;
        }

        private void NewCompte_Click(object sender, EventArgs e)
        {
            //Bouton Inscription
            Hide();
            Inscription x = new Inscription(Accueil);
            x.Show();
        }
    }
}
