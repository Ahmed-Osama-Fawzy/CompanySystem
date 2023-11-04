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
        public WAccessoriesClass() { }
        public DataBase DB = new DataBase("Materials", "Accessories");
        public DataBase XDB = new DataBase("Discounts", "Accessories");
        public WindowsClass windowsClass = new WindowsClass();
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
               ,"Price",$"{Price}","true");
            return Inserted;
        }
        public DataTable ReturnChooses()
        {
            DataTable dt = XDB.MulitpeSelect("Name", "DiscountID", $"{DiscountID}", "true");
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public bool Update() 
        {
            string Updated = "";
            if(Amount > 0)
            {
                bool Up = XDB.XUpdate(
                    "DiscountID",$"{DiscountID}","true"
                   ,"Name",Name,"false"
                   ,"Amount",$"{Amount}","true");
                if (Up)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (!string.IsNullOrEmpty(Color))
            {
                bool Up = XDB.XUpdate(
                    "DiscountID", $"{DiscountID}", "true"
                   , "Name", Name, "false"
                   , "Color", Color , "false");
                if (Up)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (Updated.Contains("f"))
                return false;
            else
                return true;
        }
        public bool Remove()
        {
            bool Deleted = XDB.Delete("DiscountID", $"{DiscountID}", "true");
            return Deleted;
        }
        public DataTable Show()
        {
            DataTable dt = XDB.SelectOne("DiscountID", $"{DiscountID}", "true");
            return dt;
        }
        public DataTable ReturnData()
        {
            DataTable dt = XDB.SelectOne("DiscountID",$"{DiscountID}","true");
            if (dt.Rows.Count > 0)
                return dt;
            else return null;
        }
    }
}
