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
        private Form frmmenu;

        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmmenu = Menu;
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
                TxtMdp.UseSystemPasswordChar = false;
                TxtMdp.PasswordChar = '*';
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
                TxtMdp.UseSystemPasswordChar = true;

                TxtMdp.ForeColor = Color.Silver;
            }









        }
        //this apps made by khalid djazi et ouissal allam soufiane halloumi please don't change this comment or delete it and don't change the names in the menu forms 
        //you can add change add delete upgrade this app for better performance for the user experience FOR IMS promo 2021
        //contact me khalid djazi by my mail adress khalid.djazi@esith.net 

        private void BtnSe_Connecter_Click(object sender, EventArgs e)
        {
            BL.CDB db = new BL.CDB();

            String usr = Txt_N_Utilisateur.Text;
            String pwd = TxtMdp.Text;


            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user_info` WHERE `Username`=@usn AND `Password`=@pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usr;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pwd;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if the user exists or not 
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Connexion a réussi","Connexion",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                (frmmenu as FRM_Menu).activerForm();
                this.Close(); //quitter formulaire de connexion
            }
            else
            {
                MessageBox.Show("Connexion a échoué verifier votre Nom d'utilisateur ou votre mot de passe", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
