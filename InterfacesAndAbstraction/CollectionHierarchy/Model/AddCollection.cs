using CollectionHierarchy.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Model
{
    public class AddCollection : IAddCollection
    {
        protected List<string> collection;
        public AddCollection()
        {
            collection = new List<string>();
        }
        public virtual int Add(string element)
        {
            collection.Add(element);
            return collection.Count - 1;
        }
    }
}
