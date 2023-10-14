using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_System.App_Class
{
    internal class CustomerClass
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public int OffersNum { get; set; }
        public int IndextionsNum { get; set; }
        public int WorksNum { get; set; }
        public int Status { get; set; }

        public CustomerClass() { }
        public CustomerClass(int ID)
        {
            this.ID = ID;
        }
        public CustomerClass(string fName, string lName, string address, string mobile, string whatsapp, string email, int offersNum, int indextionsNum, int worksNum, int status)
        {
            FName = fName;
            LName = lName;
            Address = address;
            Mobile = mobile;
            Whatsapp = whatsapp;
            Email = email;
            OffersNum = offersNum;
            IndextionsNum = indextionsNum;
            WorksNum = worksNum;
            Status = status;
        }
        public DataBase DB = new DataBase("Persons", "Customers");
        public bool Insert()
        {
            
            bool Inserted = DB.Insert("FName",this.FName,"False","LName",this.LName,"False","Mobile",this.Mobile,"False","Address",this.Address,"False","Email",this.Email,"False","Whatsapp",this.Whatsapp,"False","Status",$"{this.Status}","True","OffersNum",$"{this.OffersNum}","True","WorksNum",$"{this.WorksNum}","True","IndextionsNum",$"{this.IndextionsNum}","True");
            return Inserted;
        }

        public bool Modify()
        {
            string S = "";
            if (!string.IsNullOrEmpty(FName))
            {
                bool Updated = DB.Update("ID", $"{this.ID}", "True","FName",this.FName,"False");
                if (Updated) { S += "T"; }
                else { S += "F"; }
            }
            if (!string.IsNullOrEmpty(LName))
            {
                bool Updated = DB.Update("ID", $"{this.ID}", "True", "LName", this.LName, "False");
                if (Updated) { S += "T"; }
                else { S += "F"; }
            }
            if (!string.IsNullOrEmpty(Mobile))
            {
                bool Updated = DB.Update("ID", $"{this.ID}", "True", "Mobile", this.Mobile, "False");
                if (Updated) { S += "T"; }
                else { S += "F"; }
            }
            if (!string.IsNullOrEmpty(Address))
            {
                bool Updated = DB.Update("ID", $"{this.ID}", "True", "Address", this.Address, "False");
                if (Updated) { S += "T"; }
                else { S += "F"; }
            }
            if (!string.IsNullOrEmpty(Email))
            {
                bool Updated = DB.Update("ID", $"{this.ID}", "True", "Email", this.Email, "False");
                if (Updated) { S += "T"; }
                else { S += "F"; }
            }
            if (!string.IsNullOrEmpty(Whatsapp))
            {
                bool Updated = DB.Update("ID", $"{this.ID}", "True", "Whatsapp", this.Whatsapp, "False");
                if (Updated) { S += "T"; }
                else { S += "F"; }
            }
            if (S.Contains('F')) 
            {
                return false;
            }
            return true;
        }

        public bool Remove()
        {
            bool Delted = DB.Delete("ID", $"{this.ID}", "True","All");
            if (Delted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ShowOne()
        {
            DataTable dt = new DataTable();
            dt = DB.SelectOne("ID",$"{this.ID}","true");
            return dt;
        }

        public DataTable ShowAll()
        {
            DataTable dt = new DataTable();
            dt = DB.Select("all");
            return dt;
        }

        public DataTable Search(string S)
        {
            DataTable dt = new DataTable();
            dt = DB.SelectLike(S,"FName");
            return dt;
        }
    }
}
