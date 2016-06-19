using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Decorator
{
    public class Milk : BeverageBase
    {
        private BeverageBase beverage;

        public Milk(BeverageBase beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + ", Milk"; }
        }

        public override double cost()
        {
            return beverage.cost() + 0.1;
        }

         
    }
}
