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
    public partial class ShowGlasses : Form
    {
        public ShowGlasses()
        {
            InitializeComponent();
            GlassesClass glasses = new GlassesClass();
            DataTable dt = glasses.ShowAll();
            dt.Columns["Color"].ColumnName = "اللون";
            dt.Columns["ID"].ColumnName = "الرقم التعريفي";
            dt.Columns["Kind"].ColumnName = "النوع";
            dt.Columns["Price"].ColumnName = "السعر";
            dt.Columns["NetPrice"].ColumnName = "فرق السعر";
            AllGlasses.DataSource = dt;
        }

        private void AllGlasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
