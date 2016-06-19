using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Strategy
{
    public abstract class Duck
    {

        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

    }
}
