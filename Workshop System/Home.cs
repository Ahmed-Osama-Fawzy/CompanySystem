using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.Discounts_Forms;
using Workshop_System.Discounts_Forms.Windows.Sliding_Windows;
using Workshop_System.Offer_Price_Forms;

namespace Workshop_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.Date.DayOfWeek.ToString();
            label2.Text = DateTime.Now.Date.ToString();
        }

        public Home(int ID , string Username)
        {
            InitializeComponent();
            label1.Text = DateTime.Now.Date.DayOfWeek.ToString();
            label2.Text = DateTime.Now.Date.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Customers NewForm = new Customers();
            NewForm.ShowDialog();
        }

        private void Prices_Click(object sender, EventArgs e)
        {
            Materials NewForm = new Materials();
            NewForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetOfferPrice_Click(object sender, EventArgs e)
        {
            Get_Offer_Price NewForm = new Get_Offer_Price();
            NewForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Discounts NewFrom = new Discounts();
            NewFrom.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
