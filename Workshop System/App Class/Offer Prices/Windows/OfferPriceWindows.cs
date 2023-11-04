using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class.Discounts_Classes;
using Workshop_System.App_Class.Discounts_Classes.Windows;

namespace Workshop_System.App_Class.Offer_Prices.Windows
{
    internal class OfferPriceWindows
    {
        public int OfferID { get; set; }
        public int DiscountID { get; set; }
        public int RowNumber { get; set; }
        public string ItemDescription { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Area { get; set; }
        public int Number { get; set; }
        public float PFOne { get; set; }
        public float TPrice { get; set; }
        public float ALPrice { get; set; }
        public int Rolls { get; set; }
        public string GName { get; set; }
        public string GState { get; set; }
        public OfferPriceWindows() { }
        public DataBase DB = new DataBase("OfferPrices", "Windows");
        public OfferPrice offerprice = new OfferPrice();
        public WAluminumClass Aluminum = new WAluminumClass();
        public WAccessoriesClass Accessories = new WAccessoriesClass();
        public WGlassClass Glasses = new WGlassClass();
        public WindowsClass windowsclass = new WindowsClass();
        public void MakeItemDescritption()
        {
            Aluminum.DiscountID = Accessories.DiscountID = Glasses.DiscountID = DiscountID;
            windowsclass.ID = DiscountID;
            DataTable Aluminumdata = Aluminum.ReturnData();
            DataTable Accessoriesdata = Accessories.ReturnData();
            DataTable Glassesdata = Glasses.ReturnData();
            float AluminumPrice = 0;
            float AccessoriesPrice = 0;
            float GlassesPrice = 0;
            for(int i = 0;i <  Aluminumdata.Rows.Count;i++)
            {
                DataRow dr = Aluminumdata.Rows[i];
                float XHeight = float.Parse(Convert.ToString(dr["Height"]));
                float AddingHeight = float.Parse(Convert.ToString(dr["AddingHeight"]));
                float HeightNumber = float.Parse(Convert.ToString(dr["HNumber"]));
                float XWidth = float.Parse(Convert.ToString(dr["Width"]));
                float AddingWidth = float.Parse(Convert.ToString(dr["AddingWidth"]));
                float WidthNumber = float.Parse(Convert.ToString(dr["WNumber"]));
                float Length = float.Parse(Convert.ToString(dr["Length"]));
                float Weight = float.Parse(Convert.ToString(dr["HighWeight"]));
                AluminumPrice += ((((
                    (Height - XHeight)
                    +AddingHeight)
                    *HeightNumber)
                    / 100)
                    / Length)
                    * Weight
                    * ALPrice;
                AluminumPrice += (((((
                    (Width/Rolls) - XWidth) 
                    + AddingWidth) 
                    * WidthNumber) 
                    / 100)
                    / Length) 
                    * Weight 
                    * ALPrice;
            }
            for(int i = 0; i < Accessoriesdata.Rows.Count;i++)
            {
                DataRow dr = Accessoriesdata.Rows[i];
                float Amount = float.Parse(Convert.ToString(dr["Amount"]));
                float Price = float.Parse(Convert.ToString(dr["Price"]));
                AccessoriesPrice += Amount * Price;
            }
            for (int i = 0; i < Glassesdata.Rows.Count; i++)
            {
                DataRow dr = Glassesdata.Rows[i];
                float XHeight = float.Parse(Convert.ToString(dr["Height"]));
                float XWidth = float.Parse(Convert.ToString(dr["Width"]));
                float Price = float.Parse(Convert.ToString(dr["Price"]));
                float Number = float.Parse(Convert.ToString(dr["Number"]));
                GName = (string)dr["Name"];
                GlassesPrice += (((Height - XHeight)/100) * (((Width / Rolls) - XWidth))/100) * Number * Price;
            }
            float FullPrice = AluminumPrice + AccessoriesPrice + GlassesPrice;
            MessageBox.Show($"Total = {FullPrice} , Alum = {AluminumPrice} , Acces = {AccessoriesPrice} , Glass = {GlassesPrice} , Profit = {FullPrice*0.25}");
            PFOne = (float)(FullPrice + (FullPrice * 0.25));
            TPrice = PFOne * Number;
            windowsclass.ReturnData();
            ItemDescription = $"شباك {windowsclass.Section} ,نوع {windowsclass.Type} ,{Rolls} درفة, زجاج {GName} {GState} ,الوان دولية";
        }
        public bool Insert()
        {
            MakeItemDescritption();
            bool Inserted = DB.Insert(
                 "OfferID",$"{OfferID}","true"
                ,"RowNumber",$"{RowNumber}", "true"
                , "ItemDescription",ItemDescription,"false"
                ,"Height",$"{Height}","true"
                ,"Width",$"{Width}","true"
                ,"Area",$"{Area}","true"
                ,"Number",$"{Number}","true"
                ,"PFOne",$"{PFOne}","true"
                ,"TPrice",$"{TPrice}","true");
            offerprice.ID = OfferID;
            if (Inserted)
            {
               return true;
            }
            return false;
        }
        public DataTable GetData()
        {
            DataTable dt = DB.SelectOne("OfferID", $"{OfferID}", "true");
            return dt;
        }
        public bool GetRow(string RN)
        {
            DataTable dt = DB.MulitpeSelect("*", "OfferID", $"{OfferID}", "true", "RowNumber", $"{RN}", "true");
            if(dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                Height = float.Parse(dr["Height"].ToString());
                Width = float.Parse(dr["Width"].ToString());
                Number = int.Parse(dr["Number"].ToString());
                string[] X = dr["ItemDescription"].ToString().Split(',');
                string[] D = X[3].Substring(X[3].IndexOf(" ")).Split(' ');
                windowsclass.Section = X[0].Substring(X[0].IndexOf(" "));
                windowsclass.Description = X[1].Substring(X[1].IndexOf(" "));
                windowsclass.RollsNumber = int.Parse(X[2].Substring(0, 1));
                windowsclass.Type = D[2];
                GName = D[1];
                return true;
            }
            return false;
        }
        public bool Update()
        {
            MakeItemDescritption();
            bool Updated = DB.XUpdate(
                  "OfferID", $"{OfferID}", "true"
                , "RowNumber",$"{RowNumber}","true"
                , "Height",$"{Height}","true"
                , "Width",$"{Width}","true"
                , "Area",$"{Area}","true"
                , "Number",$"{Number}","true"
                , "PFOne",$"{PFOne}","true"
                , "TPrice",$"{TPrice}","true"
                , "ItemDescription",ItemDescription,"false");
            if (Updated) return true;
            else return false;
        }
        public bool Remove()
        {
            bool Removed = DB.CustomDelete($"DELETE FROM OfferPrices.Windows WHERE OfferID = {OfferID} AND RowNumber = {RowNumber}");
            return Removed;
        }
        public float TotalPrice()
        {
            DataTable dt = DB.CustomSelect($"SELECT SUM(TPrice) AS FullPrice FROM OfferPrices.Windows WHERE OfferID = {OfferID}");
            if(dt.Rows.Count > 0)
            { 
                DataRow dr = dt.Rows[0];
                return float.Parse(dr["FullPrice"].ToString());
            }
            return 0;
        }
        public int TotalItems()
        {
            DataTable dt = DB.CustomSelect($"SELECT COUNT(TPrice) AS ItemsNumber FROM OfferPrices.Windows WHERE OfferID = {OfferID}");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["ItemsNumber"].ToString());
            }
            return 0;
        }
    }
}
