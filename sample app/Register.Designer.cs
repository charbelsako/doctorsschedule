namespace sample_app
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.usertype_label = new System.Windows.Forms.Label();
            this.usertype = new System.Windows.Forms.ListBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register a new member";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(101, 75);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(100, 20);
            this.first_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(372, 71);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(99, 20);
            this.user_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "User Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(101, 118);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(98, 20);
            this.last_name.TabIndex = 7;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(372, 118);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(99, 20);
            this.password.TabIndex = 8;
            this.password.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Password";
            // 
            // usertype_label
            // 
            this.usertype_label.AutoSize = true;
            this.usertype_label.Location = new System.Drawing.Point(194, 188);
            this.usertype_label.Name = "usertype_label";
            this.usertype_label.Size = new System.Drawing.Size(56, 13);
            this.usertype_label.TabIndex = 12;
            this.usertype_label.Text = "User Type";
            // 
            // usertype
            // 
            this.usertype.FormattingEnabled = true;
            this.usertype.Items.AddRange(new object[] {
            "A : Student",
            "B : Professor",
            "C : Admin"});
            this.usertype.Location = new System.Drawing.Point(256, 175);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(71, 43);
            this.usertype.TabIndex = 13;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(208, 262);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(152, 32);
            this.register_btn.TabIndex = 14;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(630, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(61, 21);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 330);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.usertype_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.password);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label usertype_label;
        private System.Windows.Forms.ListBox usertype;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button back_btn;
    }
}