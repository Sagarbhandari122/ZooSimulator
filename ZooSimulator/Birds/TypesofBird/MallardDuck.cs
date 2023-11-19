using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator.Birds.TypesofBird
{
    internal class MallardDuck : Bird
    {
        
        public string public_palette { get; set; }

        public MallardDuck(IFly flytype) : base(flytype)
        { 
        }
        public static void quack()
        {
            Console.WriteLine("It says quack quack");
        }

        public static void swim()
        {
            Console.WriteLine("It can swim");
        }

    }
}
