using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Workshop_System.App_Class;
using Workshop_System.Materials_Forms;
using Workshop_System.App_Class.Discounts_Classes;
using Workshop_System.App_Class.Discounts_Classes.Windows;

namespace Workshop_System.Discounts_Forms.Windows.Sliding_Windows
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            DataBase DB = new DataBase("", "");
            Section.DisplayMember = "Value";
            Section.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Section.DataSource = DB.GetData("فرع العمل"); Section.Enabled = true;
            }
            else
                Section.Enabled = false;
            Type.DisplayMember = "Value";
            Type.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Type.DataSource = DB.GetData("نوع العمل"); Type.Enabled = true;
            }
            else
                Type.Enabled = false;
            Description.DisplayMember = "Value";
            Description.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Description.DataSource = DB.GetData("وصف العمل"); Description.Enabled = true;
            }
            else
                Description.Enabled = false;

            RollsNumber.DisplayMember = "Value";
            RollsNumber.ValueMember = "Value";
            if (DB.GetData("عدد الدرفات") != null)
            {
                RollsNumber.DataSource = DB.GetData("عدد الدرفات"); RollsNumber.Enabled = true;
            }
            else
                RollsNumber.Enabled = false;
        }
        private void Details_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void MainData_Click(object sender, EventArgs e)
        {
            string SSetion = Section.Text;
            string SType = Type.Text;
            string SRollNumber = RollsNumber.Text;
            string SDescription = Description.Text;
            string Height = MainHeight.Text;
            string Width = MainWidth.Text;
            if(!string.IsNullOrEmpty(SSetion)
                && !string.IsNullOrEmpty(SType)
                && !string.IsNullOrEmpty(SRollNumber)
                && !string.IsNullOrEmpty(SDescription)
                && !string.IsNullOrEmpty(Height)
                && !string.IsNullOrEmpty(Width))
            {
                WindowsClass windowsclass = new WindowsClass();
                windowsclass.Category = "شبابيك";
                windowsclass.Section = SSetion;
                windowsclass.Type = SType;
                windowsclass.Description = SDescription;
                windowsclass.RollsNumber = Convert.ToInt32(SRollNumber);
                windowsclass.Height = float.Parse(Height);
                windowsclass.Width = float.Parse(Width);
                int id = windowsclass.CheckDiscount();
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع المدخلات اولا");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
