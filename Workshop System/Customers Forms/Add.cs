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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string XFName = FName.Text.ToString();
            string XLName = LName.Text.ToString();
            string XAddress = Address.Text.ToString();
            string XMobile = Mobile.Text.ToString();
            string XEmail = Email.Text.ToString();
            string XWhatsapp = Whatsapp.Text.ToString();
            if (string.IsNullOrEmpty(XFName) || string.IsNullOrEmpty(XLName) || string.IsNullOrEmpty(XMobile) ||string.IsNullOrEmpty(XAddress))
            {
                MessageBox.Show("من فضلك ادخل جميع المدخلات");
            }
            else
            {
                if (string.IsNullOrEmpty(XEmail))
                {
                    XEmail = "NULL";
                    if (string.IsNullOrEmpty(XWhatsapp))
                    {
                        XWhatsapp = "NULL";
                    }
                }
                CustomerClass customer = new CustomerClass(XFName, XLName, XAddress, XMobile, XWhatsapp, XEmail, 0, 0, 0, 0);
                if (customer.Insert())
                {
                    MessageBox.Show("تم اضافة العميل بنجاح");
                    FName.Text = "";
                    LName.Text = "";
                    Address.Text = "";
                    Email.Text = "";
                    Mobile.Text = "";
                    Whatsapp.Text = "";
                }
                else
                {
                    MessageBox.Show("لم يتم اضافة البيانات بنجاح");
                }
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FName.Text = "";
            LName.Text = "";
            Address.Text = "";
            Email.Text = "";
            Mobile.Text = "";
            Whatsapp.Text = "";
        }
    }
}
