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
    public partial class User_Client_Recherche : UserControl
    {


        private static User_Client_Recherche UserRecherche;
        //Creer un instance pour le usercontrole recherche
        
        public static User_Client_Recherche Instance2
        {
            get
            {
                if (UserRecherche == null)
                {
                    UserRecherche = new User_Client_Recherche();
                }
                return UserRecherche;
            }
        }

        public User_Client_Recherche()
        {
            InitializeComponent();
        }

        private void User_Client_Recherche_Load(object sender, EventArgs e)
        {

        }
    }
}
