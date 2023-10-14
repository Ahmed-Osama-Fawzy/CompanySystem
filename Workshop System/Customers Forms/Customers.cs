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
using Workshop_System.Customers_Options;

namespace Workshop_System
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add();
            NewForm.ShowDialog();
        }

        private void ModifyCustomer_Click(object sender, EventArgs e)
        {
            Modify NewForm = new Modify();
            NewForm.ShowDialog();
        }

        private void RemoveCustomer_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove();
            NewForm.ShowDialog();
        }

        private void ShowCustomer_Click(object sender, EventArgs e)
        {
            ShowCustomer NewForm = new ShowCustomer();
            NewForm.ShowDialog();
        }

        private void ShowCustomers_Click(object sender, EventArgs e)
        {
            ShowCustomers NewForm = new ShowCustomers();
            NewForm.ShowDialog();
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            CustomerClass customer = new CustomerClass();
            string S = SearchInput.Text.ToString();
            if (!string.IsNullOrEmpty(S))
            {
                DataTable dt = customer.Search(S);
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
                SelectedCustomers.DataSource = dt;
            }
        }

        private void SelectedCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            string SelectedId = SelectedCustomers.Rows[index].Cells[0].Value.ToString();
            SelectedID.Text = SelectedId;
        }

        private void CustomShow_Click(object sender, EventArgs e)
        {
            ShowCustomer NewForm = new ShowCustomer(SelectedID.Text);
            NewForm.ShowDialog();
        }

        private void SelectedCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomRemove_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove(SelectedID.Text);
            NewForm.ShowDialog();
        }

        private void CustomEdit_Click(object sender, EventArgs e)
        {
            Modify NewForm = new Modify(SelectedID.Text);
            NewForm.ShowDialog();
        }

        private void SelectedID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
