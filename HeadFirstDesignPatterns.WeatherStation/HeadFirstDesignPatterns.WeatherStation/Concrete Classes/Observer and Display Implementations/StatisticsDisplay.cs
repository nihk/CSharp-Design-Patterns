﻿using System;
using HeadFirstDesignPatterns.WeatherStation.Interfaces;

namespace HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations {
    class StatisticsDisplay : Observer, DisplayElement {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData) {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure) {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp) {
                maxTemp = temp;
            }

            if (temp < minTemp) {
                minTemp = temp;
            }

            Display();
        }

        public void Display() {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
                + "/" + maxTemp + "/" + minTemp);
        }
    }
}
