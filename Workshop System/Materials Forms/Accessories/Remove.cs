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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }
        public Remove(string i)
        {
            InitializeComponent();
            ID.Text = i;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id))
            {
                AccessoriesClass accessoriesClass = new AccessoriesClass();
                accessoriesClass.ID = Convert.ToInt32(id);
                DialogResult Result = MessageBox.Show("هل انت متاكد من حذف البانات", "رسالة تاكيدية" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Result == DialogResult.Yes)
                {
                    if (accessoriesClass.Delete())
                    {
                        MessageBox.Show("تم الحذف بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("عفوا لم يتم حذف البيانات");
                    }
                }
                else
                {

                }
                ID.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("يجب ادخال الرقم الكودي اولا");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
