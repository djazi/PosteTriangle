
namespace PosteTriangle.PL
{
    partial class User_Client_Affichage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtPer_TKTCT = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtPer_TauxConfor = new System.Windows.Forms.TextBox();
            this.TxtPer_TRG = new System.Windows.Forms.TextBox();
            this.TxtPer_StockEC_Atelier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtCycleTime = new System.Windows.Forms.TextBox();
            this.TxtQteProduite = new System.Windows.Forms.TextBox();
            this.TxtNomAtelier = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(3, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 3);
            this.panel2.TabIndex = 1;
            // 
            // TxtPer_TKTCT
            // 
            this.TxtPer_TKTCT.BackColor = System.Drawing.Color.LightCyan;
            this.TxtPer_TKTCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPer_TKTCT.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPer_TKTCT.ForeColor = System.Drawing.Color.Gray;
            this.TxtPer_TKTCT.Location = new System.Drawing.Point(26, 218);
            this.TxtPer_TKTCT.Multiline = true;
            this.TxtPer_TKTCT.Name = "TxtPer_TKTCT";
            this.TxtPer_TKTCT.Size = new System.Drawing.Size(152, 29);
            this.TxtPer_TKTCT.TabIndex = 2;
            this.TxtPer_TKTCT.Text = "TKT VS C/T";
            this.TxtPer_TKTCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPer_TKTCT.Enter += new System.EventHandler(this.TxtPer_LT_Enter);
            this.TxtPer_TKTCT.Leave += new System.EventHandler(this.TxtPer_LT_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtPer_TauxConfor
            // 
            this.TxtPer_TauxConfor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtPer_TauxConfor.BackColor = System.Drawing.Color.LightCyan;
            this.TxtPer_TauxConfor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPer_TauxConfor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPer_TauxConfor.ForeColor = System.Drawing.Color.Gray;
            this.TxtPer_TauxConfor.Location = new System.Drawing.Point(225, 218);
            this.TxtPer_TauxConfor.Multiline = true;
            this.TxtPer_TauxConfor.Name = "TxtPer_TauxConfor";
            this.TxtPer_TauxConfor.Size = new System.Drawing.Size(201, 29);
            this.TxtPer_TauxConfor.TabIndex = 4;
            this.TxtPer_TauxConfor.Text = "Taux Conformité";
            this.TxtPer_TauxConfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPer_TRG
            // 
            this.TxtPer_TRG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtPer_TRG.BackColor = System.Drawing.Color.LightCyan;
            this.TxtPer_TRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPer_TRG.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPer_TRG.ForeColor = System.Drawing.Color.Gray;
            this.TxtPer_TRG.Location = new System.Drawing.Point(470, 218);
            this.TxtPer_TRG.Multiline = true;
            this.TxtPer_TRG.Name = "TxtPer_TRG";
            this.TxtPer_TRG.Size = new System.Drawing.Size(185, 29);
            this.TxtPer_TRG.TabIndex = 5;
            this.TxtPer_TRG.Text = "TRG ";
            this.TxtPer_TRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPer_StockEC_Atelier
            // 
            this.TxtPer_StockEC_Atelier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPer_StockEC_Atelier.BackColor = System.Drawing.Color.LightCyan;
            this.TxtPer_StockEC_Atelier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPer_StockEC_Atelier.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPer_StockEC_Atelier.ForeColor = System.Drawing.Color.Gray;
            this.TxtPer_StockEC_Atelier.Location = new System.Drawing.Point(713, 218);
            this.TxtPer_StockEC_Atelier.Multiline = true;
            this.TxtPer_StockEC_Atelier.Name = "TxtPer_StockEC_Atelier";
            this.TxtPer_StockEC_Atelier.Size = new System.Drawing.Size(190, 29);
            this.TxtPer_StockEC_Atelier.TabIndex = 6;
            this.TxtPer_StockEC_Atelier.Text = "Stock en Cours ";
            this.TxtPer_StockEC_Atelier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(203, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Indicateur de Perfomance KPI ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PosteTriangle.Properties.Resources.caution;
            this.pictureBox1.Location = new System.Drawing.Point(751, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 39);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(3, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 3);
            this.panel3.TabIndex = 9;
            // 
            // TxtCycleTime
            // 
            this.TxtCycleTime.BackColor = System.Drawing.Color.LightCyan;
            this.TxtCycleTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCycleTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCycleTime.ForeColor = System.Drawing.Color.Gray;
            this.TxtCycleTime.Location = new System.Drawing.Point(37, 154);
            this.TxtCycleTime.Multiline = true;
            this.TxtCycleTime.Name = "TxtCycleTime";
            this.TxtCycleTime.Size = new System.Drawing.Size(152, 29);
            this.TxtCycleTime.TabIndex = 10;
            this.TxtCycleTime.Text = "Cycle Time";
            this.TxtCycleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtQteProduite
            // 
            this.TxtQteProduite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQteProduite.BackColor = System.Drawing.Color.LightCyan;
            this.TxtQteProduite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtQteProduite.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQteProduite.ForeColor = System.Drawing.Color.Gray;
            this.TxtQteProduite.Location = new System.Drawing.Point(702, 154);
            this.TxtQteProduite.Multiline = true;
            this.TxtQteProduite.Name = "TxtQteProduite";
            this.TxtQteProduite.Size = new System.Drawing.Size(209, 29);
            this.TxtQteProduite.TabIndex = 11;
            this.TxtQteProduite.Text = "Quantité Produite";
            this.TxtQteProduite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNomAtelier
            // 
            this.TxtNomAtelier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNomAtelier.BackColor = System.Drawing.Color.LightCyan;
            this.TxtNomAtelier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNomAtelier.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomAtelier.ForeColor = System.Drawing.Color.Gray;
            this.TxtNomAtelier.Location = new System.Drawing.Point(401, 154);
            this.TxtNomAtelier.Multiline = true;
            this.TxtNomAtelier.Name = "TxtNomAtelier";
            this.TxtNomAtelier.Size = new System.Drawing.Size(152, 29);
            this.TxtNomAtelier.TabIndex = 12;
            this.TxtNomAtelier.Text = "Nom Atelier";
            this.TxtNomAtelier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDate
            // 
            this.TxtDate.BackColor = System.Drawing.Color.LightCyan;
            this.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.ForeColor = System.Drawing.Color.Gray;
            this.TxtDate.Location = new System.Drawing.Point(26, 64);
            this.TxtDate.Multiline = true;
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(152, 29);
            this.TxtDate.TabIndex = 13;
            this.TxtDate.Text = "Date";
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User_Client_Affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtNomAtelier);
            this.Controls.Add(this.TxtQteProduite);
            this.Controls.Add(this.TxtCycleTime);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPer_StockEC_Atelier);
            this.Controls.Add(this.TxtPer_TRG);
            this.Controls.Add(this.TxtPer_TauxConfor);
            this.Controls.Add(this.TxtPer_TKTCT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User_Client_Affichage";
            this.Size = new System.Drawing.Size(929, 625);
            this.Load += new System.EventHandler(this.User_Client_Affichage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtPer_TKTCT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TxtPer_TauxConfor;
        private System.Windows.Forms.TextBox TxtPer_TRG;
        private System.Windows.Forms.TextBox TxtPer_StockEC_Atelier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtCycleTime;
        private System.Windows.Forms.TextBox TxtQteProduite;
        private System.Windows.Forms.TextBox TxtNomAtelier;
        private System.Windows.Forms.TextBox TxtDate;
    }
}
