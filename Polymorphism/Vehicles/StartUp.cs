using Vehicles.Core;
using Vehicles.Core.Interfaces;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IRead reader = new ConsoleRead();
            IWrite writer = new ConsoleWrite();
            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}