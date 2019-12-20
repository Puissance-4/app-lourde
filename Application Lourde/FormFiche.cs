using Devart.Data.MySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Lourde
{
    public partial class FormFiche : Form
    {
        //Liste qui va stocké les id des fiche que l'on veut modifier
        List<ListViewItem> listeIDFiche = new List<ListViewItem>();
        List<ListViewItem> listeIDFraisHF = new List<ListViewItem>();

        public FormFiche()
        {
            InitializeComponent();
        }

        private void FormFiche_Load(object sender, EventArgs e)
        {
            this.comboBox_Mois.Items.AddRange(new object[] {"Tous",
                        "Janvier",
                        "Février",
                        "Mars",
                        "Avril",
                        "Mai",
                        "Juin",
                        "Juillet",
                        "Août",
                        "Septembre",
                        "Octobre",
                        "Novembre",
                        "Décembre",});

        }

        //On affiche toutes les fiches
        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            RemplirListView();
        }

        private void Button_Cloture_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Fiches.CheckedItems)
            {
                //On ajoute toute les fiches cochées dans la liste
                listeIDFiche.Add(item);
            }

            //pour chaque fiche de la liste on update en la cloturant
            foreach (ListViewItem uneFiche in listeIDFiche)
            {
                UpdateEtatFiche(Convert.ToInt32(uneFiche.Text), 2);
            }
            MessageBox.Show("Modifications réussies");
            listeIDFiche.Clear();
            RemplirListView();
        }

        private void Button_Valider(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView_Fiches.CheckedItems)
            {
                //On ajoute toute les fiches cochées dans la liste
                listeIDFiche.Add(item);
            }

            //pour chaque fiche de la liste on update en la validant
            foreach (ListViewItem uneFiche in listeIDFiche)
            {
                UpdateEtatFiche(Convert.ToInt32(uneFiche.Text), 1);


                MySqlDataAdapter msdaF = new MySqlDataAdapter("CALL calculmontantF('" + Convert.ToInt32(uneFiche.Text) + "');", Program.mybdd.connection);  //on prepare une requete
                DataSet MontantF = new DataSet();   //on cree en memoire un nouveau jeu de donnees
                msdaF.Fill(MontantF);

                MySqlDataAdapter msdaHF = new MySqlDataAdapter("CALL calculmontantHF('" + Convert.ToInt32(uneFiche.Text) + "');", Program.mybdd.connection);  //on prepare une requete
                DataSet MontantHF = new DataSet();   //on cree en memoire un nouveau jeu de donnees
                msdaHF.Fill(MontantHF);
                String montantTotalF = MontantF.Tables[0].Rows[0].ItemArray[0].ToString();
                String montantTotalHF = MontantHF.Tables[0].Rows[0].ItemArray[0].ToString();
                double montantRemb = Convert.ToDouble(montantTotalF) + Convert.ToDouble(montantTotalHF);

                UpdateMontantFiche(Convert.ToInt32(uneFiche.Text), montantRemb);



            }
            MessageBox.Show("Modifications réussies");
            listeIDFiche.Clear();

            RemplirListView();



        }

        private void Button_Remboursee_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Fiches.CheckedItems)
            {
                //On ajoute toute les fiches cochées dans la liste
                listeIDFiche.Add(item);
            }

            //pour chaque fiche de la liste on upade en la remboursant
            foreach (ListViewItem uneFiche in listeIDFiche)
            {
                UpdateEtatFiche(Convert.ToInt32(uneFiche.Text), 5);
            }
            MessageBox.Show("Modifications réussies");
            listeIDFiche.Clear();
            RemplirListView();


        }

        private void Button_Mep_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Fiches.CheckedItems)
            {
                //On ajoute toute les fiches cochées dans la liste
                listeIDFiche.Add(item);
            }

            //pour chaque fiche de la liste on upade en la mettant en paiement
            foreach (ListViewItem uneFiche in listeIDFiche)
            {
                UpdateEtatFiche(Convert.ToInt32(uneFiche.Text), 4);
            }
            MessageBox.Show("Modifications réussies");
            listeIDFiche.Clear();
            RemplirListView();
        }

        //Méthode qui met à jour l'état d'une fiche selon les paramètres donnés
        static void UpdateEtatFiche(int idFiche, int idEtat)
        {
            MySqlCommand command = Program.mybdd.connection.CreateCommand();
            command.CommandText = "UPDATE FICHE SET ID_ETAT = @idEtat WHERE ID=@idFiche;"; //requete avec un paramètre
            command.Parameters.AddWithValue("@idFiche", idFiche);  //remplissage du paramètre
            command.Parameters.AddWithValue("@idEtat", idEtat);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
            }

        }


        static void UpdateMontantFiche(int idFiche, double montant)
        {
            MySqlCommand command = Program.mybdd.connection.CreateCommand();
            command.CommandText = "UPDATE FICHE SET MONTANT_REMBOURSE = @montant WHERE ID=@idFiche;"; //requete avec un paramètre
            command.Parameters.AddWithValue("@idFiche", idFiche);  //remplissage du paramètre
            command.Parameters.AddWithValue("@montant", montant);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
            }

        }

        public void RemplirListView()
        {
            //récupère le nom du client et l'index du mois choisi
            String nom = textBox_NomClient.Text;
            String mois = comboBox_Mois.SelectedIndex.ToString();



            if (comboBox_Mois.SelectedIndex.ToString() == "0")
            {
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT FICHE.ID, DATE_FORMAT(FICHE.DATE_CREATION, '%d/%m/%Y'), DATE_FORMAT(FICHE.DATE_MODIF, '%d/%m/%Y'), FICHE.MONTANT_REMBOURSE, ETAT.LIBELLE FROM FICHE INNER JOIN VISITEUR ON VISITEUR.ID = FICHE.ID_VISITEUR INNER JOIN ETAT ON ETAT.ID = FICHE.ID_ETAT WHERE VISITEUR.NOM LIKE '" + nom + "';", Program.mybdd.connection);  //on prepare une requete
                DataSet Fiches = new DataSet();   //on cree en memoire un nouveau jeu de donnees
                msda.Fill(Fiches);
                List<string> listeFiches = new List<string>();
                listeFiches.Clear();
                listView_Fiches.Clear();

                for (int i = 0; i < Fiches.Tables[0].Rows.Count; i++) //Boucle qui parcourt la requete sql et qui initialise les fiches dans la liste
                {
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[0].ToString());
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[1].ToString());
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[2].ToString());
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[3].ToString());
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[4].ToString());
                }

                // Create a new ListView control.
                ListView listView1 = new ListView();
                listView_Fiches.Bounds = new Rectangle(new Point(75, 100), new Size(500, 200));

                // Set the view to show details.
                listView_Fiches.View = View.Details;
                // Allow the user to edit item text.
                listView_Fiches.LabelEdit = true;
                // Allow the user to rearrange columns.
                listView_Fiches.AllowColumnReorder = true;
                // Display check boxes.
                listView_Fiches.CheckBoxes = true;
                // Select the item and subitems when selection is made.
                listView_Fiches.FullRowSelect = true;
                // Display grid lines.
                listView_Fiches.GridLines = true;
                // Sort the items in the list in ascending order.
                //listView_Fiches.Sorting = SortOrder.Ascending;

                //Nombre de fiche
                int nbFiche = listeFiches.Count / 5;

                //k est un compteur qui change lorsque l'on change de fiche
                int k = 0;

                //n est un compteur quelconque
                int n = 0;

                ListViewItem[] TabItem = new ListViewItem[listeFiches.Count / 5];

                for (int i = 0; i < nbFiche; i++)
                {
                    // Create three items and three sets of subitems for each item.
                    TabItem[k] = new ListViewItem(listeFiches[n], 0);
                    // Place a check mark next to the item.
                    n++;
                    TabItem[k].SubItems.Add(listeFiches[n]);
                    n++;
                    TabItem[k].SubItems.Add(listeFiches[n]);
                    n++;
                    TabItem[k].SubItems.Add(listeFiches[n]);
                    n++;
                    TabItem[k].SubItems.Add(listeFiches[n]);
                    n++;
                    k++;
                }

                // Create columns for the items and subitems.
                // Width of -2 indicates auto-size.
                listView_Fiches.Columns.Add("Fiche", -2, HorizontalAlignment.Left);
                listView_Fiches.Columns.Add("Date création", -2, HorizontalAlignment.Left);
                listView_Fiches.Columns.Add("Date modification", -2, HorizontalAlignment.Left);
                listView_Fiches.Columns.Add("Montant rembousé", -2, HorizontalAlignment.Left);
                listView_Fiches.Columns.Add("Etat", -2, HorizontalAlignment.Left);

                //Add the items to the ListView.
                foreach (ListViewItem item in TabItem)
                {
                    listView_Fiches.Items.AddRange(new ListViewItem[] { item });
                }

                // resize des colonnes
                listView_Fiches.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                // Add the ListView to the control collection.
                this.Controls.Add(listView_Fiches);

                //listView_Fiches = listView1;

                Button_validee.Visible = true;
                Button_Remboursee.Visible = true;
                Button_Mep.Visible = true;
                button_Cloture.Visible = true;

            }
            else
            {
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT FICHE.ID, FICHE.DATE_CREATION, FICHE.DATE_MODIF, FICHE.MONTANT_REMBOURSE, ETAT.LIBELLE FROM FICHE INNER JOIN VISITEUR ON VISITEUR.ID = FICHE.ID_VISITEUR INNER JOIN ETAT ON ETAT.ID = FICHE.ID_ETAT WHERE VISITEUR.NOM LIKE '" + nom + "' AND  MONTH(FICHE.DATE_CREATION) = '" + mois + "';", Program.mybdd.connection);  //on prepare une requete
                DataSet Fiches = new DataSet();   //on cree en memoire un nouveau jeu de donnees
                msda.Fill(Fiches);
                List<string> listeFiches = new List<string>();
                listeFiches.Clear();
                listView_Fiches.Clear();

                for (int i = 0; i < Fiches.Tables[0].Rows.Count; i++) //Boucle qui parcourt la requete sql et qui initialise les fiches dans la liste
                {
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[0].ToString());
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[1].ToString());
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[2].ToString());
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[3].ToString());
                    listeFiches.Add(Fiches.Tables[0].Rows[i].ItemArray[4].ToString());
                }

                // Create a new ListView control.
                ListView listView1 = new ListView();
                listView_Fiches.Bounds = new Rectangle(new Point(75, 100), new Size(500, 200));

                // Set the view to show details.
                listView_Fiches.View = View.Details;
                // Allow the user to edit item text.
                listView_Fiches.LabelEdit = true;
                // Allow the user to rearrange columns.
                listView_Fiches.AllowColumnReorder = true;
                // Display check boxes.
                listView_Fiches.CheckBoxes = true;
                // Select the item and subitems when selection is made.
                listView_Fiches.FullRowSelect = true;
                // Display grid lines.
                listView_Fiches.GridLines = true;
                // Sort the items in the list in ascending order.
                //listView_Fiches.Sorting = SortOrder.Ascending;

                //Nombre de fiche
                int nbFiche = listeFiches.Count / 5;

                //k est un compteur qui change lorsque l'on change de fiche
                int k = 0;

                //n est un compteur quelconque
                int n = 0;

                ListViewItem[] TabItem = new ListViewItem[listeFiches.Count / 5];

                for (int i = 0; i < nbFiche; i++)
                {
                    // Create three items and three sets of subitems for each item.
                    TabItem[k] = new ListViewItem(listeFiches[n], 0);
                    // Place a check mark next to the item.
                    n++;
                    TabItem[k].SubItems.Add(listeFiches[n]);
                    n++;
                    TabItem[k].SubItems.Add(listeFiches[n]);
                    n++;
                    TabItem[k].SubItems.Add(listeFiches[n]);
                    n++;
                    TabItem[k].SubItems.Add(listeFiches[n]);
                    n++;
                    k++;
                }

                // Create columns for the items and subitems.
                // Width of -2 indicates auto-size.
                listView_Fiches.Columns.Add("Fiche", -2, HorizontalAlignment.Left);
                listView_Fiches.Columns.Add("Date création", -2, HorizontalAlignment.Left);
                listView_Fiches.Columns.Add("Date modification", -2, HorizontalAlignment.Left);
                listView_Fiches.Columns.Add("Montant rembousé", -2, HorizontalAlignment.Left);
                listView_Fiches.Columns.Add("Etat", -2, HorizontalAlignment.Left);

                //Add the items to the ListView.
                foreach (ListViewItem item in TabItem)
                {
                    listView_Fiches.Items.AddRange(new ListViewItem[] { item });
                }

                // resize des colonnes
                listView_Fiches.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                // Add the ListView to the control collection.
                this.Controls.Add(listView_Fiches);

                //listView_Fiches = listView1;

                Button_validee.Visible = true;
                Button_Remboursee.Visible = true;
                Button_Mep.Visible = true;
                button_Cloture.Visible = true;
            }

        }


        private void BtnModifPrixFraisF_Click(object sender, EventArgs e)
        {
            ChangerFraisF f = new ChangerFraisF();
            f.Show();
            Close();
        }

        private void Btnretour_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            Close();
        }

        private void ListView_Fiches_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemplirListHFView();
        }

        public void RemplirListHFView()
        {
            //récupère le nom du client et l'index du mois choisi
            string idFiche = listView_Fiches.SelectedItems[0].Text;

            MySqlDataAdapter msda = new MySqlDataAdapter(" select ID, LIBELLE , DATE, MONTANT, VALIDITE from FRAISHORSFORFAIT where ID_FICHE=" + idFiche, Program.mybdd.connection);//on prepare une requete
            DataSet FraisHF = new DataSet();   //on cree en memoire un nouveau jeu de donnees
            msda.Fill(FraisHF);
            List<string> listeFraisHF = new List<string>();
            listeFraisHF.Clear();
            ListViewFraisHF.Clear();

            for (int i = 0; i < FraisHF.Tables[0].Rows.Count; i++) //Boucle qui parcourt la requete sql et qui initialise les frais dans la liste
            {
                listeFraisHF.Add(FraisHF.Tables[0].Rows[i].ItemArray[0].ToString());
                listeFraisHF.Add(FraisHF.Tables[0].Rows[i].ItemArray[1].ToString());
                listeFraisHF.Add(FraisHF.Tables[0].Rows[i].ItemArray[2].ToString());
                listeFraisHF.Add(FraisHF.Tables[0].Rows[i].ItemArray[3].ToString());
                listeFraisHF.Add(FraisHF.Tables[0].Rows[i].ItemArray[4].ToString());
            }

            // Create a new ListView control.
            ListView listView2 = new ListView();
            ListViewFraisHF.Bounds = new Rectangle(new Point(675, 100), new Size(500, 200));

            // Set the view to show details.
            ListViewFraisHF.View = View.Details;
            // Allow the user to edit item text.
            ListViewFraisHF.LabelEdit = true;
            // Allow the user to rearrange columns.
            ListViewFraisHF.AllowColumnReorder = true;
            // Display check boxes.
            ListViewFraisHF.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            ListViewFraisHF.FullRowSelect = true;
            // Display grid lines.
            ListViewFraisHF.GridLines = true;
            // Sort the items in the list in ascending order.
            //listView_Fiches.Sorting = SortOrder.Ascending;

            //Nombre de frais
            int nbFraisHF = listeFraisHF.Count / 5;

            //k est un compteur qui change lorsque l'on change de fiche
            int k = 0;

            //n est un compteur quelconque
            int n = 0;

            ListViewItem[] TabItem = new ListViewItem[listeFraisHF.Count / 5];

            for (int i = 0; i < nbFraisHF; i++)
            {
                // Create three items and three sets of subitems for each item.
                TabItem[k] = new ListViewItem(listeFraisHF[n], 0);
                // Place a check mark next to the item.
                n++;
                string item = listeFraisHF[n];
                TabItem[k].SubItems.Add(item);
                n++;
                TabItem[k].SubItems.Add(listeFraisHF[n]);
                n++;
                TabItem[k].SubItems.Add(listeFraisHF[n]);
                n++;
                TabItem[k].SubItems.Add(listeFraisHF[n]);
                n++;
                k++;
            }

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            ListViewFraisHF.Columns.Add("id", -2, HorizontalAlignment.Left);
            ListViewFraisHF.Columns.Add("libelle", -2, HorizontalAlignment.Left);
            ListViewFraisHF.Columns.Add("date", -2, HorizontalAlignment.Left);
            ListViewFraisHF.Columns.Add("montant", -2, HorizontalAlignment.Left);
            ListViewFraisHF.Columns.Add("validité", -2, HorizontalAlignment.Left);
            
            //Add the items to the ListView.
            foreach (ListViewItem item in TabItem)
            {
                ListViewFraisHF.Items.AddRange(new ListViewItem[] { item });
            }

            // resize des colonnes
            ListViewFraisHF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // Add the ListView to the control collection.
            this.Controls.Add(ListViewFraisHF);

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListViewFraisHF.CheckedItems)
            {
                //On ajoute toute les fiches cochées dans la liste
                listeIDFraisHF.Add(item);
            }

            //pour chaque fiche de la liste on upade en la mettant en paiement
            foreach (ListViewItem unFrais in listeIDFraisHF)
            {
                ValiderFrais(Convert.ToInt32(unFrais.Text));
            }
            MessageBox.Show("Modifications réussies");
            ListViewFraisHF.Clear();
            RemplirListHFView();
        }

        static void ValiderFrais(int idFrais)
        {
            MySqlCommand command = Program.mybdd.connection.CreateCommand();
            command.CommandText = "UPDATE FRAISHORSFORFAIT SET VALIDITE = 0 WHERE ID=@idFrais;"; //requete avec un paramètre
            command.Parameters.AddWithValue("@idFrais", idFrais);  //remplissage du paramètre

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
            }

        }

    }
}
