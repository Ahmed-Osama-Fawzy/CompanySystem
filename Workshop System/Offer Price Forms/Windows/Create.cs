using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_System.Offer_Price_Forms.Windows
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }
        public Create(string S)
        {
            InitializeComponent();
            CustomerID.Text = S;
        }

        private void Sections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
