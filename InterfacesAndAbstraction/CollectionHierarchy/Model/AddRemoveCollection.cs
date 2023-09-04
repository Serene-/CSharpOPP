using CollectionHierarchy.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Model
{
    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
       

        public override int Add(string element)
        {
            int index = 0;
            collection.Insert(index, element);
            return index;
        }
        public virtual string Remove()
        {
            string removedItem = collection[collection.Count - 1];
            if(collection.Count>0) collection.RemoveAt(collection.Count - 1);
            return removedItem;
        }
    }
}
