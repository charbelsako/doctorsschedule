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
        public Student_Homepage()
        {
            InitializeComponent();
        }

        private void Student_Homepage_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + userdata.username;
        }

        private void Student_Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 logout = new Form1();
            logout.Show();
        }
    }
}
