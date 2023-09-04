using CollectionHierarchy.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Model
{
    public class MyList : AddRemoveCollection, IMyList
    {
        public override string Remove()
        { 
            //if (collection.Any())
            //    {
                   string removedItem = collection[0];
                 collection.RemoveAt(0);
                 return removedItem;
              
        }
        public int Used { get { return collection.Count; } }
    }
}
