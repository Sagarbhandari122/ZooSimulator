using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Behaviors.abstractions;

namespace ZooSimulator.Birds
{
    public abstract class Bird
    {
        protected IFly flytype;

        public Bird(IFly flytype) 
        {
            this.flytype = flytype;
        }

        public string Name { get; set; }
        public string Color { get; set; }

        public float Beak_length { get; set; }

        public void fly()
        {
            flytype.Fly();
        }

        public void setfly(IFly flytype)
        {
            this.flytype = flytype;
        }
    }
}
