using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.MySql;


namespace Application_Lourde
{
    public partial class DetailFiche : Form
    {
        //ID de la fiche
        private string id;

        //ID du frai sélectionné
        //string idFrais;
        string libelle;
     
        

        public DetailFiche(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void DetailFiche_Load(object sender, EventArgs e)
        {


            int idFiche = int.Parse(this.id);
            MySqlDataAdapter msda = new MySqlDataAdapter("select LIBELLE , DATE, MONTANT, VALIDITE from FRAISHORSFORFAIT where ID_FICHE=" + idFiche, Program.mybdd.connection);  //on prepare une requete
            DataSet DS = new DataSet();   //on cree en memoire un nouveau jeu de donnees
            msda.Fill(DS);                //on remplit ce jeu de donnees
            ListFraisHF.DataSource = DS.Tables[0];    //on le lie a la grille
            txtId.Text = idFiche.ToString();

            

        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            //string idFiche = txtId.Text;
            FormFiche f = new FormFiche();
            f.Show();
            Close();
        }
        

        private void ListFraisHF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            libelle = ListFraisHF.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Ligne selectionnée");
        }

        private void BtnModifier_click(object sender, EventArgs e)
        {
            int idFiche = int.Parse(this.id);
            MySqlCommand command = Program.mybdd.connection.CreateCommand();
            command.CommandText = ("UPDATE `FRAISHORSFORFAIT` SET VALIDITE = 0 WHERE `LIBELLE` = @libelle AND ID_FICHE= @idFiche"); //requete avec un paramètre
            command.Parameters.AddWithValue("@libelle", libelle);
            command.Parameters.AddWithValue("@idFiche", idFiche); //remplissage du paramètre
            command.ExecuteNonQuery();
           

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
            }
            MessageBox.Show("Ligne modifiée");

            DetailFiche f = new DetailFiche(id);
            f.Show();
            Close();
        }
    }
    
}
