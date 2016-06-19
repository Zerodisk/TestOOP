using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Observer
{
    public interface IObserver
    {
        void update(float temperature, float humidity, float pressure);
    }
}
