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
        public DataBase DB = new DataBase("Discounts","MainTable");
        public WAluminumClass Al = new WAluminumClass();
        public WAccessoriesClass Ac = new WAccessoriesClass();
        public WGlassClass Gl = new WGlassClass();
        public WindowsClass() { }
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
            Al.DiscountID = Ac.DiscountID = Gl.DiscountID = ID;
            if(Gl.Remove() && Ac.Remove() && Al.Remove())
            {
                bool Deleted = DB.Delete("ID", $"{ID}", "true");
                return Deleted;
            }
            return false;
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
    }
}
