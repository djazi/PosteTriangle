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
        private int a = 0;
        private int b = 0;
       

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

        private void TxtNomAtelier_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtNomAtelier.Text == "Nom Atelier")
            {
                TxtNomAtelier.Text = "";
                TxtNomAtelier.ForeColor = Color.DarkGray;

            }
        }

        private void TxtNomAtelier_Leave(object sender, EventArgs e)
        {
            if (TxtNomAtelier.Text == "")
            {
                TxtNomAtelier.Text = "Nom Atelier";
                TxtNomAtelier.ForeColor = Color.Silver;
            }
        }

        private void checkBoxPC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //auto_increment pour PC et PNC et stocke 
            int s = Convert.ToInt32(TxtStockEc_Nominale.Text);
            if (s > 0)
            {
                if (checkBoxPC.Checked)
                {
                    a++;
                    TxtP_Conforme.Text = a.ToString();
                    checkBoxPC.Checked = false;
                }
                if (checkBoxPNC.Checked)
                {
                    b++;
                    TxtP_N_Conformes.Text = b.ToString();
                    checkBoxPNC.Checked = false;

                }



                TxtStockEc_Nominale.Text = Convert.ToString(s - 1);
                TxtStock_EC.Text = TxtStockEc_Nominale.Text;

            }
            BL.CDB db = new BL.CDB();
            MySqlCommand command = new MySqlCommand("UPDATE stock_poste SET Striangle=@s WHERE Date=@dt ", db.getConnection());
                  
            // update stock  

            command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
            command.Parameters.Add("@s", MySqlDbType.Int32).Value = TxtStockEc_Nominale.Text;

            //open the onnection       

            db.openConnection();

            //envoie OF a PF
            if (comboBoxPosteSuivant.SelectedItem.Equals("PF"))
            {
                MySqlCommand command_1 = new MySqlCommand("UPDATE stock_poste SET PF=PF+1 WHERE Date=@dt ", db.getConnection());
                command_1.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                command_1.ExecuteNonQuery();


            }
            //envoie OF au poste croix
            if (comboBoxPosteSuivant.SelectedItem.Equals("Croix"))
            {
                MySqlCommand command_2 = new MySqlCommand("UPDATE stock_poste SET Scroix=Scroix+1 WHERE Date=@dt ", db.getConnection());
                command_2.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                command_2.ExecuteNonQuery();


            }
            //envoie OF au poste vague
            if (comboBoxPosteSuivant.SelectedItem.Equals("Vague"))
            {
                MySqlCommand command_3 = new MySqlCommand("UPDATE stock_poste SET Svague=Svague+1 WHERE Date=@dt ", db.getConnection());
                command_3.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                command_3.ExecuteNonQuery();


            }
            //envoie OF au poste Etoile
            if (comboBoxPosteSuivant.SelectedItem.Equals("Etoile"))
            {
                MySqlCommand command_4 = new MySqlCommand("UPDATE stock_poste SET Setoile=Setoile+1 WHERE Date=@dt ", db.getConnection());
                command_4.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                command_4.ExecuteNonQuery();


            }

            //envoie OF au poste Ovale
            if (comboBoxPosteSuivant.SelectedItem.Equals("Ovale"))
            {
                MySqlCommand command_5 = new MySqlCommand("UPDATE stock_poste SET Sovale=Sovale+1 WHERE Date=@dt ", db.getConnection());
                command_5.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                command_5.ExecuteNonQuery();


            }
            //envoie OF au poste Rect
            if (comboBoxPosteSuivant.SelectedItem.Equals("Rect"))
            {
                MySqlCommand command_6 = new MySqlCommand("UPDATE stock_poste SET Srect=Srect+1 WHERE Date=@dt ", db.getConnection());
                command_6.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                command_6.ExecuteNonQuery();


            }
            //envoie OF au poste Triangle
            if (comboBoxPosteSuivant.SelectedItem.Equals("Triangle"))
            {
                MySqlCommand command_7 = new MySqlCommand("UPDATE stock_poste SET Striangle=Striangle+1 WHERE Date=@dt ", db.getConnection());
                command_7.Parameters.Add("@dt", MySqlDbType.VarChar).Value = TxtDate.Text;
                command_7.ExecuteNonQuery();


            }







            //execute Query
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("sortie de produit");
            }
            else
            {
                MessageBox.Show("erreur lors sortie de produit ");
            }

            //close the connection
            db.closeConnection();







        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNomAtelier.Text = "Triangle";
            TxtEffectif.Text = Convert.ToString(1);
            TxtTKT_Time.Text = Convert.ToString(16);

            BL.CDB db = new BL.CDB();
            db.openConnection();

            // a modifer pour chaque Poste 

            MySqlDataAdapter asdf = new MySqlDataAdapter("SELECT * from stock_poste WHERE Date = '" + TxtDate.Text + "'", db.getConnection());
            DataTable ss = new DataTable();
            asdf.Fill(ss);
            TxtStockEc_Nominale.Text = ss.Rows[0][5].ToString();
            





            //close the connection
            db.closeConnection();



        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnFermeture_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPosteSuivant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            TxtNomAtelier.Text = "Nom Atelier";
            TxtDate.Text = "Date";
            TxtStockEc_Nominale.Text = "Stock en Cours*";
            TxtP_N_Conformes.Text = "Piéces Non Conformes";
            TxtP_Conforme.Text = "Piéces Conformes";
            TxtH_Debut.Text = "Heure Début";
            TxtEffectif.Text = "Effectif";
            TxtH_Fin.Text = "Heure de Fin ";
            TxtStock_EC.Text = "Stock en Cours";
            TxtTKT_Time.Text = "Takt time";
            comboBoxPosteSuivant.Text = "Poste Suivant";
        }
    }
}
