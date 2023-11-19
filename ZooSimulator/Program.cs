using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Birds.TypesofBird;
using ZooSimulator.Birds;
using ZooSimulator.Behaviors;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            // First let's make some behaviours of birds.
            IFly flapflight = new FlapWings();
            IFly slide = new Slides();
            IFly nofly = new NoFly();
            IFly floats = new Floats();

            /*List<Bird> birdList = new List<Bird>();
            birdList.Add(new Baldeagle (flapflight));
            birdList.Add(new MallardDuck(flapflight));
            birdList.Add(new Ostrich(nofly));
            birdList.Add(new Emperorpenguin(slide));
            birdList.Add(new RubberDuck(floats));*/

            //Creating a birdList 
            List<Bird> birdList = new List<Bird>
            {
                new MallardDuck(flapflight) { Name = "MallardDuck", Color = "White" },
                new Baldeagle(flapflight) { Name = "Bald Eagle's", Color = "Black,White and Grey" },
                new Ostrich(nofly) { Name = "Fast Ostrich", Color = "Brown" },
                new Emperorpenguin(slide) { Name = "Emperor Penguin", Color = "Black and White" },
                new RubberDuck(floats) { Name = "Rubber Duck's", Color = "Yellow" }
            };

            Console.WriteLine("Number of birds in the simulation: {0} ", birdList.Count);
            foreach (var bird in birdList)
            {
                Console.Write("Here is the {0} movement behavior: ", bird.Name);
                bird.fly();
            }

                
        }
    }
}
