using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Strategy
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine(" ---- slient mute mode -----");
        }
    }
}
