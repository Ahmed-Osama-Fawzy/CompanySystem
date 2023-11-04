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
using Workshop_System.App_Class.Offer_Prices;
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
            string customerid = CustomerID.Text;
            string Section = Sections.Text.ToString();
            if(!string.IsNullOrEmpty(customerid) && !string.IsNullOrEmpty(Section)) 
            {
                OfferPrice offerprice = new OfferPrice();
                offerprice.UserID = 1;
                offerprice.CustomerID = Convert.ToInt32(customerid);
                if (Section == "شبابيك")
                {
                    offerprice.Category = "شبابيك";
                    if (offerprice.Insert())
                    {
                        int OfferID = offerprice.ReturnID();
                        if(OfferID > 0)
                        {
                            WindowsOfferPrice NewForm = new WindowsOfferPrice(OfferID);
                            NewForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("يوجد خطا ما");
                        }
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خطا ما");
                    }
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

        private void Get_Offer_Price_Load(object sender, EventArgs e)
        {

        }
    }
}
