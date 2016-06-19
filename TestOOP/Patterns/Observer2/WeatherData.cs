using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Observer2
{
    public class WeatherData 
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public float Temperature
        {
            get { return this.temperature; }
        }

        public float Humidity
        {
            get { return this.humidity; }
        }

        public float Pressure
        {
            get { return this.pressure; }
        }

    }
}
