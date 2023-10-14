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

namespace Workshop_System.Materials_Forms.Accessories
{
    public partial class ShowAccessories : Form
    {
        public ShowAccessories()
        {
            InitializeComponent();
            AccessoriesClass accessoriesClass = new AccessoriesClass();
            DataTable dt = accessoriesClass.ShowAll();
            dt.Columns["Name"].ColumnName = "الاسم";
            dt.Columns["Size"].ColumnName = "المقاس";
            dt.Columns["Status"].ColumnName = "الحالة";
            dt.Columns["Type"].ColumnName = "النوع";
            dt.Columns["Price"].ColumnName = "السعر";
            dt.Columns["Color"].ColumnName = "اللون";
            dt.Columns["Category"].ColumnName = "القسم";
            dt.Columns["ID"].ColumnName = "الرقم التعريفي";
            AllAccessories.DataSource = dt;
        }


        private void AllShapes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
