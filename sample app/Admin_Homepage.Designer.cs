﻿namespace sample_app
{
    partial class Admin_Homepage
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.register_student = new System.Windows.Forms.Button();
            this.register_professor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(601, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(88, 33);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // register_student
            // 
            this.register_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_student.Location = new System.Drawing.Point(12, 187);
            this.register_student.Name = "register_student";
            this.register_student.Size = new System.Drawing.Size(288, 52);
            this.register_student.TabIndex = 4;
            this.register_student.Text = "register a student to a course";
            this.register_student.UseVisualStyleBackColor = true;
            this.register_student.Click += new System.EventHandler(this.button2_Click);
            // 
            // register_professor
            // 
            this.register_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_professor.Location = new System.Drawing.Point(12, 246);
            this.register_professor.Name = "register_professor";
            this.register_professor.Size = new System.Drawing.Size(288, 52);
            this.register_professor.TabIndex = 5;
            this.register_professor.Text = "register a professor to a course";
            this.register_professor.UseVisualStyleBackColor = true;
            this.register_professor.Click += new System.EventHandler(this.regisiter_professor_Click);
            // 
            // Admin_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 310);
            this.Controls.Add(this.register_professor);
            this.Controls.Add(this.register_student);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Admin_Homepage";
            this.Text = "Admin_Homepage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Homepage_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button register_student;
        private System.Windows.Forms.Button register_professor;
    }
}