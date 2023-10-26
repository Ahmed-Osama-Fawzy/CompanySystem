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

namespace Workshop_System.Materials_Forms.Accessories
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
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

            Color.DisplayMember = "Value";
            Color.ValueMember = "Value";
            if (DB.GetData("اللون") != null)
            {
                Color.DataSource = DB.GetData("اللون"); Color.Enabled = true;
            }
            else
                Color.Enabled = false;

            Section.DisplayMember = "Value";
            Section.ValueMember = "Value";
            if (DB.GetData("فرع العمل") != null)
            {
                Section.DataSource = DB.GetData("فرع العمل"); Section.Enabled = true;
            }
            else
                Section.Enabled = false;

            Description.DisplayMember = "Value";
            Description.ValueMember = "Value";
            if (DB.GetData("وصف العمل") != null)
            {
                Description.DataSource = DB.GetData("وصف العمل"); Description.Enabled = true;
            }
            else
                Description.Enabled = false;

            Type.DisplayMember = "Value";
            Type.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Type.DataSource = DB.GetData("نوع العمل"); Type.Enabled = true;
            }
            else
                Type.Enabled = false;
        }

        public Name(string i)
        {
            InitializeComponent();
            ID.Text = i;
            Update();
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id)) 
            {
                string SName = AName.Text;
                string SSize = Size.Text;
                string SCategory = Category.Text;
                string SPrice = Price.Text;
                string SColor = Color.Text;
                string SType = Type.Text;
                string SDescription = Description.Text;
                string SSection = Section.Text;
                if (!string.IsNullOrEmpty(SName) || !string.IsNullOrEmpty(SCategory) || !string.IsNullOrEmpty(SSize) || !string.IsNullOrEmpty(SPrice) || !string.IsNullOrEmpty(SColor) || !string.IsNullOrEmpty(SType) || !string.IsNullOrEmpty(SDescription))
                {
                    AccessoriesClass accessoriesClass  = new AccessoriesClass();
                    accessoriesClass.ID = Convert.ToInt32(id);
                    if(!string.IsNullOrEmpty(SName))
                        accessoriesClass.Name = SName;
                    if(!string.IsNullOrEmpty(SCategory))
                        accessoriesClass.Category = SCategory;
                    if(!string.IsNullOrEmpty(SSize))
                        accessoriesClass.Size = Convert.ToInt32(SSize);
                    if(!string.IsNullOrEmpty(SPrice))
                        accessoriesClass.Price = float.Parse(SPrice);
                    if (!string.IsNullOrEmpty(SColor))
                        accessoriesClass.Color = SColor;
                    if(!string.IsNullOrEmpty(SType))
                        accessoriesClass.Type = SType;
                    if(!string.IsNullOrEmpty(SDescription))
                        accessoriesClass.Description = SDescription;
                    if (!string.IsNullOrEmpty(accessoriesClass.Section = SSection))
                        accessoriesClass.Section = SSection;
                    if (accessoriesClass.Modify())
                    {
                        MessageBox.Show("تم تعديل البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خطا في تحديث البيانات");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال بيانات للتعديل");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال الرقم الكودي اولا");
            }
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void Details_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
            Update();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            AName.Text = string.Empty;
            Size.Text = string.Empty;
            Category.Text = string.Empty;
            Price.Text = string.Empty;
            Color.Text = string.Empty;
            Section.Text = string.Empty;
            Description.Text = string.Empty;
            Type.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Description_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click_1(object sender, EventArgs e)
        {

        }

        private void Details_Click_1(object sender, EventArgs e)
        {

        }
    }
}
