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
    public partial class Aluminum : Form
    {
        public Aluminum()
        {
            InitializeComponent();
        }
        private void AddShape_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add();
            NewForm.ShowDialog();
        }
        private void ModifyShape_Click(object sender, EventArgs e)
        {
            Modify NewForm = new Modify();
            NewForm.ShowDialog();
        }
        private void RemoveShape_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove();
            NewForm.ShowDialog();
        }
        private void ShowShape_Click(object sender, EventArgs e)
        {
            ShowShape NewForm = new ShowShape();
            NewForm.ShowDialog();
        }
        private void ShowShapes_Click(object sender, EventArgs e)
        {
            Show_Shapes NewForm = new Show_Shapes();
            NewForm.ShowDialog();
        }
        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            string String = SearchInput.Text;
            AluminumClass aluminmuClass = new AluminumClass();
            DataTable dt = aluminmuClass.Search(String);
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
            SelectedShapes.DataSource = dt;
        }
        private void SelectedShapes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            SelectedID.Text = Convert.ToString(SelectedShapes.Rows[index].Cells[0].Value);
        }
        private void CustomShow_Click(object sender, EventArgs e)
        {
            ShowShape NewForm = new ShowShape(Convert.ToInt32(SelectedID.Text));
            NewForm.ShowDialog();
        }
        private void CustomRemove_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove(Convert.ToInt32(SelectedID.Text));
            NewForm.ShowDialog();
        }
        private void CustomEdit_Click(object sender, EventArgs e)
        {
            Modify NewForm = new Modify(Convert.ToInt32(SelectedID.Text));
            NewForm.ShowDialog();
        }
    }
}
