using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator.Behaviors
{
    internal class Floats : IFly
    {
        public void Fly()
        {
            Console.WriteLine("*FLOATS IN WATER");
        }
    }
}
