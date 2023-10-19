using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_System.App_Class
{
    internal class BoardClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Deep { get; set; }
        public float FPrice { get; set; }
        public float MPrice { get; set; }
        public DataBase DB = new DataBase("Materials", "Boards");

        public bool Insert()
        {
            bool Inserted = DB.Insert("Name", Name, "False", "Type", Type, "False", "Color", Color, "false", "Height", $"{Height}", "true", "Width",$"{Width}","true","Deep",$"{Deep}","true","FPrice",$"{FPrice}","true","MPrice",$"{MPrice}","true");
            return Inserted;
        }
        public bool Update()
        {
            string Updated = "";

            if (!string.IsNullOrEmpty(Name))
            {
                bool U = DB.Update("ID" , $"{ID}" , "true" , "Name", Name, "false");
                if (U) { Updated += "T"; }
                else { Updated += "F"; }
            }
            if (!string.IsNullOrEmpty(Type))
            {
                bool U = DB.Update("ID", $"{ID}", "true", "Type", Type, "false");
                if (U) { Updated += "T"; }
                else { Updated += "F"; }
            }
            if (!string.IsNullOrEmpty(Color))
            {
                bool U = DB.Update("ID", $"{ID}", "true", "Color", Color, "false");
                if (U) { Updated += "T"; }
                else { Updated += "F"; }
            }
            if (Height > 0)
            {
                bool U = DB.Update("ID", $"{ID}", "true", "Height", $"{Height}", "true");
                if (U) { Updated += "T"; }
                else { Updated += "F"; }
            }
            if (Width > 0)
            {
                bool U = DB.Update("ID", $"{ID}", "true", "Width", $"{Width}", "true");
                if (U) { Updated += "T"; }
                else { Updated += "F"; }
            }
            if (Deep > 0)
            {
                bool U = DB.Update("ID", $"{ID}", "true", "Deep", $"{Deep}", "true");
                if (U) { Updated += "T"; }
                else { Updated += "F"; }
            }
            if (FPrice > 0)
            {
                bool U = DB.Update("ID", $"{ID}", "true", "FPrice", $"{FPrice}", "true");
                if (U) { Updated += "T"; }
                else { Updated += "F"; }
            }
            if (MPrice > 0)
            {
                bool U = DB.Update("ID", $"{ID}", "true", "MPrice", $"{MPrice}", "true");
                if (U) { Updated += "T"; }
                else { Updated += "F"; }
            }
            if (!Updated.Contains("F")) { return true; }
            return false;
        }
        public bool Remove()
        {
            bool Removed = DB.Delete("ID", $"{ID}", "true", "all");
            return Removed;
        }
        public DataTable Search(string S)
        {
            DataTable dt = DB.SelectLike(S,"Name");
            return dt;
        }
        public DataTable ShowOne()
        {
            DataTable dt = DB.SelectOne("ID",$"{ID}","true");
            if(dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable ShowAll()
        {
            DataTable dt = DB.Select("all");
            return dt;
        }
    }
}
