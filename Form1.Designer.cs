namespace InventoryManagementSystem
{
    partial class IMS_MainMenu
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
            this.Upload_Button = new System.Windows.Forms.Button();
            this.termek_nev = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.termek_darab = new System.Windows.Forms.Label();
            this.termek_ár = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdatokLekerese = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Editor_Menustrp = new System.Windows.Forms.ToolStripMenuItem();
            this.Lekerdezes_Menustrp = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Upload_Button
            // 
            this.Upload_Button.Location = new System.Drawing.Point(524, 552);
            this.Upload_Button.Name = "Upload_Button";
            this.Upload_Button.Size = new System.Drawing.Size(142, 35);
            this.Upload_Button.TabIndex = 0;
            this.Upload_Button.Text = "Upload";
            this.Upload_Button.UseVisualStyleBackColor = true;
            this.Upload_Button.Visible = false;
            this.Upload_Button.Click += new System.EventHandler(this.Upload_Button_Click);
            // 
            // termek_nev
            // 
            this.termek_nev.AutoSize = true;
            this.termek_nev.Location = new System.Drawing.Point(403, 461);
            this.termek_nev.Name = "termek_nev";
            this.termek_nev.Size = new System.Drawing.Size(43, 13);
            this.termek_nev.TabIndex = 1;
            this.termek_nev.Text = "Termék";
            this.termek_nev.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 476);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(543, 476);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(715, 476);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Visible = false;
            // 
            // termek_darab
            // 
            this.termek_darab.AutoSize = true;
            this.termek_darab.Location = new System.Drawing.Point(574, 460);
            this.termek_darab.Name = "termek_darab";
            this.termek_darab.Size = new System.Drawing.Size(36, 13);
            this.termek_darab.TabIndex = 6;
            this.termek_darab.Text = "Darab";
            this.termek_darab.Visible = false;
            // 
            // termek_ár
            // 
            this.termek_ár.AutoSize = true;
            this.termek_ár.Location = new System.Drawing.Point(758, 461);
            this.termek_ár.Name = "termek_ár";
            this.termek_ár.Size = new System.Drawing.Size(16, 13);
            this.termek_ár.TabIndex = 7;
            this.termek_ár.Text = "ár";
            this.termek_ár.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1190, 388);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdatokLekerese
            // 
            this.AdatokLekerese.Location = new System.Drawing.Point(524, 552);
            this.AdatokLekerese.Name = "AdatokLekerese";
            this.AdatokLekerese.Size = new System.Drawing.Size(142, 35);
            this.AdatokLekerese.TabIndex = 9;
            this.AdatokLekerese.Text = "AdatokLekérése";
            this.AdatokLekerese.UseVisualStyleBackColor = true;
            this.AdatokLekerese.Click += new System.EventHandler(this.AdatokLekerese_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(377, 475);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Editor_Menustrp,
            this.Lekerdezes_Menustrp});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Editor_Menustrp
            // 
            this.Editor_Menustrp.Name = "Editor_Menustrp";
            this.Editor_Menustrp.Size = new System.Drawing.Size(180, 22);
            this.Editor_Menustrp.Text = "Editor";
            this.Editor_Menustrp.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // Lekerdezes_Menustrp
            // 
            this.Lekerdezes_Menustrp.Name = "Lekerdezes_Menustrp";
            this.Lekerdezes_Menustrp.Size = new System.Drawing.Size(180, 22);
            this.Lekerdezes_Menustrp.Text = "Lekérdezés";
            this.Lekerdezes_Menustrp.Click += new System.EventHandler(this.Lekerdezes_Menustrp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Válassz terméket";
            // 
            // IMS_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AdatokLekerese);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.termek_ár);
            this.Controls.Add(this.termek_darab);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.termek_nev);
            this.Controls.Add(this.Upload_Button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "IMS_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload_Button;
        private System.Windows.Forms.Label termek_nev;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label termek_darab;
        private System.Windows.Forms.Label termek_ár;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdatokLekerese;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Editor_Menustrp;
        private System.Windows.Forms.ToolStripMenuItem Lekerdezes_Menustrp;
        private System.Windows.Forms.Label label1;
    }
}

