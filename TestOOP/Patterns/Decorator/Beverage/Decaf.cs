using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Decorator
{
    public class Decaf : BeverageBase
    {
        public Decaf()
        {
            base.description = "Decaf Coffee";
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}
