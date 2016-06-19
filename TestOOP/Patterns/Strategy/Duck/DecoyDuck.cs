using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Strategy
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackLound();
        }

        public override void Display()
        {
            Console.WriteLine("I am Decoy Duck");
        }
    }
}
