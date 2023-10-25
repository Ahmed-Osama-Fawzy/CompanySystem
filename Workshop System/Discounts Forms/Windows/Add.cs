using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Workshop_System.App_Class;
using Workshop_System.Materials_Forms;
using Workshop_System.App_Class.Discounts_Classes;
using Workshop_System.App_Class.Discounts_Classes.Windows;

namespace Workshop_System.Discounts_Forms.Windows.Sliding_Windows
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            DataBase DB = new DataBase("", "");
            Section.DisplayMember = "Value";
            Section.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Section.DataSource = DB.GetData("فرع العمل"); Section.Enabled = true;
            }
            else
                Section.Enabled = false;
            Type.DisplayMember = "Value";
            Type.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Type.DataSource = DB.GetData("نوع العمل"); Type.Enabled = true;
            }
            else
                Type.Enabled = false;
            Description.DisplayMember = "Value";
            Description.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Description.DataSource = DB.GetData("وصف العمل"); Description.Enabled = true;
            }
            else
                Description.Enabled = false;

            RollsNumber.DisplayMember = "Value";
            RollsNumber.ValueMember = "Value";
            if (DB.GetData("عدد الدرفات") != null)
            {
                RollsNumber.DataSource = DB.GetData("عدد الدرفات"); RollsNumber.Enabled = true;
            }
            else
                RollsNumber.Enabled = false;
        }
        public int DiscountID;
        WindowsClass Window = new WindowsClass();
        WAluminumClass AlumWindows = new WAluminumClass();
        WAccessoriesClass AccessWindows = new WAccessoriesClass();
        WGlassClass GlassWindows = new WGlassClass();
        private void MainData_Click(object sender, EventArgs e)
        {
            string SSetion = Section.Text;
            string SType = Type.Text;
            string SDescription = Description.Text;
            string SRollNumber = RollsNumber.Text;
            string Height = MainHeight.Text;
            string Width = MainWidth.Text;
            if (!string.IsNullOrEmpty(SSetion)
                && !string.IsNullOrEmpty(SType)
                && !string.IsNullOrEmpty(SDescription)
                && !string.IsNullOrEmpty(SRollNumber)
                && !string.IsNullOrEmpty(Height)
                && !string.IsNullOrEmpty(Width))
            {
                Window.Category = "شبابيك";
                Window.Section = SSetion;
                Window.Type = SType;
                Window.Description = SDescription;
                Window.RollsNumber = Convert.ToInt32(SRollNumber);
                Window.Height = float.Parse(Height);
                Window.Width = float.Parse(Width);
                DiscountID = Window.ReturnID();
                if(DiscountID > 0)
                {
                    MessageBox.Show("تم الاضافة بنجاح");
                    AlumWindows.windowsClass = Window;
                    AlumWindows.DiscountID = DiscountID;
                    DataTable dt = AlumWindows.ReturnNames();
                    if(dt != null)
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

                    AccessWindows.windowsClass = Window;
                    AccessWindows.DiscountID = DiscountID;
                    DataTable xdt = AccessWindows.ReturnNames();
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

                    GlassWindows.windowsClass = Window;
                    GlassWindows.DiscountID = DiscountID;
                    DataTable xxdt = GlassWindows.ReturnNames();
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
                    if (Window.Insert())
                    {
                        DiscountID = Window.ReturnID();
                        MessageBox.Show("تم الاضافة بنجاح");
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع المدخلات اولا");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
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
            if(!string.IsNullOrEmpty(SAluminumTitle)
                && !string.IsNullOrEmpty(SHeigetAdding)
                && !string.IsNullOrEmpty(SHeightNumber)
                && !string.IsNullOrEmpty(SWidthNumber)
                && !string.IsNullOrEmpty(SWidthAdding)
                && !string.IsNullOrEmpty(SWidthNumber))
            {
                AlumWindows.Title = SAluminumTitle;
                if(AlumWindows.ReturnAluminumID())
                {
                    AlumWindows.Height = float.Parse(SAluminumHeight);
                    AlumWindows.Width = float.Parse(SAluminumWidth);
                    AlumWindows.AddingHeight = float.Parse(SHeigetAdding);
                    AlumWindows.AddingWidth = float.Parse(SWidthAdding);
                    AlumWindows.NHeight = int.Parse(SHeightNumber);
                    AlumWindows.NWidth = int.Parse(SWidthNumber);
                    if (AlumWindows.Insert())
                    {
                        MessageBox.Show("تم الاضافة بنجاح");
                        AluminumTitle.SelectedItem = null ;
                        HeightAdding.Text = string.Empty;
                        AluminumHeight.Text = string.Empty;
                        HeightNumber.Text = string.Empty;
                        WidthAdding.Text = string.Empty;
                        AluminumWidth.Text = string.Empty;
                        WidthNumber.Text = string.Empty;
                    }
                }
            }
        }
        private void AddAccessorie_Click(object sender, EventArgs e)
        {
            string SAccessorieTitle = AccessorieTitle.Text;
            string SAccessorieNumber = AccessorieNumber.Text;
            string SAccessorieColor = AccessorieColor.Text;
            if(    !string.IsNullOrEmpty(SAccessorieTitle)
                && !string.IsNullOrEmpty(SAccessorieNumber)
                && !string.IsNullOrEmpty(SAccessorieColor))
            {
                AccessWindows.Name = SAccessorieTitle;
                if (AccessWindows.ReturnAccessorieID())
                {
                    AccessWindows.Amount = float.Parse(SAccessorieNumber);
                    AccessWindows.Color = SAccessorieColor;
                    if (AccessWindows.Insert())
                    {
                        MessageBox.Show("تم الاضافة بنجاح");
                        AccessorieTitle.SelectedItem = null;
                        AccessorieColor.Text = string.Empty;
                        AccessorieNumber.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خطا ما");
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع المدخلات اولا");
            }
        }
        private void AddGlass_Click(object sender, EventArgs e)
        {
            string SGlassType = GlassType.Text;
            string SHeight = GlassHeight.Text;
            string SWidth = GlassWidth.Text;
            if(    !string.IsNullOrEmpty(SGlassType)
                && !string.IsNullOrEmpty(SHeight)
                && !string.IsNullOrEmpty(SWidth))
            {
                GlassWindows.Height = float.Parse(SHeight);
                GlassWindows.Width = float.Parse(SWidth);
                GlassWindows.Name = SGlassType.Substring(0, SGlassType.IndexOf(','));
                MessageBox.Show(GlassWindows.Name);
                GlassWindows.Kind = SGlassType.Substring(SGlassType.IndexOf(',') + 1);
                MessageBox.Show(GlassWindows.Kind);
                GlassWindows.GlassID = GlassWindows.ReturnGlassID();
                if (!GlassWindows.CheckDiscoutID() && GlassWindows.GlassID > 0)
                {
                    if (GlassWindows.Insert())
                    {
                        MessageBox.Show("تم الاضافة بنجاح");
                        GlassType.SelectedItem = null;
                        GlassHeight.Text = string.Empty;
                        GlassWidth.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("تم ادخال تخصيم الزجاج مسبقا");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات");
            }
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
