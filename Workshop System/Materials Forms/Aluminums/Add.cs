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
        }
        public Add(int i)
        {
            InitializeComponent();
            ID.Text = i.ToString();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            AluminumClass a = new AluminumClass();
            a.Number = Number.Text;
            a.Section = Section.Text;
            a.Category = Category.Text;
            a.Status = Status.Text;
            a.Type = Type.Text;
            a.Notes = Notes.Text;
            if (!string.IsNullOrEmpty(LowWeight.Text))
               a.Low = Convert.ToDouble(LowWeight.Text);
            else
                a.Low = 0.0;
            if (!string.IsNullOrEmpty(AvgWeight.Text))
                a.Avg = Convert.ToDouble(AvgWeight.Text);
            else
                a.Avg = 0.0;
            if (!string.IsNullOrEmpty(HighWeight.Text))
                a.High = Convert.ToDouble(HighWeight.Text);
            else
                a.High = 0.0;
            if (!string.IsNullOrEmpty(Length.Text))
                a.Length = Convert.ToDouble(Length.Text);
            else
                a.Length = 0.0;
            if(!string.IsNullOrEmpty(a.Number)&&!string.IsNullOrEmpty(a.Section)&&!string.IsNullOrEmpty(a.Category)&&!string.IsNullOrEmpty(a.Status)&&!string.IsNullOrEmpty(a.Type)&&!string.IsNullOrEmpty(a.Notes)&& a.Low > 0.0 && a.Avg > 0.0 && a.High > 0.0 && a.Length > 0.0 ) 
            {
                bool S = a.Insert();
                if (S)
                {
                    MessageBox.Show("تمت الاضافة بنجاح");
                    Number.Text = string.Empty;
                    Section.Text = string.Empty;
                    Category.Text = string.Empty;
                    Type.Text = string.Empty;
                    Status.Text = string.Empty;
                    Notes.Text = string.Empty;
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
            Section.Text = string.Empty;
            Category.Text = string.Empty;
            Type.Text = string.Empty;
            Status.Text = string.Empty;
            Notes.Text = string.Empty;
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
        }
    }
}
