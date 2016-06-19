using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Decorator
{
    public class Mocha : BeverageBase
    {
        private BeverageBase beverage;

        public Mocha(BeverageBase beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + ", Mocha"; }
        }

        public override double cost()
        {
            return beverage.cost() + 0.2;
        }
    }
}
