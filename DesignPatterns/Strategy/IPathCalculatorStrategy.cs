using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal interface IPathCalculatorStrategy
    {
        void findPath(string fromPath, string toPath);
    }
}
