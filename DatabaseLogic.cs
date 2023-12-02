using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public class DatabaseLogic
    {
        private MySqlConnection conn;

        public MySqlConnection Connection
        {
            get { return conn; }
        }

        public DatabaseLogic(string connString)
        {
            conn = new MySqlConnection(connString);
        }

        public bool OpenConnection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                    return true;
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection failed: {ex.Number}");
                return false;
            }
        }

        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public int CheckIfTermekExists(string termek_nev)
        {
            string checkQuery = "SELECT COUNT(*) FROM termek WHERE termek_nev = @termek_nev;";
            int count = 0;

            try
            {
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@termek_nev", termek_nev);
                    count = Convert.ToInt32(checkCmd.ExecuteScalar());
                }

                return count;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection failed: {ex.Number}");
                return -1;
            }
        }

        public int InsertIntoTermekDatabase(string termek_nev, string darab_szam, string termek_ar)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO termek (termek_nev) VALUES (@termek_nev);", conn))
                {
                    cmd.Parameters.AddWithValue("@termek_nev", termek_nev);


                    cmd.ExecuteNonQuery();

                    string getTermekIdQuery = "SELECT termek_id FROM termek WHERE termek_nev = @termek_nev;";
                    MySqlCommand getTermekIdCmd = new MySqlCommand(getTermekIdQuery, conn);
                    getTermekIdCmd.Parameters.AddWithValue("@termek_nev", termek_nev);
                    int termekId = Convert.ToInt32(getTermekIdCmd.ExecuteScalar());

                    return termekId;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Failed to insert into termek: {ex.Message}");
                return -1;
            }
            finally
            {
                CloseConnection(); // Close the connection in the finally block
            }
        }

        public bool InsertIntoTermek_mozgasDataTable(string darab_szam, string termek_ar, int termekId)
        {
            string query = $"INSERT INTO termekek_mozgas (termek_id, termek_darabszam, bevet_elada, datum) VALUES (@termek_id, '{darab_szam}', '{termek_ar}', NOW());";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@termek_id", termekId);

                    if (OpenConnection())
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            return true;
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Execution failed: {ex.Number}");
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection failed: {ex.Number}");
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
