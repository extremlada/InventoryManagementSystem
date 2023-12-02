namespace InventoryManagementSystem
{
    partial class DataBaseLogin
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
            this.Connect = new System.Windows.Forms.Button();
            this.ServerIP = new System.Windows.Forms.TextBox();
            this.Adatbazis_nev = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.TextBox();
            this.Jelszo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(286, 175);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(132, 41);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            // 
            // ServerIP
            // 
            this.ServerIP.Location = new System.Drawing.Point(72, 96);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(100, 20);
            this.ServerIP.TabIndex = 1;
            this.ServerIP.TextChanged += new System.EventHandler(this.ServerIP_TextChanged);
            // 
            // Adatbazis_nev
            // 
            this.Adatbazis_nev.Location = new System.Drawing.Point(227, 96);
            this.Adatbazis_nev.Name = "Adatbazis_nev";
            this.Adatbazis_nev.Size = new System.Drawing.Size(100, 20);
            this.Adatbazis_nev.TabIndex = 2;
            this.Adatbazis_nev.TextChanged += new System.EventHandler(this.Adatbazis_nev_TextChanged);
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(376, 96);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(100, 20);
            this.UserId.TabIndex = 3;
            this.UserId.TextChanged += new System.EventHandler(this.UserId_TextChanged_1);
            // 
            // Jelszo
            // 
            this.Jelszo.Location = new System.Drawing.Point(526, 96);
            this.Jelszo.Name = "Jelszo";
            this.Jelszo.Size = new System.Drawing.Size(100, 20);
            this.Jelszo.TabIndex = 4;
            this.Jelszo.TextChanged += new System.EventHandler(this.Jelszo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ServerIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adatbázis név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jelszó";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(72, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(554, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // DataBaseLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 392);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jelszo);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.Adatbazis_nev);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.Connect);
            this.MaximumSize = new System.Drawing.Size(739, 431);
            this.Name = "DataBaseLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBaseLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox ServerIP;
        private System.Windows.Forms.TextBox Adatbazis_nev;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.TextBox Jelszo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}