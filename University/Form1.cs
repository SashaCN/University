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
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            Repository<Specialization>
                .GetRepo("Faculties\\FIT\\121_IPZ.json")
                .Create(ipz);

            Specialization ce = new Specialization("123_ce");
            ce.Subjects.Add(new Subject("OOP"));
            ce.Subjects.Add(new Subject("Data structures"));
            ce.Subjects.Add(new Subject("Physics"));
            ce.Subjects.Add(new Subject("Probability theory"));
            ce.Subjects.Add(new Subject("English"));

            Repository<Specialization>
                .GetRepo("Faculties\\FIT\\123_CE.json")
                .Create(ce);
        }
        public enum Tabs { Login = 0, Registration = 1 }

        // getting all students
        public List<Student> getStudents()
        {
            List<Student> students = Repository<Student>
               .GetRepo("students.json")
               .GetAll();

            return students;
        }

        // filling the list of specializations
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

        delegate void RegistrationDelegate();

        private void Registration_Button_Click(object sender, EventArgs e)
        {

            // Check if all field are not empty

            if (Registration_Name.Text == "" || Registration_Surname.Text == "" || Registration_Email.Text == "" || Registration_Password.Text == "" || Registration_Specialization.Text == "")
            {
                MessageBox.Show("Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
          
            object obj;
            if (Registration_Teacher.Checked)
                obj = new Teacher(Registration_Name.Text, Registration_Surname.Text, Registration_Email.Text, Registration_Password.Text);
            else
                obj = new Student(Registration_Name.Text, Registration_Surname.Text, Registration_Email.Text, Registration_Password.Text, Registration_Specialization.Text);

            // Створення делегата і виклик методу create
            RegistrationDelegate registration = (obj is Teacher) ? ((Teacher)obj).Create : ((Student)obj).Create;
            registration();

            // Success message 
            MessageBox.Show("Registration successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public Student authorizedStudent = new();

        private void Login_Button_Click(object sender, EventArgs e)
        {
            List<Student> students = getStudents();

            var student = students.FirstOrDefault(s => s.Email == Login_Email.Text && s.Password == Login_Password.Text);
            if (student != null)
            {
                authorizedStudent = student;
                Profile profileForm = new(student);
                profileForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Email or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
