using System;
using System.Windows.Forms;
using Workshop_System.Materials_Forms;
using Workshop_System.Materials_Forms.Accessories;
using Workshop_System.Materials_Forms.Aluminum;
using Workshop_System.Prices_Options.Addtions;
using Workshop_System.Prices_Options.Glasses;

namespace Workshop_System
{
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }
        private void Glasses_Click(object sender, EventArgs e)
        {
            Glasses NewForm = new Glasses();
            NewForm.ShowDialog();
        }
        private void Addtions_Click(object sender, EventArgs e)
        {
            Boards NewForm = new Boards();
            NewForm.ShowDialog();
        }
        private void Aluminum_Click(object sender, EventArgs e)
        {
            Aluminum NewForm = new Aluminum();
            NewForm.ShowDialog();
        }
        private void Accessories_Click(object sender, EventArgs e)
        {
            Accessories NewForm = new Accessories();
            NewForm.ShowDialog();
        }
        private void Details_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
        }
    }
}
