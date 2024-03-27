using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Models;

namespace University
{
    public partial class Profile : MaterialForm
    {
        public Profile()
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
        }
        public Profile(Student student)
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

        }
        private void Profile_Shown(object sender, EventArgs e)
        {
            Student student = new Student();

            Profile_Name.Text = student.Name + " " + student.Surname;
        }
    }
}
