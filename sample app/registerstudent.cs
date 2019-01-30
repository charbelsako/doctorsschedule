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
    public partial class registerstudent : Form
    {
        private Database db = new Database();
        private static int student_id = -1;
        private static int course_id = -1;
        private List<int> student_id_list = new List<int>();
        private List<int> course_id_list = new List<int>();

        public registerstudent()
        {
            InitializeComponent();
            db.connect();
        }

        private void registerstudent_Load(object sender, EventArgs e)
        {
            db.connect();
            string query = "SELECT id, first_name, last_name FROM users WHERE type = 'a'";
            DataTable data = db.getData(query);
            // Populate prof_id_list
            student_id_list = Utils.StoreIdField(data, 0);
            Utils.PopulateListBox(students_listbox, data);

            string query2 = "SELECT id, title FROM courses";
            DataTable data2 = db.getData(query2);
            // Populate prof_id_list
            course_id_list = Utils.StoreIdField(data2, 0);
            Utils.PopulateListBox(courses_listbox, data2);
        }

        private void students_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = students_listbox.SelectedItem.ToString();

            // Find the string in ListBox2.
            int index = students_listbox.FindString(curItem);
            student_id = student_id_list[index];
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox2");

        }

        private void courses_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = courses_listbox.SelectedItem.ToString();

            // Find the string in ListBox2.
            int index = courses_listbox.FindString(curItem);
            course_id = course_id_list[index];
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox2");

        }

        private void register_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO student_by_course (course_id, student_id) VALUES(\'" + course_id + "\',\'" + student_id + "\')";
            db.insert(query);
        }
    }
}
