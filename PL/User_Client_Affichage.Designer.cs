
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.labelCT = new System.Windows.Forms.Label();
            this.labelTrg = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelTKTCT = new System.Windows.Forms.Label();
            this.labelQt = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSuvegarderp = new System.Windows.Forms.Button();
            this.Btn_Performance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solidGaugeTC = new LiveCharts.WinForms.SolidGauge();
            this.solidGaugeTRG = new LiveCharts.WinForms.SolidGauge();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // labelCT
            // 
            this.labelCT.AutoSize = true;
            this.labelCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCT.ForeColor = System.Drawing.Color.Gray;
            this.labelCT.Location = new System.Drawing.Point(93, 130);
            this.labelCT.Name = "labelCT";
            this.labelCT.Size = new System.Drawing.Size(40, 25);
            this.labelCT.TabIndex = 18;
            this.labelCT.Text = "CT";
            this.labelCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTrg
            // 
            this.labelTrg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTrg.AutoSize = true;
            this.labelTrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrg.ForeColor = System.Drawing.Color.Gray;
            this.labelTrg.Location = new System.Drawing.Point(551, 195);
            this.labelTrg.Name = "labelTrg";
            this.labelTrg.Size = new System.Drawing.Size(56, 25);
            this.labelTrg.TabIndex = 19;
            this.labelTrg.Text = "TRG";
            this.labelTrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTC
            // 
            this.labelTC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTC.ForeColor = System.Drawing.Color.Gray;
            this.labelTC.Location = new System.Drawing.Point(379, 195);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(46, 25);
            this.labelTC.TabIndex = 20;
            this.labelTC.Text = "%C";
            this.labelTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTKTCT
            // 
            this.labelTKTCT.AutoSize = true;
            this.labelTKTCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTKTCT.ForeColor = System.Drawing.Color.Gray;
            this.labelTKTCT.Location = new System.Drawing.Point(53, 195);
            this.labelTKTCT.Name = "labelTKTCT";
            this.labelTKTCT.Size = new System.Drawing.Size(102, 25);
            this.labelTKTCT.TabIndex = 21;
            this.labelTKTCT.Text = "TKTvsCT";
            this.labelTKTCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQt
            // 
            this.labelQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQt.AutoSize = true;
            this.labelQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQt.ForeColor = System.Drawing.Color.Gray;
            this.labelQt.Location = new System.Drawing.Point(791, 130);
            this.labelQt.Name = "labelQt";
            this.labelQt.Size = new System.Drawing.Size(41, 25);
            this.labelQt.TabIndex = 22;
            this.labelQt.Text = "QT";
            this.labelQt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSec
            // 
            this.labelSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.ForeColor = System.Drawing.Color.Gray;
            this.labelSec.Location = new System.Drawing.Point(777, 195);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(55, 25);
            this.labelSec.TabIndex = 23;
            this.labelSec.Text = "SEC";
            this.labelSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::PosteTriangle.Properties.Resources.positive_vote;
            this.button3.Location = new System.Drawing.Point(184, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 37);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::PosteTriangle.Properties.Resources.bad_review;
            this.button4.Location = new System.Drawing.Point(184, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 37);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.LightCyan;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::PosteTriangle.Properties.Resources.bad_review;
            this.button5.Location = new System.Drawing.Point(470, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 37);
            this.button5.TabIndex = 27;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.Color.LightCyan;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = global::PosteTriangle.Properties.Resources.positive_vote;
            this.button6.Location = new System.Drawing.Point(470, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 37);
            this.button6.TabIndex = 26;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.BackColor = System.Drawing.Color.LightCyan;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Image = global::PosteTriangle.Properties.Resources.bad_review;
            this.button7.Location = new System.Drawing.Point(667, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 37);
            this.button7.TabIndex = 29;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button8.BackColor = System.Drawing.Color.LightCyan;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Image = global::PosteTriangle.Properties.Resources.positive_vote;
            this.button8.Location = new System.Drawing.Point(664, 213);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 37);
            this.button8.TabIndex = 28;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.LightCyan;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Image = global::PosteTriangle.Properties.Resources.bad_review;
            this.button9.Location = new System.Drawing.Point(887, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 37);
            this.button9.TabIndex = 31;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.LightCyan;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Image = global::PosteTriangle.Properties.Resources.positive_vote;
            this.button10.Location = new System.Drawing.Point(890, 210);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 37);
            this.button10.TabIndex = 30;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(516, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "TRG";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(735, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Taux Conformité";
            // 
            // solidGaugeTC
            // 
            this.solidGaugeTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.solidGaugeTC.ForeColor = System.Drawing.Color.LightCyan;
            this.solidGaugeTC.Location = new System.Drawing.Point(713, 262);
            this.solidGaugeTC.Name = "solidGaugeTC";
            this.solidGaugeTC.Size = new System.Drawing.Size(200, 142);
            this.solidGaugeTC.TabIndex = 44;
            this.solidGaugeTC.Text = "solidGaugeTRG";
            // 
            // solidGaugeTRG
            // 
            this.solidGaugeTRG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.solidGaugeTRG.ForeColor = System.Drawing.Color.LightCyan;
            this.solidGaugeTRG.Location = new System.Drawing.Point(447, 262);
            this.solidGaugeTRG.Name = "solidGaugeTRG";
            this.solidGaugeTRG.Size = new System.Drawing.Size(200, 142);
            this.solidGaugeTRG.TabIndex = 47;
            this.solidGaugeTRG.Text = "solidGaugeTRG";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 262);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(443, 276);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "chart1";
            // 
            // User_Client_Affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.solidGaugeTRG);
            this.Controls.Add(this.solidGaugeTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelQt);
            this.Controls.Add(this.labelTKTCT);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.labelTrg);
            this.Controls.Add(this.labelCT);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Label labelCT;
        private System.Windows.Forms.Label labelTrg;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelTKTCT;
        private System.Windows.Forms.Label labelQt;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.SolidGauge solidGaugeTC;
        private LiveCharts.WinForms.SolidGauge solidGaugeTRG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
