using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator.Behaviors
{
    internal class NoFly : IFly
    {
        public void Fly() 
        {
            Console.WriteLine("*HIDES HEAD IN THE SAND AS IT CANNOT FLY*");
        }
    }
}
