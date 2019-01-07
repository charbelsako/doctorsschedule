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
            // Database db = new Database();
            // MySqlConnection conn = db.connect();
            // DataTable data = db.getData("SELECT * FROM users");
            string sql = "SELECT first_name, last_name FROM users";
            DataSet Ds = new DataSet();
          
            try
            {
                cnn.Open();
                adapter = new MySqlDataAdapter(sql, cnn);
                adapter.Fill(Ds, "courses");
                DataTable data = Ds.Tables["courses"];
                // Fills the data grid view with the data
                courses.DataSource = data;
                // Connection established
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Couldn't be opened. Oh well");
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

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Problem: When the main windows is hidden and you close the second window
            //the application does not close.

            // Closes the application when another window is closed.
            Application.Exit();
        }
    }
}
