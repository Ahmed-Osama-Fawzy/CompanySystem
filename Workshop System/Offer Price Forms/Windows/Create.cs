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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            Update();
        }
        public Create(string S)
        {
            InitializeComponent();
            CustomerID.Text = S;
            Update();
        }
        public void Update()
        {
            DataBase DB = new DataBase("Materials", "Type");
            Section.DisplayMember = "Value";
            Section.ValueMember = "Value";
            if (DB.GetData("") != null)
            {
                Section.DataSource = DB.GetData(""); Section.Enabled = true;
            }
            else
                Section.Enabled = false;

            Category.DisplayMember = "Value";
            Category.ValueMember = "Value";
            if (DB.GetData("") != null)
            {
                Category.DataSource = DB.GetData(""); Category.Enabled = true;
            }
            else
                Category.Enabled = false;

            
            GlassesStatus.DisplayMember = "Value";
            GlassesStatus.ValueMember = "Value";
            if (DB.GetData("") != null)
            {
                GlassesStatus.DataSource = DB.GetData(""); GlassesStatus.Enabled = true;
            }
            else
                GlassesStatus.Enabled = false;
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
    }
}
