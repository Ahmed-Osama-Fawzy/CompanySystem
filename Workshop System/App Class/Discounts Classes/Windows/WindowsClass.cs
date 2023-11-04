using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class.Discounts_Classes.Windows;
using Workshop_System.Discounts_Forms;

namespace Workshop_System.App_Class.Discounts_Classes
{
    internal class WindowsClass
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Section { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int RollsNumber { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public WindowsClass() { }
        private DataBase DB = new DataBase("Discounts","MainTable");
        public int ReturnID()
        {
            DataTable dt = DB.Select("all");
            if(dt.Rows.Count > 0 )
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (Convert.ToString(dr["Category"]) == Category
                        && Convert.ToString(dr["Section"]) == Section
                        && Convert.ToString(dr["Type"]) == Type 
                        && Convert.ToString(dr["Description"]) == Description
                        && Convert.ToInt32(dr["RollsNumber"]) == RollsNumber
                        )
                    {
                        ID = Convert.ToInt32(dr["ID"]);
                        return ID;
                    }
                }
            }
            return 0;
        }
        public bool Insert()
        {
            bool Inserted = DB.Insert
                ("Category", Category, "false"
                , "Section", Section, "false"
                , "Type", Type, "false"
                , "Description", Description, "false"
                , "RollsNumber", $"{RollsNumber}", "true"
                , "Height", $"{Height}", "true"
                , "Width", $"{Width}", "true");
            return Inserted;
        }
        public bool Remove()
        {
            WAluminumClass Al = new WAluminumClass();
            WAccessoriesClass Ac = new WAccessoriesClass();
            WGlassClass Gl = new WGlassClass();
            Al.DiscountID = Ac.DiscountID = Gl.DiscountID = ID;
            Gl.Remove();
            Ac.Remove();
            Al.Remove();
            bool Deleted = DB.Delete("ID", $"{ID}", "true");
            return Deleted;
        }
        public DataTable ShowAll()
        {
            DataTable dt = DB.Select("all");
            return dt;
        }
        public DataTable Show()
        {
            DataTable dt = DB.SelectOne("ID", $"{ID}", "true");
            return dt;
        }
        public DataTable Search(string s)
        {
            DataTable dt = DB.SelectLike(s, "Section");
            return dt;
        }
        public void ReturnData()
        {
            DataTable dt = DB.SelectOne("ID",$"{ID}","true");
            if(dt != null)
            {
                DataRow dr = dt.Rows[0];
                Category = Convert.ToString(dr["Category"]);
                Section = Convert.ToString(dr["Section"]);
                Description = Convert.ToString(dr["Description"]);
                Type = Convert.ToString(dr["Type"]);
            }
        }
    }
}
