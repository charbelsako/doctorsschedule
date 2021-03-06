﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace sample_app
{
    public partial class Form1 : Form
    {
        private bool invalid_pass = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (invalid_pass)
            {
                status.Text = "Pass contains invalid characters";
                return;
            }
            // get data from username and password fields and compare to those in the database.
            string user = this.username.Text;
            string pass = this.password.Text;
            // connect to the database
            string conn = "server=localhost;database=doctorsschedule;uid=root;";
            MySqlConnection cnn = new MySqlConnection(conn);

            string query = "SELECT first_name, last_name, type FROM users WHERE username='" + user + "' AND password='" + pass + "' LIMIT 1";

            MySqlCommand commandDatabase = new MySqlCommand(query, cnn);
            commandDatabase.CommandTimeout = 60;

            try
            {
                cnn.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    Teacher_Homepage main = new Teacher_Homepage();
                    Student_Homepage student_main;
                    Admin_Homepage admin_main;
                   

                    char user_type = 'a';
                    string fname;
                    string lname;
                    // you have to run the method read before accessing results
                    while (reader.Read())
                    {
                        // Capitalizing the first character of the first name and last name
                        fname = capitalizeFirst(reader.GetString(0));
                        lname = capitalizeFirst(reader.GetString(1));
                        user_type = reader.GetChar(2);
                        // can i add a global class to save these. userdata.cs
                        userdata.username = fname + " " + lname;
                        userdata.first_name = fname;
                        userdata.last_name = lname;
                    }
                    userdata.f = this; 
                    this.Hide();
                    this.username.Text = "";
                    this.password.Text = "";
                    switch (user_type)
                    {
                        case 'a':
                            student_main = new Student_Homepage();
                            student_main.Show();
                            break;
                        case 'b':
                            main = new Teacher_Homepage();
                            main.Show();
                            break;
                        // this should be changed later.
                        case 'c':
                            admin_main = new Admin_Homepage();
                            admin_main.Show();
                            break;
                        case 'd':
                            admin_main = new Admin_Homepage();
                            admin_main.Show();
                            break;
                    }
                    // show all the different forms based on the user type
                    
                }
                else
                {
                    this.status.Text = "Invalid Credentials";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string capitalizeFirst(string text)
        {
            return (char.ToUpper(text[0]) + text.Substring(1).ToLower());
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

            // removes numbers and special characters
            // Regex rx = new Regex("[^a-z0-9]", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            string input = password.Text;
            string pattern = "[*`=()&% ]";
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count > 0)
            {
                status.Text = "Password cannot contain *`=()&%";
                invalid_pass = true;
            }
            else
            {
                status.Text = "";
                invalid_pass = false;
            }
            // validate if password has required length and contains 
            // at least 1 number and 1 uppercase letter and doesn't contain harmful characters.
        }

        
    }
}
