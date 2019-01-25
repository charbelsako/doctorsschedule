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
    public partial class Teacher_Homepage : Form
    {
       
        private MySqlDataAdapter adapter;
       
        public Teacher_Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, "+userdata.username;
            // since we don't have a password we don't add the pwd.
            string conn = "server=localhost;database=doctorsschedule;uid=root;";
            MySqlConnection cnn = new MySqlConnection(conn);
            // Database db = new Database();
            // MySqlConnection conn = db.connect();
            // DataTable data = db.getData("SELECT * FROM users");
            string MySql = "SELECT code, title FROM course_by_instructor cbi JOIN courses c ON cbi.course_id = c.id JOIN users u ON cbi.user_id = u.id WHERE u.first_name = \'"+userdata.first_name+"\' AND u.last_name = \'"+userdata.last_name+"\' ";
            DataSet Ds = new DataSet();
          
            try
            {
                cnn.Open();
                adapter = new MySqlDataAdapter(MySql, cnn);
                adapter.Fill(Ds, "courses");
                DataTable data = Ds.Tables["courses"];
                // Fills the data grid view with the data
                courses.DataSource = data;
                // Connection established
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            userdata.f.Show();
        }
    }
}
