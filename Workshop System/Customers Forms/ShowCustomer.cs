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
    public partial class ShowCustomer : Form
    {
        public ShowCustomer()
        {
            InitializeComponent();
        }

        public ShowCustomer(string S)
        {
            InitializeComponent();
            ID.Text = S;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string Sid = ID.Text.ToString();
            if (!string.IsNullOrEmpty(Sid))
            {
                int id = Convert.ToInt32(ID.Text);
                CustomerClass customer = new CustomerClass(id);
                DataTable dt = new DataTable();
                dt = customer.ShowOne();
                if(dt.Rows.Count > 0)
                {
                    DataRow theRow = dt.Rows[0];
                    FName.Text = (string)theRow["FName"];
                    LName.Text = (string)theRow["LName"];
                    Mobile.Text = (string)theRow["Mobile"];
                    Address.Text = (string)theRow["Address"];
                    Email.Text = (string)theRow["Email"];
                    Whatsapp.Text = (string)theRow["Whatsapp"];
                    Status.Text = Convert.ToString(theRow["Status"]);
                    IndextionsNum.Text = Convert.ToString(theRow["IndextionsNum"]);
                    WorksNum.Text = Convert.ToString(theRow["WorksNum"]);
                    OffersNum.Text = Convert.ToString(theRow["OffersNum"]);
                }
                else
                {
                    MessageBox.Show("عفوا هذا الرقم الكودي غير صحيح");
                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل الرقم الكودي اولا");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Clear();
            FName.Clear();
            LName.Clear();
            Mobile.Clear();
            Address.Clear();
            Email.Clear();
            Whatsapp.Clear();
            Status.Clear();
            IndextionsNum.Clear();
            WorksNum.Clear();
            OffersNum.Clear();
        }
    }
}
