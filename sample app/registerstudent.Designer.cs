namespace sample_app
{
    partial class registerstudent
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
            this.students_listbox = new System.Windows.Forms.ListBox();
            this.courses_listbox = new System.Windows.Forms.ListBox();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register a student to a course";
            // 
            // students_listbox
            // 
            this.students_listbox.FormattingEnabled = true;
            this.students_listbox.Location = new System.Drawing.Point(32, 89);
            this.students_listbox.Name = "students_listbox";
            this.students_listbox.Size = new System.Drawing.Size(153, 160);
            this.students_listbox.TabIndex = 1;
            this.students_listbox.SelectedIndexChanged += new System.EventHandler(this.students_listbox_SelectedIndexChanged);
            // 
            // courses_listbox
            // 
            this.courses_listbox.FormattingEnabled = true;
            this.courses_listbox.Location = new System.Drawing.Point(224, 89);
            this.courses_listbox.Name = "courses_listbox";
            this.courses_listbox.Size = new System.Drawing.Size(163, 160);
            this.courses_listbox.TabIndex = 2;
            this.courses_listbox.SelectedIndexChanged += new System.EventHandler(this.courses_listbox_SelectedIndexChanged);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(417, 267);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(164, 49);
            this.register.TabIndex = 3;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // registerstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 326);
            this.Controls.Add(this.register);
            this.Controls.Add(this.courses_listbox);
            this.Controls.Add(this.students_listbox);
            this.Controls.Add(this.label1);
            this.Name = "registerstudent";
            this.Text = "registerstudent";
            this.Load += new System.EventHandler(this.registerstudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox students_listbox;
        private System.Windows.Forms.ListBox courses_listbox;
        private System.Windows.Forms.Button register;
    }
}