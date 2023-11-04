using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_System.App_Class.Offer_Prices
{
    internal class OfferPrice
    {
        public int ID{ get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public string CreatingDate { get; set; }
        public string ExpiredDate { get; set; }
        public float TotalPrice { get; set; }
        public int ItemsNumber { get; set; }
        public string Category { get; set; }
        public OfferPrice() { }
        public DataBase DB = new DataBase("OfferPrices", "MainTable");
        public bool Insert()
        {
            bool Inserted  = DB.Insert(
                 "UserID",$"{UserID}","true"
                ,"CustomerID",$"{CustomerID}","true"
                ,"CreatingDate",DateTime.Now.ToString(),"false"
                ,"ExpiredDate",DateTime.Now.AddDays(3).ToString(),"false"
                ,"TotalPrice","0","true"
                ,"ItemsNumber","0","true"
                ,"Category",Category,"false");
            return Inserted;
        }
        public int ReturnID()
        {
            DataTable dt = DB.CustomSelect("select top 1 ID from OfferPrices.MainTable order by ID desc");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ID = Convert.ToInt32(dr["ID"]);
            }
            else
            {
                ID = 0;
            }
            return ID;
        }
        public bool Increasing(int A , float B)
        {
            bool Increace1 = DB.CustomUpdate($"UPDATE OfferPrices.MainTable SET ItemsNumber = {A} WHERE ID = {ID}");
            bool Increace2 = DB.CustomUpdate($"UPDATE OfferPrices.MainTable SET TotalPrice = {B} WHERE ID = {ID}");
            if (Increace1 && Increace2) return true;
            return false;
        }
        public bool UpdateCustomrtID()
        {
            bool Updated = false;
            DataTable dt = DB.CustomSelect($"SELECT CustomerID FROM OfferPrices.MainTable WHERE ID = {ID}");
            if(dt.Rows.Count > 0 )
            {
                DataRow dr = dt.Rows[0];
                int customerid = int.Parse(dr["CustomerID"].ToString());
                bool up = DB.CustomUpdate($"UPDATE Persons.Customers SET OffersNum += 1 WHERE ID = {customerid}");
                if(up) Updated = true;
            }
            return Updated;
        }
    }
}
