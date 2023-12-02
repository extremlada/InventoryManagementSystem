using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class IMS_MainMenu : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private DatabaseLogic DatabaseL;
        private DataTable dt;




        public IMS_MainMenu()
        {
            server = "localhost";
            database = "raktar";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};convert zero datetime=True";


            DatabaseL = new DatabaseLogic(connString);




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

            if (termek(termek_nev, termek_ar, darab_szam))
            {
                MessageBox.Show("minden fel lett töltve");

                // Add the new item to the DataTable
                DataRow newRow = dt.NewRow();
                newRow["termek_nev"] = termek_nev;
                dt.Rows.Add(newRow);

                // Refresh the ComboBox
                comboBox1.DataSource = null;
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "termek_nev";
                comboBox1.ValueMember = "termek_nev";
            }
            else
            {
                MessageBox.Show("Valami rosszul lett be írva");
            }


        }

        public bool termek(string termek_nev, string termek_ar, string darab_szam)
        {
            try
            {
                if (!DatabaseL.OpenConnection())
                {
                    MessageBox.Show("Failed to open connection");
                    return false;
                }

                int count = DatabaseL.CheckIfTermekExists(termek_nev);
                if (count > 0)
                {
                    MessageBox.Show("A termék már létezik az adatbázisban");
                    return false;
                }

                int termekId = DatabaseL.InsertIntoTermekDatabase(termek_nev, darab_szam, termek_ar);
                if (termekId == -1)
                {
                    MessageBox.Show("Hiba történt az elem kezelése közben, nem lehet az adatbázisba fel venni az elemet");
                    return false;
                }

                return DatabaseL.InsertIntoTermek_mozgasDataTable(darab_szam, termek_ar, termekId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception in termek: {ex.Message}");
                return false;
            }
            finally
            {
                DatabaseL.CloseConnection();
            }
            

        }


        private void AdatokLekerese_Click(object sender, EventArgs e)
        {
            string selectedTermekNev = comboBox1.SelectedValue?.ToString();
            string query = "SELECT termek.termek_id, `termek_nev`, `termek_darabszam`, `bevet_elada`, `datum` " +
                   "FROM `termekek_mozgas` " +
                   "INNER JOIN termek ON termek.termek_id = termekek_mozgas.termek_id ";

            if (!string.IsNullOrEmpty(selectedTermekNev) && selectedTermekNev != "minden")
            {
                query += $"WHERE termek.termek_nev = '{selectedTermekNev}' ";
            }

            MySqlDataAdapter da = new MySqlDataAdapter(query, DatabaseL.Connection);
            DataSet ds = new DataSet();



            try
            {
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Adat tábla lekérése közben hiba történt: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PopulateComboBox()
        {
            try
            {
                if (DatabaseL.OpenConnection())
                {
                    string query = "SELECT termek_nev FROM termek;";
                    MySqlCommand cmd = new MySqlCommand(query, DatabaseL.Connection);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        dt = new DataTable();
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
                    MessageBox.Show("something went wrong");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
            finally
            {
                DatabaseL.CloseConnection();
            }
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseLogin Csatlakozas = new DataBaseLogin();
            Csatlakozas.Show();
        }
    }
}
