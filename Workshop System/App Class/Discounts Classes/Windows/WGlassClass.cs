using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_System.App_Class.Discounts_Classes.Windows
{
    internal class WGlassClass
    {
        public WGlassClass() { }
        public int DiscountID { get; set; }
        public int GlassID { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Number { get; set; }
        public float Price { get; set; }
        public WindowsClass windowsClass = new WindowsClass();
        public DataBase DB = new DataBase("Materials", "Glasses");
        public DataBase XDB = new DataBase("Discounts", "Glasses");
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
    }
}
