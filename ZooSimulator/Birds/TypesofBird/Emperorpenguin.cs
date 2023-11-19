using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator.Birds.TypesofBird
{
    internal class Emperorpenguin : Bird
    {
        public Emperorpenguin(IFly flytype) : base(flytype)
        {
        }
    }
}
