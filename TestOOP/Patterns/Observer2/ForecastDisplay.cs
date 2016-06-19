using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Observer2
{
    public class ForecastDisplay : IDisplayElement, IObserver<WeatherData>
    {
        private float currentPressure = 29.92f;
        private float lastPressure;

        public ForecastDisplay(IObservable<WeatherData> provider)
        {
            if (provider != null)
                provider.Subscribe(this);
        }

        public void display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        public void OnNext(WeatherData weather)
        {
            lastPressure = currentPressure;
            this.currentPressure = weather.Pressure;
            display();
        }

        public void OnCompleted()
        {
            Console.WriteLine("On Complete");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("On Error");
        }

        
    }
}
