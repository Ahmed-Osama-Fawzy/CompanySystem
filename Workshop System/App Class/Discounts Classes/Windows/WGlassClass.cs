using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_System.App_Class.Discounts_Classes.Windows
{
    internal class WGlassClass
    {
        public int DiscountID { get; set; }
        public int AccessorieID { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public string Color { get; set; }
        public float TotalPrice { get; set; }
        WindowsClass windowsClass = new WindowsClass();
        DataBase DB = new DataBase("Materials","Accessories");
        DataBase XDB = new DataBase("Discounts","Accessories");
        public WGlassClass() { }
    }
}
