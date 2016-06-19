using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public class TestProtected : ProtectBase 
    {
        public int result;

        public TestProtected()
        {
            result = add(5, 3);
        }
    }
}
