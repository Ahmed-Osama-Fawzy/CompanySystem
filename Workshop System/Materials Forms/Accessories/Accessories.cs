using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Modify NewForm = new Modify();
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
    }
}
