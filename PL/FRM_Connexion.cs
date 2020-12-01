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
    public partial class FRM_Connexion : Form
    {
        public FRM_Connexion()
        {
            InitializeComponent();
        }

        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void BtnQuitterConnexion_Click(object sender, EventArgs e)
        {
            //Quitter la formulaire 
            this.Close();
        }

        private void Txt_N_Utilisateur_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if(Txt_N_Utilisateur.Text== "Nom d'utilisateur ")
            {
                Txt_N_Utilisateur.Text = "";
                Txt_N_Utilisateur.ForeColor = Color.WhiteSmoke;



            }
        }

        private void TxtMdp_Enter(object sender, EventArgs e)
        {
            //Pour vider le textBox
            if (TxtMdp.Text == "Mot de Passe")
            {
                TxtMdp.Text = "";
                TxtMdp.ForeColor = Color.WhiteSmoke;



            }
        }

        private void Txt_N_Utilisateur_Leave(object sender, EventArgs e)
        {
            if(Txt_N_Utilisateur.Text=="")
            {
                Txt_N_Utilisateur.Text = "Nom d'utilisateur ";
                Txt_N_Utilisateur.ForeColor = Color.Silver;
            }
        }

        private void TxtMdp_Leave(object sender, EventArgs e)
        {
            if (TxtMdp.Text == "")
            {
                TxtMdp.Text = "Mot de Passe";
                TxtMdp.ForeColor = Color.Silver;
            }









        }

        private void BtnSe_Connecter_Click(object sender, EventArgs e)
        {
            BL.CDB db = new BL.CDB();

            String usr = Txt_N_Utilisateur.Text;
            String pwd = TxtMdp.Text;


            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Username`=@usn AND `Password`=@pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usr;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pwd;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if the user exists or not 
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("NO");
            }




        }
    }
}
