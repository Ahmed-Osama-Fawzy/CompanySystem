using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class;

namespace Workshop_System.Materials_Forms.Aluminum
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            Update();
        }
        public Add(int i)
        {
            InitializeComponent();
            ID.Text = i.ToString();
            Update();
        }
        public void Update()
        {
            DataBase DB = new DataBase("Materials", "Type");
            Category.DisplayMember = "Value";
            Category.ValueMember = "Value";
            if (DB.GetData("قسم العمل") != null)
            {
                Category.DataSource = DB.GetData("قسم العمل"); Category.Enabled = true;
            }
            else
                Category.Enabled = false;

            Section.DisplayMember = "Value";
            Section.ValueMember = "Value";
            if (DB.GetData("فرع العمل") != null)
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
            if (DB.GetData("وصف العمل") != null)
            {
                Description.DataSource = DB.GetData("وصف العمل"); Description.Enabled = true;
            }
            else
                Description.Enabled = false;

            Length.DisplayMember = "Value";
            Length.ValueMember = "Value";
            if (DB.GetData("الطول") != null)
            {
                Length.DataSource = DB.GetData("الطول"); Length.Enabled = true;
            }
            else
                Length.Enabled = false;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            AluminumClass a = new AluminumClass();
            a.Number = Number.Text;
            a.Category = Category.Text;
            a.Section = Section.Text;
            a.Type = Type.Text;
            a.Title = AName.Text;
            a.Description = Description.Text;
            if (!string.IsNullOrEmpty(LowWeight.Text))
                if (Convert.ToDouble(LowWeight.Text) > 0) a.Low = Convert.ToDouble(LowWeight.Text);
                else MessageBox.Show("عفوا يجب ادخال قيمة وزن خفيف صالحة");
            else
                a.Low = 0.0;
            if (!string.IsNullOrEmpty(AvgWeight.Text))
                if (Convert.ToDouble(AvgWeight.Text) > 0) a.Avg = Convert.ToDouble(AvgWeight.Text);
                else MessageBox.Show("عفوا يجب ادخال قيمة وزن متوسط صالحة");
            else
                a.Avg = 0.0;
            if (!string.IsNullOrEmpty(HighWeight.Text))
                if (Convert.ToDouble(HighWeight.Text) > 0) a.High = Convert.ToDouble(HighWeight.Text);
                else MessageBox.Show("عفوا يجب ادخال قيمة وزن ثقيل صالحة");
            else
                a.High = 0.0;
            if (!string.IsNullOrEmpty(Length.Text))
                if (Convert.ToDouble(Length.Text) > 0) a.Length = Convert.ToDouble(Length.Text);
                else MessageBox.Show("عفوا يجب ادخال قيمة طول صالحة");
            else
                a.Length = 0.0;
            if(!string.IsNullOrEmpty(a.Number)&&!string.IsNullOrEmpty(a.Category)&&!string.IsNullOrEmpty(a.Section)&&!string.IsNullOrEmpty(a.Type)&&!string.IsNullOrEmpty(a.Title)&&!string.IsNullOrEmpty(a.Description)&& a.Low > 0.0 && a.Avg > 0.0 && a.High > 0.0 && a.Length > 0.0 ) 
            {
                bool S = a.Insert();
                if (S)
                {
                    MessageBox.Show("تمت الاضافة بنجاح");
                    Number.Text = string.Empty;
                    Category.Text = string.Empty;
                    Section.Text = string.Empty;
                    Type.Text = string.Empty;
                    AName.Text = string.Empty;
                    Description.Text = string.Empty;
                    LowWeight.Text = string.Empty;
                    AvgWeight.Text = string.Empty;
                    HighWeight.Text = string.Empty;
                    Length.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("عفوا حدث خطا اثناء الادخال");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            Number.Text = string.Empty;
            Category.Text = string.Empty;
            Section.Text = string.Empty;
            Type.Text = string.Empty;
            AName.Text = string.Empty;
            Description.Text = string.Empty;
            LowWeight.Text = string.Empty;
            AvgWeight.Text = string.Empty;
            HighWeight.Text = string.Empty;
            Length.Text = string.Empty;
        }
        private void Add_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Details_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
            Update();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
