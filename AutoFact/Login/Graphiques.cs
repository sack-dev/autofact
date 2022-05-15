using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Login
{
    public partial class Graphiques : Form
    {
        Chart graphic = new Chart();
        public Graphiques(object sender, EventArgs e, Chart chart2)
        {
            InitializeComponent();
            Graph(sender, e, chart2);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            //Bouton Home
            Close();
            AccueilCo x = new AccueilCo();
            x.Show();
        }

        private void Deco_Click(object sender, EventArgs e)
        {
            // Bouton Deconnexion
            Close();
            Accueil x = new Accueil();
            x.Show();
        }

        private void Graph(object sender, EventArgs e, Chart chart2)
        {
            graphic = chart2;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            //Style Graphique
            chart1.Series.Clear();
            chart1.Series.Add("Graph");
            chart1.Series["Graph"].ChartType = SeriesChartType.Line;
            chart1.Series["Graph"].Color = Color.Red;
            chart1.Series["Graph"].BorderWidth = 2;
            chart1.Series["Graph"].LegendText = "Salaire Annuel (par mois)";
            chart1.Series[0].IsVisibleInLegend = false;
            var chart = chart1.ChartAreas[0];
            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisX.Interval = 1;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 1000;
            chart.AxisY.Interval = 50;

            string mailutilisateur = Connexion.utilisateur;

            //Connexion BDD
            string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
            MySqlConnection connection = new MySqlConnection(dsnConnection);
            connection.Open();

            //IDU
            string SelectIDU = "SELECT IDU FROM utilisateur WHERE MAIL='" + mailutilisateur + "'";
            MySqlCommand idu = new MySqlCommand(SelectIDU, connection);
            int IDU = int.Parse(idu.ExecuteScalar().ToString());

            //Recupération du chiffre d'affaire par mois en fonction de l'année choisie
            string cmd = @"SELECT MONTH(DATE) AS MONTH, SUM(PRIXTOTAL) AS SOMME FROM document INNER JOIN devenir ON document.IDD = devenir.IDD INNER JOIN utilisateur ON document.IDU = utilisateur.IDU WHERE IDT= 2 AND DATE LIKE '" + comboBox1.Text + "-%' AND utilisateur.IDU = '" + IDU + "' GROUP BY MONTH(DATE)";
            MySqlCommand command = new MySqlCommand(cmd, connection);
            MySqlDataReader dr = command.ExecuteReader();

            Dictionary<int, float> dblist = new Dictionary<int, float>();
            while (dr.Read())
            {
                dblist.Add(int.Parse(dr["MONTH"].ToString()), float.Parse(dr["SOMME"].ToString()));
            }

            //Instenciation de la liste des points
            int i = 0;
            Dictionary<int, float> list = new Dictionary<int, float>();
            while (i < 12)
            {
                if (!(dblist.ContainsKey(i + 1)))
                {
                    list.Add(i + 1, 0);
                }
                else
                {
                    dblist.TryGetValue(i + 1, out float value);
                    list.Add(i + 1, float.Parse(value.ToString()));
                }
                i++;
            }

            //Création des points sur le Graphique
            i = 1;
            foreach (KeyValuePair<int, float> item in list)
            {
                chart1.Series["Graph"].Points.AddXY(i, item.Value);
                i++;
            }
        }
    }
}
