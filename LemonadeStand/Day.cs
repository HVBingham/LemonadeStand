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
        List<Customer> Customers;

        public Day()
        {
            Customers = new List<Customer>();
            newRecipe = new Recipe();
            CurrentWeather = new Weather();
            DaysProfit = 0;


        }
        public void DisplayForCast()
        {
            foreCastedTemp = CurrentWeather.FindHeat();
            clearity = CurrentWeather.FindClearity();
            UserInterface.DisplayDayForecast(clearity, foreCastedTemp);
        }
        public void NeedToGOToStore(string name, Player player)
        {
            UserInterface.NeedForStore(name);
            String userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "yes")
            {
               VistStore(player);
            }
            //ToDo add and else statement so that they can play game with supplies they have.
        }
        public void VistStore(Player player)
        {
            Store Walmart = new Store();
            UserInterface.DisplayStoreWelcome();
            player.PurchaseItems(Walmart);
        }



        public void SetRecipe()
        {
            newRecipe.SetRecipe();
        }

      
        public void SetCupPrice()
        {
            UserInterface.CupsPrice();
            lemonadePrice = double.Parse(Console.ReadLine());
        }
       public int ActualWeather()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(-3, 3);
            actualTemp = RandomNumber + foreCastedTemp;
            UserInterface.DisplayActualWeather(actualTemp, clearity);
            return actualTemp;

        }
        
        //public int GetCustomers()
        //{

        //}
           

        
       
       
       
        

   
        
      



    }
}
