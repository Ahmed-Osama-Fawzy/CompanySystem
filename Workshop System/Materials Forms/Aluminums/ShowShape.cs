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

namespace Workshop_System.Materials_Forms.Aluminum
{
    public partial class ShowShape : Form
    {
        public ShowShape()
        {
            InitializeComponent();
        }
        public ShowShape(int i)
        {
            InitializeComponent();
            ID.Text = i.ToString();
        }
        private void Show_Click(object sender, EventArgs e)
        {
            AluminumClass aluminmu = new AluminumClass();
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id))
            {
                aluminmu.ID = Convert.ToInt32(id);
                DataTable dt = aluminmu.SelectOne();
                dt = aluminmu.SelectOne();
                if(dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Number.Text = Convert.ToString(dr["Number"]);
                    AName.Text = Convert.ToString(dr["Title"]);
                    Category.Text = Convert.ToString(dr["Category"]);
                    Section.Text = Convert.ToString(dr["Section"]);
                    Type.Text = Convert.ToString(dr["Type"]);
                    Description.Text = Convert.ToString(dr["Description"]);
                    LowW.Text = Convert.ToString(dr["LowWeight"]);
                    AvgW.Text = Convert.ToString(dr["AvgWeight"]);
                    HighW.Text = Convert.ToString(dr["HighWeight"]);
                    Length.Text = Convert.ToString(dr["Length"]);
                }
                else
                {
                    MessageBox.Show("عفوا هذا الرقم الكودي غير موجود");
                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل الرقم الكودي");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty; 
            Number.Text = string.Empty;
            AName.Text = string.Empty;
            Category.Text = string.Empty;
            Section.Text = string.Empty;
            Type.Text = string.Empty;
            Description.Text = string.Empty;
            LowW.Text = string.Empty;
            AvgW.Text = string.Empty;
            HighW.Text = string.Empty;
            Length.Text = string.Empty;
        }
    }
}
