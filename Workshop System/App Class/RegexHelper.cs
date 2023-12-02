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
            MyPatterns.Add("Name", "^[A-Za-z]+$");
            MyPatterns.Add("Mobile", @"(\+2)?0(10|11|12|15)[0-9]{8}$");
            MyPatterns.Add("Email", "\\w@(gmail|oulook|hotmail).(com|org|info|io|edu|eg)");
            MyPatterns.Add("FloatNumber", "");
            MyPatterns.Add("IntNumber", "");
            MyPatterns.Add("Address", "[0-9][a-zA-Z]");
            MyPatterns.Add("Normal Text", "");
            MyPatterns.Add("Spicail Text", "");
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
