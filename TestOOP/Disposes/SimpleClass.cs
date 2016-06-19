using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public class SimpleClass : IDisposable
    {
        ~SimpleClass()
        {
            Console.WriteLine("Byeee.... object is ~~~~SimpleClass");
        }

        public void Dispose()
        {
            Console.WriteLine("Byeee.... object is Dispose()");
        }

        public string returnA()
        {
            int i = 12;
            object o = 12;
            decimal a = 12;
            double d = 12;
            byte b = 12;
            string s = "12";

            return "AAA";
        }


        
    }
}
