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

namespace Workshop_System.Prices_Options.Addtions
{
    public partial class ShowBoards : Form
    {
        public ShowBoards()
        {
            InitializeComponent();
            BoardClass boardClass = new BoardClass();
            DataTable dt = boardClass.ShowAll();
            dt.Columns["Color"].ColumnName = "اللون";
            dt.Columns["Name"].ColumnName = "الاسم";
            dt.Columns["Type"].ColumnName = "النوع";
            dt.Columns["Height"].ColumnName = "الارتفاع";
            dt.Columns["Width"].ColumnName = "العرض";
            dt.Columns["Deep"].ColumnName = "السمك";
            dt.Columns["FPrice"].ColumnName = "سعر الللوح";
            dt.Columns["MPrice"].ColumnName = "سعر المتر";
            dt.Columns["LastEditDate"].ColumnName = "تاريخ اخر تعديل";
            AllBoards.DataSource = dt;

        }
    }
}
