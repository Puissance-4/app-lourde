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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void BtnModifPrixFraisF_Click(object sender, EventArgs e)
        {
            ChangerFraisF f = new ChangerFraisF();
            f.Show();
            Close();
        }

        private void BtnChoixDuVis_Click(object sender, EventArgs e)
        {
            FormFiche f = new FormFiche();
            f.Show();
            Close();
        }
    }
}
