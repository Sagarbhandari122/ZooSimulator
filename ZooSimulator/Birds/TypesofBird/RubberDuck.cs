using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator.Birds.TypesofBird
{
    internal class RubberDuck : Bird
    {
        public RubberDuck(IFly flytype) : base(flytype)
        {
        }
    }
}
