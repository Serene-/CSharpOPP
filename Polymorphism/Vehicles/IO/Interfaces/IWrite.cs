﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.IO.Interfaces
{
    public interface IWrite
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
