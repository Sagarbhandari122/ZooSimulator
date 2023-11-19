using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator.Birds.TypesofBird
{
    internal class Baldeagle : Bird
    {
        public float Speed { set; get; }
        public float vision_range { set; get; }
        public Baldeagle(IFly flytype) : base(flytype)  
        {
        }
        public static void Perch()
        {
            Console.WriteLine("It is perching in a tree");

        }

        public static void SearchForPray()
        {
            Console.WriteLine("It is searching for pray");
        }
    }

}
