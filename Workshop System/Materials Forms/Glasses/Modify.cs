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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }
        public Modify(int I)
        {
            InitializeComponent();
            ID.Text = I.ToString();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            string SID = ID.Text;
            string SColor = Color.Text;
            string SKind = Kind.Text;
            string SPrice = Price.Text;
            bool Checked = Default.Checked;
            string SDeep = Deep.Text;
            if(!string.IsNullOrEmpty(SID))
            {
                GlassesClass glasses = new GlassesClass();
                if (!string.IsNullOrEmpty(SID))
                {
                    glasses.ID = Convert.ToInt32(SID);
                    if(string.IsNullOrEmpty(SColor)&& string.IsNullOrEmpty(SKind)&& string.IsNullOrEmpty(SPrice) && !Checked)
                    {
                        MessageBox.Show("عفوا لا يوجد بيانات للتعديل, من فضلك ادخل بيانات");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(SColor))
                        {
                            glasses.Color = SColor;
                        }

                        if (!string.IsNullOrEmpty(SKind))
                        {
                            glasses.Kind = SKind;
                        }

                        if (!string.IsNullOrEmpty(SPrice))
                        {
                            glasses.Price = Convert.ToInt32(SPrice);
                        }

                        if (!string.IsNullOrEmpty(SDeep))
                        {
                            glasses.Deep = Convert.ToInt32(SDeep);
                        }

                        if (Checked)
                        {
                            glasses.Default = 1;
                        }

                        bool Editte = glasses.Modify();
                        if (Editte)
                        {
                            MessageBox.Show("تم تعديل البيانات بنجاح");
                            ID.Text = string.Empty;
                            Color.Text = string.Empty;
                            Price.Text = string.Empty;
                            Kind.Text = string.Empty;
                            Deep.Text = string.Empty;
                            Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("عفوا حدث خطا في العملية, حاول مرة اخري");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل الرقم الكودي اولا");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            Color.Text = string.Empty;
            Price.Text = string.Empty;
            Default.Checked = false;
            Kind.Text = string.Empty;
            Deep.Text = string.Empty;
        }
    }
}
