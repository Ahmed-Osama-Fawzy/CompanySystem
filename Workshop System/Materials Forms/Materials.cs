﻿using System;
using System.Windows.Forms;
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

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Glasses_Click(object sender, EventArgs e)
        {
            Glasses NewForm = new Glasses();
            NewForm.ShowDialog();
        }
        private void Addtions_Click(object sender, EventArgs e)
        {
            Addtions NewForm = new Addtions();
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
    }
}
