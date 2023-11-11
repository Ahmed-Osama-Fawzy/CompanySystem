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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }
        public Modify(string S)
        {
            InitializeComponent();
            ID.Text = S;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            string XFName = FName.Text.ToString();
            string XLName = LName.Text.ToString();
            string XAddress = Address.Text.ToString();
            string XMobile = Mobile.Text.ToString();
            string XEmail = Email.Text.ToString();
            string XWhatsapp = Whatsapp.Text.ToString();

            if (!string.IsNullOrEmpty(ID.Text)) 
            {
                if (string.IsNullOrEmpty(XEmail)&&string.IsNullOrWhiteSpace(XLName)&&string.IsNullOrWhiteSpace(XWhatsapp)&&string.IsNullOrEmpty(XMobile)&&string.IsNullOrEmpty(XAddress)&&string.IsNullOrEmpty(XFName))
                {
                    MessageBox.Show("عفوا لا يوجد بيانات للتحديث, برجاء ادخال البيانات");
                }
                else
                {
                    int id = Convert.ToInt32(ID.Text);
                    string S = "";
                    CustomerClass customer = new CustomerClass(id);
                    if (!string.IsNullOrEmpty(FName.Text)) { customer.FName = FName.Text; };
                    if (!string.IsNullOrEmpty(LName.Text)) { customer.LName = LName.Text; };
                    if (!string.IsNullOrEmpty(Mobile.Text) && Mobile.Text.Length == 11) 
                    { customer.Mobile = Mobile.Text; }
                    else { MessageBox.Show("عفوا يجب ادخال رقم هاتف مصري صالح"); S += "f"; };
                    if (!string.IsNullOrEmpty(Email.Text) && Email.Text.Contains("@") && Email.Text.Contains(".com")) { customer.Email = Email.Text; }
                    else { MessageBox.Show("عفوا يجب ادخال بريد الكتروني مصري "); S += "f"; };
                    if (!string.IsNullOrEmpty(Whatsapp.Text) && Whatsapp.Text.Length == 11) { customer.Whatsapp = Whatsapp.Text; }
                    else { MessageBox.Show("عفوا يجب ادخال رقم هاتف للواتس مصري صالح"); S += "f"; };
                    if (!string.IsNullOrEmpty(Address.Text)) { customer.Address = Address.Text; };
                    if (!S.Contains("f"))
                    {
                        if (customer.Modify())
                        {
                            MessageBox.Show("تم تحديث بيانات العميل بنجاح");
                            ID.Text = string.Empty;
                            FName.Text = string.Empty;
                            LName.Text = string.Empty;
                            Address.Text = string.Empty;
                            Email.Text = string.Empty;
                            Mobile.Text = string.Empty;
                            Whatsapp.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم تحديث البيانات بنجاح");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("برجاء ادخال الرقم الكودي للعميل");
            }
            
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            FName.Text = string.Empty;
            LName.Text = string.Empty;
            Address.Text = string.Empty;
            Email.Text = string.Empty;
            Mobile.Text = string.Empty;
            Whatsapp.Text = string.Empty;
            ID.Text = string.Empty;
        }
    }
}
