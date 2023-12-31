﻿using BorderControl.Core;
using BorderControl.Core.Interfaces;
using BorderControl.IO;
using BorderControl.IO.Interfaces;

namespace BorderControl
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}