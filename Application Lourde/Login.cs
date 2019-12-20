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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            string Lelogin = TxtLogin.Text;
            string mdp = TxtMdp.Text;

            MySqlDataAdapter msda = new MySqlDataAdapter("select `LOGIN` from COMPTABLE", Program.mybdd.connection);  //on prepare une requete
            DataSet Logs = new DataSet();   //on cree en memoire un nouveau jeu de donnees
            msda.Fill(Logs);

            MySqlDataAdapter msda2 = new MySqlDataAdapter("select `MDP` from COMPTABLE", Program.mybdd.connection);  //on prepare une requete
            DataSet mdps = new DataSet();   //on cree en memoire un nouveau jeu de donnees
            msda2.Fill(mdps);

            bool verif = false; // variable qui indique si on as le bon mot de passe
            List<string> listeLogs = new List<string>();//creation de la liste des logs comptables
            List<string> listeMdp = new List<string>();//creation de la liste des mdp comptables
            for (int i = 0; i < Logs.Tables[0].Rows.Count; i++) //Boucle qui parcourt la requete sql et qui initialise les logins dans la liste
            {
                listeLogs.Add(Logs.Tables[0].Rows[i].ItemArray[0].ToString());

            }
            for (int i = 0; i < mdps.Tables[0].Rows.Count; i++) //Boucle qui parcourt la requete sql et qui initialise les mdps dans la liste
            {
                listeMdp.Add(mdps.Tables[0].Rows[i].ItemArray[0].ToString());

            }



            for (int i = 0; i < listeLogs.Count; i++) //boucle qui teste si le login inseré est present dans la liste des logins
            {
                if (Lelogin == listeLogs[i] && mdp == listeMdp[i] ) //changement de verification si le log et le mdp est présent
                {
                    verif = true;
                    
                }
            }
            
            if (verif==true)
            {
                Menu f = new Menu();
                f.Show();

            }
            else
            {
                MessageBox.Show("CONNEXION IMPOSSIBLE");
            }
           


        }
    }
}
