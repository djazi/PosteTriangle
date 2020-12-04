using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PosteTriangle.PL
{
    public partial class User_Client_Affichage : UserControl
    {
        private static User_Client_Affichage UserAffichage;
        //Creer un instance pour le usercontrole Affichage 
        public static User_Client_Affichage Instance1
        {
            get
            {
                if (UserAffichage == null)
                {
                    UserAffichage = new User_Client_Affichage();
                }
                return UserAffichage;
            }
        }
        public User_Client_Affichage()
        {
            InitializeComponent();
        }

        private void User_Client_Affichage_Load(object sender, EventArgs e)
        {

        }

        private void TxtPer_LT_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtPer_LT_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
