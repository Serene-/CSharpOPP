using Raiding.Core.Interfaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models;
using Raiding.Models.Interfaces;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IRead reader;
        private readonly IWrite writer;
        private readonly IHeroFactory heroFactory;
        private List<IBaseHero> raidGroup;
        public Engine(IRead reader,IWrite writer,IHeroFactory heroFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.heroFactory = heroFactory;
            raidGroup = new List<IBaseHero>();
        }
        public void Run()
        {
            int n = int.Parse(reader.ReadLine());
            for(int i=0;i<n;i++)
            {
                string heroName = reader.ReadLine();
                string heroType = reader.ReadLine();
                try
                {
                    raidGroup.Add(heroFactory.CreateHero(heroName, heroType));
                }
                catch(ArgumentException)
                {
                    i--;
                }
            }
            int bossPower = int.Parse(reader.ReadLine());
            PrintHeroes();
            int raidGroupPower=0;
            foreach (var hero in raidGroup)
            {
                raidGroupPower += hero.Power;
            }
            if (raidGroupPower >= bossPower) writer.WriteLine("Victory!");
            writer.WriteLine("Defeat...");
        }
        public void PrintHeroes()
        {
            foreach(var hero in raidGroup)
            {
                writer.WriteLine(hero.CastAbility());
            }
        }
    }
}
