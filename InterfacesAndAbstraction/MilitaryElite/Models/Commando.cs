using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly ICollection<IMission> missions;
        public Commando(int id, string firstName, string lastName, Corps corps,ICollection<IMission> missions) : base(id, firstName, lastName, corps)
        {
            this.missions = missions;
        }

        public IReadOnlyCollection<IMission> Missions { get { return (IReadOnlyCollection<IMission>)missions; } }
    }
}
