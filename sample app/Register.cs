﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace sample_app
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string username = user_name.Text;
            string Pass = password.Text;
            string firstname = first_name.Text;
            string lastname = last_name.Text;

            char user_type;
            string curItem = usertype.SelectedItem.ToString();
            switch (curItem)
            {
                case "A : Student":
                    user_type = 'a';
                    break;
                case "B : Professor":
                    user_type = 'b';
                    break;
                default:
                    user_type = 'c';
                    break;


            }
            Database DB = new Database();
            MySqlConnection conn = DB.connect();
            string query = "INSERT INTO users (first_name, last_name, username, password, type) VALUES (\""+firstname+"\",\""+lastname+"\",\""+username+"\",\""+Pass+"\",\""+user_type+"\")";
            MessageBox.Show(query);
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Added new user");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
            Admin_Homepage back = new Admin_Homepage();
            back.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
    }
}
