using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem
{
    public partial class IMS_MainMenu : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public IMS_MainMenu()
        {
            server = "localhost";
            database = "raktar";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};convert zero datetime=True";

            conn = new MySqlConnection(connString);
    

            InitializeComponent();
            PopulateComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Upload_Button_Click(object sender, EventArgs e)
        {
            string termek_nev = textBox1.Text;
            string termek_ar = textBox3.Text;
            string darab_szam = textBox2.Text;

            MessageBox.Show(termek_nev + " " + darab_szam + " db " + termek_ar + "Ft");

            if (termek(termek_nev))
            {
                MessageBox.Show("minden fel lett töltve");
            }
            else
            {
                MessageBox.Show("Valami rosszul lett be írva");
            }


            if (termek_mozgas(darab_szam, termek_ar))
            {
                MessageBox.Show("minden is fel lett töltve");
            }
            else
            {
                MessageBox.Show("valami rosszul lett be víve");
            }
            
        }

        public bool termek (string termek_nev)
        {
            {
                // Check if the item already exists
                string checkQuery = "SELECT COUNT(*) FROM termek WHERE termek_nev = @termek_nev;";
                int count = 0;

                try
                {
                    if (OpenConnection())
                    {
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@termek_nev", termek_nev);
                            count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        }
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return false;
                }

                // If the item already exists, return false
                if (count > 0)
                {
;                  
                }                
                
                // If the item doesn't exist, perform the INSERT
                string insertQuery = "INSERT INTO termek (termek_nev) VALUES (@termek_nev);";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@termek_nev", termek_nev);

                        try
                        {
                            cmd.ExecuteNonQuery();

                            string getTermekIdQuery = "SELECT termek_id FROM termek WHERE termek_nev = @termek_nev;";
                            MySqlCommand getTermekIdCmd = new MySqlCommand(getTermekIdQuery, conn);
                            getTermekIdCmd.Parameters.AddWithValue("@termek_nev", termek_nev);
                            int termekId = Convert.ToInt32(getTermekIdCmd.ExecuteScalar());

                            string forwardToTermekMozgasQuery = "INSERT INTO termek_mozgas (termek_id) VALUES (@termek_id);";
                            MySqlCommand forwardCmd = new MySqlCommand(forwardToTermekMozgasQuery, conn);
                            forwardCmd.Parameters.AddWithValue("@termek_id", termekId);
                            forwardCmd.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception x)
                        {
                            return false;
                        }
                    }
                }
                catch (Exception x)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }

        }
        public bool termek_mozgas(string darab_szam, string termek_ar)
        {

            
            string query = $"INSERT INTO termek_mozgas (termek_darabszam, bevet_eladas, datum) VALUES ('{darab_szam}', '{termek_ar}', NOW());";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed");
                        break;
                }
                return false;
            }
        }

        private void AdatokLekerese_Click(object sender, EventArgs e)
        {
            string selectedTermekNev = comboBox1.SelectedValue?.ToString();
            string query = "SELECT termek.termek_id, `termek_nev`, `termek_darabszam`, `bevet_eladas`, `datum` " +
                   "FROM `termek_mozgas` " +
                   "INNER JOIN termek ON termek.termek_id = termek_mozgas.termek_id ";

            if (!string.IsNullOrEmpty(selectedTermekNev) && selectedTermekNev != "minden")
            {
                query += $"WHERE termek.termek_nev = '{selectedTermekNev}' ";
            }

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();



            try
            {
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void PopulateComboBox()
        {
            try
            {
                if (OpenConnection())
                {
                    string query = "SELECT termek_nev FROM termek;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow everythingRow = dt.NewRow();
                        everythingRow["termek_nev"] = "minden";
                        dt.Rows.InsertAt(everythingRow, 0);


                        // Bind the DataTable to the ComboBox
                        comboBox1.DisplayMember = "termek_nev";
                        comboBox1.ValueMember = "termek_nev";
                        comboBox1.DataSource = dt;
                    }
                }
                else
                {
                    // Handle connection failure
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                conn.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            termek_darab.Show();
            termek_ár.Show();
            termek_nev.Show();
            label1.Hide();
            comboBox1.Hide();
            AdatokLekerese.Hide();
            Upload_Button.Show();
        }

        private void Lekerdezes_Menustrp_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            termek_darab.Hide();
            termek_ár.Hide();
            termek_nev.Hide();
            label1.Show();
            comboBox1.Show();
            AdatokLekerese.Show();
            Upload_Button.Hide();
        }
    }
}
