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
    public partial class Admin_Homepage : Form
    {
        public Admin_Homepage()
        {
            InitializeComponent();
            label1.Text = "Welcome, "+ userdata.username;
        }

        private void Admin_Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            Register reg = new Register();
            reg.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
            userdata.f.Show();
        }

        private void Admin_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
