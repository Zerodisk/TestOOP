using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Decorator
{
    public abstract class BeverageBase
    {
        protected string description = "unknown beverage";

        public virtual string Description
        {
            get { return description; }
        }

        public abstract double cost();
    }
}
