using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Models;

namespace University
{
    public partial class Authentication : MaterialForm
    {
        public Authentication()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            Color Dark = Color.FromArgb(33, 33, 33);
            Color LessDark = Color.FromArgb(42, 42, 42);
            Color LightGrey = Color.LightGray;
            Color MoreDark = Color.FromArgb(5, 5, 5);
            Color Orange = Color.Orange;
            Color White = Color.White;
            materialSkinManager.ColorScheme = new ColorScheme(Dark, Dark, MoreDark, Orange, TextShade.WHITE);

            Specialization ipz = new Specialization("121_ipz");
            ipz.Subjects.Add(new Subject("OOP"));
            ipz.Subjects.Add(new Subject("Math analysis"));
            ipz.Subjects.Add(new Subject("Databases"));
            ipz.Subjects.Add(new Subject("IPZ basis"));
            ipz.Subjects.Add(new Subject("English"));

            using (FileStream fs = new FileStream("Database\\Faculties\\FIT\\121_IPZ.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<Specialization>(fs, ipz);
            }

            Specialization ce = new Specialization("123_ce");
            ce.Subjects.Add(new Subject("OOP"));
            ce.Subjects.Add(new Subject("Data structures"));
            ce.Subjects.Add(new Subject("Physics"));
            ce.Subjects.Add(new Subject("Probability theory"));
            ce.Subjects.Add(new Subject("English"));

            using (FileStream fs = new FileStream("Database\\Faculties\\FIT\\123_CE.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<Specialization>(fs, ce);
            }
        }
        public enum Tabs { Login = 0, Registration = 1 }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == (int)Tabs.Registration)
            {
                List<string> specializations = Directory.GetFiles("Database\\Faculties\\FIT\\").ToList();
                for (int i = 0; i < specializations.Count; i++)
                {
                    specializations[i] = specializations[i].Substring(specializations[i].LastIndexOf('\\') + 1);
                    specializations[i] = specializations[i].Substring(0, specializations[i].LastIndexOf('.'));
                    Registration_Specialization.Items.Add(specializations[i]);
                }
            }
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {

            // Check if all field are not empty

            if (Registration_Name.Text == "" || Registration_Surname.Text == "" || Registration_Email.Text == "" || Registration_Password.Text == "" || Registration_Specialization.Text == "")
            {
                MessageBox.Show("Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            // Finding the correct specialization

            Specialization specialization;
            using (FileStream fs = new FileStream($"Database\\Faculties\\FIT\\{Registration_Specialization.Text}.json", FileMode.OpenOrCreate))
            {
                specialization = JsonSerializer.Deserialize<Specialization>(fs);
            }

            // Creating new student

            Student student = new Student(Registration_Name.Text, Registration_Surname.Text, Registration_Email.Text, Registration_Password.Text, specialization);

            // Saving student to json

            if (!File.Exists("Database\\students.json"))
            {
                using (FileStream fs = new FileStream("Database\\students.json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.Serialize<Student>(fs, student);
                }
            } else
            {
                using (FileStream fs = new FileStream("Database\\students.json", FileMode.Append, FileAccess.Write))
                {
                    JsonSerializer.Serialize<Student>(fs, student);
                }

            }

        }
    }
}
