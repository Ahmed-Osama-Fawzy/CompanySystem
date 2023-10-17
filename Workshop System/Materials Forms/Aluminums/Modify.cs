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
            DataBase DB = new DataBase("", "");
            Section.DisplayMember = "Value";
            Section.ValueMember = "Value";
            if (DB.GetData("فرع الوميتال") != null)
            {
                Section.DataSource = DB.GetData("فرع الوميتال"); Section.Enabled = true;
            }
            else
                Section.Enabled = false;

            Category.DisplayMember = "Value";
            Category.ValueMember = "Value";
            if (DB.GetData("قسم الالوميتال") != null)
            {
                Category.DataSource = DB.GetData("قسم الالوميتال"); Category.Enabled = true;
            }
            else
                Category.Enabled = false;

            Type.DisplayMember = "Value";
            Type.ValueMember = "Value";
            if (DB.GetData("نوع الالوميتال ") != null)
            {
                Type.DataSource = DB.GetData("نوع الالوميتال "); Type.Enabled = true;
            }
            else
                Type.Enabled = false;

            Status.DisplayMember = "Value";
            Status.ValueMember = "Value";
            if (DB.GetData("حالة الالوميتال ") != null)
            {
                Status.DataSource = DB.GetData("حالة الالوميتال "); Status.Enabled = true;
            }
            else
                Status.Enabled = false;

            Notes.DisplayMember = "Value";
            Notes.ValueMember = "Value";
            if (DB.GetData("ملاحظات الوميتال") != null)
            {
                Notes.DataSource = DB.GetData("ملاحظات الوميتال"); Notes.Enabled = true;
            }
            else
                Notes.Enabled = false;

            Length.DisplayMember = "Value";
            Length.ValueMember = "Value";
            if (DB.GetData("طول") != null)
            {
                Length.DataSource = DB.GetData("طول"); Length.Enabled = true;
            }
            else
                Length.Enabled = false;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id))
            {
                AluminumClass aluminmu = new AluminumClass();
                aluminmu.ID = Convert.ToInt32(id);
                string XNumber = Number.Text;
                string XSection = Section.Text;
                string XCategory = Category.Text;
                string XStatus = Status.Text;
                string XType = Type.Text;
                string XNotes = Notes.Text;
                string Low = LowWeight.Text;
                string Avg = AvgWeight.Text;
                string High = HighWeight.Text;
                string Len = Length.Text;
                if (string.IsNullOrEmpty(XNumber)&&string.IsNullOrEmpty(XSection)&&string.IsNullOrEmpty(XCategory)&&string.IsNullOrEmpty(XStatus)&&string.IsNullOrEmpty(XType)&&string.IsNullOrEmpty(XNotes)&&string.IsNullOrEmpty(Low)&&string.IsNullOrEmpty(Avg)&&string.IsNullOrEmpty(High)&&string.IsNullOrEmpty(Len)) 
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
                    if (!string.IsNullOrEmpty(XType))
                        aluminmu.Type = XType;
                    if (!string.IsNullOrEmpty(XNotes))
                        aluminmu.Notes = XNotes;
                    if (!string.IsNullOrEmpty(XStatus))
                        aluminmu.Status = XStatus;
                    if (!string.IsNullOrEmpty(Low))
                        aluminmu.Low = Convert.ToDouble(Low);
                    if (!string.IsNullOrEmpty(Avg))
                        aluminmu.Avg = Convert.ToDouble(Avg);
                    if (!string.IsNullOrEmpty(High))
                        aluminmu.High = Convert.ToDouble(High);
                    if (!string.IsNullOrEmpty(Len))
                        aluminmu.Length = Convert.ToDouble(Length);
                    bool Updated = aluminmu.Update();
                    if (Updated)
                    {
                        MessageBox.Show("تم تحديث البايانات بنجاح");
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

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            Number.Text = string.Empty;
            Section.Text = string.Empty;
            Category.Text = string.Empty;
            Status.Text = string.Empty;
            Type.Text = string.Empty;
            Notes.Text = string.Empty;
            LowWeight.Text = string.Empty;
            AvgWeight.Text = string.Empty;
            HighWeight.Text = string.Empty;
            Length.Text = string.Empty;
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
    }
}
