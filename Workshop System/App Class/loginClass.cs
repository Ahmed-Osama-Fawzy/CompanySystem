using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_System.App_Class
{
    internal class loginClass
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public int BranchID { get; set; }

        public DataBase DB = new DataBase("Validation", "Users");

        public bool SearchAccount()
        {
            DataTable Values = DB.Select("Username", "Password");
            bool Finded = false;
            for (int i = 0; i < Values.Rows.Count; i++)
            {
                DataRow Row = Values.Rows[i];
                string Username = (string)Row["Username"];
                string Password = (string)Row["Password"];

                if (this.Username == Username && this.Password == Password && BranchID == 1)
                {
                    Finded = true;
                }
            }
            return Finded;
        }

    }
}
