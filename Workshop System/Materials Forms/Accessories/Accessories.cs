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
using Workshop_System.Customers_Options;

namespace Workshop_System.Materials_Forms.Accessories
{
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }

        private void AddAccessorie_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add();
            NewForm.ShowDialog();
        }

        private void ModifyAccessorie_Click(object sender, EventArgs e)
        {
            Name NewForm = new Name();
            NewForm.ShowDialog();
        }

        private void RemoveAccessorie_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove();
            NewForm.ShowDialog();
        }

        private void ShowAccessorie_Click(object sender, EventArgs e)
        {
            ShowAccessiore NewForm = new ShowAccessiore();
            NewForm.ShowDialog();
        }

        private void ShowAccessories_Click(object sender, EventArgs e)
        {
            ShowAccessories NewForm = new ShowAccessories();
            NewForm.ShowDialog();
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            string Key = SearchInput.Text;
            AccessoriesClass accessoriesClass = new AccessoriesClass();
            DataTable dt = accessoriesClass.Search(Key);
            dt.Columns["ID"].ColumnName = "الرقم التعريفي";
            dt.Columns["Name"].ColumnName = "الاسم";
            dt.Columns["Size"].ColumnName = "المقاس";
            dt.Columns["Category"].ColumnName = "القسم";
            dt.Columns["Price"].ColumnName = "السعر";
            dt.Columns["Color"].ColumnName = "اللون";
            dt.Columns["LastEditDate"].ColumnName = "تاريخ اخر تعديل";
            dt.Columns["Section"].ColumnName = "الفرع";
            dt.Columns["Description"].ColumnName = "الوصف";
            SelectedAccessories.DataSource = dt;
        }

        private void SelectedAccessories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            SelectedID.Text = SelectedAccessories.Rows[index].Cells[0].Value.ToString();
        }

        private void CustomShow_Click(object sender, EventArgs e)
        {
            ShowAccessiore showAccessiore = new ShowAccessiore(Convert.ToString(SelectedID.Text));
            showAccessiore.ShowDialog();
        }

        private void CustomRemove_Click(object sender, EventArgs e)
        {
            Remove remove = new Remove(Convert.ToString(SelectedID.Text));
            remove.ShowDialog();
        }

        private void CustomEdit_Click(object sender, EventArgs e)
        {
            Name modify  =  new Name(Convert.ToString(SelectedID.Text));
            modify.ShowDialog();
        }

        private void Accessories_Load(object sender, EventArgs e)
        {

        }
    }
}
