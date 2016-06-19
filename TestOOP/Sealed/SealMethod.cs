using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public class SealMethod : TestVirtual 
    {
        public override int add(int a, int b)
        {
            return a + b + 1;
        }

        //this is complier-error
        /*
        public sealed override int substract(int a, int b)
        {
            return -44;
        }
        */
        
        //sealed method can be used with override only, multipy was override from parent class: TestVirtual
        //   so this will make sure to NOT allow overrride again
        public sealed override int multipy(int a, int b)
        {
            return a * b * 2;
        }
        
        
    }
}
