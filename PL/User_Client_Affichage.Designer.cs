
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
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtCycleTime = new System.Windows.Forms.TextBox();
            this.TxtQteProduite = new System.Windows.Forms.TextBox();
            this.TxtNomAtelier = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSuvegarderp = new System.Windows.Forms.Button();
            this.Btn_Performance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.TxtPer_TKTCT.Location = new System.Drawing.Point(26, 224);
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
            this.TxtPer_TauxConfor.Location = new System.Drawing.Point(245, 224);
            this.TxtPer_TauxConfor.Multiline = true;
            this.TxtPer_TauxConfor.Name = "TxtPer_TauxConfor";
            this.TxtPer_TauxConfor.Size = new System.Drawing.Size(180, 29);
            this.TxtPer_TauxConfor.TabIndex = 4;
            this.TxtPer_TauxConfor.Text = "Taux Conformité";
            this.TxtPer_TauxConfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtPer_TRG
            // 
            this.TxtPer_TRG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtPer_TRG.BackColor = System.Drawing.Color.LightCyan;
            this.TxtPer_TRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPer_TRG.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPer_TRG.ForeColor = System.Drawing.Color.Gray;
            this.TxtPer_TRG.Location = new System.Drawing.Point(531, 224);
            this.TxtPer_TRG.Multiline = true;
            this.TxtPer_TRG.Name = "TxtPer_TRG";
            this.TxtPer_TRG.Size = new System.Drawing.Size(76, 29);
            this.TxtPer_TRG.TabIndex = 5;
            this.TxtPer_TRG.Text = "TRG ";
            this.TxtPer_TRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtPer_StockEC_Atelier
            // 
            this.TxtPer_StockEC_Atelier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPer_StockEC_Atelier.BackColor = System.Drawing.Color.LightCyan;
            this.TxtPer_StockEC_Atelier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPer_StockEC_Atelier.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPer_StockEC_Atelier.ForeColor = System.Drawing.Color.Gray;
            this.TxtPer_StockEC_Atelier.Location = new System.Drawing.Point(713, 223);
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
            this.label1.Location = new System.Drawing.Point(203, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Indicateur de Perfomance KPI ";
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
            this.TxtCycleTime.Location = new System.Drawing.Point(37, 158);
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
            this.TxtQteProduite.Location = new System.Drawing.Point(702, 158);
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
            this.TxtNomAtelier.Location = new System.Drawing.Point(399, 158);
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
            this.TxtDate.Location = new System.Drawing.Point(26, 70);
            this.TxtDate.Multiline = true;
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(152, 29);
            this.TxtDate.TabIndex = 13;
            this.TxtDate.Text = "Date";
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDate.Enter += new System.EventHandler(this.TxtDate_Enter);
            this.TxtDate.Leave += new System.EventHandler(this.TxtDate_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PosteTriangle.Properties.Resources.percentage1;
            this.button1.Location = new System.Drawing.Point(613, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 38);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnSuvegarderp
            // 
            this.BtnSuvegarderp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSuvegarderp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnSuvegarderp.FlatAppearance.BorderSize = 0;
            this.BtnSuvegarderp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnSuvegarderp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuvegarderp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuvegarderp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSuvegarderp.Image = global::PosteTriangle.Properties.Resources.Actions_list_add_icon;
            this.BtnSuvegarderp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSuvegarderp.Location = new System.Drawing.Point(667, 554);
            this.BtnSuvegarderp.Name = "BtnSuvegarderp";
            this.BtnSuvegarderp.Size = new System.Drawing.Size(244, 55);
            this.BtnSuvegarderp.TabIndex = 15;
            this.BtnSuvegarderp.Text = "      Sauvegarder";
            this.BtnSuvegarderp.UseVisualStyleBackColor = false;
            this.BtnSuvegarderp.Click += new System.EventHandler(this.BtnSuvegarderp_Click);
            // 
            // Btn_Performance
            // 
            this.Btn_Performance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Performance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Performance.FlatAppearance.BorderSize = 0;
            this.Btn_Performance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Btn_Performance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Performance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Performance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Performance.Image = global::PosteTriangle.Properties.Resources.kpi45;
            this.Btn_Performance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Performance.Location = new System.Drawing.Point(20, 554);
            this.Btn_Performance.Name = "Btn_Performance";
            this.Btn_Performance.Size = new System.Drawing.Size(244, 55);
            this.Btn_Performance.TabIndex = 14;
            this.Btn_Performance.Text = "      Performance";
            this.Btn_Performance.UseVisualStyleBackColor = false;
            this.Btn_Performance.Click += new System.EventHandler(this.Btn_Performance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PosteTriangle.Properties.Resources.caution;
            this.pictureBox1.Location = new System.Drawing.Point(751, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 39);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::PosteTriangle.Properties.Resources.percentage1;
            this.button2.Location = new System.Drawing.Point(431, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 38);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // User_Client_Affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSuvegarderp);
            this.Controls.Add(this.Btn_Performance);
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
        private System.Windows.Forms.Button Btn_Performance;
        private System.Windows.Forms.Button BtnSuvegarderp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
