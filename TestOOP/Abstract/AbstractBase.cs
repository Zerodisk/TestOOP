using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public abstract class AbstractBase
    {
        public virtual int add(int a, int b)
        {
            return a + b;
        }

        public abstract int substract(int a, int b);
    }
}
