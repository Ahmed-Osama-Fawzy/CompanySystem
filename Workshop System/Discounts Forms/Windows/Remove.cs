using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class.Discounts_Classes;

namespace Workshop_System.Discounts_Forms.Windows
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        public Remove(string S)
        {
            InitializeComponent();
            ID.Text = S;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من حذف التخصيم بالكامل","رسالة تاكيدية",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                string id = ID.Text;
                if (!string.IsNullOrEmpty(id))
                {
                    WindowsClass windowsClass = new WindowsClass();
                    windowsClass.ID = Convert.ToInt32(id);
                    if (windowsClass.Remove())
                    {
                        MessageBox.Show("تم حذف البيانات بنجاح");
                        ID.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا لم تتم عملية الحذف بنجاح");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال الرقم الكودي اولا ");
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
        }
    }
}
