using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Workshop_System.App_Class
{
    internal class MainData
    {
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string EnglishOwnerName { get; set; }
        public string ArabicOwnerName { get; set; }
        public string CurrentDate { get; set; }
        public string CurrentDay { get; set; }
        public string CurrentTime { get; set; }
        public MainData()
        {
            EnglishName = "Elesraa For Aluminuim Products";
            ArabicName = "الإسراء لاعمال الألوميتال";
            EnglishOwnerName = "Osama Fawzy";
            ArabicOwnerName = "أسامة فوزي";
            CurrentDate = DateTime.Now.ToString("dd:MM:yyyy");
            CurrentDay = DateTime.Now.DayOfWeek.ToString();
            CurrentTime = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
