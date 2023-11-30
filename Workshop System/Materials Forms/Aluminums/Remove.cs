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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }
        public Remove(int i)
        {
            InitializeComponent();
            ID.Text = i.ToString();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            AluminumClass aluminmuClass = new AluminumClass();
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id) )
            {
                DialogResult Result = MessageBox.Show("هل انت متاكد من حذف هذه البايانات" , "تاكيد العملية" ,  MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    aluminmuClass.ID = Convert.ToInt32(id);
                    if (aluminmuClass.Remove())
                    {
                        MessageBox.Show("تم الحذف بنجاح");
                        ID.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا يوجد خطا في عملية الحذف");
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("يجب ادخال رالقم الكودي اولا");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
        }
    }
}
