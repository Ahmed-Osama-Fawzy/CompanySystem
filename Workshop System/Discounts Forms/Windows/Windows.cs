using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class.Discounts_Classes;

namespace Workshop_System.Discounts_Forms.Windows.Sliding_Windows
{
    public partial class Silding_Windows : Form
    {
        public Silding_Windows()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add();
            NewForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modify NewForm = new Modify();
            NewForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove();
            NewForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowDiscounts NewForm = new ShowDiscounts();
            NewForm.ShowDialog();
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            WindowsClass windowsClass = new WindowsClass();
            string S = SearchInput.Text;
            DataTable dt = windowsClass.Search(S);
            dt.Columns["ID"].ColumnName = "الرقم التعريفي";
            dt.Columns["Category"].ColumnName = "القسم";
            dt.Columns["Section"].ColumnName = "الفرع";
            dt.Columns["Description"].ColumnName = "الوصف";
            dt.Columns["Type"].ColumnName = "النوع";
            dt.Columns["Height"].ColumnName = "الارتفاع";
            dt.Columns["Width"].ColumnName = "العرض";
            dt.Columns["RollsNumber"].ColumnName = "عدد الدرفات";
            SelectedDiscounts.DataSource = dt;
        }
        private void SelectedDiscounts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            SelectedID.Text = SelectedDiscounts.Rows[index].Cells[0].Value.ToString();
        }

        private void CustomShow_Click(object sender, EventArgs e)
        {
            ShowDiscount NewForm = new ShowDiscount(SelectedID.Text);
            NewForm.ShowDialog();
        }

        private void CustomRemove_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove(SelectedID.Text);
            NewForm.ShowDialog();
        }

        private void CustomEdit_Click(object sender, EventArgs e)
        {
            Modify NewForm = new Modify(SelectedID.Text);
            NewForm.ShowDialog();
        }

        private void Silding_Windows_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowDiscount NewForm = new ShowDiscount();
            NewForm.ShowDialog();
        }
    }
}
