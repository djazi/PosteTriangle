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
            // hide labels 
            labelCT.Visible = false;
            labelQt.Visible = false;
            labelSec.Visible = false;
            labelTC.Visible = false;
            labelTKTCT.Visible = false;
            labelTrg.Visible = false;

        }

        private void TxtPer_LT_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtPer_LT_Leave(object sender, EventArgs e)
        {
            
        }

        private void Btn_Performance_Click(object sender, EventArgs e)
        {
            BL.CDB db = new BL.CDB();
            db.openConnection();
            
         
            
            

            // a modifer pour chaque Poste 

            MySqlDataAdapter asdf = new MySqlDataAdapter("SELECT * from saisie_poste WHERE Date = '" + TxtDate.Text + "'", db.getConnection());
            DataTable ss = new DataTable();
            asdf.Fill(ss);
            TxtNomAtelier.Text = ss.Rows[0][1].ToString();
             string v= ss.Rows[0][3].ToString(); // get PC from saisie_poste
            string w = ss.Rows[0][4].ToString();//get PNC from saisie_poste
            string tk= ss.Rows[0][6].ToString();// get TKT from saisie_poste

            int sum = int.Parse(w) + int.Parse(v); //calcule de la QT 
            TxtQteProduite.Text = sum.ToString(); //set QT dans TXTBOX

            string t = ss.Rows[0][9].ToString(); // get time from saisie_poste

            decimal ct = (decimal) int.Parse(t) /(sum); // calcule de cycle time
            decimal ctr= Math.Round(ct, 2);
            TxtCycleTime.Text = ctr.ToString(); // set cycle time dans TXTBOX

           

            decimal tkct = Math.Abs(int.Parse(tk)-ct); //calcule de TKTvsCT
            decimal tktctr= Math.Round(tkct, 2);

            if (tktctr <= 3)
            {
                TxtPer_TKTCT.Text = tktctr.ToString(); //set TKTCT dans txtbox
                TxtPer_TKTCT.ForeColor = Color.DarkGreen;
            }
            else
            {
                TxtPer_TKTCT.Text = tktctr.ToString(); //set TKTCT dans txtbox
                TxtPer_TKTCT.ForeColor = Color.Crimson;

            }







            decimal Trg = (decimal) (int.Parse(v) * ct)*100 / 1207;  // calcule TRG
            decimal Trgr = Math.Round(Trg, 2); // round with two number

            if (Trgr >= 70)
            {
                TxtPer_TRG.Text = Trgr.ToString(); //  set %TRG to TXTBOX
                TxtPer_TRG.ForeColor = Color.DarkGreen;




            }
            else
            {
                TxtPer_TRG.Text = Trgr.ToString(); //  set %TRG to TXTBOX
                TxtPer_TRG.ForeColor = Color.Crimson;

            }










            decimal tc = (decimal)  (int.Parse(v)*100/sum); // calcule TC
            decimal tcr = Math.Round(tc, 2); // round with two number
            if (tcr > 80)
            {
                TxtPer_TauxConfor.Text = tcr.ToString(); // set %CONFORMITe to TXTBOX
                
                TxtPer_TauxConfor.ForeColor = Color.DarkGreen;
               

            } else
            {
                TxtPer_TauxConfor.Text = tcr.ToString(); // set %CONFORMITe to TXTBOX

                TxtPer_TauxConfor.ForeColor = Color.Crimson;
            }












            //close the connection
            db.closeConnection();



            db.openConnection();

            // get valeur de stock triangle 

            MySqlDataAdapter asdf1 = new MySqlDataAdapter("SELECT * from stock_poste WHERE Date = '" + TxtDate.Text + "'", db.getConnection());
            DataTable ss1 = new DataTable();
            asdf1.Fill(ss1);
            string s = ss1.Rows[0][5].ToString(); // a modifier pour chaque poste 
            if(int.Parse(s)<=4)
            {
                TxtPer_StockEC_Atelier.Text = s.ToString();
                TxtPer_StockEC_Atelier.ForeColor = Color.DarkGreen;
            }
            else
            {
                TxtPer_StockEC_Atelier.Text = s.ToString();
                TxtPer_StockEC_Atelier.ForeColor = Color.Crimson;

            }




            db.closeConnection();






            //show labels 
             
            labelCT.Visible = true;
            labelQt.Visible = true;
            labelSec.Visible = true;
            labelTC.Visible = true;
            labelTKTCT.Visible = true;
            labelTrg.Visible = true;






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

        private void BtnSuvegarderp_Click(object sender, EventArgs e)
        {
            BL.CDB db = new BL.CDB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `affichage_poste`(`Date`, `Stock`, `TRG`, `Taux_conformité`, `Cycle_Time`, `TKT_VS_CT`, `Nom_Atelier`) VALUES (@dt, @st, @trg, @tc, @ct, @tktct, @nat)", db.getConnection());

            // fill table affichage_poste    
            command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = TxtPer_StockEC_Atelier.Text;
            command.Parameters.Add("@trg", MySqlDbType.VarChar).Value = TxtPer_TRG.Text;
            command.Parameters.Add("@tc", MySqlDbType.VarChar).Value = TxtPer_TauxConfor.Text;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = TxtCycleTime.Text;
            command.Parameters.Add("@tktct", MySqlDbType.VarChar).Value = TxtPer_TKTCT.Text;
            command.Parameters.Add("@nat", MySqlDbType.VarChar).Value = TxtNomAtelier.Text;
            



            //open the onnection       

            db.openConnection();

            //execute Query
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Données de votre poste est transférée au poste Pilote ");
            }
            else
            {
                MessageBox.Show("Données NON enregistrées");
            }

            //close the connection
            db.closeConnection();

        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
