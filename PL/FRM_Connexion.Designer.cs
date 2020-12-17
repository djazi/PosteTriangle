
namespace PosteTriangle.PL
{
    partial class FRM_Connexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Connexion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnQuitterConnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_N_Utilisateur = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtMdp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnSe_Connecter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 376);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(316, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 376);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 3);
            this.panel4.TabIndex = 3;
            // 
            // BtnQuitterConnexion
            // 
            this.BtnQuitterConnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuitterConnexion.FlatAppearance.BorderSize = 0;
            this.BtnQuitterConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitterConnexion.Image = global::PosteTriangle.Properties.Resources.Button_Delete_icon;
            this.BtnQuitterConnexion.Location = new System.Drawing.Point(272, 7);
            this.BtnQuitterConnexion.Name = "BtnQuitterConnexion";
            this.BtnQuitterConnexion.Size = new System.Drawing.Size(39, 37);
            this.BtnQuitterConnexion.TabIndex = 4;
            this.BtnQuitterConnexion.UseVisualStyleBackColor = true;
            this.BtnQuitterConnexion.Click += new System.EventHandler(this.BtnQuitterConnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connexion";
            // 
            // Txt_N_Utilisateur
            // 
            this.Txt_N_Utilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Txt_N_Utilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_N_Utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_N_Utilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_N_Utilisateur.Location = new System.Drawing.Point(53, 134);
            this.Txt_N_Utilisateur.Multiline = true;
            this.Txt_N_Utilisateur.Name = "Txt_N_Utilisateur";
            this.Txt_N_Utilisateur.Size = new System.Drawing.Size(249, 33);
            this.Txt_N_Utilisateur.TabIndex = 6;
            this.Txt_N_Utilisateur.Text = "Nom d\'utilisateur ";
            this.Txt_N_Utilisateur.Enter += new System.EventHandler(this.Txt_N_Utilisateur_Enter);
            this.Txt_N_Utilisateur.Leave += new System.EventHandler(this.Txt_N_Utilisateur_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(53, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 1);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(53, 266);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 1);
            this.panel6.TabIndex = 9;
            // 
            // TxtMdp
            // 
            this.TxtMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.TxtMdp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtMdp.Location = new System.Drawing.Point(53, 231);
            this.TxtMdp.Multiline = true;
            this.TxtMdp.Name = "TxtMdp";
            this.TxtMdp.Size = new System.Drawing.Size(249, 33);
            this.TxtMdp.TabIndex = 8;
            this.TxtMdp.Text = "Mot de Passe";
            this.TxtMdp.Enter += new System.EventHandler(this.TxtMdp_Enter);
            this.TxtMdp.Leave += new System.EventHandler(this.TxtMdp_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PosteTriangle.Properties.Resources.login_32;
            this.pictureBox1.Location = new System.Drawing.Point(14, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PosteTriangle.Properties.Resources.Motdepasse_32;
            this.pictureBox2.Location = new System.Drawing.Point(14, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // BtnSe_Connecter
            // 
            this.BtnSe_Connecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnSe_Connecter.FlatAppearance.BorderSize = 0;
            this.BtnSe_Connecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSe_Connecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSe_Connecter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSe_Connecter.Location = new System.Drawing.Point(31, 303);
            this.BtnSe_Connecter.Name = "BtnSe_Connecter";
            this.BtnSe_Connecter.Size = new System.Drawing.Size(249, 40);
            this.BtnSe_Connecter.TabIndex = 12;
            this.BtnSe_Connecter.Text = "Se Connecter";
            this.BtnSe_Connecter.UseVisualStyleBackColor = false;
            this.BtnSe_Connecter.Click += new System.EventHandler(this.BtnSe_Connecter_Click);
            // 
            // FRM_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(319, 379);
            this.Controls.Add(this.BtnSe_Connecter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TxtMdp);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Txt_N_Utilisateur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQuitterConnexion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Connexion";
            this.Load += new System.EventHandler(this.FRM_Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnQuitterConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_N_Utilisateur;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TxtMdp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnSe_Connecter;
    }
}