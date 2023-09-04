using CollectionHierarchy.Core.Interfaces;
using CollectionHierarchy.IO;
using CollectionHierarchy.IO.Interfaces;
using CollectionHierarchy.Model;
using CollectionHierarchy.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IAddCollection addCollection;
        private IAddRemoveCollection addRemoveCollection;
        private IMyList myList;
        public Engine(IReader reader,IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            addCollection = new AddCollection();
            addRemoveCollection = new AddRemoveCollection();
            myList = new MyList();
        }
        public void Run()
        {
            string[] input = reader.ReadLine().Split(' ');
            StringBuilder ouputAddCollection = new StringBuilder();
            StringBuilder ouputAddRemoveCollection = new StringBuilder();
            StringBuilder ouputMyList = new StringBuilder();
            for (int i=0;i<input.Length; i++)
            {
                ouputAddCollection
                    .Append(addCollection.Add(input[i]))
                    .Append(' ');
                ouputAddRemoveCollection
                    .Append(addRemoveCollection.Add(input[i]))
                    .Append(' ');
                ouputMyList
                    .Append(myList.Add(input[i]))
                    .Append(' ');
            }
            int removeOperations = int.Parse(reader.ReadLine());
            StringBuilder removeAddRemoveCollection = new StringBuilder();
            StringBuilder removeMyList = new StringBuilder();
            for (int i = 0; i < removeOperations; i++)
            {
                removeAddRemoveCollection
                    .Append(addRemoveCollection.Remove())
                    .Append(' ');
                removeMyList
                    .Append(myList.Remove())
                    .Append(' ');

            }
            writer.WriteLine(ouputAddCollection.ToString());
            writer.WriteLine(ouputAddRemoveCollection.ToString());
            writer.WriteLine(ouputMyList.ToString());
            writer.WriteLine(removeAddRemoveCollection.ToString());
            writer.WriteLine(removeMyList.ToString());
        }
    }
}
