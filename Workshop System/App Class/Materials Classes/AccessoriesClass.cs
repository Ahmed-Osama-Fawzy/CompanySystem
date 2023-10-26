using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_System.App_Class
{
    internal class AccessoriesClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Size { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }
        public string Section { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DataBase DB = new DataBase("Materials", "Accessories");
        public bool Insert()
        {
            if (DB.Insert("Name", Name, "False", "Size", $"{Size}", "Ture", "Category", Category, "False", "Price", $"{Price}", "True", "Color", Color, "False","Section",Section,"false","Description",Description,"false" , "Type",Type,"false"))
            {
                return true;
            }
            else return false;
        }
        public bool Modify()
        {
            if(ID > 0)
            {
                string A = "";
                if (!string.IsNullOrEmpty(Name))
                {
                    bool Update = DB.Update("ID",$"{ID}","True","Name",Name,"false");
                    if (Update)
                        A += "T";
                    else
                        A += "F";
                }
                if (!string.IsNullOrEmpty(Category))
                {
                    bool Update =  DB.Update("ID", $"{ID}", "True", "Category", Category, "false");
                    if (Update)
                        A += "T";
                    else
                        A += "F";
                }
                if (Size > 0)
                {
                    bool Update =  DB.Update("ID", $"{ID}", "True", "Size", $"{Size}", "true");
                    if (Update)
                        A += "T";
                    else
                        A += "F";
                }
                if (Price > 0)
                {
                    bool Update =  DB.Update("ID", $"{ID}", "True", "Size", $"{Price}", "true");
                    if (Update)
                        A += "T";
                    else
                        A += "F";
                }
                if (!string.IsNullOrEmpty(Color))
                {
                    bool Update = DB.Update("ID", $"{ID}", "True", "Color", Color, "false");
                    if (Update)
                        A += "T";
                    else
                        A += "F";
                }
                if (!string.IsNullOrEmpty(Section))
                {
                    bool Update = DB.Update("ID", $"{ID}", "True", "Section", Section, "false");
                    if (Update)
                        A += "T";
                    else
                        A += "F";
                }
                if (!string.IsNullOrEmpty(Description))
                {
                    bool Update =  DB.Update("ID", $"{ID}", "True", "Description", Description, "false");
                    if (Update)
                        A += "T";
                    else
                        A += "F";
                }
                if (!string.IsNullOrEmpty(Type))
                {
                    bool Update = DB.Update("ID", $"{ID}", "True", "Type", Type, "false");
                    if (Update)
                        A += "T";
                    else
                        A += "F";
                }
                if (!A.Contains("F"))
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("عفوا حدث خطا ");
            }
            return false;
        }
        public bool Delete()
        {
            if(ID > 0)
            {
                bool Del = DB.Delete("ID", $"{ID}", "True");
                if (Del)
                    return true;
            }
            else
            {
                MessageBox.Show("عفوا حدث خطا ");
            }
            return false;
        }
        public DataTable ShowOne()
        {
            if(ID > 0)
            {
                DataTable dt = DB.SelectOne("ID",$"{ID}","True");
                if (dt.Rows.Count > 0)
                    return dt;
                else
                    MessageBox.Show("عفوا حدث خطا");
            }
            return null;
        }
        public DataTable ShowAll()
        {
            DataTable dt = DB.Select("All");
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable Search(string S)
        {
            DataTable dt = DB.SelectLike(S,"Name");
            return dt;
        }
    }
}
