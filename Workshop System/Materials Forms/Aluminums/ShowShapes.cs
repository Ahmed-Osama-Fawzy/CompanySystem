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
    public partial class Show_Shapes : Form
    {
        public Show_Shapes()
        {
            InitializeComponent();
            AluminumClass aluminmuClass = new AluminumClass();
            DataTable dt = aluminmuClass.SelectAll();
            dt.Columns["Number"].ColumnName = "الرقم";
            dt.Columns["Title"].ColumnName = "الكنية";
            dt.Columns["Description"].ColumnName = "الوصف";
            dt.Columns["Type"].ColumnName = "النوع";
            dt.Columns["Category"].ColumnName = "القسم";
            dt.Columns["ID"].ColumnName = "الرقم التعريفي";
            dt.Columns["Section"].ColumnName = "الفرع";
            dt.Columns["LowWeight"].ColumnName = "الوزن الخفيف";
            dt.Columns["AvgWeight"].ColumnName = "الوزن المتوسط";
            dt.Columns["HighWeight"].ColumnName = "الوزن الثقيل";
            dt.Columns["Length"].ColumnName = "الطول";
            AllShapes.DataSource = dt;
        }

        private void AllShapes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Show_Shapes_Load(object sender, EventArgs e)
        {
             
        }
    }
}
