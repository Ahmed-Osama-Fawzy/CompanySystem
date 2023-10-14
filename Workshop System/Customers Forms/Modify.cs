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
                    CustomerClass customer = new CustomerClass(id);
                    if (!string.IsNullOrEmpty(FName.Text)) { customer.FName = FName.Text; };
                    if (!string.IsNullOrEmpty(LName.Text)) { customer.LName = LName.Text; };
                    if (!string.IsNullOrEmpty(Mobile.Text)) { customer.Mobile = Mobile.Text; };
                    if (!string.IsNullOrEmpty(Email.Text)) { customer.Email = Email.Text; };
                    if (!string.IsNullOrEmpty(Whatsapp.Text)) { customer.Whatsapp = Whatsapp.Text; };
                    if (!string.IsNullOrEmpty(Address.Text)) { customer.Address = Address.Text; };
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

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Whatsapp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
