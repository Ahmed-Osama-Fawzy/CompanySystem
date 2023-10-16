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

namespace Workshop_System.Materials_Forms
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string SCategory = Category.Text;
            string SValue = Value.Text;
            if(!string.IsNullOrEmpty(SCategory) && !string.IsNullOrEmpty(SValue))
            {
                DataBase DB = new DataBase("Materials", "Types");
                bool Inserted = DB.Insert("Category" , SCategory , "false","Value" , SValue , "false");
                if (Inserted) 
                {
                    MessageBox.Show("تم الاضافة بنجاح");
                    Category.Text = string.Empty;
                    Value.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("عفوا حدضث خطا");
                }
            }
            else
            {
                MessageBox.Show("‘فوا يجب ادخال المعلومات كاملة");
            }
        }
    }
}
