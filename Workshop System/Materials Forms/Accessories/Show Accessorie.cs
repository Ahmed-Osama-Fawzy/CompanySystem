using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Workshop_System.App_Class;

namespace Workshop_System.Materials_Forms.Accessories
{
    public partial class ShowAccessiore : Form
    {
        public ShowAccessiore()
        {
            InitializeComponent();
        }
        public ShowAccessiore(string i)
        {
            InitializeComponent();
            ID.Text = i;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id))
            {
                AccessoriesClass accessoriesClass = new AccessoriesClass();
                accessoriesClass.ID = Convert.ToInt32(id);
                DataTable dt = accessoriesClass.ShowOne();
                if(dt != null)
                {
                    DataRow dr = dt.Rows[0];
                    Number.Text = Convert.ToString(dr["ID"]);
                    Title.Text = Convert.ToString(dr["Name"]);
                    Size.Text = Convert.ToString(dr["Size"]);
                    Category.Text = Convert.ToString(dr["Category"]);
                    Section.Text = Convert.ToString(dr["Section"]);
                    Price.Text = Convert.ToString(dr["Price"]);
                    Color.Text = Convert.ToString(dr["Color"]);
                    Type.Text = Convert.ToString(dr["Type"]);
                    Description.Text = Convert.ToString(dr["Description"]);
                }


            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال الرقم الكودي");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            Title.Text = string.Empty;
            Size.Text = string.Empty;
            Category.Text = string.Empty;
            Price.Text = string.Empty;
            Color.Text = string.Empty;
            Type.Text = string.Empty;
            Description.Text = string.Empty;
            Section.Text = string.Empty;

        }

        private void ShowAccessiore_Load(object sender, EventArgs e)
        {

        }
    }
}
