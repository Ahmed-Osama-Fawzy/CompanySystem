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

namespace Workshop_System.Prices_Options.Addtions
{
    public partial class ShowBoard : Form
    {
        public ShowBoard()
        {
            InitializeComponent();
        }
        public ShowBoard(string S)
        {
            InitializeComponent();
            ID.Text = S;
        }
        private void Show_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id) )
            {
                BoardClass boardClass = new BoardClass();
                boardClass.ID = Convert.ToInt32(id);
                DataTable dt = boardClass.ShowOne();
                if(dt != null )
                {
                    DataRow dr = dt.Rows[0];
                    BName.Text = Convert.ToString(dr["Name"]);
                    Type.Text = Convert.ToString(dr["Type"]);
                    Color.Text = Convert.ToString(dr["Color"]);
                    Height.Text = Convert.ToString(dr["Height"]);
                    Width.Text = Convert.ToString(dr["Width"]);
                    Deep.Text = Convert.ToString(dr["Deep"]);
                    FPrice.Text = Convert.ToString(dr["FPrice"]);
                    MPrice.Text = Convert.ToString(dr["MPrice"]);
                    LastEditDate.Text = Convert.ToString(dr["LastEditDate"]);
                }
                else
                {
                    MessageBox.Show("عفوا هذا الرقم الكودي غير موجود");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال الرقم الكودي اولا");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            BName.Text = string.Empty;
            Type.Text = string.Empty;
            Color.Text = string.Empty;
            Height.Text = string.Empty;
            Width.Text = string.Empty;
            Deep.Text = string.Empty;
            FPrice.Text = string.Empty;
            MPrice.Text = string.Empty;
            LastEditDate.Text = string.Empty;
        }
    }
}
