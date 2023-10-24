using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.Discounts_Forms.Windows.Sliding_Windows;

namespace Workshop_System.Discounts_Forms
{
    public partial class Discounts : Form
    {
        public Discounts()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Silding_Windows NewForm = new Silding_Windows();
            NewForm.ShowDialog();
        }
    }
}
