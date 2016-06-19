using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber Duck");
        }
    }
}
