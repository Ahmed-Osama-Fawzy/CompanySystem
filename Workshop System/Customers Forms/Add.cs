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
        private void Insert_Click(object sender, EventArgs e)
        {
            string XFName = FName.Text.ToString();
            string XLName = LName.Text.ToString();
            string XAddress = Address.Text.ToString();
            string XMobile = Mobile.Text.ToString();
            string XEmail = Email.Text.ToString();
            string XWhatsapp = Whatsapp.Text.ToString();
            if (!string.IsNullOrEmpty(XFName) && !string.IsNullOrEmpty(XLName) && !string.IsNullOrEmpty(XMobile) && !string.IsNullOrEmpty(XAddress))
            {
                if (string.IsNullOrEmpty(XEmail)){ XEmail = "NULL";
                    if (string.IsNullOrEmpty(XWhatsapp)){XWhatsapp = "NULL";}}
                CustomerClass customer = new CustomerClass(XFName, XLName, XAddress, XMobile, XWhatsapp, XEmail, 0, 0, 0, 0);
                if(XMobile.Length == 11)
                {
                    if (XWhatsapp.Length == 11 || XWhatsapp.Length == 3)
                    {
                        if (XEmail.Contains("@") && XEmail.Contains(".com") || XEmail.Equals("NULL"))
                        {
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
                        else
                        {
                            MessageBox.Show("عفوا يجب ادخال بريد الكتروني صالح");
                        }
                    }
                    else
                    {
                        MessageBox.Show("عفوا يجب ادخال رقم هاتف  صالح مصري");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال رقم هاتف صالح مصري");
                }
            }
            else
            { 
                MessageBox.Show("من فضلك ادخل جميع المدخلات");
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