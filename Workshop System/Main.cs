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

namespace Workshop_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Password.UseSystemPasswordChar = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void ForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword NewForm = new ForgetPassword();
            NewForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string XUsername = Username.Text;
            string XPassword = Password.Text;
            string BranchNum = BranchID.Text;
            if (!string.IsNullOrEmpty(XUsername) && !string.IsNullOrEmpty(XPassword) &&  !string.IsNullOrEmpty(BranchNum))
            {
                loginClass Object = new loginClass();
                Object.Username = XUsername;
                Object.Password = XPassword;
                Object.BranchID = Convert.ToInt32(BranchNum);
                if (Object.SearchAccount())
                {
                    Username.Text = "";
                    Password.Text = "";
                    BranchID.Text = "";
                    Home NewForm = new Home();
                    NewForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("عذرا يوجد خطا في المدخلات , من فضلك حاول مرة اخري");
                }
            }
            else 
            {
                MessageBox.Show("عذرا يجب ادخال المدخلات كاملة , من فضلك حاول مرة اخري");
            }
        }
    }
}
