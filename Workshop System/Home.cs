using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class;
using Workshop_System.Discounts_Forms;
using Workshop_System.Discounts_Forms.Windows.Sliding_Windows;
using Workshop_System.Offer_Price_Forms;

namespace Workshop_System
{
    public partial class Home : Form
    {
        private MainData maindata = new MainData();
        private void UpdateTime()
        {
            while (true)
            {
                Time.Text = maindata.CurrentTime;
                Thread.Sleep(1000);
            }
        }
        public Home()
        {
            InitializeComponent();
            Date.Text = maindata.CurrentDate;
            Title.Text = maindata.ArabicName;
            Day.Text = maindata.CurrentDay;
        }

        public Home(int ID , string Username)
        {
            InitializeComponent();
            Date.Text = maindata.CurrentDate;
            Title.Text = maindata.ArabicName;
            Day.Text = maindata.CurrentDay;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
