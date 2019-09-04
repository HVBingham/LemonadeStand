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
        int ForeCastedTemp;
        string ForeCastedClearity;
        public Weather()
        {
            SkyClearity= new List<string>();
            SkyClearity.Add("Sunny");
            SkyClearity.Add("OverCast");
            SkyClearity.Add("Rainy");
            SkyClearity.Add("Cloudy");
            SkyClearity.Add("Clear");
            ForeCastedTemp = FindHeat(55, 98);
            ForeCastedClearity = FindClearity(SkyClearity);
            


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
        public int Randomizer(int min, int max)
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(min, max);
            return RandomNumber;

        }
        public void ForcastedWeather ()
        {
            Console.WriteLine("Todays forcast is"+ForeCastedTemp +" Degrees and " +ForeCastedClearity);
        }
        public int ActualTempurature()
        {
            
            int TempVariance = Randomizer(-3, 3);
            int ActualTemp = ForeCastedTemp + TempVariance;
            return ActualTemp;
            
        }
        public void DisplayActual()
        {
        }        
        






    }
}
