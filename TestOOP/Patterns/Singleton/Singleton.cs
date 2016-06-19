using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Singleton
{
    public class Singleton
    {
        private static Singleton instant;

        private Singleton()
        {

        }

        public static Singleton Instant
        {
            get
            {
                if (instant == null)
                {
                    instant = new Singleton();
                }
                return instant;
            }
        }

        public string getTest()
        {
            return "Hello world";
        }

    }
}
