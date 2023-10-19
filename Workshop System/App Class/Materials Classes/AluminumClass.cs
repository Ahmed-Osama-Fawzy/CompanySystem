using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.Customers_Options;

namespace Workshop_System.App_Class
{
    internal class AluminumClass
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public string Category { get; set; }
        public string Section { get; set; }
        public string Type { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public double Low { get; set; }
        public double Avg { get; set; }
        public double High { get; set; }
        public double Length { get; set; }
        public DataBase DB = new DataBase("Materials","Aluminum"); 
        public bool Insert()
        {
            bool Inserted = 
                DB.Insert("Number",Number,"False", "Category", Category,"False", "Title", Title,"False", "Section", Section , "False" , "Description", Description,"False", "Type", Type,"False","LowWeight",$"{Low}","True","AvgWeight",$"{Avg}","True","HighWeight",$"{High}", "True", "Length",$"{Length}","True");
            return Inserted;
        }
        public bool Update()
        {
            string S = "";
            if (!string.IsNullOrEmpty(Number))
            {
                bool Updated = DB.Update("ID", $"{ID}", "True","Number",Number,"False");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (!string.IsNullOrEmpty(Category))
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "Category", Category, "False");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (!string.IsNullOrEmpty(Section))
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "Section", Section, "False");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (!string.IsNullOrEmpty(Title))
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "Title", Title, "False");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (!string.IsNullOrEmpty(Type))
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "Type", Type, "False");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (!string.IsNullOrEmpty(Description))
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "Description", Description, "False");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (Low > 0.0)
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "LowWeight", $"{Low}", "True");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (Avg > 0.0)
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "AvgWeight", $"{Avg}", "True");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (High > 0.0)
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "HighWeight", $"{High}", "True");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (Length > 0.0)
            {
                bool Updated = DB.Update("ID", $"{ID}", "True", "Length", $"{Length}", "True");
                if (Updated)
                    S += "T";
                else
                    S += "F";
            }
            if (!S.Contains("F"))
            {
                return true;
            }
            return false;
        }
        public DataTable SelectOne()
        {
            DataTable dt = new DataTable();
            if(ID > 0)
            {
                dt = DB.SelectOne("ID", $"{this.ID}", "True");
            }
            else 
            {
                MessageBox.Show("حدث خطا");
            }
            return dt;
        }
        public bool Remove()
        {
            if(ID > 0)
            {
                if (DB.Delete("ID", $"{this.ID}", "True", "All"))
                {
                    return true;
                } 
            }
            else
            {
                MessageBox.Show("Error");
            }
            return false;
        }
        public DataTable SelectAll()
        {
            DataTable dt = DB.Select("All");
            return dt;
        }
        public DataTable Search(string S)
        {
            DataTable dt = DB.SelectLike(S,"Section");
            return dt;
        }
    }
}
