using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public Smartphone()
        {

        }
        public string Browsing(string url)
        {
            foreach(char ch in url)
            {
                if (Char.IsDigit(ch)) return "Ivalid URL!";
            }
            return String.Format($"Browsing: {url}!");
        }

        public string Calling(string number)
        {
            int num;
            if (Int32.TryParse(number,out num))
            {
                return String.Format($"Calling... {number}");
            }
            else return "Invalid number!";
        }
    }
}
