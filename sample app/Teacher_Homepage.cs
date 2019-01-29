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
        private static string course_id = "";
        public static string Course_id { get => course_id; set => course_id = value; }

        public Teacher_Homepage()
        {
            InitializeComponent();
        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + userdata.username;
            // since we don't have a password we don't add the pwd.
            Database db = new Database();
            db.connect();
            string MySql = "SELECT code, title, course_id FROM course_by_instructor cbi JOIN courses c ON cbi.course_id = c.id JOIN users u ON cbi.user_id = u.id WHERE u.first_name = \'" + userdata.first_name + "\' AND u.last_name = \'" + userdata.last_name + "\' ";
            
            // Show the teacher his absences
            DataTable data = db.getData("SELECT date FROM professor_absence pa JOIN users u ON pa.professor_id = u.id WHERE u.first_name = '" + userdata.first_name + "' AND u.last_name = '" + userdata.last_name + "'");
            absences.DataSource = data;


        }

        private static string[][] findTimeForMakeupCourse(Database db)
        {
            // This isn't gonna work. BECAUSE
            /* Some of the relations in the database weren't even made.
             * Those relations would have made this algorithm easier.
             * 
             * The result is that this algorithm will only show you 
             * a time if ALL rooms are empty at that given day and time.
             * 
             * Solution. Include all rooms in the 2d array and eliminate time by room.
             * 
             */


            // GET ALL THE COURSES THAT THOSE STUDENTS TAKE AND STORE THE START DATE AND THE DAY IN A LIST
            DataTable student_time = db.getData("SELECT day ,start_date FROM student_by_course sby JOIN courses c ON c.id = sby.course_id JOIN rooms r ON r.id = c.room_id JOIN days d ON d.id = c.day_id JOIN users u ON u.id = sby.student_id JOIN time t ON t.id = c.time_id WHERE u.type = 'a' AND sby.student_id IN (SELECT student_id FROM student_by_course JOIN users u ON u.id = student_id WHERE course_id = "+Course_id+" AND u.type = 'a')");

            // GET all the courses that the university is offering and store their start_date and number in a list.
            // Based on the time of the free students get the room that is free.
            DataTable room_time = db.getData("SELECT day, start_date FROM courses c JOIN rooms r ON r.id = c.room_id JOIN time t ON t.id = c.time_id JOIN days d  ON d.id = c.day_id");

            // Programmatically choose a day and a time that no one has anything to do in.
            string[] days = new string[4] { "MF", "TR", "MTRF", "W" };
            string[] times = new string[5] { "08:30", "10:00", "11:30", "02:00", "03:30" };

            string[][] times_days = new string[20][];

            int k = 0;
            for (int i = 0, n = days.Length; i < n; i++)
            {
                for (int j = 0, m = times.Length; j < m; j++)
                {
                    string[] v = new string[3] { days[i], times[j], "1" };
                    times_days[k] = v;
                    k++;
                }
            }

            // Eliminate used up time.
            // Highly inefficient
            foreach (DataRow row in student_time.Rows)
            {
                for (int i = 0; i < 20; i++)
                {
                    bool is_same_day = times_days[i][0] == row[0].ToString();
                    bool is_same_time = times_days[i][1] == row[1].ToString().Substring(0, 5);
                    if ((is_same_time && is_same_day))
                    {
                        times_days[i][2] = "0";
                    }
                }
            }
            //Console.WriteLine(times_days);
            foreach (DataRow row in room_time.Rows)
            {
                for (int i = 0; i < 20; i++)
                {
                    bool is_same_day = times_days[i][0] == row[0].ToString();
                    bool is_same_time = times_days[i][1] == row[1].ToString().Substring(0, 5);
                    if ((is_same_time && is_same_day))
                    {
                        times_days[i][2] = "0";
                    }
                }
            }
            return times_days;
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
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            userdata.f.Show();
        }

        private void makeup_session_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.connect();
            string[][] available_time = findTimeForMakeupCourse(db);
            Show2DArray(available_time, end: "\n");
        }

        private static void Show2DArray(string[][] arr, string end="\t")
        {
            string msg = "";
            foreach(var row in arr)
            {
                for (int i = 0; i < row.Length - 1; i++) {
                    string col = row[i];
                    if(row[2] == "1") {
                        msg += col + " ";
                    }
                    
                }
                msg += end;
            }
            MessageBox.Show(msg);
        }

        private void courses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ri = e.RowIndex;
            int ci = e.ColumnIndex;
            Course_id = Convert.ToString(courses.Rows[ri].Cells[2].ToString());
            
        }
    }
}
