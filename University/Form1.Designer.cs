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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.Registration = new System.Windows.Forms.TabPage();
            this.Registration_Specialization = new MaterialSkin.Controls.MaterialComboBox();
            this.Registration_Button = new MaterialSkin.Controls.MaterialButton();
            this.Registration_Password = new MaterialSkin.Controls.MaterialTextBox();
            this.Registration_Email = new MaterialSkin.Controls.MaterialTextBox();
            this.Registration_Surname = new MaterialSkin.Controls.MaterialTextBox();
            this.Registration_Name = new MaterialSkin.Controls.MaterialTextBox();
            this.tabControl1.SuspendLayout();
            this.Registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CategorySplitterColor = System.Drawing.SystemColors.ControlText;
            this.propertyGrid1.Location = new System.Drawing.Point(528, 378);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(8, 8);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.Registration);
            this.tabControl1.Location = new System.Drawing.Point(-4, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 388);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(800, 362);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Registration.Controls.Add(this.Registration_Specialization);
            this.Registration.Controls.Add(this.Registration_Button);
            this.Registration.Controls.Add(this.Registration_Password);
            this.Registration.Controls.Add(this.Registration_Email);
            this.Registration.Controls.Add(this.Registration_Surname);
            this.Registration.Controls.Add(this.Registration_Name);
            this.Registration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Registration.Location = new System.Drawing.Point(4, 22);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Registration.Size = new System.Drawing.Size(800, 362);
            this.Registration.TabIndex = 1;
            this.Registration.Text = "Registration";
            // 
            // Registration_Specialization
            // 
            this.Registration_Specialization.AutoResize = false;
            this.Registration_Specialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Registration_Specialization.Depth = 0;
            this.Registration_Specialization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Registration_Specialization.DropDownHeight = 174;
            this.Registration_Specialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Registration_Specialization.DropDownWidth = 121;
            this.Registration_Specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Registration_Specialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Registration_Specialization.FormattingEnabled = true;
            this.Registration_Specialization.Hint = "Specialization";
            this.Registration_Specialization.IntegralHeight = false;
            this.Registration_Specialization.ItemHeight = 43;
            this.Registration_Specialization.Location = new System.Drawing.Point(565, 35);
            this.Registration_Specialization.MaxDropDownItems = 4;
            this.Registration_Specialization.MouseState = MaterialSkin.MouseState.OUT;
            this.Registration_Specialization.Name = "Registration_Specialization";
            this.Registration_Specialization.Size = new System.Drawing.Size(218, 49);
            this.Registration_Specialization.StartIndex = 0;
            this.Registration_Specialization.TabIndex = 10;
            // 
            // Registration_Button
            // 
            this.Registration_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Registration_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Registration_Button.Depth = 0;
            this.Registration_Button.HighEmphasis = true;
            this.Registration_Button.Icon = null;
            this.Registration_Button.Location = new System.Drawing.Point(380, 263);
            this.Registration_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Registration_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Registration_Button.Size = new System.Drawing.Size(89, 36);
            this.Registration_Button.TabIndex = 9;
            this.Registration_Button.Text = "Register";
            this.Registration_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Registration_Button.UseAccentColor = false;
            this.Registration_Button.UseVisualStyleBackColor = true;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // Registration_Password
            // 
            this.Registration_Password.AnimateReadOnly = false;
            this.Registration_Password.BackColor = System.Drawing.SystemColors.Window;
            this.Registration_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registration_Password.Depth = 0;
            this.Registration_Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Registration_Password.Hint = "Password";
            this.Registration_Password.LeadingIcon = null;
            this.Registration_Password.Location = new System.Drawing.Point(137, 204);
            this.Registration_Password.MaxLength = 50;
            this.Registration_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Registration_Password.Multiline = false;
            this.Registration_Password.Name = "Registration_Password";
            this.Registration_Password.Password = true;
            this.Registration_Password.Size = new System.Drawing.Size(363, 50);
            this.Registration_Password.TabIndex = 8;
            this.Registration_Password.Text = "";
            this.Registration_Password.TrailingIcon = null;
            // 
            // Registration_Email
            // 
            this.Registration_Email.AnimateReadOnly = false;
            this.Registration_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registration_Email.Depth = 0;
            this.Registration_Email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Registration_Email.Hint = "Email";
            this.Registration_Email.LeadingIcon = null;
            this.Registration_Email.Location = new System.Drawing.Point(137, 148);
            this.Registration_Email.MaxLength = 50;
            this.Registration_Email.MouseState = MaterialSkin.MouseState.OUT;
            this.Registration_Email.Multiline = false;
            this.Registration_Email.Name = "Registration_Email";
            this.Registration_Email.Size = new System.Drawing.Size(363, 50);
            this.Registration_Email.TabIndex = 7;
            this.Registration_Email.Text = "";
            this.Registration_Email.TrailingIcon = null;
            // 
            // Registration_Surname
            // 
            this.Registration_Surname.AnimateReadOnly = false;
            this.Registration_Surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registration_Surname.Depth = 0;
            this.Registration_Surname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Registration_Surname.Hint = "Surname";
            this.Registration_Surname.LeadingIcon = null;
            this.Registration_Surname.Location = new System.Drawing.Point(137, 92);
            this.Registration_Surname.MaxLength = 50;
            this.Registration_Surname.MouseState = MaterialSkin.MouseState.OUT;
            this.Registration_Surname.Multiline = false;
            this.Registration_Surname.Name = "Registration_Surname";
            this.Registration_Surname.Size = new System.Drawing.Size(363, 50);
            this.Registration_Surname.TabIndex = 6;
            this.Registration_Surname.Text = "";
            this.Registration_Surname.TrailingIcon = null;
            // 
            // Registration_Name
            // 
            this.Registration_Name.AnimateReadOnly = false;
            this.Registration_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registration_Name.Depth = 0;
            this.Registration_Name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Registration_Name.Hint = "Name";
            this.Registration_Name.LeadingIcon = null;
            this.Registration_Name.Location = new System.Drawing.Point(137, 36);
            this.Registration_Name.MaxLength = 50;
            this.Registration_Name.MouseState = MaterialSkin.MouseState.OUT;
            this.Registration_Name.Multiline = false;
            this.Registration_Name.Name = "Registration_Name";
            this.Registration_Name.Size = new System.Drawing.Size(363, 50);
            this.Registration_Name.TabIndex = 5;
            this.Registration_Name.Text = "";
            this.Registration_Name.TrailingIcon = null;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.tabControl1.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

