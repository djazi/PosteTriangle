using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosteTriangle.PL
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel2.Size = new Size(240, 638);
            pnlconnexion.Visible = false;

        }

        private void BtnQuitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimized_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnHideMenu_Click(object sender, EventArgs e)
        {
            if(panel2.Width== 240)
            {
                panel2.Size = new Size(75, 638);
            }else
            {
                panel2.Size = new Size(240, 638); 
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            pnlbut.Top = BtnRechercher.Top;
        }

        private void BtnPerformance_Click(object sender, EventArgs e)
        {
            pnlbut.Top = BtnPerformance.Top;
        }

        private void BtnAtelier_Click(object sender, EventArgs e)
        {
            pnlbut.Top = BtnAtelier.Top;
        }

        private void BtnGuide_Click(object sender, EventArgs e)
        {
            pnlbut.Top = BtnGuide.Top;
        }

        private void BtnParametre_Click(object sender, EventArgs e)
        {
            pnlconnexion.Size = new Size(189, 132);
            pnlconnexion.Visible = !pnlconnexion.Visible;
        }
    }
}
