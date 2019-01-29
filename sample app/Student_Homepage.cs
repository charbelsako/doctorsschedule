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
    public partial class Student_Homepage : Form
    {
        private MySqlDataAdapter adapter;

        public Student_Homepage()
        {
            InitializeComponent();
        }

        private void Student_Homepage_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + userdata.username;

            string conn = "server=localhost;database=doctorsschedule;uid=root;";
            MySqlConnection cnn = new MySqlConnection(conn);
            string MySql = "SELECT code, title, start_date, end_date, day FROM student_by_course sby JOIN users u ON u.id = sby.student_id JOIN courses c ON c.id = sby.course_id JOIN time t ON t.id = c.time_id JOIN days d ON d.id = c.day_id WHERE u.first_name = \'"+userdata.first_name+"\' AND u.last_name = \'"+userdata.last_name+"\'";
            DataSet Ds = new DataSet();

            try
            {
                cnn.Open();
                adapter = new MySqlDataAdapter(MySql, cnn);
                adapter.Fill(Ds, "courses");
                DataTable data = Ds.Tables["courses"];
                // Fills the data grid view with the data
                myCourses.DataSource = data;
                // Connection established
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Connection Couldn't be opened. Oh well");
            }
        }

        private void Student_Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            userdata.f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            userdata.f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
