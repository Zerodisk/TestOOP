using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public class TestVirtual : VirtualBase 
    {
        int a = 5;
        int b = 2;
        public int resultA;
        public int resultB;

        public override int add(int a, int b)
        {
            return a + b + 255;
        }

        // this is still override method substract but not recommended
        /*
        public int substract(int a, int b)
        {
            return -99;
        }
        */

        public TestVirtual()
        {
            resultA = add(a, b);        //calling the override
            resultB = substract(a, b);  //calling the base class's method
        }
        
    }
}
