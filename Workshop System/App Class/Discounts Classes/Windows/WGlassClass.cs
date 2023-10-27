using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_System.App_Class.Discounts_Classes.Windows
{
    internal class WGlassClass
    {
        public int DiscountID { get; set; }
        public int GlassID { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Number { get; set; }
        public float Price { get; set; }
        public WGlassClass() { }
        public DataBase DB = new DataBase("Materials", "Glasses");
        public DataBase XDB = new DataBase("Discounts", "Glasses");
        public WindowsClass windowsClass = new WindowsClass();
        public DataTable ReturnNames()
        {
            DataTable dt = DB.Select("Color", "Kind");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    dr["Color"] += $",{dr["Kind"]}";
                    
                }
                return dt;
            }
            return null;
        }
        public int ReturnGlassID()
        {
            DataTable dt = DB.MulitpeSelect("ID,Price","Color",Name,"false","Kind",Kind,"false");
            if(dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                GlassID = Convert.ToInt32(Convert.ToString(dr["ID"]));
                Price = float.Parse(Convert.ToString(dr["Price"]));
                return GlassID;
            }
            return 0;
        }
        public bool CheckDiscoutID()
        {
            DataTable dt = XDB.Select("DiscountID");
            for (int i = 0;i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if(DiscountID == Convert.ToInt32(dr["DiscountID"]))
                {
                    return true;
                }
            }
            return false;
        }
        public int CheckNumber()
        {
            if(windowsClass.Type == "دبل")
            {
                Number = Convert.ToInt32(windowsClass.RollsNumber*2);
            }
            else
            {
                Number = Convert.ToInt32(windowsClass.RollsNumber * 1);
            }
            return Number;
        }
        public bool Insert()
        {
            CheckNumber();
            bool Inserted = XDB.Insert(
                "DiscountID",$"{DiscountID}","true"
               ,"GlassID",$"{GlassID}","true"
               ,"Name",Name,"false"
               ,"Kind",Kind,"false"
               ,"Height",$"{Height}","true"
               ,"Width",$"{Width}","true"
               ,"Number",$"{Number}","true"
               ,"Price",$"{Price}","true");
            return Inserted;
        }
        public DataTable ReturnChooses()
        {
            DataTable dt = XDB.MulitpeSelect("Name,Kind", "DiscountID", $"{DiscountID}", "true");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    dr["Name"] += $",{dr["Kind"]}";

                }
                return dt;
            }
            return null;
        }
        public bool Update()
        {
            string Updated = "";
            if (Height > 0)
            {
                bool Up = XDB.XUpdate(
                    "DiscountID", $"{DiscountID}", "true"
                   , "Name", Name, "false"
                   , "Height", $"{Height}", "true");
                if (Up)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (Width > 0)
            {
                bool Up = XDB.XUpdate(
                    "DiscountID", $"{DiscountID}", "true"
                   , "Name", Name, "false"
                   , "Width", $"{Width}", "true");
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
            DataTable dt = XDB.SelectOne("DiscountID",$"{DiscountID}","true");
            return dt;
        }
    }
}
