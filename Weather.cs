using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class  Weather
    {
        List<string> SkyClearity;
        

        int TempOfDay;
        string Clearity;
        public Weather()
        {
            SkyClearity= new List<string>();
            SkyClearity.Add("Sunny");
            SkyClearity.Add("OverCast");
            SkyClearity.Add("Rainy");
            SkyClearity.Add("Cloudy");
            SkyClearity.Add("Clear");
        }

        public int FindHeat(int min, int max)
        {
            Random Tempurature = new Random();
            int RandomTemp = Tempurature.Next(min, max);
            return RandomTemp;
            


        }
        public string FindClearity(List<string>SkyClearity)
        {
            Random clearity = new Random();
            int i = clearity.Next(SkyClearity.Count);
            string FinalClearity = SkyClearity[i];
            return FinalClearity;

        }
        public void WeatherForecast()
        {
            TempOfDay = FindHeat(50, 98);
            Clearity = FindClearity(SkyClearity);
            Console.WriteLine("Todays Weather Forecast is "+TempOfDay +" Degrees and " +Clearity  );

            
        }
        public int Randomizer(int min, int max)
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(min, max);
            return RandomNumber;

        }

        public void ActualWeather(List<string> SkyClearity)
        {
            int ForecastedTemp =FindHeat(50, 95);
            int TempVariance = Randomizer(-5, 5);
            int ActualTemp = ForecastedTemp + TempVariance;


        }






    }
}
