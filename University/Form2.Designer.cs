namespace University
{
    partial class Profile
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
            tabControl1 = new TabControl();
            Student_page = new TabPage();
            Teacher_page = new TabPage();
            Profile_Name = new MaterialSkin.Controls.MaterialLabel();
            tabControl1.SuspendLayout();
            Student_page.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Student_page);
            tabControl1.Controls.Add(Teacher_page);
            tabControl1.Location = new Point(-5, 76);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(943, 448);
            tabControl1.TabIndex = 0;
            // 
            // Student_page
            // 
            Student_page.BackColor = Color.FromArgb(50, 50, 50);
            Student_page.Controls.Add(Profile_Name);
            Student_page.Location = new Point(4, 24);
            Student_page.Name = "Student_page";
            Student_page.Padding = new Padding(3);
            Student_page.Size = new Size(935, 420);
            Student_page.TabIndex = 0;
            Student_page.Text = "Student";
            // 
            // Teacher_page
            // 
            Teacher_page.BackColor = Color.FromArgb(50, 50, 50);
            Teacher_page.Location = new Point(4, 24);
            Teacher_page.Name = "Teacher_page";
            Teacher_page.Padding = new Padding(3);
            Teacher_page.Size = new Size(935, 420);
            Teacher_page.TabIndex = 1;
            Teacher_page.Text = "Teacher";
            // 
            // Profile_Name
            // 
            Profile_Name.AutoSize = true;
            Profile_Name.Depth = 0;
            Profile_Name.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Profile_Name.ForeColor = SystemColors.Control;
            Profile_Name.Location = new Point(390, 19);
            Profile_Name.MouseState = MaterialSkin.MouseState.HOVER;
            Profile_Name.Name = "Profile_Name";
            Profile_Name.Size = new Size(107, 19);
            Profile_Name.TabIndex = 0;
            Profile_Name.Text = "materialLabel1";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(933, 519);
            Controls.Add(tabControl1);
            Name = "Profile";
            Text = "Profile";
            Shown += Profile_Shown;
            tabControl1.ResumeLayout(false);
            Student_page.ResumeLayout(false);
            Student_page.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Student_page;
        private TabPage Teacher_page;
        private MaterialSkin.Controls.MaterialLabel Profile_Name;
    }
}