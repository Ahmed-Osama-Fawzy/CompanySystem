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
    public partial class ShowCustomers : Form
    {
        public ShowCustomers()
        {
            InitializeComponent();
            CustomerClass customer = new CustomerClass();
            DataTable dt = new DataTable();
            dt = customer.ShowAll();
            dt.Columns["ID"].ColumnName = "الرقم التعريفي";
            dt.Columns["FName"].ColumnName = "الاسم الاول";
            dt.Columns["LName"].ColumnName = "الاسم الاخير";
            dt.Columns["Address"].ColumnName = "العنوان";
            dt.Columns["Mobile"].ColumnName = "رقم الهاتف";
            dt.Columns["Whatsapp"].ColumnName = "رقم الواتس";
            dt.Columns["IndextionsNum"].ColumnName = "عدد المقايسات";
            dt.Columns["WorksNum"].ColumnName = "عدد الاعمال";
            dt.Columns["OffersNum"].ColumnName = "عدد عروض السعر";
            dt.Columns["Status"].ColumnName = "الحالة";
            dt.Columns["Email"].ColumnName = "البريد الالكتروني";
            AllCustomers.DataSource = dt;
        }

        private void AllCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
