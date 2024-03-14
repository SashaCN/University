using University.Models;

namespace University
{
    partial class Authentication
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
            propertyGrid1 = new PropertyGrid();
            tabControl1 = new TabControl();
            Login = new TabPage();
            Registration = new TabPage();
            Registration_Specialization = new MaterialSkin.Controls.MaterialComboBox();
            Registration_Button = new MaterialSkin.Controls.MaterialButton();
            Registration_Password = new MaterialSkin.Controls.MaterialTextBox();
            Registration_Email = new MaterialSkin.Controls.MaterialTextBox();
            Registration_Surname = new MaterialSkin.Controls.MaterialTextBox();
            Registration_Name = new MaterialSkin.Controls.MaterialTextBox();
            Login_Button = new MaterialSkin.Controls.MaterialButton();
            Login_Password = new MaterialSkin.Controls.MaterialTextBox();
            Login_Email = new MaterialSkin.Controls.MaterialTextBox();
            tabControl1.SuspendLayout();
            Login.SuspendLayout();
            Registration.SuspendLayout();
            SuspendLayout();
            // 
            // propertyGrid1
            // 
            propertyGrid1.CategorySplitterColor = SystemColors.ControlText;
            propertyGrid1.Location = new Point(616, 436);
            propertyGrid1.Margin = new Padding(4, 3, 4, 3);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(9, 9);
            propertyGrid1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Login);
            tabControl1.Controls.Add(Registration);
            tabControl1.Location = new Point(-5, 76);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(943, 448);
            tabControl1.TabIndex = 1;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(50, 50, 50);
            Login.Controls.Add(Login_Button);
            Login.Controls.Add(Login_Password);
            Login.Controls.Add(Login_Email);
            Login.Location = new Point(4, 24);
            Login.Margin = new Padding(4, 3, 4, 3);
            Login.Name = "Login";
            Login.Padding = new Padding(4, 3, 4, 3);
            Login.Size = new Size(935, 420);
            Login.TabIndex = 0;
            Login.Text = "Login";
            // 
            // Registration
            // 
            Registration.BackColor = Color.FromArgb(50, 50, 50);
            Registration.Controls.Add(Registration_Specialization);
            Registration.Controls.Add(Registration_Button);
            Registration.Controls.Add(Registration_Password);
            Registration.Controls.Add(Registration_Email);
            Registration.Controls.Add(Registration_Surname);
            Registration.Controls.Add(Registration_Name);
            Registration.ForeColor = SystemColors.ControlText;
            Registration.Location = new Point(4, 24);
            Registration.Margin = new Padding(4, 3, 4, 3);
            Registration.Name = "Registration";
            Registration.Padding = new Padding(4, 3, 4, 3);
            Registration.Size = new Size(935, 420);
            Registration.TabIndex = 1;
            Registration.Text = "Registration";
            // 
            // Registration_Specialization
            // 
            Registration_Specialization.AutoResize = false;
            Registration_Specialization.BackColor = Color.FromArgb(255, 255, 255);
            Registration_Specialization.Depth = 0;
            Registration_Specialization.DrawMode = DrawMode.OwnerDrawVariable;
            Registration_Specialization.DropDownHeight = 174;
            Registration_Specialization.DropDownStyle = ComboBoxStyle.DropDownList;
            Registration_Specialization.DropDownWidth = 121;
            Registration_Specialization.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Registration_Specialization.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Registration_Specialization.FormattingEnabled = true;
            Registration_Specialization.Hint = "Specialization";
            Registration_Specialization.IntegralHeight = false;
            Registration_Specialization.ItemHeight = 43;
            Registration_Specialization.Location = new Point(659, 40);
            Registration_Specialization.Margin = new Padding(4, 3, 4, 3);
            Registration_Specialization.MaxDropDownItems = 4;
            Registration_Specialization.MouseState = MaterialSkin.MouseState.OUT;
            Registration_Specialization.Name = "Registration_Specialization";
            Registration_Specialization.Size = new Size(254, 49);
            Registration_Specialization.StartIndex = 0;
            Registration_Specialization.TabIndex = 10;
            // 
            // Registration_Button
            // 
            Registration_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Registration_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Registration_Button.Depth = 0;
            Registration_Button.HighEmphasis = true;
            Registration_Button.Icon = null;
            Registration_Button.Location = new Point(443, 303);
            Registration_Button.Margin = new Padding(5, 7, 5, 7);
            Registration_Button.MouseState = MaterialSkin.MouseState.HOVER;
            Registration_Button.Name = "Registration_Button";
            Registration_Button.NoAccentTextColor = Color.Empty;
            Registration_Button.Size = new Size(89, 36);
            Registration_Button.TabIndex = 9;
            Registration_Button.Text = "Register";
            Registration_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Registration_Button.UseAccentColor = false;
            Registration_Button.UseVisualStyleBackColor = true;
            Registration_Button.Click += Registration_Button_Click;
            // 
            // Registration_Password
            // 
            Registration_Password.AnimateReadOnly = false;
            Registration_Password.BackColor = SystemColors.Window;
            Registration_Password.BorderStyle = BorderStyle.None;
            Registration_Password.Depth = 0;
            Registration_Password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Registration_Password.Hint = "Password";
            Registration_Password.LeadingIcon = null;
            Registration_Password.Location = new Point(160, 235);
            Registration_Password.Margin = new Padding(4, 3, 4, 3);
            Registration_Password.MaxLength = 50;
            Registration_Password.MouseState = MaterialSkin.MouseState.OUT;
            Registration_Password.Multiline = false;
            Registration_Password.Name = "Registration_Password";
            Registration_Password.Password = true;
            Registration_Password.Size = new Size(424, 50);
            Registration_Password.TabIndex = 8;
            Registration_Password.Text = "";
            Registration_Password.TrailingIcon = null;
            // 
            // Registration_Email
            // 
            Registration_Email.AnimateReadOnly = false;
            Registration_Email.BorderStyle = BorderStyle.None;
            Registration_Email.Depth = 0;
            Registration_Email.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Registration_Email.Hint = "Email";
            Registration_Email.LeadingIcon = null;
            Registration_Email.Location = new Point(160, 171);
            Registration_Email.Margin = new Padding(4, 3, 4, 3);
            Registration_Email.MaxLength = 50;
            Registration_Email.MouseState = MaterialSkin.MouseState.OUT;
            Registration_Email.Multiline = false;
            Registration_Email.Name = "Registration_Email";
            Registration_Email.Size = new Size(424, 50);
            Registration_Email.TabIndex = 7;
            Registration_Email.Text = "";
            Registration_Email.TrailingIcon = null;
            // 
            // Registration_Surname
            // 
            Registration_Surname.AnimateReadOnly = false;
            Registration_Surname.BorderStyle = BorderStyle.None;
            Registration_Surname.Depth = 0;
            Registration_Surname.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Registration_Surname.Hint = "Surname";
            Registration_Surname.LeadingIcon = null;
            Registration_Surname.Location = new Point(160, 106);
            Registration_Surname.Margin = new Padding(4, 3, 4, 3);
            Registration_Surname.MaxLength = 50;
            Registration_Surname.MouseState = MaterialSkin.MouseState.OUT;
            Registration_Surname.Multiline = false;
            Registration_Surname.Name = "Registration_Surname";
            Registration_Surname.Size = new Size(424, 50);
            Registration_Surname.TabIndex = 6;
            Registration_Surname.Text = "";
            Registration_Surname.TrailingIcon = null;
            // 
            // Registration_Name
            // 
            Registration_Name.AnimateReadOnly = false;
            Registration_Name.BorderStyle = BorderStyle.None;
            Registration_Name.Depth = 0;
            Registration_Name.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Registration_Name.Hint = "Name";
            Registration_Name.LeadingIcon = null;
            Registration_Name.Location = new Point(160, 42);
            Registration_Name.Margin = new Padding(4, 3, 4, 3);
            Registration_Name.MaxLength = 50;
            Registration_Name.MouseState = MaterialSkin.MouseState.OUT;
            Registration_Name.Multiline = false;
            Registration_Name.Name = "Registration_Name";
            Registration_Name.Size = new Size(424, 50);
            Registration_Name.TabIndex = 5;
            Registration_Name.Text = "";
            Registration_Name.TrailingIcon = null;
            // 
            // Login_Button
            // 
            Login_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Login_Button.CausesValidation = false;
            Login_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Login_Button.Depth = 0;
            Login_Button.HighEmphasis = true;
            Login_Button.Icon = null;
            Login_Button.Location = new Point(422, 236);
            Login_Button.Margin = new Padding(5, 7, 5, 7);
            Login_Button.MouseState = MaterialSkin.MouseState.HOVER;
            Login_Button.Name = "Login_Button";
            Login_Button.NoAccentTextColor = Color.Empty;
            Login_Button.Size = new Size(89, 36);
            Login_Button.TabIndex = 12;
            Login_Button.Text = "Login";
            Login_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Login_Button.UseAccentColor = false;
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // Login_Password
            // 
            Login_Password.AnimateReadOnly = false;
            Login_Password.BackColor = SystemColors.Window;
            Login_Password.BorderStyle = BorderStyle.None;
            Login_Password.Depth = 0;
            Login_Password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Login_Password.Hint = "Password";
            Login_Password.LeadingIcon = null;
            Login_Password.Location = new Point(255, 176);
            Login_Password.Margin = new Padding(4, 3, 4, 3);
            Login_Password.MaxLength = 50;
            Login_Password.MouseState = MaterialSkin.MouseState.OUT;
            Login_Password.Multiline = false;
            Login_Password.Name = "Login_Password";
            Login_Password.Password = true;
            Login_Password.Size = new Size(424, 50);
            Login_Password.TabIndex = 11;
            Login_Password.Text = "";
            Login_Password.TrailingIcon = null;
            // 
            // Login_Email
            // 
            Login_Email.AnimateReadOnly = false;
            Login_Email.BorderStyle = BorderStyle.None;
            Login_Email.Depth = 0;
            Login_Email.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Login_Email.Hint = "Email";
            Login_Email.LeadingIcon = null;
            Login_Email.Location = new Point(255, 112);
            Login_Email.Margin = new Padding(4, 3, 4, 3);
            Login_Email.MaxLength = 50;
            Login_Email.MouseState = MaterialSkin.MouseState.OUT;
            Login_Email.Multiline = false;
            Login_Email.Name = "Login_Email";
            Login_Email.Size = new Size(424, 50);
            Login_Email.TabIndex = 10;
            Login_Email.Text = "";
            Login_Email.TrailingIcon = null;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(tabControl1);
            Controls.Add(propertyGrid1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Authentication";
            Padding = new Padding(4, 74, 4, 3);
            Text = "Authentication";
            tabControl1.ResumeLayout(false);
            Login.ResumeLayout(false);
            Login.PerformLayout();
            Registration.ResumeLayout(false);
            Registration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage Registration;
        private MaterialSkin.Controls.MaterialTextBox Registration_Name;
        private MaterialSkin.Controls.MaterialTextBox Registration_Email;
        private MaterialSkin.Controls.MaterialTextBox Registration_Surname;
        private MaterialSkin.Controls.MaterialTextBox Registration_Password;
        private MaterialSkin.Controls.MaterialButton Registration_Button;
        private MaterialSkin.Controls.MaterialComboBox Registration_Specialization;
        private MaterialSkin.Controls.MaterialButton Login_Button;
        private MaterialSkin.Controls.MaterialTextBox Login_Password;
        private MaterialSkin.Controls.MaterialTextBox Login_Email;
    }
}

