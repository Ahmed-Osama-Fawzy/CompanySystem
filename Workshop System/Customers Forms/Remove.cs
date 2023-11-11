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

namespace Workshop_System.Customers_Options
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
        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string Sid = ID.Text;
            if(!string.IsNullOrEmpty(Sid) ) 
            {
                int id = Convert.ToInt32(Sid);
                CustomerClass customer = new CustomerClass(id);
                ID.Text = string.Empty;
                DialogResult Result = MessageBox.Show("هل انت متاكد من حذف العميل نهائيا من قواعد البانات ", "رسالة تاكيدية", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    if (customer.Remove())
                    {
                        MessageBox.Show(" تم حذف البيانات بنجاح");
                        ID.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا يتعذر حذف البيانات");
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال الرقم الكودي اولأ ");
            }
        }
    }
}
