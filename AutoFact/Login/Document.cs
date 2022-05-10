using MySql.Data.MySqlClient;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Login
{
    public partial class Document : Form
    {
        public static int IDD;
        public static string NomClient;
        public static string Date;
        public int Qtt = 0;

        public Document()
        {
            InitializeComponent();
            DisplayData();
        }

        //Connexion BDD
        static string dsnConnection = "Server=localhost; Database=AUTOFACT; Uid=root; Password=''; SSL Mode='None'";
        static MySqlConnection connection = new MySqlConnection(dsnConnection);
        MySqlDataAdapter dap;
        DataSet ds;

        private void Document_Load(object sender, EventArgs e)
        {
            //Incrémentation données dans le combobox (selection du client)
            connection.Close();
            connection.Open();
            string selectnom = "SELECT NOM, ADRESSE FROM client";
            MySqlCommand cmd = new MySqlCommand(selectnom, connection);
            dap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "client");

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                SelectClient.Items.Add(x[0].ToString());
            }
        }

        private void DisplayData()
        {
            //Datagridview
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT NOM,TVA,PRIX FROM prestation", connection);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {  //Gestion de la quantité dans le datagridview
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            if (selectedRow.Cells[0].Value != null)
            {
                Qtt = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            }
        }

        private void SaveDevis_Click(object sender, EventArgs e)
        {
            double TotalHT = 0;
            double TotalTVA = 0;
            string mailutilisateur = Connexion.utilisateur;
            string Nom = SelectClient.SelectedItem.ToString();
            NomClient = Nom;
            Date = DateTime.Today.ToLongDateString();

            //Bouton Enregistrer Devis
            WordDocument document = new WordDocument();
            Stream docStream = File.OpenRead(Path.GetFullPath(@"../Documents/Template/templateAutoFact.doc"));
            document.Open(docStream, Syncfusion.DocIO.FormatType.Doc);
            docStream.Dispose();

            //Informations Clients
            string Adressecliente = "SELECT NOM, MAIL, ADRESSE, VILLE, CODE_POSTAL, TEL FROM client WHERE NOM = '" + Nom + "'";
            MySqlCommand cmd = new MySqlCommand(Adressecliente, connection);
            MySqlDataReader infoclient = cmd.ExecuteReader();
            while (infoclient.Read())
            {
                document.Replace("#Nomclient#", infoclient["NOM"].ToString(), true, true);
                document.Replace("#Mailclient#", infoclient["MAIL"].ToString(), true, true);
                document.Replace("#Adresseclient#", infoclient["ADRESSE"].ToString(), true, true);
                document.Replace("#Villeclient#", infoclient["VILLE"].ToString(), true, true);
                document.Replace("#CPclient#", infoclient["CODE_POSTAL"].ToString(), true, true);
                document.Replace("#Telclient#", infoclient["TEL"].ToString(), true, true);
            }
            infoclient.Close();
            document.Replace("#Document#", "Devis", true, true);
            document.Replace("#Date#", DateTime.Today.ToLongDateString(), true, true);
            document.Replace("#Description#", DescriptionDoc.Text, true, true);

            //Tableaux
            BookmarksNavigator bookmarkNavigator = new BookmarksNavigator(document);
            bookmarkNavigator.MoveToBookmark("Tableau");
            IWSection section = document.AddSection();
            IWTable table = section.AddTable();

            BookmarksNavigator bookmark = new BookmarksNavigator(document);
            bookmark.MoveToBookmark("TableauTotaux");
            IWSection sections = document.AddSection();
            IWTable tables = sections.AddTable();
            IWTable tabless = sections.AddTable();

            WTableRow row1 = table.AddRow(true, false);
            WTableCell cell1 = row1.AddCell();
            WTableRow row2 = tables.AddRow(true, false);
            WTableCell cell2 = row2.AddCell();
            WTableRow rows = tables.AddRow(true, false);
            WTableCell cells = rows.AddCell();
            WTableRow rowss = tabless.AddRow(true, false);
            WTableCell cellss = rowss.AddCell();

            //Style des Tableaux 
            table.TableFormat.HorizontalAlignment = RowAlignment.Right;
            tables.TableFormat.HorizontalAlignment = RowAlignment.Right;
            tabless.TableFormat.HorizontalAlignment = RowAlignment.Right;
            table.TableFormat.BackColor = Color.FromArgb(235, 235, 235);
            tables.TableFormat.BackColor = Color.FromArgb(235, 235, 235);
            tabless.TableFormat.BackColor = Color.FromArgb(235, 235, 235);

            //Informations Entêtes                                                 
            IWTextRange Desc = cell1.AddParagraph().AppendText("Description");
            Desc.CharacterFormat.Bold = true;
            Desc.CharacterFormat.FontSize = 12;
            cell1 = row1.AddCell();
            IWTextRange Qte = cell1.AddParagraph().AppendText("Quantité");
            Qte.CharacterFormat.Bold = true;
            Qte.CharacterFormat.FontSize = 12;
            cell1 = row1.AddCell();
            IWTextRange Prix = cell1.AddParagraph().AppendText("Prix (€)");
            Prix.CharacterFormat.Bold = true;
            Prix.CharacterFormat.FontSize = 12;
            cell1 = row1.AddCell();
            IWTextRange TVA = cell1.AddParagraph().AppendText("TVA (%)");
            TVA.CharacterFormat.Bold = true;
            TVA.CharacterFormat.FontSize = 12;
            cell1 = row1.AddCell();
            IWTextRange Total = cell1.AddParagraph().AppendText("Total HT(€)");
            Total.CharacterFormat.Bold = true;
            Total.CharacterFormat.FontSize = 12;

            //IDU
            string SelectIDU = "SELECT IDU FROM utilisateur WHERE MAIL='" + mailutilisateur + "'";
            MySqlCommand idu = new MySqlCommand(SelectIDU, connection);
            int IDU = int.Parse(idu.ExecuteScalar().ToString());

            if (IDD == 0)
            {
                //Document BDD
                string InsertDoc = "INSERT INTO document(IDU, IDC, DESCRIPTION) VALUES ('" + IDU + "',(SELECT IDC FROM client WHERE NOM = '" + Nom + "'), '" + DescriptionDoc.Text + "')";
                MySqlCommand doc = new MySqlCommand(InsertDoc, connection);
                doc.ExecuteNonQuery();

                //IDD
                string SelectIDD = "SELECT IDD FROM document WHERE IDU='" + IDU + "' AND IDC=(SELECT IDC FROM client WHERE NOM = '" + Nom + "') AND DESCRIPTION= '" + DescriptionDoc.Text + "'";
                MySqlCommand idd = new MySqlCommand(SelectIDD, connection);
                IDD = int.Parse(idd.ExecuteScalar().ToString());
            }


            foreach (DataGridViewRow ligne in dataGridView1.Rows)
            {
                if (ligne.Cells[0].Value != null)
                {
                    //Informations Prestations
                    WTableRow row = table.AddRow(true, false);
                    WTableCell cell = row.AddCell();

                    cell.AddParagraph().AppendText(ligne.Cells[1].Value.ToString());
                    cell = row.AddCell();
                    cell.AddParagraph().AppendText(ligne.Cells[0].Value.ToString());
                    cell = row.AddCell();
                    cell.AddParagraph().AppendText(ligne.Cells[3].Value.ToString());
                    cell = row.AddCell();
                    cell.AddParagraph().AppendText(ligne.Cells[2].Value.ToString());
                    cell = row.AddCell();
                    double SommePresta = Convert.ToDouble(ligne.Cells[3].Value.ToString()) * int.Parse(ligne.Cells[0].Value.ToString());
                    cell.AddParagraph().AppendText(SommePresta.ToString());

                    //IDP
                    string SelectIDP = "SELECT IDP FROM prestation WHERE NOM='" + ligne.Cells[1].Value.ToString() + "'";
                    MySqlCommand idp = new MySqlCommand(SelectIDP, connection);
                    int IDP = int.Parse(idp.ExecuteScalar().ToString());

                    //Incrémentation Concerner BDD
                    string InsertCon = "INSERT INTO concerner(IDD, IDP, QUANTITE) VALUES ('" + IDD + "' , '" + IDP + "' , '" + ligne.Cells[0].Value.ToString() + "')ON DUPLICATE KEY UPDATE IDD = '" + IDD + "'";
                    MySqlCommand con = new MySqlCommand(InsertCon, connection);
                    con.ExecuteNonQuery();

                    TotalHT += double.Parse(ligne.Cells[3].Value.ToString()) * int.Parse(ligne.Cells[0].Value.ToString());
                    if (double.Parse(ligne.Cells[3].Value.ToString()) != 0)
                    {
                        TotalTVA += double.Parse(ligne.Cells[3].Value.ToString()) * double.Parse(ligne.Cells[0].Value.ToString()) * (double.Parse(ligne.Cells[2].Value.ToString()) / 100);
                    }
                }
            }
            bookmarkNavigator.InsertTable(table);
            document.Replace("#Tableau#", "", true, true);

            string TotalTTC = String.Format("{0:0.##}", TotalHT + TotalTVA).Replace(",", ".");
            string TotalHt = String.Format("{0:0.##}", TotalHT).Replace(",", ".");
            string TotalTva = String.Format("{0:0.##}", TotalTVA).Replace(",", ".");

            //Tableau Totaux
            cell2.Width = 100;
            IWTextRange HT = cell2.AddParagraph().AppendText("Total HT");
            HT.CharacterFormat.Bold = true;
            HT.CharacterFormat.FontSize = 12;
            cell2 = row2.AddCell();
            cell2.Width = 100;
            cell2.AddParagraph().AppendText(TotalHt + " €");
            cells.Width = 100;
            IWTextRange Tva = cells.AddParagraph().AppendText("Total TVA");
            Tva.CharacterFormat.Bold = true;
            Tva.CharacterFormat.FontSize = 12;
            cells = rows.AddCell();
            cells.Width = 100;
            cells.AddParagraph().AppendText(TotalTva + " €");
            cellss.Width = 100;
            IWTextRange Ttc = cellss.AddParagraph().AppendText("Total TTC");
            Ttc.CharacterFormat.Bold = true;
            Ttc.CharacterFormat.FontSize = 12;
            cellss = rowss.AddCell();
            cellss.Width = 100;
            cellss.AddParagraph().AppendText(TotalTTC + " €");

            bookmark.InsertTable(tables);
            bookmark.InsertTable(tabless);
            document.Replace("#TableauTotaux#", "", true, true);

            //Devenir BDD
            string InsertDev = "INSERT INTO devenir(IDD, IDT, DATE) VALUES ('" + IDD + "' , 1 , '" + DateTime.Now.ToString("yyyy-MM-dd") + "')ON DUPLICATE KEY UPDATE IDD = '" + IDD + "'";
            MySqlCommand dev = new MySqlCommand(InsertDev, connection);
            dev.ExecuteNonQuery();

            //Update Document BDD
            string UpdateDoc = "UPDATE document SET PRIXTOTAL ='" + TotalTTC + "' WHERE IDD ='" + IDD + "'";
            MySqlCommand Doc = new MySqlCommand(UpdateDoc, connection);
            Doc.ExecuteNonQuery();

            //Supprime les espaces inutiles dans le document
            for (int secIndex = document.Sections.Count - 1; secIndex >= 0; secIndex--)
            {
                for (int i = document.Sections[secIndex].ChildEntities.Count - 1; i >= 0; i--)
                {
                    WTextBody textBody = document.Sections[secIndex].ChildEntities[i] as WTextBody;
                    if (textBody != null && textBody.EntityType == EntityType.TextBody)
                    {
                        if (textBody.ChildEntities.Count == 0)
                        {
                            document.Sections.RemoveAt(secIndex);
                            break;
                        }
                    }
                }
            }
            docStream.Dispose();

            DocToPDFConverter converter = new DocToPDFConverter();
            converter.Settings.ExportBookmarks = Syncfusion.DocIO.ExportBookmarkType.Headings | Syncfusion.DocIO.ExportBookmarkType.Bookmarks;
            PdfDocument PDF = converter.ConvertToPDF(document);
            string path = @"../Documents/Devis&Factures/" + NomClient + @"/Devis_N°" + IDD + "_de_" + NomClient + ".pdf";
            PDF.Save(path);
            MessageBox.Show("Le Devis de " + NomClient + " a bien été envoyé au Format PDF", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Déconnexion_Click(object sender, EventArgs e)
        {
            // Bouton Deconnexion
            connection.Close();
            Hide();
            Accueil x = new Accueil();
            x.Show();
            x.Refresh();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            //Bouton Home
            Hide();
            AccueilCo x = new AccueilCo();
            x.Show();
        }
        private void SaveFacture_Click(object sender, EventArgs e)
        {
            //Bouton Enregistrer Facture
            double TotalHT = 0;
            double TotalTVA = 0;
            string mailutilisateur = Connexion.utilisateur;
            string Nom = SelectClient.SelectedItem.ToString();
            NomClient = Nom;
            Date = DateTime.Today.ToLongDateString();

            //Bouton Enregistrer Devis
            WordDocument document = new WordDocument();
            Stream docStream = File.OpenRead(Path.GetFullPath(@"../Documents/Template/templateAutoFact.doc"));
            document.Open(docStream, Syncfusion.DocIO.FormatType.Doc);
            docStream.Dispose();

            //Informations Clients
            string Adressecliente = "SELECT NOM, MAIL, ADRESSE, VILLE, CODE_POSTAL, TEL FROM client WHERE NOM = '" + Nom + "'";
            MySqlCommand cmd = new MySqlCommand(Adressecliente, connection);
            MySqlDataReader infoclient = cmd.ExecuteReader();
            while (infoclient.Read())
            {
                document.Replace("#Nomclient#", infoclient["NOM"].ToString(), true, true);
                document.Replace("#Mailclient#", infoclient["MAIL"].ToString(), true, true);
                document.Replace("#Adresseclient#", infoclient["ADRESSE"].ToString(), true, true);
                document.Replace("#Villeclient#", infoclient["VILLE"].ToString(), true, true);
                document.Replace("#CPclient#", infoclient["CODE_POSTAL"].ToString(), true, true);
                document.Replace("#Telclient#", infoclient["TEL"].ToString(), true, true);
            }
            infoclient.Close();
            document.Replace("#Document#", "Facture", true, true);
            document.Replace("#Date#", DateTime.Today.ToLongDateString(), true, true);
            document.Replace("#Description#", DescriptionDoc.Text, true, true);

            //Tableaux
            BookmarksNavigator bookmarkNavigator = new BookmarksNavigator(document);
            bookmarkNavigator.MoveToBookmark("Tableau");
            IWSection section = document.AddSection();
            IWTable table = section.AddTable();

            BookmarksNavigator bookmark = new BookmarksNavigator(document);
            bookmark.MoveToBookmark("TableauTotaux");
            IWSection sections = document.AddSection();
            IWTable tables = sections.AddTable();
            IWTable tabless = sections.AddTable();

            WTableRow row1 = table.AddRow(true, false);
            WTableCell cell1 = row1.AddCell();
            WTableRow row2 = tables.AddRow(true, false);
            WTableCell cell2 = row2.AddCell();
            WTableRow rows = tables.AddRow(true, false);
            WTableCell cells = rows.AddCell();
            WTableRow rowss = tabless.AddRow(true, false);
            WTableCell cellss = rowss.AddCell();

            //Style des Tableaux 
            table.TableFormat.HorizontalAlignment = RowAlignment.Right;
            tables.TableFormat.HorizontalAlignment = RowAlignment.Right;
            tabless.TableFormat.HorizontalAlignment = RowAlignment.Right;
            table.TableFormat.BackColor = Color.FromArgb(235, 235, 235);
            tables.TableFormat.BackColor = Color.FromArgb(235, 235, 235);
            tabless.TableFormat.BackColor = Color.FromArgb(235, 235, 235);

            //Informations Entêtes                                                 
            IWTextRange Desc = cell1.AddParagraph().AppendText("Description");
            Desc.CharacterFormat.Bold = true;
            Desc.CharacterFormat.FontSize = 12;
            cell1 = row1.AddCell();
            IWTextRange Qte = cell1.AddParagraph().AppendText("Quantité");
            Qte.CharacterFormat.Bold = true;
            Qte.CharacterFormat.FontSize = 12;
            cell1 = row1.AddCell();
            IWTextRange Prix = cell1.AddParagraph().AppendText("Prix (€)");
            Prix.CharacterFormat.Bold = true;
            Prix.CharacterFormat.FontSize = 12;
            cell1 = row1.AddCell();
            IWTextRange TVA = cell1.AddParagraph().AppendText("TVA (%)");
            TVA.CharacterFormat.Bold = true;
            TVA.CharacterFormat.FontSize = 12;
            cell1 = row1.AddCell();
            IWTextRange Total = cell1.AddParagraph().AppendText("Total HT(€)");
            Total.CharacterFormat.Bold = true;
            Total.CharacterFormat.FontSize = 12;

            //IDU
            string SelectIDU = "SELECT IDU FROM utilisateur WHERE MAIL='" + mailutilisateur + "'";
            MySqlCommand idu = new MySqlCommand(SelectIDU, connection);
            int IDU = int.Parse(idu.ExecuteScalar().ToString());

            if (IDD == 0)
            {
                //Document BDD
                string InsertDoc = "INSERT INTO document(IDU, IDC, DESCRIPTION) VALUES ('" + IDU + "',(SELECT IDC FROM client WHERE NOM = '" + Nom + "'), '" + DescriptionDoc.Text + "')";
                MySqlCommand doc = new MySqlCommand(InsertDoc, connection);
                doc.ExecuteNonQuery();

                //IDD
                string SelectIDD = "SELECT IDD FROM document WHERE IDU='" + IDU + "' AND IDC=(SELECT IDC FROM client WHERE NOM = '" + Nom + "') AND DESCRIPTION= '" + DescriptionDoc.Text + "'";
                MySqlCommand idd = new MySqlCommand(SelectIDD, connection);
                IDD = int.Parse(idd.ExecuteScalar().ToString());
            }

            foreach (DataGridViewRow ligne in dataGridView1.Rows)
            {
                if (ligne.Cells[0].Value != null)
                {
                    //Informations Prestations
                    WTableRow row = table.AddRow(true, false);
                    WTableCell cell = row.AddCell();

                    cell.AddParagraph().AppendText(ligne.Cells[1].Value.ToString());
                    cell = row.AddCell();
                    cell.AddParagraph().AppendText(ligne.Cells[0].Value.ToString());
                    cell = row.AddCell();
                    cell.AddParagraph().AppendText(ligne.Cells[3].Value.ToString());
                    cell = row.AddCell();
                    cell.AddParagraph().AppendText(ligne.Cells[2].Value.ToString());
                    cell = row.AddCell();
                    double SommePresta = Convert.ToDouble(ligne.Cells[3].Value.ToString()) * int.Parse(ligne.Cells[0].Value.ToString());
                    cell.AddParagraph().AppendText(SommePresta.ToString());

                    //IDP
                    string SelectIDP = "SELECT IDP FROM prestation WHERE NOM='" + ligne.Cells[1].Value.ToString() + "'";
                    MySqlCommand idp = new MySqlCommand(SelectIDP, connection);
                    int IDP = int.Parse(idp.ExecuteScalar().ToString());

                    //Incrémentation Concerner BDD
                    string InsertCon = "INSERT INTO concerner(IDD, IDP, QUANTITE) VALUES ('" + IDD + "' , '" + IDP + "' , '" + ligne.Cells[0].Value.ToString() + "') ON DUPLICATE KEY UPDATE IDD = '" + IDD + "'";
                    MySqlCommand con = new MySqlCommand(InsertCon, connection);
                    con.ExecuteNonQuery();

                    TotalHT += double.Parse(ligne.Cells[3].Value.ToString()) * int.Parse(ligne.Cells[0].Value.ToString());
                    if (double.Parse(ligne.Cells[3].Value.ToString()) != 0)
                    {
                        TotalTVA += double.Parse(ligne.Cells[3].Value.ToString()) * double.Parse(ligne.Cells[0].Value.ToString()) * (double.Parse(ligne.Cells[2].Value.ToString()) / 100);
                    }
                }
            }
            bookmarkNavigator.InsertTable(table);
            document.Replace("#Tableau#", "", true, true);

            string TotalTTC = String.Format("{0:0.##}", TotalHT + TotalTVA).Replace(",", ".");
            string TotalHt = String.Format("{0:0.##}", TotalHT).Replace(",", ".");
            string TotalTva = String.Format("{0:0.##}", TotalTVA).Replace(",", ".");

            //Tableau Totaux
            cell2.Width = 100;
            IWTextRange HT = cell2.AddParagraph().AppendText("Total HT");
            HT.CharacterFormat.Bold = true;
            HT.CharacterFormat.FontSize = 12;
            cell2 = row2.AddCell();
            cell2.Width = 100;
            cell2.AddParagraph().AppendText(TotalHt + " €");
            cells.Width = 100;
            IWTextRange Tva = cells.AddParagraph().AppendText("Total TVA");
            Tva.CharacterFormat.Bold = true;
            Tva.CharacterFormat.FontSize = 12;
            cells = rows.AddCell();
            cells.Width = 100;
            cells.AddParagraph().AppendText(TotalTva + " €");
            cellss.Width = 100;
            IWTextRange Ttc = cellss.AddParagraph().AppendText("Total TTC");
            Ttc.CharacterFormat.Bold = true;
            Ttc.CharacterFormat.FontSize = 12;
            cellss = rowss.AddCell();
            cellss.Width = 100;
            cellss.AddParagraph().AppendText(TotalTTC + " €");

            bookmark.InsertTable(tables);
            bookmark.InsertTable(tabless);
            document.Replace("#TableauTotaux#", "", true, true);

            //Devenir BDD
            string InsertDev = "INSERT INTO devenir(IDD, IDT, DATE) VALUES ('" + IDD + "' , 1 , '" + DateTime.Now.ToString("yyyy-MM-dd") + "')ON DUPLICATE KEY UPDATE IDD = '" + IDD + "'";
            MySqlCommand dev = new MySqlCommand(InsertDev, connection);
            dev.ExecuteNonQuery();

            //Update Document BDD
            string UpdateDoc = "UPDATE document SET PRIXTOTAL ='" + TotalTTC + "' WHERE IDD ='" + IDD + "'";
            MySqlCommand Doc = new MySqlCommand(UpdateDoc, connection);
            Doc.ExecuteNonQuery();

            //Supprime les espaces inutiles dans le document
            for (int secIndex = document.Sections.Count - 1; secIndex >= 0; secIndex--)
            {
                for (int i = document.Sections[secIndex].ChildEntities.Count - 1; i >= 0; i--)
                {
                    WTextBody textBody = document.Sections[secIndex].ChildEntities[i] as WTextBody;
                    if (textBody != null && textBody.EntityType == EntityType.TextBody)
                    {
                        if (textBody.ChildEntities.Count == 0)
                        {
                            document.Sections.RemoveAt(secIndex);
                            break;
                        }
                    }
                }
            }
            docStream.Dispose();

            DocToPDFConverter converter = new DocToPDFConverter();
            converter.Settings.ExportBookmarks = Syncfusion.DocIO.ExportBookmarkType.Headings | Syncfusion.DocIO.ExportBookmarkType.Bookmarks;
            PdfDocument PDF = converter.ConvertToPDF(document);
            string path = @"../Documents/Devis&Factures/" + NomClient + @"/Facture_N°" + IDD + "_de_" + NomClient + ".pdf";
            PDF.Save(path);
            MessageBox.Show("La Facture de " + NomClient + " a bien été envoyé au Format PDF", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
