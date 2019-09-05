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
        
        public void TotalCustomers(Customer customers)
        {

            customers.HowManyCustomers(CurrentWeather);
            customers.ChanceOfSale(CurrentWeather);
        }
        
        public int Randomizer(int min, int max)
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(min, max);
            return RandomNumber;

        }
      
        
      



    }
}
