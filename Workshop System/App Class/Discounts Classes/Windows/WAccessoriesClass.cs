using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_System.App_Class.Discounts_Classes.Windows
{
    internal class WAccessoriesClass
    {
        public int DiscountID { get; set; }
        public int GlassID { get; set; }
        public string Name{ get; set; }
        public string Kind { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Area { get; set; }
        public int Number { get; set; }
        public float TotalPrice { get; set; }
        WindowsClass windowsClass = new WindowsClass();
        DataBase DB = new DataBase("Materials", "Glasses");
        DataBase XDB = new DataBase("Discounts", "Glasses");
        public WAccessoriesClass() { }
    }
}
