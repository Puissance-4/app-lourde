using Devart.Data.MySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Lourde
{
    public partial class ChangerFraisF : Form
    {
       
        public ChangerFraisF()
        {
            InitializeComponent();

            MySqlDataAdapter RecupPrix = new MySqlDataAdapter("SELECT `MONTANT_UNITAIRE` FROM TYPEFRAISFORFAIT", Program.mybdd.connection);  //on prepare une requete
            DataSet prix = new DataSet();   //on cree en memoire un nouveau jeu de donnees
            RecupPrix.Fill(prix);

            double montantNuitee = Convert.ToDouble(prix.Tables[0].Rows[0].ItemArray[0]);
            double montantRepasMidi = Convert.ToDouble(prix.Tables[0].Rows[1].ItemArray[0]);
            double montantRepasRelais = Convert.ToDouble(prix.Tables[0].Rows[2].ItemArray[0]);
            double montantPrixKm = Convert.ToDouble(prix.Tables[0].Rows[3].ItemArray[0]);

            BoxPrixNuitee.Text = montantNuitee.ToString();
            BoxPrixMidi.Text = montantRepasMidi.ToString();
            BoxPrixRepasRelais.Text = montantRepasRelais.ToString();
            BoxPrixKm.Text = montantPrixKm.ToString();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            Close();
        }

        static void UpdateTypeFraisF(int ID, Double MONTANT_UNITAIRE)
        {
            MySqlCommand command = Program.mybdd.connection.CreateCommand();
            command.CommandText = "UPDATE TYPEFRAISFORFAIT SET MONTANT_UNITAIRE = @montant_unitaire WHERE ID=@id;";//requete avec un paramètre
            command.Parameters.AddWithValue("@id", ID);  //remplissage du paramètre
            command.Parameters.AddWithValue("@montant_unitaire", MONTANT_UNITAIRE);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
            }

        } 

        private void BtnValider_Click(object sender, EventArgs e)
        {
            

            UpdateTypeFraisF(1,Convert.ToDouble( BoxPrixNuitee.Text)) ;
            UpdateTypeFraisF(2,Convert.ToDouble(BoxPrixMidi.Text));
            UpdateTypeFraisF(3,Convert.ToDouble(BoxPrixRepasRelais.Text));
            UpdateTypeFraisF(4,Convert.ToDouble(BoxPrixKm.Text));

            Menu f = new Menu();
            f.Show();
            Close();
        }
      
    }
}
