namespace sample_app
{
    partial class registerprofessor
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
            this.register_prof = new System.Windows.Forms.Button();
            this.professor_list = new System.Windows.Forms.ListBox();
            this.course_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register a professor to the desired course";
            // 
            // register_prof
            // 
            this.register_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.register_prof.Location = new System.Drawing.Point(362, 259);
            this.register_prof.Name = "register_prof";
            this.register_prof.Size = new System.Drawing.Size(182, 56);
            this.register_prof.TabIndex = 1;
            this.register_prof.Text = "Register";
            this.register_prof.UseVisualStyleBackColor = true;
            this.register_prof.Click += new System.EventHandler(this.button1_Click);
            // 
            // professor_list
            // 
            this.professor_list.FormattingEnabled = true;
            this.professor_list.Location = new System.Drawing.Point(31, 91);
            this.professor_list.Name = "professor_list";
            this.professor_list.Size = new System.Drawing.Size(140, 173);
            this.professor_list.TabIndex = 2;
            this.professor_list.SelectedIndexChanged += new System.EventHandler(this.professor_list_SelectedIndexChanged);
            // 
            // course_list
            // 
            this.course_list.FormattingEnabled = true;
            this.course_list.Location = new System.Drawing.Point(199, 91);
            this.course_list.Name = "course_list";
            this.course_list.Size = new System.Drawing.Size(148, 173);
            this.course_list.TabIndex = 3;
            this.course_list.SelectedIndexChanged += new System.EventHandler(this.course_list_SelectedIndexChanged);
            // 
            // registerprofessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 327);
            this.Controls.Add(this.course_list);
            this.Controls.Add(this.professor_list);
            this.Controls.Add(this.register_prof);
            this.Controls.Add(this.label1);
            this.Name = "registerprofessor";
            this.Text = "registerprofessor";
            this.Load += new System.EventHandler(this.registerprofessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_prof;
        private System.Windows.Forms.ListBox professor_list;
        private System.Windows.Forms.ListBox course_list;
    }
}