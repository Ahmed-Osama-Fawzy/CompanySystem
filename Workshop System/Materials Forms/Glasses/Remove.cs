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

namespace Workshop_System.Prices_Options.Glasses
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }
        public Remove(int I)
        {
            InitializeComponent();
            ID.Text = I.ToString();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ID.Text)) 
            {
                DialogResult Result = MessageBox.Show("هل انت متاكد من حذف بيانات النوع؟", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    GlassesClass glassesClass = new GlassesClass(Convert.ToInt32(ID.Text));
                    glassesClass.Remove();
                    ID.Text = string.Empty;
                }
                else
                {
                    ID.Text = string.Empty;
                }
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
    }
}
