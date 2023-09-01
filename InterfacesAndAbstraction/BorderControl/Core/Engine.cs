using BorderControl.Core.Interfaces;
using BorderControl.IO.Interfaces;
using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Core
{
    public class Engine : IEngine
    {
        private readonly IWriter writer;
        private readonly IReader reader;
        private ICollection<IIdentity> citizens;
        public Engine(IReader reader,IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            citizens = new HashSet<IIdentity>();
        }
        public void Run()
        {
            string command = reader.ReadLine();
            IIdentity citizen;
            while(command!="End")
            {
                string[] args = command.Split(' ');
                if (args.Length == 2)
                {
                    citizen = new Robot(args[0], args[1]);
                    citizens.Add(citizen);
                }
                else
                {
                    citizen = new Citizen(args[0], int.Parse(args[1]), args[2]);
                    citizens.Add(citizen);
                }
                command = reader.ReadLine();
            }
            string lastDigits = reader.ReadLine();
            writer.WriteLine(CheckingFakeIds(lastDigits));
        }
        public string CheckingFakeIds(string lastDigits)
        {
            StringBuilder sb = new StringBuilder();
            foreach(IIdentity citizen in citizens)
            {
                if (citizen.Id.EndsWith(lastDigits)) sb.AppendLine(citizen.Id);
            }
            return sb.ToString().Trim();
        }
    }
}
