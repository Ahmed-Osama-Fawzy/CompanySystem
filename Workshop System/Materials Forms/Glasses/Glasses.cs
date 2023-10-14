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
    public partial class Glasses : Form
    {
        public Glasses()
        {
            InitializeComponent();
        }

        private void AddGlass_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add();
            NewForm.ShowDialog();
        }

        private void RemoveGlass_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove();
            NewForm.ShowDialog();
        }

        private void ShowGlass_Click(object sender, EventArgs e)
        {
            ShowGlass NewForm = new ShowGlass();
            NewForm.ShowDialog();
        }

        private void ModifyGlass_Click(object sender, EventArgs e)
        {
            Modify NewForm = new Modify();
            NewForm.ShowDialog();
        }

        private void ShowGlasses_Click(object sender, EventArgs e)
        {
            ShowGlasses NewForm = new ShowGlasses();
            NewForm.ShowDialog();
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            GlassesClass glasses = new GlassesClass();
            string S = SearchInput.Text.ToString();
            if (!string.IsNullOrEmpty(S))
            {
                DataTable dt = glasses.Search(S,"Color");
                dt.Columns["ID"].ColumnName = "الرقم التعريفي";
                dt.Columns["Color"].ColumnName = "اللون";
                dt.Columns["Price"].ColumnName = "السعر";
                dt.Columns["NetPrice"].ColumnName = "فرق السعر";
                dt.Columns["Kind"].ColumnName = "النوع";
                SelectedCustomers.DataSource = dt;
            }
        }

        private void SelectedCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            string SelectedId = SelectedCustomers.Rows[index].Cells[0].Value.ToString();
            SelectedID.Text = SelectedId;
        }

        private void CustomShow_Click(object sender, EventArgs e)
        {
            int Index = Convert.ToInt32(SelectedID.Text);
            ShowGlass NewForm = new ShowGlass(Index);
            NewForm.ShowDialog();
        }

        private void CustomRemove_Click(object sender, EventArgs e)
        {
            int Index = Convert.ToInt32(SelectedID.Text);
            Remove NewForm = new Remove(Index);
            NewForm.ShowDialog();
        }

        private void CustomEdit_Click(object sender, EventArgs e)
        {
            int Index = Convert.ToInt32(SelectedID.Text);
            Modify NewForm = new Modify(Index);
            NewForm.ShowDialog();
        }
    }
}
