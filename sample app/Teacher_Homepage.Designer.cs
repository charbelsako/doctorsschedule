namespace sample_app
{
    partial class Teacher_Homepage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courses = new System.Windows.Forms.DataGridView();
            this.logout = new System.Windows.Forms.Button();
            this.absences = new System.Windows.Forms.DataGridView();
            this.makeup_session = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absences)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome , user";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Courses";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(322, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Absense";
            // 
            // courses
            // 
            this.courses.AllowUserToAddRows = false;
            this.courses.AllowUserToDeleteRows = false;
            this.courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses.Location = new System.Drawing.Point(12, 126);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(285, 150);
            this.courses.TabIndex = 3;
            this.courses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courses_CellClick);
            this.courses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courses_CellContentClick);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(665, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(104, 36);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // absences
            // 
            this.absences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.absences.Location = new System.Drawing.Point(330, 127);
            this.absences.Name = "absences";
            this.absences.Size = new System.Drawing.Size(284, 148);
            this.absences.TabIndex = 5;
            // 
            // makeup_session
            // 
            this.makeup_session.Location = new System.Drawing.Point(14, 302);
            this.makeup_session.Name = "makeup_session";
            this.makeup_session.Size = new System.Drawing.Size(143, 36);
            this.makeup_session.TabIndex = 6;
            this.makeup_session.Text = "Request Make up session";
            this.makeup_session.UseVisualStyleBackColor = true;
            this.makeup_session.Click += new System.EventHandler(this.makeup_session_Click);
            // 
            // Teacher_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 364);
            this.Controls.Add(this.makeup_session);
            this.Controls.Add(this.absences);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teacher_Homepage";
            this.Text = "Homepage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homepage_FormClosed);
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView courses;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DataGridView absences;
        private System.Windows.Forms.Button makeup_session;
    }
}