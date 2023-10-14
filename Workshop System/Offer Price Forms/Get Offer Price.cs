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
using Workshop_System.Offer_Price_Forms.Windows;

namespace Workshop_System.Offer_Price_Forms
{
    public partial class Get_Offer_Price : Form
    {
        public Get_Offer_Price()
        {
            InitializeComponent();
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            CustomerClass customer = new CustomerClass();
            string S = SearchInput.Text;
            SelectedCustomers.DataSource = customer.Search(S);
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add();
            NewForm.ShowDialog();
        }

        private void SelectedCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectedCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            string Id = SelectedCustomers.Rows[index].Cells[0].Value.ToString();
            CustomerID.Text = Id;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CustomerID.Text = string.Empty;
            SearchInput.Text = string.Empty;
            Sections.Text = string.Empty;
        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            string id = CustomerID.Text;
            string Section = Sections.Text.ToString();
            if(!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(Section)) 
            {
                if (Section == "شبابيك")
                {
                    Create NewForm = new Create(id);
                    NewForm.ShowDialog();
                }
                else if (Section == "ابواب")
                {

                }
                else if(Section == "مطبخ")
                {

                }
                else if(Section == "تند")
                {

                }
                else if (Section == "شيش حصيرة")
                {

                }
                else if (Section == "وحدات منفصلة")
                {

                }
                else if (Section == "صيانة")
                {

                }
                else if (Section == "اخري")
                {

                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل جميع المدخلات, للانتقال الي الخطوت التالية");
            }
        }
    }
}
