using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class.Discounts_Classes.Windows;
using Workshop_System.App_Class.Discounts_Classes;
using Workshop_System.Materials_Forms;

namespace Workshop_System.Discounts_Forms.Windows
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }
        public Modify(string S)
        {
            InitializeComponent();
            ID.Text = S;
        }
        public int DiscountID;
        private WAluminumClass AlumWindows = new WAluminumClass();
        private WAccessoriesClass AccessWindows = new WAccessoriesClass();
        private WGlassClass GlassWindows = new WGlassClass();
        private void AddDiscount_Click(object sender, EventArgs e)
        {
            string SID = ID.Text;
            string Height = MainHeight.Text;
            string Width = MainWidth.Text;
            if(!string.IsNullOrEmpty(SID) 
             &&!string.IsNullOrEmpty(Height)
             && !string.IsNullOrEmpty(Width))
            {
                DiscountID = int.Parse(SID);
                AlumWindows.DiscountID = DiscountID;
                AccessWindows.DiscountID = DiscountID;
                GlassWindows.DiscountID = DiscountID; 
                DataTable dt = AlumWindows.ReturnChooses();
                
                if (dt != null)
                {
                    AluminumTitle.DisplayMember = "Title";
                    AluminumTitle.ValueMember = "Title";
                    AluminumTitle.DataSource = dt;
                    AluminumTitle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد قطاعات لهذا النوع من فضلك ادخل القطاعات اولا ");
                }

                DataTable xdt = AccessWindows.ReturnChooses();
                if (dt != null)
                {
                    AccessorieTitle.DisplayMember = "Name";
                    AccessorieTitle.ValueMember = "Name";
                    AccessorieTitle.DataSource = xdt;
                    AccessorieTitle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد اكسسوارات لهذا النوع من فضلك ادخل اكسسوارات اولا ");
                }

                DataTable xxdt = GlassWindows.ReturnChooses();
                if (dt != null)
                {
                    GlassType.DisplayMember = "Color";
                    GlassType.ValueMember = "Color";
                    GlassType.DataSource = xxdt;
                    GlassType.Enabled = true;
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد زجاج من فضلك ادخل زجاج اولا ");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع المدخلات");
            }
        }
        private void AddAluminum_Click(object sender, EventArgs e)
        {
            string SAluminumTitle = AluminumTitle.Text;
            string SHeigetAdding = HeightAdding.Text;
            string SAluminumHeight = AluminumHeight.Text;
            string SHeightNumber = HeightNumber.Text;
            string SWidthAdding = WidthAdding.Text;
            string SAluminumWidth = AluminumWidth.Text;
            string SWidthNumber = WidthNumber.Text;
            if (!string.IsNullOrEmpty(SAluminumTitle))
            {
                AlumWindows.Title = SAluminumTitle;
                if(    !string.IsNullOrEmpty(SHeigetAdding)
                    || !string.IsNullOrEmpty(SHeightNumber)
                    || !string.IsNullOrEmpty(SWidthAdding)
                    || !string.IsNullOrEmpty(SWidthNumber)
                    || !string.IsNullOrEmpty(SAluminumHeight)
                    || !string.IsNullOrEmpty(SAluminumWidth))
                {
                    if (!string.IsNullOrEmpty(SHeigetAdding))
                        AlumWindows.AddingHeight = float.Parse(SHeigetAdding);
                    if (!string.IsNullOrEmpty(SWidthAdding))
                        AlumWindows.AddingWidth = float.Parse(SWidthAdding);
                    if (!string.IsNullOrEmpty(SHeightNumber))
                        AlumWindows.NHeight = int.Parse(SHeightNumber);
                    if (!string.IsNullOrEmpty(SWidthNumber))
                        AlumWindows.NWidth = int.Parse(SWidthNumber);
                    if (!string.IsNullOrEmpty(SAluminumHeight))
                        AlumWindows.Height = float.Parse(SAluminumHeight);
                    if (!string.IsNullOrEmpty(SAluminumWidth))
                        AlumWindows.Width = float.Parse(SAluminumWidth);
                    if (AlumWindows.Update())
                    {
                        MessageBox.Show("تم تحديث البيانات بنجاح");
                        AluminumTitle.SelectedItem = null;
                        HeightAdding.Text = string.Empty;
                        AluminumHeight.Text = string.Empty;
                        HeightNumber.Text = string.Empty;
                        WidthAdding.Text = string.Empty;
                        AluminumWidth.Text = string.Empty;
                        WidthNumber.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا لم يتم تحديث البيانات بنجاح");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال بيانات للتحديث");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب اختيار القطاع اولا");
            }
        }
        private void AddAccessorie_Click(object sender, EventArgs e)
        {
            string SAccessorieTitle = AccessorieTitle.Text;
            string SAccessorieNumber = AccessorieNumber.Text;
            string SAccessorieColor = AccessorieColor.Text;
            if (!string.IsNullOrEmpty(SAccessorieTitle))
            {
                AccessWindows.Name = SAccessorieTitle;
                if(!string.IsNullOrEmpty(SAccessorieNumber)
                || !string.IsNullOrEmpty(SAccessorieColor))
                {
                    AccessWindows.Amount = float.Parse(SAccessorieNumber);
                    AccessWindows.Color = SAccessorieColor;
                    if (AccessWindows.Update())
                    {
                        MessageBox.Show("تم تحديث البيانات بنجاح");
                        AccessorieTitle.SelectedItem = null;
                        AccessorieColor.Text = string.Empty;
                        AccessorieNumber.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("  عفوا لم يتم تحديث البيانات بنجاح");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال بيانات للتحديث");
                }
            }else
            {
                MessageBox.Show("عفوا يجب اختيار قطعة الاكسسوارات اولا");
            }
        }
        private void AddGlass_Click(object sender, EventArgs e)
        {
            string SGlassType = GlassType.Text;
            string SHeight = GlassHeight.Text;
            string SWidth = GlassWidth.Text;
            if (!string.IsNullOrEmpty(SGlassType))
            {
                GlassWindows.Name = SGlassType.Substring(0,SGlassType.IndexOf(','));
                if(!string.IsNullOrEmpty(SHeight)
                | !string.IsNullOrEmpty(SWidth))
                {
                    if (!string.IsNullOrEmpty(SHeight))
                        GlassWindows.Height = float.Parse(SHeight);
                    if (!string.IsNullOrEmpty(SWidth))
                        GlassWindows.Width = float.Parse(SWidth);
                    if (GlassWindows.Update())
                    {
                        MessageBox.Show("تم الاضافة بنجاح");
                        GlassType.SelectedItem = null;
                        GlassHeight.Text = string.Empty;
                        GlassWidth.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا لم يتم تحديث تخصيم الزجاج بنجاح");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال بيانات للتحديث اولا");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب اختيار نوع الزجاج اولا");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AluminumTitle.SelectedItem = null;
            HeightAdding.Text = string.Empty;
            AluminumHeight.Text = string.Empty;
            HeightNumber.Text = string.Empty;
            WidthAdding.Text = string.Empty;
            AluminumWidth.Text = string.Empty;
            WidthNumber.Text = string.Empty;
            AccessorieTitle.SelectedItem = null;
            AccessorieColor.Text = string.Empty;
            AccessorieNumber.Text = string.Empty;
            GlassType.SelectedItem = null;
            GlassHeight.Text = string.Empty;
            GlassWidth.Text = string.Empty;
        }
    }
}
