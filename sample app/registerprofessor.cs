using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace sample_app
{
    public partial class registerprofessor : Form
    {
        private Database db = new Database();
        private static int prof_id = -1;
        private static int course_id = -1;
        private List<int> prof_id_list = new List<int>();
        private List<int> course_id_list = new List<int>();



        public registerprofessor()
        {
            InitializeComponent();
        }

        private void registerprofessor_Load(object sender, EventArgs e)
        {
            db.connect();
            string query = "SELECT id, first_name, last_name FROM users WHERE type = 'b'";
            DataTable data = db.getData(query);
            // Populate prof_id_list
            prof_id_list = Utils.StoreIdField(data, 0);
            Utils.PopulateListBox(professor_list, data);

            string query2 = "SELECT id, title FROM courses";
            DataTable data2 = db.getData(query2);
            // Populate prof_id_list
            course_id_list = Utils.StoreIdField(data2, 0);
            Utils.PopulateListBox(course_list, data2);

        }

        



        private void professor_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = professor_list.SelectedItem.ToString();

            // Find the string in ListBox2.
            int index = professor_list.FindString(curItem);
            prof_id = prof_id_list[index];
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox2");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO course_by_instructor (course_id, user_id) VALUES(\'"+course_id+"\',\'"+prof_id+"\')";
            db.insert(query);
        }

        private void course_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = course_list.SelectedItem.ToString();

            // Find the string in ListBox2.
            int index = course_list.FindString(curItem);
            course_id = course_id_list[index];
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox2");
                    

        }
    }
}
