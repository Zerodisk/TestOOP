using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public class VirtualBase
    {
        //this method, the derived class can be overrided
        public virtual int add(int a, int b)
        {
            return a + b;
        }

        public int substract(int a, int b)
        {
            return a - b;
        }

        public virtual int multipy(int a, int b)
        {
            return a * b;
        }

        //below will cause complie-error, abstract method need to be with abstract class
        //public abstract int multipy(int a, int b);
    }
}
