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

namespace Workshop_System.Prices_Options.Glasses
{
    public partial class ShowGlass : Form
    {
        public ShowGlass()
        {
            InitializeComponent();
        }
        public ShowGlass(int I)
        {
            InitializeComponent();
            ID.Text = I.ToString();
        }
        private void Show_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID.Text))
            {
                Color.Text = string.Empty;
                Kind.Text = string.Empty;
                Price.Text = string.Empty;
                NetPrice.Text = string.Empty;
                Default.Text = string.Empty;
                Deep.Text = string.Empty;
                GlassesClass glassesClass = new GlassesClass(Convert.ToInt32(ID.Text));
                DataTable dt = glassesClass.ShowOne();
                if(dt.Rows.Count > 0 )
                {
                    DataRow dr = dt.Rows[0];
                    Color.Text = Convert.ToString(dr["Color"]);
                    Kind.Text = Convert.ToString(dr["Kind"]);
                    Price.Text = Convert.ToString(dr["Price"]);
                    NetPrice.Text = Convert.ToString(dr["NetPrice"]);
                    Deep.Text = Convert.ToString(dr["Deep"]);
                    if (Convert.ToString(dr["DefaultColor"]) == "1")
                    {
                        Default.Text = "YES";
                    }
                    else
                    {
                        Default.Text = "NO";
                    }
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد نوع زجاج بهذا الرقم الكودي");
                }
            }
            else
            {
                MessageBox.Show("يجب ادخال الرقم الكودي صحيح");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            Color.Text = string.Empty;
            Kind.Text = string.Empty;
            Price.Text = string.Empty;
            NetPrice.Text = string.Empty;
            Default.Text = string.Empty;
            Deep.Text = string.Empty;
        }
    }
}
