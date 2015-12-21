﻿using System;
using HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Subject_Implementations;
using HeadFirstDesignPatterns.WeatherStation.Concrete_Classes.Observer_and_Display_Implementations;

namespace HeadFirstDesignPatterns.WeatherStation.Driver_Classes {
    class WeatherStation {
        public static void Main(string[] args) {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadLine();
        }
    }
}
