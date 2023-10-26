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
using Workshop_System.App_Class.Discounts_Classes;

namespace Workshop_System.Discounts_Forms.Windows
{
    public partial class ShowDiscounts : Form
    {
        public ShowDiscounts()
        {
            InitializeComponent();
            WindowsClass windowsClass = new WindowsClass();
            DataTable dt = new DataTable();
            dt = windowsClass.ShowAll();
            dt.Columns["ID"].ColumnName = "الرقم التعريفي";
            dt.Columns["Category"].ColumnName = "القسم";
            dt.Columns["Section"].ColumnName = "الفرع";
            dt.Columns["Description"].ColumnName = "الوصف";
            dt.Columns["Type"].ColumnName = "النوع";
            dt.Columns["Height"].ColumnName = "الارتفاع";
            dt.Columns["Width"].ColumnName = "العرض";
            dt.Columns["RollsNumber"].ColumnName = "عدد الدرفات";
            Discounts.DataSource = dt;
        }
    }
}
