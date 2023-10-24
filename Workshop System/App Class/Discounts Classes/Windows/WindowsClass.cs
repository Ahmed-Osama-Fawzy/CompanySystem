using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DataBase DB = new DataBase("Discounts", "MainTable");
        public WindowsClass() { }
        public int CheckDiscount()
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
                        )
                    {
                        ID = (int)dr["ID"];
                        MessageBox.Show($"{ID} done.....");
                        break;
                    }
                }
            }
            if(ID == 0)
            {
                Insert();
            }
            return 0;
        }
        public bool Insert()
        {
            bool Inserted = DB.Insert("Category", Category, "false"
                , "Section", Section, "false"
                , "Type", Type, "false"
                , "Description", Description, "false"
                , "Height", $"{Height}", "false"
                , "Width", $"{Width}", "false");
            return Inserted;
        }

    }
}
