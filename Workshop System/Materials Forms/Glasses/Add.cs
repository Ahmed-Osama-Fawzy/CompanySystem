using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_System.App_Class;
using System.Windows.Forms;
using Workshop_System.Prices_Options.Glasses;

namespace Workshop_System.Prices_Options.Glasses
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string XColor = Color.Text;
            string XKind = Kind.Text;
            string XPrice = Price.Text;
            string XDeep = Deep.Text;
            bool Checked = Default.Checked;
            if(!string.IsNullOrEmpty(XColor) && !string.IsNullOrEmpty(XPrice))
            {
                GlassesClass glasses = new GlassesClass();
                glasses.Price = Convert.ToInt32(XPrice);
                glasses.Color = XColor;
                if (!string.IsNullOrEmpty(XKind))
                {
                    glasses.Kind = XKind;
                }
                else
                {
                    glasses.Kind = "NULL";
                }

                if (!string.IsNullOrEmpty(XDeep))
                {
                    glasses.Deep = Convert.ToInt32(XDeep);
                }
                else
                {
                    glasses.Deep = 0;
                }

                if (Checked)
                {
                    glasses.Default = 1;    
                }
                else
                {
                    glasses.SetNetPrice();
                }

                bool Added = glasses.Insert();
                if (Added)
                {
                    if(glasses.Default == 1)
                    {
                        if (glasses.UpdatePrices())
                        {
                            MessageBox.Show("تم اضافة النوع بنجاح");
                            Color.Text = string.Empty;
                            Price.Text = string.Empty;
                            Default.Checked = false;
                            Price.Text = string.Empty;
                            Kind.Text = string.Empty;
                            Deep.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم اضافة العنصر بنجاح 1");
                        }
                    }
                    else
                    {
                        MessageBox.Show("تم اضافة النوع بنجاح");
                        Color.Text = string.Empty;
                        Price.Text = string.Empty;
                        Default.Checked = false;
                        Price.Text = string.Empty;
                        Deep.Text = string.Empty;
                        Kind.Text = string.Empty;
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال البيانات كاملة");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Color.Text = string.Empty;
            Price.Text = string.Empty;
            Default.Checked = false;
            Price.Text = string.Empty;
            Kind.Text = string.Empty;
            Deep.Text = string.Empty;
        }
    }
}