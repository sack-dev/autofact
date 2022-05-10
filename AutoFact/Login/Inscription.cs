using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Inscription : Form
    {
        Form Accueil;
        public Inscription(Form Accueil)
        {
            InitializeComponent();
            this.Accueil = Accueil;
        }

        //Connection BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);

        private void Annuler_Click(object sender, EventArgs e)
        {
            //Bouton Annuler
            Close();
        }

        private void AfficherMdp_CheckedChanged(object sender, EventArgs e)
        {
            //Affichage du Mot de Passe en Clair
            if (AfficherMdp.Checked)
            {
                MdpUti.UseSystemPasswordChar = false;
                MdpUti2.UseSystemPasswordChar = false;
            }
            else
            {
                MdpUti.UseSystemPasswordChar = true;
                MdpUti2.UseSystemPasswordChar = true;
            }
        }

        private void Inscrire_Click(object sender, EventArgs e)
        {
            User aUser = new User(NomUti.Text, MailUti.Text);
            //Bouton Inscription
            //Salt + Hash du Mot de passe
            string Password = MdpUti.Text;
            string Salt = BCrypt.Net.BCrypt.GenerateSalt();
            string Hash = BCrypt.Net.BCrypt.HashPassword(Password, Salt);
            //bool PasswordMatch = BCrypt.Net.BCrypt.Verify(Password, Hash);

            //Salt + Hash du Mot de passe
            string verifPassword = MdpUti2.Text;
            //string verifSalt = BCrypt.Net.BCrypt.GenerateSalt();
            string verifHash = BCrypt.Net.BCrypt.HashPassword(verifPassword, Salt);
            bool verifPasswordMatch = BCrypt.Net.BCrypt.Verify(verifPassword, Hash);

            try
            {
                //Bouton S'Inscrire
                connection.Open();
                if (NomUti.Text != string.Empty && MailUti.Text != string.Empty && MdpUti.Text != string.Empty && MdpUti2.Text != string.Empty)
                {
                    if (aUser.verifMail())
                    {

                        //Vérification des 2 Mots de Passes
                        if (verifPasswordMatch)
                        {
                            string select = "SELECT * FROM `utilisateur` WHERE `MAIL`= '" + MailUti.Text + "'";
                            MySqlCommand read = new MySqlCommand(select, connection);
                            MySqlDataReader rd = read.ExecuteReader();
                            if (rd.Read())
                            {
                                rd.Close();
                                MessageBox.Show("Ce mail a déjà été utilisé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                rd.Close();
                                string insert = "INSERT INTO utilisateur(NOM_UTILISATEUR, MAIL, MDP, SALT) VALUES (@nom_utilisateur,@email,@mdp, @salt)";
                                MySqlCommand cmd = new MySqlCommand(insert, connection);
                                cmd.Parameters.AddWithValue("@nom_utilisateur", NomUti.Text);
                                cmd.Parameters.AddWithValue("@email", MailUti.Text);
                                cmd.Parameters.AddWithValue("@mdp", verifHash);
                                cmd.Parameters.AddWithValue("@salt", Salt);
                                cmd.ExecuteNonQuery();

                                //Redirection vers la page Connexion
                                Hide();
                                Connexion x = new Connexion(Accueil);
                                x.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Les deux mots de passes doivent être identiques !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Adresse mail incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir toutes les cases et/ou renseignez un email valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Echec lors de la connection à la base de donnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            connection.Close();
        }


    }


}

