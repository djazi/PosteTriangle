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

        private void btnStock_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CDB db = new BL.CDB();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM stock_poste", db.getConnection());
                db.openConnection();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "stock_poste");
                dataGridViewStock.DataSource = ds.Tables["stock_poste"];

                db.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CDB db = new BL.CDB();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM saisie_poste", db.getConnection());
                db.openConnection();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "saisie_poste");
                dataGridViewStock.DataSource = ds.Tables["saisie_poste"];

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CDB db = new BL.CDB();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM affichage_poste", db.getConnection());
                db.openConnection();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "affichage_poste");
                dataGridViewStock.DataSource = ds.Tables["affichage_poste"];

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
