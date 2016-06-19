using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Observer
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private ISubject weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
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

        public void update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            display();
        }
    }
}
