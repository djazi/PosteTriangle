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
        //Creer un instance pour le usercontrole 
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

        private void TxtidAtelier_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtidAtelier.Text == "ID Atelier")
            {
                TxtidAtelier.Text = "";
                TxtidAtelier.ForeColor = Color.DarkGray;



            }
        }

        private void TxtidAtelier_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtidAtelier_Leave(object sender, EventArgs e)
        {
            if (TxtidAtelier.Text == "")
            {
                TxtidAtelier.Text = "ID Atelier";
                TxtidAtelier.ForeColor = Color.Silver;
            }
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

        private void TxtCycle_Time_Nominale_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtCycle_Time_Nominale.Text == "Cycle Time*")
            {
                TxtCycle_Time_Nominale.Text = "";
                TxtCycle_Time_Nominale.ForeColor = Color.DarkGray;



            }

        }

        private void TxtCycle_Time_Nominale_Leave(object sender, EventArgs e)
        {
            if (TxtCycle_Time_Nominale.Text == "")
            {
                TxtCycle_Time_Nominale.Text = "Cycle Time*";
                TxtCycle_Time_Nominale.ForeColor = Color.Silver;
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

        private void TxtLead_Time_Nominal_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtLead_Time_Nominal.Text == "Lead Time *")
            {
                TxtLead_Time_Nominal.Text = "";
                TxtLead_Time_Nominal.ForeColor = Color.DarkGray;

            }
        }

        private void TxtLead_Time_Nominal_Leave(object sender, EventArgs e)
        {
            if (TxtLead_Time_Nominal.Text == "")
            {
                TxtLead_Time_Nominal.Text = "Lead Time *";
                TxtLead_Time_Nominal.ForeColor = Color.Silver;
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

        private void TxtHeure_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtHeure.Text == "Heure")
            {
                TxtHeure.Text = "";
                TxtHeure.ForeColor = Color.DarkGray;

            }
        }

        private void TxtHeure_Leave(object sender, EventArgs e)
        {
            if (TxtHeure.Text == "")
            {
                TxtHeure.Text = "Heure";
                TxtHeure.ForeColor = Color.Silver;
            }
        }

        private void Btn_Sauvegarder_Click(object sender, EventArgs e)
        {
            BL.CDB db = new BL.CDB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `production`(`Id_Atelier`, `Date`, `Heure`, `Stock_Ec`, `P_Conforme`, `P_Non_Coforme`, `Stock_Nominale`, `Cycle_Time`) VALUES (@idA, @date, @heure, @Sec, @PC, @PNc, @Secn, @CT)", db.getConnection());

            // fill table production 
            command.Parameters.Add("@idA", MySqlDbType.VarChar).Value = TxtidAtelier.Text;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = TxtDate.Text;
            command.Parameters.Add("@heure", MySqlDbType.VarChar).Value = TxtHeure.Text;
            command.Parameters.Add("@Sec", MySqlDbType.VarChar).Value = TxtStock_EC.Text;
            command.Parameters.Add("@PC", MySqlDbType.VarChar).Value = TxtP_Conforme.Text;
            command.Parameters.Add("@PNc", MySqlDbType.VarChar).Value = TxtP_N_Conformes.Text;
            command.Parameters.Add("@Secn", MySqlDbType.VarChar).Value = TxtStockEc_Nominale.Text;
            command.Parameters.Add("@CT", MySqlDbType.VarChar).Value = TxtCycle_Time_Nominale.Text;

            // fill table atelier



            MySqlCommand command_1 = new MySqlCommand("INSERT INTO `atelier`(`Id`, `Nom_Atelier`, `TKT`, `Stock_Ec`, `Effectif`) VALUES (@idAT, @NomAtelier, @TKT, @STEC, @Effct)", db.getConnection());
            command_1.Parameters.Add("@idAT", MySqlDbType.VarChar).Value = TxtidAtelier.Text;
            command_1.Parameters.Add("@NomAtelier", MySqlDbType.VarChar).Value = "Triangle";
            command_1.Parameters.Add("@TKT", MySqlDbType.VarChar).Value = TxtTKT_Time.Text;
            command_1.Parameters.Add("@STEC", MySqlDbType.VarChar).Value = TxtStockEc_Nominale.Text;
            command_1.Parameters.Add("@Effct", MySqlDbType.VarChar).Value = TxtEffectif.Text;

            // fill table lead_time

            MySqlCommand command_2 = new MySqlCommand("INSERT INTO `lt_time`(`Id_Atelier`, `H_debut`, `H_fin`) VALUES (@idAte, @Hd, @Hf)", db.getConnection());
            command_2.Parameters.Add("@idAte", MySqlDbType.VarChar).Value = TxtidAtelier.Text;
            command_2.Parameters.Add("@Hd", MySqlDbType.VarChar).Value = TxtH_Debut.Text;
            command_2.Parameters.Add("@Hf", MySqlDbType.VarChar).Value = TxtH_Fin.Text;



            //open the onnection       

            db.openConnection();

            //execute Query
            if(command.ExecuteNonQuery() == 1 & command_1.ExecuteNonQuery() == 1 & command_2.ExecuteNonQuery() == 1 )
            {
                MessageBox.Show("Données enregistrées");
            }
            else
            {
                MessageBox.Show("Données NON enregistrées");
            }

            //close the connection
            db.closeConnection();

            














        }
    }
}
