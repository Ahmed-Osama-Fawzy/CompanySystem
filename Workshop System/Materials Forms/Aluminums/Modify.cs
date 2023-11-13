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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
            Update();
        }
        public Modify(int i)
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
        private void Edit_Click(object sender, EventArgs e)
        {
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void Details_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            string id = ID.Text;
            if (!string.IsNullOrEmpty(id))
            {
                AluminumClass aluminmu = new AluminumClass();
                aluminmu.ID = Convert.ToInt32(id);
                string XNumber = Number.Text;
                string XSection = Section.Text;
                string XCategory = Category.Text;
                string XDescription = Description.Text;
                string XType = Type.Text;
                string XName = AName.Text;
                string Low = LowWeight.Text;
                string Avg = AvgWeight.Text;
                string High = HighWeight.Text;
                string Len = Length.Text;
                if (string.IsNullOrEmpty(XNumber) && string.IsNullOrEmpty(XSection) && string.IsNullOrEmpty(XCategory) && string.IsNullOrEmpty(XDescription) && string.IsNullOrEmpty(XType) && string.IsNullOrEmpty(XName) && string.IsNullOrEmpty(Low) && string.IsNullOrEmpty(Avg) && string.IsNullOrEmpty(High) && string.IsNullOrEmpty(Len))
                {
                    MessageBox.Show("عفوا يجب ادخال بيانات للتحديث");
                }
                else
                {
                    if (!string.IsNullOrEmpty(XNumber))
                        aluminmu.Number = XNumber;
                    if (!string.IsNullOrEmpty(XSection))
                        aluminmu.Section = XSection;
                    if (!string.IsNullOrEmpty(XCategory))
                        aluminmu.Category = XCategory;
                    if (!string.IsNullOrEmpty(XName))
                        aluminmu.Title = XName;
                    if (!string.IsNullOrEmpty(XType))
                        aluminmu.Type = XType;
                    if (!string.IsNullOrEmpty(XDescription))
                        aluminmu.Description = XDescription;
                    if (!string.IsNullOrEmpty(Low))
                        if (Convert.ToDouble(Low) > 0) aluminmu.Low = Convert.ToDouble(Low);
                        else MessageBox.Show("عفوا يجب ادخال قيمة وزن خفيف صالحة");
                    if (!string.IsNullOrEmpty(Avg))
                        if(Convert.ToDouble(Avg)> 0) aluminmu.Avg = Convert.ToDouble(Avg);
                        else MessageBox.Show("عفوا يجب ادخال قيمة وزن متوسط صالحة");
                    if (!string.IsNullOrEmpty(High))
                        if(Convert.ToDouble(High) > 0) aluminmu.High = Convert.ToDouble(High);
                        else MessageBox.Show("عفوا يجب ادخال قيمة وزن ثقيل صالحة");
                    if (!string.IsNullOrEmpty(Len))
                        if(Convert.ToDouble(Len) > 0) aluminmu.Length = Convert.ToDouble(Len);
                        else MessageBox.Show("عفوا يجب ادخال قيمة طول صالحة");
                    bool Updated = aluminmu.Update();
                    if (Updated)
                    {
                        MessageBox.Show("تم تحديث البايانات بنجاح");
                        ID.Text = string.Empty;
                        Number.Text = string.Empty;
                        Section.Text = string.Empty;
                        Category.Text = string.Empty;
                        AName.Text = string.Empty;
                        Type.Text = string.Empty;
                        Description.Text = string.Empty;
                        LowWeight.Text = string.Empty;
                        AvgWeight.Text = string.Empty;
                        HighWeight.Text = string.Empty;
                        Length.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("‘عفوا لا يمكن تحديث البيانات");
                    }
                }

            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال الرقم الكودي اولا ");
            }
        }

        private void Details_Click_1(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
            Update();
        }
        private void Clear_Click_1(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            Number.Text = string.Empty;
            Section.Text = string.Empty;
            Category.Text = string.Empty;
            AName.Text = string.Empty;
            Type.Text = string.Empty;
            Description.Text = string.Empty;
            LowWeight.Text = string.Empty;
            AvgWeight.Text = string.Empty;
            HighWeight.Text = string.Empty;
            Length.Text = string.Empty;
        }
    }
}
