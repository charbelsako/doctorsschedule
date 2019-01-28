﻿using MySql.Data.MySqlClient;
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
            label1.Text = "Welcome, " + userdata.username;
            // since we don't have a password we don't add the pwd.
            string conn = "server=localhost;database=doctorsschedule;uid=root;";
            MySqlConnection cnn = new MySqlConnection(conn);
            string MySql = "SELECT code, title FROM course_by_instructor cbi JOIN courses c ON cbi.course_id = c.id JOIN users u ON cbi.user_id = u.id WHERE u.first_name = \'" + userdata.first_name + "\' AND u.last_name = \'" + userdata.last_name + "\' ";
            DataSet Ds = new DataSet();

            try
            {
                cnn.Open();
                adapter = new MySqlDataAdapter(MySql, cnn);
                adapter.Fill(Ds, "courses");
                DataTable _data = Ds.Tables["courses"];
                // Fills the data grid view with the data
                courses.DataSource = _data;
                // Connection established
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Connection Couldn't be opened. Oh well");
            }
            // Show the teacher his absences
            Database db = new Database();
            db.connect();
            DataTable data = db.getData("SELECT date FROM professor_absence pa JOIN users u ON pa.professor_id = u.id WHERE u.first_name = '" + userdata.first_name + "' AND u.last_name = '" + userdata.last_name + "'");
            absences.DataSource = data;


            // I could make a dictionary and use a process of elimination to determine what free time we have.

            // GET ALL THE COURSES THAT THOSE STUDENTS TAKE AND STORE THE START DATE AND THE DAY IN A LIST
            /*  
             *  
             SELECT start_date, day FROM student_by_course sby 
             JOIN courses c ON c.id = sby.course_id 
             JOIN rooms r ON r.id = c.room_id 
             JOIN days d ON d.id = c.day_id 
             JOIN users u ON u.id = sby.student_id 
             JOIN time t ON t.id = c.time_id
             WHERE u.type = 'a' AND sby.student_id 
             IN(SELECT student_id FROM student_by_course sby 
             JOIN users u ON u.id = sby.student_id WHERE course_id = 1 AND u.type = 'a' )
             * 
             * 
            */
            // Make an algorithm to figure out when the students are free.


            // GET all the courses that the university is offering and store their start_date and number in a list.
            /*
             * "SELECT start_date, number FROM courses c JOIN rooms r ON r.id = c.room_id JOIN time t ON t.id = c.time_id"  
             */
            // Based on the time of the free students get the room that is free.

            // Programmatically choose a day and a time that no one has anything to do in.
            string[] days = new string[5] { "M", "T", "W", "R", "F" };
            string[] times = new string[5] { "8:30", "10:00", "11:30", "2:00", "3:30" };

            string[][] times_days = new string[25][];

            int k = 0;
            for (int i = 0, n = days.Length; i < n; i++)
            {
                for (int j = 0, m = times.Length; j < m; j++)
                {
                    string[] v = new string[2] { days[i], times[j] };
                    times_days[k] = v;
                    k++;
                }
            }

            // To be continued.
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
