using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator.Behaviors
{
    internal class Slides : IFly
    {
        public void Fly()
        {
            Console.WriteLine("*SLIDES BY ITS BELLY*");
        }
    }
}
