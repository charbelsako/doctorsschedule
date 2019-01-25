using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sample_app
{
    class Database
    {
        private string connectionString = "server=localhost;database=doctorsschedule;uid=root;";
        private MySqlConnection connection;
        public Database()
        {

        }

        public MySqlConnection connect()
        {
            connection = new MySqlConnection(connectionString);
            return connection;
        }

        public DataTable getData(string query)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter;
            try
            {
                connection.Open();
                adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(ds, "data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds.Tables["data"];
        }
    }
}