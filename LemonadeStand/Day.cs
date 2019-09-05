using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        Recipe newRecipe;
        double DaysProfit;
        Weather CurrentWeather;
        double lemonadePrice;

        public Day()
        {
            newRecipe = new Recipe();
            CurrentWeather = new Weather();
            DaysProfit = 0;


        }
        public void SetRecipe()
        {
            newRecipe.SetRecipe();
        }

      
        public void SetCupPrice()
        {
            Console.WriteLine("How much would you like to charge per cup for lemonade today?");
            lemonadePrice = double.Parse(Console.ReadLine());
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
