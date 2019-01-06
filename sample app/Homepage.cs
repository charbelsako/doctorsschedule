using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace sample_app
{
    public partial class Homepage : Form
    {
        public string user = null;
        private MySqlDataAdapter adapter;
       
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, "+user;
            // since we don't have a password we don't add the pwd.
            string conn = "server=localhost;database=doctorsschedule;uid=root;";
            MySqlConnection cnn = new MySqlConnection(conn);
            string sql = "SELECT * FROM users";
            DataSet Ds = new DataSet();
          
            try
            {
                cnn.Open();
                adapter = new MySqlDataAdapter(sql, cnn);
                adapter.Fill(Ds, "courses");
                DataTable data = Ds.Tables["courses"];
                courses.DataSource = data;
                // Connection established
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Couldn't be opened");
            }
            // get the data for the user
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
