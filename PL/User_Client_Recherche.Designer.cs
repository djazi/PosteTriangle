
namespace PosteTriangle.PL
{
    partial class User_Client_Recherche
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnPerform = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(23, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 3);
            this.panel1.TabIndex = 20;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStock.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewStock.Location = new System.Drawing.Point(3, 74);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(923, 470);
            this.dataGridViewStock.TabIndex = 24;
            // 
            // btnStock
            // 
            this.btnStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStock.Image = global::PosteTriangle.Properties.Resources.packages;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(23, 556);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(244, 55);
            this.btnStock.TabIndex = 23;
            this.btnStock.Text = "       Stock Poste";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnPerform
            // 
            this.btnPerform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnPerform.FlatAppearance.BorderSize = 0;
            this.btnPerform.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnPerform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerform.Image = global::PosteTriangle.Properties.Resources.speedometer1;
            this.btnPerform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerform.Location = new System.Drawing.Point(664, 556);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(244, 55);
            this.btnPerform.TabIndex = 22;
            this.btnPerform.Text = "       Performance";
            this.btnPerform.UseVisualStyleBackColor = false;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // btnProd
            // 
            this.btnProd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProd.Image = global::PosteTriangle.Properties.Resources.production;
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProd.Location = new System.Drawing.Point(338, 556);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(244, 55);
            this.btnProd.TabIndex = 19;
            this.btnProd.Text = "       Production";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(285, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tables des Données";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // User_Client_Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStock);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProd);
            this.Name = "User_Client_Recherche";
            this.Size = new System.Drawing.Size(929, 625);
            this.Load += new System.EventHandler(this.User_Client_Recherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Label label1;
    }
}
