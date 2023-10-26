using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.Prices_Options.Glasses;

namespace Workshop_System.App_Class
{
    internal class GlassesClass
    {
        public int ID { get; set; }
        public string Color { get; set; }
        public string Kind { get; set; }
        public int Price { get; set; }
        public int NetPrice { get; set; }
        public int Default { get; set; }
        public int Deep { get; set; }
        public DataBase DB = new DataBase("Materials", "Glasses");

        public GlassesClass() { }
        public GlassesClass(int ID) 
        {
            this.ID = ID;
        }
        public bool Insert()
        {
            bool Inserted;
            if (this.Default == 1) {
                DB.UpdateAll("DefaultColor", "NULL", "True");
                Inserted = DB.Insert("Color", this.Color, "False", "Price", $"{this.Price}", "True", "NetPrice", "0", "True", "Kind", this.Kind, "False", "DefaultColor", $"{this.Default}", "True","Deep",$"{this.Deep}","True");
            }
            else
            {
                Inserted = DB.Insert("Color", this.Color, "False", "Price", $"{this.Price}", "True", "NetPrice", $"{this.NetPrice}", "True", "Kind", this.Kind, "False" , "DefaultColor", "NULL", "True" , "Deep", $"{this.Deep}", "True");
            }
            return Inserted;
        }
        public bool SetNetPrice()
        {
            bool Setted = false;
            if (!string.IsNullOrEmpty(Convert.ToString(this.Price))) 
            {
                DataTable dt = DB.CustomSelect("SELECT Price FROM PricesPart.Glasses WHERE DefaultColor = 1");
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    int Price = Convert.ToInt32(dr["Price"]);
                    this.NetPrice = this.Price - Price;
                    Setted = true;
                }
                else
                {
                    MessageBox.Show("يجب تعيين قيمة افتراضية اولا");
                }
            }
            return Setted;
        }
        public bool UpdatePrices()
        {
            bool Updated = false;
            DataTable dt = DB.Select("All");
            if(dt.Rows.Count == 0)
            {
                return true;
            }
            if (this.Default == 1)
            {
                Updated = DB.CustomUpdate($"UPDATE PricesPart.Glasses SET NetPrice = Price - (SELECT Price FROM PricesPart.Glasses WHERE DefaultColor = 1)");
            }
            return Updated;
        }
        public bool Remove()
        {
            bool Removed = false;
            DataTable dt = DB.SelectOne("ID", $"{this.ID}", "True", "DefaultColor");
            if(dt.Rows.Count > 0) 
            {
                DataRow dr = dt.Rows[0];
                string Val = Convert.ToString(dr["DefaultColor"]);
                if (Val == "1")
                {
                    MessageBox.Show("عفوا لا يمكن حذف النوع لانه النوع الافتراضي , يجب تعيين نوع اخر لحذف ذلك");
                }
                else
                {
                    Removed = DB.Delete("ID", $"{this.ID}", "True","all");
                    if (Removed) 
                    {
                        MessageBox.Show("تم الحذف بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("عفوا هذا الرقم الكودي غير موجود");
                    }
                }
            }
            return Removed;
        }
        public DataTable ShowOne()
        {
            DataTable dt = DB.SelectOne("ID",$"{this.ID}","True");
            return dt;
        }
        public bool Modify()
        {
            bool XModified = false;
            string S = "";
            if (!string.IsNullOrEmpty(this.Color))
            {
                bool Modified = DB.Update("ID", $"{this.ID}", "True", "Color", this.Color, "False");
                if (Modified) { S += "T"; }
                else { S += "F"; }
            }
            if (!string.IsNullOrEmpty(this.Kind))
            {
                bool Modified = DB.Update("ID", $"{this.ID}", "True", "Kind", this.Kind, "False");
                if (Modified) { S += "T"; }
                else { S += "F"; }
            }

            if (this.Price > 0)
            {
                bool Modified = DB.Update("ID", $"{this.ID}", "True", "Price", $"{this.Price}","True");
                bool M = SetNetPrice();
                bool XM = DB.Update("ID", $"{this.ID}", "True", "NetPrice", $"{this.NetPrice}", "True");
                DataTable Selectd = DB.SelectOne("ID", $"{this.ID}", "True", "DefaultColor");
                if (Selectd.Rows.Count > 0)
                {
                    DataRow dr = Selectd.Rows[0];
                    string V = Convert.ToString(dr["DefaultColor"]);
                    if (V == "1")
                    {
                        this.Default = 1;
                        bool MM = UpdatePrices();
                        if (Modified == true && M == true && XM == true && MM == true) { S += "T"; }
                        else { S += "F"; }
                    }
                    else
                    {
                        if (Modified == true && M == true && XM == true) { S += "T"; }
                        else { S += "F"; }
                    }
                }
                else
                {
                    MessageBox.Show("عفوا هذا الرقم الكودي غير موجود");
                    return false;
                }
            }
            if (this.Deep > 0)
            {
                bool Modified = DB.Update("ID", $"{this.ID}", "True", "Deep", $"{this.Deep}", "True");
                if (Modified) { S += "T"; }
                else { S += "F"; }
            }

            if (this.Default == 1)
            {
                bool XM = DB.UpdateAll("DefaultColor", "NULL", "True");
                bool Modified = DB.Update("ID", $"{this.ID}", "True", "DefaultColor", "1", "True");
                bool M = UpdatePrices();
                if (Modified == true && XM == true && M == true) { S += "T"; }
                else { S += "F"; }
            }

            if (!S.Contains("F"))
            {
                XModified = true;
            }
            return XModified;
        }
        public DataTable ShowAll()
        {
            DataTable dt = DB.Select("all");
            return dt;
        }
        public DataTable Search(string S , string C)
        {
            DataTable dt = DB.SelectLike(S,C);
            return dt;
        }
    }
}
