using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class.Discounts_Classes;
using Workshop_System.App_Class.Discounts_Classes.Windows;

namespace Workshop_System.Discounts_Forms.Windows
{
    public partial class ShowDiscount : Form
    {
        public ShowDiscount()
        {
            InitializeComponent();
        }

        public ShowDiscount(string S)
        {
            InitializeComponent();
            ID.Text = S;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id)) 
            {
                WindowsClass windowsClass = new WindowsClass();
                WAluminumClass wAluminumClass = new WAluminumClass();
                WAccessoriesClass wAccessoriesClass = new WAccessoriesClass();
                WGlassClass wGlassClass = new WGlassClass();
                wAccessoriesClass.DiscountID = Convert.ToInt32(id); 
                wAluminumClass.DiscountID = Convert.ToInt32(id); 
                wGlassClass.DiscountID = Convert.ToInt32(id); 
                windowsClass.ID = Convert.ToInt32(id);
                DataTable dt;
                dt = wAluminumClass.Show();
                dt.Columns["DiscountID"].ColumnName = "الرقم التعريفي";
                dt.Columns["Title"].ColumnName = "اسم القطاع";
                dt.Columns["ALuminumID"].ColumnName = "رقم القطاع التعريفي";
                dt.Columns["Height"].ColumnName = "الارتفاع";
                dt.Columns["Width"].ColumnName = "العرض";
                dt.Columns["AddingHeight"].ColumnName = "زيادة الارتفاع";
                dt.Columns["AddingWidth"].ColumnName = "زيادة العرض";
                dt.Columns["HNumber"].ColumnName = "عدد الارتفاعات";
                dt.Columns["WNumber"].ColumnName = "عدد العوارض";
                dt.Columns["Length"].ColumnName = "طول العود";
                dt.Columns["LowWeight"].ColumnName = "الوزن الخفيف";
                dt.Columns["AvgWeight"].ColumnName = "الوزن المتوسط";
                dt.Columns["HighWeight"].ColumnName = "الوزن الثقيل";
                AluminumDiscounts.DataSource = dt;
                dt = wAccessoriesClass.Show();
                dt.Columns["DiscountID"].ColumnName = "الرقم التعريفي";
                dt.Columns["AccessorieID"].ColumnName = "رقم القطعة التعريفي";
                dt.Columns["Name"].ColumnName = "اسم القطعة";
                dt.Columns["Color"].ColumnName = "لون القطعة";
                dt.Columns["Amount"].ColumnName = "الكميو";
                dt.Columns["Price"].ColumnName = "سعر القطعة";
                AccessoriesDiscounts.DataSource = dt;
                dt = wGlassClass.Show();
                dt.Columns["DiscountID"].ColumnName = "الرقم التعريفي";
                dt.Columns["Price"].ColumnName = "سعر القطعة";
                dt.Columns["Name"].ColumnName = "لون الزجاج";
                dt.Columns["Height"].ColumnName = "الارتفاع";
                dt.Columns["Width"].ColumnName = "العرض";
                dt.Columns["Number"].ColumnName = "عدد القطع";
                dt.Columns["Kind"].ColumnName = "نوع الزجاج";
                dt.Columns["GlassID"].ColumnName = "رقم الزجاج التعريفي";
                GlassesDiscounts.DataSource = dt;
                dt = windowsClass.Show();
                if(dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Category.Text = Convert.ToString(dr["Category"]);
                    Section.Text = Convert.ToString(dr["Section"]);
                    Description.Text = Convert.ToString(dr["Description"]);
                    Type.Text = Convert.ToString(dr["Type"]);
                    RollsNumber.Text = Convert.ToString(dr["RollsNumber"]);
                }
                else
                {
                    MessageBox.Show("عفوا هذا الرقم الكودي غير موجود");
                }
            }
            else
            {
                MessageBox.Show("عغوا يجب ادخال الرقم الكودي اولا");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            Category.Text = string.Empty;
            Section.Text = string.Empty;
            Description.Text = string.Empty;
            Type.Text = string.Empty;
            RollsNumber.Text = string.Empty;
            AluminumDiscounts.DataSource = null;
            AccessoriesDiscounts.DataSource = null;
            GlassesDiscounts.DataSource= null;
        }

        private void ShowDiscount_Load(object sender, EventArgs e)
        {

        }
    }
}
