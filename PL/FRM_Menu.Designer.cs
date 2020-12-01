
namespace PosteTriangle.PL
{
    partial class FRM_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnMinimized = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 625);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(161, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 13);
            this.panel1.TabIndex = 2;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuitter.FlatAppearance.BorderSize = 0;
            this.BtnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitter.Image = global::PosteTriangle.Properties.Resources.Shutdown_32;
            this.BtnQuitter.Location = new System.Drawing.Point(1057, 17);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(40, 29);
            this.BtnQuitter.TabIndex = 3;
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // BtnMinimized
            // 
            this.BtnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimized.FlatAppearance.BorderSize = 0;
            this.BtnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimized.Image = global::PosteTriangle.Properties.Resources.Subtract_32;
            this.BtnMinimized.Location = new System.Drawing.Point(1015, 17);
            this.BtnMinimized.Name = "BtnMinimized";
            this.BtnMinimized.Size = new System.Drawing.Size(40, 29);
            this.BtnMinimized.TabIndex = 4;
            this.BtnMinimized.UseVisualStyleBackColor = true;
            this.BtnMinimized.Click += new System.EventHandler(this.BtnMinimized_Click);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 625);
            this.Controls.Add(this.BtnMinimized);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Menu";
            this.Text = "FRM_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnMinimized;
    }
}