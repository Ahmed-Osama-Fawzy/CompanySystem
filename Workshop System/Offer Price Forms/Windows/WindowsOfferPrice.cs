using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Workshop_System.App_Class;
using Workshop_System.Materials_Forms;

namespace Workshop_System.Offer_Price_Forms.Windows
{
    public partial class WindowsOfferPrice : Form
    {
        public WindowsOfferPrice()
        {
            InitializeComponent();
            Update();
        }
        public WindowsOfferPrice(string S)
        {
            InitializeComponent();
            CustomerID.Text = S;
            Update();
        }
        public void Update()
        {
            DataBase DB = new DataBase("Materials", "Types");
            Section.DisplayMember = "Value";
            Section.ValueMember = "Value";
            if (DB.GetData("فرع العمل") != null)
            {
                Section.DataSource = DB.GetData("فرع العمل"); Section.Enabled = true;
            }
            else
                Section.Enabled = false;

            Type.DisplayMember = "Value";
            Type.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Type.DataSource = DB.GetData("نوع العمل"); Type.Enabled = true;
            }
            else
                Type.Enabled = false;

            
            Desciption.DisplayMember = "Value";
            Desciption.ValueMember = "Value";
            if (DB.GetData("وصف العمل") != null)
            {
                Desciption.DataSource = DB.GetData("وصف العمل"); Desciption.Enabled = true;
            }
            else
                Desciption.Enabled = false;

            RollsNumber.DisplayMember = "Value";
            RollsNumber.ValueMember = "Value";
            if (DB.GetData("عدد الدرفات") != null)
            {
                RollsNumber.DataSource = DB.GetData("عدد الدرفات"); RollsNumber.Enabled = true;
            }
            else
                RollsNumber.Enabled = false;
        }

        private void Sections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void Details_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
            Update();
        }

        private void Desciption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddWindow_Click(object sender, EventArgs e)
        {
            string SHeight = Height.Text;
            string SWidth = Width.Text;
            string SNumber = Number.Text;
            string SSection = Section.Text;
            string SType = Type.Text;
            string SDescription = Desciption.Text;
            string SRollsNumber  = RollsNumber.Text;
            string SCategory = "شبابيك";
            if (!string.IsNullOrEmpty(SHeight)
                && !string.IsNullOrEmpty(SWidth)
                && !string.IsNullOrEmpty(SNumber)
                && !string.IsNullOrEmpty(SSection)
                && !string.IsNullOrEmpty(SType)
                && !string.IsNullOrEmpty(SDescription)
                && !string.IsNullOrEmpty(SRollsNumber))
            {

            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات المطلوبة ");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Height.Text = string.Empty;
            Width.Text = string.Empty;
            Number.Text = string.Empty;
            Section.SelectedItem = null;
            Type.SelectedItem = null;
            Desciption.SelectedItem = null;
            RollsNumber.SelectedItem = null;
        }
    }
}
