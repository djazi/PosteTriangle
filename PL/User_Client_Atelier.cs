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
   
    public partial class User_Client_Atelier : UserControl
    {
        private static User_Client_Atelier Userclient;
        //Creer un instance pour le usercontrole Atelier 
        public static User_Client_Atelier Instance
        {
            get
            {
                if(Userclient==null)
                {
                    Userclient = new User_Client_Atelier();
                }
                return Userclient;
            }
        }
       public User_Client_Atelier()
        {
            InitializeComponent();
        }

        private void User_Client_Atelier_Load(object sender, EventArgs e)
        {

        }

     

        private void TxtidAtelier_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void TxtH_Debut_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtH_Debut.Text == "Heure Début")
            {
                TxtH_Debut.Text = "";
                TxtH_Debut.ForeColor = Color.DarkGray;



            }

        }

        private void TxtH_Debut_Leave(object sender, EventArgs e)
        {
            if (TxtH_Debut.Text == "")
            {
                TxtH_Debut.Text = "Heure Début";
                TxtH_Debut.ForeColor = Color.Silver;
            }

        }

        

       

        private void TxtH_Fin_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtH_Fin.Text == "Heure de Fin ")
            {
                TxtH_Fin.Text = "";
                TxtH_Fin.ForeColor = Color.DarkGray;



            }
        }

        private void TxtH_Fin_Leave(object sender, EventArgs e)
        {
            if (TxtH_Fin.Text == "")
            {
                TxtH_Fin.Text = "Heure de Fin ";
                TxtH_Fin.ForeColor = Color.Silver;
            }
        }

        private void TxtStockEc_Nominale_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtStockEc_Nominale.Text == "Stock en Cours*")
            {
                TxtStockEc_Nominale.Text = "";
                TxtStockEc_Nominale.ForeColor = Color.DarkGray;



            }

        }

        private void TxtStockEc_Nominale_Leave(object sender, EventArgs e)
        {
            if (TxtStockEc_Nominale.Text == "")
            {
                TxtStockEc_Nominale.Text = "Stock en Cours*";
                TxtStockEc_Nominale.ForeColor = Color.Silver;
            }

        }

        private void TxtDate_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtDate.Text == "Date")
            {
                TxtDate.Text = "";
                TxtDate.ForeColor = Color.DarkGray;



            }

        }

        private void TxtDate_Leave(object sender, EventArgs e)
        {
            if (TxtDate.Text == "")
            {
                TxtDate.Text = "Date";
                TxtDate.ForeColor = Color.Silver;
            }

        }

        

        private void TxtTKT_Time_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtTKT_Time.Text == "Takt time")
            {
                TxtTKT_Time.Text = "";
                TxtTKT_Time.ForeColor = Color.DarkGray;

            }
        }

        private void TxtTKT_Time_Leave(object sender, EventArgs e)
        {
            if (TxtTKT_Time.Text == "")
            {
                TxtTKT_Time.Text = "Takt time";
                TxtTKT_Time.ForeColor = Color.Silver;
            }
        }

        private void TxtP_Conforme_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtP_Conforme.Text == "Piéces Conformes")
            {
                TxtP_Conforme.Text = "";
                TxtP_Conforme.ForeColor = Color.DarkGray;

            }
        }

        private void TxtP_Conforme_Leave(object sender, EventArgs e)
        {
            if (TxtP_Conforme.Text == "")
            {
                TxtP_Conforme.Text = "Piéces Conformes";
                TxtP_Conforme.ForeColor = Color.Silver;
            }
        }

        private void TxtEffectif_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtEffectif.Text == "Effectif")
            {
                TxtEffectif.Text = "";
                TxtEffectif.ForeColor = Color.DarkGray;

            }
        }

        private void TxtEffectif_Leave(object sender, EventArgs e)
        {
            if (TxtEffectif.Text == "")
            {
                TxtEffectif.Text = "Effectif";
                TxtEffectif.ForeColor = Color.Silver;
            }
        }

        private void TxtP_N_Conformes_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtP_N_Conformes.Text == "Piéces Non Conformes")
            {
                TxtP_N_Conformes.Text = "";
                TxtP_N_Conformes.ForeColor = Color.DarkGray;

            }
        }

        private void TxtP_N_Conformes_Leave(object sender, EventArgs e)
        {
            if (TxtP_N_Conformes.Text == "")
            {
                TxtP_N_Conformes.Text = "Piéces Non Conformes";
                TxtP_N_Conformes.ForeColor = Color.Silver;
            }
        }

        private void TxtStock_EC_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtStock_EC.Text == "Stock en Cours")
            {
                TxtStock_EC.Text = "";
                TxtStock_EC.ForeColor = Color.DarkGray;

            }
        }

        private void TxtStock_EC_Leave(object sender, EventArgs e)
        {

            if (TxtStock_EC.Text == "")
            {
                TxtStock_EC.Text = "Stock en Cours";
                TxtStock_EC.ForeColor = Color.Silver;
            }
        }


        private void TxtHeure_Leave(object sender, EventArgs e)
        {
            














        }

        private void TxtLead_Time_Nominal_Enter_1(object sender, EventArgs e)
        {

        }

        private void Btn_Commencer_Click(object sender, EventArgs e)
        {

        }

        private void TxtP_N_Conformes_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtP_Conforme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
