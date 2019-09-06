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
        int foreCastedTemp;
        public string clearity;
        public int actualTemp;

        public Day()
        {
            newRecipe = new Recipe();
            CurrentWeather = new Weather();
            DaysProfit = 0;


        }
        public void DisplayForCast()
        {
            foreCastedTemp = CurrentWeather.FindHeat();
            clearity = CurrentWeather.FindClearity();
            Console.WriteLine("The Forcasted Weather For the day is " +clearity +" and " +foreCastedTemp +" Degrees.");
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
       public int ActualWeather()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(-3, 3);
            actualTemp = RandomNumber + foreCastedTemp;
            Console.WriteLine("It's " +actualTemp +" degrees and " +clearity);
            return actualTemp;

        }
    
       
       
       
        

   
        
      



    }
}
