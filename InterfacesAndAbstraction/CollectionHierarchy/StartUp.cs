using CollectionHierarchy.Core;
using CollectionHierarchy.Core.Interfaces;
using CollectionHierarchy.IO;
using CollectionHierarchy.IO.Interfaces;

namespace CollectionHierarchy
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            IReader reader = new ConsoleReader();
            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}