using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral :Private, ILieutenantGeneral
    {
        private readonly ICollection<IPrivate> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary,ICollection<IPrivate> privates) : base(id, firstName, lastName, salary)
        {
           this.privates = privates;
        }

        public IReadOnlyCollection<IPrivate> Privates { get { return (IReadOnlyCollection<IPrivate>)privates; } }
    }
}
