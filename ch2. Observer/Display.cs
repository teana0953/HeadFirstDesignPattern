using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2.Observer
{
    public class CurrentConditionsDisplay:IObserver,IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine(string.Format($"Current conditions: {temperature} F degrees and {humidity}% humidity"));
        }
    }

    public class StatisticsDisplay : IObserver, IDisplayElement
    {

        #region Members
        private float maxTemp = 0.0f;
        private float minTemp = 200;

        private float temperatureSum = 0.0f;
        private int numReadings = 0;
        private ISubject weatherData;
        #endregion

        public int NumberOfReadings { get {return numReadings; } }

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        #region IDisplayElement members
        public void display()
        {
            Console.WriteLine(string.Format($"Avg/Max/Min temperature = {RoundFloatToString(temperatureSum / numReadings)}F/ {maxTemp}F/ {minTemp}F"));
        }
        #endregion

        #region IObserver members
        public void update(float temperature, float humidity, float pressure)
        {
            temperatureSum += temperature;
            numReadings++;
            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }
            display();
        } 
        #endregion

        public static string RoundFloatToString(float floatToRound)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            return floatToRound.ToString("F", cultureInfo);
        }
    }

    public class ForecastDisplay:IObserver,IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private ISubject weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        #region IDisplayElement members
        public void display()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Forecast: ");

            if (currentPressure > lastPressure)
                sb.Append("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                sb.Append("More of the same");
            else if (currentPressure < lastPressure)
                sb.Append("Watch out for cooler, rainy weather");

            Console.WriteLine(sb.ToString());
        }
        #endregion

        #region IObservers Members
        public void update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            display();
        } 
        #endregion


    }

}
