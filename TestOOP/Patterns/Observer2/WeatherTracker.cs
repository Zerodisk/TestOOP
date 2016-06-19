using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Observer2
{
    public class WeatherTracker : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> observers;

        public WeatherTracker()
        {
            observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return null;
        }

        public void Unsubscribe(IObserver<WeatherData> observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }


        public void UpdateWeather(WeatherData weather)
        {
            foreach (var observer in observers)
            {
                    observer.OnNext(weather);
            }
        }
    }
}
