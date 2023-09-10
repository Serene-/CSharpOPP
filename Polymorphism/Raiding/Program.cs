using Raiding.Core;
using Raiding.Core.Interfaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWrite writer = new ConsoleWriter();
            IRead reader = new ConsoleReader();
            IHeroFactory heroFactory = new HeroFactory();
            IEngine engine = new Engine(reader,writer,heroFactory);
            engine.Run();
        }
    }
}