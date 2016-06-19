﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature
                                + "F degrees and " + humidity + "% humidity");
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }
    }
}
