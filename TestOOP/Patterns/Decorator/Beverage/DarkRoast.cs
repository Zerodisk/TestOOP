using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Decorator
{
    public class DarkRoast : BeverageBase
    {
        public DarkRoast()
        {
            base.description = "Dark Roast Coffee";
        }

        public override double cost()
        {
            return 0.99;
        }
    }
}
