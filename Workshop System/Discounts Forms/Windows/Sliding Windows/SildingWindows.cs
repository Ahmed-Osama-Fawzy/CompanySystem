﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_System.Discounts_Forms.Windows.Sliding_Windows
{
    public partial class Silding_Windows : Form
    {
        public Silding_Windows()
        {
            InitializeComponent();
        }

        private void AddWindow_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add();
            NewForm.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add();
            NewForm.ShowDialog();
        }
    }
}
