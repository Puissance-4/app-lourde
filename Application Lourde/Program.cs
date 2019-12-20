using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.MySql;

namespace Application_Lourde
{
    static class Program
    {
        public static Bdd mybdd;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mybdd = new Bdd("192.168.2.4", "bdhdebec7", "sqlhdebec", "savary");
            

            //ouvre la connexion

            if (Program.mybdd.OpenConnection() != true)
                
                Application.Exit();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            //ferme la connexion

            Program.mybdd.CloseConnection();
        }
    }
}
