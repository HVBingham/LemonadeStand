using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {

        double DaysProfit;
        Weather CurrentWeather;

        public Day()
        {
            CurrentWeather = new Weather();
            DaysProfit = 0;


        }
        public void TotalCustomers()
        {
        }
        
        public int Randomizer(int min, int max)
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(min, max);
            return RandomNumber;

        }
        //public void DaysWeather()
        //{
        //    int fHeat = ForecastedHeat(CurrentWeather);
        //    string fClearity = ForecastedClearity(CurrentWeather);
           
        //    Console.WriteLine("Todays forecast is " +fClearity +" and " +fHeat +" Degrees.");

        //    int rnd = Randomizer(-3, 3);
        //    int dayHeat = fHeat + rnd;

        //    Console.WriteLine("Todays weather is " +fClearity +" and " +dayHeat +" Degrees.");
            
        //}
        
        
      



    }
}
