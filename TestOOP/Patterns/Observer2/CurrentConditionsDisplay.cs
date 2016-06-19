using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Observer2
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver<WeatherData>
    {
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(IObservable<WeatherData> provider)
        {
            if (provider != null)
                provider.Subscribe(this);
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature
                                + "F degrees and " + humidity + "% humidity");
        }

        public void OnNext(WeatherData weather)
        {
            temperature = weather.Temperature;
            humidity = weather.Humidity;
            display();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("On Error");
        }

        public void OnCompleted()
        {
            Console.WriteLine("On Complete");
        }

    }
}
