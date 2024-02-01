using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Workshop_System.App_Class
{
    internal class RegexHelper
    {
        private Dictionary<string, string> MyPatterns = new Dictionary<string, string>();
        public RegexHelper()
        {
            MyPatterns.Add("Name", @"^[A-Za-z]+$");
            MyPatterns.Add("Mobile", @"(\+2)?0{1}(10|11|12|15)\d{8}$";
            MyPatterns.Add("Email", @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }
        public bool Matches(string Text, string Type)
        {
            if (MyPatterns.Keys.Contains(Type))
            {
                Regex regex = new Regex(MyPatterns[Type]);
                return regex.IsMatch(Text);
            }
            else
            {
                return false;
            }
        }
        public void AddNewPattern(string typename , string thepattern)
        {
            MyPatterns.Add(typename,thepattern);
        }
    }
}
