using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_System.Materials_Forms.Aluminum;

namespace Workshop_System.App_Class.Discounts_Classes.Windows
{
    internal class WAccessoriesClass
    {
        public int DiscountID { get; set; }
        public int AccessorieID { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }
        public WindowsClass windowsClass = new WindowsClass();
        DataBase DB = new DataBase("Materials", "Accessories");
        DataBase XDB = new DataBase("Discounts", "Accessories");
        public bool ReturnAccessorieID()
        {
            DataTable dt = DB.MulitpeSelect("ID,Price"
                , "Name", Name, "false"
                , "Category", windowsClass.Category, "false"
                , "Section", windowsClass.Section, "false"
                , "Description", windowsClass.Description, "false"
                , "Type", windowsClass.Type, "false");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                AccessorieID = Convert.ToInt32(Convert.ToString(dr["ID"]));
                Price = float.Parse(Convert.ToString(dr["Price"]));
            }
            if (AccessorieID > 0)
                return true;
            return false;
        }
        public DataTable ReturnNames()
        {
            DataTable dt = DB.MulitpeSelect("Name"
                , "Category", windowsClass.Category, "false"
                , "Section", windowsClass.Section, "false"
                , "Description", windowsClass.Description, "false"
                , "Type", windowsClass.Type, "false"
                );
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public bool Insert()
        {
            bool Inserted = XDB.Insert(
                "DiscountID",$"{DiscountID}","true"
               ,"AccessorieID",$"{AccessorieID}","true"
               ,"Name",Name,"false"
               ,"Amount",$"{Amount}","true"
               ,"Color",Color,"false"
               ,"TotalPrice",$"{Price*Amount}","true");
            return Inserted;
        }
    }
}
