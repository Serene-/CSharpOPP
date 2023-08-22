using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Soldier,ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName,Corps corps) : base(id, firstName, lastName)
        {
        }

        public Corps corps { get; private set; }
    }
}
