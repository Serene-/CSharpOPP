using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        int codeNumber;
        public Spy(int id, string firstName, string lastName,int codeNumber) : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber
        { 
            get { return codeNumber; }
            private set { codeNumber = value; }
        }
    }
}
