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

namespace Workshop_System.Prices_Options.Addtions
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
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id))
            {
                DialogResult = MessageBox.Show("هل انت متاكد من حذف هذه البيانات" , "رسالة تاكيدية" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if(DialogResult == DialogResult.Yes)
                {
                    BoardClass boardClass = new BoardClass();
                    boardClass.ID = Convert.ToInt32(id);
                    if (boardClass.Remove())
                    {
                        MessageBox.Show("تم حذف البيانات بنجاح");
                        ID.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خطا في الحذف");
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال الرقم الكودي اولا");
            }
        }

        private void Remove_Load(object sender, EventArgs e)
        {

        }
    }
}
