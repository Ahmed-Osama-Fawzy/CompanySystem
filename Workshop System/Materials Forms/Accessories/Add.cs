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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            DataBase DB = new DataBase("Materials", "Types");
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
        private void add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companypSystemDataSet1.Types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.companypSystemDataSet1.Types);
            // TODO: This line of code loads data into the 'companypSystemDataSet1.Accessories' table. You can move, or remove it, as needed.
            AName.Text = string.Empty;
            Size.Text = string.Empty;
            Category.Text = string.Empty;
            Price.Text = string.Empty;
            Color.Text = string.Empty;
            Section.Text = string.Empty;
            Description.Text = string.Empty;
            Type.Text = string.Empty;
        }
        private void Insert_Click_1(object sender, EventArgs e)
        {
            AccessoriesClass accessoriesClass = new AccessoriesClass();
            string SName = AName.Text;
            string SSize = Size.Text;
            string SCategory = Category.Text;
            string SPrice = Price.Text;
            string SColor = Color.Text;
            string SSection = Section.Text;
            string SStatus = Description.Text;
            string SType = Type.Text;
            if (!string.IsNullOrEmpty(SName) && !string.IsNullOrEmpty(SCategory) && !string.IsNullOrEmpty(SSize) && !string.IsNullOrEmpty(SPrice) && !string.IsNullOrEmpty(SColor) && !string.IsNullOrEmpty(SSection) && !string.IsNullOrEmpty(SStatus) && !string.IsNullOrEmpty(SType
                ))
            {
                accessoriesClass.Name = SName;
                if (float.Parse(SSize) > 0) accessoriesClass.Size = float.Parse(SSize);
                else MessageBox.Show("عفوا يجب ادخال قيمة مقاس صالح");
                accessoriesClass.Category = SCategory;
                if(float.Parse(SPrice) > 0) accessoriesClass.Price = float.Parse(SPrice);
                else MessageBox.Show("عفوا يجب ادخال قيمة سعر صالح");
                accessoriesClass.Color = SColor;
                accessoriesClass.Section = SSection;
                accessoriesClass.Description = SStatus;
                accessoriesClass.Type = SType;
                if (accessoriesClass.Insert())
                {
                    MessageBox.Show("تم حفظ البيانات بنجاح ");
                    AName.Text = string.Empty;
                    Size.Text = string.Empty;
                    Category.Text = string.Empty;
                    Price.Text = string.Empty;
                    Color.Text = string.Empty;
                    Section.Text = string.Empty;
                    Description.Text = string.Empty;
                    Type.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("عفوا لم يتم حفظ البيانات حاول مرة اخري");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات");
            }
        }
        private void Details_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
            Update();

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            AName.Text = string.Empty;
            Size.Text = string.Empty;
            Category.Text = string.Empty;
            Price.Text = string.Empty;
            Color.Text = string.Empty;
            Section.Text = string.Empty;
            Description.Text = string.Empty;
            Type.Text = string.Empty;
        }
    }
}
