using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_System.App_Class.Discounts_Classes.Windows
{
    internal class WAluminumClass
    {
        public int DiscountID { get; set; }
        public int AluminumID { get; set; }
        public string Title { get; set; }
        public float Height { get; set; }
        public int NHeight  { get; set; }
        public float AddingHeight { get; set; }
        public float Width { get; set; }
        public int NWidth { get; set; }
        public float AddingWidth { get; set; }
        //public float TotalWidth { get; set; }
        //public float Price { get; set; }
        //public float TotalLength { get; set; }
        //public float TotalPrice { get; set; }
        //public float TotalHeight { get; set; }
        public float Length { get; set; }
        public float LowWeight { get; set; }
        public float AvgWeight { get; set; }
        public float HighWeight { get; set; }
        public WindowsClass windowsClass = new WindowsClass();
        public DataBase DB = new DataBase("Materials","Aluminum");
        public DataBase XDB = new DataBase("Discounts", "Aluminum");
        public WAluminumClass() {}
    }
}
