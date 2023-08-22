using MilitaryElite.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        public Engine(IReader reader,IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
           
        }
    }
}
