using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICall
    {
        public StationaryPhone()
        {

        }
        public string Calling(string number)
        {
            int num;
            if (Int32.TryParse(number,out num))
            {
                return String.Format($"Dialing... {number}");
            }
            else return "Invalid number";
        }
    }
    
}
