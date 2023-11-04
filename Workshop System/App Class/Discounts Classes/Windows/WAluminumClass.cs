using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

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
        public WAluminumClass() { }
        public DataBase DB = new DataBase("Materials", "Aluminum");
        public DataBase XDB = new DataBase("Discounts", "Aluminum");
        public WindowsClass windowsClass = new WindowsClass();
        public bool ReturnAluminumID()
        {
            DataTable dt = DB.MulitpeSelect("ID,LowWeight,AvgWeight,HighWeight,Length"
                ,"Category",windowsClass.Category,"false"
                ,"Section",windowsClass.Section,"false"
                ,"Description", windowsClass.Description,"false"
                ,"Type",windowsClass.Type,"false"
                ,"Title",Title,"false");
            if(dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                AluminumID = Convert.ToInt32(Convert.ToString(dr["ID"]));
                LowWeight = float.Parse(Convert.ToString(dr["LowWeight"]));
                AvgWeight = float.Parse(Convert.ToString(dr["AvgWeight"]));
                HighWeight = float.Parse(Convert.ToString(dr["HighWeight"]));
                Length = float.Parse(Convert.ToString(dr["Length"]));
            }
            if (AluminumID > 0)
                return true;
            return false;
        }
        public DataTable ReturnNames()
        {
            DataTable dt = DB.MulitpeSelect("Title"
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
                "AluminumID",$"{AluminumID}","true"
               ,"Title",Title,"false"
               ,"DiscountID",$"{DiscountID}","true"
               ,"Height",$"{Height}","true"
               ,"Width",$"{Width}","true"
               ,"AddingHeight",$"{AddingHeight}","true"
               ,"AddingWidth",$"{AddingWidth}","true"
               ,"HNumber",$"{NHeight}","true"
               ,"WNumber",$"{NWidth}","true"
               ,"LowWeight",$"{LowWeight}","true"
               ,"AvgWeight", $"{AvgWeight}", "true"
               ,"HighWeight", $"{HighWeight}", "true"
               ,"Length",$"{Length}","true");
            return Inserted;
        }
        public DataTable ReturnChooses()
        {
            DataTable dt = XDB.MulitpeSelect("Title", "DiscountID", $"{DiscountID}", "true");
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public bool Update()
        {
            string Updated = "";
            if (Height > 0)
            {
                bool Updateing = XDB.XUpdate(
                    "DiscountID",$"{DiscountID}","true"
                   ,"Title",Title,"false"
                   ,"Height",$"{Height}","true");
                if (Updateing)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (Width > 0)
            {
                bool Updateing = XDB.XUpdate(
                    "DiscountID", $"{DiscountID}", "true"
                   , "Title", Title, "false"
                   , "Width", $"{Width}", "true");
                if (Updateing)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (AddingHeight > 0)
            {
                bool Updateing = XDB.XUpdate(
                     "DiscountID", $"{DiscountID}", "true"
                   , "Title", Title, "false"
                   , "AddingHeight", $"{AddingHeight}", "true");
                if (Updateing)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (AddingWidth > 0)
            {
                bool Updateing = XDB.XUpdate(
                     "DiscountID", $"{DiscountID}", "true"
                   , "Title", Title, "false"
                   , "AddingWidth", $"{AddingWidth}", "true");
                if (Updateing)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (NHeight > 0)
            {
                bool Updateing = XDB.XUpdate(
                     "DiscountID", $"{DiscountID}", "true"
                   , "Title", Title, "false"
                   , "HNumber", $"{NHeight}", "true");
                if (Updateing)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (NWidth > 0)
            {
                bool Updateing = XDB.XUpdate(
                     "DiscountID", $"{DiscountID}", "true"
                   , "Title", Title, "false"
                   , "WNumber", $"{NWidth}", "true");
                if (Updateing)
                    Updated += "t";
                else
                    Updated += "f";
            }
            if (Updated.Contains("f"))
                return false;
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
            DataTable dt = XDB.SelectOne("DiscountID", $"{DiscountID}", "true");
            if (dt.Rows.Count > 0)
                return dt;
            else return null;
        }
    }
}
